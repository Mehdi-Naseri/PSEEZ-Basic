using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseezBasic.UI.Models
{
    [Table("DurationType", Schema = "SystemBase")]
    public class DurationType
    {
        [Key]
        public long Id { get; set; }

        [Display(Name = "عنوان")]
        public string Title { get; set; }

    }
}