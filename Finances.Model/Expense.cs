using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Finances.Model
{
    public class Expense
    {
        [Key]
        public Guid ID { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateIncurred { get; set; }
        public bool Required { get; set; }
    }
}
