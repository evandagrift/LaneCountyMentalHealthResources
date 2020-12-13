using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaneCountyMentalHealth.Models
{
    public class Link
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Catagory { get; set; }
        public string SubCatagory { get; set; }
        public string AdditionalNote { get; set; }

    }
}
