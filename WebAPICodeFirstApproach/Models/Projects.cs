using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICodeFirstApproach.Models
{
    public class Projects
    {
        [Key]

        public int Pid { get; set; }
        [Required]

        [Column(TypeName = "nvarchar(50)")]
        public string Pname { get; set; }
        [Required]

        [Column(TypeName = "nvarchar(200)")]
        public string Pdesc { get; set; }

    }
}
