using FormHospital.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormHospital.Concreate
{
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
        }

        private void DoktorEkle_Load(object sender, EventArgs e)
        {
            comboBoxGender.Items.AddRange(System.Enum.GetNames(typeof(Gender)));
        }

        private void buttonDoktorEkle_Click(object sender, EventArgs e)
        {
            if (radioButtonOrtopedi.Checked)
            {
                OrthopedicsDoctor ortopediDoktor = new OrthopedicsDoctor()
                {
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    MoneyPay = double.Parse(textBoxPaycheck.Text),
                    TurkishID = textBoxTurkishID.Text,
                    MontlyVigilCount = int.Parse(textBoxMonthlyVigilCount.Text),
                    ExtraMoneyBank = double.Parse(textBoxExtraMoneyBank.Text),
                    Unit = Unit.Ortopedics,
                    DailyPatientCount = int.Parse(textBoxDailyPatientCount.Text),
                    Title = textBoxTitle.Text,
                    ExpertiseField = textBoxExpertiseField.Text,
                    Age = int.Parse(textBoxAge.Text),
                };
                ortopediDoktor.HumanGender = comboBoxGender.SelectedItem.ToString() == "Men" ? Gender.Men : Gender.Woman;
                MainHospitalForm.hospital.Doctors.Add(ortopediDoktor);
            }
            else if (radioButtonPsikiyatri.Checked)
            {
                PsychiatryDoctor psikiyatriDoktor = new PsychiatryDoctor()
                {
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    MoneyPay = double.Parse(textBoxPaycheck.Text),
                    TurkishID = textBoxTurkishID.Text,
                    MontlyVigilCount = int.Parse(textBoxMonthlyVigilCount.Text),
                    ExtraMoneyBank = double.Parse(textBoxExtraMoneyBank.Text),
                    Unit = Unit.Psychiatry,
                    DailyPatientCount = int.Parse(textBoxDailyPatientCount.Text),
                    Unvan = textBoxTitle.Text,
                    ExpertiseField = textBoxExpertiseField.Text,
                    Age = int.Parse(textBoxAge.Text),
                };
                psikiyatriDoktor.HumanGender = comboBoxGender.SelectedItem.ToString() == "Men" ? Gender.Men : Gender.Woman;
                MainHospitalForm.hospital.Doctors.Add(psikiyatriDoktor);

            }
        }


    }
}
