#pragma checksum "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ca0d6f65ff8eb19ee9b8aea4b621c7aa986490d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ca0d6f65ff8eb19ee9b8aea4b621c7aa986490d", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6a7cd37460f953b9787e736e6c4fe42df2fc1ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyLibrary.Models.OrderDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Order Details</h1>\r\n");
#nullable restore
#line 9 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
  
    double total = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
  
    var order = ViewData["order"] as MyLibrary.Models.Order;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            OrderId\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
       Write(order.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd> \r\n        <dt class = \"col-sm-2\">\r\n            Member\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
       Write(order.Member.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            OrderDate\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
       Write(order.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>   \r\n        <dt class = \"col-sm-2\">\r\n            RequiredDate\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
       Write(order.RequiredDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>   \r\n        <dt class = \"col-sm-2\">\r\n            ShippedDate\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
       Write(order.ShippedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>   \r\n        <dt class = \"col-sm-2\">\r\n            Freight\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
       Write(order.Freight);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>   \r\n\r\n    </dl>\r\n</div>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 62 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 66 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 70 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>          \r\n            <th>\r\n                ");
#nullable restore
#line 73 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>   \r\n            <th>\r\n                Price\r\n            </th>  \r\n            <th>Action</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 82 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
         foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("               \r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>           \r\n            <td>\r\n                ");
#nullable restore
#line 94 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>  \r\n            \r\n");
#nullable restore
#line 97 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
                total += ((double)item.UnitPrice * (double)item.Quantity) * (1 - (double)item.Discount/100);

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
                  
                    double price = ((double)item.UnitPrice * (double)item.Quantity) * (1 - (double)item.Discount / 100);
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                ");
#nullable restore
#line 102 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
           Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td> \r\n            <td>\r\n                ");
#nullable restore
#line 105 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { orderID = item.OrderId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 108 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
        
  }   

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            Total Price\r\n        </dt>\r\n        <dd class = \"col-sm-10 text-danger\">\r\n");
#nullable restore
#line 117 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
              
                total += (double)order.Freight;
          

#line default
#line hidden
#nullable disable
            WriteLiteral("          ");
#nullable restore
#line 120 "F:\PRN211\Ass03\Ass03Solution_SE1625_SE151252\eStore\Views\Order\Details.cshtml"
     Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>   \r\n    </dl>\r\n         \r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ca0d6f65ff8eb19ee9b8aea4b621c7aa986490d11854", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyLibrary.Models.OrderDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
