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
    internal class OrthopedicsDoctor : IDoctor
    {
        public int DailyPatientCount { get ; set ; }
        public int MontlyVigilCount { get; set ; }
        public string ExpertiseField { get; set ; }
        public string Name { get ; set ; }
        public string Surname { get; set ; }
        public string TurkishID { get ; set ; }
        public int Age { get ; set ; }
        public Gender HumanGender { get; set; }
        private double _payMoney;
        public double MoneyPay
        {
            get { return _payMoney; }
            set
            {
                if (_payMoney < 20000)
                {
                    _payMoney = 25000;
                }
                else
                {
                    _payMoney=value;
                }
            }
        }
        public string Title { get; set; }
        private Unit _units;
        public Unit Unit
        {
            get { return _units; }
            set
            {
                if (value != Unit.Ortopedics) { value = Unit.Ortopedics; }
                else
                {
                    _units = value;
                }
            }
        }
        public double ExtraMoneyBank { get; set; }
        public int MonthlyVigilCount { get ; set ; }
        public Unit Units { get ; set; }

        public void DoOperations()
        {
            MessageBox.Show("Test");
        }

        public void DoCheckPatient()
        {
            DialogResult dialogResult = MessageBox.Show("xxxx xxxx?", "xxxx", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                MessageBox.Show("xxxxx xxxxxx xxxxx");
            }
            else
            {
                MessageBox.Show("xxxxx xxxxxx xxxxx");
            }
        }

        public void TakeMoney()
        {
            MessageBox.Show($"xxxxx xxxxxx xxxxx{ExtraMoneyBank}  xxxxx xxxxxx xxxxx{_payMoney + ExtraMoneyBank}");
        }
    }
}
