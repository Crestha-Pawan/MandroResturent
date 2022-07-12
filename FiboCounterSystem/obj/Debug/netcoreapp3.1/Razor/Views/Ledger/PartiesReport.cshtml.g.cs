#pragma checksum "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Ledger\PartiesReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3db54bfb1d10838df6b015e833f3cf272375ea20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ledger_PartiesReport), @"mvc.1.0.view", @"/Views/Ledger/PartiesReport.cshtml")]
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
#line 14 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Ledger\PartiesReport.cshtml"
using FiboInfraStructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3db54bfb1d10838df6b015e833f3cf272375ea20", @"/Views/Ledger/PartiesReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d7a7554eaab05fe64b8a2fb2f77723e544dd69", @"/Views/_ViewImports.cshtml")]
    public class Views_Ledger_PartiesReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FiboParty.Src.ViewModel.PartiesReportVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("select2 form-control custom-select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 30px; border-radius: 35px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PartiesReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ledger", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Ledger\PartiesReport.cshtml"
  
    int SN = 1;
    decimal? total = 0;
    decimal dr = 0;
    decimal cr = 0;
    string debit = "Dr";
    string credit = "Cr";

    var fiscalyear = await _fiscalrepos.GetAllFiscalYearAsync();
    var fiscalyr = fiscalyear.Where(x => x.IsActive()).FirstOrDefault();


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .btn-success {
        background-color: #40A214;
    }
</style>
<script type=""text/javascript"">
    function CallPrint(strid) {
        var mywindow = document.getElementById('profile');
        var popupWin = window.open('', ""Kaamana Format"", 'width=350,height=150,location=no,left=200px');
        popupWin.document.open();
        popupWin.document.write('<html><title>' + """" + '</title><link rel=""stylesheet"" type=""text/css""  href=""../Content/bootstrap.min.css"" /></head><body onload=""window.print()"">')
        popupWin.document.write('<html><title>' + """" + '</title><link rel=""stylesheet"" type=""text/css"" href=""../Content/print.css"" /></head><body onload=""window.print()"">')
        popupWin.document.write(mywindow.innerHTML);
        popupWin.document.write('</html>');
        popupWin.document.close();

    }

</script>
<div class=""col-sm-12"">
    <div class=""card"">
");
#nullable restore
#line 39 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Ledger\PartiesReport.cshtml"
         using (Html.BeginForm("PartiesReport", "Ledger", FormMethod.Get, new { @class = "form-view-data" }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card-header\">\r\n            <h6 style=\"text-align:center\">Active Fiscal Year :<b style=\"color:red\">");
#nullable restore
#line 42 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Ledger\PartiesReport.cshtml"
                                                                              Write(fiscalyr.FiscalYearName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> </h6>\r\n            <div class=\" col-lg-12\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-3\">\r\n                        <label>Party Name</label>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3db54bfb1d10838df6b015e833f3cf272375ea207908", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 47 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Ledger\PartiesReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PartyId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 47 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Ledger\PartiesReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.PartyList;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class="" col-lg-3"" style=""text-align:left"">
                        <button type=""submit"" style=""margin-top: 30px;border-radius:35px;"" class=""btn btn-success""><i class=""ti-filter"">Search</i></button>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3db54bfb1d10838df6b015e833f3cf272375ea2010197", async() => {
                WriteLiteral("\r\n                            Show All\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""col-lg-6"" style=""text-align:right"">
                        <button type=""button"" class=""btn "" style=""margin-top: 30px; background-color: darkblue; border-radius: 35px; color: white; font-weight: bold"" onclick=""CallPrint('strid')"" data-ma-action=""print"">
                            <i class=""ti-printer""></i> Print
                        </button>

                    </div>
                </div>
            </div>
        </div>
");
            WriteLiteral(@"            <div class=""card-body"">

                <div class=""table-responsive"" id=""profile"">
                    <div class=""tableFixHead"">
                        <table class=""table table-bordered table-striped"" BORDER=""1"" width=""100%"">
                            <thead style=""background-color: #0e4d5496;"">
                                <tr>
");
            WriteLiteral(@"                                    <th>
                                        Name
                                    </th>
                                    <th>Debit</th>
                                    <th>Credit</th>
                                    <th>Dr/Cr</th>
                                    <th>Balance</th>
                                    <th style=""text-align:center"">
                                        Action
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 86 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Ledger\PartiesReport.cshtml"
                                 foreach (var item in Model.PartiesReportVMList)
                                {
                                    var de = item.Dr;
                                    var ce = item.Cr;
                                    var party = await _prepo.GetByIdAsync((long)item.PartyId);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr style=\"text-align:center\">\r\n");
            WriteLiteral("                                        <td>");
#nullable restore
#line 95 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Ledger\PartiesReport.cshtml"
                                       Write(party.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                        <td>");
#nullable restore
#line 97 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Ledger\PartiesReport.cshtml"
                                       Write(item.Dr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 98 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Ledger\PartiesReport.cshtml"
                                       Write(item.Cr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n");
#nullable restore
#line 100 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Ledger\PartiesReport.cshtml"
                                             if (de.ToDecimal() > ce.ToDecimal())
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Ledger\PartiesReport.cshtml"
                                           Write(debit);

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Ledger\PartiesReport.cshtml"
                                                      ;
                                            }
                                            else

                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Ledger\PartiesReport.cshtml"
                                           Write(credit);

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Ledger\PartiesReport.cshtml"
                                                       ;
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td>");
#nullable restore
#line 110 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Ledger\PartiesReport.cshtml"
                                       Write(item.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 5554, "\"", 5621, 1);
#nullable restore
#line 112 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Ledger\PartiesReport.cshtml"
WriteAttributeValue("", 5561, Url.Action("MonthlyReport","Ledger",new {id=item.PartyId }), 5561, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <i class=\"ti-eye\" data-toggle=\"tooltip\" title=\"Monthly Report\"></i>\r\n                                            </a>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 5838, "\"", 5904, 1);
#nullable restore
#line 115 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Ledger\PartiesReport.cshtml"
WriteAttributeValue("", 5845, Url.Action("PartyDetails","Ledger",new {id=item.PartyId }), 5845, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                <i class=""ti-eye""style=""color:red"" data-toggle=""tooltip"" title=""Total Report""></i>
                                            </a>
                                        </td>
                                    </tr>
");
#nullable restore
#line 120 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Ledger\PartiesReport.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n\r\n\r\n            </div>\r\n");
#nullable restore
#line 128 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Ledger\PartiesReport.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public FiboOffice.InfraStructure.Repository.IFiscalYearRepository _fiscalrepos { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public FiboParty.Infrastructure.Repository.IPartyRepository _prepo { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public FiboParty.Infrastructure.Repository.ILedgerRepository _repo { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FiboParty.Src.ViewModel.PartiesReportVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
