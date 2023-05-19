using FormHospital.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormHospital.Concreate
{
    public class Hospital : IHospital
    {
        public Hospital()
        {
            Doctors = new List<IDoctor>();
        }
        public string HospitalName { get; set; }
       
        public int WorkerCount { get; set; }
        public int BedServiceCount { get; set; }
        public List<IDoctor> Doctors { get; set; }
        public string HospitalCount { get; set ; }
        public int DailyPatientCount { get ; set ; }
    }
}
