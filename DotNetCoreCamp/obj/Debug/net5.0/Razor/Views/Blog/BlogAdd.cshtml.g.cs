#pragma checksum "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Blog\BlogAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d85e099eed57d20dcb4c704d3d2da0e76942705a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogAdd), @"mvc.1.0.view", @"/Views/Blog/BlogAdd.cshtml")]
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
#line 1 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\_ViewImports.cshtml"
using DotNetCoreCamp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\_ViewImports.cshtml"
using DotNetCoreCamp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d85e099eed57d20dcb4c704d3d2da0e76942705a", @"/Views/Blog/BlogAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e06a52ab9f63d5c9aacfe452a58100eb701d9ad8", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Blog\BlogAdd.cshtml"
  
    ViewData["Title"] = "BlogAdd";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Blog Ekleme Sayfası</h1>\r\n<br />\r\n\r\n");
#nullable restore
#line 11 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Blog\BlogAdd.cshtml"
 using (Html.BeginForm("BlogAdd", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Başlığını Giriniz"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x => x.BlogTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogTitle, "", new { @class = "text-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n");
#nullable restore
#line 18 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Görselini Giriniz"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x => x.BlogImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogImage, "", new { @class = "text-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n");
#nullable restore
#line 23 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Küçük Görselini Giriniz"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x => x.BlogThumbNailImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n");
#nullable restore
#line 27 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Kategorisini Giriniz"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Blog\BlogAdd.cshtml"
Write(Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>)ViewBag.cv, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n");
#nullable restore
#line 32 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog İçeriğini Giriniz!"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Blog\BlogAdd.cshtml"
Write(Html.TextAreaFor(x => x.BlogContent, 15, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogContent, "", new { @class = "text-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n    <button class=\"btn btn-outline-info\">Blog\'u Kaydet</button>\r\n");
#nullable restore
#line 38 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Blog\BlogAdd.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
