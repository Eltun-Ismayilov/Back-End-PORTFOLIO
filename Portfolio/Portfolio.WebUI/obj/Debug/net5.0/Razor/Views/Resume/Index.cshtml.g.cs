#pragma checksum "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf715aba47a776635ce45c2a7a2eb36e722e0f84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Resume_Index), @"mvc.1.0.view", @"/Views/Resume/Index.cshtml")]
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
#line 3 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.Domain.Model.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.Domain.Model.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.Domain.Model.DataContexts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.Domain.Model.FormModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf715aba47a776635ce45c2a7a2eb36e722e0f84", @"/Views/Resume/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8d620982dd95aa33b2845380dfdb7449a3b4d3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Resume_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResumeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
  
    ViewData["Title"] = "Resume";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"





<div role=""tabpanel"" class=""tab-pane fade active in"" id=""resume"">
    <div class=""inside-sec"">
        <!-- BIO AND SKILLS -->

        <h5 class=""tittle"">Bio &amp; Skills</h5>
        <div class=""bio-info padding-30"">
            <p>
                ");
#nullable restore
#line 18 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
           Write(Html.Raw(Model.Bios.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n\r\n            <div class=\"skills\">\r\n\r\n                <!-- HARD SKILLS -->\r\n                <h5 class=\"margin-top-30\">Hard Skills</h5>\r\n\r\n                <div class=\"panel-group accordion\" id=\"accordion\">\r\n");
#nullable restore
#line 27 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
                     foreach (var item in Model.Skills.Where(s => s.isHardSkill == true))
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""panel panel-default"">
                            <div class=""row"">
                                <div class=""col-sm-4"">
                                    <!-- PANEL HEADING -->
                                    <div class=""panel-heading"">
                                        <h4 class=""panel-title""> <a data-toggle=""collapse"" data-parent=""#accordion5""");
            BeginWriteAttribute("href", " href=\"", 1110, "\"", 1126, 2);
            WriteAttributeValue("", 1117, "#", 1117, 1, true);
#nullable restore
#line 35 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
WriteAttributeValue("", 1118, item.Id, 1118, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapsed\">");
#nullable restore
#line 35 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
                                                                                                                                                   Write(item.SkillName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a> </h4>
                                    </div>
                                </div>

                                <!-- Skillls Bars -->
                                <div class=""col-sm-8"">
                                    <div class=""progress"">
                                        <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""80"" aria-valuemin=""0"" aria-valuemax=""100""");
            BeginWriteAttribute("style", " style=\"", 1571, "\"", 1608, 3);
            WriteAttributeValue("", 1579, "width:", 1579, 6, true);
#nullable restore
#line 42 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
WriteAttributeValue(" ", 1585, item.SkillPercentage, 1586, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1607, ";", 1607, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <span class=\"sr-only\"> </span> </div>\r\n                                    </div>\r\n\r\n                                    <!-- Skillls Text -->\r\n                                    <div");
            BeginWriteAttribute("id", " id=\"", 1795, "\"", 1808, 1);
#nullable restore
#line 46 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
WriteAttributeValue("", 1800, item.Id, 1800, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse collapsed\" >\r\n                                        <div class=\"panel-body\">\r\n                                            <p>");
#nullable restore
#line 48 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
                                          Write(item.SkillDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 54 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <!-- Soft Skills -->\r\n                <h5 class=\"margin-top-30\">Soft Skills</h5>\r\n\r\n                <!-- Application of knowledge -->\r\n\r\n                <div class=\"panel-group accordion\" id=\"accordion5\">\r\n");
#nullable restore
#line 64 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
                     foreach (var item in Model.Skills.Where(s => s.isHardSkill == false))
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""panel panel-default"">
                            <div class=""row"">
                                <div class=""col-sm-4"">
                                    <!-- PANEL HEADING -->
                                    <div class=""panel-heading"">
                                        <h4 class=""panel-title""> <a data-toggle=""collapse"" data-parent=""#accordion5""");
            BeginWriteAttribute("href", " href=\"", 2974, "\"", 2990, 2);
            WriteAttributeValue("", 2981, "#", 2981, 1, true);
#nullable restore
#line 72 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
WriteAttributeValue("", 2982, item.Id, 2982, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapsed\" >");
#nullable restore
#line 72 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
                                                                                                                                                    Write(item.SkillName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a> </h4>
                                    </div>
                                </div>

                                <!-- Skillls Bars -->
                                <div class=""col-sm-8"">
                                    <div class=""progress"">
                                        <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""80"" aria-valuemin=""0"" aria-valuemax=""100""");
            BeginWriteAttribute("style", " style=\"", 3436, "\"", 3473, 3);
            WriteAttributeValue("", 3444, "width:", 3444, 6, true);
#nullable restore
#line 79 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
WriteAttributeValue(" ", 3450, item.SkillPercentage, 3451, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3472, ";", 3472, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <span class=\"sr-only\"> </span> </div>\r\n                                    </div>\r\n\r\n                                    <!-- Skillls Text -->\r\n                                    <div");
            BeginWriteAttribute("id", " id=\"", 3660, "\"", 3673, 1);
#nullable restore
#line 83 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
WriteAttributeValue("", 3665, item.Id, 3665, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse collapsed\">\r\n                                        <div class=\"panel-body\">\r\n                                            <p>");
#nullable restore
#line 85 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
                                          Write(item.SkillDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 91 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>


                <!-- Follow ethical -->
                <div class=""ethical"">
                    <h6>Follow ethical work practices</h6>
                    <a href=""#."">Prioritize Learning Tasks</a> <a href=""#."">Make Ethical Choices</a> <a href=""#."">Social Work</a> <a href=""#."">Community Work</a>
                </div>
            </div>
        </div>
    </div>

    <!-- Professional Experience -->
    <div class=""inside-sec margin-top-30"">
        <!-- Professional Experience -->
        <h5 class=""tittle"">Professional Experience</h5>
        <div class=""padding-30 exp-history"">

");
#nullable restore
#line 111 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
             foreach (var item in Model.Experiencess)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <!-- Wordpress Developer -->\r\n                <div class=\"exp\">\r\n                    <div class=\"media-left\"> <span class=\"sun\">");
#nullable restore
#line 115 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
                                                          Write(item.TimeInterval);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </div>\r\n                    <div class=\"media-body\">\r\n\r\n                        <!-- COmpany Logo -->\r\n                        <div class=\"company-logo\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf715aba47a776635ce45c2a7a2eb36e722e0f8414683", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5108, "~/uploads/images/", 5108, 17, true);
#nullable restore
#line 119 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
AddHtmlAttributeValue("", 5125, item.Logo, 5125, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </div>\r\n                        <h6>");
#nullable restore
#line 120 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
                       Write(item.WorkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <p>");
#nullable restore
#line 121 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
                      Write(item.WorkType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 122 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
                      Write(item.WorkPlace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"margin-top-10\">");
#nullable restore
#line 123 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
                                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("<a href=\"#.\">Read More</a> </p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 126 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"


            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <!-- Academic Background -->\r\n    <div class=\"inside-sec margin-top-30\">\r\n        <!-- Academic Background -->\r\n        <h5 class=\"tittle\">Academic Background</h5>\r\n        <div class=\"padding-30 exp-history\">\r\n");
#nullable restore
#line 138 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
             foreach (var item in Model.Educations)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <!-- Wordpress Developer -->\r\n                <div class=\"exp\">\r\n                    <div class=\"media-left\"> <span class=\"sun\">");
#nullable restore
#line 142 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
                                                          Write(item.TimeInterval);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> </div>
                    <div class=""media-body"">
                        <!-- COmpany Logo -->
                        <div class=""company-logo""> <span class=""diploma""><i class=""fa fa-graduation-cap"" aria-hidden=""true""></i> Download Diploma</span> </div>
                        <h6>");
#nullable restore
#line 146 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
                       Write(item.Occoption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <p>");
#nullable restore
#line 147 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
                      Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 148 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
                      Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"margin-top-10\">");
#nullable restore
#line 149 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
                                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a href=\"#.\">Read More</a> </p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 152 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Resume\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResumeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
