using FormHospital.Concreate;
using FormHospital.Enum;
using System.Runtime.Serialization.Formatters.Binary;

namespace FormHospital
{
    public partial class MainHospitalForm : Form
    {

        public static Hospital hospital;
        public MainHospitalForm()
        {
            InitializeComponent();
            hospital = new Hospital()
            {
                HospitalName = "XXXXX XXXX",
                WorkerCount = 5000,
                DailyPatientCount = 10000,
                BedServiceCount = 150
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstHospitalDoctor.View = View.Details;
            lstHospitalDoctor.GridLines = true;
            lstHospitalDoctor.Columns.Add("Name", 100);
            lstHospitalDoctor.Columns.Add("Surname", 100);
            lstHospitalDoctor.Columns.Add("TurkishID", 100);
            lstHospitalDoctor.Columns.Add("Pay", 100);
            lstHospitalDoctor.Columns.Add("Age", 100);
            lstHospitalDoctor.Columns.Add("Daily Patient", 100);
            lstHospitalDoctor.Columns.Add("Expertise", 100);
            lstHospitalDoctor.Columns.Add("MonthlyVigilCount", 100);
            lstHospitalDoctor.Columns.Add("ExpertiseFields", 100);
            lstHospitalDoctor.Columns.Add("ExtraMoneyBank", 100);
        }

        public void buttonTest_Click(object sender, EventArgs e)
        {


            OrthopedicsDoctor oDoctor = new OrthopedicsDoctor()
            {
                Name = "Oxxxxx",
                Surname = "Axxxxx",
                MoneyPay = 34000,
                Age = 34,
                DailyPatientCount = 55,
                HumanGender = Gender.Men,
                Title = "prof",
                MontlyVigilCount = 60,
                ExpertiseField = "xxxxx",
                ExtraMoneyBank = 55000,
                TurkishID = "2xxxxxxxxxx",


            };
            OrthopedicsDoctor oDoctor1 = new OrthopedicsDoctor()
            {
                Name = "faruk",
                Surname = "ALxxxxx",
                MoneyPay = 34000,
                Age = 34,
                DailyPatientCount = 55,
                HumanGender = Gender.Men,
                Title = "prof",
                MontlyVigilCount = 60,
                ExpertiseField = "xxxxx",
                ExtraMoneyBank = 55000,
                TurkishID = "23xxxxxxxxxx",


            };
            OrthopedicsDoctor oDoctor2 = new OrthopedicsDoctor()
            {
                Name = "Rxxxxxxx",
                Surname = "ALxxxxxxxxxx",
                MoneyPay = 34000,
                Age = 34,
                DailyPatientCount = 55,
                HumanGender = Gender.Woman,
                Title = "prof",
                MontlyVigilCount = 60,
                ExpertiseField = "xxxx",
                ExtraMoneyBank = 55000,
                TurkishID = "2xxxxxxxxxx",


            };

            FileStream fs = new FileStream("temp.txt", FileMode.Create);
            BinaryFormatter binary = new BinaryFormatter();
            binary.Serialize(fs, oDoctor2);
            fs.Close();

            FileStream _fs = new FileStream("temp.txt", FileMode.Open);
            BinaryFormatter binary1 = new BinaryFormatter();
            OrthopedicsDoctor v = (OrthopedicsDoctor)binary1.Deserialize(_fs);
            MessageBox.Show($"XXXXX XXXX = {v.TurkishID}, XXXXX XXXX = {v.DailyPatientCount}");
            _fs.Close();
            hospital.Doctors.Add(oDoctor);
            hospital.Doctors.Add(oDoctor1);
            hospital.Doctors.Add(oDoctor2);
            foreach (var item in hospital.Doctors)
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
                lstHospitalDoctor.Items.Add(lstitem);
            }
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            Listele listele = new Listele();
            listele.Show();
        }

        private void buttonDoktorEkle_Click(object sender, EventArgs e)
        {
            AddDoctor doktorEkle = new AddDoctor();
            doktorEkle.Show();
        }
    }
}