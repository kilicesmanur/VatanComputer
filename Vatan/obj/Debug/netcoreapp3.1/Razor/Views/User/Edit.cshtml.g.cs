<<<<<<< HEAD
#pragma checksum "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26a3261843cd1733ff83b5fea3b75e89619ecc22"
=======
#pragma checksum "C:\Users\User\Desktop\MVC\Yeni klasör\Vatan\Vatan\Views\User\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beb297d37089508b4efdcd50748a12854777e3a1"
>>>>>>> a62cc9af49e8b23fc734c47a70c02ad2af73eb37
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Edit), @"mvc.1.0.view", @"/Views/User/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26a3261843cd1733ff83b5fea3b75e89619ecc22", @"/Views/User/Edit.cshtml")]
    public class Views_User_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vatan.Models.VM.UserVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\MVC\Yeni klasör\Vatan\Vatan\Views\User\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Edit</h1>\n");
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header card-header-primary"">
                <h4 class=""card-title"">Edit User</h4>
                <p class=""card-category"">Edit a user</p>
            </div>
            <div class=""card-body"">
                <form action=""/User/Edit"" method=""post"">

                    ");
#nullable restore
#line 20 "C:\Users\User\Desktop\MVC\Yeni klasör\Vatan\Vatan\Views\User\Edit.cshtml"
               Write(await Html.PartialAsync("Partial/UserForm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                    ");
#nullable restore
#line 22 "C:\Users\User\Desktop\MVC\Yeni klasör\Vatan\Vatan\Views\User\Edit.cshtml"
               Write(Html.HiddenFor(q => q.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                    <button type=\"submit\" class=\"btn btn-primary pull-right\">Edit User</button>\n                    <div class=\"clearfix\"></div>\n                </form>\n            </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vatan.Models.VM.UserVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
