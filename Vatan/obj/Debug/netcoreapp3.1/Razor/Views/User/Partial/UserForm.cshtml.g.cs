#pragma checksum "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52cdfdbfc978417a9765422ff3eecd23cd893687"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Partial_UserForm), @"mvc.1.0.view", @"/Views/User/Partial/UserForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52cdfdbfc978417a9765422ff3eecd23cd893687", @"/Views/User/Partial/UserForm.cshtml")]
    public class Views_User_Partial_UserForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vatan.Models.VM.UserVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 7 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml"
       Write(Html.LabelFor(q => q.Name, new { @class = "col-sm-3 text-left control-label col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 8 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml"
       Write(Html.TextBoxFor(q => q.Name, new { @placeholder = "Enter CategoryName name", @class = "form-control", @id = "fname" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 9 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml"
       Write(Html.ValidationMessageFor(q => q.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-12\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 14 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml"
       Write(Html.LabelFor(q => q.Surname, new { @class = "col-sm-3 text-left control-label col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 15 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml"
       Write(Html.TextBoxFor(q => q.Surname, new { @placeholder = "Enter CategoryName name", @class = "form-control", @id = "fname" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 16 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml"
       Write(Html.ValidationMessageFor(q => q.Surname, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-12\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 21 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml"
       Write(Html.LabelFor(q => q.Mail, new { @class = "col-sm-3 text-left control-label col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 22 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml"
       Write(Html.TextBoxFor(q => q.Mail, new { @placeholder = "Enter CategoryName name", @class = "form-control", @id = "fname", @type = "email" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 23 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml"
       Write(Html.ValidationMessageFor(q => q.Mail, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-12\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 28 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml"
       Write(Html.LabelFor(q => q.Password, new { @class = "col-sm-3 text-left control-label col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 29 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml"
       Write(Html.PasswordFor(q => q.Password, new { @placeholder = "Enter CategoryName name", @class = "form-control", @id = "fname"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 30 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml"
       Write(Html.ValidationMessageFor(q => q.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-12\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 35 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml"
       Write(Html.LabelFor(q => q.ConfirmPassword, new { @class = "col-sm-3 text-left control-label col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 36 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml"
       Write(Html.TextBoxFor(q => q.ConfirmPassword, new { @placeholder = "Enter CategoryName name", @class = "form-control", @id = "fname" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 37 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml"
       Write(Html.ValidationMessageFor(q => q.ConfirmPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-12\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 42 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml"
       Write(Html.LabelFor(q => q.Phone, new { @class = "col-sm-3 text-left control-label col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 43 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml"
       Write(Html.TextBoxFor(q => q.Phone, new { @placeholder = "Enter CategoryName name", @class = "form-control", @id = "fname", @type = "phone" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 44 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml"
       Write(Html.ValidationMessageFor(q => q.Phone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-12\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 49 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml"
       Write(Html.LabelFor(q => q.Address, new { @class = "col-sm-3 text-left control-label col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 50 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml"
       Write(Html.TextAreaFor(q => q.Address, new { @placeholder = "Enter CategoryName name", @class = "form-control", @id = "fname" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 51 "C:\Users\dgdm_\source\repos\Vatan\Vatan\Views\User\Partial\UserForm.cshtml"
       Write(Html.ValidationMessageFor(q => q.Address, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
