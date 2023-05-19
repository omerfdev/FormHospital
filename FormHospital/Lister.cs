using FormHospital.Concreate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormHospital
{
    public partial class Listele : Form
    {
        public Listele()
        {
            InitializeComponent();
        }

        private void Listele_Load(object sender, EventArgs e)
        {

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("Name", 100);
            listView1.Columns.Add("Surname", 100);
            listView1.Columns.Add("TurkishID", 100);
            listView1.Columns.Add("MAAŞ", 100);
            listView1.Columns.Add("YAŞ", 100);
            listView1.Columns.Add("GÜNLÜK HASTA SAYISI", 100);
            listView1.Columns.Add("UNVAN", 100);
            listView1.Columns.Add("AYLIK NÖBET SAYISI", 100);
            listView1.Columns.Add("UZMANLIK ALANI", 100);
            listView1.Columns.Add("DÖNER SERMAYE PARASI", 100);

            foreach (var item in MainHospitalForm.hospital.Doctors)
            {
                ListViewItem lstitem = new ListViewItem();
                lstitem.Text = item.Name;
                lstitem.SubItems.Add(item.Surname);
                lstitem.SubItems.Add(item.TurkishID);
                lstitem.SubItems.Add(item.MoneyPay.ToString());
                lstitem.SubItems.Add(item.Age.ToString());
                lstitem.SubItems.Add(item.HumanGender.ToString());
                lstitem.SubItems.Add(item.DailyPatientCount.ToString());
                lstitem.SubItems.Add(item.Title);
                lstitem.SubItems.Add(item.MonthlyVigilCount.ToString());
                lstitem.SubItems.Add(item.ExpertiseField);
                lstitem.SubItems.Add(item.ExtraMoneyBank.ToString());
                listView1.Items.Add(lstitem);
            }
        }
    }
}
