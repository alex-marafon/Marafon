#pragma checksum "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "050fdffa19a7b3f6c125f3a01ac18f714087000d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Locatario_Details), @"mvc.1.0.view", @"/Views/Locatario/Details.cshtml")]
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
#line 1 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\_ViewImports.cshtml"
using Aluguel.Mvc;

#line default
#line hidden
#line 2 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\_ViewImports.cshtml"
using Aluguel.Mvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"050fdffa19a7b3f6c125f3a01ac18f714087000d", @"/Views/Locatario/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa012f05fdf587cc92e18d1a20aa6cea385586c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Locatario_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Aluguel.Dominio.Models.Locatario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Locatario</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 14 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 17 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 20 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 23 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 26 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SobreNome));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 29 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayFor(model => model.SobreNome));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 32 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cpf));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 35 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cpf));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 38 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rg));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 41 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rg));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 44 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrgaoEmissor));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 47 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrgaoEmissor));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 50 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Profissao));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 53 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Profissao));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 56 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EstadoCivil));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 59 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayFor(model => model.EstadoCivil));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 62 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 65 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 68 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tel));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 71 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tel));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 74 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TelTestemunha));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 77 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
       Write(Html.DisplayFor(model => model.TelTestemunha));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "050fdffa19a7b3f6c125f3a01ac18f714087000d10646", async() => {
                WriteLiteral("Edit");
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
#line 82 "C:\Users\alex.marafon\Source\Repos\Marafon\Aluguel\src\Aluguel.Mvc\Views\Locatario\Details.cshtml"
                           WriteLiteral(Model.LocatarioId);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "050fdffa19a7b3f6c125f3a01ac18f714087000d12778", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Aluguel.Dominio.Models.Locatario> Html { get; private set; }
    }
}
#pragma warning restore 1591
