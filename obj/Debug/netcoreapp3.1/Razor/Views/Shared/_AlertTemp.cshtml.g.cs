#pragma checksum "D:\Study\net104\ASMMAIN\NET104\Views\Shared\_AlertTemp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34c1b07d18dce31d8769c6ab71ac048ac487f8fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AlertTemp), @"mvc.1.0.view", @"/Views/Shared/_AlertTemp.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34c1b07d18dce31d8769c6ab71ac048ac487f8fe", @"/Views/Shared/_AlertTemp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6026e44d3c177711fb395dba6086084292801d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AlertTemp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Study\net104\ASMMAIN\NET104\Views\Shared\_AlertTemp.cshtml"
  
    var message = TempData["Message"] as string;
    var MessageType = TempData["MessageType"] as string;
    MessageType ??= AlertModel.Type.success;
    AlertModel alert = null;
    if(message != null) { 
        alert = new AlertModel(MessageType , message);
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 13 "D:\Study\net104\ASMMAIN\NET104\Views\Shared\_AlertTemp.cshtml"
 if (alert != null)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 337, "\"", 367, 2);
            WriteAttributeValue("", 345, "alert", 345, 5, true);
#nullable restore
#line 17 "D:\Study\net104\ASMMAIN\NET104\Views\Shared\_AlertTemp.cshtml"
WriteAttributeValue(" ", 350, alert.classType, 351, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n            <div class=\"alert-icon\">\r\n                <i");
            BeginWriteAttribute("class", " class=\"", 429, "\"", 448, 1);
#nullable restore
#line 20 "D:\Study\net104\ASMMAIN\NET104\Views\Shared\_AlertTemp.cshtml"
WriteAttributeValue("", 437, alert.icon, 437, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n            </div>\r\n            <div class=\"alert-body\">\r\n                <p class=\"alert-desc\">");
#nullable restore
#line 23 "D:\Study\net104\ASMMAIN\NET104\Views\Shared\_AlertTemp.cshtml"
                                 Write(alert.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 27 "D:\Study\net104\ASMMAIN\NET104\Views\Shared\_AlertTemp.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
