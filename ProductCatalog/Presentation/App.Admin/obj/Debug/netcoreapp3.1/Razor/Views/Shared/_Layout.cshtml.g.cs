#pragma checksum "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "372a89927f703cd581319bf0dcc6babb661befe3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"372a89927f703cd581319bf0dcc6babb661befe3", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66fa6860aa4fcba15e46a75672ed7a4ca414deba", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : App.Application.Razor.NopRazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ThemeCssScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_LoginPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::App.Application.TagHelpers.ResourcesTagHelper __App_Application_TagHelpers_ResourcesTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html ");
#nullable restore
#line 2 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml"
       if (!CommonHelper.WorkingLanguage.Rtl) { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" lang=\"en\" ");
#nullable restore
#line 2 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml"
                                                                          } else { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" lang=\"ar\" dir=\"rtl\" ");
#nullable restore
#line 2 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml"
                                                                                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral(">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "372a89927f703cd581319bf0dcc6babb661befe37279", async() => {
                WriteLiteral("\n\n    <meta charset=\"utf-8\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\n    <title>");
#nullable restore
#line 8 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 8 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml"
                           Write(Translate("ProductCatalog").Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("  </title>\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "372a89927f703cd581319bf0dcc6babb661befe38153", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    ");
#nullable restore
#line 12 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml"
Write(RenderSection("Styles", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("resources", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "372a89927f703cd581319bf0dcc6babb661befe39566", async() => {
                }
                );
                __App_Application_TagHelpers_ResourcesTagHelper = CreateTagHelper<global::App.Application.TagHelpers.ResourcesTagHelper>();
                __tagHelperExecutionContext.Add(__App_Application_TagHelpers_ResourcesTagHelper);
#nullable restore
#line 14 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml"
__App_Application_TagHelpers_ResourcesTagHelper.Resources = new[] { "SharedResource" };

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("names", __App_Application_TagHelpers_ResourcesTagHelper.Resources, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "372a89927f703cd581319bf0dcc6babb661befe311685", async() => {
                WriteLiteral("\n    <!-- Main navbar -->\n    <div class=\"navbar navbar-expand-md navbar-dark\">\n        <div class=\"navbar-brand\">\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "372a89927f703cd581319bf0dcc6babb661befe312075", async() => {
#nullable restore
#line 21 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml"
                                                                          Write(Translate("ProductCatalog").Text);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

        </div>
        <div class=""d-md-none"">
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbar-mobile"">
                <i class=""icon-tree5""></i>
            </button>
            <button class=""navbar-toggler sidebar-mobile-main-toggle"" type=""button"">
                <i class=""icon-paragraph-justify3""></i>
            </button>
        </div>
        <div class=""collapse navbar-collapse"" id=""navbar-mobile"">
            <ul class=""navbar-nav ml-md-3 mr-md-auto"">
                <li class=""nav-item"">
                    <a class=""navbar-nav-link sidebar-control sidebar-main-toggle d-none d-md-block"">
                        <i class=""icon-paragraph-justify3""></i>
                    </a>
                </li>
            </ul>
            <ul class=""navbar-nav"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "372a89927f703cd581319bf0dcc6babb661befe314690", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </ul>
        </div>
    </div>
    <!-- /main navbar -->
    <!-- Page content -->
    <div class=""page-content"">
        <!-- Main sidebar -->
        <!-- Main sidebar -->
        <div class=""sidebar sidebar-dark sidebar-main sidebar-expand-md"">
            <!-- Sidebar mobile toggler -->
            <div class=""sidebar-mobile-toggler text-center"">
                <a href=""#"" class=""sidebar-mobile-main-toggle"">
                    <i class=""icon-arrow-right8""></i>
                </a>
                -
                <a href=""#"" class=""sidebar-mobile-expand"">
                    <i class=""icon-screen-full""></i>
                    <i class=""icon-screen-normal""></i>
                </a>
            </div>
            <!-- /sidebar mobile toggler -->
            <!-- Sidebar content -->
            <div class=""sidebar-content"">
");
#nullable restore
#line 65 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml"
                 if (User.Identity.IsAuthenticated)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml"
               Write(await Component.InvokeAsync("Menu"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml"
                                                        
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n            <!-- /sidebar content -->\n\n        </div>\n        <!-- /main sidebar -->\n        <!-- /main sidebar -->\n        <!-- Main content -->\n        <div class=\"content-wrapper\">\n            ");
#nullable restore
#line 78 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            <!-- Footer -->
            <div class=""navbar navbar-expand-lg navbar-light"">
                <div class=""text-center d-lg-none w-100"">
                    <button type=""button"" class=""navbar-toggler dropdown-toggle"" data-toggle=""collapse"" data-target=""#navbar-footer"">
                        <i class=""icon-unfold mr-2""></i>
                        ");
#nullable restore
#line 84 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml"
                   Write(Translate("CopyRight").Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </button>\n                </div>\n                <div class=\"navbar-collapse collapse\" id=\"navbar-footer\">\n                    <span class=\"navbar-text\">\n                        ");
#nullable restore
#line 89 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml"
                   Write(Translate("ProductCatalog").Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </span>\n\n                </div>\n            </div>\n            <!-- /footer -->\n        </div>\n        <!-- /main content -->\n    </div>\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "372a89927f703cd581319bf0dcc6babb661befe319144", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    ");
#nullable restore
#line 101 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n");
#nullable restore
#line 103 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml"
     if (TempData["errorMsg"] != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\n            $(document).ready(function () {\n                swal({ title: \'\', text: \"");
#nullable restore
#line 107 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml"
                                    Write(Html.Raw(TempData["errorMsg"]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\", type: \"error\", confirmButtontext: Resources.SharedResource.successfullymsg, timer: 5000 });\n            });\n        </script>\n");
#nullable restore
#line 110 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml"
      
        if (TempData["successMsg"] != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <script type=\"text/javascript\">\n                $(document).ready(function () {\n                    swal({ title: \'\', text: \'");
#nullable restore
#line 116 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml"
                                        Write(Html.Raw(TempData["successMsg"]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\', type: \"success\", confirmButtontext: Resources.SharedResource.successfullymsg, timer: 5000 });\n                });\n            </script>\n");
#nullable restore
#line 119 "F:\ProductCatalog\Presentation\App.Admin\Views\Shared\_Layout.cshtml"
            TempData["successMsg"] = null;
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script>

        $('.summernote').summernote({
            height: 250,   //set editable area's height
        });
        $("".select2"").select2({
            // the following code is used to disable x-scrollbar when click in select input and
            // take 100% width in responsive also
            dropdownAutoWidth: true,
            width: '100%'
        });
        function ShowModal(content) {
            $('.modal-dialog').html(content);
            $('#exampleModalfat').modal();
        }
        function ShowLoading() {
            var $form1 = $('#frmAddEdit');
            if ($form1.valid()) {
                $.blockUI({
                    baseZ: 10000000,
                    // message: ''
                    message: '',
                });
                return true;
            }
        }
        function blockUI() {
            $.blockUI({
                baseZ: 10000000,
                message: '',
            });
        }
        function IsEnglishOnly(evt) {
            evt = ");
                WriteLiteral(@"(evt) ? evt : window.event;
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            var englishAlphabetAndWhiteSpace = /[A-Za-z]/g;

            var key = String.fromCharCode(evt.which);
            //(charCode != 46 ||
            //        $(this).val().indexOf('.') != -1) &&
            if (charCode > 47 && charCode < 58) {
                return false;
            }
            if (charCode > 31 && (charCode < 48 || charCode > 57)) {
                if (englishAlphabetAndWhiteSpace.test(key)) {
                    return true;
                }
                return false;
            }
            return true;
        }
        function IsArabicOnly(event) {
            var arabicCharUnicodeRange = /[\u0600-\u06FF]/;
            var key = event.which;
            // 0 = numpad
            // 8 = backspace
            // 32 = space
            if (key == 8 || key == 0) {
                return true;
            }

            var str = String.fromCharCode(key);
            if (arabi");
                WriteLiteral("cCharUnicodeRange.test(str)) {\n                return true;\n            }\n\n            return false;\n        }\n        $(document).ajaxStart(function () {\n            blockUI();\n        }).ajaxStop(function () { $.unblockUI(); });\n    </script>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
