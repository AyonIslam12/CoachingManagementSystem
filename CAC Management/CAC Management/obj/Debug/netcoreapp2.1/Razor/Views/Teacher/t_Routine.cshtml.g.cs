#pragma checksum "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Teacher\t_Routine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45cac07ff0d3996c4a7dc7c30c1c4c547027c8b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_t_Routine), @"mvc.1.0.view", @"/Views/Teacher/t_Routine.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/t_Routine.cshtml", typeof(AspNetCore.Views_Teacher_t_Routine))]
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
#line 1 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\_ViewImports.cshtml"
using CAC_Management;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\_ViewImports.cshtml"
using CAC_Management.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45cac07ff0d3996c4a7dc7c30c1c4c547027c8b3", @"/Views/Teacher/t_Routine.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d480e88fc2ea1a4d87350da6cf5607cfa8fe1ad9", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_t_Routine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CAC_Management.Models.st_routine>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "t_Routine", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #309369;align-content: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Teacher\t_Routine.cshtml"
  
    ViewData["Title"] = "RoutineIndex";
    Layout = "_LayoutForTeacher";


#line default
#line hidden
            BeginContext(139, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(141, 2009, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07d52b478d5845bebb233c712ccd6825", async() => {
                BeginContext(204, 161, true);
                WriteLiteral("\r\n    <div style=\"margin:15px;\">\r\n        <center> <h2>Teacher Routine List</h2></center> \r\n        <br />\r\n        <div>\r\n            <center>\r\n                ");
                EndContext();
                BeginContext(365, 515, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32632c5f5ebd42ab93338d1a8969e981", async() => {
                    BeginContext(407, 466, true);
                    WriteLiteral(@"
                    <div class=""form-group"">
                        <div class=""col-sm-2"">
                            <input placeholder=""Enter Name"" type=""text"" name=""search"" />
                        </div>
                        <div class=""col-sm-1"">
                            <input placeholder=""Enter Name"" value=""Search"" type=""submit"" class=""btn btn-primary btn-sm"" />
                        </div>
                    </div>
                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(880, 199, true);
                WriteLiteral("\r\n            </center>\r\n            \r\n        </div>\r\n        \r\n        <br />    <br />\r\n\r\n        <table class=\"table table-bordered\">\r\n            <tr>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1080, 48, false);
#line 33 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Teacher\t_Routine.cshtml"
               Write(Html.DisplayNameFor(m => m.FirstOrDefault().day));

#line default
#line hidden
                EndContext();
                BeginContext(1128, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1196, 48, false);
#line 36 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Teacher\t_Routine.cshtml"
               Write(Html.DisplayNameFor(m => m.FirstOrDefault().sub));

#line default
#line hidden
                EndContext();
                BeginContext(1244, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1312, 49, false);
#line 39 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Teacher\t_Routine.cshtml"
               Write(Html.DisplayNameFor(m => m.FirstOrDefault().time));

#line default
#line hidden
                EndContext();
                BeginContext(1361, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1429, 55, false);
#line 42 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Teacher\t_Routine.cshtml"
               Write(Html.DisplayNameFor(m => m.FirstOrDefault().instructor));

#line default
#line hidden
                EndContext();
                BeginContext(1484, 60, true);
                WriteLiteral("\r\n                </th>\r\n              \r\n            </tr>\r\n");
                EndContext();
#line 46 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Teacher\t_Routine.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(1601, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1674, 30, false);
#line 50 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Teacher\t_Routine.cshtml"
                   Write(Html.DisplayFor(p => item.day));

#line default
#line hidden
                EndContext();
                BeginContext(1704, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1784, 30, false);
#line 53 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Teacher\t_Routine.cshtml"
                   Write(Html.DisplayFor(p => item.sub));

#line default
#line hidden
                EndContext();
                BeginContext(1814, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1894, 31, false);
#line 56 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Teacher\t_Routine.cshtml"
                   Write(Html.DisplayFor(p => item.time));

#line default
#line hidden
                EndContext();
                BeginContext(1925, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2005, 37, false);
#line 59 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Teacher\t_Routine.cshtml"
                   Write(Html.DisplayFor(p => item.instructor));

#line default
#line hidden
                EndContext();
                BeginContext(2042, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 62 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Teacher\t_Routine.cshtml"
            }

#line default
#line hidden
                BeginContext(2109, 34, true);
                WriteLiteral("\r\n        </table>\r\n\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CAC_Management.Models.st_routine>> Html { get; private set; }
    }
}
#pragma warning restore 1591
