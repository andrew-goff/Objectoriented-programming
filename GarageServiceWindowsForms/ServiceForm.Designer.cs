namespace GarageServiceWindowsForms
{
    partial class ServiceForm
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
            System.Windows.Forms.Label ServiceIDLabel;
            System.Windows.Forms.Label DateofNextMOTLabel;
            System.Windows.Forms.Label DateofLastMOTLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label DateofLastServiceLabel;
            System.Windows.Forms.Label label1;
            this.UpdateDataButton = new System.Windows.Forms.Button();
            this.DeleteDataButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TxtServiceID = new System.Windows.Forms.TextBox();
            this.serviceMOTDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LastMOTdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EditCar = new System.Windows.Forms.Button();
            this.txtVehicleIDnum = new System.Windows.Forms.TextBox();
            this.AddRegistrationNumber = new System.Windows.Forms.Button();
            this.Car = new System.Windows.Forms.ComboBox();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.garageServiceDatabaseDataSet = new GarageServiceWindowsForms.GarageServiceDatabaseDataSet();
            this.dateofServiceTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddData = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.garageServiceDatabaseDataSet11 = new GarageServiceWindowsForms.GarageServiceDatabaseDataSet1();
            this.carTableAdapter1 = new GarageServiceWindowsForms.GarageServiceDatabaseDataSetTableAdapters.CarTableAdapter();
            this.addImage = new System.Windows.Forms.Button();
            ServiceIDLabel = new System.Windows.Forms.Label();
            DateofNextMOTLabel = new System.Windows.Forms.Label();
            DateofLastMOTLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            DateofLastServiceLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageServiceDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageServiceDatabaseDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceIDLabel
            // 
            ServiceIDLabel.AutoSize = true;
            ServiceIDLabel.Location = new System.Drawing.Point(204, 26);
            ServiceIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ServiceIDLabel.Name = "ServiceIDLabel";
            ServiceIDLabel.Size = new System.Drawing.Size(76, 17);
            ServiceIDLabel.TabIndex = 18;
            ServiceIDLabel.Text = "Service ID:";
            // 
            // DateofNextMOTLabel
            // 
            DateofNextMOTLabel.AutoSize = true;
            DateofNextMOTLabel.Location = new System.Drawing.Point(149, 273);
            DateofNextMOTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DateofNextMOTLabel.Name = "DateofNextMOTLabel";
            DateofNextMOTLabel.Size = new System.Drawing.Size(125, 17);
            DateofNextMOTLabel.TabIndex = 19;
            DateofNextMOTLabel.Text = "Date of Next MOT:";
            // 
            // DateofLastMOTLabel
            // 
            DateofLastMOTLabel.AutoSize = true;
            DateofLastMOTLabel.Location = new System.Drawing.Point(152, 369);
            DateofLastMOTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DateofLastMOTLabel.Name = "DateofLastMOTLabel";
            DateofLastMOTLabel.Size = new System.Drawing.Size(124, 17);
            DateofLastMOTLabel.TabIndex = 20;
            DateofLastMOTLabel.Text = "Date of Last MOT:";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(143, 103);
            customerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(142, 17);
            customerIDLabel.TabIndex = 21;
            customerIDLabel.Text = "Registration Number:";
            // 
            // DateofLastServiceLabel
            // 
            DateofLastServiceLabel.AutoSize = true;
            DateofLastServiceLabel.Location = new System.Drawing.Point(167, 455);
            DateofLastServiceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DateofLastServiceLabel.Name = "DateofLastServiceLabel";
            DateofLastServiceLabel.Size = new System.Drawing.Size(109, 17);
            DateofLastServiceLabel.TabIndex = 22;
            DateofLastServiceLabel.Text = "Date of Service:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(73, 191);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(203, 17);
            label1.TabIndex = 35;
            label1.Text = "Vehichle Identification Number:";
            // 
            // UpdateDataButton
            // 
            this.UpdateDataButton.Location = new System.Drawing.Point(11, 162);
            this.UpdateDataButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateDataButton.Name = "UpdateDataButton";
            this.UpdateDataButton.Size = new System.Drawing.Size(132, 48);
            this.UpdateDataButton.TabIndex = 2;
            this.UpdateDataButton.Text = "Update Data";
            this.UpdateDataButton.UseVisualStyleBackColor = true;
            this.UpdateDataButton.Click += new System.EventHandler(this.UpdateForm_Click);
            // 
            // DeleteDataButton
            // 
            this.DeleteDataButton.Location = new System.Drawing.Point(11, 319);
            this.DeleteDataButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteDataButton.Name = "DeleteDataButton";
            this.DeleteDataButton.Size = new System.Drawing.Size(132, 48);
            this.DeleteDataButton.TabIndex = 3;
            this.DeleteDataButton.Text = "Delete Data";
            this.DeleteDataButton.UseVisualStyleBackColor = true;
            this.DeleteDataButton.Click += new System.EventHandler(this.DeleteForm_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(12, 468);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(132, 48);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Home";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close_Click);
            // 
            // TxtServiceID
            // 
            this.TxtServiceID.Location = new System.Drawing.Point(291, 22);
            this.TxtServiceID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtServiceID.Name = "TxtServiceID";
            this.TxtServiceID.ReadOnly = true;
            this.TxtServiceID.Size = new System.Drawing.Size(265, 22);
            this.TxtServiceID.TabIndex = 13;
            this.TxtServiceID.Validated += new System.EventHandler(this.validationCheck);
            // 
            // serviceMOTDateTimePicker
            // 
            this.serviceMOTDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.serviceMOTDateTimePicker.Location = new System.Drawing.Point(287, 273);
            this.serviceMOTDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.serviceMOTDateTimePicker.Name = "serviceMOTDateTimePicker";
            this.serviceMOTDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.serviceMOTDateTimePicker.TabIndex = 14;
            this.serviceMOTDateTimePicker.Validated += new System.EventHandler(this.validationCheck);
            // 
            // LastMOTdateTimePicker
            // 
            this.LastMOTdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.LastMOTdateTimePicker.Location = new System.Drawing.Point(287, 369);
            this.LastMOTdateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.LastMOTdateTimePicker.Name = "LastMOTdateTimePicker";
            this.LastMOTdateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.LastMOTdateTimePicker.TabIndex = 15;
            this.LastMOTdateTimePicker.Validated += new System.EventHandler(this.validationCheck);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EditCar);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.txtVehicleIDnum);
            this.groupBox1.Controls.Add(this.AddRegistrationNumber);
            this.groupBox1.Controls.Add(this.Car);
            this.groupBox1.Controls.Add(DateofLastServiceLabel);
            this.groupBox1.Controls.Add(customerIDLabel);
            this.groupBox1.Controls.Add(DateofLastMOTLabel);
            this.groupBox1.Controls.Add(DateofNextMOTLabel);
            this.groupBox1.Controls.Add(ServiceIDLabel);
            this.groupBox1.Controls.Add(this.dateofServiceTimePicker);
            this.groupBox1.Controls.Add(this.LastMOTdateTimePicker);
            this.groupBox1.Controls.Add(this.serviceMOTDateTimePicker);
            this.groupBox1.Controls.Add(this.TxtServiceID);
            this.groupBox1.Location = new System.Drawing.Point(149, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(560, 503);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // EditCar
            // 
            this.EditCar.Enabled = false;
            this.EditCar.Location = new System.Drawing.Point(509, 127);
            this.EditCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditCar.Name = "EditCar";
            this.EditCar.Size = new System.Drawing.Size(43, 25);
            this.EditCar.TabIndex = 54;
            this.EditCar.Text = "Edit";
            this.EditCar.UseVisualStyleBackColor = true;
            this.EditCar.Click += new System.EventHandler(this.carEdit);
            // 
            // txtVehicleIDnum
            // 
            this.txtVehicleIDnum.Location = new System.Drawing.Point(287, 191);
            this.txtVehicleIDnum.Margin = new System.Windows.Forms.Padding(4);
            this.txtVehicleIDnum.Name = "txtVehicleIDnum";
            this.txtVehicleIDnum.ReadOnly = true;
            this.txtVehicleIDnum.Size = new System.Drawing.Size(268, 22);
            this.txtVehicleIDnum.TabIndex = 34;
            this.txtVehicleIDnum.Validated += new System.EventHandler(this.validationCheck);
            // 
            // AddRegistrationNumber
            // 
            this.AddRegistrationNumber.Location = new System.Drawing.Point(511, 98);
            this.AddRegistrationNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRegistrationNumber.Name = "AddRegistrationNumber";
            this.AddRegistrationNumber.Size = new System.Drawing.Size(43, 25);
            this.AddRegistrationNumber.TabIndex = 30;
            this.AddRegistrationNumber.Text = "+";
            this.AddRegistrationNumber.UseVisualStyleBackColor = true;
            this.AddRegistrationNumber.Click += new System.EventHandler(this.CarForm_Click);
            // 
            // Car
            // 
            this.Car.DataSource = this.carBindingSource;
            this.Car.DisplayMember = "RegistrationNumber";
            this.Car.FormattingEnabled = true;
            this.Car.Location = new System.Drawing.Point(291, 97);
            this.Car.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(215, 24);
            this.Car.TabIndex = 33;
            this.Car.ValueMember = "VehicleIdentificationNumber";
            this.Car.SelectedIndexChanged += new System.EventHandler(this.Car_SelectedIndexChanged);
            this.Car.Validated += new System.EventHandler(this.validationCheck);
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.garageServiceDatabaseDataSet;
            // 
            // garageServiceDatabaseDataSet
            // 
            this.garageServiceDatabaseDataSet.DataSetName = "GarageServiceDatabaseDataSet";
            this.garageServiceDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateofServiceTimePicker
            // 
            this.dateofServiceTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateofServiceTimePicker.Location = new System.Drawing.Point(287, 455);
            this.dateofServiceTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateofServiceTimePicker.Name = "dateofServiceTimePicker";
            this.dateofServiceTimePicker.Size = new System.Drawing.Size(265, 22);
            this.dateofServiceTimePicker.TabIndex = 16;
            // 
            // AddData
            // 
            this.AddData.Location = new System.Drawing.Point(11, 11);
            this.AddData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddData.Name = "AddData";
            this.AddData.Size = new System.Drawing.Size(132, 48);
            this.AddData.TabIndex = 29;
            this.AddData.Text = "Add Data";
            this.AddData.UseVisualStyleBackColor = true;
            this.AddData.Click += new System.EventHandler(this.AddForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(149, 521);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 183);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.garageServiceDatabaseDataSet;
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
            // addImage
            // 
            this.addImage.Location = new System.Drawing.Point(10, 650);
            this.addImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addImage.Name = "addImage";
            this.addImage.Size = new System.Drawing.Size(132, 48);
            this.addImage.TabIndex = 32;
            this.addImage.Text = "Add Image";
            this.addImage.UseVisualStyleBackColor = true;
            this.addImage.Click += new System.EventHandler(this.addImage_Click);
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 709);
            this.Controls.Add(this.addImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddData);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DeleteDataButton);
            this.Controls.Add(this.UpdateDataButton);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ServiceForm";
            this.ShowIcon = false;
            this.Text = "Garage Service Form";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageServiceDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageServiceDatabaseDataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UpdateDataButton;
        private System.Windows.Forms.Button DeleteDataButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox TxtServiceID;
        private System.Windows.Forms.DateTimePicker serviceMOTDateTimePicker;
        private System.Windows.Forms.DateTimePicker LastMOTdateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateofServiceTimePicker;
        private System.Windows.Forms.Button AddData;
        private GarageServiceDatabaseDataSet1 garageServiceDatabaseDataSet11;
        private GarageServiceDatabaseDataSet1TableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.ComboBox Car;
        private System.Windows.Forms.Button AddRegistrationNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtVehicleIDnum;
        private GarageServiceDatabaseDataSet garageServiceDatabaseDataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.BindingSource carBindingSource;
        private GarageServiceDatabaseDataSetTableAdapters.CarTableAdapter carTableAdapter1;
        private System.Windows.Forms.Button EditCar;
        private System.Windows.Forms.Button addImage;
    }
}

