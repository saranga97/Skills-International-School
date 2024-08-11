namespace SkillsInternational
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBoxStudentReg = new System.Windows.Forms.GroupBox();
            this.cmbRegNo = new System.Windows.Forms.ComboBox();
            this.labelRegNo = new System.Windows.Forms.Label();
            this.groupBoxBasicDetails = new System.Windows.Forms.GroupBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.groupBoxContactDetails = new System.Windows.Forms.GroupBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.labelHomePhone = new System.Windows.Forms.Label();
            this.labelMobilePhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.groupBoxParentDetails = new System.Windows.Forms.GroupBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.labelContactNo = new System.Windows.Forms.Label();
            this.labelNIC = new System.Windows.Forms.Label();
            this.labelParentName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.linkLogout = new System.Windows.Forms.LinkLabel();
            this.linkExit = new System.Windows.Forms.LinkLabel();
            this.groupBoxStudentReg.SuspendLayout();
            this.groupBoxBasicDetails.SuspendLayout();
            this.groupBoxContactDetails.SuspendLayout();
            this.groupBoxParentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStudentReg
            // 
            this.groupBoxStudentReg.Controls.Add(this.cmbRegNo);
            this.groupBoxStudentReg.Controls.Add(this.labelRegNo);
            this.groupBoxStudentReg.Location = new System.Drawing.Point(22, 48);
            this.groupBoxStudentReg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxStudentReg.Name = "groupBoxStudentReg";
            this.groupBoxStudentReg.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxStudentReg.Size = new System.Drawing.Size(511, 74);
            this.groupBoxStudentReg.TabIndex = 0;
            this.groupBoxStudentReg.TabStop = false;
            this.groupBoxStudentReg.Text = "Student Registration";
            // 
            // cmbRegNo
            // 
            this.cmbRegNo.FormattingEnabled = true;
            this.cmbRegNo.Location = new System.Drawing.Point(133, 31);
            this.cmbRegNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRegNo.Name = "cmbRegNo";
            this.cmbRegNo.Size = new System.Drawing.Size(319, 24);
            this.cmbRegNo.TabIndex = 0;
            this.cmbRegNo.SelectedIndexChanged += new System.EventHandler(this.cmbRegNo_SelectedIndexChanged);
            // 
            // labelRegNo
            // 
            this.labelRegNo.AutoSize = true;
            this.labelRegNo.Location = new System.Drawing.Point(20, 34);
            this.labelRegNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegNo.Name = "labelRegNo";
            this.labelRegNo.Size = new System.Drawing.Size(54, 16);
            this.labelRegNo.TabIndex = 0;
            this.labelRegNo.Text = "Reg No";
            // 
            // groupBoxBasicDetails
            // 
            this.groupBoxBasicDetails.Controls.Add(this.dtpDateOfBirth);
            this.groupBoxBasicDetails.Controls.Add(this.rdbFemale);
            this.groupBoxBasicDetails.Controls.Add(this.rdbMale);
            this.groupBoxBasicDetails.Controls.Add(this.txtLastName);
            this.groupBoxBasicDetails.Controls.Add(this.txtFirstName);
            this.groupBoxBasicDetails.Controls.Add(this.labelDateOfBirth);
            this.groupBoxBasicDetails.Controls.Add(this.labelGender);
            this.groupBoxBasicDetails.Controls.Add(this.labelLastName);
            this.groupBoxBasicDetails.Controls.Add(this.labelFirstName);
            this.groupBoxBasicDetails.Location = new System.Drawing.Point(22, 130);
            this.groupBoxBasicDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxBasicDetails.Name = "groupBoxBasicDetails";
            this.groupBoxBasicDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxBasicDetails.Size = new System.Drawing.Size(511, 156);
            this.groupBoxBasicDetails.TabIndex = 1;
            this.groupBoxBasicDetails.TabStop = false;
            this.groupBoxBasicDetails.Text = "Basic Details";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(133, 115);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(319, 22);
            this.dtpDateOfBirth.TabIndex = 4;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(227, 86);
            this.rdbFemale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(71, 20);
            this.rdbFemale.TabIndex = 3;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(133, 86);
            this.rdbMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(55, 20);
            this.rdbMale.TabIndex = 2;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(133, 55);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(366, 22);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(133, 24);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(366, 22);
            this.txtFirstName.TabIndex = 0;
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(20, 121);
            this.labelDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(79, 16);
            this.labelDateOfBirth.TabIndex = 6;
            this.labelDateOfBirth.Text = "Date of Birth";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(20, 86);
            this.labelGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(52, 16);
            this.labelGender.TabIndex = 5;
            this.labelGender.Text = "Gender";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(20, 55);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(72, 16);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(20, 24);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(72, 16);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "First Name";
            // 
            // groupBoxContactDetails
            // 
            this.groupBoxContactDetails.Controls.Add(this.txtHomePhone);
            this.groupBoxContactDetails.Controls.Add(this.txtMobilePhone);
            this.groupBoxContactDetails.Controls.Add(this.txtEmail);
            this.groupBoxContactDetails.Controls.Add(this.txtAddress);
            this.groupBoxContactDetails.Controls.Add(this.labelHomePhone);
            this.groupBoxContactDetails.Controls.Add(this.labelMobilePhone);
            this.groupBoxContactDetails.Controls.Add(this.labelEmail);
            this.groupBoxContactDetails.Controls.Add(this.labelAddress);
            this.groupBoxContactDetails.Location = new System.Drawing.Point(22, 294);
            this.groupBoxContactDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxContactDetails.Name = "groupBoxContactDetails";
            this.groupBoxContactDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxContactDetails.Size = new System.Drawing.Size(511, 148);
            this.groupBoxContactDetails.TabIndex = 2;
            this.groupBoxContactDetails.TabStop = false;
            this.groupBoxContactDetails.Text = "Contact Details";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(367, 105);
            this.txtHomePhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(132, 22);
            this.txtHomePhone.TabIndex = 7;
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.Location = new System.Drawing.Point(133, 103);
            this.txtMobilePhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(132, 22);
            this.txtMobilePhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(133, 68);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(366, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(133, 31);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(366, 24);
            this.txtAddress.TabIndex = 4;
            // 
            // labelHomePhone
            // 
            this.labelHomePhone.AutoSize = true;
            this.labelHomePhone.Location = new System.Drawing.Point(279, 105);
            this.labelHomePhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHomePhone.Name = "labelHomePhone";
            this.labelHomePhone.Size = new System.Drawing.Size(86, 16);
            this.labelHomePhone.TabIndex = 10;
            this.labelHomePhone.Text = "Home Phone";
            // 
            // labelMobilePhone
            // 
            this.labelMobilePhone.AutoSize = true;
            this.labelMobilePhone.Location = new System.Drawing.Point(20, 105);
            this.labelMobilePhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMobilePhone.Name = "labelMobilePhone";
            this.labelMobilePhone.Size = new System.Drawing.Size(90, 16);
            this.labelMobilePhone.TabIndex = 9;
            this.labelMobilePhone.Text = "Mobile Phone";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(20, 70);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 16);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(20, 31);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(58, 16);
            this.labelAddress.TabIndex = 7;
            this.labelAddress.Text = "Address";
            // 
            // groupBoxParentDetails
            // 
            this.groupBoxParentDetails.Controls.Add(this.txtContactNo);
            this.groupBoxParentDetails.Controls.Add(this.txtNIC);
            this.groupBoxParentDetails.Controls.Add(this.txtParentName);
            this.groupBoxParentDetails.Controls.Add(this.labelContactNo);
            this.groupBoxParentDetails.Controls.Add(this.labelNIC);
            this.groupBoxParentDetails.Controls.Add(this.labelParentName);
            this.groupBoxParentDetails.Location = new System.Drawing.Point(22, 449);
            this.groupBoxParentDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxParentDetails.Name = "groupBoxParentDetails";
            this.groupBoxParentDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxParentDetails.Size = new System.Drawing.Size(511, 134);
            this.groupBoxParentDetails.TabIndex = 3;
            this.groupBoxParentDetails.TabStop = false;
            this.groupBoxParentDetails.Text = "Parent Details";
            this.groupBoxParentDetails.Enter += new System.EventHandler(this.groupBoxParentDetails_Enter);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(133, 93);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(366, 22);
            this.txtContactNo.TabIndex = 10;
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(133, 62);
            this.txtNIC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(366, 22);
            this.txtNIC.TabIndex = 9;
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(133, 31);
            this.txtParentName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(366, 22);
            this.txtParentName.TabIndex = 8;
            // 
            // labelContactNo
            // 
            this.labelContactNo.AutoSize = true;
            this.labelContactNo.Location = new System.Drawing.Point(20, 93);
            this.labelContactNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContactNo.Name = "labelContactNo";
            this.labelContactNo.Size = new System.Drawing.Size(73, 16);
            this.labelContactNo.TabIndex = 13;
            this.labelContactNo.Text = "Contact No";
            // 
            // labelNIC
            // 
            this.labelNIC.AutoSize = true;
            this.labelNIC.Location = new System.Drawing.Point(20, 62);
            this.labelNIC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNIC.Name = "labelNIC";
            this.labelNIC.Size = new System.Drawing.Size(29, 16);
            this.labelNIC.TabIndex = 12;
            this.labelNIC.Text = "NIC";
            // 
            // labelParentName
            // 
            this.labelParentName.AutoSize = true;
            this.labelParentName.Location = new System.Drawing.Point(20, 31);
            this.labelParentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelParentName.Name = "labelParentName";
            this.labelParentName.Size = new System.Drawing.Size(86, 16);
            this.labelParentName.TabIndex = 11;
            this.labelParentName.Text = "Parent Name";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(22, 591);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 28);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(130, 591);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(325, 591);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(433, 591);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // linkLogout
            // 
            this.linkLogout.AutoSize = true;
            this.linkLogout.Location = new System.Drawing.Point(23, 19);
            this.linkLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLogout.Name = "linkLogout";
            this.linkLogout.Size = new System.Drawing.Size(48, 16);
            this.linkLogout.TabIndex = 15;
            this.linkLogout.TabStop = true;
            this.linkLogout.Text = "Logout";
            this.linkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogout_LinkClicked);
            // 
            // linkExit
            // 
            this.linkExit.AutoSize = true;
            this.linkExit.Location = new System.Drawing.Point(505, 632);
            this.linkExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkExit.Name = "linkExit";
            this.linkExit.Size = new System.Drawing.Size(28, 16);
            this.linkExit.TabIndex = 16;
            this.linkExit.TabStop = true;
            this.linkExit.Text = "Exit";
            this.linkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkExit_LinkClicked);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 670);
            this.Controls.Add(this.linkExit);
            this.Controls.Add(this.linkLogout);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupBoxParentDetails);
            this.Controls.Add(this.groupBoxContactDetails);
            this.Controls.Add(this.groupBoxBasicDetails);
            this.Controls.Add(this.groupBoxStudentReg);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistrationForm";
            this.Text = "Student Registration - Skills International";
            this.groupBoxStudentReg.ResumeLayout(false);
            this.groupBoxStudentReg.PerformLayout();
            this.groupBoxBasicDetails.ResumeLayout(false);
            this.groupBoxBasicDetails.PerformLayout();
            this.groupBoxContactDetails.ResumeLayout(false);
            this.groupBoxContactDetails.PerformLayout();
            this.groupBoxParentDetails.ResumeLayout(false);
            this.groupBoxParentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.GroupBox groupBoxStudentReg;
        private System.Windows.Forms.ComboBox cmbRegNo;
        private System.Windows.Forms.Label labelRegNo;
        private System.Windows.Forms.GroupBox groupBoxBasicDetails;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.GroupBox groupBoxContactDetails;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label labelHomePhone;
        private System.Windows.Forms.Label labelMobilePhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.GroupBox groupBoxParentDetails;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label labelContactNo;
        private System.Windows.Forms.Label labelNIC;
        private System.Windows.Forms.Label labelParentName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.LinkLabel linkLogout;
        private System.Windows.Forms.LinkLabel linkExit;
    }
}
