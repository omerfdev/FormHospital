using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormHospital.Abstract
{
    public interface IHospital
    {
        string HospitalCount { get; set; }
        string HospitalName { get; set; }
        int DailyPatientCount { get; set; }
        int WorkerCount { get; set; }
        int BedServiceCount { get; set; }
        List<IDoctor> Doctors { get; set; }

    }
}
