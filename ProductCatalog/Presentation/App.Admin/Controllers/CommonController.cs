using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Drawing;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.AspNetCore.Hosting;
using App.Application.Interfaces;
using App.Application.FrameWork;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using App.Application.Models;
using App.Application.Model;

namespace App.Admin.Controllers
{
    public class CommonController : Controller
    {
        private readonly IAttachmentService _attachmentService;
        public IConfiguration _Configuration;
        private readonly ILookupSevices _lookupSevices;
        private readonly IUsersService _UsersService;
        private readonly ILocaleStringResourceSevices _localeStringResourceSevices;
        public CommonController(IAttachmentService attachmentService,
            ILookupSevices lookupSevices,
            IUsersService UsersService, ILocaleStringResourceSevices localeStringResourceSevices,
            IConfiguration configuration)
        {
            _attachmentService = attachmentService;
            _Configuration = configuration;
            _lookupSevices = lookupSevices;
            _UsersService = UsersService;
            _localeStringResourceSevices = localeStringResourceSevices;
        }
        public async Task<IActionResult> AsyncUpload()
        {
            //if (!_permissionService.Authorize(StandardPermissionProvider.UploadPictures))
            //    return Json(new { success = false, error = "You do not have required permissions" }, "text/plain");

            //we process it distinct ways based on a browser
            //find more info here http://stackoverflow.com/questions/4884920/mvc3-valums-ajax-file-upload
            var fileName = "";
            var contentType = "";
            var httpPostedFile = Request.Form.Files.FirstOrDefault();
            if (String.IsNullOrEmpty(Request.Form["qqfile"]))
            {
                // IE
                if (httpPostedFile == null)
                    throw new ArgumentException("No file uploaded");

                fileName = Path.GetFileName(httpPostedFile.FileName);
                contentType = httpPostedFile.ContentType;
            }

            var fileBinary = _attachmentService.GetDownloadBits(httpPostedFile);

            var fileExtension = Path.GetExtension(fileName);
            if (!String.IsNullOrEmpty(fileExtension))
                fileExtension = fileExtension.ToLowerInvariant();
            //contentType is not always available 
            //that's why we manually update it here
            //http://www.sfsu.edu/training/mimetype.htm
            if (String.IsNullOrEmpty(contentType))
            {
                switch (fileExtension.ToLower())
                {
                    case ".bmp":
                        contentType = MimeTypes.ImageBmp;
                        break;
                    case ".gif":
                        contentType = MimeTypes.ImageGif;
                        break;
                    case ".jpeg":
                    case ".jpg":
                    case ".jpe":
                    case ".jfif":
                    case ".pjpeg":
                    case ".pjp":
                        contentType = MimeTypes.ImageJpeg;
                        break;
                    case ".png":
                        contentType = MimeTypes.ImagePng;
                        break;
                    case ".tiff":
                    case ".tif":
                        contentType = MimeTypes.ImageTiff;
                        break;
                    default:
                        break;
                }
            }

            var picture = await _attachmentService.InsertPicture(httpPostedFile.Length, fileName, contentType, fileExtension);

            string new_filename = string.Format("{0}_{1}", picture.AttachmentId, fileName);

            string SavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AttachmentFiles",
                new_filename);

            using (var stream = new FileStream(SavePath,
                FileMode.Create))
            {
                httpPostedFile.CopyTo(stream);
            }

            return Json(new
            {
                success = true,
                pictureId = picture.AttachmentId,
                imageContent = "/AttachmentFiles/" + new_filename,
                filename = new_filename,
            });
        }
        public async Task<IActionResult> AsyncUploadApi()
        {
            //if (!_permissionService.Authorize(StandardPermissionProvider.UploadPictures))
            //    return Json(new { success = false, error = "You do not have required permissions" }, "text/plain");

            //we process it distinct ways based on a browser
            //find more info here http://stackoverflow.com/questions/4884920/mvc3-valums-ajax-file-upload
            var fileName = "";
            var contentType = "";
            var httpPostedFile = Request.Form.Files.FirstOrDefault();
            if (String.IsNullOrEmpty(Request.Form["qqfile"]))
            {
                // IE
                if (httpPostedFile == null)
                    throw new ArgumentException("No file uploaded");

                fileName = Path.GetFileName(httpPostedFile.FileName);
                contentType = httpPostedFile.ContentType;
            }

            var fileBinary = _attachmentService.GetDownloadBits(httpPostedFile);

            var fileExtension = Path.GetExtension(fileName);
            if (!String.IsNullOrEmpty(fileExtension))
                fileExtension = fileExtension.ToLowerInvariant();
            //contentType is not always available 
            //that's why we manually update it here
            //http://www.sfsu.edu/training/mimetype.htm
            if (String.IsNullOrEmpty(contentType))
            {
                switch (fileExtension.ToLower())
                {
                    case ".bmp":
                        contentType = MimeTypes.ImageBmp;
                        break;
                    case ".gif":
                        contentType = MimeTypes.ImageGif;
                        break;
                    case ".jpeg":
                    case ".jpg":
                    case ".jpe":
                    case ".jfif":
                    case ".pjpeg":
                    case ".pjp":
                        contentType = MimeTypes.ImageJpeg;
                        break;
                    case ".png":
                        contentType = MimeTypes.ImagePng;
                        break;
                    case ".tiff":
                    case ".tif":
                        contentType = MimeTypes.ImageTiff;
                        break;
                    default:
                        break;
                }
            }

            var picture = await _attachmentService.InsertPicture(httpPostedFile.Length, fileName, contentType, fileExtension);

            string new_filename = string.Format("{0}_{1}", picture.AttachmentId, fileName);

            string SavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AttachmentFiles",
                new_filename);

            using (var stream = new FileStream(SavePath,
                FileMode.Create))
            {
                httpPostedFile.CopyTo(stream);
            }
            var url = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";

            return Json(new
            {
                success = true,
                id = picture.AttachmentId,
                imagePath = url + "/AttachmentFiles/" + new_filename,
                message = "",
            });
        }
    
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordModel model)
        {
            var result = await _UsersService.ForgotPasswordAsync(model.Email);

            if (result == "NotFound")
            {
                return Ok(new ResponseModel
                {
                    IsSuccess = false,
                    Message = _localeStringResourceSevices.GetResource("EmailNotRegistered").ToString(),
                });

            }
            else if (result == "ForgotPasswordConfirmation")
            {
                return Ok(new ResponseModel
                {
                    IsSuccess = false,
                    Message = _localeStringResourceSevices.GetResource("ForgotPasswordConfirmation"),
                });

            }
            return Ok(new ResponseModel
            {
                IsSuccess = true,
                Message = _localeStringResourceSevices.GetResource("UrlSendSuccess").ToString(),
            });
        }
        [HttpPost]
        public IActionResult DeleteFile(int fileId)
        {
            _attachmentService.DeletePicture(fileId);
            return Json(new
            {
                success = true,
            });
        }

    }
}