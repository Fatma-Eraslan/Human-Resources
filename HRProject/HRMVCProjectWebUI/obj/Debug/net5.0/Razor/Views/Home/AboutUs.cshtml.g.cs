#pragma checksum "C:\Users\FATOŞ\Source\Repos\HRProject\HRMVCProjectWebUI\Views\Home\AboutUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "232bddb4df7dbc9b26f525f03e4bcde6e19421c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AboutUs), @"mvc.1.0.view", @"/Views/Home/AboutUs.cshtml")]
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
#line 1 "C:\Users\FATOŞ\Source\Repos\HRProject\HRMVCProjectWebUI\Views\_ViewImports.cshtml"
using HRMVCProjectWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FATOŞ\Source\Repos\HRProject\HRMVCProjectWebUI\Views\_ViewImports.cshtml"
using HRMVCProjectWebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\FATOŞ\Source\Repos\HRProject\HRMVCProjectWebUI\Views\Home\AboutUs.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"232bddb4df7dbc9b26f525f03e4bcde6e19421c8", @"/Views/Home/AboutUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0e3a902020cb12dded0b0567616996ab9379d0e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_AboutUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/stylesheets/aboutUs.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\FATOŞ\Source\Repos\HRProject\HRMVCProjectWebUI\Views\Home\AboutUs.cshtml"
  
    int id = (int)Context.Session.GetInt32("Id");
    if(id<0)
    {
        Layout = "~/Views/Shared/_Layout.cshtml";
    }
    else
    {
        Layout = "_LayoutForEmployee";
    }
    ViewData["Title"] = "About Us";
   

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "232bddb4df7dbc9b26f525f03e4bcde6e19421c84927", async() => {
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
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "232bddb4df7dbc9b26f525f03e4bcde6e19421c86051", async() => {
                WriteLiteral(@"
    <div class=""col-md-3"">
        <section class=""panel"">
            <header class=""panel-heading"">
                <h2 class=""panel-title"">Şirketimiz</h2>
            </header>
            <div class=""panel-body"">
                <div class=""owl-carousel"" data-plugin-carousel data-plugin-options='{ ""items"": 1, ""autoHeight"": true }'>
                    <div class=""item"">
                        <img");
                BeginWriteAttribute("alt", " alt=\"", 784, "\"", 790, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""img-responsive"" src=""/assets/images/sirket.jpg"">
                    </div>
                </div>
            </div>
            <div class=""panel-body"">
                <div class=""owl-carousel"" data-plugin-carousel data-plugin-options='{ ""items"": 1, ""autoHeight"": true }'>
                    <div class=""item"">
                        <img");
                BeginWriteAttribute("alt", " alt=\"", 1149, "\"", 1155, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""img-responsive"" src=""/assets/images/sirket.jpg"">
                    </div>
                </div>
            </div>
            <div class=""panel-body"">
                <div class=""owl-carousel"" data-plugin-carousel data-plugin-options='{ ""items"": 1, ""autoHeight"": true }'>
                    <div class=""item"">
                        <img");
                BeginWriteAttribute("alt", " alt=\"", 1514, "\"", 1520, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""img-responsive"" src=""/assets/images/sirket.jpg"">
                    </div>
                </div>
            </div>
        </section>
    </div>

    <hr>

    <div id=""AboutUs"" class=""text-center"">
        <h1 class=""display-4"">Hakkımızda Sayfasına Hoşgeldiniz</h1>
        <p>Biz insan kaynakları desteği veren şirketiz.</p>
        <p>Amacımız, müşterilerimizin taleplerini en iyi şekilde karşılamaktır.</p>
        <p>Hedefimiz, her zaman büyüyerek bu sektördeki en iyi firma olmak.</p>
        <p>Değerli müşterilerimiz ile çalışmak bizim için bir zevktir.</p>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591