#pragma checksum "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4095e71bea1f9681a106f9d22107679119018db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BillingReport_BillingDetails), @"mvc.1.0.view", @"/Views/BillingReport/BillingDetails.cshtml")]
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
#line 13 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
using FiboInfraStructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4095e71bea1f9681a106f9d22107679119018db", @"/Views/BillingReport/BillingDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d7a7554eaab05fe64b8a2fb2f77723e544dd69", @"/Views/_ViewImports.cshtml")]
    public class Views_BillingReport_BillingDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FiboBilling.Src.ViewModel.BillingReportViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/mandro_logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 60px; width: 60px; margin-right: -280px; margin-top: -100px; border-radius:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
  
    int SN = 1;
    int count = 1;
    var billing = await _billrepo.GetAllBillingAsync();

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
 foreach (var item in billing)
{
    count++;
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    * {
        font-size: 12px;
        margin: 0;
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
        popupWin.document.wr");
            WriteLiteral(@"ite('</html>');

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
                    <i class=""ti-printer""></i> Print
                </button>
            </div>
        </div>
        <div style=""vertical-align:central"" class=""ticket"" id=""profile"">

            <table>
                <tr>
                    <td>
                        <table>

                            <tr>
                                <td style=""text-align:center"">
                                    <p>
         ");
            WriteLiteral(@"                               <b style=""font-size: 23px;""><u>Mandro Restaurant </u></b>
                                    <p style=""font-size: 13px; margin-top: -15px;"">
                                        MNP-13,Charali Jhapa, illam Road.
                                        <br />
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4095e71bea1f9681a106f9d22107679119018db7583", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        <br />
<p style=""margin-top:-30px"">023-460223</p>
                                </td>
                            </tr>
                            <tr>
                                <td colspan=""3"" style=""text-align:left"">Order Slip</td>
                                <td colspan=""3"" style=""text-align:right"">
                                    No:  ");
#nullable restore
#line 86 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                          if (@Model.Billings.Count > 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                   Write(Model.Billings.FirstOrDefault().BillingNumber);

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                                                                      ;

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </td>
                            </tr>
                        </table>
                        <table>
                            <tr colspan=""4"">
                                <td colspan=""5"" style=""text-align: left; font-size: 13px;"">
                                    <b>Guest Name:</b>
");
#nullable restore
#line 98 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                     if (@Model.Billings.Count > 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                   Write(Model.Billings.FirstOrDefault().GuestName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                                                                  ;

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td colspan=\"5\" style=\"text-align: left; font-size: 13px;\">\r\n                                    <b> Table No :</b>\r\n");
#nullable restore
#line 106 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                     if (@Model.Billings.Count > 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                   Write(Model.Billings.FirstOrDefault().TableNo);

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                                                                ;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </td>

                            </tr>
                            <tr>
                                <td colspan=""5"" style=""text-align: left; font-size: 13px;"">
                                    <b>Payment Method :</b>
");
#nullable restore
#line 116 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                     if (@Model.Billings.Count > 0)
                                    {
                                        if (Model.Billings.FirstOrDefault().PaymentMethod == "FonePay")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <label>Fone Pay</label>\r\n");
#nullable restore
#line 121 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"

                                        }
                                        else
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                       Write(Model.Billings.FirstOrDefault().PaymentMethod);

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                                                                          ;
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td colspan=\"5\" style=\"text-align: right; font-size: 13px;\">\r\n                                    <b> Date :</b>\r\n");
#nullable restore
#line 131 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                     if (@Model.Billings.Count > 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                   Write(Model.Billings.FirstOrDefault().BillingDate.ToNepDate());

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                                                                                ;

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n\r\n                            </tr>\r\n                            <tr>\r\n                                <td colspan=\"6\" style=\"text-align: left; font-size: 13px;\">\r\n                                    <b> By :</b>\r\n");
#nullable restore
#line 142 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                     if (@Model.Billings.Count > 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                   Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                                           
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </td>

                            </tr>

                        </table>
                        <table>
                            <tr>
                                <td colspan=""3"">
                                    <table class=""table table-bordered table-striped"" BORDER=""1"" width=""100%"">
                                        <thead style=""font-size:12px;"">
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
            WriteLiteral(@"                                 </th>
                                                <th rowspan=""2"">
                                                    <p>
                                                        Qty
                                                    </p>
                                                </th>
                                                <th rowspan=""2"">
                                                    <p>
                                                        Rate
                                                    </p>
                                                </th>
                                                <th rowspan=""2"">
                                                    <p>
                                                        Amount
                                                    </p>

                                                </th>
");
            WriteLiteral("                                            </tr>\r\n\r\n                                        </thead>\r\n                                        <tbody>\r\n");
#nullable restore
#line 193 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                             foreach (var item in Model.BillingInfoList)

                                            {
                                                var product = await _productrepos.GetByIdAsync((long)item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n\r\n                                                    <td style=\"vertical-align: top;font-size:12px;\">\r\n\r\n                                                        ");
#nullable restore
#line 201 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                                   Write(SN);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                        <br />

                                                    </td>
                                                    <td style=""vertical-align:top;text-align:right;font-size:12px;"">
                                                        <p>



                                                            ");
#nullable restore
#line 210 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                                       Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <br />

                                                        </p>

                                                    </td>
                                                    <td style=""vertical-align: top; text-align: right;font-size:12px; "">
                                                        <p>

                                                            ");
#nullable restore
#line 218 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />

                                                        </p>

                                                    </td>
                                                    <td style=""vertical-align: top;text-align:right;font-size:12px; "">
                                                        <p>

                                                            ");
#nullable restore
#line 226 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />

                                                        </p>

                                                    </td>
                                                    <td style=""vertical-align: top; text-align: right; font-size: 12px; "">
                                                        <p style="" font-size: 12px;"">

                                                            ");
#nullable restore
#line 234 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                                       Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n                                                        </p>\r\n\r\n                                                    </td>\r\n");
            WriteLiteral("                                                </tr>\r\n");
#nullable restore
#line 248 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                                SN++;
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <tr>
                                                <td colspan=""4"" style=""text-align: right; font-size: 12px;"">Total</td>
                                                <td style=""text-align: right; font-size: 12px;"">
");
#nullable restore
#line 253 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                                     foreach (var item in Model.Billings)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <p style=\"font-size: 12px;\">\r\n                                                            ");
#nullable restore
#line 256 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                                       Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </p>");
#nullable restore
#line 257 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </td>\r\n");
            WriteLiteral(@"                                            </tr>
                                            <tr>
                                                <td colspan=""4"" style=""text-align: right; font-size: 12px;"">
                                                    <p>
                                                        Discount
                                                    </p>
                                                </td>
                                                <td style=""text-align: right; font-size: 12px;"">
                                                    <p style="" font-size: 12px;"">
");
#nullable restore
#line 269 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                                         foreach (var item in Model.Billings)
                                                        {
                                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 271 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                                       Write(item.Discount);

#line default
#line hidden
#nullable disable
#nullable restore
#line 271 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                                                          
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </p>\r\n                                                </td>\r\n");
            WriteLiteral(@"                                            </tr>
                                            <tr>
                                                <td colspan=""4"" style=""text-align: right; font-size: 12px; "">
                                                    Net Payable Amt
                                                </td>
                                                <td style=""text-align: right; font-size: 12px;"">
");
#nullable restore
#line 282 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                                     foreach (var item in Model.Billings)
                                                    {
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 284 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                                   Write(item.NetAmtPayable);

#line default
#line hidden
#nullable disable
#nullable restore
#line 284 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
                                                                           

                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </td>\r\n");
            WriteLiteral(@"                                            </tr>

                                        </tbody>
                                    </table>

                                </td>
                            </tr>
                        </table>
                        <table>
                            <tr>
                                <td style=""text-align: center; font-size: 12px;"">
                                    Thank You For Giving Us Chance to Serve
                                </td>
                            </tr>
                            <tr>
                                <td style=""text-align: center; font-size: 12px;"">
                                    Visit Us Again
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4095e71bea1f9681a106f9d22107679119018db28610", async() => {
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
            WriteLiteral("\r\n");
#nullable restore
#line 316 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script type=""text/javascript"">
    'use strict';
    $(window).on('load', function () {
        function notify(message,type) {
            $.growl({
                message: message
            }, {
                type: type,
                allow_dismiss: false,
                label: 'Cancel',
                className: 'btn-xs btn-inverse',
                placement: {from: 'top', align: 'right'},
                delay: 2500,
                animate: { enter: 'animated rotateIn', exit: 'animated rotateIn'},
                offset: {x: 30,y: 30}
            });
        };
        notify('");
#nullable restore
#line 335 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
           Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\'success\');\r\n    });\r\n</script>");
#nullable restore
#line 337 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\BillingReport\BillingDetails.cshtml"
         }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public FiboInventory.InfraStructure.Repository.IProductRepository _productrepos { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public FiboBilling.InfraStructure.Repository.IBillingRepository _billrepo { get; private set; }
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