#pragma checksum "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Partial\Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adfa41981f98441c02f1bfc60369b3019b59c56f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partial_Header), @"mvc.1.0.view", @"/Views/Partial/Header.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adfa41981f98441c02f1bfc60369b3019b59c56f", @"/Views/Partial/Header.cshtml")]
    public class Views_Partial_Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""navbar-inner"">
    <a class=""brand"" href=""index.html""><img src=""themes/images/logo.png"" alt=""Bootsshop"" /></a>
    <form class=""form-inline navbar-search"" method=""post"" action=""products.html"">
        <input id=""srchFld"" class=""srchTxt"" type=""text"" />
        <select class=""srchTxt"">
            <option>All</option>
            <option>CLOTHES </option>
            <option>FOOD AND BEVERAGES </option>
            <option>HEALTH & BEAUTY </option>
            <option>SPORTS & LEISURE </option>
            <option>BOOKS & ENTERTAINMENTS </option>
        </select>
        <button type=""submit"" id=""submitButton"" class=""btn btn-primary"">Go</button>
    </form>
    <ul id=""topMenu"" class=""nav pull-right"">
        <li");
            BeginWriteAttribute("class", " class=\"", 748, "\"", 756, 0);
            EndWriteAttribute();
            WriteLiteral("><a href=\"special_offer.html\">Specials Offer</a></li>\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 823, "\"", 831, 0);
            EndWriteAttribute();
            WriteLiteral("><a href=\"normal.html\">Delivery</a></li>\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 885, "\"", 893, 0);
            EndWriteAttribute();
            WriteLiteral("><a href=\"contact.html\">Contact</a></li>\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 947, "\"", 955, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <a href=""#login"" role=""button"" data-toggle=""modal"" style=""padding-right:0""><span class=""btn btn-large btn-success"">Login</span></a>
            <div id=""login"" class=""modal hide fade in"" tabindex=""-1"" role=""dialog"" aria-labelledby=""login"" aria-hidden=""false"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">??</button>
                    <h3>Login Block</h3>
                </div>
                <div class=""modal-body"">
                    <form class=""form-horizontal loginFrm"">
                        <div class=""control-group"">
                            <input type=""text"" id=""inputEmail"" placeholder=""Email"">
                        </div>
                        <div class=""control-group"">
                            <input type=""password"" id=""inputPassword"" placeholder=""Password"">
                        </div>
                        <div class=""control-group"">
                       ");
            WriteLiteral(@"     <label class=""checkbox"">
                                <input type=""checkbox""> Remember me
                            </label>
                        </div>
                    </form>
                    <button type=""submit"" class=""btn btn-success"">Sign in</button>
                    <button class=""btn"" data-dismiss=""modal"" aria-hidden=""true"">Close</button>
                </div>
            </div>
        </li>
    </ul>
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
