using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHub.DAL.Entities
{
    public class Temperature
    {
        public int Id { get; set; }
        public float Degrees { get; set; }
        public float Farenheit { get; set; }
    }
}
