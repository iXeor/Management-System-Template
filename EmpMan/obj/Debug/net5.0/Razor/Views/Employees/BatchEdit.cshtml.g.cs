#pragma checksum "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99b5ae314c72228a6ef5ecc6155f239d7d640cb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_BatchEdit), @"mvc.1.0.view", @"/Views/Employees/BatchEdit.cshtml")]
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
#line 1 "D:\数据库实训\EmpMan\EmpMan\Views\_ViewImports.cshtml"
using WalkingTec.Mvvm.TagHelpers.LayUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\数据库实训\EmpMan\EmpMan\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\数据库实训\EmpMan\EmpMan\Views\_ViewImports.cshtml"
using EmpMan;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99b5ae314c72228a6ef5ecc6155f239d7d640cb6", @"/Views/Employees/BatchEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6eb08fc745fa4d8c418fb2d064cdc45f535ba08", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_BatchEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmpMan.ViewModel.EmployeesVMs.EmployeesBatchVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("hidden-panel", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.FormTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.RowTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.TextBoxTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.ComboBoxTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.SwitchTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_SwitchTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.HiddenTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.DataTableTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.SubmitButtonTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.CloseButtonTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_CloseButtonTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99b5ae314c72228a6ef5ecc6155f239d7d640cb64611", async() => {
                WriteLiteral("\r\n    <div style=\"margin-bottom:10px\">");
#nullable restore
#line 5 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
                               Write(Localizer["Sys.BatchEditConfirm"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </div>\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:row", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99b5ae314c72228a6ef5ecc6155f239d7d640cb65166", async() => {
                    WriteLiteral("\r\n");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:textbox", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99b5ae314c72228a6ef5ecc6155f239d7d640cb65434", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.TextBoxTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper);
#nullable restore
#line 7 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LinkedVM.Elder);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:textbox", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99b5ae314c72228a6ef5ecc6155f239d7d640cb66960", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.TextBoxTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper);
#nullable restore
#line 8 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LinkedVM.Age);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:textbox", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99b5ae314c72228a6ef5ecc6155f239d7d640cb68484", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.TextBoxTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper);
#nullable restore
#line 9 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LinkedVM.Email);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:combobox", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99b5ae314c72228a6ef5ecc6155f239d7d640cb610010", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.ComboBoxTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper);
#nullable restore
#line 10 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LinkedVM.Gender);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_ComboBoxTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:textbox", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99b5ae314c72228a6ef5ecc6155f239d7d640cb611545", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.TextBoxTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper);
#nullable restore
#line 11 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LinkedVM.CellPhone);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:textbox", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99b5ae314c72228a6ef5ecc6155f239d7d640cb613077", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.TextBoxTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper);
#nullable restore
#line 12 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LinkedVM.HomePhone);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:textbox", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99b5ae314c72228a6ef5ecc6155f239d7d640cb614609", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.TextBoxTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper);
#nullable restore
#line 13 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LinkedVM.Address);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:textbox", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99b5ae314c72228a6ef5ecc6155f239d7d640cb616139", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.TextBoxTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper);
#nullable restore
#line 14 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LinkedVM.ZipCode);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:textbox", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99b5ae314c72228a6ef5ecc6155f239d7d640cb617669", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.TextBoxTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper);
#nullable restore
#line 15 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LinkedVM.EID);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:textbox", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99b5ae314c72228a6ef5ecc6155f239d7d640cb619195", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.TextBoxTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper);
#nullable restore
#line 16 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LinkedVM.jobs);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:textbox", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99b5ae314c72228a6ef5ecc6155f239d7d640cb620722", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.TextBoxTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper);
#nullable restore
#line 17 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LinkedVM.ITCode);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:textbox", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99b5ae314c72228a6ef5ecc6155f239d7d640cb622251", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.TextBoxTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper);
#nullable restore
#line 18 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LinkedVM.Password);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:textbox", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99b5ae314c72228a6ef5ecc6155f239d7d640cb623782", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.TextBoxTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper);
#nullable restore
#line 19 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LinkedVM.Name);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_TextBoxTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:switch", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99b5ae314c72228a6ef5ecc6155f239d7d640cb625309", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_SwitchTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.SwitchTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_SwitchTagHelper);
#nullable restore
#line 20 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_SwitchTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LinkedVM.IsValid);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_SwitchTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.RowTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper);
#nullable restore
#line 6 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper.ItemsPerRow = ItemsPerRowEnum.Two;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("items-per-row", __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper.ItemsPerRow, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99b5ae314c72228a6ef5ecc6155f239d7d640cb628013", async() => {
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.HiddenTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper);
#nullable restore
#line 22 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Ids);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99b5ae314c72228a6ef5ecc6155f239d7d640cb629472", async() => {
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.DataTableTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper);
#nullable restore
#line 23 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.Vm = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ListVM);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("vm", __WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.Vm, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.UseLocalData = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("use-local-data", __WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.UseLocalData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.Height = 300;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("height", __WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.Height, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.HiddenCheckbox = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("hidden-checkbox", __WalkingTec_Mvvm_TagHelpers_LayUI_DataTableTagHelper.HiddenCheckbox, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:row", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99b5ae314c72228a6ef5ecc6155f239d7d640cb632362", async() => {
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:submitbutton", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99b5ae314c72228a6ef5ecc6155f239d7d640cb632639", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.SubmitButtonTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:closebutton", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99b5ae314c72228a6ef5ecc6155f239d7d640cb633681", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_CloseButtonTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.CloseButtonTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_CloseButtonTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n    ");
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.RowTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper);
#nullable restore
#line 24 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper.Align = AlignEnum.Right;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("align", __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper.Align, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.FormTagHelper>();
            __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper);
#nullable restore
#line 4 "D:\数据库实训\EmpMan\EmpMan\Views\Employees\BatchEdit.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper.Vm = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("vm", __WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper.Vm, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<Program> Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmpMan.ViewModel.EmployeesVMs.EmployeesBatchVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
