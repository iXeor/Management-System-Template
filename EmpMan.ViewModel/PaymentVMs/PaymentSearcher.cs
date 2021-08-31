using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using EmpMan.Model;


namespace EmpMan.ViewModel.PaymentVMs
{
    public partial class PaymentSearcher : BaseSearcher
    {
        [Display(Name = "工资结算日期")]
        public String date { get; set; }
        [Display(Name = "被结发人")]
        public String Name { get; set; }

        protected override void InitVM()
        {
        }

    }
}
