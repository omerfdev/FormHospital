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
            comboBoxCinsiyet.Items.AddRange(System.Enum.GetNames(typeof(Gender)));
        }

        private void buttonDoktorEkle_Click(object sender, EventArgs e)
        {
            if (radioButtonOrtopedi.Checked)
            {
                OrthopedicsDoctor ortopediDoktor = new OrthopedicsDoctor()
                {
                    Name = textBoxAd.Text,
                    Surname = textBoxSoyad.Text,
                    MoneyPay = double.Parse(textBoxMaas.Text),
                    TurkishID = textBoxTC.Text,
                    MontlyVigilCount = int.Parse(textBoxAylikNobetSayisi.Text),
                    ExtraMoneyBank = double.Parse(textBoxDonerSermaye.Text),
                    Unit = Unit.Ortopedics,
                    DailyPatientCount = int.Parse(textBoxGunlukHastaSayisi.Text),
                    Title = textBoxUnvan.Text,
                    ExpertiseField = textBoxUzmanlikAlani.Text,
                    Age = int.Parse(textBoxYas.Text),
                };
                ortopediDoktor.HumanGender = comboBoxCinsiyet.SelectedItem.ToString() == "Men" ? Gender.Men : Gender.Woman;
                MainHospitalForm.hospital.Doctors.Add(ortopediDoktor);
            }
            else if (radioButtonPsikiyatri.Checked)
            {
                PsychiatryDoctor psikiyatriDoktor = new PsychiatryDoctor()
                {
                    Name = textBoxAd.Text,
                    Surname = textBoxSoyad.Text,
                    MoneyPay = double.Parse(textBoxMaas.Text),
                    TurkishID = textBoxTC.Text,
                    MontlyVigilCount = int.Parse(textBoxAylikNobetSayisi.Text),
                    ExtraMoneyBank = double.Parse(textBoxDonerSermaye.Text),
                    Unit = Unit.Psychiatry,
                    DailyPatientCount = int.Parse(textBoxGunlukHastaSayisi.Text),
                    Unvan = textBoxUnvan.Text,
                    ExpertiseField = textBoxUzmanlikAlani.Text,
                    Age = int.Parse(textBoxYas.Text),
                };
                psikiyatriDoktor.HumanGender = comboBoxCinsiyet.SelectedItem.ToString() == "Men" ? Gender.Men : Gender.Woman;
                MainHospitalForm.hospital.Doctors.Add(psikiyatriDoktor);

            }
        }


    }
}
