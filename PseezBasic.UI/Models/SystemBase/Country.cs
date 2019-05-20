using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseezBasic.UI.Models
{
    [Table("Country", Schema = "SystemBase")]
    public class Country
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
        public string Title { get; set; }


        [Display(Name = "کد کشور")]
        public string CountryCode { get; set; }


    }
}