#pragma checksum "F:\Estudios universidad\Ciclo 8\Calidad y pruebas de software\DIARS\Banco\Banco\Views\Solicitud\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34671e745a3be30195a62898ee1566d6c7dc4be5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Solicitud_Index), @"mvc.1.0.view", @"/Views/Solicitud/Index.cshtml")]
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
#line 1 "F:\Estudios universidad\Ciclo 8\Calidad y pruebas de software\DIARS\Banco\Banco\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Estudios universidad\Ciclo 8\Calidad y pruebas de software\DIARS\Banco\Banco\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34671e745a3be30195a62898ee1566d6c7dc4be5", @"/Views/Solicitud/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Solicitud_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Estudios universidad\Ciclo 8\Calidad y pruebas de software\DIARS\Banco\Banco\Views\Solicitud\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Nombre</th>\r\n            <th>Opciones</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 13 "F:\Estudios universidad\Ciclo 8\Calidad y pruebas de software\DIARS\Banco\Banco\Views\Solicitud\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
#nullable restore
#line 16 "F:\Estudios universidad\Ciclo 8\Calidad y pruebas de software\DIARS\Banco\Banco\Views\Solicitud\Index.cshtml"
                 if (item.Estado == "Pendiente")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 18 "F:\Estudios universidad\Ciclo 8\Calidad y pruebas de software\DIARS\Banco\Banco\Views\Solicitud\Index.cshtml"
                   Write(item.User.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 406, "\"", 492, 4);
            WriteAttributeValue("", 413, "/solicitud/aceptar?IdUsuario=", 413, 29, true);
#nullable restore
#line 19 "F:\Estudios universidad\Ciclo 8\Calidad y pruebas de software\DIARS\Banco\Banco\Views\Solicitud\Index.cshtml"
WriteAttributeValue("", 442, item.User.IdUsuario, 442, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 462, "&IdSolicitud=", 462, 13, true);
#nullable restore
#line 19 "F:\Estudios universidad\Ciclo 8\Calidad y pruebas de software\DIARS\Banco\Banco\Views\Solicitud\Index.cshtml"
WriteAttributeValue("", 475, item.IdSolicitud, 475, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aceptar</a></td>\r\n");
#nullable restore
#line 20 "F:\Estudios universidad\Ciclo 8\Calidad y pruebas de software\DIARS\Banco\Banco\Views\Solicitud\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 22 "F:\Estudios universidad\Ciclo 8\Calidad y pruebas de software\DIARS\Banco\Banco\Views\Solicitud\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
