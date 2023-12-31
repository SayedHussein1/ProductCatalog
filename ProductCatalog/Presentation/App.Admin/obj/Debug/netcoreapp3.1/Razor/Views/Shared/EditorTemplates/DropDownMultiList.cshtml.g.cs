#pragma checksum "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\DropDownMultiList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3f4a44b284b8732bfcc3dea3b5c0b7ee80d085d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_DropDownMultiList), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/DropDownMultiList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3f4a44b284b8732bfcc3dea3b5c0b7ee80d085d", @"/Views/Shared/EditorTemplates/DropDownMultiList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66fa6860aa4fcba15e46a75672ed7a4ca414deba", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_EditorTemplates_DropDownMultiList : App.Application.Razor.NopRazorPage<string[]>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\DropDownMultiList.cshtml"
  
    var Items = ViewData["List"] as SelectList;
    var Id = ViewData["Id"] as string;
    var Required = ViewData["required"] as string;
    var Placeholder = ViewData["Placeholder"] as string;

#line default
#line hidden
#nullable disable
            WriteLiteral("<select ");
#nullable restore
#line 8 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\DropDownMultiList.cshtml"
         if (Required == "required") { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" required data-fouc");
#nullable restore
#line 8 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\DropDownMultiList.cshtml"
                                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        id=\"");
#nullable restore
#line 9 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\DropDownMultiList.cshtml"
       Write(Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" name=\"");
#nullable restore
#line 9 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\DropDownMultiList.cshtml"
                  Write(Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" multiple=\"multiple\"\n        data-placeholder=\"");
#nullable restore
#line 10 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\DropDownMultiList.cshtml"
                     Write(Placeholder);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n        class=\"form-control form-control-select2-icons\" data-fouc>\n");
#nullable restore
#line 12 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\DropDownMultiList.cshtml"
     foreach (var item in Items.Where(s=> s.Value != "0"))
    {
        if (Model != null && Model.Contains(item.Value))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3f4a44b284b8732bfcc3dea3b5c0b7ee80d085d6267", async() => {
                WriteLiteral("\n                ");
#nullable restore
#line 17 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\DropDownMultiList.cshtml"
           Write(item.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\DropDownMultiList.cshtml"
               WriteLiteral(item.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 19 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\DropDownMultiList.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3f4a44b284b8732bfcc3dea3b5c0b7ee80d085d8713", async() => {
                WriteLiteral("\n                ");
#nullable restore
#line 23 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\DropDownMultiList.cshtml"
           Write(item.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\DropDownMultiList.cshtml"
               WriteLiteral(item.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 25 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\EditorTemplates\DropDownMultiList.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</select>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string[]> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
