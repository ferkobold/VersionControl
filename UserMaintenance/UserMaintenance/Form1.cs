using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities; //ezt a névteret be kellett hivatkozni, hogy megtalálja a User classt

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            labLastName.Text = Resource1.LastName; //a lastname labelnek az lesz a neve, amit a resx fileba megadtam a LastName stringnek valueként
            labFirstName.Text = Resource1.FirstName;
            btnAdd.Text = Resource1.Add;

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";

            var u = new User()
            {
                LastName = textBLastName.Text,
                FirstName = textBFirstName.Text
            };
            users.Add(u);
        }
    }
}
