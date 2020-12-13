using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaneCountyMentalHealth.Models
{
    public class FeedbackForum
    {
        [Key]
        public int FeedbackId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Date { get; set; }
        public string Feedback { get; set; }
    }
}
