#pragma checksum "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Employee\ToggleStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32b6408152f82449567964f1ffac92e95efe9d88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_ToggleStatus), @"mvc.1.0.view", @"/Views/Employee/ToggleStatus.cshtml")]
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
#line 1 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\_ViewImports.cshtml"
using FiboCounterSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\_ViewImports.cshtml"
using FiboCounterSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32b6408152f82449567964f1ffac92e95efe9d88", @"/Views/Employee/ToggleStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d7a7554eaab05fe64b8a2fb2f77723e544dd69", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_ToggleStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FiboInfraStructure.Entity.FiboOffice.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ToggleStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Employee\ToggleStatus.cshtml"
   Layout = null; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32b6408152f82449567964f1ffac92e95efe9d884671", async() => {
                WriteLiteral("\n    ");
#nullable restore
#line 6 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Employee\ToggleStatus.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    ");
#nullable restore
#line 7 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Employee\ToggleStatus.cshtml"
Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <div class=\"modal-content\">\n        <div class=\"modal-header\">\n            <h5 class=\"modal-title\">");
#nullable restore
#line 10 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Employee\ToggleStatus.cshtml"
                               Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\n            <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\n        </div>\n        <div class=\"modal-body\">\n            <p>\n                Are You Sure to\n");
#nullable restore
#line 16 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Employee\ToggleStatus.cshtml"
                 if (Model.IsActive())
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <label style=\"color:darkred\">Disable  ");
#nullable restore
#line 18 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Employee\ToggleStatus.cshtml"
                                     Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> ");
#nullable restore
#line 18 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Employee\ToggleStatus.cshtml"
                                                              }
else
{

#line default
#line hidden
#nullable disable
                WriteLiteral("<label style=\"color:green\">Enable  ");
#nullable restore
#line 21 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Employee\ToggleStatus.cshtml"
                              Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>");
#nullable restore
#line 21 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Employee\ToggleStatus.cshtml"
                                                      }

#line default
#line hidden
#nullable disable
                WriteLiteral("                ?\n            </p>\n        </div>\n        <div class=\"modal-footer\">\n            <button type=\"button\" class=\"btn  btn-secondary\" data-dismiss=\"modal\">&times; Cancel</button>\n");
#nullable restore
#line 27 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Employee\ToggleStatus.cshtml"
             if (Model.IsActive())
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<button type=\"submit\" class=\"btn  btn-danger\"><i class=\"feather icon-thumbs-down\"></i> Disable</button> ");
#nullable restore
#line 29 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Employee\ToggleStatus.cshtml"
                                                                                                        }
else
{

#line default
#line hidden
#nullable disable
                WriteLiteral("<button type=\"submit\" class=\"btn  btn-success\"><i class=\"feather icon-thumbs-up\"></i> Enable</button>");
#nullable restore
#line 32 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Employee\ToggleStatus.cshtml"
                                                                                                     }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32b6408152f82449567964f1ffac92e95efe9d8810137", async() => {
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
            WriteLiteral("\n");
#nullable restore
#line 38 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Employee\ToggleStatus.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script type=""text/javascript"">
    'use strict';
    $(window).on('load', function () {
        function notify(message) {
            $.notify({
                message: message,
                type: 'danger',
                allow_dismiss: false,
                label: 'Cancel',
                className: 'btn-xs btn-danger',
                placement: { from: 'bottom', align: 'right' },
                delay: 2500,
                animate: { enter: 'animated fadeInRight', exit: 'animated fadeOutRight' },
                offset: { x: 30, y: 30 }
            });
        };
        /**/
        notify('");
#nullable restore
#line 57 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Employee\ToggleStatus.cshtml"
           Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\n    /**/\n    });\n</script>");
#nullable restore
#line 60 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Employee\ToggleStatus.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32b6408152f82449567964f1ffac92e95efe9d8812502", async() => {
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
            WriteLiteral("\n");
#nullable restore
#line 63 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Employee\ToggleStatus.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <script type=""text/javascript"">
    'use strict';
    $(window).on('load', function () {
        function notify(message) {
            $.notify({
                message: message,
                type: 'danger',
                allow_dismiss: false,
                label: 'Cancel',
                className: 'btn-xs btn-danger',
                placement: { from: 'bottom', align: 'right' },
                delay: 2500,
                animate: { enter: 'animated fadeInRight', exit: 'animated fadeOutRight' },
                offset: { x: 30, y: 30 }
            });
        };
        /**/
        notify('");
#nullable restore
#line 82 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Employee\ToggleStatus.cshtml"
           Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\n    /**/\n    });\n    </script>\n");
#nullable restore
#line 86 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Employee\ToggleStatus.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FiboInfraStructure.Entity.FiboOffice.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
