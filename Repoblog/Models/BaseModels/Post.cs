using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Repoblog.Models.BaseModels
{
    public class Post
    {
        public int ID { get; set; }
        [Required]
        public string Overskrift { get; set; }
        [Required]
        public string Tekst { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Dato { get; set; }
        [Required]
        public string Forfatter { get; set; }


    }
}
