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
    public class Ball : Toy
    {
        public SolidBrush BallColor { get; private set; }

        public Ball(Color color)
        {
            BallColor = new SolidBrush(color);
        }
        public Ball()
        {
            AutoSize = false;
            Width = 50;
            Height = Width;
            Paint += Ball_Paint;
        }
        //Milyen billentyűkombinációval lehet eseményt létrehozni? 
        // += és = között az a difi, hogy += így megváltoztatja
        private void Ball_Paint(object sender, PaintEventArgs e)
        {
            //DrawImage függvény
            //PaintEventArgs argumentumokból kérjük le az adott osztályhoz létrehozott
            //grafika példányt: e.Graphics
            DrawImage(e.Graphics);
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillEllipse(BallColor, 0, 0, Width, Height);
        }

        public void MoveBall()
        {
            Left += 1;
        }
            
    }
}
