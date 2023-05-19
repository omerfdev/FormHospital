using FormHospital.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormHospital.Abstract
{
    public interface IHuman
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TurkishID { get; set; }
        public int Age { get; set; }
        Gender HumanGender { get; set; }
    }
}
