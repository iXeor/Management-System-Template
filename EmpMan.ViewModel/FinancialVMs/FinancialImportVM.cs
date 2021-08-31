using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using EmpMan.Model;


namespace EmpMan.ViewModel.FinancialVMs
{
    public partial class FinancialTemplateVM : BaseTemplateVM
    {
        [Display(Name = "日期")]
        public ExcelPropety date_Excel = ExcelPropety.CreateProperty<Financial>(x => x.date);
        [Display(Name = "资金状态")]
        public ExcelPropety Gender_Excel = ExcelPropety.CreateProperty<Financial>(x => x.Gender);
        [Display(Name = "金额")]
        public ExcelPropety Money_Excel = ExcelPropety.CreateProperty<Financial>(x => x.Money);
        [Display(Name = "用途")]
        public ExcelPropety UseFor_Excel = ExcelPropety.CreateProperty<Financial>(x => x.UseFor);
        [Display(Name = "备注")]
        public ExcelPropety Notes_Excel = ExcelPropety.CreateProperty<Financial>(x => x.Notes);

	    protected override void InitVM()
        {
        }

    }

    public class FinancialImportVM : BaseImportVM<FinancialTemplateVM, Financial>
    {

    }

}
