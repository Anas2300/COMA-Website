#pragma checksum "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccae18ece50524cc5aa8a10006ed6c2b0a6642d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Members_Details), @"mvc.1.0.view", @"/Views/Members/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Members/Details.cshtml", typeof(AspNetCore.Views_Members_Details))]
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
#line 1 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\_ViewImports.cshtml"
using MusicianApp;

#line default
#line hidden
#line 2 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\_ViewImports.cshtml"
using MusicianApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccae18ece50524cc5aa8a10006ed6c2b0a6642d7", @"/Views/Members/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0abae3f6a11ad16fc8d1b43a0463eaad33861835", @"/Views/_ViewImports.cshtml")]
    public class Views_Members_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MusicianApp.Models.Person>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MemberInstruments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 102, true);
            WriteLiteral("\r\n\r\n<div>\r\n    <h4>Person</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(182, 45, false);
#line 13 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(227, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(271, 41, false);
#line 16 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(312, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(356, 44, false);
#line 19 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(400, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(444, 40, false);
#line 22 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(484, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(528, 44, false);
#line 25 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(572, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(616, 40, false);
#line 28 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(656, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(700, 51, false);
#line 31 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AssociationDate));

#line default
#line hidden
            EndContext();
            BeginContext(751, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(795, 47, false);
#line 34 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
       Write(Html.DisplayFor(model => model.AssociationDate));

#line default
#line hidden
            EndContext();
            BeginContext(842, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(886, 41, false);
#line 37 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(927, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(971, 37, false);
#line 40 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1008, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1052, 46, false);
#line 43 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BalanceDue));

#line default
#line hidden
            EndContext();
            BeginContext(1098, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1142, 42, false);
#line 46 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
       Write(Html.DisplayFor(model => model.BalanceDue));

#line default
#line hidden
            EndContext();
            BeginContext(1184, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1228, 43, false);
#line 49 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Balance));

#line default
#line hidden
            EndContext();
            BeginContext(1271, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1315, 39, false);
#line 52 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
       Write(Html.DisplayFor(model => model.Balance));

#line default
#line hidden
            EndContext();
            BeginContext(1354, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1398, 43, false);
#line 55 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Request));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1485, 39, false);
#line 58 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
       Write(Html.DisplayFor(model => model.Request));

#line default
#line hidden
            EndContext();
            BeginContext(1524, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1568, 44, false);
#line 61 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StatusId));

#line default
#line hidden
            EndContext();
            BeginContext(1612, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1656, 40, false);
#line 64 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
       Write(Html.DisplayFor(model => model.StatusId));

#line default
#line hidden
            EndContext();
            BeginContext(1696, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(1743, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4608fd845de84fccbbb581f8fa769df3", async() => {
                BeginContext(1795, 4, true);
                WriteLiteral("Edit");
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
#line 68 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
                               WriteLiteral(Model.MemberId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1803, 84, true);
            WriteLiteral("\r\n    </div>\r\n    <h4>Instruments</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n");
            EndContext();
#line 73 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
         foreach (var item in ViewBag.instruments)
        {

#line default
#line hidden
            BeginContext(1950, 69, true);
            WriteLiteral("            <dt> Instrument:</dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2020, 19, false);
#line 77 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
           Write(item.instrumentName);

#line default
#line hidden
            EndContext();
            BeginContext(2039, 21, true);
            WriteLiteral("\r\n            </dd>\r\n");
            EndContext();
#line 79 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(2071, 15, true);
            WriteLiteral("    </dl>\r\n    ");
            EndContext();
            BeginContext(2086, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "693e7feebf814c80bfa20a71dc6d77cc", async() => {
                BeginContext(2175, 3, true);
                WriteLiteral("Add");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 81 "C:\Users\romagnaE\Documents\Computer Program\Fourth Semester\Capstone Project\Project\v2.2 Unit Test\OntarioMusicians\MusicianApp\Views\Members\Details.cshtml"
                                                                WriteLiteral(Model.MemberId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2182, 15, true);
            WriteLiteral("\r\n \r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MusicianApp.Models.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591