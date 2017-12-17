namespace projInsurancePolicy
{
    partial class frmPolicyCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpStartDateOfPolicy = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gboAddDriver = new System.Windows.Forms.GroupBox();
            this.panelAddClaims = new System.Windows.Forms.Panel();
            this.btnAddClaim = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpPastClaim = new System.Windows.Forms.DateTimePicker();
            this.lblClaims = new System.Windows.Forms.Label();
            this.lblClaim1 = new System.Windows.Forms.Label();
            this.btnClearDrivers = new System.Windows.Forms.Button();
            this.lblDriversCreated = new System.Windows.Forms.Label();
            this.btnCreatePolicy = new System.Windows.Forms.Button();
            this.btnAdminSection = new System.Windows.Forms.Button();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.cboOccupation = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.csvDataGrid = new System.Windows.Forms.DataGridView();
            this.btnBackToForm = new System.Windows.Forms.Button();
            this.txtSaveChanges = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gboAddDriver.SuspendLayout();
            this.panelAddClaims.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csvDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpStartDateOfPolicy
            // 
            this.dtpStartDateOfPolicy.Checked = false;
            this.dtpStartDateOfPolicy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDateOfPolicy.Location = new System.Drawing.Point(138, 15);
            this.dtpStartDateOfPolicy.Name = "dtpStartDateOfPolicy";
            this.dtpStartDateOfPolicy.Size = new System.Drawing.Size(149, 20);
            this.dtpStartDateOfPolicy.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Date of the Policy";
            // 
            // gboAddDriver
            // 
            this.gboAddDriver.Controls.Add(this.panelAddClaims);
            this.gboAddDriver.Controls.Add(this.btnClearDrivers);
            this.gboAddDriver.Controls.Add(this.lblDriversCreated);
            this.gboAddDriver.Controls.Add(this.btnCreatePolicy);
            this.gboAddDriver.Controls.Add(this.btnAdminSection);
            this.gboAddDriver.Controls.Add(this.btnAddDriver);
            this.gboAddDriver.Controls.Add(this.cboOccupation);
            this.gboAddDriver.Controls.Add(this.dtpDateOfBirth);
            this.gboAddDriver.Controls.Add(this.label4);
            this.gboAddDriver.Controls.Add(this.label3);
            this.gboAddDriver.Controls.Add(this.txtName);
            this.gboAddDriver.Controls.Add(this.label2);
            this.gboAddDriver.Location = new System.Drawing.Point(19, 47);
            this.gboAddDriver.Name = "gboAddDriver";
            this.gboAddDriver.Size = new System.Drawing.Size(682, 333);
            this.gboAddDriver.TabIndex = 2;
            this.gboAddDriver.TabStop = false;
            this.gboAddDriver.Text = "Add Driver";
            // 
            // panelAddClaims
            // 
            this.panelAddClaims.Controls.Add(this.btnAddClaim);
            this.panelAddClaims.Controls.Add(this.label6);
            this.panelAddClaims.Controls.Add(this.dtpPastClaim);
            this.panelAddClaims.Controls.Add(this.lblClaims);
            this.panelAddClaims.Controls.Add(this.lblClaim1);
            this.panelAddClaims.Location = new System.Drawing.Point(362, 19);
            this.panelAddClaims.Name = "panelAddClaims";
            this.panelAddClaims.Size = new System.Drawing.Size(262, 111);
            this.panelAddClaims.TabIndex = 17;
            // 
            // btnAddClaim
            // 
            this.btnAddClaim.Location = new System.Drawing.Point(102, 74);
            this.btnAddClaim.Name = "btnAddClaim";
            this.btnAddClaim.Size = new System.Drawing.Size(99, 23);
            this.btnAddClaim.TabIndex = 14;
            this.btnAddClaim.Text = "Add Claim";
            this.btnAddClaim.UseVisualStyleBackColor = true;
            this.btnAddClaim.Click += new System.EventHandler(this.btnAddClaim_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Add Insurance Claims for a Driver";
            // 
            // dtpPastClaim
            // 
            this.dtpPastClaim.Checked = false;
            this.dtpPastClaim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPastClaim.Location = new System.Drawing.Point(102, 48);
            this.dtpPastClaim.Name = "dtpPastClaim";
            this.dtpPastClaim.Size = new System.Drawing.Size(149, 20);
            this.dtpPastClaim.TabIndex = 10;
            // 
            // lblClaims
            // 
            this.lblClaims.AutoSize = true;
            this.lblClaims.Location = new System.Drawing.Point(13, 79);
            this.lblClaims.Name = "lblClaims";
            this.lblClaims.Size = new System.Drawing.Size(83, 13);
            this.lblClaims.TabIndex = 15;
            this.lblClaims.Text = "Claims Added: 0";
            // 
            // lblClaim1
            // 
            this.lblClaim1.AutoSize = true;
            this.lblClaim1.Location = new System.Drawing.Point(23, 54);
            this.lblClaim1.Name = "lblClaim1";
            this.lblClaim1.Size = new System.Drawing.Size(73, 13);
            this.lblClaim1.TabIndex = 11;
            this.lblClaim1.Text = "Date of Claim:";
            // 
            // btnClearDrivers
            // 
            this.btnClearDrivers.Location = new System.Drawing.Point(14, 294);
            this.btnClearDrivers.Name = "btnClearDrivers";
            this.btnClearDrivers.Size = new System.Drawing.Size(99, 23);
            this.btnClearDrivers.TabIndex = 13;
            this.btnClearDrivers.Text = "Clear Drivers";
            this.btnClearDrivers.UseVisualStyleBackColor = true;
            this.btnClearDrivers.Click += new System.EventHandler(this.btnClearDrivers_Click);
            // 
            // lblDriversCreated
            // 
            this.lblDriversCreated.AutoSize = true;
            this.lblDriversCreated.Location = new System.Drawing.Point(122, 115);
            this.lblDriversCreated.Name = "lblDriversCreated";
            this.lblDriversCreated.Size = new System.Drawing.Size(99, 13);
            this.lblDriversCreated.TabIndex = 3;
            this.lblDriversCreated.Text = "Drivers created 0/5";
            // 
            // btnCreatePolicy
            // 
            this.btnCreatePolicy.Location = new System.Drawing.Point(224, 294);
            this.btnCreatePolicy.Name = "btnCreatePolicy";
            this.btnCreatePolicy.Size = new System.Drawing.Size(99, 23);
            this.btnCreatePolicy.TabIndex = 12;
            this.btnCreatePolicy.Text = "Create Policy";
            this.btnCreatePolicy.UseVisualStyleBackColor = true;
            this.btnCreatePolicy.Click += new System.EventHandler(this.btnCreatePolicy_Click);
            // 
            // btnAdminSection
            // 
            this.btnAdminSection.Location = new System.Drawing.Point(573, 294);
            this.btnAdminSection.Name = "btnAdminSection";
            this.btnAdminSection.Size = new System.Drawing.Size(99, 23);
            this.btnAdminSection.TabIndex = 10;
            this.btnAdminSection.Text = "Admin Section";
            this.btnAdminSection.UseVisualStyleBackColor = true;
            this.btnAdminSection.Click += new System.EventHandler(this.btnAdminSection_Click);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(119, 294);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(99, 23);
            this.btnAddDriver.TabIndex = 6;
            this.btnAddDriver.Text = "Add Driver";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // cboOccupation
            // 
            this.cboOccupation.FormattingEnabled = true;
            this.cboOccupation.Items.AddRange(new object[] {
            "Accountant",
            "Chauffeur"});
            this.cboOccupation.Location = new System.Drawing.Point(119, 55);
            this.cboOccupation.Name = "cboOccupation";
            this.cboOccupation.Size = new System.Drawing.Size(149, 21);
            this.cboOccupation.TabIndex = 5;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Checked = false;
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(119, 82);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(149, 20);
            this.dtpDateOfBirth.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date of Birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Occupation:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(119, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 20);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(636, 461);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpStartDateOfPolicy);
            this.panel1.Controls.Add(this.gboAddDriver);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 398);
            this.panel1.TabIndex = 13;
            // 
            // csvDataGrid
            // 
            this.csvDataGrid.AllowUserToAddRows = false;
            this.csvDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.csvDataGrid.Location = new System.Drawing.Point(38, 15);
            this.csvDataGrid.Name = "csvDataGrid";
            this.csvDataGrid.Size = new System.Drawing.Size(665, 392);
            this.csvDataGrid.TabIndex = 11;
            // 
            // btnBackToForm
            // 
            this.btnBackToForm.Location = new System.Drawing.Point(234, 24);
            this.btnBackToForm.Name = "btnBackToForm";
            this.btnBackToForm.Size = new System.Drawing.Size(100, 23);
            this.btnBackToForm.TabIndex = 7;
            this.btnBackToForm.Text = "Go Back to Form";
            this.btnBackToForm.UseVisualStyleBackColor = true;
            this.btnBackToForm.Click += new System.EventHandler(this.btnBackToForm_Click);
            // 
            // txtSaveChanges
            // 
            this.txtSaveChanges.Location = new System.Drawing.Point(358, 24);
            this.txtSaveChanges.Name = "txtSaveChanges";
            this.txtSaveChanges.Size = new System.Drawing.Size(92, 23);
            this.txtSaveChanges.TabIndex = 12;
            this.txtSaveChanges.Text = "Save Changes";
            this.txtSaveChanges.UseVisualStyleBackColor = true;
            this.txtSaveChanges.Click += new System.EventHandler(this.txtSaveChanges_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Admin Section";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnBackToForm);
            this.panel2.Controls.Add(this.txtSaveChanges);
            this.panel2.Location = new System.Drawing.Point(12, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 68);
            this.panel2.TabIndex = 14;
            // 
            // frmPolicyCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(737, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.csvDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPolicyCalculator";
            this.Text = "Insurance Policy Calculator";
            this.Load += new System.EventHandler(this.frmPolicyCalculator_Load);
            this.gboAddDriver.ResumeLayout(false);
            this.gboAddDriver.PerformLayout();
            this.panelAddClaims.ResumeLayout(false);
            this.panelAddClaims.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csvDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartDateOfPolicy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboAddDriver;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboOccupation;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdminSection;
        private System.Windows.Forms.DateTimePicker dtpPastClaim;
        private System.Windows.Forms.Label lblClaim1;
        private System.Windows.Forms.Button btnCreatePolicy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView csvDataGrid;
        private System.Windows.Forms.Button btnBackToForm;
        private System.Windows.Forms.Button txtSaveChanges;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDriversCreated;
        private System.Windows.Forms.Button btnClearDrivers;
        private System.Windows.Forms.Button btnAddClaim;
        private System.Windows.Forms.Label lblClaims;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelAddClaims;
    }
}

