#pragma checksum "D:\Study\net104\ASMMAIN\NET104\Views\Home\detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2686931ca10abc32f1bf353810171cfdea09b217"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_detail), @"mvc.1.0.view", @"/Views/Home/detail.cshtml")]
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
#line 1 "D:\Study\net104\ASMMAIN\NET104\Views\_ViewImports.cshtml"
using ASMMAIN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study\net104\ASMMAIN\NET104\Views\_ViewImports.cshtml"
using ASMMAIN.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2686931ca10abc32f1bf353810171cfdea09b217", @"/Views/Home/detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6026e44d3c177711fb395dba6086084292801d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/product.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-image", new global::Microsoft.AspNetCore.Html.HtmlString("black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-image", new global::Microsoft.AspNetCore.Html.HtmlString("blue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-image", new global::Microsoft.AspNetCore.Html.HtmlString("red"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Study\net104\ASMMAIN\NET104\Views\Home\detail.cshtml"
  
  ViewData["Title"] = "detail";
  string display = "";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
  body {
    background-color: #edf1f5;
  }
</style>
<script>
  $(document).ready(function () {

    $('.color-choose input').on('click', function () {
      var headphonesColor = $(this).attr('data-image');

      $('.active').removeClass('active');
      $('.left-column img[data-image = ' + headphonesColor + ']').addClass('active');
      $(this).addClass('active');
    });

  });
</script>
<main class=""container"">

  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2686931ca10abc32f1bf353810171cfdea09b2177181", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  <!-- Left Column / Headphones Image -->\r\n\r\n  <div class=\"left-column\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2686931ca10abc32f1bf353810171cfdea09b2178382", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 690, "~/images/", 690, 9, true);
#nullable restore
#line 30 "D:\Study\net104\ASMMAIN\NET104\Views\Home\detail.cshtml"
AddHtmlAttributeValue("", 699, Model.image_url, 699, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2686931ca10abc32f1bf353810171cfdea09b21710009", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 758, "~/images/", 758, 9, true);
#nullable restore
#line 31 "D:\Study\net104\ASMMAIN\NET104\Views\Home\detail.cshtml"
AddHtmlAttributeValue("", 767, Model.image_url, 767, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2686931ca10abc32f1bf353810171cfdea09b21711637", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 840, "~/images/", 840, 9, true);
#nullable restore
#line 32 "D:\Study\net104\ASMMAIN\NET104\Views\Home\detail.cshtml"
AddHtmlAttributeValue("", 849, Model.image_url, 849, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  </div>\r\n\r\n\r\n  <!-- Right Column -->\r\n  <div class=\"right-column\">\r\n\r\n    <!-- Product Description -->\r\n    <div class=\"product-description\">\r\n      <span>Lego</span>\r\n      <h2>");
#nullable restore
#line 42 "D:\Study\net104\ASMMAIN\NET104\Views\Home\detail.cshtml"
     Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n      <p>");
#nullable restore
#line 43 "D:\Study\net104\ASMMAIN\NET104\Views\Home\detail.cshtml"
    Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    </div>

    <!-- Product Configuration -->
    <div class=""product-configuration"">

      <!-- Product Color -->
      <div class=""product-color"">
        <span>Color</span>

        <div class=""color-choose"">
          <div>
            <input data-image=""red"" type=""radio"" id=""red"" name=""color"" value=""red"" checked>
            <label for=""red""><span></span></label>
          </div>
          <div>
            <input data-image=""blue"" type=""radio"" id=""blue"" name=""color"" value=""blue"">
            <label for=""blue""><span></span></label>
          </div>
          <div>
            <input data-image=""black"" type=""radio"" id=""black"" name=""color"" value=""black"">
            <label for=""black""><span></span></label>
          </div>
        </div>

      </div>

      <!-- Cable Configuration -->
      <div class=""cable-config"">
        <span>Cable configuration</span>

        <div class=""cable-choose"">
          <button>Straight</button>
          <button>Coiled</button>
  ");
            WriteLiteral("        <button>Long-coiled</button>\r\n        </div>\r\n");
#nullable restore
#line 79 "D:\Study\net104\ASMMAIN\NET104\Views\Home\detail.cshtml"
         if (@Model.quantity == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div style=\"font-size: 1.2rem;\" class=\"text text-dark\">Số lượng: <span class=\"text-danger\"");
            BeginWriteAttribute("id", "\r\n            id=\"", 2325, "\"", 2366, 2);
            WriteAttributeValue("", 2343, "count-", 2343, 6, true);
#nullable restore
#line 82 "D:\Study\net104\ASMMAIN\NET104\Views\Home\detail.cshtml"
WriteAttributeValue("", 2349, Model.product_id, 2349, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Hết hàng</span></div>\r\n");
#nullable restore
#line 83 "D:\Study\net104\ASMMAIN\NET104\Views\Home\detail.cshtml"
          display = "hidden";
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div style=\"font-size: 1.2rem;\" class=\"text text-dark\">Số lượng: <span class=\"text-success\"");
            BeginWriteAttribute("id", "\r\n            id=\"", 2559, "\"", 2600, 2);
            WriteAttributeValue("", 2577, "count-", 2577, 6, true);
#nullable restore
#line 88 "D:\Study\net104\ASMMAIN\NET104\Views\Home\detail.cshtml"
WriteAttributeValue("", 2583, Model.product_id, 2583, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 88 "D:\Study\net104\ASMMAIN\NET104\Views\Home\detail.cshtml"
                                    Write(Model.quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n");
#nullable restore
#line 89 "D:\Study\net104\ASMMAIN\NET104\Views\Home\detail.cshtml"
          display = "visible";
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </div>\r\n    </div>\r\n\r\n    <!-- Product Pricing -->\r\n    <div class=\"product-price\">\r\n      <span>");
#nullable restore
#line 97 "D:\Study\net104\ASMMAIN\NET104\Views\Home\detail.cshtml"
       Write(Model.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</span>\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2686931ca10abc32f1bf353810171cfdea09b21717442", async() => {
                WriteLiteral("Thêm vào giỏ hàng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2819, "visibility:", 2819, 11, true);
#nullable restore
#line 98 "D:\Study\net104\ASMMAIN\NET104\Views\Home\detail.cshtml"
AddHtmlAttributeValue(" ", 2830, display, 2831, 8, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2839, ";", 2839, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "D:\Study\net104\ASMMAIN\NET104\Views\Home\detail.cshtml"
                                                                                 WriteLiteral(Model.product_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 11, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2932, "addCart(\'/images/", 2932, 17, true);
#nullable restore
#line 99 "D:\Study\net104\ASMMAIN\NET104\Views\Home\detail.cshtml"
AddHtmlAttributeValue("", 2949, Model.image_url, 2949, 16, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2965, "\',\'", 2965, 3, true);
#nullable restore
#line 99 "D:\Study\net104\ASMMAIN\NET104\Views\Home\detail.cshtml"
AddHtmlAttributeValue("", 2968, Model.name, 2968, 11, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2979, "\',\'", 2979, 3, true);
#nullable restore
#line 99 "D:\Study\net104\ASMMAIN\NET104\Views\Home\detail.cshtml"
AddHtmlAttributeValue("", 2982, Model.price, 2982, 12, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2994, "\'", 2994, 1, true);
            AddHtmlAttributeValue(" ", 2995, ",", 2996, 2, true);
            AddHtmlAttributeValue(" ", 2997, "\'", 2998, 2, true);
#nullable restore
#line 99 "D:\Study\net104\ASMMAIN\NET104\Views\Home\detail.cshtml"
AddHtmlAttributeValue("", 2999, Model.product_id, 2999, 17, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3016, "\')", 3016, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3033, "btn-", 3033, 4, true);
#nullable restore
#line 100 "D:\Study\net104\ASMMAIN\NET104\Views\Home\detail.cshtml"
AddHtmlAttributeValue("", 3037, Model.product_id, 3037, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n  </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
