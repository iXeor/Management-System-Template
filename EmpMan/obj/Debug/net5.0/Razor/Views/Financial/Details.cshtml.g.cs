#pragma checksum "D:\数据库实训\EmpMan\EmpMan\Views\Financial\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30695a4f94508de557de767ad54c086e28254615"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Financial_Details), @"mvc.1.0.view", @"/Views/Financial/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30695a4f94508de557de767ad54c086e28254615", @"/Views/Financial/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6eb08fc745fa4d8c418fb2d064cdc45f535ba08", @"/Views/_ViewImports.cshtml")]
    public class Views_Financial_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmpMan.ViewModel.FinancialVMs.FinancialVM>
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
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.FormTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_FormTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.RowTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.DisplayTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.CloseButtonTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_CloseButtonTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30695a4f94508de557de767ad54c086e282546153593", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:row", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30695a4f94508de557de767ad54c086e282546153854", async() => {
                    WriteLiteral("\r\n");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:display", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "30695a4f94508de557de767ad54c086e282546154122", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.DisplayTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper);
#nullable restore
#line 6 "D:\数据库实训\EmpMan\EmpMan\Views\Financial\Details.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Entity.date);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:display", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "30695a4f94508de557de767ad54c086e282546155643", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.DisplayTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper);
#nullable restore
#line 7 "D:\数据库实训\EmpMan\EmpMan\Views\Financial\Details.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Entity.Gender);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:display", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "30695a4f94508de557de767ad54c086e282546157166", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.DisplayTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper);
#nullable restore
#line 8 "D:\数据库实训\EmpMan\EmpMan\Views\Financial\Details.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Entity.Money);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:display", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "30695a4f94508de557de767ad54c086e282546158688", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.DisplayTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper);
#nullable restore
#line 9 "D:\数据库实训\EmpMan\EmpMan\Views\Financial\Details.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Entity.UseFor);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:display", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "30695a4f94508de557de767ad54c086e2825461510211", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.DisplayTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper);
#nullable restore
#line 10 "D:\数据库实训\EmpMan\EmpMan\Views\Financial\Details.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Entity.Notes);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\数据库实训\EmpMan\EmpMan\Views\Financial\Details.cshtml"
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:row", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30695a4f94508de557de767ad54c086e2825461512913", async() => {
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:closebutton", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "30695a4f94508de557de767ad54c086e2825461513190", async() => {
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
#line 12 "D:\数据库实训\EmpMan\EmpMan\Views\Financial\Details.cshtml"
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
#line 4 "D:\数据库实训\EmpMan\EmpMan\Views\Financial\Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmpMan.ViewModel.FinancialVMs.FinancialVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
