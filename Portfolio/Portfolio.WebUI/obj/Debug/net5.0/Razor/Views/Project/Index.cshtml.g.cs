#pragma checksum "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Project\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59b059b7201bfc135693e1b1209c6debe1442d3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Index), @"mvc.1.0.view", @"/Views/Project/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59b059b7201bfc135693e1b1209c6debe1442d3a", @"/Views/Project/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fb3c500b1c5833f8b467a4764844cb3f928cc5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedViewModel<Project>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Open Imagination"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Project", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("go"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Project\Index.cshtml"
  
    ViewData["Title"] = "Portfolio";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




<div role=""tabpanel"" class=""tab-pane fade active in"" id=""portfolio"">
    <div class=""inside-sec"">
        <!-- BIO AND SKILLS -->
        <h5 class=""tittle"">PORTFOLIO</h5>

        <!-- PORTFOLIO -->
        <section class=""portfolio padding-top-50 padding-bottom-50"">
            <!-- Work Filter -->
            <ul class=""tabs portfolio-filter text-center margin-bottom-30"">
                <li class=""filter active"" data-filter=""all"">all</li>
                <li class=""filter"" data-filter="".brand"">Branding</li>
                <li class=""filter"" data-filter="".design"">designing</li>
                <li class=""filter"" data-filter="".photo"">photography</li>
                <li class=""filter"" data-filter="".visual"">visual design</li>
            </ul>

            <!-- PORTFOLIO ITEMS -->
            <div id=""Container"" class=""item-space row col-3"" style=""height: 0px; perspective: 3000px; perspective-origin: 50% 50%; transition: height 600ms ease 0s;"">

                <!-- ITEM -->

");
#nullable restore
#line 31 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Project\Index.cshtml"
                 foreach (var item in Model.Items)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <!-- ITEM -->
                    <article class=""portfolio-item mix pf-web-design"" data-inter-pos-x=""0"" data-inter-pos-y=""0"" data-final-pos-x=""0"" data-final-pos-y=""0"" style=""transition: all 600ms ease 0ms, opacity 600ms linear; display: inline-block; transform: translate(0px, 0px);"" data-bound=""true"">
                        <div class=""portfolio-image"">
                            <a href=""#."">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "59b059b7201bfc135693e1b1209c6debe1442d3a7470", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1684, "~/uploads/images/portfolio/5/", 1684, 29, true);
#nullable restore
#line 37 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Project\Index.cshtml"
AddHtmlAttributeValue("", 1713, item.ImagePath, 1713, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </a>
                            <div class=""portfolio-overlay style-4"">
                                <div class=""detail-info"">
                                    <div class=""position-center-center"">
                                        <h3 class=""no-margin"">");
#nullable restore
#line 42 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Project\Index.cshtml"
                                                         Write(item.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                        <span>\r\n                                            <a href=\"#.\">");
#nullable restore
#line 44 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Project\Index.cshtml"
                                                    Write(item.ProjectType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </span>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59b059b7201bfc135693e1b1209c6debe1442d3a10250", async() => {
                WriteLiteral("<i class=\"fa fa-search\" aria-hidden=\"true\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Project\Index.cshtml"
                                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2450, "\"", 2468, 1);
#nullable restore
#line 47 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Project\Index.cshtml"
WriteAttributeValue("", 2457, item.CLink, 2457, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"" class=""go""><i class=""fa fa-link"" aria-hidden=""true""></i></a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </article>
");
#nullable restore
#line 53 "C:\Users\User\Desktop\Back-End-PORTFOLIO\Portfolio\Portfolio.WebUI\Views\Project\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n          \r\n        </section>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedViewModel<Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
