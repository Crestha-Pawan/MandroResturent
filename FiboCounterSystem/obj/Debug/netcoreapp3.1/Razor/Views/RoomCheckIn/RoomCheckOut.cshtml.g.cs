#pragma checksum "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\RoomCheckOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db5001867f8fda40c51ceabb3ef463cff11caa97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RoomCheckIn_RoomCheckOut), @"mvc.1.0.view", @"/Views/RoomCheckIn/RoomCheckOut.cshtml")]
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
#line 9 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\RoomCheckOut.cshtml"
using FiboInfraStructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db5001867f8fda40c51ceabb3ef463cff11caa97", @"/Views/RoomCheckIn/RoomCheckOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d7a7554eaab05fe64b8a2fb2f77723e544dd69", @"/Views/_ViewImports.cshtml")]
    public class Views_RoomCheckIn_RoomCheckOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FiboLodge.Src.ViewModel.RoomCheckInViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RoomCheckOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "RoomCheckIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\RoomCheckOut.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\RoomCheckOut.cshtml"
   string room = string.Empty;
    var roomList = await _roomRepo.GetAllRoomAsync(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-sm-12\">\r\n    <div class=\"col-lg-12\">\r\n        <div class=\"card-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db5001867f8fda40c51ceabb3ef463cff11caa976066", async() => {
                WriteLiteral("\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-12\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-sm-3\">\r\n                                Room<br />\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db5001867f8fda40c51ceabb3ef463cff11caa976593", async() => {
                    WriteLiteral("\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 20 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\RoomCheckOut.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RoomSetupId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 20 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\RoomCheckOut.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.RoomSetupSelectList;

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
                            <div class=""btn btn-group"">
                                <button type=""submit"" class=""btn btn-success"">Search</button>
                            </div>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
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
    </div>
    <div class=""card"">
        <div class=""card-body"">
            <div class=""table-responsive"">
                <div class=""tableFixHead"">
                    <table class=""table table-bordered"">
                        <thead style=""background-color: #FFFFFFCC;"">
                            <tr>
                                <th>
                                    Check In Time
                                </th>
                                <th>
                                    Room
                                </th>
                                <th>
                                    Customer's Name
                                </th>
                                <th>
                                    Contact No
                                </th>
                                <th>
                                    Advance
                                </th>
                                <th style=""text-align:center"">");
            WriteLiteral("\n                                    Action Name\r\n                                </th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 60 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\RoomCheckOut.cshtml"
                             foreach (var item in Model.RoomCheckInList.Where(x => x.IsCheckIn()))
                            {
                                if (item.RoomSetupId.Contains(","))
                                {
                                    room = string.Empty;
                                    string[] roomsetupId = item.RoomSetupId.Split(",");
                                    for (int i = 0; i < roomsetupId.Length; i++)
                                    {
                                        room += string.Format("{0}{1}", roomList.Where(x => x.Id == long.Parse(roomsetupId[i])).Select(x => x.RoomName).FirstOrDefault(), ", ");
                                    }
                                }
                                else
                                {
                                    room = roomList.Where(x => x.Id == long.Parse(item.RoomSetupId)).Select(x => x.RoomName).FirstOrDefault();
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 77 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\RoomCheckOut.cshtml"
                                   Write(item.CreatedDate.ToDateTime().ToNepDate());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 80 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\RoomCheckOut.cshtml"
                                   Write(room);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 83 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\RoomCheckOut.cshtml"
                                   Write(item.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 86 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\RoomCheckOut.cshtml"
                                   Write(item.ContactNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 89 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\RoomCheckOut.cshtml"
                                   Write(item.Advance);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td style=\"text-align:center\">\r\n                                        <div class=\"btn-group-sm\">\r\n");
#nullable restore
#line 93 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\RoomCheckOut.cshtml"
                                             if (item.IsCheckIn())
                                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <a type=\"button\" class=\"btn btn-warning\" href=\"#!\" ReferenceType=\"toggle\" data-toggle=\"modal\"");
            BeginWriteAttribute("RoomCheckInId", " RoomCheckInId=\"", 4603, "\"", 4627, 1);
#nullable restore
#line 96 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\RoomCheckOut.cshtml"
WriteAttributeValue("", 4619, item.Id, 4619, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-target=\"#myModal\">\r\n                                                    <i class=\"ti-thumb-down\" data-toggle=\"tooltip\" title=\"Check-Out\"></i>\r\n                                                </a>\r\n");
#nullable restore
#line 99 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\RoomCheckOut.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\r\n\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 104 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\RoomCheckOut.cshtml"
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

<div class=""modal"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" id=""DeleteBody"">

        <!-- /.modal-content -->
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db5001867f8fda40c51ceabb3ef463cff11caa9717398", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
    $(""#myModal"").on('show.bs.modal', function (ke) {
        const roomId = $(ke.relatedTarget).attr('RoomCheckInId');
        const type = $(ke.relatedTarget).attr('ReferenceType');
        if (roomId > 0) {
             if (type == ""toggle"") {
                 var url = '");
#nullable restore
#line 130 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\RoomCheckOut.cshtml"
                       Write(Url.Action("CheckOut", "RoomCheckIn"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + ""?id="" + roomId;
                    $(""#DeleteBody"").load(url, function () {

                        $(""#myModal"").modal('show');
                    });
                }
        }

    })

    </script>
    <script>
        $(document).ready(function () {
            $('[data-toggle=""tooltip""]').tooltip();
        });
    </script>
");
#nullable restore
#line 146 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\RoomCheckOut.cshtml"
     if (ViewBag.Message != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <script type=""text/javascript"">
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
#line 165 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\RoomCheckOut.cshtml"
           Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', \'success\');\r\n    /**/\r\n    });\r\n        </script>\r\n");
#nullable restore
#line 169 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\RoomCheckOut.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public FiboLodge.InfraStructure.Repository.IRoomSetupRepository _roomRepo { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FiboLodge.Src.ViewModel.RoomCheckInViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
