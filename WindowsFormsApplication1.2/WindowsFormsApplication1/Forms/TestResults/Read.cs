using FuaClinic.Business.Managers;
using FuaClinic.Business.Managers.ManagerInterfaces;
using FuaClinic.Business.Models;
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

namespace WindowsFormsApplication1.Forms.TestResults
{
    public partial class Read : Form
    {

        ITestResultManager testResultManager;
        TestResult testResult;

        public Read(TestResult testResult, ITestResultManager testResultManager)
        {
            InitializeComponent();
            this.testResult = testResult;
            this.testResultManager = testResultManager;
        }

        public Image ConvertBinaryToImage(byte[] binary)
        {
            var ms = new MemoryStream(binary);
            return Image.FromStream(ms);
        }

        private void TestResults_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = ConvertBinaryToImage(testResult.Image);
        }
    }
}