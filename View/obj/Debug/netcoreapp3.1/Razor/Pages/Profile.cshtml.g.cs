#pragma checksum "/home/hhhh/Documentos/Proyecto/View/Pages/Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2a9bfb71bf54cc9ab21b7c07c960a3a173f1e6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(View.Pages.Pages_Profile), @"mvc.1.0.razor-page", @"/Pages/Profile.cshtml")]
namespace View.Pages
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
#line 1 "/home/hhhh/Documentos/Proyecto/View/Pages/_ViewImports.cshtml"
using View;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2a9bfb71bf54cc9ab21b7c07c960a3a173f1e6d", @"/Pages/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a70cd4ed12140ba413fbf9bf97f1a4b4d524ea24", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Profile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/hhhh/Documentos/Proyecto/View/Pages/Profile.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"card\" style=\"width: 18rem;\">\r\n  <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 142, "\"", 204, 1);
#nullable restore
#line 9 "/home/hhhh/Documentos/Proyecto/View/Pages/Profile.cshtml"
WriteAttributeValue("", 148, Url.Content("~/img/aplicacion-becas-benito-juarez.jpg"), 148, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n  <div class=\"card-body\">\r\n    <h5 class=\"card-title\">Becas de descuento</h5>\r\n    <p class=\"card-text\">Aplica para la beca de descuento \r\n        academico que puede reducir un porcentaje de tu inscripcion </p>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 452, "\"", 496, 1);
#nullable restore
#line 14 "/home/hhhh/Documentos/Proyecto/View/Pages/Profile.cshtml"
WriteAttributeValue("", 459, Url.Page("Registro", @Model.account), 459, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  >Aplicar</a>\r\n  </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proyecto.ProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Proyecto.ProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Proyecto.ProfileModel>)PageContext?.ViewData;
        public Proyecto.ProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
