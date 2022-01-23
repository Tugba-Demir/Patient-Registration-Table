
namespace hospitalForm
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPatientRecord = new System.Windows.Forms.DataGridView();
            this.grpPetientAdd = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.comboRegDoctorName = new System.Windows.Forms.ComboBox();
            this.comboRegAppoDay = new System.Windows.Forms.ComboBox();
            this.comboRegAppoTime = new System.Windows.Forms.ComboBox();
            this.comboRegPoliclinic = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPatientRegistration = new System.Windows.Forms.Button();
            this.txtBoxRegId = new System.Windows.Forms.TextBox();
            this.txtBoxRegSurname = new System.Windows.Forms.TextBox();
            this.txtBoxRegName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientRecord)).BeginInit();
            this.grpPetientAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPatientRecord
            // 
            this.dgvPatientRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatientRecord.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dgvPatientRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientRecord.GridColor = System.Drawing.Color.Green;
            this.dgvPatientRecord.Location = new System.Drawing.Point(54, 24);
            this.dgvPatientRecord.Name = "dgvPatientRecord";
            this.dgvPatientRecord.RowHeadersWidth = 51;
            this.dgvPatientRecord.RowTemplate.Height = 24;
            this.dgvPatientRecord.Size = new System.Drawing.Size(1070, 198);
            this.dgvPatientRecord.TabIndex = 0;
            this.dgvPatientRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientRecord_CellClick);
            // 
            // grpPetientAdd
            // 
            this.grpPetientAdd.BackColor = System.Drawing.Color.LightPink;
            this.grpPetientAdd.Controls.Add(this.btnRemove);
            this.grpPetientAdd.Controls.Add(this.comboRegDoctorName);
            this.grpPetientAdd.Controls.Add(this.comboRegAppoDay);
            this.grpPetientAdd.Controls.Add(this.comboRegAppoTime);
            this.grpPetientAdd.Controls.Add(this.comboRegPoliclinic);
            this.grpPetientAdd.Controls.Add(this.btnUpdate);
            this.grpPetientAdd.Controls.Add(this.btnPatientRegistration);
            this.grpPetientAdd.Controls.Add(this.txtBoxRegId);
            this.grpPetientAdd.Controls.Add(this.txtBoxRegSurname);
            this.grpPetientAdd.Controls.Add(this.txtBoxRegName);
            this.grpPetientAdd.Controls.Add(this.label7);
            this.grpPetientAdd.Controls.Add(this.label6);
            this.grpPetientAdd.Controls.Add(this.label5);
            this.grpPetientAdd.Controls.Add(this.label4);
            this.grpPetientAdd.Controls.Add(this.label3);
            this.grpPetientAdd.Controls.Add(this.label2);
            this.grpPetientAdd.Controls.Add(this.label1);
            this.grpPetientAdd.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpPetientAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpPetientAdd.Location = new System.Drawing.Point(248, 240);
            this.grpPetientAdd.Name = "grpPetientAdd";
            this.grpPetientAdd.Size = new System.Drawing.Size(702, 289);
            this.grpPetientAdd.TabIndex = 1;
            this.grpPetientAdd.TabStop = false;
            this.grpPetientAdd.Text = "PATIENT PROCEDURES";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(517, 189);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(153, 35);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // comboRegDoctorName
            // 
            this.comboRegDoctorName.FormattingEnabled = true;
            this.comboRegDoctorName.Location = new System.Drawing.Point(210, 174);
            this.comboRegDoctorName.Name = "comboRegDoctorName";
            this.comboRegDoctorName.Size = new System.Drawing.Size(245, 29);
            this.comboRegDoctorName.TabIndex = 3;
            // 
            // comboRegAppoDay
            // 
            this.comboRegAppoDay.FormattingEnabled = true;
            this.comboRegAppoDay.Location = new System.Drawing.Point(209, 209);
            this.comboRegAppoDay.Name = "comboRegAppoDay";
            this.comboRegAppoDay.Size = new System.Drawing.Size(246, 29);
            this.comboRegAppoDay.TabIndex = 4;
            // 
            // comboRegAppoTime
            // 
            this.comboRegAppoTime.FormattingEnabled = true;
            this.comboRegAppoTime.Location = new System.Drawing.Point(210, 244);
            this.comboRegAppoTime.Name = "comboRegAppoTime";
            this.comboRegAppoTime.Size = new System.Drawing.Size(246, 29);
            this.comboRegAppoTime.TabIndex = 5;
            // 
            // comboRegPoliclinic
            // 
            this.comboRegPoliclinic.FormattingEnabled = true;
            this.comboRegPoliclinic.Location = new System.Drawing.Point(209, 139);
            this.comboRegPoliclinic.Name = "comboRegPoliclinic";
            this.comboRegPoliclinic.Size = new System.Drawing.Size(246, 29);
            this.comboRegPoliclinic.TabIndex = 2;
            this.comboRegPoliclinic.SelectedIndexChanged += new System.EventHandler(this.comboRegPoliclinic_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(517, 130);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 35);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPatientRegistration
            // 
            this.btnPatientRegistration.Location = new System.Drawing.Point(517, 74);
            this.btnPatientRegistration.Name = "btnPatientRegistration";
            this.btnPatientRegistration.Size = new System.Drawing.Size(153, 35);
            this.btnPatientRegistration.TabIndex = 12;
            this.btnPatientRegistration.Text = "REGİSTER";
            this.btnPatientRegistration.UseVisualStyleBackColor = true;
            this.btnPatientRegistration.Click += new System.EventHandler(this.btnPatientRegistration_Click);
            // 
            // txtBoxRegId
            // 
            this.txtBoxRegId.Location = new System.Drawing.Point(209, 105);
            this.txtBoxRegId.Name = "txtBoxRegId";
            this.txtBoxRegId.Size = new System.Drawing.Size(245, 28);
            this.txtBoxRegId.TabIndex = 7;
            // 
            // txtBoxRegSurname
            // 
            this.txtBoxRegSurname.Location = new System.Drawing.Point(207, 70);
            this.txtBoxRegSurname.Name = "txtBoxRegSurname";
            this.txtBoxRegSurname.Size = new System.Drawing.Size(245, 28);
            this.txtBoxRegSurname.TabIndex = 6;
            // 
            // txtBoxRegName
            // 
            this.txtBoxRegName.Location = new System.Drawing.Point(207, 36);
            this.txtBoxRegName.Name = "txtBoxRegName";
            this.txtBoxRegName.Size = new System.Drawing.Size(245, 28);
            this.txtBoxRegName.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "APPOINTMENT TIME:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "APPOINTMENT DAY:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "DOCTOR NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "POLICLINIC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "SURNAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1173, 556);
            this.Controls.Add(this.grpPetientAdd);
            this.Controls.Add(this.dgvPatientRecord);
            this.Name = "Form1";
            this.Text = "Patient Record Table";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientRecord)).EndInit();
            this.grpPetientAdd.ResumeLayout(false);
            this.grpPetientAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatientRecord;
        private System.Windows.Forms.GroupBox grpPetientAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxRegSurname;
        private System.Windows.Forms.TextBox txtBoxRegName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPatientRegistration;
        private System.Windows.Forms.TextBox txtBoxRegId;
        private System.Windows.Forms.ComboBox comboRegPoliclinic;
        private System.Windows.Forms.ComboBox comboRegDoctorName;
        private System.Windows.Forms.ComboBox comboRegAppoDay;
        private System.Windows.Forms.ComboBox comboRegAppoTime;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
    }
}

