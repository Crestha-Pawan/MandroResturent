#pragma checksum "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "595d3f06ec1a3c7e673d53de69025068c20e02cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Billing_PrintBOT), @"mvc.1.0.view", @"/Views/Billing/PrintBOT.cshtml")]
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
#line 9 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
using FiboInfraStructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"595d3f06ec1a3c7e673d53de69025068c20e02cd", @"/Views/Billing/PrintBOT.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d7a7554eaab05fe64b8a2fb2f77723e544dd69", @"/Views/_ViewImports.cshtml")]
    public class Views_Billing_PrintBOT : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FiboBilling.Src.ViewModel.BillingReportViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
  
    
    int SN = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n");
            WriteLiteral(@"<style>
    * {
        font-size: 12px;
        margin: 0
    }

    .centered {
        text-align: center;
        align-content: center;
    }

    .ticket {
        width: 140px;
        max-width: 140px;
    }

    img {
        max-width: inherit;
        width: inherit;
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
        popupWin.document.wri");
            WriteLiteral(@"te('</html>');

        popupWin.document.close();

    }

</script>

<div class=""card col-lg-6 col-md-6 col-sm-6 col-xs-6"">
    <div class=""card-body"">
        <div class=""row"" style=""text-align:right"">
            <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                <button type=""button"" class=""btn""
                        style=""margin-bottom:20px;background-color:darkblue;padding-top: 3px;
    padding-bottom: 5px;padding-left:5px;color:white;font-weight:bold""
                        onclick=""CallPrint('strid')"" data-ma-action=""print"">
                    <i class=""ti-printer"">Print</i>
                </button>
            </div>
        </div>
        <div class=""ticket"" id=""profile"">
            <table>
                <tr>
                    <td>
                        <table>
                            <tr>
                                <td></td>
                                <td style=""text-align:center"">
                                    <p>
   ");
            WriteLiteral(@"                                     <b style=""font-size: 23px;""><u>Mandro Restaurant </u></b>
                                    <p style=""font-size: 13px; margin-top: -15px;"">

                                </td>
                                <td></td>
                            </tr>
                            <tr>
                                <td colspan=""3"" style=""text-align:center"">BOT</td>
                            </tr>
                        </table>
                        <table>
                            <tr>
                                <td>

");
#nullable restore
#line 83 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
                                     if (@Model.Billings.Count > 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
                                   Write(Model.Billings.FirstOrDefault().TableNo);

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
                                                                                ;

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </td>

                            </tr>
                        </table>
                        <table>
                            <tr>
                                <td colspan=""3"">
                                    <table class=""table table-bordered table-striped"" BORDER=""1"" width=""100%"">
                                        <thead>
                                            <tr>
                                                <th rowspan=""2"">
                                                    <p>
                                                        S.N
                                                    </p>
                                                </th>
                                                <th rowspan=""2"">
                                                    <p>
                                                        Item Name
                                                    </p>
                                       ");
            WriteLiteral(@"         </th>
                                                <th rowspan=""2"">
                                                    <p style=""font-size:15px"">
                                                        Quantity
                                                    </p>
                                                </th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>

                                                <td style=""vertical-align: top"">
");
#nullable restore
#line 120 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
                                                     foreach (var item in Model.BillingInfoList)

                                                    {
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
                                                   Write(SN);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <br />\r\n");
#nullable restore
#line 125 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
                                                        SN++;
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                                </td>\r\n                                                <td style=\"vertical-align:top;text-align:right\">\r\n                                                    <p>\r\n");
#nullable restore
#line 132 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
                                                         foreach (var item in Model.BillingInfoList)
                                                        {
                                                            var product = await _productrepos.GetByIdAsync((long)item.ProductId);
                                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
                                                       Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 136 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
                                                            if (item.IsTakeAway)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"badge badge-light-success m-b-0\" style=\"font-size: 15px; color:black\">-Take Away: ");
#nullable restore
#line 138 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
                                                                                                                                                          Write(item.TakeAwayQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 139 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
                                                            }
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    </p>
                                                </td>
                                                <td style=""vertical-align: top; text-align: right"">
                                                    <p>
");
#nullable restore
#line 145 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
                                                         foreach (var item in Model.BillingInfoList)
                                                        {
                                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
                                                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 148 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    </p>

                                                    <hr style=""background: white;"" />
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
");
#nullable restore
#line 162 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
             foreach (var item in Model.Billings)

            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label>BOT By</label>\r\n");
#nullable restore
#line 166 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
           Write(item.KotBotBy);

#line default
#line hidden
#nullable disable
#nullable restore
#line 166 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
                              
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "595d3f06ec1a3c7e673d53de69025068c20e02cd15059", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 172 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
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
#line 191 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
           Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'success\');\r\n    /**/\r\n    });\r\n    </script>\r\n");
#nullable restore
#line 195 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\Billing\PrintBOT.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public FiboBilling.InfraStructure.Repository.IBillingRepository _repo { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public FiboInventory.InfraStructure.Repository.IProductRepository _productrepos { get; private set; }
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
