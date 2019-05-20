using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseezBasic.UI.Models
{
    [Table("Person", Schema = "Base")]
    public class Person
    {
        [Key]
        public long Id { get; set; }

        [Display(Name = "نام")]
        public string Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        public string Family { get; set; }

        [Display(Name = "نام پدر")]
        public string FatherName { get; set; }

        [Display(Name = "تاریخ تولد")]
        public string BirthDate { get; set; }

        [Display(Name = "کد شهر")]
        public long? City_Id { get; set; }

        [Display(Name = "کد شناسایی")]
        public string IdNumber { get; set; }

        [Display(Name = "کد ملی")]
        public string NationalCode { get; set; }

        [Display(Name = "جنسیت")]
        public long Gender_Id { get; set; }


        [Display(Name = "موبایل")]
        public string Mobile { get; set; }

        [ForeignKey("City_Id")]
        public virtual City City { get; set; }

        [ForeignKey("Gender_Id")]
        public virtual Gender Gender { get; set; }

        //[ForeignKey("Id")]
        //public virtual Employee Employee { get; set; }
    }
}