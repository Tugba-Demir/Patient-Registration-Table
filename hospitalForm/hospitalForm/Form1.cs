using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitalForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            // comboRegPoliclinic items;
            string[] policlinics = { "CHEST DISEASES", "CHILD ALLERGY", "CHILD SURGERY", "EYE DISEASES",
                                     "GENERAL SURGERY", "NEPHROLOGY", "NEUROLOGY", "UROLOGY" };
            comboRegPoliclinic.Items.AddRange(policlinics);

            // add days
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            comboRegAppoDay.Items.AddRange(days);

            // add times
            string[] times = { "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30" };
            comboRegAppoTime.Items.AddRange(times);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewShow();
        }

        PatientDal _patientDal = new PatientDal();

        #region comboRegPoliclinic_SelectedIndexChanged
        private void comboRegPoliclinic_SelectedIndexChanged(object sender, EventArgs e)
        {

            // comboRegDoctorName items;
            string[] doctorsChestDiseases = { "Sevinç Ak", "Cihan Akaş", "Mehmetcan Akay", "Münevver Akca" };
            string[] doctorsChildAllergy = { "Şennur Ağnar", "Kazım Başar", "Ayşegül Barutçuoğlu", "Yüksel Bal" };
            string[] doctorsChildSurgery = { "Safa Batur", "Gökmen Baştuğ", "Bensu Can", "Aygün Bayram" };
            string[] doctorsEyeDisease = { "Görkem Bilgeç", "Armağan Bilgen", "Sevgi Akman", "Arzu Yıldırım" };
            string[] doctorsGeneralSurgery = { "Kübra Tansu", "Altan Boz", "Anıl Bektaş", "Ahmet Çam" };
            string[] doctorsNephrology = { "Nergis Diken", "Aksu Bugey", "Yaprak Bural", "Canan Er" };
            string[] doctorsNeurology = { "Mustafa Canbek", "Seyit Ceylan", "Elif Salkım", "Sevda Coşku" };
            string[] doctorsUrology = { "Eda Yaman", "Rabia Leman", "Büşra Çakan", "Afra Çağan" };


            if (comboRegPoliclinic.Text == "CHEST DISEASES") 
            {
                comboRegDoctorName.Items.Clear(); 
                comboRegDoctorName.Items.AddRange(doctorsChestDiseases);
            }
            else if (comboRegPoliclinic.SelectedIndex == 1)
            {
                comboRegDoctorName.Items.Clear();
                comboRegDoctorName.Items.AddRange(doctorsChildAllergy);
            }
            else if (comboRegPoliclinic.SelectedIndex == 2)
            {
                comboRegDoctorName.Items.Clear();
                comboRegDoctorName.Items.AddRange(doctorsChildSurgery);
            }
            else if (comboRegPoliclinic.SelectedIndex == 3)
            {
                comboRegDoctorName.Items.Clear();
                comboRegDoctorName.Items.AddRange(doctorsEyeDisease);
            }
            else if (comboRegPoliclinic.SelectedIndex == 4)
            {
                comboRegDoctorName.Items.Clear();
                comboRegDoctorName.Items.AddRange(doctorsGeneralSurgery);
            }
            else if (comboRegPoliclinic.SelectedIndex == 5)
            {
                comboRegDoctorName.Items.Clear();
                comboRegDoctorName.Items.AddRange(doctorsNephrology);
            }
            else if (comboRegPoliclinic.SelectedIndex == 6)
            {
                comboRegDoctorName.Items.Clear();
                comboRegDoctorName.Items.AddRange(doctorsNeurology);
            }
            else
            {
                comboRegDoctorName.Items.Clear();
                comboRegDoctorName.Items.AddRange(doctorsUrology);
            }
        }
        #endregion

        #region btnPatientRegistration
        private void btnPatientRegistration_Click(object sender, EventArgs e)
        {
            string patientName = txtBoxRegName.Text;
            string patientSurname = txtBoxRegSurname.Text;
            string id = txtBoxRegId.Text;
            string  policlinic = comboRegPoliclinic.Text;
            string doctorName = comboRegDoctorName.Text;
            string appointmentDay = comboRegAppoDay.Text;
            string appointmentTime = comboRegAppoTime.Text;


            Patient patient = new Patient
            {
                PatientName = patientName,
                PatientSurname = patientSurname,
                Id = id,
                Policlinic = policlinic, 
                DoctorName = doctorName,
                AppointmentDay = appointmentDay,
                AppointmentTime = appointmentTime
            };


            
            _patientDal.Add(patient);

            MessageBox.Show("Created was your registration", "To Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            DataGridViewShow();
        }
        #endregion

        #region UpdateProcesses

        private void dgvPatientRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxRegName.Text = dgvPatientRecord.CurrentRow.Cells[0].Value.ToString();
            txtBoxRegSurname.Text = dgvPatientRecord.CurrentRow.Cells[1].Value.ToString();
            txtBoxRegId.Text = dgvPatientRecord.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string patientName = txtBoxRegName.Text;
            string patientSurname = txtBoxRegSurname.Text;
            string id = txtBoxRegId.Text;
            string policlinic = comboRegPoliclinic.Text;
            string doctorName = comboRegDoctorName.Text;
            string appointmentDay = comboRegAppoDay.Text;
            string appointmentTime = comboRegAppoTime.Text;


            Patient patient = new Patient
            {
                PatientName = patientName,
                PatientSurname = patientSurname,
                Id = id,
                Policlinic = policlinic,
                DoctorName = doctorName,
                AppointmentDay = appointmentDay,
                AppointmentTime = appointmentTime
            };

            _patientDal.Update(patient);

            MessageBox.Show("Updated was your registration", "To Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            DataGridViewShow();
            
        }

        #endregion

        #region DataGridViewShowMethod

        private void DataGridViewShow()
        {
            dgvPatientRecord.DataSource = _patientDal.GetAll();
        }
        #endregion

        #region btnRemove
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string id = dgvPatientRecord.CurrentRow.Cells[2].Value.ToString();

            _patientDal.Remove(id);
            MessageBox.Show("Deleted was your registration", "To Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            DataGridViewShow();
        }
        #endregion

        #region ClearMethod
        public void Clear()
        {
            txtBoxRegName.Clear();
            txtBoxRegId.Clear();
            txtBoxRegSurname.Clear();
            txtBoxRegId.Clear();
            comboRegPoliclinic.Text = "";
            comboRegDoctorName.Text = "";
            comboRegAppoDay.Text = "";
            comboRegAppoTime.Text = "";

        }
        #endregion
    }
}
