#pragma checksum "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\SalesReport\SalesReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24fc884333a86d90fdf81c1fdf75c56951db81b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesReport_SalesReport), @"mvc.1.0.view", @"/Views/SalesReport/SalesReport.cshtml")]
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
#nullable restore
#line 9 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\SalesReport\SalesReport.cshtml"
using FiboInfraStructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24fc884333a86d90fdf81c1fdf75c56951db81b0", @"/Views/SalesReport/SalesReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d7a7554eaab05fe64b8a2fb2f77723e544dd69", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesReport_SalesReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FiboBilling.Src.ViewModel.SalesReportViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:-8px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("PaymentMethod"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\SalesReport\SalesReport.cshtml"
  

    int SN = 1;
    decimal? total = 0;
    decimal? totalQuantity = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script type=""text/javascript"">
    function CallPrint(strid) {
        var mywindow = document.getElementById('Format');
        var popupWin = window.open('', ""Kaamana Format"", 'width=350,height=150,location=no,left=200px');

        popupWin.document.open();
        popupWin.document.write('<html><title>' + """" + '</title><link rel=""stylesheet"" type=""text/css""  href=""../Content/bootstrap.min.css"" /></head><body onload=""window.print()"">')
        popupWin.document.write('<html><title>' + """" + '</title><link rel=""stylesheet"" type=""text/css"" href=""../Content/print.css"" /></head><body onload=""window.print()"">')
        popupWin.document.write(mywindow.innerHTML);
        popupWin.document.write('</html>');

        popupWin.document.close();

    }

</script>

<div class=""col-lg-12"">
    <div class=""card"">
        <div class=""card-body"">
");
#nullable restore
#line 30 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\SalesReport\SalesReport.cshtml"
             using (Html.BeginForm("SalesReport", "SalesReport", FormMethod.Get, new { @class = "form-view-data" }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""row"">

                            <div class=""col-lg-2"">
                                <label for=""From Date"" style=""margin-bottom:-5px"">From Date</label>
                                ");
#nullable restore
#line 38 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\SalesReport\SalesReport.cshtml"
                           Write(Html.TextBoxFor(x => x.FromMiti, "{0:YYYY/MM/DD }", new { @class = "form-control nepali-datepicker", @placeholder = "YYYY/MM/DD", @autocomplete = "off" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-lg-2\">\r\n                                <label for=\"To Date\" style=\"margin-bottom:-5px\">To Date</label>\r\n                                ");
#nullable restore
#line 42 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\SalesReport\SalesReport.cshtml"
                           Write(Html.TextBoxFor(x => x.ToMiti, "{0:YYYY/MM/DD  }", new { @class = "form-control nepali-datepicker", @placeholder = "YYYY/MM/DD", @autocomplete = "off" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                           \r\n                            <div class=\"col-lg-3\">\r\n                                <label for=\"Payment\" style=\"margin-bottom:-5px\">Name</label>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24fc884333a86d90fdf81c1fdf75c56951db81b08280", async() => {
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24fc884333a86d90fdf81c1fdf75c56951db81b08576", async() => {
                    WriteLiteral("--select--");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    \r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 47 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\SalesReport\SalesReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 47 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\SalesReport\SalesReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.ProductList;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""btn btn-sm  btn-group"" style=""margin-top: 17px;"">
                                <button type=""submit"" class=""btn btn-success""><i class=""ti-filter"">Search</i></button>
                                <button type=""button"" class=""btn btn-success""
                                        style=""background-color:darkblue;color:white;font-weight:bold""
                                        onclick=""CallPrint('strid')"" data-ma-action=""print"">
                                    <i class=""ti-printer""></i> Print
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 63 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\SalesReport\SalesReport.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</div>
<div class=""col-sm-12"">
    <div class=""card"">
        <div class=""card-body"" id=""Format"">
            <h4>Sales Report</h4>
            <hr />
            <div class=""table-responsive"">
                <div class=""tableFixHead"">
                    <table class=""table table-bordered table-striped"" border=""1"" width=""100%"">
                        <thead style=""background-color: #FFFFFFCC;"">
                            <tr>
                                <th>SN</th>
                                <th>Date</th>
                                <th>Name</th>
                                <th>Quantity</th>
                                <th>Amount</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 86 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\SalesReport\SalesReport.cshtml"
                             foreach (var item in Model.salesvm)
                            {

                                var product = await _inventrepos.GetByIdAsync((long)item.ProductId);
                                total += item.Total.ToDecimal();
                                totalQuantity += item.Quantity.ToDecimal();

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 94 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\SalesReport\SalesReport.cshtml"
                                   Write(SN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 97 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\SalesReport\SalesReport.cshtml"
                                   Write(item.BillingDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 100 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\SalesReport\SalesReport.cshtml"
                                   Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 103 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\SalesReport\SalesReport.cshtml"
                                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 106 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\SalesReport\SalesReport.cshtml"
                                   Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 110 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\SalesReport\SalesReport.cshtml"
                                SN++;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <tr>
                                <td colspan=""3"" style=""text-align:right"">
                                    Total
                                </td>
                                <td>
                                    ");
#nullable restore
#line 117 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\SalesReport\SalesReport.cshtml"
                               Write(totalQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 120 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\SalesReport\SalesReport.cshtml"
                               Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public FiboInventory.InfraStructure.Repository.IProductRepository _inventrepos { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FiboBilling.Src.ViewModel.SalesReportViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
