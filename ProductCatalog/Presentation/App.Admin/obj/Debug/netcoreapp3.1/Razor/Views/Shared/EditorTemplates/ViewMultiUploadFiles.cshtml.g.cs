#pragma checksum "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\ViewMultiUploadFiles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "040c1b78d56638cab706f7766d7de7d859e80d1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_ViewMultiUploadFiles), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/ViewMultiUploadFiles.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"040c1b78d56638cab706f7766d7de7d859e80d1d", @"/Views/Shared/EditorTemplates/ViewMultiUploadFiles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66fa6860aa4fcba15e46a75672ed7a4ca414deba", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_EditorTemplates_ViewMultiUploadFiles : App.Application.Razor.NopRazorPage<List<AttachmentsViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\ViewMultiUploadFiles.cshtml"
  
    var Id = ViewData["Id"] as string;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\ViewMultiUploadFiles.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-lg-12\">\n        <div class=\"form-group row\">\n            <div class=\"col-lg-12\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 254, "\"", 279, 1);
#nullable restore
#line 11 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\ViewMultiUploadFiles.cshtml"
WriteAttributeValue("", 261, item.thumbnailUrl, 261, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 11 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\ViewMultiUploadFiles.cshtml"
                                                        Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 15 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\ViewMultiUploadFiles.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IJsonHelper Json { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AttachmentsViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591