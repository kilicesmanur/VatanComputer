#pragma checksum "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f597a825d164614b7fa334e8965cd02a67c6376c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f597a825d164614b7fa334e8965cd02a67c6376c", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Vatan.Areas.Admin.Models.VM.ProductVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""span9"">
    <div class=""well well-small"">
        <h4>Featured Products <small class=""pull-right"">200+ featured products</small></h4>
        <div class=""row-fluid"">
            <div id=""featured"" class=""carousel slide"">
                <div class=""carousel-inner"">
                    <div class=""item active"">
                        <ul class=""thumbnails"">

");
#nullable restore
#line 16 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"span3\">\r\n                                    <div class=\"thumbnail\">\r\n                                        <i class=\"tag\"></i>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 828, "\"", 860, 2);
            WriteAttributeValue("", 835, "/Products/Detail/", 835, 17, true);
#nullable restore
#line 21 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
WriteAttributeValue("", 852, item.ID, 852, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 866, "\"", 908, 2);
            WriteAttributeValue("", 872, "/productimage/", 872, 14, true);
#nullable restore
#line 21 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
WriteAttributeValue("", 886, item.MainImagePath[0], 886, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 909, "\"", 915, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                        <div class=\"caption\">\r\n                                            <h5>");
#nullable restore
#line 23 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
                                           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <h4><a class=\"btn\" href=\"product_details.html\">VIEW</a> <span class=\"pull-right\">$");
#nullable restore
#line 24 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
                                                                                                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\r\n                                        </div>\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 28 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                    <div class=\"item\">\r\n                        <ul class=\"thumbnails\">\r\n");
#nullable restore
#line 33 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"span3\">\r\n                                    <div class=\"thumbnail\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1763, "\"", 1795, 2);
            WriteAttributeValue("", 1770, "/Products/Detail/", 1770, 17, true);
#nullable restore
#line 37 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
WriteAttributeValue("", 1787, item.ID, 1787, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 1801, "\"", 1843, 2);
            WriteAttributeValue("", 1807, "/productimage/", 1807, 14, true);
#nullable restore
#line 37 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
WriteAttributeValue("", 1821, item.MainImagePath[0], 1821, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1844, "\"", 1850, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                        <div class=\"caption\">\r\n                                            <h5>");
#nullable restore
#line 39 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
                                           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <h4><a class=\"btn\" href=\"product_details.html\">VIEW</a> <span class=\"pull-right\">$");
#nullable restore
#line 40 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
                                                                                                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\r\n                                        </div>\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 44 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                    <div class=\"item\">\r\n                        <ul class=\"thumbnails\">\r\n");
#nullable restore
#line 49 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"span3\">\r\n                                    <div class=\"thumbnail\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2698, "\"", 2730, 2);
            WriteAttributeValue("", 2705, "/Products/Detail/", 2705, 17, true);
#nullable restore
#line 53 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
WriteAttributeValue("", 2722, item.ID, 2722, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 2736, "\"", 2778, 2);
            WriteAttributeValue("", 2742, "/productimage/", 2742, 14, true);
#nullable restore
#line 53 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
WriteAttributeValue("", 2756, item.MainImagePath[0], 2756, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2779, "\"", 2785, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                        <div class=\"caption\">\r\n                                            <h5>");
#nullable restore
#line 55 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
                                           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <h4><a class=\"btn\" href=\"product_details.html\">VIEW</a> <span class=\"pull-right\">$");
#nullable restore
#line 56 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
                                                                                                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\r\n                                        </div>\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 60 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                    <div class=\"item\">\r\n                        <ul class=\"thumbnails\">\r\n");
#nullable restore
#line 65 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"span3\">\r\n                                    <div class=\"thumbnail\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3633, "\"", 3665, 2);
            WriteAttributeValue("", 3640, "/Products/Detail/", 3640, 17, true);
#nullable restore
#line 69 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
WriteAttributeValue("", 3657, item.ID, 3657, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 3671, "\"", 3713, 2);
            WriteAttributeValue("", 3677, "/productimage/", 3677, 14, true);
#nullable restore
#line 69 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
WriteAttributeValue("", 3691, item.MainImagePath[0], 3691, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3714, "\"", 3720, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                        <div class=\"caption\">\r\n                                            <h5>");
#nullable restore
#line 71 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
                                           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <h4><a class=\"btn\" href=\"product_details.html\">VIEW</a> <span class=\"pull-right\">$");
#nullable restore
#line 72 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
                                                                                                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\r\n                                        </div>\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 76 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
                <a class=""left carousel-control"" href=""#featured"" data-slide=""prev"">???</a>
                <a class=""right carousel-control"" href=""#featured"" data-slide=""next"">???</a>
            </div>
        </div>
    </div>
    <h4>Latest Products </h4>
    <ul class=""thumbnails"">
");
#nullable restore
#line 87 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"span3\">\r\n                <div class=\"thumbnail\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4694, "\"", 4726, 2);
            WriteAttributeValue("", 4701, "/Products/Detail/", 4701, 17, true);
#nullable restore
#line 91 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
WriteAttributeValue("", 4718, item.ID, 4718, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 4732, "\"", 4774, 2);
            WriteAttributeValue("", 4738, "/productimage/", 4738, 14, true);
#nullable restore
#line 91 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
WriteAttributeValue("", 4752, item.MainImagePath[0], 4752, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4775, "\"", 4781, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                    <div class=\"caption\">\r\n                        <h5>");
#nullable restore
#line 93 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
                       Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p>\r\n                            ");
#nullable restore
#line 95 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <h4 style=\"text-align:center\"><a class=\"btn\"");
            BeginWriteAttribute("href", " href=\"", 5060, "\"", 5092, 2);
            WriteAttributeValue("", 5067, "/Products/Detail/", 5067, 17, true);
#nullable restore
#line 97 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
WriteAttributeValue("", 5084, item.ID, 5084, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i class=\"icon-zoom-in\"></i></a> <a class=\"btn\" href=\"#\">Add to <i class=\"icon-shopping-cart\"></i></a> <a class=\"btn btn-primary\" href=\"#\">$");
#nullable restore
#line 97 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
                                                                                                                                                                                                                                              Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                    </div>\r\n                </div>\r\n            </li>\r\n");
#nullable restore
#line 101 "C:\Users\User\Desktop\MVC\BizimProje\Vatan\Vatan\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Vatan.Areas.Admin.Models.VM.ProductVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
