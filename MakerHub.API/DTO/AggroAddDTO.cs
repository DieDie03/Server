using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHub.API.DTO
{
    public class AggroAddDTO
    {
        [Required]
        public float Humidity { get; set; }
        [Required]
        public string Test { get; set; }
    }
}
