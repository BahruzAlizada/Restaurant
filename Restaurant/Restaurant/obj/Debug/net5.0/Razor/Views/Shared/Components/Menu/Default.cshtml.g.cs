#pragma checksum "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a27ac7b83cf296a122491e104631cc3f689e0e31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a27ac7b83cf296a122491e104631cc3f689e0e31", @"/Views/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3252bb80a0572243a0a2c06d4a14dfe742524a68", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MenuVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("flex-shrink-0 img-fluid rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 80px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""text-center wow fadeInUp"" data-wow-delay=""0.1s"">
    <h5 class=""section-title ff-secondary text-center text-primary fw-normal"">Food Menu</h5>
    <h1 class=""mb-5"">Most Popular Items</h1>
</div>
<div class=""tab-class text-center wow fadeInUp"" data-wow-delay=""0.1s"">
    <ul class=""nav nav-pills d-inline-flex justify-content-center border-bottom mb-5"">
        <li class=""nav-item"">
            <a class=""d-flex align-items-center text-start mx-3 ms-0 pb-3 active"" data-bs-toggle=""pill"" href=""#tab-1"">
                <i class=""fa fa-pizza-slice fa-2x text-primary""></i>
                <div class=""ps-3"">

                    <p class=""mt-n1 mb-0"">Pizza</p>
                </div>
            </a>
        </li>

        <li class=""nav-item"">
            <a class=""d-flex align-items-center text-start mx-3 pb-3"" data-bs-toggle=""pill"" href=""#tab-2"">
                <i class=""fa fa-hamburger fa-2x text-primary""></i>
                <div class=""ps-3"">
                    <p class=""mt-n1 mb");
            WriteLiteral(@"-0"">Burger</p>
                </div>
            </a>
        </li>

        <li class=""nav-item"">
            <a class=""d-flex align-items-center text-start mx-3 me-0 pb-3"" data-bs-toggle=""pill"" href=""#tab-3"">
                <i class=""fa fa-utensils fa-2x text-primary""></i>
                <div class=""ps-3"">
                    <p class=""mt-n1 mb-0"">Dinner</p>
                </div>
            </a>
        </li>

        <li class=""nav-item"">
            <a class=""d-flex align-items-center text-start mx-3 me-0 pb-3"" data-bs-toggle=""pill"" href=""#tab-4"">
                <i class=""fa fa-coffee fa-2x text-primary""></i>
                <div class=""ps-3"">
                    <p class=""mt-n1 mb-0"">Drink</p>
                </div>
            </a>
        </li>
    </ul>
    <div class=""tab-content"">
        <div id=""tab-1"" class=""tab-pane fade show p-0 active"">
            <div class=""row g-4"">
");
#nullable restore
#line 49 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                 foreach (Product product in Model.Products)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                     if (product.CategoryId == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-6\">\r\n                            <div class=\"d-flex align-items-center\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a27ac7b83cf296a122491e104631cc3f689e0e317364", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2324, "~/img/", 2324, 6, true);
#nullable restore
#line 55 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
AddHtmlAttributeValue("", 2330, product.Image, 2330, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"w-100 d-flex flex-column text-start ps-4\">\r\n                                    <h5 class=\"d-flex justify-content-between border-bottom pb-2\">\r\n                                        <span>");
#nullable restore
#line 58 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                                         Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <span class=\"text-primary\">$");
#nullable restore
#line 59 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                                                               Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </h5>\r\n                                    <small class=\"fst-italic\">");
#nullable restore
#line 61 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                                                         Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 65 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <div id=\"tab-2\" class=\"tab-pane fade show p-0\">\r\n            <div class=\"row g-4\">\r\n");
#nullable restore
#line 74 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                 foreach (Product item in Model.Products)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                     if (item.CategoryId == 2)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-6\">\r\n                            <div class=\"d-flex align-items-center\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a27ac7b83cf296a122491e104631cc3f689e0e3111998", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3490, "~/img/", 3490, 6, true);
#nullable restore
#line 80 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
AddHtmlAttributeValue("", 3496, item.Image, 3496, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"w-100 d-flex flex-column text-start ps-4\">\r\n                                    <h5 class=\"d-flex justify-content-between border-bottom pb-2\">\r\n                                        <span>");
#nullable restore
#line 83 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <span class=\"text-primary\">$");
#nullable restore
#line 84 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                                                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </h5>\r\n                                    <small class=\"fst-italic\">");
#nullable restore
#line 86 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                                                         Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 90 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n        <div id=\"tab-3\" class=\"tab-pane fade show p-0\">\r\n            <div class=\"row g-4\">\r\n");
#nullable restore
#line 97 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                 foreach (Product item2 in Model.Products)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                     if (item2.CategoryId == 4)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-6\">\r\n                            <div class=\"d-flex align-items-center\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a27ac7b83cf296a122491e104631cc3f689e0e3116615", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4642, "~/img/", 4642, 6, true);
#nullable restore
#line 103 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
AddHtmlAttributeValue("", 4648, item2.Image, 4648, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"w-100 d-flex flex-column text-start ps-4\">\r\n                                    <h5 class=\"d-flex justify-content-between border-bottom pb-2\">\r\n                                        <span>");
#nullable restore
#line 106 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                                         Write(item2.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <span class=\"text-primary\">$");
#nullable restore
#line 107 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                                                               Write(item2.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </h5>\r\n                                    <small class=\"fst-italic\">");
#nullable restore
#line 109 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                                                         Write(item2.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 113 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n        <div id=\"tab-4\" class=\"tab-pane fade show p-0\">\r\n            <div class=\"row g-4\">\r\n");
#nullable restore
#line 120 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                 foreach (Product item3 in Model.Products)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                     if (item3.CategoryId == 3)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-6\">\r\n                            <div class=\"d-flex align-items-center\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a27ac7b83cf296a122491e104631cc3f689e0e3121244", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5798, "~/img/", 5798, 6, true);
#nullable restore
#line 126 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
AddHtmlAttributeValue("", 5804, item3.Image, 5804, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"w-100 d-flex flex-column text-start ps-4\">\r\n                                    <h5 class=\"d-flex justify-content-between border-bottom pb-2\">\r\n                                        <span>");
#nullable restore
#line 129 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                                         Write(item3.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <span class=\"text-primary\">$");
#nullable restore
#line 130 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                                                               Write(item3.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </h5>\r\n                                    <small class=\"fst-italic\">");
#nullable restore
#line 132 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                                                         Write(item3.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 136 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Views\Shared\Components\Menu\Default.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MenuVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
