using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseezBasic.UI.Models
{
    [Table("Religion", Schema = "Employee")]
    public class Religion
    {
        //public Religion()
        //{
        //    this.Employees = new HashSet<Employee>();
        //}
        [Key]
        public long Id { get; set; }

        [Display(Name = "عنوان")]
        public string Name { get; set; }

        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        //[Timestamp]
        //public byte[] TimeStamp { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}