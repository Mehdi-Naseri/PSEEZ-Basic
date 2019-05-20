using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseezBasic.UI.Models
{
    [Table("AcademicalResume", Schema = "Employee")]
    public class AcademicalResume
    {
        [Key]
        public long Id { get; set; }

        public long Employee_Id { get; set; }
        public string Name { get; set; }
        public int DegreeType_Id { get; set; }

        [ForeignKey("DegreeType_Id")]
        public virtual DegreeState DegreeType_Id { get; set; }

    }
}