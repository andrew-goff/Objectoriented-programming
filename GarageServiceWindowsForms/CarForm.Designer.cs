namespace GarageServiceWindowsForms
{
    partial class CarForm
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
            System.Windows.Forms.Label MOTCertificateLabel;
            this.DeleteButton = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.UpdateDataButton = new System.Windows.Forms.Button();
            this.AddDataButton = new System.Windows.Forms.Button();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EditOwner = new System.Windows.Forms.Button();
            this.MOTCertificate = new System.Windows.Forms.TextBox();
            this.textBoxMileage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerLastService = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerNextService = new System.Windows.Forms.DateTimePicker();
            this.AddOwner = new System.Windows.Forms.Button();
            this.cmbOwner = new System.Windows.Forms.ComboBox();
            this.ownerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.garageServiceDatabaseDataSet11 = new GarageServiceWindowsForms.GarageServiceDatabaseDataSet1();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textAirbags = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAircon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textColour = new System.Windows.Forms.TextBox();
            this.textNoofDoors = new System.Windows.Forms.TextBox();
            this.txtEngineSize = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ownerIDLabel = new System.Windows.Forms.Label();
            this.VINLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.TxtVehicleID = new System.Windows.Forms.TextBox();
            this.TxtManufacturer = new System.Windows.Forms.TextBox();
            this.TxtRegNum = new System.Windows.Forms.TextBox();
            this.HomeButton = new System.Windows.Forms.Button();
            this.carTableAdapter1 = new GarageServiceWindowsForms.GarageServiceDatabaseDataSet1TableAdapters.CarTableAdapter();
            this.ownerTableAdapter1 = new GarageServiceWindowsForms.GarageServiceDatabaseDataSet1TableAdapters.OwnerTableAdapter();
            this.tableAdapterManager1 = new GarageServiceWindowsForms.GarageServiceDatabaseDataSet1TableAdapters.TableAdapterManager();
            MOTCertificateLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageServiceDatabaseDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // MOTCertificateLabel
            // 
            MOTCertificateLabel.AutoSize = true;
            MOTCertificateLabel.Location = new System.Drawing.Point(163, 823);
            MOTCertificateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            MOTCertificateLabel.Name = "MOTCertificateLabel";
            MOTCertificateLabel.Size = new System.Drawing.Size(110, 17);
            MOTCertificateLabel.TabIndex = 50;
            MOTCertificateLabel.Text = "MOT Certificate:";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(11, 841);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(132, 48);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete Data";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteData_Click);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(285, 294);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(287, 22);
            this.txtModel.TabIndex = 26;
            this.txtModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModel_KeyPress_Click);
            this.txtModel.Validated += new System.EventHandler(this.validationCheck);
            // 
            // UpdateDataButton
            // 
            this.UpdateDataButton.Location = new System.Drawing.Point(12, 567);
            this.UpdateDataButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateDataButton.Name = "UpdateDataButton";
            this.UpdateDataButton.Size = new System.Drawing.Size(132, 48);
            this.UpdateDataButton.TabIndex = 13;
            this.UpdateDataButton.Text = "Update Data";
            this.UpdateDataButton.UseVisualStyleBackColor = true;
            this.UpdateDataButton.Click += new System.EventHandler(this.UpdateData_Click);
            // 
            // AddDataButton
            // 
            this.AddDataButton.Location = new System.Drawing.Point(11, 286);
            this.AddDataButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddDataButton.Name = "AddDataButton";
            this.AddDataButton.Size = new System.Drawing.Size(132, 48);
            this.AddDataButton.TabIndex = 12;
            this.AddDataButton.Text = "Add Data";
            this.AddDataButton.UseVisualStyleBackColor = true;
            this.AddDataButton.Click += new System.EventHandler(this.AddData_Click);
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(228, 299);
            this.ModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(50, 17);
            this.ModelLabel.TabIndex = 27;
            this.ModelLabel.Text = "Model:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EditOwner);
            this.groupBox1.Controls.Add(MOTCertificateLabel);
            this.groupBox1.Controls.Add(this.MOTCertificate);
            this.groupBox1.Controls.Add(this.textBoxMileage);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTimePickerLastService);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePickerNextService);
            this.groupBox1.Controls.Add(this.AddOwner);
            this.groupBox1.Controls.Add(this.cmbOwner);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textAirbags);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtAircon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textColour);
            this.groupBox1.Controls.Add(this.textNoofDoors);
            this.groupBox1.Controls.Add(this.txtEngineSize);
            this.groupBox1.Controls.Add(this.vScrollBar1);
            this.groupBox1.Controls.Add(this.ModelLabel);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.ManufacturerLabel);
            this.groupBox1.Controls.Add(this.ownerIDLabel);
            this.groupBox1.Controls.Add(this.VINLabel);
            this.groupBox1.Controls.Add(this.SubmitButton);
            this.groupBox1.Controls.Add(this.TxtVehicleID);
            this.groupBox1.Controls.Add(this.TxtManufacturer);
            this.groupBox1.Controls.Add(this.TxtRegNum);
            this.groupBox1.Location = new System.Drawing.Point(149, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(655, 882);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // EditOwner
            // 
            this.EditOwner.Enabled = false;
            this.EditOwner.Location = new System.Drawing.Point(579, 142);
            this.EditOwner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditOwner.Name = "EditOwner";
            this.EditOwner.Size = new System.Drawing.Size(43, 25);
            this.EditOwner.TabIndex = 53;
            this.EditOwner.Text = "Edit";
            this.EditOwner.UseVisualStyleBackColor = true;
            this.EditOwner.Click += new System.EventHandler(this.EditOwnerForm_Click);
            // 
            // MOTCertificate
            // 
            this.MOTCertificate.Location = new System.Drawing.Point(283, 820);
            this.MOTCertificate.Margin = new System.Windows.Forms.Padding(4);
            this.MOTCertificate.Name = "MOTCertificate";
            this.MOTCertificate.Size = new System.Drawing.Size(287, 22);
            this.MOTCertificate.TabIndex = 52;
            this.MOTCertificate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MOTCertificate_KeyPress_Click);
            this.MOTCertificate.Validated += new System.EventHandler(this.validationCheck);
            // 
            // textBoxMileage
            // 
            this.textBoxMileage.Location = new System.Drawing.Point(283, 768);
            this.textBoxMileage.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMileage.Name = "textBoxMileage";
            this.textBoxMileage.Size = new System.Drawing.Size(287, 22);
            this.textBoxMileage.TabIndex = 51;
            this.textBoxMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMileage_KeyPress_Click);
            this.textBoxMileage.Validated += new System.EventHandler(this.validationCheck);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 768);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "Mileage:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 718);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 17);
            this.label8.TabIndex = 50;
            this.label8.Text = "Date of Last Service:";
            // 
            // dateTimePickerLastService
            // 
            this.dateTimePickerLastService.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerLastService.Location = new System.Drawing.Point(283, 713);
            this.dateTimePickerLastService.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerLastService.Name = "dateTimePickerLastService";
            this.dateTimePickerLastService.Size = new System.Drawing.Size(287, 22);
            this.dateTimePickerLastService.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 657);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Date of Next Service:";
            // 
            // dateTimePickerNextService
            // 
            this.dateTimePickerNextService.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNextService.Location = new System.Drawing.Point(283, 657);
            this.dateTimePickerNextService.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerNextService.Name = "dateTimePickerNextService";
            this.dateTimePickerNextService.Size = new System.Drawing.Size(287, 22);
            this.dateTimePickerNextService.TabIndex = 45;
            // 
            // AddOwner
            // 
            this.AddOwner.Location = new System.Drawing.Point(579, 102);
            this.AddOwner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddOwner.Name = "AddOwner";
            this.AddOwner.Size = new System.Drawing.Size(43, 25);
            this.AddOwner.TabIndex = 44;
            this.AddOwner.Text = "+";
            this.AddOwner.UseVisualStyleBackColor = true;
            this.AddOwner.Click += new System.EventHandler(this.AddOwnerForm_Click);
            // 
            // cmbOwner
            // 
            this.cmbOwner.DataSource = this.ownerBindingSource;
            this.cmbOwner.DisplayMember = "OwnerFirstName";
            this.cmbOwner.FormattingEnabled = true;
            this.cmbOwner.Location = new System.Drawing.Point(289, 103);
            this.cmbOwner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(287, 24);
            this.cmbOwner.TabIndex = 43;
            this.cmbOwner.UseWaitCursor = true;
            this.cmbOwner.ValueMember = "OwnerID";
            // 
            // ownerBindingSource
            // 
            this.ownerBindingSource.DataMember = "Owner";
            this.ownerBindingSource.DataSource = this.garageServiceDatabaseDataSet11;
            // 
            // garageServiceDatabaseDataSet11
            // 
            this.garageServiceDatabaseDataSet11.DataSetName = "GarageServiceDatabaseDataSet1";
            this.garageServiceDatabaseDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Registration Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 599);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Airbags:";
            // 
            // textAirbags
            // 
            this.textAirbags.Location = new System.Drawing.Point(285, 599);
            this.textAirbags.Margin = new System.Windows.Forms.Padding(4);
            this.textAirbags.Name = "textAirbags";
            this.textAirbags.Size = new System.Drawing.Size(287, 22);
            this.textAirbags.TabIndex = 39;
            this.textAirbags.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAirbags_KeyPress_Click);
            this.textAirbags.Validated += new System.EventHandler(this.validationCheck);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 534);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Aircon:";
            // 
            // TxtAircon
            // 
            this.TxtAircon.Location = new System.Drawing.Point(285, 534);
            this.TxtAircon.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAircon.Name = "TxtAircon";
            this.TxtAircon.Size = new System.Drawing.Size(287, 22);
            this.TxtAircon.TabIndex = 37;
            this.TxtAircon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAircon_KeyPress_Click);
            this.TxtAircon.Validated += new System.EventHandler(this.validationCheck);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 479);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Colour:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 411);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "No of Doors:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 359);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Engine Size:";
            // 
            // textColour
            // 
            this.textColour.Location = new System.Drawing.Point(285, 474);
            this.textColour.Margin = new System.Windows.Forms.Padding(4);
            this.textColour.Name = "textColour";
            this.textColour.Size = new System.Drawing.Size(287, 22);
            this.textColour.TabIndex = 33;
            this.textColour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textColour_KeyPress_Click);
            this.textColour.Validated += new System.EventHandler(this.validationCheck);
            // 
            // textNoofDoors
            // 
            this.textNoofDoors.Location = new System.Drawing.Point(285, 411);
            this.textNoofDoors.Margin = new System.Windows.Forms.Padding(4);
            this.textNoofDoors.Name = "textNoofDoors";
            this.textNoofDoors.Size = new System.Drawing.Size(287, 22);
            this.textNoofDoors.TabIndex = 32;
            this.textNoofDoors.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNoofDoors_KeyPress_Click);
            this.textNoofDoors.Validated += new System.EventHandler(this.validationCheck);
            // 
            // txtEngineSize
            // 
            this.txtEngineSize.Location = new System.Drawing.Point(285, 359);
            this.txtEngineSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtEngineSize.Name = "txtEngineSize";
            this.txtEngineSize.Size = new System.Drawing.Size(287, 22);
            this.txtEngineSize.TabIndex = 31;
            this.txtEngineSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEngineSize_KeyPress_Click);
            this.txtEngineSize.Validated += new System.EventHandler(this.validationCheck);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(628, 18);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 862);
            this.vScrollBar1.TabIndex = 29;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(181, 233);
            this.ManufacturerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(96, 17);
            this.ManufacturerLabel.TabIndex = 24;
            this.ManufacturerLabel.Text = "Manufacturer:";
            // 
            // ownerIDLabel
            // 
            this.ownerIDLabel.AutoSize = true;
            this.ownerIDLabel.Location = new System.Drawing.Point(213, 106);
            this.ownerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ownerIDLabel.Name = "ownerIDLabel";
            this.ownerIDLabel.Size = new System.Drawing.Size(70, 17);
            this.ownerIDLabel.TabIndex = 50;
            this.ownerIDLabel.Text = "Owner ID:";
            // 
            // VINLabel
            // 
            this.VINLabel.AutoSize = true;
            this.VINLabel.Location = new System.Drawing.Point(88, 50);
            this.VINLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VINLabel.Name = "VINLabel";
            this.VINLabel.Size = new System.Drawing.Size(195, 17);
            this.VINLabel.TabIndex = 18;
            this.VINLabel.Text = "Vehicle Identification Number:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(507, 844);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(115, 34);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit Data";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.AddData_Click);
            // 
            // TxtVehicleID
            // 
            this.TxtVehicleID.Location = new System.Drawing.Point(289, 50);
            this.TxtVehicleID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtVehicleID.Name = "TxtVehicleID";
            this.TxtVehicleID.ReadOnly = true;
            this.TxtVehicleID.Size = new System.Drawing.Size(287, 22);
            this.TxtVehicleID.TabIndex = 13;
            this.TxtVehicleID.Validated += new System.EventHandler(this.validationCheck);
            // 
            // TxtManufacturer
            // 
            this.TxtManufacturer.Location = new System.Drawing.Point(285, 230);
            this.TxtManufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.TxtManufacturer.Name = "TxtManufacturer";
            this.TxtManufacturer.Size = new System.Drawing.Size(287, 22);
            this.TxtManufacturer.TabIndex = 12;
            this.TxtManufacturer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtManufacturer_KeyPress_Click);
            this.TxtManufacturer.Validated += new System.EventHandler(this.validationCheck);
            // 
            // TxtRegNum
            // 
            this.TxtRegNum.Location = new System.Drawing.Point(289, 169);
            this.TxtRegNum.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRegNum.Name = "TxtRegNum";
            this.TxtRegNum.Size = new System.Drawing.Size(287, 22);
            this.TxtRegNum.TabIndex = 11;
            this.TxtRegNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRegNum_KeyPress_Click);
            this.TxtRegNum.Validated += new System.EventHandler(this.validationCheck);
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(12, 14);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(132, 48);
            this.HomeButton.TabIndex = 11;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.ServiceForm_Click);
            // 
            // carTableAdapter1
            // 
            this.carTableAdapter1.ClearBeforeFill = true;
            // 
            // ownerTableAdapter1
            // 
            this.ownerTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CarTableAdapter = this.carTableAdapter1;
            this.tableAdapterManager1.OwnerTableAdapter = this.ownerTableAdapter1;
            this.tableAdapterManager1.ServiceTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = GarageServiceWindowsForms.GarageServiceDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 891);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateDataButton);
            this.Controls.Add(this.AddDataButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HomeButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "CarForm";
            this.ShowIcon = false;
            this.Text = "Garage Service Form";
            this.Load += new System.EventHandler(this.CarForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageServiceDatabaseDataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button UpdateDataButton;
        private System.Windows.Forms.Button AddDataButton;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ownerIDLabel;
        private System.Windows.Forms.Label VINLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox TxtVehicleID;
        private System.Windows.Forms.TextBox TxtManufacturer;
        private System.Windows.Forms.TextBox TxtRegNum;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox textColour;
        private System.Windows.Forms.TextBox textNoofDoors;
        private System.Windows.Forms.TextBox txtEngineSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAircon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAirbags;
        private GarageServiceDatabaseDataSet1 garageServiceDatabaseDataSet11;
        private GarageServiceDatabaseDataSet1TableAdapters.CarTableAdapter carTableAdapter1;
        private GarageServiceDatabaseDataSet1TableAdapters.OwnerTableAdapter ownerTableAdapter1;
        private GarageServiceDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbOwner;
        private System.Windows.Forms.Button AddOwner;
        private System.Windows.Forms.DateTimePicker dateTimePickerNextService;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerLastService;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMileage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MOTCertificate;
        private System.Windows.Forms.Button EditOwner;
        private System.Windows.Forms.BindingSource ownerBindingSource;
    }
}