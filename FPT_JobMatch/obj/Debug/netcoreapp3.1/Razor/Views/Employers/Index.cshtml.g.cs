#pragma checksum "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Employers\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "17f3e0664c31fe6659a22b2d876562ceeff7f6302168b2dea8a4e003c0e244aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employers_Index), @"mvc.1.0.view", @"/Views/Employers/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"17f3e0664c31fe6659a22b2d876562ceeff7f6302168b2dea8a4e003c0e244aa", @"/Views/Employers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1c8645b3d78a0d32175978f47bdb1d0ef6d07f8bcfe7f2fd45556e57bd0bc5ff", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FPT_JobMatch.Models.Employer>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-custom btn-create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-custom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-custom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-custom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Employers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <style>
        .main-content {
            padding: 20px;
        }

        .card {
        margin-bottom: 20px;
        transition: transform 0.2s; /* Hiệu ứng chuyển động */
        }

        .card-title {
            font-size: 20px;
            font-weight: bold;
        }

    .card:hover {
        box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2); /* Thêm bóng */
    }

    .btn-custom {
        padding: 12px; /* Adjusted padding */
        font-size: 14px; /* Font size */
        width: 99px; /* Fixed width for buttons */
        transition: background-color 0.3s ease, transform 0.3s ease;
        margin-bottom: 10px;
    }

    .btn-create {
        width: fit-content;
    }

    .btn-primary.btn-custom:hover {
        background-color: #0056b3;
    }

        .statistics-number {
            font-size: 36px;
            font-weight: bold;
            color: #0d6efd;
        }

        .recent-applications table {
            width: 100%;
        }

       ");
            WriteLiteral(@"     .recent-applications table th, .recent-applications table td {
                padding: 18px;
                text-align: center;
            }

            .recent-applications table th {
                background-color: #343a40;
                color: white;
            }

            .recent-applications table td {
                background-color: #f8f9fa;
            }

    </style>

");
#nullable restore
#line 68 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Employers\Index.cshtml"
 if (User.Identity.IsAuthenticated && User.IsInRole("Employer"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!-- Sidebar -->
    <div class=""d-flex"">
        <!-- Main Content -->
        <div class=""main-content flex-grow-1"">

            <!-- Dashboard Statistics -->
            <div class=""container mt-4"">
                <div class=""row"">
                    <div class=""col-lg-4 col-md-6"">
                        <div class=""card text-center"">
                            <div class=""card-body"">
                                <h5 class=""card-title"">Active Jobs</h5>
                                <p class=""statistics-number"">5</p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6"">
                        <div class=""card text-center"">
                            <div class=""card-body"">
                                <h5 class=""card-title"">Pending Applications</h5>
                                <p class=""statistics-number"">12</p>
                            </div>
                        </d");
            WriteLiteral(@"iv>
                    </div>
                    <div class=""col-lg-4 col-md-6"">
                        <div class=""card text-center"">
                            <div class=""card-body"">
                                <h5 class=""card-title"">Total Hires</h5>
                                <p class=""statistics-number"">3</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Recent Applications -->
            <div class=""container mt-4 recent-applications"">
                <h5>Recent Applications</h5>
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th>Applicant Name</th>
                            <th>Job Title</th>
                            <th>Date Applied</th>
                            <th>Status</th>
                            <th>Action</th>
                        </tr>
           ");
            WriteLiteral(@"         </thead>
                    <tbody>
                        <tr>
                            <td>John Doe</td>
                            <td>Web Developer</td>
                            <td>20/10/2024</td>
                            <td>Pending</td>
                            <td><button class=""btn btn-primary"">View</button></td>
                        </tr>
                        <tr>
                            <td>Jane Smith</td>
                            <td>Graphic Designer</td>
                            <td>19/10/2024</td>
                            <td>Interview Scheduled</td>
                            <td><button class=""btn btn-primary"">View</button></td>
                        </tr>
                        <tr>
                            <td>David Brown</td>
                            <td>Project Manager</td>
                            <td>18/10/2024</td>
                            <td>Rejected</td>
                            <td><button class=""btn ");
            WriteLiteral(@"btn-primary"">View</button></td>
                        </tr>
                        <tr>
                            <td>David Brown</td>
                            <td>Project Manager</td>
                            <td>18/10/2024</td>
                            <td>Accept</td>
                            <td><button class=""btn btn-primary"">View</button></td>
                        </tr>

                        <tr>
                            <td>David Brown</td>
                            <td>Front-End JS</td>
                            <td>18/10/2024</td>
                            <td>Rejected</td>
                            <td><button class=""btn btn-primary"">View</button></td>
                        </tr>

                        <tr>
                            <td>David Brown</td>
                            <td>Project Manager</td>
                            <td>19/10/2024</td>
                            <td>Accept</td>
                            <td><button cla");
            WriteLiteral(@"ss=""btn btn-primary"">View</button></td>
                        </tr>

                        <tr>
                            <td>David Brown</td>
                            <td>Back-End Java</td>
                            <td>20/10/2024</td>
                            <td>Accept</td>
                            <td><button class=""btn btn-primary"">View</button></td>
                        </tr>

                    </tbody>
                </table>
            </div>
        </div>
    </div>
");
#nullable restore
#line 177 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Employers\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 179 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Employers\Index.cshtml"
 if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"text-center my-4 mb-5 mt-5\">List of Employers</h1>\r\n    <p class=\"text-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17f3e0664c31fe6659a22b2d876562ceeff7f6302168b2dea8a4e003c0e244aa13377", async() => {
                WriteLiteral("Add New Employer");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n");
            WriteLiteral("    <div class=\"row\">\r\n");
#nullable restore
#line 187 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Employers\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4 mb-4\">\r\n                <div class=\"card shadow-sm h-100\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title text-truncate\"");
            BeginWriteAttribute("title", " title=\"", 6764, "\"", 6813, 1);
#nullable restore
#line 192 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Employers\Index.cshtml"
WriteAttributeValue("", 6772, Html.DisplayNameFor(model => model.Name), 6772, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 192 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Employers\Index.cshtml"
                                                                                                          Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">Company Name: ");
#nullable restore
#line 193 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Employers\Index.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">Age: ");
#nullable restore
#line 194 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Employers\Index.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"card-footer text-center\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17f3e0664c31fe6659a22b2d876562ceeff7f6302168b2dea8a4e003c0e244aa16817", async() => {
                WriteLiteral("\r\n                            <i class=\"fas fa-info-circle\"></i> Details\r\n                        ");
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
#line 197 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Employers\Index.cshtml"
                                                  WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17f3e0664c31fe6659a22b2d876562ceeff7f6302168b2dea8a4e003c0e244aa19219", async() => {
                WriteLiteral("\r\n                            <i class=\"fas fa-edit\"></i> Edit\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 200 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Employers\Index.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17f3e0664c31fe6659a22b2d876562ceeff7f6302168b2dea8a4e003c0e244aa21608", async() => {
                WriteLiteral("\r\n                            <i class=\"fas fa-trash-alt\"></i> Delete\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 203 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Employers\Index.cshtml"
                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 209 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Employers\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 211 "C:\Users\ADMIN\Desktop\source\repos\FPT_JobMatch\FPT_JobMatch\Views\Employers\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FPT_JobMatch.Models.Employer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
