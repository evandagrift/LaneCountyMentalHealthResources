using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace LaneCountyMentalHealth.Models
{
    public class HomeForum
    {
        [Key]
        public int SelectionId { get; set; }
        public string TeenYA { get; set; }
        public string FinancialMental { get; set; }
        public string GenderIdentity { get; set; }
    }
}
