#pragma checksum "D:\GitHub\Demo\CoreMVC\Views\DITest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25618cdef6e5a8b333f6bf98b92e7bd9d6aa861a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DITest_Index), @"mvc.1.0.view", @"/Views/DITest/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DITest/Index.cshtml", typeof(AspNetCore.Views_DITest_Index))]
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
#line 1 "D:\GitHub\Demo\CoreMVC\Views\_ViewImports.cshtml"
using CoreMVC;

#line default
#line hidden
#line 2 "D:\GitHub\Demo\CoreMVC\Views\_ViewImports.cshtml"
using CoreMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25618cdef6e5a8b333f6bf98b92e7bd9d6aa861a", @"/Views/DITest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e49ef1b62a3bca90a51ee9002da6167d250edae6", @"/Views/_ViewImports.cshtml")]
    public class Views_DITest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\GitHub\Demo\CoreMVC\Views\DITest\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(41, 18, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n");
            EndContext();
#line 6 "D:\GitHub\Demo\CoreMVC\Views\DITest\Index.cshtml"
 foreach (var item in ViewBag.date)
{


#line default
#line hidden
            BeginContext(101, 8, true);
            WriteLiteral("    <h2>");
            EndContext();
            BeginContext(110, 4, false);
#line 9 "D:\GitHub\Demo\CoreMVC\Views\DITest\Index.cshtml"
   Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(114, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 10 "D:\GitHub\Demo\CoreMVC\Views\DITest\Index.cshtml"
}

#line default
#line hidden
            BeginContext(124, 25, true);
            WriteLiteral("\r\n    <h1>Transient(瞬时的):");
            EndContext();
            BeginContext(150, 12, false);
#line 12 "D:\GitHub\Demo\CoreMVC\Views\DITest\Index.cshtml"
                  Write(ViewBag.guid);

#line default
#line hidden
            EndContext();
            BeginContext(162, 31, true);
            WriteLiteral("</h1>\r\n    <h1>Transient(瞬时的)2:");
            EndContext();
            BeginContext(194, 14, false);
#line 13 "D:\GitHub\Demo\CoreMVC\Views\DITest\Index.cshtml"
                   Write(ViewBag.guid11);

#line default
#line hidden
            EndContext();
            BeginContext(208, 29, true);
            WriteLiteral("</h1>\r\n    <h1> Scoped(作用域的):");
            EndContext();
            BeginContext(238, 13, false);
#line 14 "D:\GitHub\Demo\CoreMVC\Views\DITest\Index.cshtml"
                 Write(ViewBag.guid2);

#line default
#line hidden
            EndContext();
            BeginContext(251, 30, true);
            WriteLiteral("</h1>\r\n    <h1> Scoped(作用域的)2:");
            EndContext();
            BeginContext(282, 14, false);
#line 15 "D:\GitHub\Demo\CoreMVC\Views\DITest\Index.cshtml"
                  Write(ViewBag.guid22);

#line default
#line hidden
            EndContext();
            BeginContext(296, 32, true);
            WriteLiteral("</h1>\r\n    <h1>Singleton(全局唯一的):");
            EndContext();
            BeginContext(329, 13, false);
#line 16 "D:\GitHub\Demo\CoreMVC\Views\DITest\Index.cshtml"
                    Write(ViewBag.guid3);

#line default
#line hidden
            EndContext();
            BeginContext(342, 5, true);
            WriteLiteral("</h1>");
            EndContext();
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
