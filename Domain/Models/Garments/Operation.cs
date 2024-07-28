using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.Garments
{
    public class Operation
    {
        public Operation() { }
        public Operation(string name, string description, decimal timeallowed) 
        {
            Name = name;
            Description = description;
            TimeAllowed = timeallowed;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public decimal TimeAllowed { get; set; }
        
        [ForeignKey("GarmentId")]
        public int GarmentId { get; set; }
        public Garment Garment { get; set; }

    }
}
