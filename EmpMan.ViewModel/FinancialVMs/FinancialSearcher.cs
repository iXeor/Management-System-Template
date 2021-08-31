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
    public partial class FinancialSearcher : BaseSearcher
    {
        [Display(Name = "日期")]
        public String date { get; set; }
        [Display(Name = "资金状态")]
        public Financial.IOEnum? Gender { get; set; }

        protected override void InitVM()
        {
        }

    }
}
