#pragma checksum "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Shared\AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef6437cd291b4c83987fae69559ca3ffd8b4145a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_AdminLayout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/AdminLayout.cshtml")]
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
#line 3 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\_ViewImports.cshtml"
using Vatan.Areas.Admin.Models.VM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\_ViewImports.cshtml"
using Vatan.Areas.Admin.Models.ORM.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6437cd291b4c83987fae69559ca3ffd8b4145a", @"/Areas/Admin/Views/Shared/AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"719e21ca811eabf282219850cb8b4b0f62ecb3d8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef6437cd291b4c83987fae69559ca3ffd8b4145a3753", async() => {
                WriteLiteral("\r\n\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 254, "\"", 264, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 291, "\"", 301, 0);
                EndWriteAttribute();
                WriteLiteral(@">

    <title>SB Admin 2 - Blank</title>

    <!-- Custom fonts for this template-->
    <link href=""/vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i""
          rel=""stylesheet"">

    <!-- Custom styles for this template-->
    <link href=""/css/sb-admin-2.min.css"" rel=""stylesheet"">

    <!-- Bootstrap core JavaScript-->
    <script src=""/vendor/jquery/jquery.min.js""></script>
    <script src=""/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

    <!-- Core plugin JavaScript-->
    <script src=""/vendor/jquery-easing/jquery.easing.min.js""></script>

    <!-- Custom scripts for all pages-->
    <script src=""/js/sb-admin-2.min.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef6437cd291b4c83987fae69559ca3ffd8b4145a6144", async() => {
                WriteLiteral(@"

    <!-- Page Wrapper -->
    <div id=""wrapper"">

        <!-- Sidebar -->
        <ul class=""navbar-nav bg-gradient-primary sidebar sidebar-dark accordion"" id=""accordionSidebar"">

            <!-- Sidebar - Brand -->
            <a class=""sidebar-brand d-flex align-items-center justify-content-center"" href=""/Admin"">
                <div class=""sidebar-brand-icon rotate-n-15"">
                    <i class=""fas fa-laugh-wink""></i>
                </div>
                <div class=""sidebar-brand-text mx-3"">SB Admin <sup>2</sup></div>
            </a>

            <!-- Divider -->
            <hr class=""sidebar-divider my-0"">

            <!-- Nav Item - Dashboard -->
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Admin"">
                    <i class=""fas fa-fw fa-tachometer-alt""></i>
                    <span>Dashboard</span>
                </a>
            </li>

            <!-- Divider -->
            <hr class=""sidebar-divider"">

            <!-");
                WriteLiteral("- Heading -->\r\n            <div class=\"sidebar-heading\">\r\n                Interface\r\n            </div>\r\n");
#nullable restore
#line 68 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Shared\AdminLayout.cshtml"
             foreach (var item in ViewBag.menu)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"nav-item\">\r\n                    <a class=\"nav-link collapsed\"");
                BeginWriteAttribute("href", " href=\"", 2441, "\"", 2459, 1);
#nullable restore
#line 71 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Shared\AdminLayout.cshtml"
WriteAttributeValue("", 2448, item.Route, 2448, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"collapse\" data-target=\"#");
#nullable restore
#line 71 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Shared\AdminLayout.cshtml"
                                                                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n                       aria-expanded=\"true\"");
                BeginWriteAttribute("aria-controls", " aria-controls=\"", 2554, "\"", 2580, 1);
#nullable restore
#line 72 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Shared\AdminLayout.cshtml"
WriteAttributeValue("", 2570, item.Name, 2570, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <i");
                BeginWriteAttribute("class", " class=\"", 2610, "\"", 2632, 1);
#nullable restore
#line 73 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Shared\AdminLayout.cshtml"
WriteAttributeValue("", 2618, item.IconName, 2618, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" aria-hidden=\"true\"></i>\r\n                        <span>");
#nullable restore
#line 74 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Shared\AdminLayout.cshtml"
                         Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                    </a>\r\n                    <div");
                BeginWriteAttribute("id", " id=\"", 2758, "\"", 2773, 1);
#nullable restore
#line 76 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Shared\AdminLayout.cshtml"
WriteAttributeValue("", 2763, item.Name, 2763, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                        <div class=""bg-white py-2 collapse-inner rounded"">
                            <h6 class=""collapse-header"">Custom Components:</h6>
                            <a class=""collapse-item""");
                BeginWriteAttribute("href", " href=\"", 3064, "\"", 3082, 1);
#nullable restore
#line 79 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Shared\AdminLayout.cshtml"
WriteAttributeValue("", 3071, item.Route, 3071, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">    <i class=\"fas fa-list\"></i>   List ");
#nullable restore
#line 79 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Shared\AdminLayout.cshtml"
                                                                                                          Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                            <a class=\"collapse-item\"");
                BeginWriteAttribute("href", " href=\"", 3191, "\"", 3213, 2);
#nullable restore
#line 80 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Shared\AdminLayout.cshtml"
WriteAttributeValue("", 3198, item.Route, 3198, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3209, "/add", 3209, 4, true);
                EndWriteAttribute();
                WriteLiteral(">  <i class=\"fas fa-plus\"></i> Add ");
#nullable restore
#line 80 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Shared\AdminLayout.cshtml"
                                                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n\r\n\r\n                        </div>\r\n                    </div>\r\n                </li>\r\n");
#nullable restore
#line 86 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Shared\AdminLayout.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <!-- Nav Item - Pages Collapse Menu -->
            <!--<li class=""nav-item"">
                <a class=""nav-link collapsed"" href=""/admin/product"" data-toggle=""collapse"" data-target=""#product""
                   aria-expanded=""true"" aria-controls=""product"">
                    <i class=""fab fa-product-hunt""></i>
                    <span>Products</span>
                </a>
                <div id=""product"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                    <div class=""bg-white py-2 collapse-inner rounded"">
                        <h6 class=""collapse-header"">Custom Components:</h6>
                        <a class=""collapse-item"" href=""/Admin/Product""><i class=""fas fa-list""></i>   List Product</a>
                        <a class=""collapse-item"" href=""/Admin/Product/add"">  <i class=""fas fa-plus""></i>  Add Product</a>


                    </div>
                </div>
            </li>-->
            <!-- Nav Item - Utilities Collapse");
                WriteLiteral(" Menu -->\r\n");
                WriteLiteral(@"

            <!-- Divider -->
            <hr class=""sidebar-divider"">

            <!-- Heading -->
            <!-- Nav Item - Pages Collapse Menu -->
            <!-- Divider -->
            <hr class=""sidebar-divider d-none d-md-block"">

            <!-- Sidebar Toggler (Sidebar) -->
            <div class=""text-center d-none d-md-inline"">
                <button class=""rounded-circle border-0"" id=""sidebarToggle""></button>
            </div>

        </ul>
        <!-- End of Sidebar -->
        <!-- Content Wrapper -->
        <div id=""content-wrapper"" class=""d-flex flex-column"">

            <!-- Main Content -->
            <div id=""content"">

                <!-- Topbar -->
                <nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">

                    <!-- Sidebar Toggle (Topbar) -->
                    <button id=""sidebarToggleTop"" class=""btn btn-link d-md-none rounded-circle mr-3"">
                        <i class=""fa fa-bars""");
                WriteLiteral(@"></i>
                    </button>

                    <!-- Topbar Search -->
                    <form class=""d-none d-sm-inline-block form-inline mr-auto ml-md-3 my-2 my-md-0 mw-100 navbar-search"">
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control bg-light border-0 small"" placeholder=""Search for...""
                                   aria-label=""Search"" aria-describedby=""basic-addon2"">
                            <div class=""input-group-append"">
                                <button class=""btn btn-primary"" type=""button"">
                                    <i class=""fas fa-search fa-sm""></i>
                                </button>
                            </div>
                        </div>
                    </form>

                    <!-- Topbar Navbar -->
                    <ul class=""navbar-nav ml-auto"">

                        <!-- Nav Item - Search Dropdown (Visible Only XS) -->
                     ");
                WriteLiteral(@"   <li class=""nav-item dropdown no-arrow d-sm-none"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""searchDropdown"" role=""button""
                               data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <i class=""fas fa-search fa-fw""></i>
                            </a>
                            <!-- Dropdown - Messages -->
                            <div class=""dropdown-menu dropdown-menu-right p-3 shadow animated--grow-in""
                                 aria-labelledby=""searchDropdown"">
                                <form class=""form-inline mr-auto w-100 navbar-search"">
                                    <div class=""input-group"">
                                        <input type=""text"" class=""form-control bg-light border-0 small""
                                               placeholder=""Search for..."" aria-label=""Search""
                                               aria-describedby=""basic-addon2");
                WriteLiteral(@""">
                                        <div class=""input-group-append"">
                                            <button class=""btn btn-primary"" type=""button"">
                                                <i class=""fas fa-search fa-sm""></i>
                                            </button>
                                        </div>
                                    </div>
                                </form>
                            </div>
                        </li>

                        <!-- Nav Item - Alerts -->
                        <li class=""nav-item dropdown no-arrow mx-1"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""alertsDropdown"" role=""button""
                               data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <i class=""fas fa-bell fa-fw""></i>
                                <!-- Counter - Alerts -->
                                <span class=""badge badge-");
                WriteLiteral(@"danger badge-counter"">3+</span>
                            </a>
                            <!-- Dropdown - Alerts -->
                            <div class=""dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in""
                                 aria-labelledby=""alertsDropdown"">
                                <h6 class=""dropdown-header"">
                                    Alerts Center
                                </h6>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""mr-3"">
                                        <div class=""icon-circle bg-primary"">
                                            <i class=""fas fa-file-alt text-white""></i>
                                        </div>
                                    </div>
                                    <div>
                                        <div class=""small text-gray-500"">December 12, 2019</div>
                 ");
                WriteLiteral(@"                       <span class=""font-weight-bold"">A new monthly report is ready to download!</span>
                                    </div>
                                </a>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""mr-3"">
                                        <div class=""icon-circle bg-success"">
                                            <i class=""fas fa-donate text-white""></i>
                                        </div>
                                    </div>
                                    <div>
                                        <div class=""small text-gray-500"">December 7, 2019</div>
                                        $290.29 has been deposited into your account!
                                    </div>
                                </a>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                            ");
                WriteLiteral(@"        <div class=""mr-3"">
                                        <div class=""icon-circle bg-warning"">
                                            <i class=""fas fa-exclamation-triangle text-white""></i>
                                        </div>
                                    </div>
                                    <div>
                                        <div class=""small text-gray-500"">December 2, 2019</div>
                                        Spending Alert: We've noticed unusually high spending for your account.
                                    </div>
                                </a>
                                <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Show All Alerts</a>
                            </div>
                        </li>

                        <!-- Nav Item - Messages -->
                        <li class=""nav-item dropdown no-arrow mx-1"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""me");
                WriteLiteral(@"ssagesDropdown"" role=""button""
                               data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <i class=""fas fa-envelope fa-fw""></i>
                                <!-- Counter - Messages -->
                                <span class=""badge badge-danger badge-counter"">7</span>
                            </a>
                            <!-- Dropdown - Messages -->
                            <div class=""dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in""
                                 aria-labelledby=""messagesDropdown"">
                                <h6 class=""dropdown-header"">
                                    Message Center
                                </h6>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""dropdown-list-image mr-3"">
                                        <img class=""rounded-circle"" src=""");
                WriteLiteral("/img/undraw_profile_1.svg\"");
                BeginWriteAttribute("alt", "\r\n                                             alt=\"", 14565, "\"", 14617, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        <div class=""status-indicator bg-success""></div>
                                    </div>
                                    <div class=""font-weight-bold"">
                                        <div class=""text-truncate"">
                                            Hi there! I am wondering if you can help me with a
                                            problem I've been having.
                                        </div>
                                        <div class=""small text-gray-500"">Emily Fowler ?? 58m</div>
                                    </div>
                                </a>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""dropdown-list-image mr-3"">
                                        <img class=""rounded-circle"" src=""/img/undraw_profile_2.svg""");
                BeginWriteAttribute("alt", "\r\n                                             alt=\"", 15556, "\"", 15608, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        <div class=""status-indicator""></div>
                                    </div>
                                    <div>
                                        <div class=""text-truncate"">
                                            I have the photos that you ordered last month, how
                                            would you like them sent to you?
                                        </div>
                                        <div class=""small text-gray-500"">Jae Chun ?? 1d</div>
                                    </div>
                                </a>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""dropdown-list-image mr-3"">
                                        <img class=""rounded-circle"" src=""/img/undraw_profile_3.svg""");
                BeginWriteAttribute("alt", "\r\n                                             alt=\"", 16513, "\"", 16565, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        <div class=""status-indicator bg-warning""></div>
                                    </div>
                                    <div>
                                        <div class=""text-truncate"">
                                            Last month's report looks great, I am very happy with
                                            the progress so far, keep up the good work!
                                        </div>
                                        <div class=""small text-gray-500"">Morgan Alvarez ?? 2d</div>
                                    </div>
                                </a>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""dropdown-list-image mr-3"">
                                        <img class=""rounded-circle"" src=""https://source.unsplash.com/Mv9hjnEUHR4/60x60""");
                BeginWriteAttribute("alt", "\r\n                                             alt=\"", 17521, "\"", 17573, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        <div class=""status-indicator bg-success""></div>
                                    </div>
                                    <div>
                                        <div class=""text-truncate"">
                                            Am I a good boy? The reason I ask is because someone
                                            told me that people say this to all dogs, even if they aren't good...
                                        </div>
                                        <div class=""small text-gray-500"">Chicken the Dog ?? 2w</div>
                                    </div>
                                </a>
                                <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Read More Messages</a>
                            </div>
                        </li>

                        <div class=""topbar-divider d-none d-sm-block""></div>

                        <!-- Nav Item - User Information -->");
                WriteLiteral(@"
                        <li class=""nav-item dropdown no-arrow"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button""
                               data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <span class=""mr-2 d-none d-lg-inline text-gray-600 small"">");
#nullable restore
#line 339 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Shared\AdminLayout.cshtml"
                                                                                     Write(ViewBag.email);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                <img class=""img-profile rounded-circle""
                                     src=""/img/undraw_profile.svg"">
                            </a>
                            <!-- Dropdown - User Information -->
                            <div class=""dropdown-menu dropdown-menu-right shadow animated--grow-in""
                                 aria-labelledby=""userDropdown"">
                                <a class=""dropdown-item"" href=""#"">
                                    <i class=""fas fa-user fa-sm fa-fw mr-2 text-gray-400""></i>
                                    Profile
                                </a>
                                <a class=""dropdown-item"" href=""#"">
                                    <i class=""fas fa-cogs fa-sm fa-fw mr-2 text-gray-400""></i>
                                    Settings
                                </a>
                                <a class=""dropdown-item"" href=""#"">
                                    <i clas");
                WriteLiteral(@"s=""fas fa-list fa-sm fa-fw mr-2 text-gray-400""></i>
                                    Activity Log
                                </a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""/Admin/Login/Logout"">
                                    <i class=""fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400""></i>
                                    Logout
                                </a>
                            </div>
                        </li>

                    </ul>

                </nav>
                <!-- End of Topbar -->
                <!-- Begin Page Content -->
                <div class=""container-fluid"">

                    <!-- Page Heading -->
                    ");
#nullable restore
#line 374 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Shared\AdminLayout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                </div>
                <!-- /.container-fluid -->

            </div>
            <!-- End of Main Content -->
            <!-- Footer -->
            <footer class=""sticky-footer bg-white"">
                <div class=""container my-auto"">
                    <div class=""copyright text-center my-auto"">
                        <span>Copyright &copy; Your Website 2020</span>
                    </div>
                </div>
            </footer>
            <!-- End of Footer -->

        </div>
        <!-- End of Content Wrapper -->

    </div>
    <!-- End of Page Wrapper -->
    <!-- Scroll to Top Button-->
    <a class=""scroll-to-top rounded"" href=""#page-top"">
        <i class=""fas fa-angle-up""></i>
    </a>

    <!-- Logout Modal-->
    <div class=""modal fade"" id=""logoutModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
         aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">");
                WriteLiteral(@"
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Ready to Leave?</h5>
                    <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">??</span>
                    </button>
                </div>
                <div class=""modal-body"">Select ""Logout"" below if you are ready to end your current session.</div>
                <div class=""modal-footer"">
                    <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                    <a class=""btn btn-primary"" href=""login.html"">Logout</a>
                </div>
            </div>
        </div>
    </div>



");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 424 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Areas\Admin\Views\Shared\AdminLayout.cshtml"
Write(RenderSection("Scripts", false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</html>\r\n\r\n");
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
