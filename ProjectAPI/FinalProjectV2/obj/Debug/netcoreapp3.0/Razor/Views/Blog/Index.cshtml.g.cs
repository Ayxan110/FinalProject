#pragma checksum "C:\Users\Ayxan\Desktop\FinalProject\ProjectAPI\FinalProjectV2\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b2123c22bf05dfc23a87958087ea37c251d98af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\Ayxan\Desktop\FinalProject\ProjectAPI\FinalProjectV2\Views\_ViewImports.cshtml"
using FinalProjectV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ayxan\Desktop\FinalProject\ProjectAPI\FinalProjectV2\Views\_ViewImports.cshtml"
using FinalProjectV2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ayxan\Desktop\FinalProject\ProjectAPI\FinalProjectV2\Views\_ViewImports.cshtml"
using ProjectAPI.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ayxan\Desktop\FinalProject\ProjectAPI\FinalProjectV2\Views\_ViewImports.cshtml"
using FinalProjectV2.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b2123c22bf05dfc23a87958087ea37c251d98af", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdd00e121c3abfb89083c3c1f25eee9d401e38e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalProjectV2.Data.ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Ayxan\Desktop\FinalProject\ProjectAPI\FinalProjectV2\Views\Blog\Index.cshtml"
   
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <main class=\"blog container\">\r\n        <h4 class=\"blogtitle\">Blog</h4>\r\n");
#nullable restore
#line 7 "C:\Users\Ayxan\Desktop\FinalProject\ProjectAPI\FinalProjectV2\Views\Blog\Index.cshtml"
          
            foreach (var item in Model.News)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"news-box\">\r\n                    <h5 class=\"title\">");
#nullable restore
#line 11 "C:\Users\Ayxan\Desktop\FinalProject\ProjectAPI\FinalProjectV2\Views\Blog\Index.cshtml"
                                 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <span>");
#nullable restore
#line 12 "C:\Users\Ayxan\Desktop\FinalProject\ProjectAPI\FinalProjectV2\Views\Blog\Index.cshtml"
                     Write(item.PublishedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <div class=\"blog-img\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3b2123c22bf05dfc23a87958087ea37c251d98af5140", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 470, "~/img/", 470, 6, true);
#nullable restore
#line 14 "C:\Users\Ayxan\Desktop\FinalProject\ProjectAPI\FinalProjectV2\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 476, item.Image, 476, 11, false);

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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 17 "C:\Users\Ayxan\Desktop\FinalProject\ProjectAPI\FinalProjectV2\Views\Blog\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProjectV2.Data.ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
