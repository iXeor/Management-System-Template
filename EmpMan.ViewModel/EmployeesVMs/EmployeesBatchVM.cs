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
    public partial class EmployeesBatchVM : BaseBatchVM<Employees, Employees_BatchEdit>
    {
        public EmployeesBatchVM()
        {
            ListVM = new EmployeesListVM();
            LinkedVM = new Employees_BatchEdit();
        }

    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class Employees_BatchEdit : BaseVM
    {
        [Display(Name = "工龄")]
        public String Elder { get; set; }
        [Display(Name = "年龄")]
        public String Age { get; set; }
        [Display(Name = "_Admin.Email")]
        public String Email { get; set; }
        [Display(Name = "_Admin.Gender")]
        public GenderEnum? Gender { get; set; }
        [Display(Name = "_Admin.CellPhone")]
        public String CellPhone { get; set; }
        [Display(Name = "_Admin.HomePhone")]
        public String HomePhone { get; set; }
        [Display(Name = "_Admin.Address")]
        public String Address { get; set; }
        [Display(Name = "_Admin.ZipCode")]
        public String ZipCode { get; set; }
        [Display(Name = "工号")]
        public String EID { get; set; }
        [Display(Name = "职务")]
        public String jobs { get; set; }
        [Display(Name = "_Admin.Account")]
        public String ITCode { get; set; }
        [Display(Name = "_Admin.Password")]
        public String Password { get; set; }
        [Display(Name = "_Admin.Name")]
        public String Name { get; set; }
        [Display(Name = "_Admin.IsValid")]
        public Boolean? IsValid { get; set; }

        protected override void InitVM()
        {
        }

    }

}
