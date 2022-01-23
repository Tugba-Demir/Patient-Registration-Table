using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalForm
{
    public class PatientDal
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-M55G9OV\SQLEXPRESS08;Initial Catalog=PatientRegistration;Integrated Security=True");

        #region ControlConnectionMethod
        public void ControlConnection()
        {
            if(_connection.State==ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        #endregion

        #region PatientAdd
        public void Add(Patient _patient)
        {
            ControlConnection();

            SqlCommand command = new SqlCommand("Insert into PatientInfoTable values(@PatientName, @PatientSurname, @Id, @Policlinic, @DoctorName, @AppointmentDay, @AppointmentTime)", _connection);
            command.Parameters.AddWithValue("@PatientName", _patient.PatientName);
            command.Parameters.AddWithValue("@PatientSurname", _patient.PatientSurname);
            command.Parameters.AddWithValue("@Id", _patient.Id);
            command.Parameters.AddWithValue("@Policlinic", _patient.Policlinic);
            command.Parameters.AddWithValue("@DoctorName", _patient.DoctorName);
            command.Parameters.AddWithValue("@AppointmentDay", _patient.AppointmentDay);
            command.Parameters.AddWithValue("@AppointmentTime", _patient.AppointmentTime);
            command.ExecuteNonQuery();

            _connection.Close();

        }
        #endregion

        #region GetAllMethod

        public List<Patient> GetAll()
        {
            ControlConnection();
            SqlCommand command = new SqlCommand("select * from PatientInfoTable", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Patient> patients = new List<Patient>();

            while(reader.Read())
            {
                Patient patient = new Patient
                {
                    PatientName = reader["PatientName"].ToString(),
                    PatientSurname = reader["PatientSurname"].ToString(),
                    Id = reader["Id"].ToString(),
                    Policlinic = reader["Policlinic"].ToString(),
                    DoctorName = reader["DoctorName"].ToString(),
                    AppointmentDay = reader["AppointmentDay"].ToString(),
                    AppointmentTime = reader["AppointmentTime"].ToString()
                };
                patients.Add(patient);
            }
            _connection.Close();
            return patients;
        }
        #endregion

        #region UpdateMethod
        public void Update(Patient _patient)
        {
            ControlConnection();
            SqlCommand command = new SqlCommand("Update PatientInfoTable set PatientName=@patientName, PatientSurname=@patientSurname, " +
                "Id=@id, Policlinic=@policlinic, DoctorName=@doctorName, AppointmentDay=@appointmentDay, AppointmentTime=@appointmentTime where Id=@id", _connection);
            command.Parameters.AddWithValue("@patientName", _patient.PatientName);
            command.Parameters.AddWithValue("@patientSurname", _patient.PatientSurname);
            command.Parameters.AddWithValue("@id", _patient.Id);
            command.Parameters.AddWithValue("@policlinic", _patient.Policlinic);
            command.Parameters.AddWithValue("@doctorName", _patient.DoctorName);
            command.Parameters.AddWithValue("@appointmentDay", _patient.AppointmentDay);
            command.Parameters.AddWithValue("@appointmentTime", _patient.AppointmentTime);
            command.ExecuteNonQuery();

            _connection.Close();
        }
        #endregion

        #region RemoveMethod
        public void Remove(string id)
        {
            ControlConnection();
            SqlCommand command = new SqlCommand("Delete from PatientInfoTable where Id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            _connection.Close();
        }
        #endregion
    }
}
