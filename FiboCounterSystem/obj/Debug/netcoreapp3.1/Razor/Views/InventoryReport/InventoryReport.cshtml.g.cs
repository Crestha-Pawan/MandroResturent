#pragma checksum "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\InventoryReport\InventoryReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e3b208a2316927f0f0231e38c2f28dc91163e0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InventoryReport_InventoryReport), @"mvc.1.0.view", @"/Views/InventoryReport/InventoryReport.cshtml")]
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
#line 9 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\InventoryReport\InventoryReport.cshtml"
using FiboInfraStructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e3b208a2316927f0f0231e38c2f28dc91163e0d", @"/Views/InventoryReport/InventoryReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d7a7554eaab05fe64b8a2fb2f77723e544dd69", @"/Views/_ViewImports.cshtml")]
    public class Views_InventoryReport_InventoryReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FiboInventory.Src.ViewModel.InventoryReportViewModel>
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
#line 2 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\InventoryReport\InventoryReport.cshtml"
  
    int SN = 0;

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
#line 30 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\InventoryReport\InventoryReport.cshtml"
             using (Html.BeginForm("InventoryReport", "InventoryReport", FormMethod.Get, new { @class = "form-view-data" }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""row"">
                            <div class=""col-lg-3"">
                                <label for=""Payment"" style=""margin-bottom:-5px"">Item Name</label>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e3b208a2316927f0f0231e38c2f28dc91163e0d7017", async() => {
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e3b208a2316927f0f0231e38c2f28dc91163e0d7313", async() => {
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
                WriteLiteral("\r\n\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 37 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\InventoryReport\InventoryReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ItemId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\InventoryReport\InventoryReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.ItemList;

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
#line 53 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\InventoryReport\InventoryReport.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</div>
<div class=""col-lg-12"">
    <div class=""card"">
        <div class=""card-body"" id=""Format"">
            <h4>Inventory Report</h4>
            <hr />
            <div class=""table-responsive"">
                <div class=""tableFixHead"">
                    <table class=""table table-bordered table-striped"" border=""1"" width=""100%"">
                        <thead style=""background-color: #FFFFFFCC;"">
                            <tr>
                                <th>SN</th>
                                <th>Item</th>
                                <th>Actual Quantity </th>
                                <th>Adjusted Quantity</th>
                                <th>Consumed Quantity </th>
                                <th> Available Quantity</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 77 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\InventoryReport\InventoryReport.cshtml"
                             foreach (var item in Model.Inventories)
                            {
                                decimal adjQty = 0;
                                decimal stckavailablee = 0;
                                SN++;
                                var items = await _itemRepository.GetByIdAsync((long)item.ItemId);
                                var mu = await _muRepo.GetByIdAsync((long)item.MeasuringUnitId);
                                var stklist = await _stkrepo.GetAllStockAdjustmentDetailAsync();
                                var stk = stklist.Where(x => x.ItemId == item.ItemId).ToList();

                                if (stk != null)
                                {
                                    foreach (var _item in stk)
                                    {
                                        adjQty += _item.Quantity.ToDecimal();
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 96 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\InventoryReport\InventoryReport.cshtml"
                                   Write(SN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 99 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\InventoryReport\InventoryReport.cshtml"
                                   Write(items.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 103 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\InventoryReport\InventoryReport.cshtml"
                                   Write(item.ActualQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;");
#nullable restore
#line 103 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\InventoryReport\InventoryReport.cshtml"
                                                              Write(mu.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 106 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\InventoryReport\InventoryReport.cshtml"
                                   Write(adjQty);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n\r\n                                        ");
#nullable restore
#line 110 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\InventoryReport\InventoryReport.cshtml"
                                   Write(item.ConsumedQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;");
#nullable restore
#line 110 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\InventoryReport\InventoryReport.cshtml"
                                                                Write(mu.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 113 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\InventoryReport\InventoryReport.cshtml"
                                          
                                            stckavailablee = item.AvailableQuantity.ToDecimal() - @adjQty.ToDecimal();
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
#nullable restore
#line 116 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\InventoryReport\InventoryReport.cshtml"
                                   Write(stckavailablee);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;");
#nullable restore
#line 116 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\InventoryReport\InventoryReport.cshtml"
                                                         Write(mu.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 119 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\InventoryReport\InventoryReport.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'[data-toggle=\"tooltip\"]\').tooltip();\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public FiboInventory.InfraStructure.Repository.IStockAdjustmentDetailRepository _stkrepo { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public FiboOffice.InfraStructure.Repository.IMeasuringUnitRepository _muRepo { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public FiboInventory.InfraStructure.Repository.IItemRepository _itemRepository { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public FiboInventory.InfraStructure.Repository.IInventoryRepository _inventoryRepository { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FiboInventory.Src.ViewModel.InventoryReportViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
