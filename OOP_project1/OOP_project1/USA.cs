using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project1
{
    class USA
    {
        public string NameSurname { get; set; }
        public DateTime Birthday { get; set; }
        public string Language { get; set; }
        
        public int age     //method icine get ve set degeri atanır ya da direjt return kullanılabilir
        {
            get    
            {
                return DateTime.Today.Year - Birthday.Year;
            }
        }

    }
}
