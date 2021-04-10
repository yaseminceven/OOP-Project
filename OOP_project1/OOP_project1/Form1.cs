using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TC person1 = new TC();
            person1.Birthday = Convert.ToDateTime("1990-05-05");
            MessageBox.Show(person1.visa());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            USA per2 = new USA();
            per2.NameSurname = "Micheal Ravellio";
            per2.Language = "English";
            per2.Birthday = Convert.ToDateTime("1980-07-12");
            MessageBox.Show(per2.age.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            People person1 = new People(); //class People newlenir
            person1.Name = "Duygu Bal";
            person1.CanliMi = false;

            People person2 = new People();
            person2.Name = "Nermine Kal";
            person2.CanliMi = true;

            People person3 = new People("Mahmut Gül");
            People person4 = new People("Caner Gül");
            People person5 = new People()
            {
                Name = "Erkan Canlık", CanliMi = true
            };

            MessageBox.Show(person2.NamePrint());               //console.writeline komutunun formda karşılığı
            MessageBox.Show(People.Welcome());
        }
    }
}
