//AndrewG8460
//Service form that allows editing or adding details of a car service
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace GarageServiceWindowsForms
{
    public partial class ServiceForm : Form
    {
        //Intialise the boolean value, the data table and the dataset
        DataTable dt;
        SqlDataAdapter daService;
        SearchForm parent;
        string serviceId;
        bool adding = false;

        public ServiceForm(SearchForm parent, string serviceId, bool addMode)
        {
            this.parent = parent;
            this.serviceId = serviceId;
            this.adding = addMode;

            InitializeComponent();

            dt = new DataTable();
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            // Loads the car table adapter into the 'garageServiceDatabaseDataSet.Car' table.
            this.carTableAdapter1.Fill(this.garageServiceDatabaseDataSet.Car);
            //this.carTableAdapter.Fill(this.garageServiceDatabaseDataSet11.Car);

            AddData.Enabled = false;
            try
            {
                // set up the database connection and retrieve the Owner
                string connectString = Properties.Settings.Default.GarageServiceDatabaseConnectionString;

                SqlConnection con = new SqlConnection(connectString);
                con.Open();
                
                string sqlString = "Select * FROM Service;";
                daService = new SqlDataAdapter(sqlString, con);
                SqlCommandBuilder cbOwner = new SqlCommandBuilder(daService); // enables update and delete

                //caches the owner in the dataset
                daService.Fill(dt);
                if (serviceId != null)
                {
                        sqlString = sqlString + string.Format(" WHERE ServiceID = '{0}'", serviceId);
                }

                //cmbOwner_Load();
                con.Close();
                
             }
            //Brings up an error message if the database cannot be read
            catch (Exception ex)
            {
                MessageBox.Show("Error reading the database:" + ex.ToString());
            } 

            AddData.Enabled = false;

            //Disables the update data and delete data buttons if the add service button has been clicked on
            if (adding)
            {
                //Enable Add button, disable the add Update, delete buttons
                TxtServiceID.Text = Guid.NewGuid().ToString();
                Car.SelectedIndex = -1;            
                UpdateDataButton.Enabled = false;
                DeleteDataButton.Enabled = false;
            }
            //Enables the update data and delete data buttons if the edit service button has been clicked on
            else
            {
                DataRow dr = dt.Select("ServiceID = '" + serviceId + "'")[0];

                // Add new row to the Dataset
                // disable Add button , enable the add Update, delete buttons
                TxtServiceID.Text = serviceId;
                txtVehicleIDnum.Text = dr["VehicleIdentificationNumber"].ToString();
                Car.Text = dr["RegistrationNumber"].ToString();
                serviceMOTDateTimePicker.Value = (DateTime) dr["DateOfNextMOT"];
                LastMOTdateTimePicker.Value = (DateTime) dr["DateOfLastMOT"];
                dateofServiceTimePicker.Value = (DateTime) dr["DateOfService"];
                //Check for null in the Car Picture field
                if (!dr.IsNull("CarPicture"))
                {
                    pictureBox1.Image = (Image)byteArrayToImage((byte[])dr["CarPicture"]);
                    adjustImage();
                }

                UpdateDataButton.Enabled = true;
                DeleteDataButton.Enabled = true;
           }
        }

        private void validationCheck(object sender, EventArgs e)
        {
            bool valid = true;

            //Check VehicleID form is not empty
            if (Car.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a vehicle");
                valid = false;
                EditCar.Enabled = false;
            }
            //Check that the edit Car button is enabled and the MOT dates are correct
            else
            {
                EditCar.Enabled = true;
                DateTime rDateOfNextMOT = serviceMOTDateTimePicker.Value;
                DateTime rDateOfLastMOT = LastMOTdateTimePicker.Value; 
                DateTime rDateOfService = dateofServiceTimePicker.Value;
                if (rDateOfNextMOT < rDateOfLastMOT)
                {
                    MessageBox.Show("Incorrect MOT dates"); 
                    valid = false;
                }
            }

            //Check whether the buttons should be enabled depending on the boolean value 
            AddData.Enabled = adding && valid;
            UpdateDataButton.Enabled = !adding && valid;
            DeleteDataButton.Enabled = !adding && valid;
        }

        private void Close_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void UpdateForm_Click(object sender, EventArgs e)
        {
            //Select a existing data row
            DataRow dr = dt.Select("ServiceID = '" + serviceId + "'")[0];

            // get data from form fields
            dr["VehicleIdentificationNumber"] = txtVehicleIDnum.Text;
            dr["RegistrationNumber"] = Car.Text;
            dr["DateOfNextMOT"] = serviceMOTDateTimePicker.Value;
            dr["DateOfLastMOT"] = LastMOTdateTimePicker.Value;
            dr["DateOfService"] = dateofServiceTimePicker.Value;
            dr["CarPicture"] = imageToByteArray(pictureBox1.Image);
            daService.Update(dt);
            this.Close();
        }

        private void AddForm_Click(object sender, EventArgs e)
        {
            //Add a new row to the data table
            DataRow dr = dt.NewRow();
 
            //Get data from form fields
            dr["ServiceID"] = TxtServiceID.Text;
            dr["VehicleIdentificationNumber"] = txtVehicleIDnum.Text;
            dr["RegistrationNumber"] = Car.Text;
            dr["DateOfNextMOT"] = serviceMOTDateTimePicker.Value;
            dr["DateOfLastMOT"] = LastMOTdateTimePicker.Value;
            dr["DateOfService"] = dateofServiceTimePicker.Value;
            dr["CarPicture"] = imageToByteArray(pictureBox1.Image);
            dt.Rows.Add(dr);
            //Update the services data table to the dataset
            daService.Update(dt);
            this.Close();
        }

        private void DeleteForm_Click(object sender, EventArgs e)
        {
            //Select an existing data row
            DataRow dr = dt.Select("ServiceID = '" + serviceId + "'")[0];
            dt.Rows.Remove(dr); // Manually remove the data row to table Service
            daService.Update(dt); //Update the services data table to the dataset
            this.Close();
        }

        private void serviceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void GarageServiceForm_Load(object sender, EventArgs e)
        {
        }

        private void CarForm_Click(object sender, EventArgs e)
        {
            //Bring up the Add Car windows form once it is clicked
            CarForm thirdForm = new CarForm(parent, null, true);
            thirdForm.Show();
        }

        private void addImage_Click(object sender, EventArgs e)
        {
            //Open up a file dialog to allow the user to choose an image to upload
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Load(openFileDialog1.FileName);
                    adjustImage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't load image " + openFileDialog1.FileName + " : " + ex.ToString());
                }
            }
        }

        private void adjustImage()
        {
            if (pictureBox1.Image != null)
            {
                //Adjust the image after loading it to the picture box
                if (pictureBox1.Width < pictureBox1.Image.Width && pictureBox1.Height < pictureBox1.Image.Height)
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                }
            }
        }
          
        private void Car_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check to see if there is a value selected in the Car drop down list
            if (Car.SelectedIndex == -1)
            {
                txtVehicleIDnum.Text = "";
            }
            else
            {
                txtVehicleIDnum.Text = Car.SelectedValue.ToString();
                
            }
        }

        private void carEdit(object sender, EventArgs e)
        {
            //Bring up the Edit Car form once it is enabled and clicked on
            CarForm thirdForm = new CarForm(parent, Car.SelectedValue.ToString(), false);
            thirdForm.ShowDialog(this);
        }

        private byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            //Check for null values before changing the image to bytes
            if (imageIn != null)
            {
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }

            return null;
        }

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            //Check for null values before changing the bytes to image
            if (byteArrayIn != null)
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }

            return null;
        }
    }
}