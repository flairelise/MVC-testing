#pragma checksum "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61eec4fdc37045b98d5f301e0c3a342f1d90a502"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Details), @"mvc.1.0.view", @"/Views/Shared/Details.cshtml")]
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
#line 1 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\_ViewImports.cshtml"
using BusinessDevProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\_ViewImports.cshtml"
using WebMatrix.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\_ViewImports.cshtml"
using WebMatrix.WebData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
using BusinessDevProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61eec4fdc37045b98d5f301e0c3a342f1d90a502", @"/Views/Shared/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82d753633e010e71ab516b7f3855722ad06d30ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61eec4fdc37045b98d5f301e0c3a342f1d90a5024510", async() => {
                WriteLiteral("\r\n    <div>\r\n        <h4>Details</h4>\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n");
#nullable restore
#line 12 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
      



        if (Model != null)
        {


            foreach (var Data in Model)
            {
                for (int i = 0; i < 1; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"container\">\r\n                        <div class=\"row\">Title: ");
#nullable restore
#line 25 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
                                           Write(Data.Movie_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"row\">Director: ");
#nullable restore
#line 26 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
                                              Write(Data.Director_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"row\">Is Streamable: ");
#nullable restore
#line 27 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
                                                   Write(Data.Streamable);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"row\">Genre: ");
#nullable restore
#line 28 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
                                           Write(Data.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                        <div class=\"row\">Release Date: ");
#nullable restore
#line 29 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
                                                  Write(Data.Release_Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                        <div class=\"row\">Duration: ");
#nullable restore
#line 30 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
                                              Write(Data.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" minutes </div>\r\n                    </div>\r\n");
#nullable restore
#line 32 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"

                }
                break;
            }


            double x = 0;
            double y = 0;

            foreach (var Data in Model)
            {


                x = x + Convert.ToDouble(@Data.Rating);
                y = y + 1;

            }

            x = x / y;


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"container\">\r\n                <div class=\"row\">Avg. Rating: ");
#nullable restore
#line 53 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
                                         Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n            </div>\r\n");
#nullable restore
#line 55 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
        }

    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>
<p></p>
<p></p>
<h5>Rate Movie?</h5>

<div class=""container"">

    <div class=""btn-toolbar"" role=""toolbar"" aria-label=""Toolbar with button groups"">
        <div class=""btn-group mr-2"" role=""group"" aria-label=""First group"">
            <a class=""btn btn-info""");
            BeginWriteAttribute("href", " href=\"", 1627, "\"", 1661, 1);
#nullable restore
#line 68 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
WriteAttributeValue("", 1634, Url.Action("Rate1","Home"), 1634, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">1</a>\r\n            <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1705, "\"", 1739, 1);
#nullable restore
#line 69 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
WriteAttributeValue("", 1712, Url.Action("Rate2","Home"), 1712, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">2</a>\r\n            <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1783, "\"", 1817, 1);
#nullable restore
#line 70 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
WriteAttributeValue("", 1790, Url.Action("Rate3","Home"), 1790, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">3</a>\r\n            <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1861, "\"", 1895, 1);
#nullable restore
#line 71 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
WriteAttributeValue("", 1868, Url.Action("Rate4","Home"), 1868, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">4</a>\r\n            <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1939, "\"", 1973, 1);
#nullable restore
#line 72 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
WriteAttributeValue("", 1946, Url.Action("Rate5","Home"), 1946, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">5</a>\r\n            <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 2017, "\"", 2051, 1);
#nullable restore
#line 73 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
WriteAttributeValue("", 2024, Url.Action("Rate6","Home"), 2024, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">6</a>\r\n            <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 2095, "\"", 2129, 1);
#nullable restore
#line 74 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
WriteAttributeValue("", 2102, Url.Action("Rate7","Home"), 2102, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">7</a>\r\n            <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 2173, "\"", 2207, 1);
#nullable restore
#line 75 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
WriteAttributeValue("", 2180, Url.Action("Rate8","Home"), 2180, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">8</a>\r\n            <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 2251, "\"", 2285, 1);
#nullable restore
#line 76 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
WriteAttributeValue("", 2258, Url.Action("Rate9","Home"), 2258, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">9</a>\r\n            <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 2329, "\"", 2364, 1);
#nullable restore
#line 77 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
WriteAttributeValue("", 2336, Url.Action("Rate10","Home"), 2336, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">10</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            WriteLiteral("    <p></p>\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61eec4fdc37045b98d5f301e0c3a342f1d90a50214556", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label for=""ratingBox"">Comment:</label>
            <textarea class=""form-control"" id=""ratingBox"" name=""ratingBox"" rows=""1"" maxlength=""100""></textarea>
            <span>
                <input type=""submit"" class=""btn btn-info"" value=""Submit"" />
            </span>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("    <p></p>\r\n    <h5>Recent Comments:</h5>\r\n");
#nullable restore
#line 99 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
    foreach (var Data in Model)
    {
        if (Data != null || Data != "")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input class=\"form-control\" type=\"text\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2979, "\"", 3005, 1);
#nullable restore
#line 103 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
WriteAttributeValue("", 2993, Data.Review, 2993, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly>\r\n");
#nullable restore
#line 104 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Shared\Details.cshtml"
            }
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
