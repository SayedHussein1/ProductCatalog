#pragma checksum "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d14f19a2846287a515c3cd56f704bca042562650"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_Picture), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/Picture.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\ProductCatalog\Presentation\App.Admin\Views\_ViewImports.cshtml"
using App.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ProductCatalog\Presentation\App.Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\ProductCatalog\Presentation\App.Admin\Views\_ViewImports.cshtml"
using App.Application.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\ProductCatalog\Presentation\App.Admin\Views\_ViewImports.cshtml"
using App.Application.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\ProductCatalog\Presentation\App.Admin\Views\_ViewImports.cshtml"
using App.Application.Framwork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\ProductCatalog\Presentation\App.Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\ProductCatalog\Presentation\App.Admin\Views\_ViewImports.cshtml"
using App.Application.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
using App.Application.FrameWork;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d14f19a2846287a515c3cd56f704bca042562650", @"/Views/Shared/EditorTemplates/Picture.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66fa6860aa4fcba15e46a75672ed7a4ca414deba", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_EditorTemplates_Picture : App.Application.Razor.NopRazorPage<int>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lastfineuploader/fine-uploader-new.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lastfineuploader/fine-uploader.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
  
    //other variables
    var random = CommonHelper.GenerateRandomInteger();
    var clientId = "picture" + random;
    var picture = await pictureService.GetPictureDataFromCache(Model);
    var extensions = ViewData["extensions"];
    if (extensions == null)
    {
        extensions = "'jpeg', 'jpg', 'gif', 'png','svg'";
    }

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d14f19a2846287a515c3cd56f704bca0425626505866", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d14f19a2846287a515c3cd56f704bca0425626506978", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<div");
            BeginWriteAttribute("id", " id=\"", 587, "\"", 613, 1);
#nullable restore
#line 18 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
WriteAttributeValue("", 592, clientId + "value", 592, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n    ");
#nullable restore
#line 19 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
Write(Html.HiddenFor(x => x));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n<script type=\"text/template\"");
            BeginWriteAttribute("id", " id=\"", 680, "\"", 707, 2);
#nullable restore
#line 22 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
WriteAttributeValue("", 685, clientId, 685, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 696, "-validation", 696, 11, true);
            EndWriteAttribute();
            WriteLiteral(">\n    <div class=\"qq-uploader-selector qq-uploader\" qq-drop-area-text=\"");
#nullable restore
#line 23 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
                                                                Write(Translate("DragFile").Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
        <div class=""qq-total-progress-bar-container-selector qq-total-progress-bar-container"">
            <div role=""progressbar"" aria-valuenow=""0"" aria-valuemin=""0"" aria-valuemax=""100"" class=""qq-total-progress-bar-selector qq-progress-bar qq-total-progress-bar""></div>
        </div>
        <div class=""qq-upload-drop-area-selector qq-upload-drop-area"" qq-hide-dropzone>
            <span class=""qq-upload-drop-area-text-selector""></span>
        </div>
        <div class=""qq-upload-button-selector qq-upload-button"">
            <div>");
#nullable restore
#line 31 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
            Write(Translate("ChooseFile").Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        </div>\n        <span class=\"qq-drop-processing-selector qq-drop-processing\">\n            <span>");
#nullable restore
#line 34 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
             Write(Translate("ProcessingFile").Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
            <span class=""qq-drop-processing-spinner-selector qq-drop-processing-spinner""></span>
        </span>
        <ul class=""qq-upload-list-selector qq-upload-list"" aria-live=""polite"" aria-relevant=""additions removals"">
            <li>
                <div class=""qq-progress-bar-container-selector"">
                    <div role=""progressbar"" aria-valuenow=""0"" aria-valuemin=""0"" aria-valuemax=""100"" class=""qq-progress-bar-selector qq-progress-bar""></div>
                </div>
                <span class=""qq-upload-spinner-selector qq-upload-spinner""></span>
                <img class=""qq-thumbnail-selector"" qq-max-size=""100"" qq-server-scale>
                <span class=""qq-upload-file-selector qq-upload-file""></span>
                <span class=""qq-upload-size-selector qq-upload-size""></span>
                <button type=""button"" class=""qq-btn qq-upload-cancel-selector qq-upload-cancel"">");
#nullable restore
#line 46 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
                                                                                           Write(Translate("Cancel").Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n                <button type=\"button\" class=\"qq-btn qq-upload-retry-selector qq-upload-retry\">");
#nullable restore
#line 47 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
                                                                                         Write(Translate("TryAgain").Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n                <button type=\"button\" class=\"qq-btn qq-upload-delete-selector qq-upload-delete\">");
#nullable restore
#line 48 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
                                                                                           Write(Translate("Delete").Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
                <span role=""status"" class=""qq-upload-status-text-selector qq-upload-status-text""></span>
            </li>
        </ul>

        <dialog class=""qq-alert-dialog-selector"">
            <div class=""qq-dialog-message-selector""></div>
            <div class=""qq-dialog-buttons"">
                <button type=""button"" class=""qq-cancel-button-selector"">");
#nullable restore
#line 56 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
                                                                   Write(Translate("Close").Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
            </div>
        </dialog>

        <dialog class=""qq-confirm-dialog-selector"">
            <div class=""qq-dialog-message-selector""></div>
            <div class=""qq-dialog-buttons"">
                <button type=""button"" class=""qq-cancel-button-selector"">");
#nullable restore
#line 63 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
                                                                   Write(Translate("No").Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n                <button type=\"button\" class=\"qq-ok-button-selector\">");
#nullable restore
#line 64 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
                                                               Write(Translate("Yes").Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
            </div>
        </dialog>

        <dialog class=""qq-prompt-dialog-selector"">
            <div class=""qq-dialog-message-selector""></div>
            <input type=""text"">
            <div class=""qq-dialog-buttons"">
                <button type=""button"" class=""qq-cancel-button-selector"">");
#nullable restore
#line 72 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
                                                                   Write(Translate("Cancel").Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n                <button type=\"button\" class=\"qq-ok-button-selector\">");
#nullable restore
#line 73 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
                                                               Write(Translate("Ok").Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n            </div>\n        </dialog>\n    </div>\n</script>\n\n<div");
            BeginWriteAttribute("id", " id=\"", 4019, "\"", 4060, 2);
#nullable restore
#line 79 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
WriteAttributeValue("", 4024, clientId, 4024, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4035, "-fine-uploader-validation", 4035, 25, true);
            EndWriteAttribute();
            WriteLiteral("></div>\n\n<script>\n\n    var ");
#nullable restore
#line 83 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
    Write(clientId);

#line default
#line hidden
#nullable disable
            WriteLiteral("Uploader = new qq.FineUploader({\n        element: document.getElementById(\"");
#nullable restore
#line 84 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
                                      Write(clientId);

#line default
#line hidden
#nullable disable
            WriteLiteral("-fine-uploader-validation\"),\n        template: \'");
#nullable restore
#line 85 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
               Write(clientId);

#line default
#line hidden
#nullable disable
            WriteLiteral("-validation\',\n        request: {\n            endpoint: \'");
#nullable restore
#line 87 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
                   Write(Url.Content("~/Common/AsyncUpload"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'
        },
        thumbnails: {
            placeholders: {
                waitingPath: '/lastfineuploader/placeholders/waiting-generic.png',
                notAvailablePath: '/lastfineuploader/placeholders/not_available-generic.png'
            }
        },
        deleteFile: {
            enabled: true,
            forceConfirm: true,
             method: 'POST',
             endpoint: '");
#nullable restore
#line 99 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
                    Write(Url.Content("~/Common/DeleteFile"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\n        },\n        multiple: false,\n        callbacks: {\n            onSubmitDelete: function (id) {\n                var fileId = $(\"#");
#nullable restore
#line 104 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
                             Write(clientId + "value");

#line default
#line hidden
#nullable disable
            WriteLiteral(" input\").val();\n                this.setDeleteFileParams({ fileId: fileId });\n            },\n            onDeleteComplete: function (id, xhr, isError) {\n                $(\"#");
#nullable restore
#line 108 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
                Write(clientId + "value");

#line default
#line hidden
#nullable disable
            WriteLiteral(" input\").val(\"0\");\n            },\n            onComplete: function (id, name, responseJSON, xhr) {\n                if (responseJSON.success) {\n                    $(\"#");
#nullable restore
#line 112 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
                    Write(clientId + "value");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" input"").val(responseJSON.pictureId);
                }
            }
        },
        validation: {
            //allowedExtensions: ['jpeg', 'jpg', 'txt'],
            //itemLimit: 3,
            sizeLimit: 10485760,// 10mb,
            allowedExtensions: [");
#nullable restore
#line 120 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
                           Write(Html.Raw(extensions));

#line default
#line hidden
#nullable disable
            WriteLiteral("]\n        }\n    });\n\n</script>\n\n");
#nullable restore
#line 126 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
 if (Model > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\n    var ");
#nullable restore
#line 129 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
    Write(clientId);

#line default
#line hidden
#nullable disable
            WriteLiteral("fileObj = ");
#nullable restore
#line 129 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
                        Write(Html.Raw(Json.Serialize(picture)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n    console.log(");
#nullable restore
#line 130 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
           Write(Html.Raw(Json.Serialize(picture)));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\n    var ");
#nullable restore
#line 131 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
    Write(clientId);

#line default
#line hidden
#nullable disable
            WriteLiteral("stringArray = [];\n    ");
#nullable restore
#line 132 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
Write(clientId);

#line default
#line hidden
#nullable disable
            WriteLiteral("stringArray.push(");
#nullable restore
#line 132 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
                            Write(clientId);

#line default
#line hidden
#nullable disable
            WriteLiteral("fileObj);\n\n    ");
#nullable restore
#line 134 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
Write(clientId);

#line default
#line hidden
#nullable disable
            WriteLiteral("Uploader.addInitialFiles(");
#nullable restore
#line 134 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
                                    Write(clientId);

#line default
#line hidden
#nullable disable
            WriteLiteral("stringArray);\n\n</script>\n");
#nullable restore
#line 137 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\Picture.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public App.Application.Interfaces.IAttachmentService pictureService { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUsersService _usersService { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor _httpContextAccessor { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
