#pragma checksum "C:\Users\Justin\source\repos\GC_Lab21_MovieRegistration\GC_Lab21_MovieRegistration\Views\MovieRegistration\MovieSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f3620b5d5d191cdd722b1d16ab91482bfe9f360"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MovieRegistration_MovieSummary), @"mvc.1.0.view", @"/Views/MovieRegistration/MovieSummary.cshtml")]
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
#line 1 "C:\Users\Justin\source\repos\GC_Lab21_MovieRegistration\GC_Lab21_MovieRegistration\Views\_ViewImports.cshtml"
using GC_Lab21_MovieRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Justin\source\repos\GC_Lab21_MovieRegistration\GC_Lab21_MovieRegistration\Views\_ViewImports.cshtml"
using GC_Lab21_MovieRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f3620b5d5d191cdd722b1d16ab91482bfe9f360", @"/Views/MovieRegistration/MovieSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a0a53b83a48ce86c25c7638e4dcec883d752cd9", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieRegistration_MovieSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Justin\source\repos\GC_Lab21_MovieRegistration\GC_Lab21_MovieRegistration\Views\MovieRegistration\MovieSummary.cshtml"
  
    ViewData["Title"] = "Movie Summary";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "C:\Users\Justin\source\repos\GC_Lab21_MovieRegistration\GC_Lab21_MovieRegistration\Views\MovieRegistration\MovieSummary.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has been registered.</h2>\r\n\r\n<p>\r\n    <table>\r\n        <th>ID</th>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\Justin\source\repos\GC_Lab21_MovieRegistration\GC_Lab21_MovieRegistration\Views\MovieRegistration\MovieSummary.cshtml"
           Write(Model.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n</p>\r\n\r\n<p>\r\n    <table>\r\n        <th>Title</th>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Justin\source\repos\GC_Lab21_MovieRegistration\GC_Lab21_MovieRegistration\Views\MovieRegistration\MovieSummary.cshtml"
           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n</p>\r\n\r\n<p>\r\n    <table>\r\n        <th>Genre</th>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\Justin\source\repos\GC_Lab21_MovieRegistration\GC_Lab21_MovieRegistration\Views\MovieRegistration\MovieSummary.cshtml"
           Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n</p>\r\n\r\n<p>\r\n    <table>\r\n        <th>Year</th>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\Justin\source\repos\GC_Lab21_MovieRegistration\GC_Lab21_MovieRegistration\Views\MovieRegistration\MovieSummary.cshtml"
           Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n</p>\r\n\r\n<p>\r\n    <table>\r\n        <th>Actors</th>\r\n");
#nullable restore
#line 48 "C:\Users\Justin\source\repos\GC_Lab21_MovieRegistration\GC_Lab21_MovieRegistration\Views\MovieRegistration\MovieSummary.cshtml"
         foreach (string actor in Model.Actors)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 51 "C:\Users\Justin\source\repos\GC_Lab21_MovieRegistration\GC_Lab21_MovieRegistration\Views\MovieRegistration\MovieSummary.cshtml"
               Write(actor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Justin\source\repos\GC_Lab21_MovieRegistration\GC_Lab21_MovieRegistration\Views\MovieRegistration\MovieSummary.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</p>\r\n\r\n<p>\r\n    <table>\r\n        <th>Directors</th>\r\n");
#nullable restore
#line 60 "C:\Users\Justin\source\repos\GC_Lab21_MovieRegistration\GC_Lab21_MovieRegistration\Views\MovieRegistration\MovieSummary.cshtml"
         foreach (string director in Model.Directors)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 63 "C:\Users\Justin\source\repos\GC_Lab21_MovieRegistration\GC_Lab21_MovieRegistration\Views\MovieRegistration\MovieSummary.cshtml"
               Write(director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 65 "C:\Users\Justin\source\repos\GC_Lab21_MovieRegistration\GC_Lab21_MovieRegistration\Views\MovieRegistration\MovieSummary.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</p>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
