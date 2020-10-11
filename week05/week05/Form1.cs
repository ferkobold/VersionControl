using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week05
{
    public partial class Form1 : Form
    {
        PortfolioEntities context = new PortfolioEntities();
        /*A Form1 osztály szintjén példányosítsd az ORM objektumot!
         (Ha nem írtad át, akkor PortfolioEntities 
         néven kellett létrejöjjön.)*/
        List<Tick> Ticks;
        /*A Form1 osztály szintjén hozz létre egy Tick típusú elemekből
         álló listára mutató referenciát -- Ticks*/
        public Form1()
        {
            InitializeComponent();
            Ticks = context.Tick.ToList();
        /*A konstruktorban másold az adattáblát a memóriába.*/
            dataGridView1.DataSource = Ticks;
        /*Majd töltsd fel fele a DataGridViewt.*/
        }
    }
}
