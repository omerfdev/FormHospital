using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormHospital.Abstract
{
    public interface IDoctor:IHuman,IWorker,IExtraPayMoney
    {
        public int DailyPatientCount { get; set; }
        public int MonthlyVigilCount { get; set; }
        string ExpertiseField { get; set; }

        void DoOperations();
        void DoCheckPatient();
    }
}
