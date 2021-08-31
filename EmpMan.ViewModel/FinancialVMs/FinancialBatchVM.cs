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
    public partial class FinancialBatchVM : BaseBatchVM<Financial, Financial_BatchEdit>
    {
        public FinancialBatchVM()
        {
            ListVM = new FinancialListVM();
            LinkedVM = new Financial_BatchEdit();
        }

    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class Financial_BatchEdit : BaseVM
    {
        [Display(Name = "日期")]
        public String date { get; set; }
        [Display(Name = "资金状态")]
        public Financial.IOEnum? Gender { get; set; }
        [Display(Name = "金额")]
        public Decimal? Money { get; set; }
        [Display(Name = "用途")]
        public String UseFor { get; set; }
        [Display(Name = "备注")]
        public String Notes { get; set; }

        protected override void InitVM()
        {
        }

    }

}
