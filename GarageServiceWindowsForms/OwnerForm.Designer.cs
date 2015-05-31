namespace GarageServiceWindowsForms
{
    partial class OwnerForm
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
            this.SubmitData = new System.Windows.Forms.Button();
            this.UpdateData = new System.Windows.Forms.Button();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.AddDataButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OwnerEmailLabel = new System.Windows.Forms.Label();
            this.ownerLastNameLabel = new System.Windows.Forms.Label();
            this.ownerFirstNameLabel = new System.Windows.Forms.Label();
            this.OwnerIDLabel = new System.Windows.Forms.Label();
            this.TxtOwnerLastName = new System.Windows.Forms.TextBox();
            this.TxtOwnerFirstName = new System.Windows.Forms.TextBox();
            this.DeleteDatabutton = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.ownerTableAdapter1 = new GarageServiceWindowsForms.GarageServiceDatabaseDataSet1TableAdapters.OwnerTableAdapter();
            this.garageServiceDatabaseDataSet11 = new GarageServiceWindowsForms.GarageServiceDatabaseDataSet1();
            this.carTableAdapter1 = new GarageServiceWindowsForms.GarageServiceDatabaseDataSet1TableAdapters.CarTableAdapter();
            this.serviceTableAdapter1 = new GarageServiceWindowsForms.GarageServiceDatabaseDataSet1TableAdapters.ServiceTableAdapter();
            this.tableAdapterManager1 = new GarageServiceWindowsForms.GarageServiceDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garageServiceDatabaseDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitData
            // 
            this.SubmitData.Location = new System.Drawing.Point(556, 447);
            this.SubmitData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubmitData.Name = "SubmitData";
            this.SubmitData.Size = new System.Drawing.Size(115, 50);
            this.SubmitData.TabIndex = 5;
            this.SubmitData.Text = "Submit Data";
            this.SubmitData.UseVisualStyleBackColor = true;
            this.SubmitData.Click += new System.EventHandler(this.AddData_Click);
            // 
            // UpdateData
            // 
            this.UpdateData.Location = new System.Drawing.Point(8, 319);
            this.UpdateData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateData.Name = "UpdateData";
            this.UpdateData.Size = new System.Drawing.Size(132, 48);
            this.UpdateData.TabIndex = 18;
            this.UpdateData.Text = "Update Data";
            this.UpdateData.UseVisualStyleBackColor = true;
            this.UpdateData.Click += new System.EventHandler(this.UpdateData_Click);
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(285, 302);
            this.txtTelNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(288, 22);
            this.txtTelNo.TabIndex = 26;
            this.txtTelNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelNo_KeyPress_Click);
            this.txtTelNo.Validated += new System.EventHandler(this.validationCheck);
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Location = new System.Drawing.Point(289, 50);
            this.txtOwnerID.Margin = new System.Windows.Forms.Padding(4);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.ReadOnly = true;
            this.txtOwnerID.Size = new System.Drawing.Size(287, 22);
            this.txtOwnerID.TabIndex = 13;
            this.txtOwnerID.Validated += new System.EventHandler(this.validationCheck);
            // 
            // AddDataButton
            // 
            this.AddDataButton.Location = new System.Drawing.Point(8, 159);
            this.AddDataButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddDataButton.Name = "AddDataButton";
            this.AddDataButton.Size = new System.Drawing.Size(132, 48);
            this.AddDataButton.TabIndex = 17;
            this.AddDataButton.Text = "Add Data";
            this.AddDataButton.UseVisualStyleBackColor = true;
            this.AddDataButton.Click += new System.EventHandler(this.AddData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.OwnerEmailLabel);
            this.groupBox1.Controls.Add(this.txtTelNo);
            this.groupBox1.Controls.Add(this.ownerLastNameLabel);
            this.groupBox1.Controls.Add(this.ownerFirstNameLabel);
            this.groupBox1.Controls.Add(this.OwnerIDLabel);
            this.groupBox1.Controls.Add(this.SubmitData);
            this.groupBox1.Controls.Add(this.txtOwnerID);
            this.groupBox1.Controls.Add(this.TxtOwnerLastName);
            this.groupBox1.Controls.Add(this.TxtOwnerFirstName);
            this.groupBox1.Location = new System.Drawing.Point(147, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(677, 505);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(287, 235);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(288, 22);
            this.textEmail.TabIndex = 29;
            this.textEmail.Validated += new System.EventHandler(this.validationCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Owner Tel No:";
            // 
            // OwnerEmailLabel
            // 
            this.OwnerEmailLabel.AutoSize = true;
            this.OwnerEmailLabel.Location = new System.Drawing.Point(189, 238);
            this.OwnerEmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OwnerEmailLabel.Name = "OwnerEmailLabel";
            this.OwnerEmailLabel.Size = new System.Drawing.Size(91, 17);
            this.OwnerEmailLabel.TabIndex = 27;
            this.OwnerEmailLabel.Text = "Owner Email:";
            // 
            // ownerLastNameLabel
            // 
            this.ownerLastNameLabel.AutoSize = true;
            this.ownerLastNameLabel.Location = new System.Drawing.Point(156, 174);
            this.ownerLastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ownerLastNameLabel.Name = "ownerLastNameLabel";
            this.ownerLastNameLabel.Size = new System.Drawing.Size(125, 17);
            this.ownerLastNameLabel.TabIndex = 24;
            this.ownerLastNameLabel.Text = "Owner Last Name:";
            // 
            // ownerFirstNameLabel
            // 
            this.ownerFirstNameLabel.AutoSize = true;
            this.ownerFirstNameLabel.Location = new System.Drawing.Point(156, 110);
            this.ownerFirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ownerFirstNameLabel.Name = "ownerFirstNameLabel";
            this.ownerFirstNameLabel.Size = new System.Drawing.Size(125, 17);
            this.ownerFirstNameLabel.TabIndex = 21;
            this.ownerFirstNameLabel.Text = "Owner First Name:";
            // 
            // OwnerIDLabel
            // 
            this.OwnerIDLabel.AutoSize = true;
            this.OwnerIDLabel.Location = new System.Drawing.Point(211, 53);
            this.OwnerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OwnerIDLabel.Name = "OwnerIDLabel";
            this.OwnerIDLabel.Size = new System.Drawing.Size(70, 17);
            this.OwnerIDLabel.TabIndex = 18;
            this.OwnerIDLabel.Text = "Owner ID:";
            // 
            // TxtOwnerLastName
            // 
            this.TxtOwnerLastName.Location = new System.Drawing.Point(287, 170);
            this.TxtOwnerLastName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOwnerLastName.Name = "TxtOwnerLastName";
            this.TxtOwnerLastName.Size = new System.Drawing.Size(287, 22);
            this.TxtOwnerLastName.TabIndex = 12;
            this.TxtOwnerLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOwnerLastName_KeyPress_Click);
            this.TxtOwnerLastName.Validated += new System.EventHandler(this.validationCheck);
            // 
            // TxtOwnerFirstName
            // 
            this.TxtOwnerFirstName.Location = new System.Drawing.Point(289, 110);
            this.TxtOwnerFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOwnerFirstName.Name = "TxtOwnerFirstName";
            this.TxtOwnerFirstName.Size = new System.Drawing.Size(287, 22);
            this.TxtOwnerFirstName.TabIndex = 11;
            this.TxtOwnerFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOwnerFirstName_KeyPress_Click);
            this.TxtOwnerFirstName.Validated += new System.EventHandler(this.validationCheck);
            // 
            // DeleteDatabutton
            // 
            this.DeleteDatabutton.Location = new System.Drawing.Point(8, 469);
            this.DeleteDatabutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteDatabutton.Name = "DeleteDatabutton";
            this.DeleteDatabutton.Size = new System.Drawing.Size(132, 48);
            this.DeleteDatabutton.TabIndex = 28;
            this.DeleteDatabutton.Text = "Delete Data";
            this.DeleteDatabutton.UseVisualStyleBackColor = true;
            this.DeleteDatabutton.Click += new System.EventHandler(this.DeleteData_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(8, 12);
            this.Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(132, 48);
            this.Home.TabIndex = 16;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.ServiceForm_Click);
            // 
            // ownerTableAdapter1
            // 
            this.ownerTableAdapter1.ClearBeforeFill = true;
            // 
            // garageServiceDatabaseDataSet11
            // 
            this.garageServiceDatabaseDataSet11.DataSetName = "GarageServiceDatabaseDataSet1";
            this.garageServiceDatabaseDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carTableAdapter1
            // 
            this.carTableAdapter1.ClearBeforeFill = true;
            // 
            // serviceTableAdapter1
            // 
            this.serviceTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CarTableAdapter = this.carTableAdapter1;
            this.tableAdapterManager1.OwnerTableAdapter = this.ownerTableAdapter1;
            this.tableAdapterManager1.ServiceTableAdapter = this.serviceTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = GarageServiceWindowsForms.GarageServiceDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(214, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(217, 22);
            this.textBox3.TabIndex = 26;
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 528);
            this.Controls.Add(this.UpdateData);
            this.Controls.Add(this.DeleteDatabutton);
            this.Controls.Add(this.AddDataButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Home);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "OwnerForm";
            this.ShowIcon = false;
            this.Text = "Garage Service Form";
            this.Load += new System.EventHandler(this.OwnerForm_Load);
            this.Click += new System.EventHandler(this.OwnerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garageServiceDatabaseDataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SubmitData;
        private System.Windows.Forms.Button UpdateData;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtOwnerID;
        private System.Windows.Forms.Button AddDataButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label OwnerEmailLabel;
        private System.Windows.Forms.Label ownerLastNameLabel;
        private System.Windows.Forms.Label ownerFirstNameLabel;
        private System.Windows.Forms.Label OwnerIDLabel;
        private System.Windows.Forms.TextBox TxtOwnerLastName;
        private System.Windows.Forms.TextBox TxtOwnerFirstName;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button DeleteDatabutton;
        private GarageServiceDatabaseDataSet1TableAdapters.OwnerTableAdapter ownerTableAdapter1;
        private GarageServiceDatabaseDataSet1 garageServiceDatabaseDataSet11;
        private GarageServiceDatabaseDataSet1TableAdapters.CarTableAdapter carTableAdapter1;
        private GarageServiceDatabaseDataSet1TableAdapters.ServiceTableAdapter serviceTableAdapter1;
        private GarageServiceDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label1;
    }
}