using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseezBasic.UI.Models
{
    [Table("EmployeeAcademicalResume", Schema = "Employee")]
    public class EmployeeAcademicalResume
    {
        [Key]
        public long Id { get; set; }

        public long Employee_Id { get; set; }
        public string EntryYear { get; set; }
        public string GraduatedYear { get; set; }
        public long DegreeState_Id { get; set; }
        public long? AcademicalField_Id { get; set; }
        public long? School_Id { get; set; }
        public long? City_Id { get; set; }
        public double? Grade { get; set; }
        public long? ProofState_Id { get; set; }
        public string Description { get; set; }

        //[Timestamp]
        //public byte[] TimeStamp { get; set; }

        [ForeignKey("City_Id")]
        public virtual City City { get; set; }

        [ForeignKey("DegreeState_Id")]
        public virtual DegreeState DegreeState { get; set; }

        [ForeignKey("Employee_Id")]
        public virtual Employee Employee { get; set; }
    }
}