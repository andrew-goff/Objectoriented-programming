namespace GarageServiceWindowsForms
{
    partial class SearchForm
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
            this.components = new System.ComponentModel.Container();
            this.SearchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIdentificationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofNextMOTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofLastMOTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.garageServiceDatabaseDataSet11 = new GarageServiceWindowsForms.GarageServiceDatabaseDataSet1();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.Carcheckbox = new System.Windows.Forms.CheckBox();
            this.Ownercheckbox = new System.Windows.Forms.CheckBox();
            this.ServiceDate = new System.Windows.Forms.DateTimePicker();
            this.cmbOwner = new System.Windows.Forms.ComboBox();
            this.ownerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Car = new System.Windows.Forms.ComboBox();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OwnerFormButton = new System.Windows.Forms.Button();
            this.ServiceFormButton = new System.Windows.Forms.Button();
            this.serviceIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIdentificationNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofNextMOTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofLastMOTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOTCertificateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfNextServiceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfLastServiceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTableAdapter = new GarageServiceWindowsForms.GarageServiceDatabaseDataSet1TableAdapters.ServiceTableAdapter();
            this.carTableAdapter = new GarageServiceWindowsForms.GarageServiceDatabaseDataSet1TableAdapters.CarTableAdapter();
            this.garageServicetableAdapterManager = new GarageServiceWindowsForms.GarageServiceDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.ownerTableAdapter = new GarageServiceWindowsForms.GarageServiceDatabaseDataSet1TableAdapters.OwnerTableAdapter();
            this.addService = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageServiceDatabaseDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Enabled = false;
            this.SearchButton.Location = new System.Drawing.Point(773, 11);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(173, 54);
            this.SearchButton.TabIndex = 28;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.Search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.Carcheckbox);
            this.groupBox1.Controls.Add(this.Ownercheckbox);
            this.groupBox1.Controls.Add(this.ServiceDate);
            this.groupBox1.Controls.Add(this.cmbOwner);
            this.groupBox1.Controls.Add(this.Car);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Location = new System.Drawing.Point(127, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(955, 606);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceIDDataGridViewTextBoxColumn,
            this.vehicleIdentificationNumberDataGridViewTextBoxColumn,
            this.registrationNumberDataGridViewTextBoxColumn,
            this.dateofNextMOTDataGridViewTextBoxColumn,
            this.dateofLastMOTDataGridViewTextBoxColumn,
            this.dateOfServiceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.serviceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(940, 530);
            this.dataGridView1.TabIndex = 38;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            // 
            // vehicleIdentificationNumberDataGridViewTextBoxColumn
            // 
            this.vehicleIdentificationNumberDataGridViewTextBoxColumn.DataPropertyName = "VehicleIdentificationNumber";
            this.vehicleIdentificationNumberDataGridViewTextBoxColumn.HeaderText = "VehicleIdentificationNumber";
            this.vehicleIdentificationNumberDataGridViewTextBoxColumn.Name = "vehicleIdentificationNumberDataGridViewTextBoxColumn";
            // 
            // registrationNumberDataGridViewTextBoxColumn
            // 
            this.registrationNumberDataGridViewTextBoxColumn.DataPropertyName = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.HeaderText = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.Name = "registrationNumberDataGridViewTextBoxColumn";
            // 
            // dateofNextMOTDataGridViewTextBoxColumn
            // 
            this.dateofNextMOTDataGridViewTextBoxColumn.DataPropertyName = "DateofNextMOT";
            this.dateofNextMOTDataGridViewTextBoxColumn.HeaderText = "DateofNextMOT";
            this.dateofNextMOTDataGridViewTextBoxColumn.Name = "dateofNextMOTDataGridViewTextBoxColumn";
            // 
            // dateofLastMOTDataGridViewTextBoxColumn
            // 
            this.dateofLastMOTDataGridViewTextBoxColumn.DataPropertyName = "DateofLastMOT";
            this.dateofLastMOTDataGridViewTextBoxColumn.HeaderText = "DateofLastMOT";
            this.dateofLastMOTDataGridViewTextBoxColumn.Name = "dateofLastMOTDataGridViewTextBoxColumn";
            // 
            // dateOfServiceDataGridViewTextBoxColumn
            // 
            this.dateOfServiceDataGridViewTextBoxColumn.DataPropertyName = "DateOfService";
            this.dateOfServiceDataGridViewTextBoxColumn.HeaderText = "DateOfService";
            this.dateOfServiceDataGridViewTextBoxColumn.Name = "dateOfServiceDataGridViewTextBoxColumn";
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.garageServiceDatabaseDataSet11;
            // 
            // garageServiceDatabaseDataSet11
            // 
            this.garageServiceDatabaseDataSet11.DataSetName = "GarageServiceDatabaseDataSet1";
            this.garageServiceDatabaseDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(749, 12);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(18, 17);
            this.checkBox3.TabIndex = 37;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Click += new System.EventHandler(this.checkbox_click);
            // 
            // Carcheckbox
            // 
            this.Carcheckbox.AutoSize = true;
            this.Carcheckbox.Location = new System.Drawing.Point(223, 11);
            this.Carcheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Carcheckbox.Name = "Carcheckbox";
            this.Carcheckbox.Size = new System.Drawing.Size(18, 17);
            this.Carcheckbox.TabIndex = 36;
            this.Carcheckbox.UseVisualStyleBackColor = true;
            this.Carcheckbox.Click += new System.EventHandler(this.checkbox_click);
            // 
            // Ownercheckbox
            // 
            this.Ownercheckbox.AutoSize = true;
            this.Ownercheckbox.Location = new System.Drawing.Point(452, 11);
            this.Ownercheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ownercheckbox.Name = "Ownercheckbox";
            this.Ownercheckbox.Size = new System.Drawing.Size(18, 17);
            this.Ownercheckbox.TabIndex = 35;
            this.Ownercheckbox.UseVisualStyleBackColor = true;
            this.Ownercheckbox.Click += new System.EventHandler(this.checkbox_click);
            // 
            // ServiceDate
            // 
            this.ServiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ServiceDate.Location = new System.Drawing.Point(544, 7);
            this.ServiceDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServiceDate.Name = "ServiceDate";
            this.ServiceDate.Size = new System.Drawing.Size(200, 22);
            this.ServiceDate.TabIndex = 34;
            this.ServiceDate.Value = new System.DateTime(2015, 6, 7, 0, 0, 0, 0);
            // 
            // cmbOwner
            // 
            this.cmbOwner.DataSource = this.ownerBindingSource;
            this.cmbOwner.DisplayMember = "OwnerFirstName";
            this.cmbOwner.FormattingEnabled = true;
            this.cmbOwner.Location = new System.Drawing.Point(325, 7);
            this.cmbOwner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(121, 24);
            this.cmbOwner.TabIndex = 33;
            this.cmbOwner.ValueMember = "OwnerID";
            // 
            // ownerBindingSource
            // 
            this.ownerBindingSource.DataMember = "Owner";
            this.ownerBindingSource.DataSource = this.garageServiceDatabaseDataSet11;
            // 
            // Car
            // 
            this.Car.DataSource = this.carBindingSource;
            this.Car.DisplayMember = "RegistrationNumber";
            this.Car.FormattingEnabled = true;
            this.Car.Location = new System.Drawing.Point(96, 7);
            this.Car.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(121, 24);
            this.Car.TabIndex = 32;
            this.Car.ValueMember = "VehicleIdentificationNumber";
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.garageServiceDatabaseDataSet11;
            // 
            // OwnerFormButton
            // 
            this.OwnerFormButton.Location = new System.Drawing.Point(12, 582);
            this.OwnerFormButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OwnerFormButton.Name = "OwnerFormButton";
            this.OwnerFormButton.Size = new System.Drawing.Size(109, 48);
            this.OwnerFormButton.TabIndex = 22;
            this.OwnerFormButton.Text = "Edit Service";
            this.OwnerFormButton.UseVisualStyleBackColor = true;
            this.OwnerFormButton.Click += new System.EventHandler(this.ServiceForm_Click);
            // 
            // ServiceFormButton
            // 
            this.ServiceFormButton.Location = new System.Drawing.Point(12, 37);
            this.ServiceFormButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServiceFormButton.Name = "ServiceFormButton";
            this.ServiceFormButton.Size = new System.Drawing.Size(109, 48);
            this.ServiceFormButton.TabIndex = 21;
            this.ServiceFormButton.Text = "Quit";
            this.ServiceFormButton.UseVisualStyleBackColor = true;
            this.ServiceFormButton.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // serviceIDDataGridViewTextBoxColumn1
            // 
            this.serviceIDDataGridViewTextBoxColumn1.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn1.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn1.Name = "serviceIDDataGridViewTextBoxColumn1";
            // 
            // vehicleIdentificationNumberDataGridViewTextBoxColumn1
            // 
            this.vehicleIdentificationNumberDataGridViewTextBoxColumn1.DataPropertyName = "VehicleIdentificationNumber";
            this.vehicleIdentificationNumberDataGridViewTextBoxColumn1.HeaderText = "VehicleIdentificationNumber";
            this.vehicleIdentificationNumberDataGridViewTextBoxColumn1.Name = "vehicleIdentificationNumberDataGridViewTextBoxColumn1";
            // 
            // registrationNumberDataGridViewTextBoxColumn1
            // 
            this.registrationNumberDataGridViewTextBoxColumn1.DataPropertyName = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn1.HeaderText = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn1.Name = "registrationNumberDataGridViewTextBoxColumn1";
            // 
            // dateofNextMOTDataGridViewTextBoxColumn1
            // 
            this.dateofNextMOTDataGridViewTextBoxColumn1.DataPropertyName = "DateofNextMOT";
            this.dateofNextMOTDataGridViewTextBoxColumn1.HeaderText = "DateofNextMOT";
            this.dateofNextMOTDataGridViewTextBoxColumn1.Name = "dateofNextMOTDataGridViewTextBoxColumn1";
            // 
            // dateofLastMOTDataGridViewTextBoxColumn1
            // 
            this.dateofLastMOTDataGridViewTextBoxColumn1.DataPropertyName = "DateofLastMOT";
            this.dateofLastMOTDataGridViewTextBoxColumn1.HeaderText = "DateofLastMOT";
            this.dateofLastMOTDataGridViewTextBoxColumn1.Name = "dateofLastMOTDataGridViewTextBoxColumn1";
            // 
            // mOTCertificateDataGridViewTextBoxColumn1
            // 
            this.mOTCertificateDataGridViewTextBoxColumn1.DataPropertyName = "MOTCertificate";
            this.mOTCertificateDataGridViewTextBoxColumn1.HeaderText = "MOTCertificate";
            this.mOTCertificateDataGridViewTextBoxColumn1.Name = "mOTCertificateDataGridViewTextBoxColumn1";
            // 
            // dateOfNextServiceDataGridViewTextBoxColumn1
            // 
            this.dateOfNextServiceDataGridViewTextBoxColumn1.DataPropertyName = "DateOfNextService";
            this.dateOfNextServiceDataGridViewTextBoxColumn1.HeaderText = "DateOfNextService";
            this.dateOfNextServiceDataGridViewTextBoxColumn1.Name = "dateOfNextServiceDataGridViewTextBoxColumn1";
            // 
            // dateOfLastServiceDataGridViewTextBoxColumn1
            // 
            this.dateOfLastServiceDataGridViewTextBoxColumn1.DataPropertyName = "DateOfLastService";
            this.dateOfLastServiceDataGridViewTextBoxColumn1.HeaderText = "DateOfLastService";
            this.dateOfLastServiceDataGridViewTextBoxColumn1.Name = "dateOfLastServiceDataGridViewTextBoxColumn1";
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // garageServicetableAdapterManager
            // 
            this.garageServicetableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.garageServicetableAdapterManager.CarTableAdapter = this.carTableAdapter;
            this.garageServicetableAdapterManager.OwnerTableAdapter = this.ownerTableAdapter;
            this.garageServicetableAdapterManager.ServiceTableAdapter = this.serviceTableAdapter;
            this.garageServicetableAdapterManager.UpdateOrder = GarageServiceWindowsForms.GarageServiceDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ownerTableAdapter
            // 
            this.ownerTableAdapter.ClearBeforeFill = true;
            // 
            // addService
            // 
            this.addService.Location = new System.Drawing.Point(12, 512);
            this.addService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addService.Name = "addService";
            this.addService.Size = new System.Drawing.Size(109, 48);
            this.addService.TabIndex = 23;
            this.addService.Text = "Add Service";
            this.addService.UseVisualStyleBackColor = true;
            this.addService.Click += new System.EventHandler(this.addService_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 649);
            this.Controls.Add(this.addService);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OwnerFormButton);
            this.Controls.Add(this.ServiceFormButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.Text = "Garage Service Form";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageServiceDatabaseDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button OwnerFormButton;
        private System.Windows.Forms.Button ServiceFormButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Car;
        private System.Windows.Forms.DateTimePicker ServiceDate;
        private System.Windows.Forms.ComboBox cmbOwner;
        private System.Windows.Forms.CheckBox Ownercheckbox;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox Carcheckbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIdentificationNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofNextMOTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofLastMOTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOTCertificateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfNextServiceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfLastServiceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOTCertificateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfNextServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfLastServiceDataGridViewTextBoxColumn;
        private GarageServiceDatabaseDataSet1 garageServiceDatabaseDataSet11;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private GarageServiceDatabaseDataSet1TableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.BindingSource carBindingSource;
        private GarageServiceDatabaseDataSet1TableAdapters.CarTableAdapter carTableAdapter;
        private GarageServiceDatabaseDataSet1TableAdapters.TableAdapterManager garageServicetableAdapterManager;
        private GarageServiceDatabaseDataSet1TableAdapters.OwnerTableAdapter ownerTableAdapter;
        private System.Windows.Forms.BindingSource ownerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIdentificationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofNextMOTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofLastMOTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addService;
    }
}