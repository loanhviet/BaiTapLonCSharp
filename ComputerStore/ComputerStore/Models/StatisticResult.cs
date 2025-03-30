using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Models
{
    public class StatisticResult
    {
        public StatisticResult()
        {
        }

        public StatisticResult(string label, decimal totalRevenue)
        {
            Label = label;
            TotalRevenue = totalRevenue;
        }

        public string Label { get; set; }
        public decimal TotalRevenue { get; set; }
    }
}
