﻿using FuaClinic.Business.Managers;
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
    public partial class TestResults : Form
    {

        TestResultManager testResultManager = new TestResultManager();
        Appointment appointment;

        public TestResults(Appointment appointment)
        {
            InitializeComponent();
            this.appointment = appointment;
        }

        private void ListViewImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewImages.SelectedItems.Count > 0)
            {
                    var testResult = (TestResult)listViewImages.SelectedItems[0].Tag;
                    pictureBox2.Image = ConvertBinaryToImage(testResult.Image);
                    pictureBox1.Image = ConvertBinaryToImage(testResult.Image);
                    txtName.Text = testResult.Name;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var testResult = new TestResult
            {
                AppointmentId = appointment.Id,
                Name = txtName.Text,
                Image = ConvertImageToBinary(pictureBox1.Image)
            };

            if (testResultManager.Add(testResult) > 0)
            {
                MessageBox.Show("Added successfully.");
                pictureBox1.Image = null;
                FillListViewTestResultsByAppointmentId();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateTestResult();
            FillListViewTestResultsByAppointmentId();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteTestResult();
            FillListViewTestResultsByAppointmentId();
        }


        public Image ConvertBinaryToImage(byte[] binary)
        {
            var ms = new MemoryStream(binary);
            return Image.FromStream(ms);
        }

        private void BtnChooseFile_Click(object sender, EventArgs e)
        {
            // Change variable name
            var openFileDialogue = new OpenFileDialog();
            openFileDialogue.InitialDirectory = "C:\\";
            openFileDialogue.Filter = "Image Files (*.jpg)|*.jpg|All Files(*.*)|*.*";
            openFileDialogue.FilterIndex = 1;

            if (openFileDialogue.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialogue.FileName;
                pictureBox1.Image = Image.FromFile(fileName);
            }
        }

        public byte[] ConvertImageToBinary(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

       
        public void FillListViewTestResultsByAppointmentId()
        {
            listViewImages.Items.Clear();
            var testResults = testResultManager.GetWithWhereCondition<TestResult>($"AppointmentId = {appointment.Id}");
            if (testResults != null)
            {
                foreach (var testResult in testResults)
                {
                    var row = new string[] { testResult.Name };
                    var listViewItem = new ListViewItem(row);
                    listViewItem.Tag = testResult;
                    listViewImages.Items.Add(listViewItem);
                }
            }
        }

        private void TestResults_Load(object sender, EventArgs e)
        {
            FillListViewTestResultsByAppointmentId();
        }

        public void UpdateTestResult()
        {
            if (listViewImages.SelectedItems.Count > 0)
            {
                var messageBoxResult = MessageBox.Show("Are you sure you want to update test results?",
                   "Confirm Update.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (messageBoxResult == DialogResult.Yes)
                {
                    var testResult = (TestResult)listViewImages.SelectedItems[0].Tag;
                    testResult.Name = txtName.Text;
                    testResult.Image = ConvertImageToBinary(pictureBox1.Image);

                    if (testResultManager.Update(testResult))
                    {
                        MessageBox.Show("Test result updated successfully.");
                    }
                }
            }
        }

       
        public void DeleteTestResult()
        {
            if (listViewImages.SelectedItems.Count > 0)
            {
                var messageBoxResult = MessageBox.Show("Are you sure you want to delete test results?",
                   "Confirm Delete.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (messageBoxResult == DialogResult.Yes)
                {
                    var testResult = (TestResult)listViewImages.SelectedItems[0].Tag;

                    if (testResultManager.Delete(new int[] { testResult.Id }))
                    {
                        MessageBox.Show("Test result delete successfully.");
                        pictureBox1.Image = null;
                        pictureBox2.Image = null;
                        txtName.Text = string.Empty;
                    }
                }
            }
        }

        private void TestResults_Click(object sender, EventArgs e)
        {
            listViewImages.SelectedItems.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}