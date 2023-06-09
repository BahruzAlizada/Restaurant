#pragma checksum "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Areas\Admin\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e63432f45dee08b348e233fed85ec8a72f65d9d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Contact_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Areas\Admin\Views\_ViewImports.cshtml"
using Restaurant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Areas\Admin\Views\_ViewImports.cshtml"
using Restaurant.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Areas\Admin\Views\_ViewImports.cshtml"
using Restaurant.ViewsModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e63432f45dee08b348e233fed85ec8a72f65d9d4", @"/Areas/Admin/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3252bb80a0572243a0a2c06d4a14dfe742524a68", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info rounded-pill text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<hr class=""my-5"" />

<!-- Bordered Table -->
<div class=""card"">
    <div class=""card-header"" style=""display:flex;justify-content:center"">
        <h2 style=""text-align:center;"">
            Contact Info
        </h2> 
    </div>
    <div class=""card-body"">
        <div class=""table-responsive text-nowrap"">
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th>Booking Email</th>
                        <th>General Email</th>
                        <th>Tecnichial Email</th>
                        <th style=""text-align:right"">Action</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 23 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Areas\Admin\Views\Contact\Index.cshtml"
                     foreach (ContactInfo item in Model.ContactInfo)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                           <td>");
#nullable restore
#line 26 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Areas\Admin\Views\Contact\Index.cshtml"
                          Write(item.BookingEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                           <td>");
#nullable restore
#line 27 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Areas\Admin\Views\Contact\Index.cshtml"
                          Write(item.GeneralEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                           <td>");
#nullable restore
#line 28 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Areas\Admin\Views\Contact\Index.cshtml"
                          Write(item.TechinialEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>\r\n                                <div style=\"display:flex;justify-content:flex-end\">                         \r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e63432f45dee08b348e233fed85ec8a72f65d9d46726", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Areas\Admin\Views\Contact\Index.cshtml"
                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("          \r\n                                </div>\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Areas\Admin\Views\Contact\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</div>
<!--/ Bordered Table -->

<hr class=""my-5"" />


<!-- Bordered Table -->
<div class=""card"">
    <div class=""card-header"" style=""display:flex;justify-content:center"">
        <h2>
            Contact Form
        </h2>     
    </div>
    <div class=""card-body"">
        <div class=""table-responsive text-nowrap"">
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Email</th>
                        <th>Subject</th>
                        <th>Message</th>
                        <th>Created Time</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 68 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Areas\Admin\Views\Contact\Index.cshtml"
                     foreach (ContactForm item in Model.Form)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 71 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Areas\Admin\Views\Contact\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 72 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Areas\Admin\Views\Contact\Index.cshtml"
                           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 73 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Areas\Admin\Views\Contact\Index.cshtml"
                           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 74 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Areas\Admin\Views\Contact\Index.cshtml"
                           Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 75 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Areas\Admin\Views\Contact\Index.cshtml"
                           Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 77 "C:\Users\Esma\Desktop\GitHub Project\Restaurant\Restaurant\Restaurant\Areas\Admin\Views\Contact\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--/ Bordered Table -->\r\n\r\n<hr class=\"my-5\" />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
