using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcore.Models
{
    public class Product
    {
        [Key]
        [Column(TypeName = "char(20)")]
        public string SId { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public bool Enabled { get; set; }
        [Required]
        [Column(TypeName = "char(14)")]
        public string Cdt { get; set; }
        [Required]
        [Column(TypeName = "char(14)")]
        public string Mdt { get; set; }
    }
}
