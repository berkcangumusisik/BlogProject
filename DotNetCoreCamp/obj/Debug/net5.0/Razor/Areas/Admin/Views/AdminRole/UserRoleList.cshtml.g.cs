#pragma checksum "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminRole\UserRoleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31314fcf5b798d6906f09a59ffdd1dcab52aacc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminRole_UserRoleList), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminRole/UserRoleList.cshtml")]
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
#line 1 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Areas\Admin\Views\_ViewImports.cshtml"
using DotNetCoreCamp.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Areas\Admin\Views\_ViewImports.cshtml"
using DotNetCoreCamp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31314fcf5b798d6906f09a59ffdd1dcab52aacc3", @"/Areas/Admin/Views/AdminRole/UserRoleList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"846ee9a585c1fabbfae7f0ad49f68ae0e4b037fc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminRole_UserRoleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
  
    ViewData["Title"] = "UserRoleList";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Kullan??c?? Rol Listesi</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Kullan??c??</th>\r\n        <th>Rol Ata</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 427, "\"", 470, 2);
            WriteAttributeValue("", 434, "/Admin/AdminRole/AssignRole/", 434, 28, true);
#nullable restore
#line 20 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
WriteAttributeValue("", 462, item.Id, 462, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Rol ata</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 23 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n<a href=\"/Admin/AdminRole/Index/\" class=\"btn btn-primary\">Rol Listesine D??n</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
