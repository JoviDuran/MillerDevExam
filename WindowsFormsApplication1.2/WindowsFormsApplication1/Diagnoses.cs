using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using FuaClinic.Business;
using FuaClinic.Business.Repositories;

namespace WindowsFormsApplication1
{

    public partial class Diagnoses : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-PN05J6C\SQLEXPRESS;Initial Catalog= FuaClinic;Integrated Security =True;");
        int diagnosisId = 0;
        DiagnosisRepository diagnosisRepository = new DiagnosisRepository();

        public Diagnoses()
        {
            InitializeComponent();
        }

        private void SaveDiagnosis(object sender, EventArgs e)
        {
            if (btnSave.Text == "Edit")
            {
                var exisitingDiagnosis = diagnosisRepository.GetById(diagnosisId);
                exisitingDiagnosis.PatientId = Convert.ToInt32(txtPatientId.Text);
                exisitingDiagnosis.Illness = txtIllness.Text;
                exisitingDiagnosis.Date = txtDate.Text;
                if (diagnosisRepository.Update(exisitingDiagnosis) > 0)
                {
                    MessageBox.Show("Updated successfully");
                }
            }
            else
            {
                var diagnosis = new Diagnosis();
                diagnosis.PatientId = Convert.ToInt32(txtPatientId.Text);
                diagnosis.Illness = txtIllness.Text;
                diagnosis.Date = txtDate.Text;
                if (diagnosisRepository.Add(diagnosis) > 0)
                {
                    MessageBox.Show("Saved successfully");
                }
            }
            Clear();
            FillDataGridView();
        }

        private void DeleteDiagnosis(object sender, EventArgs e)
        {
            var diagnosis = diagnosisRepository.GetById(diagnosisId);
            if (diagnosisRepository.Delete(diagnosis) > 0)
            {
                MessageBox.Show("Deleted successfully");
            }

            Clear();
            FillDataGridView();

        }
        private void Diagnoses_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            btnDelete.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void FillDataGridView()
        {

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("ViewDiagnoses", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Illness", txtSearch.Text.Trim());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridDiagnoses.DataSource = dataTable;
        }

        private void SearchDiagnosis(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        public void Clear()
        {
            txtPatientId.Text = txtIllness.Text = txtDate.Text = txtSearch.Text = string.Empty;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }

        private void ClearFields(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridDiagnoses_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridDiagnoses.CurrentRow.Index != -1)
                {
                    diagnosisId = Convert.ToInt32(dataGridDiagnoses.CurrentRow.Cells[0].Value.ToString());
                    txtPatientId.Text = dataGridDiagnoses.CurrentRow.Cells[1].Value.ToString();
                    txtIllness.Text = dataGridDiagnoses.CurrentRow.Cells[2].Value.ToString();
                    txtDate.Text = dataGridDiagnoses.CurrentRow.Cells[3].Value.ToString();
                    btnSave.Text = "Edit";
                    btnDelete.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void txtPatientId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
