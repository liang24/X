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
    
    #line 6 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using System.Web.Mvc.Ajax;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using System.Web.Routing;
    
    #line default
    #line hidden
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 3 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/VisitStat/_List_Data.cshtml")]
    public partial class _Areas_Admin_Views_VisitStat__List_Data_cshtml : System.Web.Mvc.WebViewPage<IList<XCode.Membership.VisitStat>>
    {
        public _Areas_Admin_Views_VisitStat__List_Data_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 10 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as List<FieldItem>;

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n            <th");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 559), Tuple.Create("\"", 598)
            
            #line 18 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 566), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("ID"))
            
            #line default
            #line hidden
, 566), false)
);

WriteLiteral(">编号</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 651), Tuple.Create("\"", 692)
            
            #line 19 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 658), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Year"))
            
            #line default
            #line hidden
, 658), false)
);

WriteLiteral(">年</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 744), Tuple.Create("\"", 786)
            
            #line 20 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 751), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Month"))
            
            #line default
            #line hidden
, 751), false)
);

WriteLiteral(">月</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 838), Tuple.Create("\"", 878)
            
            #line 21 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 845), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Day"))
            
            #line default
            #line hidden
, 845), false)
);

WriteLiteral(">日</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 930), Tuple.Create("\"", 971)
            
            #line 22 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 937), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Page"))
            
            #line default
            #line hidden
, 937), false)
);

WriteLiteral(">页面</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1024), Tuple.Create("\"", 1066)
            
            #line 23 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1031), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Title"))
            
            #line default
            #line hidden
, 1031), false)
);

WriteLiteral(">标题</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1119), Tuple.Create("\"", 1161)
            
            #line 24 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1126), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Times"))
            
            #line default
            #line hidden
, 1126), false)
);

WriteLiteral(">次数</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1214), Tuple.Create("\"", 1256)
            
            #line 25 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1221), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Users"))
            
            #line default
            #line hidden
, 1221), false)
);

WriteLiteral(">用户</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1309), Tuple.Create("\"", 1349)
            
            #line 26 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1316), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("IPs"))
            
            #line default
            #line hidden
, 1316), false)
);

WriteLiteral(">IP</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1402), Tuple.Create("\"", 1443)
            
            #line 27 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1409), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Cost"))
            
            #line default
            #line hidden
, 1409), false)
);

WriteLiteral(">耗时</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1496), Tuple.Create("\"", 1543)
            
            #line 28 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1503), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("CreateTime"))
            
            #line default
            #line hidden
, 1503), false)
);

WriteLiteral(">创建时间</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1598), Tuple.Create("\"", 1645)
            
            #line 29 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1605), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("UpdateTime"))
            
            #line default
            #line hidden
, 1605), false)
);

WriteLiteral(">更新时间</a></th>\r\n");

            
            #line 30 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 30 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
             if (ManageProvider.User.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">操作</th>\r\n");

            
            #line 33 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 37 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
        
            
            #line default
            #line hidden
            
            #line 37 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
         foreach (var entity in Model)
        {
            var y = entity.Year > 0 ? entity.Year + "" : "全部";
            var m = entity.Month > 0 ? entity.Month + "" : "";
            var d = entity.Day > 0 ? entity.Day + "" : "";

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral(">");

            
            #line 43 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                                                 Write(entity.ID);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 44 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(y);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 45 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(m);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 46 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(d);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 47 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
               Write(entity.Page);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 48 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
               Write(entity.Title);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 49 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(entity.Times.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 50 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(entity.Users.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 51 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(entity.IPs.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 52 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(entity.AvgCost.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral(" ms</td>\r\n                <td>");

            
            #line 53 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
               Write(entity.CreateTime.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 54 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
               Write(entity.UpdateTime.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 55 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 55 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                 if (ManageProvider.User.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 58 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                   Write(Html.Partial("_List_Data_Action", (Object)entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 60 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 62 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>");

        }
    }
}
#pragma warning restore 1591
