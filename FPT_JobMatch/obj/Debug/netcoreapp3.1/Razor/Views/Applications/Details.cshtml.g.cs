#pragma checksum "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Applications\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "149d88c6cd8ee3faa9dbbc8f91782867660aa65edc508ea68de6fa726eb97014"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Applications_Details), @"mvc.1.0.view", @"/Views/Applications/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\_ViewImports.cshtml"
using FPT_JobMatch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\_ViewImports.cshtml"
using FPT_JobMatch.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"149d88c6cd8ee3faa9dbbc8f91782867660aa65edc508ea68de6fa726eb97014", @"/Views/Applications/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1c8645b3d78a0d32175978f47bdb1d0ef6d07f8bcfe7f2fd45556e57bd0bc5ff", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Applications_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FPT_JobMatch.Models.Application>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm me btn-custom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-sm btn-custom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Applications\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container mt-5"">

    <div class=""card shadow-lg border-light"">
        <div class=""card-body"">
            <h4 class=""card-title"">Application Information</h4>
            <hr />
            <dl class=""row"">
                <dt class=""col-sm-3 font-weight-bold text-secondary"">
                    ");
#nullable restore
#line 15 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Applications\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.ApplicationLatter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 547, "\"", 603, 1);
#nullable restore
#line 18 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Applications\Details.cshtml"
WriteAttributeValue("", 553, Html.DisplayFor(model => model.ApplicationLatter), 553, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"500px\" />\r\n                </dd>\r\n\r\n                <dt class=\"col-sm-3 font-weight-bold text-secondary\">\r\n                    ");
#nullable restore
#line 22 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Applications\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.ApplicationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 25 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Applications\Details.cshtml"
               Write(Html.DisplayFor(model => model.ApplicationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n");
#nullable restore
#line 27 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Applications\Details.cshtml"
                  if (User.Identity.IsAuthenticated && User.IsInRole("Employer"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dt class=\"col-sm-3 font-weight-bold text-secondary\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Applications\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.JobSeeker));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n");
#nullable restore
#line 32 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Applications\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Applications\Details.cshtml"
                  if (User.Identity.IsAuthenticated && User.IsInRole("Employer"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Applications\Details.cshtml"
               Write(Html.DisplayFor(model => model.JobSeeker.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n");
#nullable restore
#line 38 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Applications\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <dt class=\"col-sm-3 font-weight-bold text-secondary\">\r\n                    ");
#nullable restore
#line 41 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Applications\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Job));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 44 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Applications\Details.cshtml"
               Write(Html.DisplayFor(model => model.Job.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n            <div class=\"mt-5 d-flex justify-content-center\">\r\n");
#nullable restore
#line 48 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Applications\Details.cshtml"
                 if (User.Identity.IsAuthenticated && User.IsInRole("Employer"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "149d88c6cd8ee3faa9dbbc8f91782867660aa65edc508ea68de6fa726eb970149894", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-edit\"></i> Edit\r\n                    ");
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
#nullable restore
#line 50 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Applications\Details.cshtml"
                                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Applications\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "149d88c6cd8ee3faa9dbbc8f91782867660aa65edc508ea68de6fa726eb9701412494", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-arrow-left\"></i> Back to List\r\n                ");
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
#nullable restore
#line 54 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Applications\Details.cshtml"
                                        WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<style>
    /* Custom styling to improve the look */
    .card {
        border-radius: 15px;
        background: linear-gradient(135deg, #ffffff, #e9ecef);
        transition: transform 0.2s, box-shadow 0.2s;
        border: none; /* Remove default border */
    }

        .card:hover {
            transform: translateY(-5px);
            box-shadow: 0 15px 30px rgba(0, 0, 0, 0.3); /* Increased shadow for more depth */
        }

    .card-title {
        font-size: 1.75rem; /* Increased size for title */
        font-weight: bold;
        margin-bottom: 1.5rem; /* More space below title */
        color: #343a40; /* Darker color for title */
    }

    dt {
        font-size: 1.1rem; /* Slightly larger text for labels */
        color: #495057; /* Gray color for dt */
    }

    dd {
        font-size: 1.1rem; /* Slightly larger text for details */
        margin-bottom: 1rem; /* Spacing below each detail */
        pad");
            WriteLiteral(@"ding-left: 15px; /* Indentation for dd */
        background-color: #f8f9fa; /* Light background for details */
        border-radius: 5px; /* Rounded corners */
    }

    .btn-custom {
        padding: 15px; /* Adjusted padding */
        font-size: 14px; /* Font size */
        width: 150px; /* Fixed width for buttons */
        transition: background-color 0.3s ease, transform 0.3s ease;
        margin-right: 10px; /* Spacing between buttons */
    }

    .btn-primary.btn-custom:hover {
        background-color: #0056b3;
    }

    .btn-secondary.btn-custom:hover {
        background-color: #6c757d;
    }
</style>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FPT_JobMatch.Models.Application> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
