#pragma checksum "D:\Coforge\2.Technical Training(Trainer Mohd. Salman)\Day 50\D50WeeklyExercise\Views\Student\Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "129cdbf31668f64a06b3ceee14cb340afe3650ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Display), @"mvc.1.0.view", @"/Views/Student/Display.cshtml")]
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
#line 1 "D:\Coforge\2.Technical Training(Trainer Mohd. Salman)\Day 50\D50WeeklyExercise\Views\_ViewImports.cshtml"
using D50WeeklyExercise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Coforge\2.Technical Training(Trainer Mohd. Salman)\Day 50\D50WeeklyExercise\Views\_ViewImports.cshtml"
using D50WeeklyExercise.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129cdbf31668f64a06b3ceee14cb340afe3650ea", @"/Views/Student/Display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82bae1e6b52427fe5e1b768214fb9bc836d873e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<D50WeeklyExercise.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Coforge\2.Technical Training(Trainer Mohd. Salman)\Day 50\D50WeeklyExercise\Views\Student\Display.cshtml"
  
    ViewData["Title"] = "Display";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Total Number of Students: ");
#nullable restore
#line 7 "D:\Coforge\2.Technical Training(Trainer Mohd. Salman)\Day 50\D50WeeklyExercise\Views\Student\Display.cshtml"
                         Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n<table class=\"table table-dark\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "D:\Coforge\2.Technical Training(Trainer Mohd. Salman)\Day 50\D50WeeklyExercise\Views\Student\Display.cshtml"
           Write(Html.DisplayNameFor(model => model.SId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\Coforge\2.Technical Training(Trainer Mohd. Salman)\Day 50\D50WeeklyExercise\Views\Student\Display.cshtml"
           Write(Html.DisplayNameFor(model => model.SName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\Coforge\2.Technical Training(Trainer Mohd. Salman)\Day 50\D50WeeklyExercise\Views\Student\Display.cshtml"
           Write(Html.DisplayNameFor(model => model.SDOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\Coforge\2.Technical Training(Trainer Mohd. Salman)\Day 50\D50WeeklyExercise\Views\Student\Display.cshtml"
           Write(Html.DisplayNameFor(model => model.SContact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "D:\Coforge\2.Technical Training(Trainer Mohd. Salman)\Day 50\D50WeeklyExercise\Views\Student\Display.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "D:\Coforge\2.Technical Training(Trainer Mohd. Salman)\Day 50\D50WeeklyExercise\Views\Student\Display.cshtml"
           Write(Html.DisplayFor(modelItem => item.SId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "D:\Coforge\2.Technical Training(Trainer Mohd. Salman)\Day 50\D50WeeklyExercise\Views\Student\Display.cshtml"
           Write(Html.DisplayFor(modelItem => item.SName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "D:\Coforge\2.Technical Training(Trainer Mohd. Salman)\Day 50\D50WeeklyExercise\Views\Student\Display.cshtml"
           Write(Html.DisplayFor(modelItem => item.SDOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "D:\Coforge\2.Technical Training(Trainer Mohd. Salman)\Day 50\D50WeeklyExercise\Views\Student\Display.cshtml"
           Write(Html.DisplayFor(modelItem => item.SContact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 45 "D:\Coforge\2.Technical Training(Trainer Mohd. Salman)\Day 50\D50WeeklyExercise\Views\Student\Display.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<D50WeeklyExercise.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
