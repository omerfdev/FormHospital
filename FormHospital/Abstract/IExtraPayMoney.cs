using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormHospital.Abstract
{
    public interface IExtraPayMoney
    {
        public double ExtraMoneyBank { get; set; }
        void TakeMoney();
    }
}
