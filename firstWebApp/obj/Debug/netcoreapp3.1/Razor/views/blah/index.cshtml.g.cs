#pragma checksum "/Users/madisonpitts/Projects/firstWebApp/firstWebApp/views/blah/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39ac4e904ac6f39e29f4df486d97ee52ac89f1fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(firstWebApp.views.blah.views_blah_index), @"mvc.1.0.view", @"/views/blah/index.cshtml")]
namespace firstWebApp.views.blah
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
#line 3 "/Users/madisonpitts/Projects/firstWebApp/firstWebApp/views/_viewimports.cshtml"
using firstWebApp.models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39ac4e904ac6f39e29f4df486d97ee52ac89f1fe", @"/views/blah/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6a805738596d2676d25dc86a92f7482ab7c3eb0", @"/views/_viewimports.cshtml")]
    public class views_blah_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/Users/madisonpitts/Projects/firstWebApp/firstWebApp/views/blah/index.cshtml"
  
    ViewData["Title"] = "Madison's Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39ac4e904ac6f39e29f4df486d97ee52ac89f1fe3074", async() => {
                WriteLiteral("\n   \n\n");
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
            WriteLiteral(@"

    <h2>Welcome to my page!</h2>
    <h1>I'm Madison Griffith</h1>
    <br />
    <img src=""images/moab.jpg"" /><img src=""images/costarica.jpg"" /><img src=""images/utahh.JPG"" />
    <h2>and I love to travel! Especially with my husband :)</h2>
    <br />
    <br />
    <br />
    <h3>
        I hope to be able to keep up in the class and actually understand what we are doing. Last semester in IS 403,
        I got behind and most of the time I didn't understand what was going on in the class. I want to be better about my study habits and practice continually so that I have somewhat of a clue on what we are currently learning in class.
    </h3>
    <br />
    <br />

    <h3>These are the top 3 jobs I am most interested in pursuing when I graduate:</h3>
    <ul>
        <li>1. Stay-at-Home Mom</li>
        <li>2. Database Engineer</li>
        <li>3. Data Analyst</li>
    </ul>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

   

");
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
