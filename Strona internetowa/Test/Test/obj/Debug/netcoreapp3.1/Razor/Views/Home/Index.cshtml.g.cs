#pragma checksum "C:\Users\milos\OneDrive - Politechnika Wroclawska\Dokumenty\GitHub\outpost\outpost\Strona internetowa\Test\Test\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41bdde25db049450583f8ce008b226039ba9698e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 2 "C:\Users\milos\OneDrive - Politechnika Wroclawska\Dokumenty\GitHub\outpost\outpost\Strona internetowa\Test\Test\Views\Home\Index.cshtml"
using Test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41bdde25db049450583f8ce008b226039ba9698e", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\milos\OneDrive - Politechnika Wroclawska\Dokumenty\GitHub\outpost\outpost\Strona internetowa\Test\Test\Views\Home\Index.cshtml"
 using (Html.BeginForm("Index", "Home", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\milos\OneDrive - Politechnika Wroclawska\Dokumenty\GitHub\outpost\outpost\Strona internetowa\Test\Test\Views\Home\Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!DOCTYPE html>\r\n    <html lang=\"en\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41bdde25db049450583f8ce008b226039ba9698e3553", async() => {
                WriteLiteral(@"
        <meta charset=""UTF-8"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
        <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
        <title>Outpost</title>
        <link rel=""stylesheet"" href=""/css/site.css"">
        <script src=""/js/site.js""></script>
        <script src=""https://kit.fontawesome.com/ad31369bc9.js""></script>
    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41bdde25db049450583f8ce008b226039ba9698e4925", async() => {
                WriteLiteral(@"
        <span class=""slide"">
            <a href=""#"" onclick=""openSlideMenu()"" id=""bars"">

                <i class=""fas fa-bars""></i>
            </a>
        </span>

        <div id=""menu"" class=""nav"">
            <a href=""#"" class=""close"" onclick=""closeSlideMenu()"">
                <i class=""fas fa-times""></i>
            </a>
            <a href=""/home/Index"" id=""button"" runat=""server"">
                <i class=""fas fa-home""></i>
            </a>
            <a href=""/home/Package"" id=""button2"" runat=""server"">
                <i class=""fas fa-box-open""></i>
            </a>
            <a href=""/Home/Pick"" id=""button3"" runat=""server"">
                <i class=""fas fa-user-friends""></i>
            </a>
            <a href=""/Home/CreateAccount"" id=""button4"">
                <i class=""fas fa-times""></i>
            </a>
            <a href=""#"" id=""button5"">
                <i class=""fas fa-times""></i>
            </a>
        </div>

        <div class=""pimg1"">
            <d");
                WriteLiteral(@"iv class=""ptext"">
                <span class=""border"">
                    Outpost
                </span>
            </div>
        </div>

        <section class=""section section-light"">
            <h2>Sign in</h2>
            <div id=""create-account"">
                <label class=""input"">
                    ");
#nullable restore
#line 58 "C:\Users\milos\OneDrive - Politechnika Wroclawska\Dokumenty\GitHub\outpost\outpost\Strona internetowa\Test\Test\Views\Home\Index.cshtml"
               Write(Html.LabelFor(model => model.Login, htmlAttributes: new { @class = "input" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 59 "C:\Users\milos\OneDrive - Politechnika Wroclawska\Dokumenty\GitHub\outpost\outpost\Strona internetowa\Test\Test\Views\Home\Index.cshtml"
               Write(Html.EditorFor(model => model.Login));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </label>\r\n                <label class=\"input\" type=\"password\">\r\n                    ");
#nullable restore
#line 62 "C:\Users\milos\OneDrive - Politechnika Wroclawska\Dokumenty\GitHub\outpost\outpost\Strona internetowa\Test\Test\Views\Home\Index.cshtml"
               Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "input" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 63 "C:\Users\milos\OneDrive - Politechnika Wroclawska\Dokumenty\GitHub\outpost\outpost\Strona internetowa\Test\Test\Views\Home\Index.cshtml"
               Write(Html.EditorFor(model => model.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </label>
                <label class=""input"">
                    <input type=""submit"" value=""Zaloguj"" class=""btn btn-succes"" />
                </label>
            </div>
        </section>

        <div class=""pimg2"">
            <div class=""ptext"">
                <span class=""border trans"">
 
                </span>
            </div>
        </div>

        <section class=""section section-dark"">
            <h2>Outpost</h2>
        </section>

        <div class=""pimg3"">
            <div class=""ptext"">
                <span class=""border trans"">
                </span>
            </div>
        </div>

        <section class=""section section-dark"">
            <h2>Outpost</h2>
        </section>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
#nullable restore
#line 95 "C:\Users\milos\OneDrive - Politechnika Wroclawska\Dokumenty\GitHub\outpost\outpost\Strona internetowa\Test\Test\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
