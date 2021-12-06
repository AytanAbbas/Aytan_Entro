using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Models
{
    public class GalleryImage

        {[Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        [ForeignKey("Gallery")]
        public int GalleryId { get; set; }
        public Gallery Gallery { get; set; }




    }
}
