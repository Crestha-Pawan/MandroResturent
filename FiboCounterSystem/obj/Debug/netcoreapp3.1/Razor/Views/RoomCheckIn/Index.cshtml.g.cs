#pragma checksum "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdc3be8d564c4273d812882accc319ace9489680"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RoomCheckIn_Index), @"mvc.1.0.view", @"/Views/RoomCheckIn/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdc3be8d564c4273d812882accc319ace9489680", @"/Views/RoomCheckIn/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d7a7554eaab05fe64b8a2fb2f77723e544dd69", @"/Views/_ViewImports.cshtml")]
    public class Views_RoomCheckIn_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FiboLodge.Src.ViewModel.RoomCheckInViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
   Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Index"; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
   string room = string.Empty;
    var roomList = await _roomRepo.GetAllRoomAsync(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"col-sm-12\">\n\n    <div class=\"col-lg-12\">\n        <div class=\"card-body\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdc3be8d564c4273d812882accc319ace94896805801", async() => {
                WriteLiteral("\n                <div class=\"row\">\n                    <div class=\"col-lg-12\">\n                        <div class=\"row\">\n                            <div class=\"col-sm-3\">\n                                Room<br />\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdc3be8d564c4273d812882accc319ace94896806316", async() => {
                    WriteLiteral("\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 18 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RoomSetupId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 18 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
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
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"card\">\n        <div class=\"card-body\">\n");
            WriteLiteral(@"            <hr />
            <div class=""table-responsive"">
                <div class=""tableFixHead"">
                    <table class=""table table-bordered"">
                        <thead style=""background-color: #FFFFFFCC;"">
                            <tr>
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
                                <th>Status</th>
                                <th style=""text-align:center"">
                                    Action Name
                                </th>
                            </tr>
                        </thead>
            ");
            WriteLiteral("            <tbody>\n");
#nullable restore
#line 58 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
                             foreach (var item in Model.RoomCheckInList)
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
            WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 76 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
                   Write(room);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 79 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
                   Write(item.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 82 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
                   Write(item.ContactNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 85 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
                   Write(item.Advance);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n");
#nullable restore
#line 88 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
                         if (item.IsCheckIn())
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"badge badge-light-success\">");
#nullable restore
#line 90 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
                                           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ");
#nullable restore
#line 90 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
                                                                    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"badge badge-light-danger\">");
#nullable restore
#line 93 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
                                  Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 93 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
                                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n                    <td style=\"text-align:center\">\n                        <div class=\"btn-group-sm\">\n                            <a type=\"button\" class=\"btn btn-secondary\" href=\"#!\" data-toggle=\"modal\"");
            BeginWriteAttribute("RoomCheckInId", " RoomCheckInId=\"", 4272, "\"", 4296, 1);
#nullable restore
#line 97 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
WriteAttributeValue("", 4288, item.Id, 4288, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-target=\"#myModal\">\n                               <i class=\"ti-pencil-alt\" data-toggle=\"tooltip\" title=\"Edit\"></i>\n                            </a>\n                            <a type=\"button\" class=\"btn btn-danger\" href=\"#!\" data-toggle=\"modal\"");
            BeginWriteAttribute("RoomCheckInId", " RoomCheckInId=\"", 4548, "\"", 4572, 1);
#nullable restore
#line 100 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
WriteAttributeValue("", 4564, item.Id, 4564, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-target=\"#myModal\"><i class=\"ti-trash\" data-toggle=\"tooltip\" title=\"Delete\"></i></a>\n                        </div>\n\n                    </td>\n                </tr>\n");
#nullable restore
#line 105 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
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
    <div class=""modal-dialog modal-md"" id=""DeleteBody"">

        <!-- /.modal-content -->
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdc3be8d564c4273d812882accc319ace948968017481", async() => {
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
            WriteLiteral("\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(""#myModal"").on('show.bs.modal', function (ke) {
            const roomId = $(ke.relatedTarget).attr('RoomCheckInId');
            const type = $(ke.relatedTarget).attr('ReferenceType');
            if (roomId > 0) {
                if (type == null) {
                    var url = '");
#nullable restore
#line 131 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
                          Write(Url.Action("Delete", "RoomCheckIn"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' + \"?id=\" + roomId;\n                    $(\"#DeleteBody\").load(url, function () {\n                        $(\"#myModal\").modal(\'show\');\n                    });\n                }\n                else {\n                    var url = \'");
#nullable restore
#line 137 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
                          Write(Url.Action("Update", "RoomCheckIn"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' + \"?id=\" + roomId;\n                    $(\"#DeleteBody\").load(url, function () {\n                        $(\"#myModal\").modal(\'show\');\n                    });\n                }\n            }\n            else {\n                var url = \'");
#nullable restore
#line 144 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
                      Write(Url.Action("Create", "RoomCheckIn"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
                $(""#DeleteBody"").load(url, function () {
                    $(""#myModal"").modal('show');
                });
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
#line 157 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
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
#line 176 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
           Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', \'success\');\n    /**/\n    });\n</script>");
#nullable restore
#line 179 "E:\MandroRestaurantCounterBilling\FiboCounterSystem\Views\RoomCheckIn\Index.cshtml"
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
