#pragma checksum "M:\NetCore\ExamenFinal\Net5.Examen\Net5.Examen.Client\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8d95094164fd74931228274a76f686f0572ffd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "M:\NetCore\ExamenFinal\Net5.Examen\Net5.Examen.Client\Views\_ViewImports.cshtml"
using Net5.Examen.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "M:\NetCore\ExamenFinal\Net5.Examen\Net5.Examen.Client\Views\_ViewImports.cshtml"
using Net5.Examen.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8d95094164fd74931228274a76f686f0572ffd9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83b01ecd6dc5011aada0cbec55c67a0425750d19", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "M:\NetCore\ExamenFinal\Net5.Examen\Net5.Examen.Client\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Students List</h4>\r\n<table class=\"table table-sm\">\r\n    <thead>\r\n        <tr>\r\n            <th>StudentId</th>\r\n            <th>Name</th>\r\n            <th>Age</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "M:\NetCore\ExamenFinal\Net5.Examen\Net5.Examen.Client\Views\Home\Index.cshtml"
     foreach (Student student in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "M:\NetCore\ExamenFinal\Net5.Examen\Net5.Examen.Client\Views\Home\Index.cshtml"
           Write(student.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "M:\NetCore\ExamenFinal\Net5.Examen\Net5.Examen.Client\Views\Home\Index.cshtml"
           Write(student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "M:\NetCore\ExamenFinal\Net5.Examen\Net5.Examen.Client\Views\Home\Index.cshtml"
           Write(student.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "M:\NetCore\ExamenFinal\Net5.Examen\Net5.Examen.Client\Views\Home\Index.cshtml"
    }        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
