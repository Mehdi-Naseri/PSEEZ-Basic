using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseezBasic.UI.Models
{
    [Table("EmployeeFamilialType", Schema = "Employee")]
    public class EmployeeFamilialType
    {
        [Key]
        public long Id { get; set; }

        public string Date { get; set; }
        public long Employee_Id { get; set; }
        public long FamilialType_Id { get; set; }

        //[Timestamp]
        //public byte[] TimeStamp { get; set; }

        [ForeignKey("Employee_Id")]
        public virtual Employee Employee { get; set; }

        [ForeignKey("FamilialType_Id")]
        public virtual FamilialType FamilialType { get; set; }
    }
}