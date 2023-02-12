using SOLID.ISP.With;

namespace SOLID.ISP.With
{
    public interface IContractWorkerSalary : IBaseWorker
    {
        float HourlyRate { get; set; }
        float HoursInMonth { get; set; }
        float CalculateWorkedSalary();
    }
}
