#pragma checksum "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a48b489867b2ebdbb4bc4750964075605bf9d2c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
using Portfolio.WebUI.Model.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.WebUI.Model.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.WebUI.Appcode.Application.ResumeMolus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.WebUI.Appcode.Application.EducationMolus;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a48b489867b2ebdbb4bc4750964075605bf9d2c3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fb3c500b1c5833f8b467a4764844cb3f928cc5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- NAV LINKS -->
<!-- NAV LINKS END -->

<div role=""tabpanel"" class=""tab-pane fade active in"" id=""about-me"">
    <div class=""inside-sec"">
        <!-- BIO AND SKILLS -->
        <h5 class=""tittle"">About Me</h5>

        <!-- Blog -->
        <section class=""about-me padding-top-10"">

            <!-- Personal Info -->
            <ul class=""personal-info"">
                <li>
                    <p> <span> Name</span> ");
#nullable restore
#line 21 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
                                      Write(Model.PersonalDetailss.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </li>\r\n                <li>\r\n                    <p> <span> Age</span> ");
#nullable restore
#line 24 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
                                     Write(Model.PersonalDetailss.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </li>\r\n                <li>\r\n                    <p> <span> Location</span> ");
#nullable restore
#line 27 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
                                          Write(Model.PersonalDetailss.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </li>\r\n                <li>\r\n                    <p> <span> Experience</span> ");
#nullable restore
#line 30 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
                                            Write(Model.PersonalDetailss.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </li>\r\n                <li>\r\n                    <p> <span> Degree</span> ");
#nullable restore
#line 33 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
                                        Write(Model.PersonalDetailss.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </li>\r\n                <li>\r\n                    <p> <span> Career Level</span> ");
#nullable restore
#line 36 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
                                              Write(Model.PersonalDetailss.CareerLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </li>\r\n                <li>\r\n                    <p> <span> Phone</span> ");
#nullable restore
#line 39 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
                                       Write(Model.PersonalDetailss.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </li>\r\n                <li>\r\n                    <p> <span> FAX</span> ");
#nullable restore
#line 42 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
                                     Write(Model.PersonalDetailss.Fax);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </li>\r\n                <li>\r\n                    <p> <span> E-mail</span> <a href=\"#.\"> ");
#nullable restore
#line 45 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
                                                      Write(Model.PersonalDetailss.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </p>\r\n                </li>\r\n                <li>\r\n                    <p> <span> Website</span><a href=\"#.\">");
#nullable restore
#line 48 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
                                                     Write(Model.PersonalDetailss.Website);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </a></p>\r\n                </li>\r\n            </ul>\r\n\r\n            <!-- I’m Web Designer -->\r\n            <h5 class=\"tittle\">");
#nullable restore
#line 53 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
                          Write(Model.PersonalDetailss.Occupation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <div class=\"padding-20\">\r\n                <p>\r\n                 ");
#nullable restore
#line 56 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
            Write(Html.Raw(Model.PersonalDetailss.About));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n            <!-- Services -->\r\n            <h5 class=\"tittle\">Services</h5>\r\n            <div class=\"row padding-20 margin-top-50\">\r\n\r\n");
#nullable restore
#line 64 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
                 foreach (var item in Model.Servicess)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <!-- Icon -->\r\n                    <div class=\"col-md-4 text-center\">\r\n                        <div class=\"icon-box i-large ib-black\">\r\n                            <div class=\"ib-icon\"> <i");
            BeginWriteAttribute("class", " class=\"", 2464, "\"", 2528, 1);
#nullable restore
#line 69 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 2472, item.Icons.FirstOrDefault(i=>i.ServiceId==item.Id).Icon, 2472, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-hidden=\"true\"></i> </div>\r\n                            <div class=\"ib-info\">\r\n                                <h4 class=\"h6\">");
#nullable restore
#line 71 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p>");
#nullable restore
#line 72 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 76 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("             \r\n            </div>\r\n\r\n          \r\n            <!-- Skills -->\r\n            <h5 class=\"tittle\">Skills</h5>\r\n\r\n            <!-- Sound Engineering -->\r\n            <div class=\"panel-group accordion padding-20\" id=\"accordion\">\r\n");
#nullable restore
#line 86 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
                 foreach (var item in Model.Skills.Where(s => s.isHardSkill == true))
                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""panel panel-default"">
                        <div class=""row"">
                            <div class=""col-sm-4"">
                                <!-- PANEL HEADING -->
                                <div class=""panel-heading"">
                                    <h4 class=""panel-title""> <a data-toggle=""collapse"" data-parent=""#accordion5""");
            BeginWriteAttribute("href", " href=\"", 3577, "\"", 3593, 2);
            WriteAttributeValue("", 3584, "#", 3584, 1, true);
#nullable restore
#line 94 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 3585, item.Id, 3585, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapsed\">");
#nullable restore
#line 94 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
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
            BeginWriteAttribute("style", " style=\"", 4014, "\"", 4051, 3);
            WriteAttributeValue("", 4022, "width:", 4022, 6, true);
#nullable restore
#line 101 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 4028, item.SkillPercentage, 4029, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4050, ";", 4050, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <span class=\"sr-only\"> </span> </div>\r\n                                </div>\r\n\r\n                                <!-- Skillls Text -->\r\n                                <div");
            BeginWriteAttribute("id", " id=\"", 4226, "\"", 4239, 1);
#nullable restore
#line 105 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 4231, item.Id, 4231, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse collapsed\">\r\n                                    <div class=\"panel-body\">\r\n                                        <p>");
#nullable restore
#line 107 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
                                      Write(item.SkillDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 113 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n               \r\n            </div>\r\n        </section>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
