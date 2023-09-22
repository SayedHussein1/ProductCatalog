#pragma checksum "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\Components\LangaugeSelector\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45f3714c4332fe6592e02683c91944132b6b7833"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LangaugeSelector_Default), @"mvc.1.0.view", @"/Views/Shared/Components/LangaugeSelector/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45f3714c4332fe6592e02683c91944132b6b7833", @"/Views/Shared/Components/LangaugeSelector/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66fa6860aa4fcba15e46a75672ed7a4ca414deba", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_LangaugeSelector_Default : App.Application.Razor.NopRazorPage<IEnumerable<LanguageModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\Components\LangaugeSelector\Default.cshtml"
  
    var returnUrl = string.IsNullOrEmpty(Context.Request.Path) ? "~/" : $"~{Context.Request.Path.Value}{Context.Request.QueryString}";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\Components\LangaugeSelector\Default.cshtml"
 foreach (var item in Model)
{
    if (CommonHelper.WorkingLanguage.Id != item.Id)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 296, "\"", 382, 1);
#nullable restore
#line 10 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\Components\LangaugeSelector\Default.cshtml"
WriteAttributeValue("", 303, Url.Action("SetLanguage","Home",new { langid= item.Id , returnUrl= returnUrl}), 303, 79, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-lng=\"");
#nullable restore
#line 10 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\Components\LangaugeSelector\Default.cshtml"
                                                                                                                             Write(item.LanguageCulture);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n            <i class=\"icon-flag3\"></i>\n            ");
#nullable restore
#line 12 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\Components\LangaugeSelector\Default.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </a>\n");
#nullable restore
#line 14 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\Components\LangaugeSelector\Default.cshtml"
    }

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LanguageModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591