#pragma checksum "F:\Estudios universidad\Ciclo 8\Calidad y pruebas de software\DIARS\Banco\Banco\Views\Amigo\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9745cebdd936f635e0ee66014d75521a4dfe2a2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Amigo_Create), @"mvc.1.0.view", @"/Views/Amigo/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9745cebdd936f635e0ee66014d75521a4dfe2a2d", @"/Views/Amigo/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Amigo_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Estudios universidad\Ciclo 8\Calidad y pruebas de software\DIARS\Banco\Banco\Views\Amigo\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table\">\r\n\r\n        <thead>\r\n            <tr>\r\n                <th>Nombre</th>\r\n                <th>Agregar amigo</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 14 "F:\Estudios universidad\Ciclo 8\Calidad y pruebas de software\DIARS\Banco\Banco\Views\Amigo\Create.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 17 "F:\Estudios universidad\Ciclo 8\Calidad y pruebas de software\DIARS\Banco\Banco\Views\Amigo\Create.cshtml"
                   Write(item.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 410, "\"", 460, 2);
            WriteAttributeValue("", 417, "/amigo/solicitud/?IdUsuario=", 417, 28, true);
#nullable restore
#line 19 "F:\Estudios universidad\Ciclo 8\Calidad y pruebas de software\DIARS\Banco\Banco\Views\Amigo\Create.cshtml"
WriteAttributeValue("", 445, item.IdUsuario, 445, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">Enviar Solicitud</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 22 "F:\Estudios universidad\Ciclo 8\Calidad y pruebas de software\DIARS\Banco\Banco\Views\Amigo\Create.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n\r\n\r\n");
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
