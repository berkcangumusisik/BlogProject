#pragma checksum "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a0a870f063cbfaff87c9413efc7d1905ea080db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterAboutOnDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterAboutOnDashboard/Default.cshtml")]
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
#line 1 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a0a870f063cbfaff87c9413efc7d1905ea080db", @"/Views/Shared/Components/WriterAboutOnDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e06a52ab9f63d5c9aacfe452a58100eb701d9ad8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterAboutOnDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Writer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">Yazar Hakkında</h4>\r\n");
#nullable restore
#line 8 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                 foreach(var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"d-flex mt-5 align-items-top\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 391, "\"", 414, 1);
#nullable restore
#line 12 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
WriteAttributeValue("", 397, item.WriterImage, 397, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-sm rounded-circle mr-3\" alt=\"image\">\r\n                    <div class=\"mb-0 flex-grow\">\r\n                        <h5 class=\"mr-2 mb-2\">");
#nullable restore
#line 14 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                                         Write(item.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 14 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                                                            Write(item.WriterMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"mb-0 font-weight-light\">");
#nullable restore
#line 15 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                                                     Write(item.WriterAbout);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"ml-auto\">\r\n                        <i class=\"mdi mdi-heart-outline text-muted\"></i>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 21 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Writer>> Html { get; private set; }
    }
}
#pragma warning restore 1591