using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week08.Entities;
using week08.Abstractions;

namespace week08
{
    public partial class Form1 : Form
    {
        private Toy _nextToy;

        List<Toy> _toys = new List<Toy>();

        //Hozz létre egy BallFactory típusú kifejtett propertyt is Factory néven. 
        private IToyFactory _factory;
        public IToyFactory Factory
        {
            get { return _factory; }
            set { _factory = value;
                DisplayNext();
            }
        }

        public Form1()
        {
            InitializeComponent();
            Factory = new CarFactory();
            mainPanel.Width = this.Size.Width;
            mainPanel.Height = this.Size.Height;
            mainPanel.Left = 0;
            mainPanel.Top = 0;
        }

        private void CreateTimer_Tick(object sender, EventArgs e)
        {
            var toy = Factory.CreateNew();
            _toys.Add(toy);
            toy.Left = -toy.Width;
            mainPanel.Controls.Add(toy);
        }

        private void ConveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var toy in _toys)
            {
                toy.MoveToy();
                if (toy.Left > maxPosition)
                    maxPosition = toy.Left;
            }

            if (maxPosition > 1000)
            {
                var oldestToy = _toys[0];
                mainPanel.Controls.Remove(oldestToy);
                _toys.Remove(oldestToy);
            }
            
        }

        private void BtnSelectCar_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void BtnSelectBall_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory
            {
                BallColor = btnColor.BackColor
            };
        }

        private void DisplayNext()
        {
            if (_nextToy != null)
                Controls.Remove(_nextToy);
            _nextToy = Factory.CreateNew();
            _nextToy.Top = labelNext.Top + labelNext.Height + 30;
            _nextToy.Left = labelNext.Left;
            Controls.Add(_nextToy);
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var ColorPicker = new ColorDialog();

            ColorPicker.Color = button.BackColor;
            if (ColorPicker.ShowDialog() != DialogResult.OK)
                return;
            button.BackColor = ColorPicker.Color;
        }
    }
}
