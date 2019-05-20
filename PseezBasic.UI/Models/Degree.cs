using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseezBasic.UI.Models
{
    [DisplayName("مدرک تحصیلی")]
    [Table("Degree", Schema = "Employee")]
    public class Degree
    {
        //public DegreeState()
        //{
        //    this.EmployeeAcademicalResumes = new HashSet<EmployeeAcademicalResume>();
        //}
        [Key]
        public long Id { get; set; }

        [Display(Name = "سطح مدرک تحصیلی")]
        public string DegreeState_Id { get; set; }

        [Display(Name = "نوع مدرک تحصیلی")]
        public string DegreeType_Id { get; set; }

        [ForeignKey("DegreeState_Id")]
        public virtual ICollection<DegreeState> DegreeStates { get; set; }

        [ForeignKey("DegreeType_I")]
        public virtual ICollection<DegreeType> DegreeTypes { get; set; }
    }
}