#pragma checksum "C:\Users\e5641974\source\repos\WebApplication2\WebApplication2\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71285a7921a24ec2b548a3a0f2e960a6a01398fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication2.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace WebApplication2.Pages
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
#line 1 "C:\Users\e5641974\source\repos\WebApplication2\WebApplication2\Pages\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71285a7921a24ec2b548a3a0f2e960a6a01398fa", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"538f37ef395561d5f352aabc9fc72bce1358fc6b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\e5641974\source\repos\WebApplication2\WebApplication2\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a the new Devops Countinious Integrations..</a>.</p>\r\n</div>\r\n\r\n");
            WriteLiteral(@"
<div class=""login-wrap"">
    <div class=""login-html"">
        <input id=""tab-1"" type=""radio"" name=""tab"" class=""sign-in"" checked><label for=""tab-1"" class=""tab"">Sign In</label>
        <input id=""tab-2"" type=""radio"" name=""tab"" class=""sign-up""><label for=""tab-2"" class=""tab"">Sign Up</label>
        <div class=""login-form"">
            <div class=""sign-in-htm"">
                <div class=""group"">
                    <label for=""user"" class=""label"">Username</label>
                    <input id=""user"" type=""text"" class=""input"">
                </div>
                <div class=""group"">
                    <label for=""pass"" class=""label"">Password</label>
                    <input id=""pass"" type=""password"" class=""input"" data-type=""password"">
                </div>
                <div class=""group"">
                    <input id=""check"" type=""checkbox"" class=""check"" checked>
                    <label for=""check""><span class=""icon""></span> Keep me Signed in</label>
                </div>
        ");
            WriteLiteral(@"        <div class=""group"">
                    <input type=""submit"" class=""button"" value=""Sign In"">
                </div>
                <div class=""hr""></div>
                <div class=""foot-lnk"">
                    <a href=""#forgot"">Forgot Password?</a>
                </div>
            </div>
            <div class=""sign-up-htm"">
                <div class=""group"">
                    <label for=""user"" class=""label"">Username</label>
                    <input id=""user"" type=""text"" class=""input"">
                </div>
                <div class=""group"">
                    <label for=""pass"" class=""label"">Password</label>
                    <input id=""pass"" type=""password"" class=""input"" data-type=""password"">
                </div>
                <div class=""group"">
                    <label for=""pass"" class=""label"">Repeat Password</label>
                    <input id=""pass"" type=""password"" class=""input"" data-type=""password"">
                </div>
                <div class=""g");
            WriteLiteral(@"roup"">
                    <label for=""pass"" class=""label"">Email Address</label>
                    <input id=""pass"" type=""text"" class=""input"">
                </div>
                <div class=""group"">
                    <input type=""submit"" class=""button"" value=""Sign Up"">
                </div>
                <div class=""hr""></div>
                <div class=""foot-lnk"">
                    <label for=""tab-1"">Already Member?</a>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
