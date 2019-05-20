using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseezBasic.UI.Models
{
    [DisplayName("شهر")]
    [Table("Gender", Schema = "SystemBase")]
    public class Gender
    {
        //public Gender()
        //{
        //    this.People = new HashSet<Person>();
        //}
        [Key]
        public long Id { get; set; }

        [Display(Name = "عنوان")]
        public string Title { get; set; }

        //public virtual ICollection<Person> People { get; set; }
    }
}