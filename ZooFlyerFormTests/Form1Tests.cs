using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZooFlyerForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ZooFlyerForm.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestInitialize]
        public void CreateTextBox()
        {
            TextBox user = new TextBox();
            user.Text = "admin";
            TextBox pass = new TextBox();
            pass.Text = "admin";
        }


        [TestMethod()]
        public void LoginBtn_ClickTest()
        {

        }
    }
}