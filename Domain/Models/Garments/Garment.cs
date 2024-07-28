using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Domain.Models.Garments
{
    public class Garment
    {
        public Garment() { }
        public Garment(string name, string description) 
        
        {
            Name = name;
            Description = description;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Operation> Operations { get; set; }
    }
}
