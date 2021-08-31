using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using EmpMan.Model;


namespace EmpMan.ViewModel.FinancialVMs
{
    public partial class FinancialListVM : BasePagedListVM<Financial_View, FinancialSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("Financial", GridActionStandardTypesEnum.Create, Localizer["Sys.Create"],"", dialogWidth: 800),
                this.MakeStandardAction("Financial", GridActionStandardTypesEnum.Edit, Localizer["Sys.Edit"], "", dialogWidth: 800),
                this.MakeStandardAction("Financial", GridActionStandardTypesEnum.Delete, Localizer["Sys.Delete"], "", dialogWidth: 800),
                this.MakeStandardAction("Financial", GridActionStandardTypesEnum.Details, Localizer["Sys.Details"], "", dialogWidth: 800),
                this.MakeStandardAction("Financial", GridActionStandardTypesEnum.BatchEdit, Localizer["Sys.BatchEdit"], "", dialogWidth: 800),
                this.MakeStandardAction("Financial", GridActionStandardTypesEnum.BatchDelete, Localizer["Sys.BatchDelete"], "", dialogWidth: 800),
                this.MakeStandardAction("Financial", GridActionStandardTypesEnum.Import, Localizer["Sys.Import"], "", dialogWidth: 800),
                this.MakeStandardAction("Financial", GridActionStandardTypesEnum.ExportExcel, Localizer["Sys.Export"], ""),
            };
        }


        protected override IEnumerable<IGridColumn<Financial_View>> InitGridHeader()
        {
            return new List<GridColumn<Financial_View>>{
                this.MakeGridHeader(x => x.date),
                this.MakeGridHeader(x => x.Gender),
                this.MakeGridHeader(x => x.Money),
                this.MakeGridHeader(x => x.UseFor),
                this.MakeGridHeader(x => x.Notes),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Financial_View> GetSearchQuery()
        {
            var query = DC.Set<Financial>()
                .CheckContain(Searcher.date, x=>x.date)
                .CheckEqual(Searcher.Gender, x=>x.Gender)
                .Select(x => new Financial_View
                {
				    ID = x.ID,
                    date = x.date,
                    Gender = x.Gender,
                    Money = x.Money,
                    UseFor = x.UseFor,
                    Notes = x.Notes,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Financial_View : Financial{

    }
}
