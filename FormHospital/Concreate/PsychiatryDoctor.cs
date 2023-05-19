using FormHospital.Abstract;
using FormHospital.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormHospital.Concreate
{
    [Serializable]
    public class PsychiatryDoctor : IDoctor
    {
        public int DailyPatientCount { get; set; }
        public int MontlyVigilCount { get; set; }
        public string ExpertiseField { get ; set ; }
        public string Name { get ; set ; }
        public string Surname { get ; set ; }
        public string TurkishID { get ; set ; }
        public int Age { get; set; }
        public Gender HumanGender { get; set; }
        private double _payMoney;
        public double MoneyPay
        {
            get { return _payMoney; }
            set
            {
                if (_payMoney < 20000)
                {
                    _payMoney = 23000;
                }
                else
                {
                    _payMoney = value;
                }
            }
        }
        public string Unvan { get; set; }
        private Unit _units;
        public Unit Unit 
        {
            get { return _units; }
            set
            {
                if (value != Unit.Psychiatry) { value = Unit.Psychiatry; }
                else
                {
                    _units = value;
                }
            }
        }
        public double ExtraMoneyBank { get; set; }
        string IWorker.Title { get; set; }
        public int MonthlyVigilCount { get ; set; }
        public Unit Units { get ; set ; }

        public void DoOperations()
        {
            MessageBox.Show("xxxxxxxxxxxxxxxxxxxxx");
        }

        public void DoCheckPatient()
        {
            MessageBox.Show("xxxxxxxxxxxxxxxxxxxxx");
        }

        public void TakeMoney()
        {
            MessageBox.Show($"xxxxxxxxxxxxxxxxxxxxx{ExtraMoneyBank}  xxxxxxxxxxxxxxxxxxxxx{_payMoney + ExtraMoneyBank*1.1}");
        }
    }
}
