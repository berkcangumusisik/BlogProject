#pragma checksum "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Shared\Components\BlogLast3Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebf234f081bbe7deada1be5565dd56f53a56e432"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLast3Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Shared\Components\BlogLast3Post\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebf234f081bbe7deada1be5565dd56f53a56e432", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e06a52ab9f63d5c9aacfe452a58100eb701d9ad8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogLast3Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n    <h3>Son Gönderiler</h3>\r\n");
#nullable restore
#line 6 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Shared\Components\BlogLast3Post\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 256, "\"", 294, 3);
            WriteAttributeValue("", 263, "/Blog/BlogReadAll/", 263, 18, true);
#nullable restore
#line 10 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 281, item.BlogID, 281, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 293, "/", 293, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 322, "\"", 352, 1);
#nullable restore
#line 11 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 328, item.BlogThumbNailImage, 328, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 384, "\"", 390, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n\r\n            </div>\r\n\r\n\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                <h5>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 540, "\"", 578, 3);
            WriteAttributeValue("", 547, "/Blog/BlogReadAll/", 547, 18, true);
#nullable restore
#line 20 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 565, item.BlogID, 565, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 577, "/", 577, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                         Write(item.BlogContent.Substring(0, item.BlogContent.Substring(0, 50).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 24 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                 Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n\r\n\r\n        </div>\r\n");
#nullable restore
#line 31 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Shared\Components\BlogLast3Post\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591