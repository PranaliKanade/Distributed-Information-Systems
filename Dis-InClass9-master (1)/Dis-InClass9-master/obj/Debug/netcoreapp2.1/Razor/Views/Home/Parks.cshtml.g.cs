#pragma checksum "C:\Users\Pranali\Desktop\Pranali Kanade\MS\USF\DIS\InClass9\NationalParksExample-master\NationalParksExample-master\NationalParks\Views\Home\Parks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "202ca2cecae77adfc7f91fde9647a7554364cabf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Parks), @"mvc.1.0.view", @"/Views/Home/Parks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Parks.cshtml", typeof(AspNetCore.Views_Home_Parks))]
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
#line 1 "C:\Users\Pranali\Desktop\Pranali Kanade\MS\USF\DIS\InClass9\NationalParksExample-master\NationalParksExample-master\NationalParks\Views\_ViewImports.cshtml"
using NationalParks;

#line default
#line hidden
#line 2 "C:\Users\Pranali\Desktop\Pranali Kanade\MS\USF\DIS\InClass9\NationalParksExample-master\NationalParksExample-master\NationalParks\Views\_ViewImports.cshtml"
using NationalParks.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"202ca2cecae77adfc7f91fde9647a7554364cabf", @"/Views/Home/Parks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"900709f6d3ba43cfa31f0e8956ecab1c84d2d296", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Parks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NationalParks.Models.Parks>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 28, true);
            WriteLiteral("\r\n<h1>Parks</h1>\r\n<hr />\r\n\r\n");
            EndContext();
#line 6 "C:\Users\Pranali\Desktop\Pranali Kanade\MS\USF\DIS\InClass9\NationalParksExample-master\NationalParksExample-master\NationalParks\Views\Home\Parks.cshtml"
 foreach (var item in Model.data)
{

#line default
#line hidden
            BeginContext(100, 25, true);
            WriteLiteral("<div>\r\n    <h3>\r\n        ");
            EndContext();
            BeginContext(126, 43, false);
#line 10 "C:\Users\Pranali\Desktop\Pranali Kanade\MS\USF\DIS\InClass9\NationalParksExample-master\NationalParksExample-master\NationalParks\Views\Home\Parks.cshtml"
   Write(Html.DisplayFor(modelItem => item.fullName));

#line default
#line hidden
            EndContext();
            BeginContext(169, 32, true);
            WriteLiteral("\r\n    </h3>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(202, 46, false);
#line 13 "C:\Users\Pranali\Desktop\Pranali Kanade\MS\USF\DIS\InClass9\NationalParksExample-master\NationalParksExample-master\NationalParks\Views\Home\Parks.cshtml"
   Write(Html.DisplayFor(modelItem => item.description));

#line default
#line hidden
            EndContext();
            BeginContext(248, 20, true);
            WriteLiteral("\r\n    </div>\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 268, "\"", 284, 1);
#line 15 "C:\Users\Pranali\Desktop\Pranali Kanade\MS\USF\DIS\InClass9\NationalParksExample-master\NationalParksExample-master\NationalParks\Views\Home\Parks.cshtml"
WriteAttributeValue("", 275, item.url, 275, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(285, 27, true);
            WriteLiteral(" target=\"_blank\">\r\n        ");
            EndContext();
            BeginContext(313, 38, false);
#line 16 "C:\Users\Pranali\Desktop\Pranali Kanade\MS\USF\DIS\InClass9\NationalParksExample-master\NationalParksExample-master\NationalParks\Views\Home\Parks.cshtml"
   Write(Html.DisplayFor(modelItem => item.url));

#line default
#line hidden
            EndContext();
            BeginContext(351, 62, true);
            WriteLiteral("\r\n    </a>\r\n    <div>\r\n        <h5>Directions: </h5>\r\n        ");
            EndContext();
            BeginContext(414, 49, false);
#line 20 "C:\Users\Pranali\Desktop\Pranali Kanade\MS\USF\DIS\InClass9\NationalParksExample-master\NationalParksExample-master\NationalParks\Views\Home\Parks.cshtml"
   Write(Html.DisplayFor(modelItem => item.directionsInfo));

#line default
#line hidden
            EndContext();
            BeginContext(463, 28, true);
            WriteLiteral("\n    </div>\r\n</div>\r\n<br/>\r\n");
            EndContext();
#line 24 "C:\Users\Pranali\Desktop\Pranali Kanade\MS\USF\DIS\InClass9\NationalParksExample-master\NationalParksExample-master\NationalParks\Views\Home\Parks.cshtml"
}

#line default
#line hidden
            BeginContext(494, 28, true);
            WriteLiteral("\r\n<script>\r\n    alertDbSave(");
            EndContext();
            BeginContext(523, 21, false);
#line 27 "C:\Users\Pranali\Desktop\Pranali Kanade\MS\USF\DIS\InClass9\NationalParksExample-master\NationalParksExample-master\NationalParks\Views\Home\Parks.cshtml"
           Write(ViewBag.dbSuccessComp);

#line default
#line hidden
            EndContext();
            BeginContext(544, 13, true);
            WriteLiteral(");\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NationalParks.Models.Parks> Html { get; private set; }
    }
}
#pragma warning restore 1591
