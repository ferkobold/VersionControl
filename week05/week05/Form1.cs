using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week05.Entities;

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
        List<PortfolioItem> Portfolio = new List<PortfolioItem>();
        /*using week05.Entities ez nagyon fontos, hogy használjuk azt
         a névteret, ahol az új osztályunk van.
         Hozz létre egy PortfolioItem típusú elemekből álló 
         Portfolio nevű listát a Form1 szintjén.*/
        public Form1()
        {
            InitializeComponent();
            Ticks = context.Tick.ToList();
        /*A konstruktorban másold az adattáblát a memóriába.*/
            dataGridView1.DataSource = Ticks;
            /*Majd töltsd fel fele a DataGridViewt.*/
            CreatePortfolio();
        /*Hívd meg a CreatePortfolio függvényt a Form1 konstruktorában.*/
           
        }
        
        private void CreatePortfolio()
        /*Hozz létre egy függvényt CreatePortfolio néven.*/
        {
            Portfolio.Add(new PortfolioItem() { Index = "OTP", Volume = 10 });
            Portfolio.Add(new PortfolioItem() { Index = "ZWACK", Volume = 10 });
            Portfolio.Add(new PortfolioItem() { Index = "ELMU", Volume = 10 });
        /*Vedd fel a három részvényt a Portfolio listába*/
        /*  PortfolioItem p = new PortfolioItem();
            p.Index = "OTP";
            p.Volume = 10;
            Portfolio.Add(p);
        Ennek a kódnak felel meg a fenti sorok mindegyike*/

            dataGridView2.DataSource = Portfolio;
        /*Jelenítds meg a Portfóliódat az új dataGridViewban*/
        }

    }
}
