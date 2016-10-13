using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooFlyerForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void uploadPics_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Properties.Settings.Default.WebServiceUrl);
            byte[] imageData;
            imageData = File.ReadAllBytes(pictureBox.ImageLocation);

            SqlCommand cmd = new SqlCommand("Insert into Images (Pics) values (@DATA)", connect);
            cmd.Parameters.Add("@DATA", imageData);
            MessageBox.Show("Your picture has been uploadet!");

            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        private void openImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Filter = "image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            fileChooser.InitialDirectory = "C:\\Brugere\\ålen\\Billeder\\ZooFlyer";
            fileChooser.Title = "Select Image For Upload";
            if (fileChooser.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = fileChooser.FileName;
            }
        }
    }
}
