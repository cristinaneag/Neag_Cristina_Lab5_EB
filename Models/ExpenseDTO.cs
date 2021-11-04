using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neag_Cristina_Lab5_EB.Models
{
    public class ExpenseDTO
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
