#pragma checksum "C:\Users\aliasagar\Desktop\Asp.Net Assignments\Message_Board\Message_Board\Pages\MessageBoard\Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57d75bc43a121cbd51b7f01107ca280f31c7a606"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Message_Board.Pages.MessageBoard.Pages_MessageBoard_Comments), @"mvc.1.0.razor-page", @"/Pages/MessageBoard/Comments.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/MessageBoard/Comments.cshtml", typeof(Message_Board.Pages.MessageBoard.Pages_MessageBoard_Comments), @"{messageId:int}")]
namespace Message_Board.Pages.MessageBoard
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\aliasagar\Desktop\Asp.Net Assignments\Message_Board\Message_Board\Pages\_ViewImports.cshtml"
using Message_Board;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{messageId:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57d75bc43a121cbd51b7f01107ca280f31c7a606", @"/Pages/MessageBoard/Comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c99eafa3a46671764635a4ed91ec1ea7bd7cd472", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MessageBoard_Comments : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", ".\\Timeline", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\aliasagar\Desktop\Asp.Net Assignments\Message_Board\Message_Board\Pages\MessageBoard\Comments.cshtml"
  
    ViewData["Title"] = "Comments";

#line default
#line hidden
            BeginContext(124, 58, true);
            WriteLiteral("\r\n<h1>Comments</h1>\r\n<div class=\"panel panel-default\">\r\n\r\n");
            EndContext();
#line 10 "C:\Users\aliasagar\Desktop\Asp.Net Assignments\Message_Board\Message_Board\Pages\MessageBoard\Comments.cshtml"
     foreach (var comment in Model.Comments)
    {

#line default
#line hidden
            BeginContext(235, 52, true);
            WriteLiteral("        <div class=\"panel-body\">\r\n            <span>");
            EndContext();
            BeginContext(288, 15, false);
#line 13 "C:\Users\aliasagar\Desktop\Asp.Net Assignments\Message_Board\Message_Board\Pages\MessageBoard\Comments.cshtml"
             Write(comment.Content);

#line default
#line hidden
            EndContext();
            BeginContext(303, 25, true);
            WriteLiteral("</span>\r\n        </div>\r\n");
            EndContext();
#line 15 "C:\Users\aliasagar\Desktop\Asp.Net Assignments\Message_Board\Message_Board\Pages\MessageBoard\Comments.cshtml"
    }

#line default
#line hidden
            BeginContext(335, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(339, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57d75bc43a121cbd51b7f01107ca280f31c7a6065286", async() => {
                BeginContext(388, 16, true);
                WriteLiteral("Back to Timeline");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(408, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Message_Board.Pages.MessageBoard.CommentsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Message_Board.Pages.MessageBoard.CommentsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Message_Board.Pages.MessageBoard.CommentsModel>)PageContext?.ViewData;
        public Message_Board.Pages.MessageBoard.CommentsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
