#pragma checksum "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\Preference.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d7db53b32f615b5820f2b1405ca73394b0d4e26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_Preference), @"mvc.1.0.view", @"/Views/Manager/Preference.cshtml")]
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
#line 1 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\Preference.cshtml"
using AdvertisingAgency.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\Preference.cshtml"
using AdvertisingAgency.Models.CompositeModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d7db53b32f615b5820f2b1405ca73394b0d4e26", @"/Views/Manager/Preference.cshtml")]
    public class Views_Manager_Preference : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d7db53b32f615b5820f2b1405ca73394b0d4e262994", async() => {
                WriteLiteral("\r\n    <nav>\r\n        <a href=\"/Manager\">Главная</a>\r\n        <a href=\"/Manager/Out\">Выход</a>\r\n    </nav>\r\n    <div>\r\n");
#nullable restore
#line 11 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\Preference.cshtml"
         foreach(Client_Preferense preference in ViewBag.Preferences)
         {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>\r\n                <p>Название компании ");
#nullable restore
#line 14 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\Preference.cshtml"
                                Write(preference.client.company_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Директор ");
#nullable restore
#line 15 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\Preference.cshtml"
                       Write(preference.client.director);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Город ");
#nullable restore
#line 16 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\Preference.cshtml"
                    Write(preference.client.city);

#line default
#line hidden
#nullable disable
                WriteLiteral(" улица ");
#nullable restore
#line 16 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\Preference.cshtml"
                                                  Write(preference.client.street);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Email ");
#nullable restore
#line 17 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\Preference.cshtml"
                    Write(preference.client.email);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Номер телефона ");
#nullable restore
#line 17 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\Preference.cshtml"
                                                            Write(preference.client.tel);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Аудитория ");
#nullable restore
#line 18 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\Preference.cshtml"
                        Write(preference.preference.audience);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Каткое описание ");
#nullable restore
#line 19 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\Preference.cshtml"
                              Write(preference.preference.preculiarities);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Максимальнпая сумма ");
#nullable restore
#line 20 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\Preference.cshtml"
                                  Write(preference.preference.max_sum);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Период ");
#nullable restore
#line 21 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\Preference.cshtml"
                     Write(preference.preference.period);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 931, "\"", 992, 2);
                WriteAttributeValue("", 938, "/Manager/MediaPlanPreference/", 938, 29, true);
#nullable restore
#line 22 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\Preference.cshtml"
WriteAttributeValue("", 967, preference.preference.id, 967, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Выбрать</a>\r\n            </div>\r\n");
#nullable restore
#line 24 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\Preference.cshtml"
         }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
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
