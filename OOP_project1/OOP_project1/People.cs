using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project1
{
    class People
    {
        public string Name { get; set; }  //property tanımlama(prop)
        public bool CanliMi { get; set; }


        public People()             //constructor tanımlama(ctor)
        {
            CanliMi = true;
        }

        public People(string adSoyad)
        {
            Name = adSoyad;
            CanliMi = true;
        }

        public static string Welcome()   //nesneye özel statik metod tanımlama, statik olunca heryerden çagırılabilir newlenmez
        {
            return "Welcome";
        }

        public string NamePrint()
        {
            return "My name is" + " " +Name;
        } 
    }
}
