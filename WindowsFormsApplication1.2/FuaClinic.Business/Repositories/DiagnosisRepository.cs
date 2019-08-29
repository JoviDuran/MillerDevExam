using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace FuaClinic.Business.Repositories
{
    public class DiagnosisRepository
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-PN05J6C\SQLEXPRESS;Initial Catalog= FuaClinic;Integrated Security =True;");

        public Diagnosis GetById(int id)
        {
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            return sqlConnection.Query<Diagnosis>($"select * from Diagnoses where Id = '{id}'").FirstOrDefault();
            
        }

        public int Add(Diagnosis diagnosis)
        {
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            return sqlConnection.Execute("insert into Diagnoses(PatientId, Illness, Date) values(@PatientId, @Illness, @Date)",
                   new
                   {
                       PatientId = diagnosis.PatientId,
                       Illness = diagnosis.Illness,
                       Date = diagnosis.Date
                   });
            
           
        }

        public int Update(Diagnosis diagnosis)
        {
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            return sqlConnection.Execute($"update Diagnoses set PatientId = @PatientId, Illness = @Illness, Date = @Date where PatientId = '{diagnosis.PatientId}'",
                 new
                 {
                     PatientId = diagnosis.PatientId,
                     Illness = diagnosis.Illness,
                     Date = diagnosis.Date
                 });
            
        }
          

        public int Delete(Diagnosis diagnosis)
        {
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            return sqlConnection.Execute($"delete from Diagnoses where Id = '{diagnosis.Id}'");
            
        }
    }
}
