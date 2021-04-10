using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project1
{
    class TC
    {
        public long IdNum { get; set; }  //property
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime SystemLogin { get; set; }

        public TC()  //constructor
        {
            SystemLogin = DateTime.Now;
        }

        public string visa()
        {
            int age = AgeCalculate(Birthday);
            if(age >= 18)
            {
                return "You can apply";
            }
            else
            {
                return "You need permission";
            }
        }

        private int AgeCalculate(DateTime birthday)
        {
            return DateTime.Today.Year - birthday.Year;
        }
    }

}
