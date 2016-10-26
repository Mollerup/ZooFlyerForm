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
using ZooFlyerForm.Models;
using Image = ZooFlyerForm.Models.Image;

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
            var imageData = File.ReadAllBytes(pictureBox.ImageLocation);

            SqlCommand cmd = new SqlCommand("Insert into Images (Pics) values (@DATA)", connect);
            cmd.Parameters.AddWithValue("@DATA", imageData);
            MessageBox.Show("Your picture has been uploaded!");

            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        private void openImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Filter = "image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            fileChooser.InitialDirectory = "C:\\Brugere";
            fileChooser.Title = "Select Image For Upload";
            if (fileChooser.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = fileChooser.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ms = new MemoryStream(WebserviceHelper.GetImage(3).Pics))
            {
                pictureBox.Image = System.Drawing.Image.FromStream(ms);
            }
        }
    }
}
