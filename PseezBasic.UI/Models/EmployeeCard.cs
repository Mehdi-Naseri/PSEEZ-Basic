using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseezBasic.UI.Models
{
    [Table("EmployeeCard", Schema = "Employee")]
    public class EmployeeCard
    {
        //public FamilialType()
        //{
        //    this.EmployeeFamilialTypes = new HashSet<EmployeeFamilialType>();
        //}
        [Key]
        public long Id { get; set; }

        [Display(Name = "کد کارمندی")]
        public string Employee_Id { get; set; }


        [Display(Name = "تاریخ")]
        public string Date { get; set; }
        //[Timestamp]
        //public byte[] TimeStamp { get; set; }

        [Display(Name = "شماره کارت")]
        public string CardId { get; set; }

        [ForeignKey("Employee_Id")]
        public virtual Employee Employee { get; set; }
    }
}