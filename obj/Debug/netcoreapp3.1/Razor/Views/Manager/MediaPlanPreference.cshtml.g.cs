#pragma checksum "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4a3896ca1c14fb9ceba37728bad10661f5c3505"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_MediaPlanPreference), @"mvc.1.0.view", @"/Views/Manager/MediaPlanPreference.cshtml")]
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
#line 1 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
using AdvertisingAgency.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
using AdvertisingAgency.Models.CompositeModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4a3896ca1c14fb9ceba37728bad10661f5c3505", @"/Views/Manager/MediaPlanPreference.cshtml")]
    public class Views_Manager_MediaPlanPreference : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4a3896ca1c14fb9ceba37728bad10661f5c35053057", async() => {
                WriteLiteral("\r\n    <nav>\r\n        <a href=\"/Manager\">Главная</a>\r\n        <a href=\"/Manager/Out\">Выход</a>\r\n    </nav>\r\n    <div>\r\n        <div>\r\n            <p>Название компании ");
#nullable restore
#line 12 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
                            Write(ViewBag.Preference.client.company_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>Директор ");
#nullable restore
#line 13 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
                   Write(ViewBag.Preference.client.director);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>Город ");
#nullable restore
#line 14 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
                Write(ViewBag.Preference.client.city);

#line default
#line hidden
#nullable disable
                WriteLiteral(" улица ");
#nullable restore
#line 14 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
                                                      Write(ViewBag.Preference.client.street);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>Email ");
#nullable restore
#line 15 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
                Write(ViewBag.Preference.client.email);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Номер телефона ");
#nullable restore
#line 15 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
                                                                Write(ViewBag.Preference.client.tel);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>Аудитория ");
#nullable restore
#line 16 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
                    Write(ViewBag.Preference.preference.audience);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>Каткое описание ");
#nullable restore
#line 17 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
                          Write(ViewBag.Preference.preference.preculiarities);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>Максимальнпая сумма ");
#nullable restore
#line 18 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
                              Write(ViewBag.Preference.preference.max_sum);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>Период ");
#nullable restore
#line 19 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
                 Write(ViewBag.Preference.preference.period);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
         if(ViewBag.Service == null)
         {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
             foreach(Partners_Services parter in ViewBag.Partners)
             {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div>\r\n                    <p>Компания ");
#nullable restore
#line 26 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
                           Write(parter.partners.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 27 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
                     foreach(TypeOfServiceModel service in parter.services)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div>\r\n                            <p>Тип ");
#nullable restore
#line 30 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
                              Write(service.platform_type);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <p>Цена за 1 показ ");
#nullable restore
#line 31 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
                                          Write(service.price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 1397, "\"", 1444, 2);
                WriteAttributeValue("", 1404, "/Manager/SelectParterServise/", 1404, 29, true);
#nullable restore
#line 32 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
WriteAttributeValue("", 1433, service.id, 1433, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Выбрать</a>\r\n                        </div>\r\n");
#nullable restore
#line 34 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n");
#nullable restore
#line 36 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
              
         }
         else
         {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <form action=""/Manager/AddMediaPlan"">
                <ul>
                    <li>
                        <label>Показов в день</label>
                    </li>
                    <li>
                        <input type=""number"" name=""broadcast""/>
                    </li>
                </ul>
                <button type=""submit"">Создать медиа план</button>
            </form>
");
#nullable restore
#line 51 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Manager\MediaPlanPreference.cshtml"
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
