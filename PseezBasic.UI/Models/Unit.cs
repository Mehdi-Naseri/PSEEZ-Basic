using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseezBasic.UI.Models
{
    [DisplayName("واحد سازمانی")]
    [Table("Unit", Schema = "Employee")]
    public class Unit
    {
        //public Unit()
        //{
        //    this.Unit1 = new HashSet<Unit>();
        //}
        [Key]
        public long Id { get; set; }

        [Display(Name = "کد")]
        public string Code { get; set; }

        [Display(Name = "نام")]
        public string Name { get; set; }

        [Display(Name = "واحد بالاسرس")]
        public long? Unit_Parent_Id { get; set; }

        //[Timestamp]
        //public byte[] TimeStamp { get; set; }

        [Display(Name = "مدیریت؟")]
        public bool IsManagement { get; set; }

        [Display(Name = "نمایش داده شود؟")]
        public bool? Show { get; set; }

        public virtual ICollection<Unit> Unit1 { get; set; }

        [ForeignKey("Unit_Parent_Id")]
        public virtual Unit Unit2 { get; set; }
    }
}