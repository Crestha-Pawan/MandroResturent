#pragma checksum "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "953deac96364d27c9775f3eca661a3a19191b676"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BillingReport_BillingCreditReport), @"mvc.1.0.view", @"/Views/BillingReport/BillingCreditReport.cshtml")]
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
#line 10 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
using FiboInfraStructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"953deac96364d27c9775f3eca661a3a19191b676", @"/Views/BillingReport/BillingCreditReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d7a7554eaab05fe64b8a2fb2f77723e544dd69", @"/Views/_ViewImports.cshtml")]
    public class Views_BillingReport_BillingCreditReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FiboBilling.Src.ViewModel.BillingReportViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BillingDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BillingReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BillingCreditReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
  
    int SN = 1;
    decimal? total = 0;
    var billingstatus = await _billstatrepo.GetAllBillingStatusAsync();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
#line 30 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
             using (Html.BeginForm("BillingCreditReport", "BillingReport", FormMethod.Get, new { @class = "form-view-data" }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""row"">

                            <div class=""col-lg-2"">
                                From Date <br />
                                ");
#nullable restore
#line 38 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
                           Write(Html.TextBoxFor(x => x.FromMiti, "{0:yyyy/MM/dd }", new { @class = "form-control nepali-datepicker", @placeholder = "YYYY/MM/DD", @autocomplete = "off" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-lg-2\">\r\n                                To Date<br />\r\n                                ");
#nullable restore
#line 42 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
                           Write(Html.TextBoxFor(x => x.ToMiti, "{0:yyyy/MM/dd }", new { @class = "form-control nepali-datepicker", @placeholder = "YYYY/MM/DD", @autocomplete = "off" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-lg-2\">\r\n                                Name<br />\r\n                                ");
#nullable restore
#line 46 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
                           Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control", autocomplete = "off" }));

#line default
#line hidden
#nullable disable
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
#line 59 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "953deac96364d27c9775f3eca661a3a19191b6769671", async() => {
                WriteLiteral(@"
    <div class=""card"">
        <div class=""card-body"" id=""Format"">
            <h4>Billing Credit Report</h4>
            <hr />
            <div class=""table-responsive dt-responsive"">
                <div class=""tableFixHead"">
                    <table id=""colum-select"" class=""table table-bordered table-striped"" border=""1"" width=""100%"">
                        <thead style=""background-color: #FFFFFFCC;"">
                            <tr>
                                <th style=""text-align:center""> </th>
                                <th style=""text-align:center"">SN</th>
                                <th style=""text-align:center"">Date</th>
                                <th style=""text-align:center"">Guest Name</th>
                                <th style=""text-align:center"">Payment Method</th>
                                <th style=""text-align:center"">Amount</th>
                                <th style=""text-align:center"">Status</th>
                                <th style=""");
                WriteLiteral("text-align:center\">Action</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 85 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
                             foreach (var item in Model.Billings)
                            {
                                var bill = await _billrepos.GetByIdAsync(item.Id);
                                total = total + Convert.ToDecimal(item.Total);
                                var status = billingstatus.Where(x => x.BillingId == item.Id).FirstOrDefault();


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td style=\"text-align:center\"><input class=\"chkSelected\" name=\"chkSelected\" type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 4961, "\"", 4977, 1);
#nullable restore
#line 92 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
WriteAttributeValue("", 4969, item.Id, 4969, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n\r\n                                    <td style=\"text-align:center\">\r\n                                        ");
#nullable restore
#line 95 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
                                   Write(SN);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td style=\"text-align:center\">\r\n                                        ");
#nullable restore
#line 98 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
                                   Write(item.BillingDate.ToNepDate());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td style=\"text-align:center\">\r\n                                        ");
#nullable restore
#line 101 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
                                   Write(item.GuestName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td style=\"text-align:center\">\r\n                                        ");
#nullable restore
#line 104 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
                                   Write(item.PaymentMethod);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td style=\"text-align:center\">\r\n                                        ");
#nullable restore
#line 107 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
                                   Write(item.Total);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td style=\"text-align:center\">\r\n");
#nullable restore
#line 110 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
                                         if (status != null)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
                                             if (status.IsPaid == true)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <label class=\"label label-success\">Paid</label>\r\n");
#nullable restore
#line 115 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <label class=\"label label-danger\">Credit</label>\r\n");
#nullable restore
#line 119 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
                                             
                                        }
                                        else
                                        { 

#line default
#line hidden
#nullable disable
                WriteLiteral("                                           <label class=\"label label-danger\"> ");
#nullable restore
#line 123 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
                                                                         Write(item.PaymentMethod);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
#nullable restore
#line 124 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"

                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </td>\r\n                                    <td style=\"font-size:large;text-align:center\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "953deac96364d27c9775f3eca661a3a19191b67617287", async() => {
                    WriteLiteral("\r\n                                            <i class=\"ti-eye\" data-toggle=\"tooltip\" title=\"View\"></i>\r\n                                        ");
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
#line 128 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
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
                WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 133 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
                                SN++;
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <tr>\r\n                                <td colspan=\"6\" style=\"text-align:right\">Total</td>\r\n                                <td>");
#nullable restore
#line 138 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingCreditReport.cshtml"
                               Write(total.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
            <button type=""submit"" class=""btn btn-success"" style=""float:right; background-color:#228b22;color:white"">Save</button>

        </div>

    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\'[data-toggle=\"tooltip\"]\').tooltip();\r\n    });\r\n</script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public FiboBilling.InfraStructure.Repository.IBillingStatusRepository _billstatrepo { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public FiboBilling.InfraStructure.Repository.IBillingInfoRepository _billrepos { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FiboBilling.Src.ViewModel.BillingReportViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
