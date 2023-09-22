using App.Application.Caching;
using App.Application.Framwork;
using App.Application.Interfaces;
using App.Application.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace App.Admin.Areas.Admin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        private readonly ICacheManager _cacheManager;
        private readonly IConfiguration _Configuration;
        private readonly ILanguageSevices _languageService;
        private readonly IInitalizeModelLookups _initalizeModelLookups;
        private readonly ILocaleStringResourceSevices _localeStringResourceSevices;

        public HomeController(ICacheManager cacheManager,
            ILanguageSevices languageService,
            IInitalizeModelLookups initalizeModelLookups,
            ILocaleStringResourceSevices localeStringResourceSevices,
            IConfiguration configuration)
        {
            _languageService = languageService;
            _cacheManager = cacheManager;
            _Configuration = configuration;
            _initalizeModelLookups = initalizeModelLookups;
            _localeStringResourceSevices = localeStringResourceSevices;
        }
        public async Task<IActionResult> Index()
        {
            HomePageModel model = new HomePageModel();
            await _initalizeModelLookups.InitModel(model , "All");

           

            return View(model);
        }
        
        public virtual async Task<IActionResult> SetLanguage(int langid, string returnUrl = "")
        {
            var language = await _languageService.GetById(langid);

            CommonHelper.WorkingLanguage = language;

            //prevent open redirection attack
            if (!Url.IsLocalUrl(returnUrl))
                returnUrl = Url.RouteUrl("Homepage");

            return Redirect(returnUrl);
        }
        [Authorize]
        public IActionResult ClearCash()
        {
            _cacheManager.Clear();

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            string wsUrl = _Configuration["ApiUrl"];
            string Url = wsUrl + "api/Common/ClearAllCash";
            WebRequest webRequest = WebRequest.Create(Url);
            webRequest.GetResponse();
            return RedirectToAction("Index");
        }
    }
}
