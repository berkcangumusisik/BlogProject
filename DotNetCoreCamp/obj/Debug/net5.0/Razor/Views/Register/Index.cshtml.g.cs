#pragma checksum "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5900794bb76de63ce06239fb286a1e2e2367768"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5900794bb76de63ce06239fb286a1e2e2367768", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e06a52ab9f63d5c9aacfe452a58100eb701d9ad8", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script src=\"https://unpkg.com/sweetalert/dist/sweetalert.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5900794bb76de63ce06239fb286a1e2e23677683859", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<section class=\"main-content-w3layouts-agileits\">\r\n    <div class=\"container\">\r\n        <h3 class=\"tittle\">Yazar Kay??t Sayfas??</h3>\r\n        <div class=\"inner-sec\">\r\n            <div class=\"login p-5 bg-light mx-auto mw-100\">\r\n");
#nullable restore
#line 16 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Register\Index.cshtml"
                 using (Html.BeginForm("Index", "Register", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-row\">\r\n                        <div class=\"col-md-6 mb-3\">\r\n                            <label for=\"validationCustom01\">Ad??n??z Soyad??n??z</label>\r\n                            ");
#nullable restore
#line 21 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.WriterName, new { @class = "form-control", @id = "validationDefault01", @placeholder = "Ad??n??z?? Giriniz", @required = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 22 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.WriterName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6 mb-3\">\r\n                            <label for=\"validationCustom02\">Mail Adresisiniz</label>\r\n                            ");
#nullable restore
#line 26 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.WriterMail, new { @class = "form-control", @id = "validationDefault02", @placeholder = "Mail Adresinizi Giriniz", @required = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 27 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.WriterMail, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-6"">
                            <label for=""exampleInputPassword1 mb-2"">Parola</label>
                            ");
#nullable restore
#line 33 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Register\Index.cshtml"
                       Write(Html.PasswordFor(x => x.WriterPassword, new { @class = "form-control", @id = "password1", @placeholder = "??ifre Giriniz", @required = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 34 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.WriterPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <div class=""form-group col-md-6"">
                            <label for=""exampleInputPassword2 mb-2"">Parolan??z?? Tekrar Giriniz</label>
                            <input type=""password"" name=""PasswordAgain"" class=""form-control"" id=""password2"" placeholder=""??ifrenizi Tekrar Giriniz""");
            BeginWriteAttribute("required", " required=\"", 2398, "\"", 2409, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-6"">
                            <label for=""exampleInputPassword2 mb-2"">G??rsel Dosya Yolu</label>
                            <input type=""text"" name=""WriterImage"" class=""form-control"" id=""password2"" placeholder=""Dosya Yolunu Giriniz""");
            BeginWriteAttribute("required", " required=\"", 2809, "\"", 2820, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group col-md-6\">\r\n                            <label for=\"exampleInputPassword2 mb-2\">??ehir</label>\r\n                            ");
#nullable restore
#line 48 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Register\Index.cshtml"
                       Write(Html.DropDownList("cities", (ViewBag.Cities), "??ehir Se??iniz", new { @class = "form-control dropdown" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <button type=\"submit\" class=\"btn btn-outline-primary submit mb-4 col-12\">Kay??t Ol</button>\r\n                    <p>\r\n                        <a href=\"#\" id=\"btn1\">T??m ??artlar?? okudum ve kabul ediyorum.</a>\r\n                    </p>\r\n");
#nullable restore
#line 56 "C:\Users\BERKCAN\Documents\GitHub\BlogProject\DotNetCoreCamp\Views\Register\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>

    <script>
        $('#btn1').click(function () {
            swal(""Site Kabul ??artlar??"", ""Sitemizde verdi??iniz mail adresi ??zerinden bilgi ve haber e-postalar?? spam ??l????s??ne varmadan g??nderilmeye devam edilecektir. E??er e-posta b??lteninden ????kmak iterseniz mail ileti dizisini durdurabilirsiniz, ??ifre ve mail adresleriniz ??ifrelenmi?? formatta herhangi bir kullan??c??n??n g??rmeyece??i ??ekilde veri tabanlar??m??zda saklanmaktad??r."");
        });
    </script>
</section>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Writer> Html { get; private set; }
    }
}
#pragma warning restore 1591
