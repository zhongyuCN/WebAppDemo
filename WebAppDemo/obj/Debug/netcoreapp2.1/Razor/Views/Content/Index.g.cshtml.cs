#pragma checksum "D:\Project\WebAppDemo\WebAppDemo\Views\Content\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d857dae99a0e3303dd49db17ee58cd4b22440ed2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Content_Index), @"mvc.1.0.view", @"/Views/Content/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Content/Index.cshtml", typeof(AspNetCore.Views_Content_Index))]
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
#line 1 "D:\Project\WebAppDemo\WebAppDemo\Views\_ViewImports.cshtml"
using WebAppDemo;

#line default
#line hidden
#line 2 "D:\Project\WebAppDemo\WebAppDemo\Views\_ViewImports.cshtml"
using WebAppDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d857dae99a0e3303dd49db17ee58cd4b22440ed2", @"/Views/Content/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ce553616866638da7346a25c051e63019b5132b", @"/Views/_ViewImports.cshtml")]
    public class Views_Content_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppDemo.Models.ContentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Project\WebAppDemo\WebAppDemo\Views\Content\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(86, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(115, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f0b04e8ef314e8d98fa274b23b00e2c", async() => {
                BeginContext(138, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(152, 312, true);
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <td> <input type=""checkbox"" class=""done-checkbox""></td>
            <td>序号</td>
            <td>标题</td>
            <td>内容</td>
            <td>添加时间</td>
            <td>操作</td>
            

        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 26 "D:\Project\WebAppDemo\WebAppDemo\Views\Content\Index.cshtml"
 foreach (var item in Model.Contents) {

#line default
#line hidden
            BeginContext(505, 130, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                <input type=\"checkbox\" class=\"done-checkbox\">\r\n            </td>\r\n            <td>");
            EndContext();
            BeginContext(636, 7, false);
#line 31 "D:\Project\WebAppDemo\WebAppDemo\Views\Content\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(643, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(667, 10, false);
#line 32 "D:\Project\WebAppDemo\WebAppDemo\Views\Content\Index.cshtml"
           Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(677, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(701, 12, false);
#line 33 "D:\Project\WebAppDemo\WebAppDemo\Views\Content\Index.cshtml"
           Write(item.content);

#line default
#line hidden
            EndContext();
            BeginContext(713, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(737, 13, false);
#line 34 "D:\Project\WebAppDemo\WebAppDemo\Views\Content\Index.cshtml"
           Write(item.add_time);

#line default
#line hidden
            EndContext();
            BeginContext(750, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(792, 65, false);
#line 36 "D:\Project\WebAppDemo\WebAppDemo\Views\Content\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(857, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(878, 71, false);
#line 37 "D:\Project\WebAppDemo\WebAppDemo\Views\Content\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(949, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(970, 69, false);
#line 38 "D:\Project\WebAppDemo\WebAppDemo\Views\Content\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 41 "D:\Project\WebAppDemo\WebAppDemo\Views\Content\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1078, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppDemo.Models.ContentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591