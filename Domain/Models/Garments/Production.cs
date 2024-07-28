using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Garments
{
    public class Production
    {
        public Production() { }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("GarmentId")]
        public int GarmentId { get; set; } 
        public Garment Garment { get; set; }

    }
}

