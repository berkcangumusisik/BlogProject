#pragma checksum "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Message\MessageDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99eb0109af2c80da36988e9cf8763eace48d41ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_MessageDetails), @"mvc.1.0.view", @"/Views/Message/MessageDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99eb0109af2c80da36988e9cf8763eace48d41ca", @"/Views/Message/MessageDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e06a52ab9f63d5c9aacfe452a58100eb701d9ad8", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_MessageDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Message2>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Message\MessageDetails.cshtml"
  
    ViewData["Title"] = "MessageDetails";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Mesaj Detay Sayfası</h1>\r\n<br />\r\n");
#nullable restore
#line 10 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Message\MessageDetails.cshtml"
Write(Html.Label("Mesaj ID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Message\MessageDetails.cshtml"
Write(Html.TextBoxFor(x => x.MessageID, new { @class = "form-control", disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 13 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Message\MessageDetails.cshtml"
Write(Html.Label("Mesaj Başlığı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Message\MessageDetails.cshtml"
Write(Html.TextBoxFor(x => x.Subject, new { @class = "form-control", disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 16 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Message\MessageDetails.cshtml"
Write(Html.Label("Mesaj İçeriği"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Message\MessageDetails.cshtml"
Write(Html.TextAreaFor(x => x.MessageDetails, 20, 3, new { @class = "form-control", disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<button class=\"btn btn-outline-success\">Okundu Olarak İşaretle</button>\r\n<button class=\"btn btn-outline-info\">Geri Dön </button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Message2> Html { get; private set; }
    }
}
#pragma warning restore 1591
