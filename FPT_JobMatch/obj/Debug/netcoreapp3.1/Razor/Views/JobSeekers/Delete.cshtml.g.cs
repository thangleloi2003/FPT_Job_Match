#pragma checksum "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\JobSeekers\Delete.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9d6911bc247b55c7a2102f46d9e24f24e19f8ee62395fb195a9ae47da8ef8660"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobSeekers_Delete), @"mvc.1.0.view", @"/Views/JobSeekers/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9d6911bc247b55c7a2102f46d9e24f24e19f8ee62395fb195a9ae47da8ef8660", @"/Views/JobSeekers/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1c8645b3d78a0d32175978f47bdb1d0ef6d07f8bcfe7f2fd45556e57bd0bc5ff", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_JobSeekers_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FPT_JobMatch.Models.JobSeeker>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-custom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\JobSeekers\Delete.cshtml"
  
    ViewData["Title"] = "Delete JobSeeker";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container mt-5 mb-5"">
    <h1 class=""text-center mb-4 text-danger"">Delete JobSeeker</h1>
    <hr />
    <div class=""row justify-content-center"">
        <div class=""col-md-8"">
            <div class=""bg-light p-4 rounded shadow-sm"">
                <dl class=""row"">

                    <dt class=""col-sm-4 font-weight-bold image"">
                        ");
#nullable restore
#line 16 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\JobSeekers\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 613, "\"", 631, 1);
#nullable restore
#line 19 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\JobSeekers\Delete.cshtml"
WriteAttributeValue("", 619, Model.Image, 619, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Job Seeker Image\" class=\"img-fluid rounded\" />\r\n                    </dd>\r\n                    <dt class=\"col-sm-4 font-weight-bold\">\r\n                        ");
#nullable restore
#line 22 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\JobSeekers\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 25 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\JobSeekers\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n\r\n                    <dt class=\"col-sm-4 font-weight-bold\">\r\n                        ");
#nullable restore
#line 29 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\JobSeekers\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 32 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\JobSeekers\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n\r\n                    <dt class=\"col-sm-4 font-weight-bold\">\r\n                        ");
#nullable restore
#line 36 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\JobSeekers\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-8\">\r\n                        ");
#nullable restore
#line 39 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\JobSeekers\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n                <div class=\"text-center mt-4\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d6911bc247b55c7a2102f46d9e24f24e19f8ee62395fb195a9ae47da8ef86608903", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d6911bc247b55c7a2102f46d9e24f24e19f8ee62395fb195a9ae47da8ef86609209", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 44 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\JobSeekers\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <button type=""submit"" class=""btn btn-danger btn-custom"" onclick=""return confirm('Are you sure you want to delete this job?');"">
                            <i class=""fas fa-trash-alt""></i> Delete
                        </button>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d6911bc247b55c7a2102f46d9e24f24e19f8ee62395fb195a9ae47da8ef866011231", async() => {
                    WriteLiteral("\r\n                            <i class=\"fas fa-arrow-left\"></i> Back to List\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
</div>

<style>

    .form-control {
        transition: border-color 0.3s ease, box-shadow 0.3s ease; /* Smooth transition */
    }

        .form-control:focus {
            border-color: #0056b3; /* Border color on focus */
            box-shadow: 0 0 5px rgba(0, 86, 179, 0.5); /* Shadow on focus */
        }

    /* Button styling */
    .btn-custom {
        padding: 15px; /* Adjusted padding */
        font-size: 14px; /* Font size */
        width: 150px; /* Fixed width for buttons */
        transition: background-color 0.3s ease, transform 0.3s ease;
    }


    .btn-primary.btn-custom:hover {
        background-color: #0056b3; /* Darker blue */
    }

    .btn-secondary.btn-custom:hover {
        background-color: #6c757d; /* Darker grey */
    }

    /* Card styling */
    .bg-light {
        background-color: #ffffff !important; /* Light background for form */
        border: 1px solid #e0e0e");
            WriteLiteral(@"0; /* Subtle border */
    }

    /* Shadow effect */
    .shadow-sm {
        box-shadow: 0 0.125rem 0.25rem rgba(0, 0, 0, 0.075) !important; /* Light shadow for depth */
    }

    /* Rounded corners */
    .rounded {
        border-radius: 0.25rem !important; /* Rounded corners for form */
    }

    /* Image styling */
    .img-fluid {
        width: 60px;
        height: 60px;
    }

    dl.row dt, dl.row dd {
        margin-bottom: 30px; /* Add margin between elements */
    }

    .image {
        transform: translateY(30px);
    }

    .rounded {
        border-radius: 0.25rem;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FPT_JobMatch.Models.JobSeeker> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
