#pragma checksum "C:\Users\EMRE\source\repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Seller\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af62d438524d1f1057d85bc8ca41c9b6da12f1f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seller_Index), @"mvc.1.0.view", @"/Views/Seller/Index.cshtml")]
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
#line 1 "C:\Users\EMRE\source\repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\_ViewImports.cshtml"
using Grup22;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EMRE\source\repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\_ViewImports.cshtml"
using Grup22.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\EMRE\source\repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Seller\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af62d438524d1f1057d85bc8ca41c9b6da12f1f4", @"/Views/Seller/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"320e68ff9d49128fb11a7b21c53c498cce452133", @"/Views/_ViewImports.cshtml")]
    public class Views_Seller_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Grup22.Models.Seller>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\EMRE\source\repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Seller\Index.cshtml"
  
    ViewData["Title"] = "Bayiler";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<p style=\"text-align:center; font:bold 30px arial, verdana;\">MEVCUT BAYİLER</p>\r\n");
#nullable restore
#line 11 "C:\Users\EMRE\source\repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Seller\Index.cshtml"
 if (HttpContextAccessor.HttpContext.Session.GetInt32("isFactory") == 1)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("<button type=\"button\" class=\"btn btn-primary btn-lg\" onclick=\"window.location.href= \'/Seller/Create\'\"");
            BeginWriteAttribute("style", " style=\"", 487, "\"", 495, 0);
            EndWriteAttribute();
            WriteLiteral(">Yeni Bayi Ekle</button>\r\n");
#nullable restore
#line 15 "C:\Users\EMRE\source\repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Seller\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\EMRE\source\repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Seller\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.sellerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\EMRE\source\repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Seller\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.sellerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\EMRE\source\repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Seller\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.sellerAdress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\EMRE\source\repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Seller\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\EMRE\source\repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Seller\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.sellerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\EMRE\source\repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Seller\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.sellerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\EMRE\source\repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Seller\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.sellerAdress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <div class=\"btn-group btn-group-lg\">\r\n                        <button type=\"button\" class=\"btn btn-default\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1507, "\"", 1568, 4);
            WriteAttributeValue("", 1517, "window.location.href=", 1517, 21, true);
            WriteAttributeValue(" ", 1538, "\'/Seller/Edit/", 1539, 15, true);
#nullable restore
#line 46 "C:\Users\EMRE\source\repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Seller\Index.cshtml"
WriteAttributeValue("", 1553, item.sellerId, 1553, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1567, "\'", 1567, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Düzenle</button>\r\n                        <button type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1656, "\"", 1719, 4);
            WriteAttributeValue("", 1666, "window.location.href=", 1666, 21, true);
            WriteAttributeValue(" ", 1687, "\'/Seller/Delete/", 1688, 17, true);
#nullable restore
#line 47 "C:\Users\EMRE\source\repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Seller\Index.cshtml"
WriteAttributeValue("", 1704, item.sellerId, 1704, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1718, "\'", 1718, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Sil</button>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 51 "C:\Users\EMRE\source\repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Seller\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Grup22.Models.Seller>> Html { get; private set; }
    }
}
#pragma warning restore 1591
