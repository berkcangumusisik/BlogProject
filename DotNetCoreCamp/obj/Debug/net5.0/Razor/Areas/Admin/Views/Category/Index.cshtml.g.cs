#pragma checksum "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b125ea943a89c719a25ba780685a459014e0e3b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b125ea943a89c719a25ba780685a459014e0e3b5", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"846ee9a585c1fabbfae7f0ad49f68ae0e4b037fc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<EntityLayer.Concrete.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Areas\Admin\Views\Category\Index.cshtml"
   
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n<br />\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Kategori Adı</th>\r\n        <th>Sil</th>\r\n        <th>Düzenle</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Areas\Admin\Views\Category\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 21 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Areas\Admin\Views\Category\Index.cshtml"
           Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Areas\Admin\Views\Category\Index.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", "  href=\"", 529, "\"", 585, 3);
            WriteAttributeValue("", 537, "/Admin/Category/CategoryDelete/", 537, 31, true);
#nullable restore
#line 23 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 568, item.CategoryID, 568, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 584, "/", 584, 1, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"DeleteBtn\" onclick=\"return confirm(\'Silmek istediğinize emin misiniz?\');\" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-success\">Düzenle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 26 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Areas\Admin\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/Category/AddCategory/\" class=\"btn btn-outline-success col-12\">Yeni Kategori</a>\r\n<br /><br />\r\n");
#nullable restore
#line 30 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Areas\Admin\Views\Category\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model,page=>Url.Action("Index",new { page })));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<EntityLayer.Concrete.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
