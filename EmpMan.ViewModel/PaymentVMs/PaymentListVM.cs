using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using EmpMan.Model;


namespace EmpMan.ViewModel.PaymentVMs
{
    public partial class PaymentListVM : BasePagedListVM<Payment_View, PaymentSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("Payment", GridActionStandardTypesEnum.Create, Localizer["Sys.Create"],"", dialogWidth: 800),
                this.MakeStandardAction("Payment", GridActionStandardTypesEnum.Edit, Localizer["Sys.Edit"], "", dialogWidth: 800),
                this.MakeStandardAction("Payment", GridActionStandardTypesEnum.Delete, Localizer["Sys.Delete"], "", dialogWidth: 800),
                this.MakeStandardAction("Payment", GridActionStandardTypesEnum.Details, Localizer["Sys.Details"], "", dialogWidth: 800),
                this.MakeStandardAction("Payment", GridActionStandardTypesEnum.BatchEdit, Localizer["Sys.BatchEdit"], "", dialogWidth: 800),
                this.MakeStandardAction("Payment", GridActionStandardTypesEnum.BatchDelete, Localizer["Sys.BatchDelete"], "", dialogWidth: 800),
                this.MakeStandardAction("Payment", GridActionStandardTypesEnum.Import, Localizer["Sys.Import"], "", dialogWidth: 800),
                this.MakeStandardAction("Payment", GridActionStandardTypesEnum.ExportExcel, Localizer["Sys.Export"], ""),
            };
        }


        protected override IEnumerable<IGridColumn<Payment_View>> InitGridHeader()
        {
            return new List<GridColumn<Payment_View>>{
                this.MakeGridHeader(x => x.date),
                this.MakeGridHeader(x => x.Name),
                this.MakeGridHeader(x => x.pay),
                this.MakeGridHeader(x => x.Notes),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Payment_View> GetSearchQuery()
        {
            var query = DC.Set<Payment>()
                .CheckContain(Searcher.date, x=>x.date)
                .CheckContain(Searcher.Name, x=>x.Name)
                .Select(x => new Payment_View
                {
				    ID = x.ID,
                    date = x.date,
                    Name = x.Name,
                    pay = x.pay,
                    Notes = x.Notes,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Payment_View : Payment{

    }
}
