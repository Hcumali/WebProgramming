#pragma checksum "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac99b7a24eb445476675bab5e0e5fa1c8880ed49"
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
#line 1 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\_ViewImports.cshtml"
using WebProgramming.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac99b7a24eb445476675bab5e0e5fa1c8880ed49", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"484d93dbb13ecb5f5d9ee2b3cbbde234810f7876", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<News>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("    <!-- Main Content -->\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12 col-md-12 mx-auto\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 8 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\Home\Index.cshtml"
                 foreach (var news in Model)
                {
                    string imgSrc = String.Empty;
                    if (news.Image != null)
                    {
                        var base64 = Convert.ToBase64String(news.Image);
                        imgSrc = String.Format("data:image/gif;base64,{0}", base64);
                    }


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4 col-sm-12 loadDiv\">\r\n\r\n                        <div class=\"card\" style=\"width: 18rem;height: 45vh;\">\r\n                            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 750, "\"", 763, 1);
#nullable restore
#line 20 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\Home\Index.cshtml"
WriteAttributeValue("", 756, imgSrc, 756, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" style=\" height: 40%;\">\r\n                            <div class=\"card-body\">\r\n                                <h5 class=\"card-title\">");
#nullable restore
#line 22 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\Home\Index.cshtml"
                                                  Write(news.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p style=\"margin-top: 0; font-weight: bold; font-size: 1em;\" class=\"card-title\">");
#nullable restore
#line 23 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\Home\Index.cshtml"
                                                                                                           Write(news.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p style=\"margin: 0;font-size: 1em;\" class=\"card-text\">");
#nullable restore
#line 24 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\Home\Index.cshtml"
                                                                                  Write(news.Description.Substring(0, 15));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</p>\r\n                                <button type=\"button\" class=\"bottomButton btn btn-primary\" data-toggle=\"modal\" data-target=\"#exampleModal-");
#nullable restore
#line 25 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\Home\Index.cshtml"
                                                                                                                                     Write(news.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                    Load More\r\n                                </button>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 1580, "\"", 1606, 2);
            WriteAttributeValue("", 1585, "exampleModal-", 1585, 13, true);
#nullable restore
#line 32 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\Home\Index.cshtml"
WriteAttributeValue("", 1598, news.Id, 1598, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                        <div class=""modal-dialog modal-lg"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <img class=""card-img-top""");
            BeginWriteAttribute("src", " src=\"", 1948, "\"", 1961, 1);
#nullable restore
#line 36 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\Home\Index.cshtml"
WriteAttributeValue("", 1954, imgSrc, 1954, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" style=\" height: 100%;\">\r\n                                </div>\r\n                                <div class=\"modal-body\">\r\n                                    <h5 class=\"modal-title\" id=\"exampleModalLabel\">");
#nullable restore
#line 39 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\Home\Index.cshtml"
                                                                              Write(news.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <hr />\r\n                                    ");
#nullable restore
#line 41 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\Home\Index.cshtml"
                               Write(news.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                                <div class=""modal-footer"">
                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 49 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\Home\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <hr>
            <!-- Pager -->
            <div class=""clearfix"">
                <a class=""btn btn-primary float-right"" href=""#"" id=""loadMore"">Load More &rarr;</a>
            </div>



        </div>
    </div>
</div>

<style>
    .bottomButton {
        position: absolute;
        bottom: 20px;
        right: 13px;
    }

    .col-md-4.col-sm-12 {
        margin-bottom: 2%;
    }

    .loadDiv {
        display: none;
    }

    .noContent {
        color: #000 !important;
        background-color: transparent !important;
        pointer-events: none;
    }

</style>
<script>
    $(document).ready(function () {
        $("".loadDiv"").slice(0, 3).show();
        $(""#loadMore"").on(""click"", function (e) {
            e.preventDefault();
            $("".loadDiv:hidden"").slice(0, 3).slideDown();
            if ($("".loadDiv:hidden"").length == 0) {
                $(""#loadMore"").text(""No Content"").addClass(""noContent"");
            }
     ");
            WriteLiteral("   });\r\n\r\n    })\r\n    window.onscroll = function () { myFunction() };\r\n    function myFunction() {\r\n        if (scrollY > document.body.scrollHeight / 5) {\r\n            document.getElementById(\"loadMore\").click();\r\n        }\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
