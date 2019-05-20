using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseezBasic.UI.Models
{
    [Table("BloodType", Schema = "Employee")]
    public class BloodType
    {

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Required]
        //public long Id { get; set; }
        public long Id { get; set; }

        [Display(Name = "عنوان")]
        public string Title { get; set; }


        public virtual ICollection<Employee> Employees { get; set; }
    }
}