#pragma checksum "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Views\News\AddNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ef019d3a25fceb3c5bb24f9be29670637ae31cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_AddNews), @"mvc.1.0.view", @"/Views/News/AddNews.cshtml")]
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
#line 1 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Views\_ViewImports.cshtml"
using WebProgramming.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ef019d3a25fceb3c5bb24f9be29670637ae31cb", @"/Views/News/AddNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"484d93dbb13ecb5f5d9ee2b3cbbde234810f7876", @"/Views/_ViewImports.cshtml")]
    public class Views_News_AddNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Views\News\AddNews.cshtml"
  
    Layout = "_AccountLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"limiter\">\r\n    <div class=\"container-login100\">\r\n        <div class=\"wrap-login100 p-l-85 p-r-85 p-t-55 p-b-55\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Views\News\AddNews.cshtml"
             using (Html.BeginForm("AddNews", "News", FormMethod.Post, new { enctype = "multipart/form-data" }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"login100-form-title p-b-32\">\r\n                    Add News\r\n                </span>\r\n");
            WriteLiteral("                <div class=\"wrap-input100 validate-input m-b-36\">\r\n                    ");
#nullable restore
#line 16 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Views\News\AddNews.cshtml"
               Write(Html.ValidationSummary(false, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 19 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Views\News\AddNews.cshtml"
           Write(Html.LabelFor(x => x.Title, "Title", new { @class = "txt1 p-b-11" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"wrap-input100 validate-input m-b-36\" data-validate=\"Username is required\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Views\News\AddNews.cshtml"
               Write(Html.TextBoxFor(x => x.Title, null, new { @class = "input100" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <span class=\"focus-input100\"></span>\r\n                </div>\r\n");
#nullable restore
#line 25 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Views\News\AddNews.cshtml"
           Write(Html.LabelFor(x => x.SubTitle, "SubTitle", new { @class = "txt1 p-b-11" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"wrap-input100 validate-input m-b-12\" data-validate=\"Password is required\">\r\n                    <span class=\"btn-show-pass\">\r\n                        <i class=\"fa fa-eye\"></i>\r\n                    </span>\r\n                    ");
#nullable restore
#line 30 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Views\News\AddNews.cshtml"
               Write(Html.TextBoxFor(x => x.SubTitle, new { @class = "input100" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <span class=\"focus-input100\"></span>\r\n                </div>\r\n");
#nullable restore
#line 34 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Views\News\AddNews.cshtml"
           Write(Html.LabelFor(x => x.Description, "Description", new { @class = "txt1 p-b-11" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"wrap-input100 validate-input m-b-12\" data-validate=\"Password is required\">\r\n                    <span class=\"btn-show-pass\">\r\n                        <i class=\"fa fa-eye\"></i>\r\n                    </span>\r\n                    ");
#nullable restore
#line 39 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Views\News\AddNews.cshtml"
               Write(Html.TextAreaFor(x => x.Description, new { @class = "input100" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <span class=\"focus-input100\"></span>\r\n                </div>\r\n");
#nullable restore
#line 43 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Views\News\AddNews.cshtml"
           Write(Html.LabelFor(x => x.Image, "Image", new { @class = "txt1 p-b-11" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""wrap-input100 validate-input m-b-12"" data-validate=""Password is required"">
                    <span class=""btn-show-pass"">
                        <i class=""fa fa-eye""></i>
                    </span>
                    <input type=""file"" name=""Image"" />
                    <span class=""focus-input100""></span>
                </div>
                <div class=""container-login100-form-btn"">
                    <button type=""submit"" class=""login100-form-btn"" style=""margin-right:17%;"">
                        Add News
                    </button>
                    <a class=""login100-form-btn"" href=""/admin"">Return Admin Panel</a>
                </div>
");
#nullable restore
#line 57 "C:\Users\Monster\Desktop\Cuma\WebProgramlama\WebProgramming\WebProgramming\Views\News\AddNews.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div id=\"dropDownSelect1\"></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
