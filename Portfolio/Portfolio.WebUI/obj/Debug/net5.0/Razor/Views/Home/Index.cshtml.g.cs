#pragma checksum "C:\Users\User\source\repos\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de3cbcf64d93922e3bbcda4583d0a5e917fde72d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de3cbcf64d93922e3bbcda4583d0a5e917fde72d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Resume", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Portfolio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\source\repos\Portfolio\Portfolio.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- NAV LINKS -->
<nav>
    <!-- Brand and toggle get grouped for better mobile display -->
    <button type=""button"" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target=""#nav-tabis"" aria-expanded=""false""> <span class=""tittle"">MENU</span> <span class=""fa fa-navicon icon-nav"" aria-hidden=""true""></span> </button>
    <!-- Collect the nav links, forms, and other content for toggling -->
    <div class=""collapse navbar-collapse"" id=""nav-tabis"">
        <ul class=""isop-filter nav nav-pills"">
            <li role=""presentation"" class=""active"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de3cbcf64d93922e3bbcda4583d0a5e917fde72d5635", async() => {
                WriteLiteral("<i class=\"icon-user\"></i> ABOUT ME");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n            <li role=\"presentation\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de3cbcf64d93922e3bbcda4583d0a5e917fde72d7069", async() => {
                WriteLiteral("<i class=\"icon-book-open\"></i>RESUME");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n            <li role=\"presentation\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de3cbcf64d93922e3bbcda4583d0a5e917fde72d8505", async() => {
                WriteLiteral("<i class=\"icon-rocket\"></i>PORTFOLIO");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n            <li role=\"presentation\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de3cbcf64d93922e3bbcda4583d0a5e917fde72d9941", async() => {
                WriteLiteral("<i class=\"icon-note\"></i>BLOG");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n            <li role=\"presentation\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de3cbcf64d93922e3bbcda4583d0a5e917fde72d11370", async() => {
                WriteLiteral(" <i class=\"icon-pencil\"></i>CONTACT ME");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
        </ul>
    </div>
</nav>
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
                    <p> <span> Name</span> John Doe </p>
                </li>
                <li>
                    <p> <span> Age</span> 38 Years </p>
                </li>
                <li>
                    <p> <span> Location</span> Rome, Italy </p>
                </li>
                <li>
                    <p> <span> Experience</span> 15 Years </p>
                </li>
                <li>
                    <p> <span> Degree</span> MBA </p>
                </li>
                <li>
                    <p> <span> Career Level</span> Mid-Level </p>
               ");
            WriteLiteral(@" </li>
                <li>
                    <p> <span> Phone</span> (800) 123-4567 </p>
                </li>
                <li>
                    <p> <span> FAX</span> (800) 123-4568 </p>
                </li>
                <li>
                    <p> <span> E-mail</span> <a href=""#.""> example@example.com</a> </p>
                </li>
                <li>
                    <p> <span> Website</span><a href=""#.""> example.com </a></p>
                </li>
            </ul>

            <!-- I???m Web Designer -->
            <h5 class=""tittle"">I???m Web Designer</h5>
            <div class=""padding-20"">
                <p>
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. Cras vel lorem. Etiam pellentesque aliquet tellus. Phasellus pharetra nulla ac diam. <br>
                    <br>
                    Quisque semper justo at risus. Donec venenatis, turpis vel hendrerit interdum, dui ligul");
            WriteLiteral(@"a ultricies purus, sed posuere libero dui id orci. Nam congue, pede vitae dapibus aliquet, elit magna vulputate arcu, vel tempus metus leo non est. Etiam sit amet lectus quis est congue mollis. Phasellus congue lacus eget neque. Phasellus ornare, ante vitae consectetuer consequat, purus sapien ultricies dolor, et mollis pede metus eget nisi. <br>
                    <br>
                </p>
            </div>

            <!-- Services -->
            <h5 class=""tittle"">Services</h5>
            <div class=""row padding-20 margin-top-50"">

                <!-- Icon -->
                <div class=""col-md-4 text-center"">
                    <div class=""icon-box i-large ib-black"">
                        <div class=""ib-icon""> <i class=""fa fa-whatsapp"" aria-hidden=""true""></i> </div>
                        <div class=""ib-info"">
                            <h4 class=""h6"">WEB DEVELOPMENT</h4>
                            <p>We have created the new macbook psd version with scalable vector shapes.</p>
");
            WriteLiteral(@"                        </div>
                    </div>
                </div>

                <!-- Icon -->
                <div class=""col-md-4 text-center"">
                    <div class=""icon-box i-large ib-black"">
                        <div class=""ib-icon""> <i class=""fa fa-magic"" aria-hidden=""true""></i> </div>
                        <div class=""ib-info"">
                            <h4 class=""h6"">WEB DESIGN</h4>
                            <p>We have created the new macbook psd version with scalable vector shapes.</p>
                        </div>
                    </div>
                </div>

                <!-- Icon -->
                <div class=""col-md-4 text-center"">
                    <div class=""icon-box i-large ib-black"">
                        <div class=""ib-icon""> <i class=""fa fa-smile-o"" aria-hidden=""true""></i> </div>
                        <div class=""ib-info"">
                            <h4 class=""h6"">RESPONSIVE</h4>
                            <p>We hav");
            WriteLiteral(@"e created the new macbook psd version with scalable vector shapes.</p>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Icon Row -->
            <div class=""row padding-20 margin-bottom-50"">

                <!-- Icon -->
                <div class=""col-md-4"">
                    <div class=""icon-box i-large ib-black"">
                        <div class=""ib-icon""> <i class=""fa fa-diamond"" aria-hidden=""true""></i> </div>
                        <div class=""ib-info"">
                            <h4 class=""h6"">Unique Design</h4>
                            <p>We have created the new macbook psd version with scalable vector shapes.</p>
                        </div>
                    </div>
                </div>

                <!-- Icon -->
                <div class=""col-md-4"">
                    <div class=""icon-box i-large ib-black"">
                        <div class=""ib-icon""> <i class=""fa fa-server"" aria-hidden=");
            WriteLiteral(@"""true""></i> </div>
                        <div class=""ib-info"">
                            <h4 class=""h6"">Demos Layout</h4>
                            <p>We have created the new macbook psd version with scalable vector shapes.</p>
                        </div>
                    </div>
                </div>

                <!-- Icon -->
                <div class=""col-md-4"">
                    <div class=""icon-box i-large ib-black"">
                        <div class=""ib-icon""> <i class=""fa fa-scissors"" aria-hidden=""true""></i> </div>
                        <div class=""ib-info"">
                            <h4 class=""h6"">Clean Code</h4>
                            <p>We have created the new macbook psd version with scalable vector shapes.</p>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Skills -->
            <h5 class=""tittle"">Skills</h5>

            <!-- Sound Engineering -->
            <div class=""pan");
            WriteLiteral(@"el-group accordion padding-20"" id=""accordion"">
                <div class=""panel panel-default"">
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <!-- PANEL HEADING -->
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""> <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseOne"" class=""collapsed""> Photoshop</a> </h4>
                            </div>
                        </div>

                        <!-- Skillls Bars -->
                        <div class=""col-sm-8"">
                            <div class=""progress"">
                                <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""80"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 80%;""> <span class=""sr-only"">60% Complete</span> </div>
                            </div>

                            <!-- Skillls Text -->
                            <div id=""collapseOne"" ");
            WriteLiteral(@"class=""panel-collapse collapse"">
                                <div class=""panel-body"">
                                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. Cras vel lorem.</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- Business Administration -->

                <div class=""panel panel-default"">
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <!-- PANEL HEADING -->
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""> <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapsetwo"" class=""collapsed""> Dreamviewer</a> </h4>
                            </div>
                        </div>

                        <!-- Skillls Bars -->
    ");
            WriteLiteral(@"                    <div class=""col-sm-8"">
                            <div class=""progress"">
                                <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 60%;""> <span class=""sr-only"">60% Complete</span> </div>
                            </div>

                            <!-- Skillls Text -->
                            <div id=""collapsetwo"" class=""panel-collapse collapse"">
                                <div class=""panel-body"">
                                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. Cras vel lorem.</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- HTML -->
                <div class=""panel panel-default"">
                    <div class=""row"">
                        <div ");
            WriteLiteral(@"class=""col-sm-4"">
                            <!-- PANEL HEADING -->
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""> <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapsethree"" class=""collapsed""> HTML5/CSS3</a> </h4>
                            </div>
                        </div>

                        <!-- Skillls Bars -->
                        <div class=""col-sm-8"">
                            <div class=""progress"">
                                <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 100%;""> <span class=""sr-only"">60% Complete</span> </div>
                            </div>

                            <!-- Skillls Text -->
                            <div id=""collapsethree"" class=""panel-collapse collapse"">
                                <div class=""panel-body"">
                                    <p>Lorem ipsum dolor sit amet, c");
            WriteLiteral(@"onsectetur adipiscing elit. Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. Cras vel lorem.</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
