﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using MyCube;
    using NewLife;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Form_Header.cshtml")]
    public partial class _Views_Shared__Form_Header_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Form_Header_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\_Form_Header.cshtml"
   
    var msg = ViewBag.StatusMessage as String;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 4 "..\..\Views\Shared\_Form_Header.cshtml"
 if (!msg.IsNullOrEmpty())
{
    //if (ViewData.ModelState.Values.Any(st => st.Errors.Count > 0))
    if (ViewBag.RowsAffected <= 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-danger alert-dismissible text-center\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close\"");

WriteLiteral(" data-dismiss=\"alert\"");

WriteLiteral(" aria-label=\"Close\"");

WriteLiteral("><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&times;</span></button>\r\n            <strong>");

            
            #line 11 "..\..\Views\Shared\_Form_Header.cshtml"
               Write(msg);

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n        </div>\r\n");

            
            #line 13 "..\..\Views\Shared\_Form_Header.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-success alert-dismissible text-center\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close\"");

WriteLiteral(" data-dismiss=\"alert\"");

WriteLiteral(" aria-label=\"Close\"");

WriteLiteral("><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&times;</span></button>\r\n            <strong>");

            
            #line 18 "..\..\Views\Shared\_Form_Header.cshtml"
               Write(msg);

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n        </div>\r\n");

            
            #line 20 "..\..\Views\Shared\_Form_Header.cshtml"
    }
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591