using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week07.Entities;


/*Enumeráció: olyan típus, amely meghatározott értékek névvel ellátott
 halmazát képviseli. Felsorolt típust az enum kulcsszo segítségével
 deklarálunk. Az enumeráció osztályhoz hasonló elem, ezért az osztályokkal
 egy szinten érdemes deklarálni.*/
namespace week07
{
    public partial class Form1 : Form
    {
        List<Person> Population = new List<Person>();
        List<BirthProbability> BirthProbabilities = new List<BirthProbability>();
        List<DeathProbability> DeathProbabilities = new List<DeathProbability>();
        public Form1()
        {
            InitializeComponent();
        }
    }
}
