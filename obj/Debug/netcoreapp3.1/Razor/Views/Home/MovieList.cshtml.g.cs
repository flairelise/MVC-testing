#pragma checksum "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f0daf11ef62cab06db9e96962241fd64756857b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MovieList), @"mvc.1.0.view", @"/Views/Home/MovieList.cshtml")]
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
#line 2 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\_ViewImports.cshtml"
using BusinessDevProject.Models;

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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f0daf11ef62cab06db9e96962241fd64756857b", @"/Views/Home/MovieList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82d753633e010e71ab516b7f3855722ad06d30ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MovieList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MovieList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
  
    ViewData["Title"] = "Movies";

    string[] TableHeaders = new string[] {"Movie Title"
                        ,"Director"
                        ,"Streamable"
                        ,"Genre"
                        ,"Release Date"
                        ,"Duration (min)"
                        ,"Info"
                                };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n   <h2>Movie List</h2>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f0daf11ef62cab06db9e96962241fd64756857b5080", async() => {
                WriteLiteral(@"
        <p>
            <div class=""input-group mb-3"">

                <input type=""text"" class=""form-control"" placeholder=""Movie Title..."" name=""SearchString"" />
                <div class=""input-group-append"">
                    <span>
                        <input type=""submit"" class=""btn btn-info"" value=""Search"" />
                    </span>
                </div>
            </div>
        </p>
    ");
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
            WriteLiteral("\r\n\r\n</div>\r\n<div class=\"table\">\r\n    <table class=\"table table-bordered table-hover\">\r\n        <thead>\r\n            <tr>\r\n");
#nullable restore
#line 37 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
                  
                    foreach (var head in TableHeaders)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th>\r\n                            ");
#nullable restore
#line 41 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
                       Write(head);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n");
#nullable restore
#line 43 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n        </thead>\r\n\r\n        <tbody>\r\n");
#nullable restore
#line 49 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
              
                if (Model != null)
                {
                    foreach (var Data in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 55 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
                           Write(Data.Movie_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 56 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
                           Write(Data.Director_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 57 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
                           Write(Data.Streamable);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                            <td>");
#nullable restore
#line 58 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
                           Write(Data.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 59 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
                           Write(Data.Release_Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 60 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
                           Write(Data.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 61 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
                           Write(Html.ActionLink("Details", "Details", new { id = Data.Movie_ID} ));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
