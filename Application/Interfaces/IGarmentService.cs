using Domain.Models.Garments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGarmentService
    {
        public Garment Add(Garment garment);
    }
}
