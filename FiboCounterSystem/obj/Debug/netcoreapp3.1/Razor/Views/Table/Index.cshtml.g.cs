#pragma checksum "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Table\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ade7422d4650344a82c167c9bc237c4cc1980da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Table_Index), @"mvc.1.0.view", @"/Views/Table/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ade7422d4650344a82c167c9bc237c4cc1980da", @"/Views/Table/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d7a7554eaab05fe64b8a2fb2f77723e544dd69", @"/Views/_ViewImports.cshtml")]
    public class Views_Table_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FiboBilling.Src.ViewModel.TableViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Table", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Table\Index.cshtml"
   Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Create"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"col-lg-12\">\n    <div class=\"card\">\n        <div class=\"card-body\">\n            <div style=\"text-align:left\">\n                <button class=\"btn btn-success\" data-toggle=\"modal\"");
            BeginWriteAttribute("ReferenceType", " ReferenceType=\"", 314, "\"", 388, 1);
#nullable restore
#line 9 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Table\Index.cshtml"
WriteAttributeValue("", 330, FiboInfraStructure.Entity.FiboBilling.TableType.TypeTable, 330, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" data-target="".bd-example-modal-lg""><i class=""ti-plus""></i> Create New</button>
            </div>
            <hr />
            <div class=""table-responsive"">
                <div class=""tableFixHead"">
                    <table class=""table table-bordered"">
                        <thead style=""background-color: #FFFFFFCC;"">
                            <tr>
                                <th>
                                    Name
                                </th>
                                <th style=""text-align:center"">
                                    Action Name
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 26 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Table\Index.cshtml"
                             foreach (var item in Model.Tables)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 30 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Table\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td style=\"text-align:center\">\n                     <div class=\"btn-group-sm\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ade7422d4650344a82c167c9bc237c4cc1980da6933", async() => {
                WriteLiteral("\n                            <i class=\"ti-pencil-alt\" data-toggle=\"tooltip\" title=\"Edit\"></i>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Table\Index.cshtml"
                                                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        <a  class=\"btn btn-danger\"href=\"#!\" data-toggle=\"modal\"");
            BeginWriteAttribute("TableId", " TableId=\"", 1738, "\"", 1756, 1);
#nullable restore
#line 37 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Table\Index.cshtml"
WriteAttributeValue("", 1748, item.Id, 1748, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-target=\"#myModal\"><i class=\" ti-trash\" data-toggle=\"tooltip\" title=\"Delete\"></i></a>\n                        </div>\n                    </td>\n                </tr>");
#nullable restore
#line 40 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Table\Index.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>

            </div>
        </div>
    </div>
</div>

<div class=""modal modal-lg"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" id=""DeleteBody"">

        <!-- /.modal-content -->
    </div>
</div>

<div class=""modal bd-example-modal-lg"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" id=""ModalBody"">

    </div>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ade7422d4650344a82c167c9bc237c4cc1980da10984", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <script type=\"text/javascript\">\n        $(\".bd-example-modal-lg\").on(\'show.bs.modal\', function (ke) {\n            const type = $(ke.relatedTarget).attr(\'ReferenceType\');\n            var url = \'");
#nullable restore
#line 69 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Table\Index.cshtml"
                  Write(Url.Action("Create", "Table"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + ""?type="" + type;
            $(""#ModalBody"").load(url, function () {
                $(""#myModal"").modal('show');
            });
        })
    </script>
    <script>
        $(document).ready(function () {
            $('[data-toggle=""tooltip""]').tooltip();
        });
    </script>
    <script type=""text/javascript"">
        $(""#myModal"").on('show.bs.modal', function (e) {
            const tableId = $(e.relatedTarget).attr('TableId');

            var url = '");
#nullable restore
#line 84 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Table\Index.cshtml"
                  Write(Url.Action("Delete","Table"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + ""?id="" + tableId;
            if (tableId > 0) {
            $(""#DeleteBody"").load(url, function () {

                $(""#myModal"").modal('show');
            });
        }
        else {
            $(""#myModal"").modal('hide');
        }
    })
    </script>

");
#nullable restore
#line 97 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Table\Index.cshtml"
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
                type: 'inverse',
                allow_dismiss: false,
                label: 'Cancel',
                className: 'btn-xs btn-inverse',
                placement: { from: 'bottom', align: 'right' },
                delay: 2500,
                animate: { enter: 'animated fadeInRight', exit: 'animated fadeOutRight' },
                offset: { x: 30, y: 30 }
            });
        };
        /**/
        notify('");
#nullable restore
#line 116 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Table\Index.cshtml"
           Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', \'success\');\n    /**/\n    });\n</script>");
#nullable restore
#line 119 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Table\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral(@"<script type=""text/javascript"">
    $(function () {
        Array.prototype.filter.call($('.frmValidation'), function (form) {
            $('#btnSubmit').click(function () {
                if (form.checkValidity() === false) {
                    event.preventDefault();
                    event.stopPropagation();
                    form.classList.add('was-validated');
                    return false;
                }
                else {
                    return true;
                }


            });
        });
    });
    
    </script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FiboBilling.Src.ViewModel.TableViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
