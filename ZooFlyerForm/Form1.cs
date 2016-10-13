using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooFlyerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void usernameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
                passwordBox.Focus();
        }

        private void passwordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
                LoginBtn.PerformClick();
        }

        public void LoginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameBox.Text))
            {
                MessageBox.Show("Please enter your username or password correct", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                usernameBox.Focus();
                return;
            }
            try
            {
                using (masterEntities mastEnt = new masterEntities())
                {
                    var query = from o in mastEnt.Users
                        where o.Email == usernameBox.Text && o.Password == passwordBox.Text
                        select o;
                    if (query.SingleOrDefault() != null)
                    {
                        MessageBox.Show("You have succesfully logged in", "Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Hide();
                        Main ss = new Main();
                        ss.Show();
                    }
                    else
                    {
                        MessageBox.Show("Your username or password is incorrect", "Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
