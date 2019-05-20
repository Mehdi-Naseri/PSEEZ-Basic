using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseezBasic.UI.Models
{
    [DisplayName("شهر")]
    [Table("City", Schema = "SystemBase")]
    public class City
    {
        //public City()
        //{
        //    this.People = new HashSet<Person>();
        //    this.EmployeeAcademicalResumes = new HashSet<EmployeeAcademicalResume>();
        //    this.TimeTables = new HashSet<TimeTable>();
        //    this.TimeTables1 = new HashSet<TimeTable>();
        //}
        [Key]
        public long Id { get; set; }


        [Display(Name = "کد")]
        public string Code { get; set; }


        [Display(Name = "عنوان")]
        public string Name { get; set; }


        [Display(Name = "استان")]
        public long Province_Id { get; set; }

        [Display(Name = "اولویت")]
        public int Priority { get; set; }

        [ForeignKey("Province_Id")]
        public virtual Province Province { get; set; }

        //public virtual ICollection<TimeTable> TimeTables1 { get; set; }
        //public virtual ICollection<TimeTable> TimeTables { get; set; }
        //public virtual ICollection<EmployeeAcademicalResume> EmployeeAcademicalResumes { get; set; }

        //public virtual ICollection<Person> People { get; set; }
    }
}