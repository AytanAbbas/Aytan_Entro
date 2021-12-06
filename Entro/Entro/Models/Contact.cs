using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Models
{
    public class Contact
    {[Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        [Column(TypeName ="ntext")]
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
