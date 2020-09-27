using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            labFullName.Text = Resource1.FullName; 
            btnAdd.Text = Resource1.Add;
            btnSave.Text = Resource1.Save;

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";

            var u = new User()
            {
                FullName = textBFullName.Text
            };
            users.Add(u);
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream stream = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(stream);
                sw.Write(textBFullName.Text);
                sw.Close();
            }
        }
    }
}
