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
    public partial class PaymentTemplateVM : BaseTemplateVM
    {
        [Display(Name = "工资结算日期")]
        public ExcelPropety date_Excel = ExcelPropety.CreateProperty<Payment>(x => x.date);
        [Display(Name = "被结发人")]
        public ExcelPropety Name_Excel = ExcelPropety.CreateProperty<Payment>(x => x.Name);
        [Display(Name = "结发工资（元）")]
        public ExcelPropety pay_Excel = ExcelPropety.CreateProperty<Payment>(x => x.pay);
        [Display(Name = "备注")]
        public ExcelPropety Notes_Excel = ExcelPropety.CreateProperty<Payment>(x => x.Notes);

	    protected override void InitVM()
        {
        }

    }

    public class PaymentImportVM : BaseImportVM<PaymentTemplateVM, Payment>
    {

    }

}
