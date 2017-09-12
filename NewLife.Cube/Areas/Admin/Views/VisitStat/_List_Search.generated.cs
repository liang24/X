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
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/VisitStat/_List_Search.cshtml")]
    public partial class _Areas_Admin_Views_VisitStat__List_Search_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_VisitStat__List_Search_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Admin\Views\VisitStat\_List_Search.cshtml"
  
    var now = DateTime.Now;

    var year = Request["year"].ToInt(-1);
    var month = Request["month"].ToInt(-1);
    var day = Request["day"].ToInt(-1);

    var ys = new Dictionary<Int32, String>();
    ys.Add(0, "全部");
    for (int i = 0; i > -10; i--)
    {
        ys.Add(now.Year + i , now.Year + i + "");
    }

    var ms = new Dictionary<Int32, String>();
    if (year > 0)
    {
        ms.Add(0, "全年");
        // 不要当前月以后的月份
        var max = year == now.Year ? now.Month : 12;
        for (int i = 1; i <= max; i++)
        {
            ms.Add(i, i + "");
        }
    }

    var ds = new Dictionary<Int32, String>();
    if (year > 0 && month > 0)
    {
        ds.Add(0, "全月");
        // 该月有多少天
        var max = DateTime.DaysInMonth(year, month);
        // 不要当前月以后的月份
        if (year == now.Year && month == now.Month) { max = now.Day; }
        for (int i = 1; i <= max; i++)
        {
            ds.Add(i, i + "");
        }
    }


            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 43 "..\..\Areas\Admin\Views\VisitStat\_List_Search.cshtml"
Write(Html.ForDropDownList("p", VisitStat.FindAllPageName(), Request["p"], "全部页面", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 46 "..\..\Areas\Admin\Views\VisitStat\_List_Search.cshtml"
Write(Html.ForDropDownList("year", ys, Request["year"], "所有年份", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 49 "..\..\Areas\Admin\Views\VisitStat\_List_Search.cshtml"
Write(Html.ForDropDownList("month", ms, Request["month"], "所有月份", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 52 "..\..\Areas\Admin\Views\VisitStat\_List_Search.cshtml"
Write(Html.ForDropDownList("day", ds, Request["day"], "所有天", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

            
            #line 54 "..\..\Areas\Admin\Views\VisitStat\_List_Search.cshtml"
Write(Html.Partial("_DateRange"));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
