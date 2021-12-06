#pragma checksum "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04b77cbff8366b54ed831a7502d0bc747ca88234"
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
#line 1 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
using WebMatrix.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
using WebMatrix.WebData;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04b77cbff8366b54ed831a7502d0bc747ca88234", @"/Views/Home/MovieList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82d753633e010e71ab516b7f3855722ad06d30ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MovieList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
   
    ViewData["Title"] = "Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 7 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
  
  
    var db = Database.Open("SQLServerConnectionString");
    var selectQueryString = "SELECT Movie_Name, Streamable, Release_Date, Duration FROM Movie ORDER BY Movie_Name";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04b77cbff8366b54ed831a7502d0bc747ca882344438", async() => {
                WriteLiteral("\r\n    <title>Movies</title>\r\n    <style>\r\n        table, th, td {\r\n            border: solid 1px #bbbbbb;\r\n            border-collapse: collapse;\r\n            padding: 2px;\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04b77cbff8366b54ed831a7502d0bc747ca882345617", async() => {
                WriteLiteral(@"
    <h1>Movie List</h1>
    <table>
        <thead>
            <tr>
                <th>Name</th>
                <th>Streamable (Y/N)</th>
                <th>Release Date</th>
                <th>Duration</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 38 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
             foreach (var row in db.Query(selectQueryString))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
                   Write(row.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
                   Write(row.Streamable);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
                   Write(row.Release);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Date</td>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
                   Write(row.Duration);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 46 "C:\Users\carys\source\repos\flairelise\MVC-testing\Views\Home\MovieList.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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