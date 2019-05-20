using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseezBasic.UI.Models
{
    [DisplayName("نوع مدرک تحصیلی")]
    [Table("DegreeType", Schema = "Employee")]
    public class DegreeType
    {
        //public DegreeState()
        //{
        //    this.EmployeeAcademicalResumes = new HashSet<EmployeeAcademicalResume>();
        //}
        [Key]
        public long Id { get; set; }

        [Display(Name = "عنوان")]
        public string Title { get; set; }


    }
}