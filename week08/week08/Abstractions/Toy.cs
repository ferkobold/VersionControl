using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week08.Abstractions;

namespace week08.Entities
{
    public abstract class Toy : Label
    {
        public Toy()
        {
            AutoSize = false;
            Width = 50;
            Height = Width;
            Paint += Toy_Paint;
        }
        //Milyen billentyűkombinációval lehet eseményt létrehozni? 
        // += és = között az a difi, hogy += így megváltoztatja
        private void Toy_Paint(object sender, PaintEventArgs e)
        {
            //DrawImage függvény
            //PaintEventArgs argumentumokból kérjük le az adott osztályhoz létrehozott
            //grafika példányt: e.Graphics
            DrawImage(e.Graphics);
        }

        protected abstract void DrawImage(Graphics g);

        public virtual void MoveToy()
        {
            Left += 1;
        }

    }
}
