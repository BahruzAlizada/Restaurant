#pragma checksum "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Service\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e1d75c5049cfbb5afc43bbe45fabbee2eb86f2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Service_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Service/Default.cshtml")]
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
#line 1 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\_ViewImports.cshtml"
using Restaurant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\_ViewImports.cshtml"
using Restaurant.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\_ViewImports.cshtml"
using Restaurant.ViewsModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e1d75c5049cfbb5afc43bbe45fabbee2eb86f2a", @"/Views/Shared/Components/Service/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3252bb80a0572243a0a2c06d4a14dfe742524a68", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Service_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Service\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-lg-3 col-sm-6 wow fadeInUp\" data-wow-delay=\"0.3s\">\r\n        <div class=\"service-item rounded pt-3\">\r\n\t\t\t<div class=\"p-4\">\r\n                ");
#nullable restore
#line 8 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Service\Default.cshtml"
           Write(Html.Raw(item.Icon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <h5>");
#nullable restore
#line 9 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Service\Default.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p>");
#nullable restore
#line 10 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Service\Default.cshtml"
              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Service\Default.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
