#pragma checksum "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87b4a017b75e44ce3c160d926b1513addd486d52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87b4a017b75e44ce3c160d926b1513addd486d52", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"484d93dbb13ecb5f5d9ee2b3cbbde234810f7876", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\Account\Login.cshtml"
  
    Layout = "_AccountLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"limiter\">\r\n    <div class=\"container-login100\">\r\n        <div class=\"wrap-login100 p-l-85 p-r-85 p-t-55 p-b-55\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\Account\Login.cshtml"
             using (Html.BeginForm("Login", "Account", FormMethod.Post, null))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"login100-form-title p-b-32\">\r\n                    Account Login\r\n                </span>\r\n                <div class=\"wrap-input100 validate-input m-b-36\">\r\n                    ");
#nullable restore
#line 15 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\Account\Login.cshtml"
               Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <span class=\"txt1 p-b-11\">\r\n                    Username\r\n                </span>\r\n                <div class=\"wrap-input100 validate-input m-b-36\" data-validate=\"Username is required\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\Account\Login.cshtml"
               Write(Html.TextBoxFor(x => x.UserName, null, new { @class = "input100" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <span class=\"focus-input100\"></span>\r\n                </div>\r\n");
            WriteLiteral(@"                <span class=""txt1 p-b-11"">
                    Password
                </span>
                <div class=""wrap-input100 validate-input m-b-12"" data-validate=""Password is required"">
                    <span class=""btn-show-pass"">
                        <i class=""fa fa-eye""></i>
                    </span>
                    ");
#nullable restore
#line 32 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\Account\Login.cshtml"
               Write(Html.PasswordFor(x => x.Password, new { @class = "input100"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <span class=\"focus-input100\"></span>\r\n                </div>\r\n");
            WriteLiteral(@"                <div class=""container-login100-form-btn"">
                    <button type=""submit"" class=""login100-form-btn""  style=""margin-right: 23%;"">
                        Login
                    </button>
                    
                        ");
#nullable restore
#line 42 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\Account\Login.cshtml"
                   Write(Html.ActionLink("Sign Up", "SignUp", "Account", null, new { @class = "login100-form-btn text-white" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                   \r\n                </div>\r\n");
#nullable restore
#line 45 "C:\Users\Monster\source\repos\WebProgramming\WebProgramming\Views\Account\Login.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div id=\"dropDownSelect1\"></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
