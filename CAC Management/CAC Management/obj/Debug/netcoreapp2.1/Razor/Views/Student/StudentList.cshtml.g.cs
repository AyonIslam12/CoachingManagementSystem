#pragma checksum "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Student\StudentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a303587160140c00bf96418f6dcb92f063d01443"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_StudentList), @"mvc.1.0.view", @"/Views/Student/StudentList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/StudentList.cshtml", typeof(AspNetCore.Views_Student_StudentList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a303587160140c00bf96418f6dcb92f063d01443", @"/Views/Student/StudentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d480e88fc2ea1a4d87350da6cf5607cfa8fe1ad9", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_StudentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CAC_Management.Models.Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PayDue", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding:30px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #309369;align-content: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Student\StudentList.cshtml"
  
    ViewData["Title"] = "Update Student Information";
    Layout = "_LayoutForAdmin";

#line default
#line hidden
            BeginContext(139, 78, true);
            WriteLiteral("\r\n\r\n\r\n<h1 style=\"text-align:center\"> <strong>Student List </strong></h1>\r\n\r\n\r\n");
            EndContext();
            BeginContext(217, 2263, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93decf6c4f0b4a07b78c6ee075e76873", async() => {
                BeginContext(280, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 13 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Student\StudentList.cshtml"
     using (Html.BeginForm("StudentList", "StudentController", FormMethod.Post))
    {

#line default
#line hidden
                BeginContext(371, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(379, 2079, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e3e1c8c58004d799e6554e4f7768604", async() => {
                    BeginContext(421, 492, true);
                    WriteLiteral(@"
            <table class=""table table-bordered"">
                <tr>

                    <th>Student Id</th>
                    <th>Student Name</th>
                    <th>Gender</th>
                    <th>Address</th>
                    <th>Contact</th>
                    <th style=""text-align:center;"">Email</th>
                    <th>Tution Fee</th>
                    <th>Due Amount</th>
                    <th>Payment Status</th>


                </tr>

");
                    EndContext();
#line 32 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Student\StudentList.cshtml"
                 foreach (var ac in Model)
                {

#line default
#line hidden
                    BeginContext(976, 80, true);
                    WriteLiteral("                    <tr>\r\n                        <td style=\"text-align:center\">");
                    EndContext();
                    BeginContext(1057, 12, false);
#line 35 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Student\StudentList.cshtml"
                                                 Write(ac.StudentId);

#line default
#line hidden
                    EndContext();
                    BeginContext(1069, 61, true);
                    WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
                    EndContext();
                    BeginContext(1131, 14, false);
#line 36 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Student\StudentList.cshtml"
                                                 Write(ac.StudentName);

#line default
#line hidden
                    EndContext();
                    BeginContext(1145, 61, true);
                    WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
                    EndContext();
                    BeginContext(1207, 9, false);
#line 37 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Student\StudentList.cshtml"
                                                 Write(ac.Gender);

#line default
#line hidden
                    EndContext();
                    BeginContext(1216, 61, true);
                    WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
                    EndContext();
                    BeginContext(1278, 10, false);
#line 38 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Student\StudentList.cshtml"
                                                 Write(ac.Address);

#line default
#line hidden
                    EndContext();
                    BeginContext(1288, 61, true);
                    WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
                    EndContext();
                    BeginContext(1350, 10, false);
#line 39 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Student\StudentList.cshtml"
                                                 Write(ac.Contact);

#line default
#line hidden
                    EndContext();
                    BeginContext(1360, 61, true);
                    WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
                    EndContext();
                    BeginContext(1422, 8, false);
#line 40 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Student\StudentList.cshtml"
                                                 Write(ac.Email);

#line default
#line hidden
                    EndContext();
                    BeginContext(1430, 61, true);
                    WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
                    EndContext();
                    BeginContext(1492, 13, false);
#line 41 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Student\StudentList.cshtml"
                                                 Write(ac.TuitionFee);

#line default
#line hidden
                    EndContext();
                    BeginContext(1505, 61, true);
                    WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
                    EndContext();
                    BeginContext(1567, 12, false);
#line 42 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Student\StudentList.cshtml"
                                                 Write(ac.DueAmount);

#line default
#line hidden
                    EndContext();
                    BeginContext(1579, 7, true);
                    WriteLiteral("</td>\r\n");
                    EndContext();
#line 43 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Student\StudentList.cshtml"
                         if (ac.PaymentStatus == 0)
                        {

#line default
#line hidden
                    BeginContext(1666, 69, true);
                    WriteLiteral("                            <td style=\"text-align:center\">Paid</td>\r\n");
                    EndContext();
#line 46 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Student\StudentList.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                    BeginContext(1819, 69, true);
                    WriteLiteral("                            <td style=\"text-align:center \">Due</td>\r\n");
                    EndContext();
#line 50 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Student\StudentList.cshtml"
                        }

#line default
#line hidden
                    BeginContext(1915, 86, true);
                    WriteLiteral("\r\n                        <td style=\"text-align:center\">\r\n                            ");
                    EndContext();
                    BeginContext(2001, 95, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8a74d0e75804b99b7c9abd1dca128f1", async() => {
                        BeginContext(2082, 10, true);
                        WriteLiteral("Transction");
                        EndContext();
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
#line 53 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Student\StudentList.cshtml"
                                                          WriteLiteral(ac.StudentId);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2096, 30, true);
                    WriteLiteral("\r\n                            ");
                    EndContext();
                    BeginContext(2126, 86, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa6d26620f2c437a9d89984261762a50", async() => {
                        BeginContext(2202, 6, true);
                        WriteLiteral("PayDue");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#line 54 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Student\StudentList.cshtml"
                                                     WriteLiteral(ac.StudentId);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2212, 63, true);
                    WriteLiteral("\r\n\r\n                        </td>\r\n                        <td>");
                    EndContext();
                    BeginContext(2275, 93, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e4e7920116c43da8e671fae7d4e3bc6", async() => {
                        BeginContext(2358, 6, true);
                        WriteLiteral("Delete");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#line 57 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Student\StudentList.cshtml"
                                                            WriteLiteral(ac.StudentId);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2368, 34, true);
                    WriteLiteral("</td>\r\n                    </tr>\r\n");
                    EndContext();
#line 59 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Student\StudentList.cshtml"
                }

#line default
#line hidden
                    BeginContext(2421, 30, true);
                    WriteLiteral("            </table>\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2458, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 62 "C:\Users\User\Desktop\CAC Management\CAC Management\Views\Student\StudentList.cshtml"
    }

#line default
#line hidden
                BeginContext(2467, 6, true);
                WriteLiteral("\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CAC_Management.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
