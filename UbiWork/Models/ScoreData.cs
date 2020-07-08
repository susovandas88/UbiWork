using System;
using System.ComponentModel.DataAnnotations;

namespace UbiWork.Models
{
    public class ScoreData
    {
        [Key]
        public int ScoreId { get; set; }
        public double Score { get; set; }
    }
}
