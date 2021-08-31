using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Endpoint.Models;


namespace EmpMan.ViewModel.EmployeesVMs
{
    public partial class EmployeesListVM : BasePagedListVM<Employees_View, EmployeesSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("Employees", GridActionStandardTypesEnum.Create, Localizer["Sys.Create"],"", dialogWidth: 800),
                this.MakeStandardAction("Employees", GridActionStandardTypesEnum.Edit, Localizer["Sys.Edit"], "", dialogWidth: 800),
                this.MakeStandardAction("Employees", GridActionStandardTypesEnum.Delete, Localizer["Sys.Delete"], "", dialogWidth: 800),
                this.MakeStandardAction("Employees", GridActionStandardTypesEnum.Details, Localizer["Sys.Details"], "", dialogWidth: 800),
                this.MakeStandardAction("Employees", GridActionStandardTypesEnum.BatchEdit, Localizer["Sys.BatchEdit"], "", dialogWidth: 800),
                this.MakeStandardAction("Employees", GridActionStandardTypesEnum.BatchDelete, Localizer["Sys.BatchDelete"], "", dialogWidth: 800),
                this.MakeStandardAction("Employees", GridActionStandardTypesEnum.Import, Localizer["Sys.Import"], "", dialogWidth: 800),
                this.MakeStandardAction("Employees", GridActionStandardTypesEnum.ExportExcel, Localizer["Sys.Export"], ""),
            };
        }


        protected override IEnumerable<IGridColumn<Employees_View>> InitGridHeader()
        {
            return new List<GridColumn<Employees_View>>{
                this.MakeGridHeader(x => x.EID),
                this.MakeGridHeader(x => x.Name),
                this.MakeGridHeader(x => x.Age),
                this.MakeGridHeader(x => x.Gender),
                this.MakeGridHeader(x => x.jobs),
                this.MakeGridHeader(x => x.Elder),
                this.MakeGridHeader(x => x.ITCode),
                this.MakeGridHeader(x => x.Password),
                this.MakeGridHeader(x => x.IsValid),
                this.MakeGridHeader(x => x.CellPhone),
                this.MakeGridHeader(x => x.Email),
                this.MakeGridHeader(x => x.HomePhone),
                this.MakeGridHeader(x => x.Address),
                this.MakeGridHeader(x => x.ZipCode),
                this.MakeGridHeader(x => x.PhotoId).SetFormat(PhotoIdFormat),
                this.MakeGridHeaderAction(width: 200)
            };
        }
        private List<ColumnFormatInfo> PhotoIdFormat(Employees_View entity, object val)
        {
            return new List<ColumnFormatInfo>
            {
                ColumnFormatInfo.MakeDownloadButton(ButtonTypesEnum.Button,entity.PhotoId),
                ColumnFormatInfo.MakeViewButton(ButtonTypesEnum.Button,entity.PhotoId,640,480),
            };
        }


        public override IOrderedQueryable<Employees_View> GetSearchQuery()
        {
            var query = DC.Set<Employees>()
                .CheckContain(Searcher.Elder, x=>x.Elder)
                .CheckContain(Searcher.Age, x=>x.Age)
                .CheckEqual(Searcher.Gender, x=>x.Gender)
                .CheckContain(Searcher.CellPhone, x=>x.CellPhone)
                .CheckContain(Searcher.EID, x=>x.EID)
                .CheckContain(Searcher.jobs, x=>x.jobs)
                .CheckContain(Searcher.ITCode, x=>x.ITCode)
                .CheckContain(Searcher.Name, x=>x.Name)
                .CheckEqual(Searcher.IsValid, x=>x.IsValid)
                .Select(x => new Employees_View
                {
				    ID = x.ID,
                    Elder = x.Elder,
                    Age = x.Age,
                    Email = x.Email,
                    Gender = x.Gender,
                    CellPhone = x.CellPhone,
                    HomePhone = x.HomePhone,
                    Address = x.Address,
                    ZipCode = x.ZipCode,
                    EID = x.EID,
                    jobs = x.jobs,
                    ITCode = x.ITCode,
                    Password = x.Password,
                    Name = x.Name,
                    IsValid = x.IsValid,
                    PhotoId = x.PhotoId,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Employees_View : Employees{

    }
}
