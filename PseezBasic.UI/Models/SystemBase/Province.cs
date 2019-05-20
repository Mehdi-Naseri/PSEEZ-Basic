using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseezBasic.UI.Models
{
    [Table("Province", Schema = "SystemBase")]
    public class Province
    {
        //public Province()
        //{
        //    this.Cities = new HashSet<City>();
        //}
        [Key]
        public long Id { get; set; }


        [Display(Name = "کد")]
        public string Code { get; set; }


        [Display(Name = "نام")]
        public string Name { get; set; }


        [Display(Name = "کشور")]
        public long Country_Id { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}