#pragma checksum "/Users/reginethimothee/Desktop/Project3_FinalExam/Views/Home/GetFaculty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e092e45439cb97323a2892fd3b0b79ed77ed6c87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetFaculty), @"mvc.1.0.view", @"/Views/Home/GetFaculty.cshtml")]
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
#line 1 "/Users/reginethimothee/Desktop/Project3_FinalExam/Views/_ViewImports.cshtml"
using Project3_FinalExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/reginethimothee/Desktop/Project3_FinalExam/Views/_ViewImports.cshtml"
using Project3_FinalExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e092e45439cb97323a2892fd3b0b79ed77ed6c87", @"/Views/Home/GetFaculty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eb26fd86b6b4d21c48708c3be3589307986ac32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetFaculty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project3_FinalExam.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!--\r\nREMOVED UNECCESSARY ADDTION DISPLAY:INLINE BOCK IN SLICK.JS FOR THE CHILDREN\r\n-->\r\n<div class=\"facData\">\r\n");
#nullable restore
#line 6 "/Users/reginethimothee/Desktop/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
     foreach (var fac in Model.Faculty)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\'flex-container facImageContent\'>\r\n    <img class=\" facImage\"");
            BeginWriteAttribute("src", " src=\"", 286, "\"", 307, 2);
#nullable restore
#line 10 "/Users/reginethimothee/Desktop/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
WriteAttributeValue("", 292, fac.imagePath, 292, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 306, "", 307, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <div class=\'facInfo\'>\r\n        <p>\r\n            Name: ");
#nullable restore
#line 13 "/Users/reginethimothee/Desktop/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
             Write(fac.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n            Title: ");
#nullable restore
#line 14 "/Users/reginethimothee/Desktop/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
              Write(fac.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n            Office: ");
#nullable restore
#line 15 "/Users/reginethimothee/Desktop/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
               Write(fac.office);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n            Phone: ");
#nullable restore
#line 16 "/Users/reginethimothee/Desktop/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
              Write(fac.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n            Email: ");
#nullable restore
#line 17 "/Users/reginethimothee/Desktop/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
              Write(fac.email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n\r\n        </p>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 22 "/Users/reginethimothee/Desktop/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/Users/reginethimothee/Desktop/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
     foreach (var staff in Model.Staff)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\'flex-container staffImageContent\'>\r\n            <img class=\" staffImage\"");
            BeginWriteAttribute("src", " src=\"", 726, "\"", 749, 2);
#nullable restore
#line 26 "/Users/reginethimothee/Desktop/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
WriteAttributeValue("", 732, staff.imagePath, 732, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 748, "", 749, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div class=\'staffInfo\'>\r\n                <p>\r\n                    Name: ");
#nullable restore
#line 29 "/Users/reginethimothee/Desktop/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
                     Write(staff.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                    Title: ");
#nullable restore
#line 30 "/Users/reginethimothee/Desktop/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
                      Write(staff.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                    Office: ");
#nullable restore
#line 31 "/Users/reginethimothee/Desktop/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
                       Write(staff.office);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                    Phone: ");
#nullable restore
#line 32 "/Users/reginethimothee/Desktop/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
                      Write(staff.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                    Email: ");
#nullable restore
#line 33 "/Users/reginethimothee/Desktop/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
                      Write(staff.email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n\r\n                </p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 38 "/Users/reginethimothee/Desktop/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e092e45439cb97323a2892fd3b0b79ed77ed6c878177", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project3_FinalExam.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
