using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_FileReader
{
    public class User
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string InfoUser
        {
            get => FirstName + " " + MiddleName + " " + LastName + ", Возраст - " + Age + " Зарплата = " + Salary + "p.";
            set { }
        }
    }
}
