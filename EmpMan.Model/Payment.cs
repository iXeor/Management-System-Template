using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;

namespace EmpMan.Model
{
    [Table("Payment")]
    public class Payment : BasePoco
    {
        [Display(Name = "工资结算日期")]
        [StringLength(50, ErrorMessage = "Validate.{0}stringmax{1}")]
        public string date { get; set; }

        [Display(Name = "被结发人")]
        [Required(ErrorMessage = "Validate.{0}required")]
        [StringLength(50, ErrorMessage = "Validate.{0}stringmax{1}")]
        public string Name { get; set; }
        [Display(Name = "结发工资（元）")] public string pay { get; set;  }

        [Display(Name = "备注")]
        [StringLength(400, ErrorMessage = "Validate.{0}stringmax{1}")]
        public string Notes { get; set; }
    }
}
