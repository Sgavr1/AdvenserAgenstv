#pragma checksum "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Client\Preference.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3be96d66614ef8e3208d4eac8cfeb8775cd0f48e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Preference), @"mvc.1.0.view", @"/Views/Client/Preference.cshtml")]
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
#line 1 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Client\Preference.cshtml"
using AdvertisingAgency.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3be96d66614ef8e3208d4eac8cfeb8775cd0f48e", @"/Views/Client/Preference.cshtml")]
    public class Views_Client_Preference : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3be96d66614ef8e3208d4eac8cfeb8775cd0f48e2773", async() => {
                WriteLiteral(@"
    <nav>
        <a href=""/Client"">Главное</a>
        <a href=""/Client/Out"">Выйти</a>
    </nav>
    <div>
        <form action=""/Client/AddPreference"">
            <ul>
                <li>
                    <label>Аудитория</label>
                </li>
                <li>
                    <input type=""radio"" id=""1"" name=""audience"" value=""3+"" />
                    <label for=""1"">3+</label>
                    <input type=""radio"" id=""2"" name=""audience"" value=""18"" />
                    <label for=""2"">До 18</label>
                    <input type=""radio"" id=""3"" name=""audience"" value=""18-45"" />
                    <label for=""3"">18-45</label>
                    <input type=""radio"" id=""4"" name=""audience"" value=""45+"" />
                    <label for=""4"">45+</label>
                </li>
                <li>
                    <label>Краткое описание</label>
                </li>
                <li>
                    <input type=""text"" name=""preculiarities"" />
           ");
                WriteLiteral(@"     </li>
                <li>
                    <label>Количество дней</label>
                </li>
                <li>
                    <input type=""number"" name=""period"" />
                </li>
                <li>
                    <label>Максимальная сумма</label>
                </li>
                <li>
                    <input type=""number"" name=""max_sum"" />
                </li>
            </ul>
            <button type=""submit"">Создать</button>
        </form>
    </div>
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
            WriteLiteral("\r\n</html>");
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
