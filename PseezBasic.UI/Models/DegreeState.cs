using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseezBasic.UI.Models
{
    [DisplayName("سطح مدرک تحصیلی")]
    [Table("DegreeState", Schema = "Employee")]
    public class DegreeState
    {
        //public DegreeState()
        //{
        //    this.EmployeeAcademicalResumes = new HashSet<EmployeeAcademicalResume>();
        //}
        [Key]
        public long Id { get; set; }

        [Display(Name = "عنوان")]
        public string Title { get; set; }

        [Display(Name = "توضیحات")]
        public string Describer { get; set; }

    }
}