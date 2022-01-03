using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBoardings.Core
{
    public class Boarding
    {
        public Guid Id { get; init; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:D2}")]
        [Range(0, 180, ErrorMessage = "Degrees must be within 1-180 only!!")]
        public int LatDeg { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:D2}")]
        [Range(0, 60, ErrorMessage = "Minutes must be within 0-60 only!!")]
        public int LatMin { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:D3}")]
        [Range(0, 180, ErrorMessage = "Degrees must be within 1-180 only!!")]
        public int LongDeg { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:D2}")]
        [Range(0, 60, ErrorMessage = "Minutes must be within 0-60 only!!")]
        public int LongMin { get; set; }

        //public string SeaArea { get; set; } //TODO : Write Logic to determine sea area from Lat/Long
        [Required]
        public DateTime BoardingTime { get; set; } = DateTime.Parse(DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
        [Required]
        public string Description { get; set; }
        public bool IsArrested { get; set; } = false;
    }
}
