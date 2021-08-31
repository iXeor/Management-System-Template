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
    public partial class PaymentBatchVM : BaseBatchVM<Payment, Payment_BatchEdit>
    {
        public PaymentBatchVM()
        {
            ListVM = new PaymentListVM();
            LinkedVM = new Payment_BatchEdit();
        }

    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class Payment_BatchEdit : BaseVM
    {
        [Display(Name = "工资结算日期")]
        public String date { get; set; }
        [Display(Name = "被结发人")]
        public String Name { get; set; }
        [Display(Name = "结发工资（元）")]
        public String pay { get; set; }
        [Display(Name = "备注")]
        public String Notes { get; set; }

        protected override void InitVM()
        {
        }

    }

}
