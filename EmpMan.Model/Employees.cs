using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace Endpoint.Models
{
    [Table("Employees")]
    public class Employees : FrameworkUserBase
    {
        [Display(Name = "工龄")]
        [StringLength(3, ErrorMessage = "Validate.{0}stringmax{1}")]
        public string Elder { get; set; }

        [Display(Name = "年龄")]
        [StringLength(3, ErrorMessage = "Validate.{0}stringmax{1}")]
        public string Age { get; set; }

        [Display(Name = "_Admin.Email")]
        [RegularExpression("^[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+(\\.[a-zA-Z0-9_-]+)+$", ErrorMessage = "Validate.{0}formaterror")]
        [StringLength(50, ErrorMessage = "Validate.{0}stringmax{1}")]
        public string Email { get; set; }

        [Display(Name = "_Admin.Gender")]
        public GenderEnum? Gender { get; set; }

        [Display(Name = "_Admin.CellPhone")]
        [RegularExpression("^[1][3-9]\\d{9}$", ErrorMessage = "Validate.{0}formaterror")]
        public string CellPhone { get; set; }

        [Display(Name = "_Admin.HomePhone")]
        [StringLength(30, ErrorMessage = "Validate.{0}stringmax{1}")]
        [RegularExpression("^[-0-9\\s]{8,30}$", ErrorMessage = "Validate.{0}formaterror")]
        public string HomePhone { get; set; }

        [Display(Name = "_Admin.Address")]
        [StringLength(200, ErrorMessage = "Validate.{0}stringmax{1}")]
        public string Address { get; set; }

        [Display(Name = "_Admin.ZipCode")]
        [RegularExpression("^[0-9]{6,6}$", ErrorMessage = "Validate.{0}formaterror")]
        public string ZipCode { get; set; }

        [Display(Name = "工号")]
        [StringLength(12, ErrorMessage = "Validate.{0}stringmax{1}")]
        public string EID { get; set; }

        [Display(Name = "职务")]
        [StringLength(12, ErrorMessage = "Validate.{0}stringmax{1}")]
        public string jobs { get; set; }
    }
}
