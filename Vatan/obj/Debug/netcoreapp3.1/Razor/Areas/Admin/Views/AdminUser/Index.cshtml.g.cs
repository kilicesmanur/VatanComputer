#pragma checksum "C:\Users\dgdm_\OneDrive\Masaüstü\Vatan\Vatan\Vatan\Areas\Admin\Views\AdminUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "237f86a7355ea3ce4110f9f854165ffc42bdc7ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminUser_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminUser/Index.cshtml")]
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
#line 3 "C:\Users\dgdm_\OneDrive\Masaüstü\Vatan\Vatan\Vatan\Areas\Admin\Views\_ViewImports.cshtml"
using Vatan.Areas.Admin.Models.VM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dgdm_\OneDrive\Masaüstü\Vatan\Vatan\Vatan\Areas\Admin\Views\_ViewImports.cshtml"
using Vatan.Areas.Admin.Models.ORM.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"237f86a7355ea3ce4110f9f854165ffc42bdc7ad", @"/Areas/Admin/Views/AdminUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"719e21ca811eabf282219850cb8b4b0f62ecb3d8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AdminUserVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\dgdm_\OneDrive\Masaüstü\Vatan\Vatan\Vatan\Areas\Admin\Views\AdminUser\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<h1>Index</h1>

<div class=""container-fluid"">
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Category List</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Email</th>
                            <th>Name</th>
                            <th>Surname</th>
                            <th>Last Login</th>

                            <th>Delete</th>


                        </tr>
                    </thead>

                    <tbody>
");
#nullable restore
#line 33 "C:\Users\dgdm_\OneDrive\Masaüstü\Vatan\Vatan\Vatan\Areas\Admin\Views\AdminUser\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("id", " id=\"", 1065, "\"", 1078, 1);
#nullable restore
#line 35 "C:\Users\dgdm_\OneDrive\Masaüstü\Vatan\Vatan\Vatan\Areas\Admin\Views\AdminUser\Index.cshtml"
WriteAttributeValue("", 1070, item.ID, 1070, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <td>");
#nullable restore
#line 36 "C:\Users\dgdm_\OneDrive\Masaüstü\Vatan\Vatan\Vatan\Areas\Admin\Views\AdminUser\Index.cshtml"
                               Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 37 "C:\Users\dgdm_\OneDrive\Masaüstü\Vatan\Vatan\Vatan\Areas\Admin\Views\AdminUser\Index.cshtml"
                               Write(item.EMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 38 "C:\Users\dgdm_\OneDrive\Masaüstü\Vatan\Vatan\Vatan\Areas\Admin\Views\AdminUser\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 39 "C:\Users\dgdm_\OneDrive\Masaüstü\Vatan\Vatan\Vatan\Areas\Admin\Views\AdminUser\Index.cshtml"
                               Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 40 "C:\Users\dgdm_\OneDrive\Masaüstü\Vatan\Vatan\Vatan\Areas\Admin\Views\AdminUser\Index.cshtml"
                               Write(item.Lastlogindate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n                                <td>\r\n\r\n                                    <button class=\"btn btn-outline-danger delete\"");
            BeginWriteAttribute("id", " id=\"", 1485, "\"", 1498, 1);
#nullable restore
#line 46 "C:\Users\dgdm_\OneDrive\Masaüstü\Vatan\Vatan\Vatan\Areas\Admin\Views\AdminUser\Index.cshtml"
WriteAttributeValue("", 1490, item.ID, 1490, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 50 "C:\Users\dgdm_\OneDrive\Masaüstü\Vatan\Vatan\Vatan\Areas\Admin\Views\AdminUser\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <!-- Page level plugins -->
    <script src=""/vendor/datatables/jquery.dataTables.min.js""></script>
    <script src=""/vendor/datatables/dataTables.bootstrap4.min.js""></script>

    <!-- Page level custom scripts -->
    <script src=""/js/demo/datatables-demo.js""></script> ");
            }
            );
            WriteLiteral(@"

    <script>
        $(document).on(""click"", "".delete"", function () {
            var confirmation = confirm(""are you sure you want to remove the item?"");
            if (confirmation) {
                let id = $(this).attr(""id"")
                $.ajax({
                    url: ""/Admin/AdminUser/Delete"",
                    type: ""POST"",
                    data: { id: id },
                    success: function (msg) {
                        $(""#"" + id).fadeOut();
                    },
                    error: function (err) {
                        alert(""Admin User Deleting Failed!"");
                    }
                })
            }
        })
    </script>



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AdminUserVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
