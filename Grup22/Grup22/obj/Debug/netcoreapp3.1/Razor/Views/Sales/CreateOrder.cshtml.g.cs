#pragma checksum "C:\Users\EMRE\Source\Repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Sales\CreateOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22a2fcbb5b188849796f35acc462e6d61a5616e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sales_CreateOrder), @"mvc.1.0.view", @"/Views/Sales/CreateOrder.cshtml")]
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
#line 1 "C:\Users\EMRE\Source\Repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\_ViewImports.cshtml"
using Grup22;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EMRE\Source\Repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\_ViewImports.cshtml"
using Grup22.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a2fcbb5b188849796f35acc462e6d61a5616e7", @"/Views/Sales/CreateOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"320e68ff9d49128fb11a7b21c53c498cce452133", @"/Views/_ViewImports.cshtml")]
    public class Views_Sales_CreateOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Grup22.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\EMRE\Source\Repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Sales\CreateOrder.cshtml"
  
    ViewData["Title"] = "CreateOrder";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CreateOrder</h1>\r\n\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\EMRE\Source\Repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Sales\CreateOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.productImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <img class=\"img-responsive\"");
            BeginWriteAttribute("src", " src=\"", 398, "\"", 452, 1);
#nullable restore
#line 18 "C:\Users\EMRE\Source\Repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Sales\CreateOrder.cshtml"
WriteAttributeValue("", 404, Html.DisplayFor(model => model.productImageUrl), 404, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"100\" />\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\EMRE\Source\Repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Sales\CreateOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.productName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\EMRE\Source\Repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Sales\CreateOrder.cshtml"
       Write(Html.DisplayFor(model => model.productName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Mevcut Stok\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\EMRE\Source\Repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Sales\CreateOrder.cshtml"
       Write(Html.DisplayFor(model => model.productStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\EMRE\Source\Repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Sales\CreateOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.productPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\EMRE\Source\Repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Sales\CreateOrder.cshtml"
       Write(Html.DisplayFor(model => model.productPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Fabrika Adresi\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\EMRE\Source\Repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Sales\CreateOrder.cshtml"
       Write(Html.DisplayFor(model => model.productFactoryUser.factoryUserAdress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22a2fcbb5b188849796f35acc462e6d61a5616e77503", async() => {
                WriteLiteral("\r\n        <div class=\"form-horizontal\">\r\n            <div class=\"form-group\">\r\n                <div class=\"alert col-sm-3\" style=\"color:red\">");
#nullable restore
#line 51 "C:\Users\EMRE\Source\Repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Sales\CreateOrder.cshtml"
                                                         Write(ViewBag.error);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
            </div>
            <div class=""form-group"">
                <input class=""col-sm-3"" name=""amountRequested"" type=""number"" />
            </div>
            <div class=""form-group"">
                <button class=""col-sm-2 btn btn-primary"" type=""submit"" name=""saleProductId""");
                BeginWriteAttribute("value", " value=\"", 1823, "\"", 1873, 1);
#nullable restore
#line 57 "C:\Users\EMRE\Source\Repos\atakankar\YZM-4215-GRUP-22\Grup22\Grup22\Views\Sales\CreateOrder.cshtml"
WriteAttributeValue("", 1831, Html.DisplayFor(model => model.productId), 1831, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Siparişi Oluştur</button>\r\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Grup22.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591