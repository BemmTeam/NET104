#pragma checksum "D:\Study\net104\ASMMAIN\NET104\Areas\Manage\Views\Shared\_AlertView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20735346d659bb4645a0f1a2c1417efdad12557c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Shared__AlertView), @"mvc.1.0.view", @"/Areas/Manage/Views/Shared/_AlertView.cshtml")]
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
#line 1 "D:\Study\net104\ASMMAIN\NET104\Areas\Manage\Views\_ViewImports.cshtml"
using ASMMAIN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study\net104\ASMMAIN\NET104\Areas\Manage\Views\_ViewImports.cshtml"
using ASMMAIN.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Study\net104\ASMMAIN\NET104\Areas\Manage\Views\_ViewImports.cshtml"
using ASMMAIN.Areas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20735346d659bb4645a0f1a2c1417efdad12557c", @"/Areas/Manage/Views/Shared/_AlertView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dffe83833ee66c4003971962cbbf0b3d1588e9da", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Shared__AlertView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 10 "D:\Study\net104\ASMMAIN\NET104\Areas\Manage\Views\Shared\_AlertView.cshtml"
                                    

    var alert = ViewData["Message"] as AlertModel;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 17 "D:\Study\net104\ASMMAIN\NET104\Areas\Manage\Views\Shared\_AlertView.cshtml"
 if (alert != null)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 463, "\"", 493, 2);
            WriteAttributeValue("", 471, "alert", 471, 5, true);
#nullable restore
#line 21 "D:\Study\net104\ASMMAIN\NET104\Areas\Manage\Views\Shared\_AlertView.cshtml"
WriteAttributeValue(" ", 476, alert.classType, 477, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n            <div class=\"alert-icon\">\r\n                <i");
            BeginWriteAttribute("class", " class=\"", 555, "\"", 574, 1);
#nullable restore
#line 24 "D:\Study\net104\ASMMAIN\NET104\Areas\Manage\Views\Shared\_AlertView.cshtml"
WriteAttributeValue("", 563, alert.icon, 563, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n            </div>\r\n            <div class=\"alert-body\">\r\n                <p class=\"alert-desc\">");
#nullable restore
#line 27 "D:\Study\net104\ASMMAIN\NET104\Areas\Manage\Views\Shared\_AlertView.cshtml"
                                 Write(alert.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 31 "D:\Study\net104\ASMMAIN\NET104\Areas\Manage\Views\Shared\_AlertView.cshtml"
}

#line default
#line hidden
#nullable disable
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
