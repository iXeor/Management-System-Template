using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ICSharpCode.SharpZipLib.Core;
using WalkingTec.Mvvm.Core;

namespace EmpMan.Model
{
    [Table("Financial")]
    public class Financial : BasePoco
    {
        public enum IOEnum
        {
            [Display(Name = "转入")] In,
            [Display(Name = "转出")] Out,
        }

        [Display(Name = "日期")]
        [StringLength(50, ErrorMessage = "Validate.{0}stringmax{1}")]
        public string date { get; set; }


        [Display(Name = "资金状态")]
        public IOEnum? Gender { get; set; }

        [Display(Name = "金额")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Money { get; set; }

        [Display(Name = "用途")]
        [StringLength(20, ErrorMessage = "Validate.{0}stringmax{1}")]
        public string UseFor { get; set; }

        [Display(Name = "备注")]
        [StringLength(400, ErrorMessage = "Validate.{0}stringmax{1}")]
        public string Notes { get; set; }
    }
}
