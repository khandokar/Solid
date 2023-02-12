using SOLID.ISP.With;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.With
{
    public class ContractEmployeeFixed : IContractWorkerSalary
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float HourlyRate { get; set; }
        public float HoursInMonth { get; set; }
        public float CalculateWorkedSalary() => HourlyRate * HoursInMonth;
    }
}
