#pragma checksum "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e708169593fe8c72d99ee2902d0eb5239bde3c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Director_Staff), @"mvc.1.0.view", @"/Views/Director/Staff.cshtml")]
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
#line 1 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
using AdvertisingAgency.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
using AdvertisingAgency.Models.CompositeModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e708169593fe8c72d99ee2902d0eb5239bde3c1", @"/Views/Director/Staff.cshtml")]
    public class Views_Director_Staff : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e708169593fe8c72d99ee2902d0eb5239bde3c12966", async() => {
                WriteLiteral(@"
    <nav>
        <a href=""/Director/Partner"">Партнёры</a>
        <a href=""/Director/Out"">Выйти</a>
    </nav>
    <div>
        <form action=""AddStaff"">
            <ul>
                <li>
                    <label>Имя</label>
                </li>
                <li>
                    <input type=""text"" name=""first_name"" />
                </li>
                <li>
                    <label>Фамилия</label>
                </li>
                <li>
                    <input type=""text"" name=""last_name"" />
                </li>
                <li>
                    <label>Дата рождения</label>
                </li>
                <li>
                    <input type=""date"" name=""date_of_birthday""/>
                </li>
                <li>
                    <label>Пол</label>
                </li>
                <li>
                    <input id=""1"" value=""m"" name=""sex"" type=""radio"" />
                    <label for=""1"">Мужской</label>
                    <");
                WriteLiteral(@"input id=""2"" value=""f"" name=""sex"" type=""radio"" />
                    <label for=""2"">Женский</label>
                </li>
                <li>
                    <label>Должность</label>
                </li>
                <li>
                    <input id=""2"" value=""2"" name=""position"" type=""radio"" />
                    <label for=""2"">Менеджер</label>
                    <input id=""3"" value=""3"" name=""position"" type=""radio"" />
                    <label for=""3"">Креативный Менеджер</label>
                </li>
                <li>
                    <label>Номер телефона</label>
                </li>
                <li>
                    <input type=""tel"" name=""tel"" />
                </li>
                <li>
                    <label>Пароль</label>
                </li>
                <li>
                    <input type=""text"" name=""password"" />
                </li>
            </ul>
            <button>Добавить нового сотрудника</button>
        </form>
    </div>
");
#nullable restore
#line 65 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
     if (ViewBag.WorkingStaffs.Count > 0)
     {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>\r\n");
#nullable restore
#line 68 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
             foreach (Staff_StaffPosition_Position staff in ViewBag.WorkingStaffs)
             {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
                 if (staff.position.name != "Director")
                 {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div>\r\n                        <p>Имя ");
#nullable restore
#line 73 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
                          Write(staff.staff.first_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <p>Фамилия ");
#nullable restore
#line 74 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
                              Write(staff.staff.last_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <p>День рождения ");
#nullable restore
#line 75 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
                                    Write(staff.staff.date_of_birthday.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                        <p>Пол ");
#nullable restore
#line 76 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
                          Write(staff.staff.sex);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                        <p>Номер телефона ");
#nullable restore
#line 77 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
                                     Write(staff.staff.tel);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                        <p>Дата устройство на работу ");
#nullable restore
#line 78 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
                                                Write(staff.staffPosition.start_work.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                        <p>Должность ");
#nullable restore
#line 79 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
                                Write(staff.position.name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                        <p>Зарплата ");
#nullable restore
#line 80 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
                               Write(staff.position.salary);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3028, "\"", 3078, 2);
                WriteAttributeValue("", 3035, "/Director/FireStaff/", 3035, 20, true);
#nullable restore
#line 81 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
WriteAttributeValue("", 3055, staff.staffPosition.id, 3055, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Уволить</a>\r\n                    </div>\r\n");
#nullable restore
#line 83 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
                 }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
                  
             }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n");
#nullable restore
#line 86 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
     if (ViewBag.FireStaffs.Count > 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>Уволеные сотрудники</p>\r\n        <div>\r\n");
#nullable restore
#line 91 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
             foreach (Staff_StaffPosition_Position staff in ViewBag.FireStaffs)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div>\r\n                    <p>Уволен</p>\r\n                    <p>Имя ");
#nullable restore
#line 95 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
                      Write(staff.staff.first_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p>Фамилия ");
#nullable restore
#line 96 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
                          Write(staff.staff.last_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p>День рождения ");
#nullable restore
#line 97 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
                                Write(staff.staff.date_of_birthday.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                    <p>Пол ");
#nullable restore
#line 98 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
                      Write(staff.staff.sex);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                    <p>Номер телефона ");
#nullable restore
#line 99 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
                                 Write(staff.staff.tel);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                    <p>Дата устройство на работу ");
#nullable restore
#line 100 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
                                            Write(staff.staffPosition.start_work.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                    <p>Дата увольнения ");
#nullable restore
#line 101 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
                                  Write(staff.staffPosition.end_work.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                    <p>Должность ");
#nullable restore
#line 102 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
                            Write(staff.position.name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                </div>\r\n");
#nullable restore
#line 104 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n");
#nullable restore
#line 106 "C:\Users\Alex\Desktop\БД Настя\git\AdvenserAgenstv\Views\Director\Staff.cshtml"
    }

#line default
#line hidden
#nullable disable
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
