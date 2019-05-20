using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseezBasic.UI.Models
{
    [Table("FamilialType", Schema = "Employee")]
    public class FamilialType
    {
        //public FamilialType()
        //{
        //    this.EmployeeFamilialTypes = new HashSet<EmployeeFamilialType>();
        //}
        [Key]
        public long Id { get; set; }

        [Display(Name = "عنوان")]
        public string Title { get; set; }

        //[Timestamp]
        //public byte[] TimeStamp { get; set; }

        [Display(Name = "توضیحات")]
        public string Describer { get; set; }

        public virtual ICollection<EmployeeFamilialType> EmployeeFamilialTypes { get; set; }
    }
}