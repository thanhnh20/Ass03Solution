#pragma checksum "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\RoleMember\OrderHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d271e5b68ebf9e13b9e4e94af894e143f1b63b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RoleMember_OrderHistory), @"mvc.1.0.view", @"/Views/RoleMember/OrderHistory.cshtml")]
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
#line 1 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\_ViewImports.cshtml"
using eStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\_ViewImports.cshtml"
using eStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d271e5b68ebf9e13b9e4e94af894e143f1b63b3", @"/Views/RoleMember/OrderHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6a7cd37460f953b9787e736e6c4fe42df2fc1ad", @"/Views/_ViewImports.cshtml")]
    public class Views_RoleMember_OrderHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyLibrary.Models.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\RoleMember\OrderHistory.cshtml"
  
    ViewData["Title"] = "OrderHistory";
    Layout = "~/Views/Shared/_LayoutMember.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>OrderHistory</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\RoleMember\OrderHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\RoleMember\OrderHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\RoleMember\OrderHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.RequiredDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\RoleMember\OrderHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.ShippedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\RoleMember\OrderHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.Freight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            \r\n            <th>Action</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\RoleMember\OrderHistory.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\RoleMember\OrderHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\RoleMember\OrderHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\RoleMember\OrderHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.RequiredDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\RoleMember\OrderHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.ShippedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\RoleMember\OrderHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.Freight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td>\r\n                ");
#nullable restore
#line 53 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\RoleMember\OrderHistory.cshtml"
           Write(Html.ActionLink("Details", "OrderHistoryDetail", new {orderID = item.OrderId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 56 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\RoleMember\OrderHistory.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyLibrary.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
