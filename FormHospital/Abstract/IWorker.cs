using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormHospital.Abstract
{
    public interface IWorker
    {
        public double MoneyPay { get; set; }
        public string Title { get; set; }
        Unit Units { get; set; }   
    }
}
