#pragma checksum "D:\数据库实训\EmpMan\EmpMan\Areas\_Admin\Views\FrameworkGroup\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2326196b790b70b88b3abbaedb68cd18279ab88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas__Admin_Views_FrameworkGroup_Delete), @"mvc.1.0.view", @"/Areas/_Admin/Views/FrameworkGroup/Delete.cshtml")]
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
#line 3 "D:\数据库实训\EmpMan\EmpMan\Areas\_ViewImports.cshtml"
using EmpMan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\数据库实训\EmpMan\EmpMan\Areas\_Admin\Views\_ViewImports.cshtml"
using WalkingTec.Mvvm.TagHelpers.LayUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\数据库实训\EmpMan\EmpMan\Areas\_Admin\Views\FrameworkGroup\Delete.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2326196b790b70b88b3abbaedb68cd18279ab88", @"/Areas/_Admin/Views/FrameworkGroup/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6eb08fc745fa4d8c418fb2d064cdc45f535ba08", @"/Areas/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5af7bad1a013aa83ed4e7fe5690b1e15f4509763", @"/Areas/_Admin/Views/_ViewImports.cshtml")]
    public class Areas__Admin_Views_FrameworkGroup_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WalkingTec.Mvvm.Mvc.Admin.ViewModels.FrameworkGroupVMs.FrameworkGroupVM>
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
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.QuoteTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_QuoteTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.DisplayTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.TextAreaTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_TextAreaTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.HiddenTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.RowTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.SubmitButtonTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper;
        private global::WalkingTec.Mvvm.TagHelpers.LayUI.CloseButtonTagHelper __WalkingTec_Mvvm_TagHelpers_LayUI_CloseButtonTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2326196b790b70b88b3abbaedb68cd18279ab884438", async() => {
                WriteLiteral("\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:quote", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2326196b790b70b88b3abbaedb68cd18279ab884701", async() => {
#nullable restore
#line 6 "D:\数据库实训\EmpMan\EmpMan\Areas\_Admin\Views\FrameworkGroup\Delete.cshtml"
       Write(Localizer["Sys.DeleteConfirm"]);

#line default
#line hidden
#nullable disable
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_QuoteTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.QuoteTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_QuoteTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:display", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2326196b790b70b88b3abbaedb68cd18279ab885860", async() => {
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.DisplayTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper);
#nullable restore
#line 7 "D:\数据库实训\EmpMan\EmpMan\Areas\_Admin\Views\FrameworkGroup\Delete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Entity.GroupCode);

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
                WriteLiteral("\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:display", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2326196b790b70b88b3abbaedb68cd18279ab887349", async() => {
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.DisplayTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper);
#nullable restore
#line 8 "D:\数据库实训\EmpMan\EmpMan\Areas\_Admin\Views\FrameworkGroup\Delete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_DisplayTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Entity.GroupName);

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
                WriteLiteral("\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2326196b790b70b88b3abbaedb68cd18279ab888838", async() => {
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_TextAreaTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_TextAreaTagHelper);
#nullable restore
#line 9 "D:\数据库实训\EmpMan\EmpMan\Areas\_Admin\Views\FrameworkGroup\Delete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_TextAreaTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Entity.GroupRemark);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("field", __WalkingTec_Mvvm_TagHelpers_LayUI_TextAreaTagHelper.Field, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 9 "D:\数据库实训\EmpMan\EmpMan\Areas\_Admin\Views\FrameworkGroup\Delete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_TextAreaTagHelper.Disabled = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("disabled", __WalkingTec_Mvvm_TagHelpers_LayUI_TextAreaTagHelper.Disabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2326196b790b70b88b3abbaedb68cd18279ab8810784", async() => {
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.HiddenTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper);
#nullable restore
#line 10 "D:\数据库实训\EmpMan\EmpMan\Areas\_Admin\Views\FrameworkGroup\Delete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_HiddenTagHelper.Field = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Entity.ID);

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
                WriteLiteral("\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:row", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2326196b790b70b88b3abbaedb68cd18279ab8812262", async() => {
                    WriteLiteral("\r\n    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:submitbutton", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2326196b790b70b88b3abbaedb68cd18279ab8812535", async() => {
                    }
                    );
                    __WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.SubmitButtonTagHelper>();
                    __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper);
#nullable restore
#line 12 "D:\数据库实训\EmpMan\EmpMan\Areas\_Admin\Views\FrameworkGroup\Delete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper.Theme =  ButtonThemeEnum.Warm;

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("theme", __WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper.Theme, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "D:\数据库实训\EmpMan\EmpMan\Areas\_Admin\Views\FrameworkGroup\Delete.cshtml"
                                             WriteLiteral(Localizer["Sys.Delete"]);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper.Text = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("text", __WalkingTec_Mvvm_TagHelpers_LayUI_SubmitButtonTagHelper.Text, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("wt:closebutton", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2326196b790b70b88b3abbaedb68cd18279ab8814757", async() => {
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
                    WriteLiteral("\r\n  ");
                }
                );
                __WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper = CreateTagHelper<global::WalkingTec.Mvvm.TagHelpers.LayUI.RowTagHelper>();
                __tagHelperExecutionContext.Add(__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper);
#nullable restore
#line 11 "D:\数据库实训\EmpMan\EmpMan\Areas\_Admin\Views\FrameworkGroup\Delete.cshtml"
__WalkingTec_Mvvm_TagHelpers_LayUI_RowTagHelper.Align =  AlignEnum.Right;

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
#line 5 "D:\数据库实训\EmpMan\EmpMan\Areas\_Admin\Views\FrameworkGroup\Delete.cshtml"
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
            WriteLiteral("\r\n\r\n<!-- WTM默认页面 Wtm buidin page-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WalkingTec.Mvvm.Mvc.Admin.ViewModels.FrameworkGroupVMs.FrameworkGroupVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
