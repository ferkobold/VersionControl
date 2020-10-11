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

            List<decimal> Nyereségek = new List<decimal>();
            int intervalum = 30;
            DateTime kezdőDátum = (from x in Ticks select x.TradingDay).Min();
            DateTime záróDátum = new DateTime(2016, 12, 30);
            TimeSpan z = záróDátum - kezdőDátum;
            for (int i = 0; i < z.Days - intervalum; i++)
            {
                decimal ny = GetPortfolioValue(kezdőDátum.AddDays(i + intervalum))
                            - GetPortfolioValue(kezdőDátum.AddDays(i));
                Nyereségek.Add(ny);
                Console.WriteLine(i + " " + ny);
            }
            var nyereségekRendezve = (from x in Nyereségek
                                      orderby x
                                      select x)
                                      .ToList();
            MessageBox.Show(nyereségekRendezve[nyereségekRendezve.Count() / 5].ToString());

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

        private decimal GetPortfolioValue(DateTime date)
        {
            decimal value = 0;
            foreach (var item in Portfolio)
            {
                var last = (from x in Ticks
                            where item.Index == x.Index.Trim()
                            && date <= x.TradingDay
                            select x)
                            .First();
                value += (decimal)last.Price * item.Volume;
            }
        /*Szóval feljebb megcsinálom a Portfoliot. Utána átmegyek az összes 
         elemén ennek a Portfolionak azzal a kódrészlettel, hogy
         foreach(var item in Portfolio), tehát itt az összes Portfolioban 
         szereplő ismeretlenre, amit itemnek neveztem el le fog futni a
         foreach alatti kódrészlet. */
            return value;
        }
    }
}
