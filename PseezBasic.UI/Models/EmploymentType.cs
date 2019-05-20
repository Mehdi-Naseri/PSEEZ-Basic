using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseezBasic.UI.Models
{
    [Table("EmploymentType", Schema = "Employee")]
    public partial class EmploymentType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Display(Name = "کد")]
        public string Code { get; set; }

        [Display(Name = "نام")]
        public string Name { get; set; }

        [Display(Name = "کد وضعیت استخدام")]
        public long EmploymentState_Id { get; set; }

        [Display(Name = "فعال")]
        public bool IsActive { get; set; }
    }
}
