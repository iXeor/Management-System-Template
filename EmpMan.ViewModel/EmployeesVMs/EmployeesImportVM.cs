using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Endpoint.Models;


namespace EmpMan.ViewModel.EmployeesVMs
{
    public partial class EmployeesTemplateVM : BaseTemplateVM
    {
        [Display(Name = "工号")]
        public ExcelPropety EID_Excel = ExcelPropety.CreateProperty<Employees>(x => x.EID);
        [Display(Name = "_Admin.Name")]
        public ExcelPropety Name_Excel = ExcelPropety.CreateProperty<Employees>(x => x.Name);
        [Display(Name = "年龄")]
        public ExcelPropety Age_Excel = ExcelPropety.CreateProperty<Employees>(x => x.Age);
        [Display(Name = "_Admin.Gender")]
        public ExcelPropety Gender_Excel = ExcelPropety.CreateProperty<Employees>(x => x.Gender);
        [Display(Name = "职务")]
        public ExcelPropety jobs_Excel = ExcelPropety.CreateProperty<Employees>(x => x.jobs);
        [Display(Name = "工龄")]
        public ExcelPropety Elder_Excel = ExcelPropety.CreateProperty<Employees>(x => x.Elder);
        [Display(Name = "_Admin.Account")]
        public ExcelPropety ITCode_Excel = ExcelPropety.CreateProperty<Employees>(x => x.ITCode);
        [Display(Name = "_Admin.Password")]
        public ExcelPropety Password_Excel = ExcelPropety.CreateProperty<Employees>(x => x.Password);
        [Display(Name = "_Admin.IsValid")]
        public ExcelPropety IsValid_Excel = ExcelPropety.CreateProperty<Employees>(x => x.IsValid);
        [Display(Name = "_Admin.CellPhone")]
        public ExcelPropety CellPhone_Excel = ExcelPropety.CreateProperty<Employees>(x => x.CellPhone);
        [Display(Name = "_Admin.Email")]
        public ExcelPropety Email_Excel = ExcelPropety.CreateProperty<Employees>(x => x.Email);
        [Display(Name = "_Admin.HomePhone")]
        public ExcelPropety HomePhone_Excel = ExcelPropety.CreateProperty<Employees>(x => x.HomePhone);
        [Display(Name = "_Admin.Address")]
        public ExcelPropety Address_Excel = ExcelPropety.CreateProperty<Employees>(x => x.Address);
        [Display(Name = "_Admin.ZipCode")]
        public ExcelPropety ZipCode_Excel = ExcelPropety.CreateProperty<Employees>(x => x.ZipCode);

        protected override void InitVM()
        {
        }

    }

    public class EmployeesImportVM : BaseImportVM<EmployeesTemplateVM, Employees>
    {

    }

}
