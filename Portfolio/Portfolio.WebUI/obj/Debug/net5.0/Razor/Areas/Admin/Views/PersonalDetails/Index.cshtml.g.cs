#pragma checksum "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\PersonalDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "584ee38fd531498238ace0ecae85b750ecc2fc77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_PersonalDetails_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/PersonalDetails/Index.cshtml")]
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
#line 3 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.WebUI.Model.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.WebUI.Model.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.WebUI.Appcode.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.WebUI.Appcode.Application.BlogMolus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.WebUI.Appcode.Application.ProjectMolus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.WebUI.Appcode.Application.EducationMolus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.WebUI.Appcode.Application.ExperinceMolus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.WebUI.Appcode.Application.BioMolus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.WebUI.Appcode.Application.SkillMolus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.WebUI.Appcode.Application.PersonalMolus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.WebUI.Model.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.WebUI.Appcode.Application.IconMolus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Portfolio.WebUI.Appcode.Application.ServiceMolus;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"584ee38fd531498238ace0ecae85b750ecc2fc77", @"/Areas/Admin/Views/PersonalDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e44cbc739534e3af67d2d25c21dfb0fe66c74cd", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_PersonalDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonalDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/sweetalert/sweetalert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/toastr.js/toastr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/toastr.js/toastr.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\PersonalDetails\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div style=\"display:flex\">\r\n    <h1>Education Index</h1>\r\n\r\n\r\n</div>\r\n");
            WriteLiteral(@"<div class=""col-10"">
    <table class=""table table-striped"" border=""1"">
        <thead>
            <tr>
                <th scope=""col"">Name</th>
                <th scope=""col"">Email</th>
                <th scope=""col"">Age</th>
                <th scope=""col"">Phone</th>
                <th>
                




                </th>

            </tr>
        </thead>
        <tbody>
        
            <tr>
                <th>");
#nullable restore
#line 39 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\PersonalDetails\Index.cshtml"
               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\PersonalDetails\Index.cshtml"
               Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 41 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\PersonalDetails\Index.cshtml"
                Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 42 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\PersonalDetails\Index.cshtml"
                Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "584ee38fd531498238ace0ecae85b750ecc2fc7710973", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-pencil-alt\"></i>\r\n                        Edit\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\PersonalDetails\Index.cshtml"
                                                                           WriteLiteral(Model.Id);

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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "584ee38fd531498238ace0ecae85b750ecc2fc7713410", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-eye\"></i>\r\n\r\n                        Details\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\PersonalDetails\Index.cshtml"
                                                                           WriteLiteral(Model.Id);

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
            WriteLiteral("\r\n\r\n\r\n                   \r\n                </td>\r\n\r\n            </tr>\r\n            \r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
            DefineSection("addjs", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "584ee38fd531498238ace0ecae85b750ecc2fc7716078", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "584ee38fd531498238ace0ecae85b750ecc2fc7717178", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


    <script>

        function remove(id, name) {

            swal({
                title: ""Eminsiniz?"",
                text: `Testik etdiyiniz teqdirde  '${name}' sistemden  silinecek!`,
                type: ""warning"",
                showCancelButton: true,
                confirmButtonClass: ""btn-danger"",
                buttons: [""No"", ""Yes""]
            }).then(
                function (isConfirm) {
                    if (isConfirm) {


                        $.ajax({
                            url: '");
#nullable restore
#line 88 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Areas\Admin\Views\PersonalDetails\Index.cshtml"
                             Write(Url.Action("Delete"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                            type: 'POST',
                            data: { id },
                            contentType: 'application/x-www-form-urlencoded', // ne tip  gedecek?   2side model binding rolnu oynayir datani back gondermek ucun isdifade edilir  yeni back gonderilmeye xirmet edilir
                            dataType: 'json',
                    beforeSend: function () {
                        console.log(""sorgudan evvel"")   // loadir acmaq

                    },
                    success: function (response) {   // sorgunun neticesi ugurlu olsa
                        console.log(response)

                        if (response.error == false) {

                            toastr.success(response.Message, ""Ugurludur"");
                            window.location.reload();

                        } else {
                            toastr.error(response.Message, ""xeta"");

                        }
                    },
                            error: functio");
                WriteLiteral(@"n (response) {   // sorgunun neticesi ugursuz olsa
                                console.log(response)
                    },


                }).always(function () {
                         console.log(""sorgudan sonra"")  //loadir baglamaq

                });

                    }
                });
        };
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("addcss", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "584ee38fd531498238ace0ecae85b750ecc2fc7720695", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonalDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
