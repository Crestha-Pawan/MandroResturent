#pragma checksum "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f7ba582cf0c291c50143df1f252d26c23d2d90d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DayCashBook_Create), @"mvc.1.0.view", @"/Views/DayCashBook/Create.cshtml")]
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
#line 21 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
using FiboInfraStructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f7ba582cf0c291c50143df1f252d26c23d2d90d", @"/Views/DayCashBook/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d7a7554eaab05fe64b8a2fb2f77723e544dd69", @"/Views/_ViewImports.cshtml")]
    public class Views_DayCashBook_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FiboOffice.Src.Dto.DayCashBookDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("OpeningBalance"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 50%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DayCashBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
  

    int SN = 0;
    decimal? ledgerdr = 0;
    decimal? ledgercr = 0;
    decimal? clblc = 0;
    decimal InvTotal = 0;
    decimal exp = 0;
    decimal netsaving = 0;
    decimal SalesTotal = 0;
    decimal salary = 0;
    decimal advsalary = 0;
    decimal partydr = 0;
    decimal partycr = 0;
    DateTime dt = DateTime.Now;
    var officeList = await _officeRepo.GetAllOfficeAsync();
    var office = officeList.FirstOrDefault();


#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f7ba582cf0c291c50143df1f252d26c23d2d90d6860", async() => {
                WriteLiteral("\r\n    <div class=\"card\">\r\n        <div class=\"card-header\" style=\"text-align:center\">\r\n            Day Cash Book of ");
#nullable restore
#line 26 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
                        Write(office.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br /><br /><br />\r\n            Date: ");
#nullable restore
#line 27 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
             Write(dt.ToDateTime().ToNepDate());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            <hr />
        </div>
    </div>
    <div class=""card-body"" id=""Format"">
        <div class=""table-responsive"">
            <div class=""tableFixHead"">
                <table class=""table table-bordered"">
                    <thead style=""background-color: #FFFFFFCC;"">
                        <tr>
                            <th>S.No.</th>
                            <th>Particulars</th>
                            <th>Debit(Rs) </th>
                            <th>Credit(Rs) </th>
                        </tr>
                    </thead>
                    <tbody>

");
#nullable restore
#line 45 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
                         foreach (var item in Model.InventoryList)
                        {
                            InvTotal += item.Total.ToDecimal();

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
                         foreach (var item in Model.Expenses)
                        {
                            exp += item.Amount.ToDecimal();
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
                         foreach (var item in Model.BillingList)
                        {
                            SalesTotal += item.NetAmtPayable.ToDecimal();
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
                         foreach (var item in Model.SalarySheets)
                        {
                            salary += item.NetSalary.ToDecimal();
                            advsalary += item.AdvanceSalary.ToDecimal();
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
                         foreach (var item in Model.LedgerDetailList)
                        {

                            ledgerdr += item.DebitAmount.ToDecimal();
                            ledgercr += item.CreditAmount.ToDecimal();
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <tr>

                            <td colspan=""3"" style=""color:red; text-align:right"">
                                Opening Balance
                            </td>

                            <td>
                                ");
#nullable restore
#line 77 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
                           Write(ViewBag.Balance);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                1
                            </td>
                            <td>
                                Purchase
                            </td>
                            <td>
                                ");
#nullable restore
#line 88 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
                           Write(InvTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </td>
                            <td>
                                -
                            </td>
                        </tr>
                        <tr>
                            <td>
                                2
                            </td>
                            <td>
                                Sales
                            </td>
                            <td>
                                -
                            </td>
                            <td>
                                ");
#nullable restore
#line 105 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
                           Write(SalesTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                                3
                            </td>
                            <td>
                                Administrative Expenses
                            </td>
                            <td>
                                ");
#nullable restore
#line 116 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
                           Write(exp);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </td>
                            <td>
                                -
                            </td>
                        </tr>
                        <tr>
                            <td>
                                4
                            </td>
                            <td>
                                Salary Paid
                            </td>
                            <td>
                                ");
#nullable restore
#line 130 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
                           Write(salary);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </td>
                            <td>
                                -
                            </td>
                        </tr>
                        <tr>
                            <td>
                                5
                            </td>
                            <td>
                                Advance Salary
                            </td>
                            <td>
                                ");
#nullable restore
#line 144 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
                           Write(advsalary);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </td>
                            <td>
                                -
                            </td>
                        </tr>
                        <tr>
                            <td>
                                6
                            </td>
                            <td>
                                Payment To Parties
                            </td>
                            <td>
                                ");
#nullable restore
#line 158 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
                           Write(ledgerdr);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </td>
                            <td>
                                -
                            </td>
                        </tr>
                        <tr>
                            <td>
                                7
                            </td>
                            <td>
                                Received From Parties
                            </td>
                            <td>
                            </td>
                            <td>
                                ");
#nullable restore
#line 174 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
                           Write(ledgercr);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                            <td style=""font-size:20px"">
                                <b>Today's Net Saving</b>
                            </td>
                            <td>
                            </td>
                            <td>
");
#nullable restore
#line 186 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
                                  
                                    netsaving = SalesTotal.ToDecimal() - InvTotal.ToDecimal() - exp.ToDecimal()+ledgercr.ToDecimal()-ledgerdr.ToDecimal()-salary.ToDecimal()-advsalary.ToDecimal();
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
#nullable restore
#line 189 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
                           Write(netsaving);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </td>
                        </tr>

                        <tr>
                            <td colspan=""3"" style=""color:red; text-align:right"">
                                <b>Closing Balance</b>
                            </td>
                            <td>

");
#nullable restore
#line 199 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
                                  
                                    clblc = @ViewBag.Balance + netsaving;
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6f7ba582cf0c291c50143df1f252d26c23d2d90d17853", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 202 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OpeningBalance);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 202 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\DayCashBook\Create.cshtml"
                                                           WriteLiteral(clblc);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </td>
                        </tr>
                    </tbody>
                </table>

            </div>
        </div>
    </div>
    <div class=""card-footer"">
        <div class=""form-group"">
            <div class=""col-md-12"" style=""text-align:right"">
                <button type=""submit"" class=""btn  btn-success"" id=""btnSubmit""><i class=""feather mr-2 icon-check-circle""></i>Submit</button>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public FiboOffice.InfraStructure.Repository.IOfficeRepository _officeRepo { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FiboOffice.Src.Dto.DayCashBookDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
