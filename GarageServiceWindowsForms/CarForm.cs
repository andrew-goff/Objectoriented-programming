//AndrewG8460
//Car form that allows editing or adding details of a car service
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GarageServiceWindowsForms
{
    public partial class CarForm : Form
    {
        //Intialise the boolean value, the data table and the dataset
        SearchForm parent;

        DataTable carDt;
        DataSet ownerDs;
        SqlDataAdapter daOwner;
        SqlDataAdapter daCar;
        bool adding;
        string carId;

        public CarForm(SearchForm parent, string carId, bool addMode)
        {
            this.parent = parent;
            this.carId = carId;
            this.adding = addMode;

            carDt = new DataTable();
            ownerDs = new DataSet();

            InitializeComponent();
        }

        private void ServiceForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            // Loads the car table adapter into the  'garageServiceDatabaseDataSet.Car' table. 
            this.carTableAdapter1.Fill(this.garageServiceDatabaseDataSet11.Car);
            // Loads the owner table adapter into the  'garageServiceDatabaseDataSet.Owner' table. 
            this.ownerTableAdapter1.Fill(this.garageServiceDatabaseDataSet11.Owner);

            try
            {
                // set up the database connection and retrieve the Car data table
                string connectString = Properties.Settings.Default.GarageServiceDatabaseConnectionString;

                SqlConnection con = new SqlConnection(connectString);
                con.Open();

                string sqlString = "Select * FROM Owner";
                daOwner = new SqlDataAdapter(sqlString, con);
                SqlCommandBuilder cbOwner = new SqlCommandBuilder(daOwner); // enables update and delete

                // cache the Car data in the Dataset
                daOwner.Fill(ownerDs, "Owner");
                
                cmbOwner.DisplayMember = "OwnerFirstName";
                cmbOwner.ValueMember = "OwnerID";
                cmbOwner.DataSource = ownerDs.Tables["Owner"];

                //Use a SQL string to select all the records from Car where there is a Vehicle Identification Number
                sqlString = "Select * FROM Car";
                if (carId != null)
                {
                    sqlString = sqlString + string.Format(" WHERE VehicleIdentificationNumber = '{0}'", carId);
                }
                
                daCar = new SqlDataAdapter(sqlString, con);
                SqlCommandBuilder cbCar = new SqlCommandBuilder(daCar);//enables update and delete
                //Fill the dataadapter car with the car data table
                daCar.Fill(carDt);
                
                con.Close();
            }
            //Brings up an error message if the database cannot be read
            catch (Exception ex)
            {
                MessageBox.Show("Error reading the database:" + ex.ToString());
            }
            //Disables the update data and delete data buttons if the add car button has been clicked on
            if (adding)
            {
                //Enable Add button, disable the add Update, delete buttons
                TxtVehicleID.Text = Guid.NewGuid().ToString();
                cmbOwner.SelectedIndex = -1;
                UpdateDataButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
            //Enables the update data and delete data buttons if the edit car button has been clicked on
            else
            {
                DataRow dr = carDt.Select("[VehicleIdentificationNumber] = '" + carId + "'")[0];
                // Add new row to the Dataset
                // disable Add button , enable the add Update, delete buttons
                TxtVehicleID.Text = dr["VehicleIdentificationNumber"].ToString();
                cmbOwner.Text = dr["OwnerID"].ToString();
                TxtRegNum.Text = dr["RegistrationNumber"].ToString();
                TxtManufacturer.Text = dr["Manufacturer"].ToString();
                txtModel.Text = dr["Model"].ToString();
                txtEngineSize.Text = dr["EngineSize"].ToString();
                textNoofDoors.Text = dr["NoOfDoors"].ToString();
                textColour.Text = dr["Colour"].ToString();
                TxtAircon.Text = dr["Aircon"].ToString();
                textAirbags.Text = dr["Airbags"].ToString();
                dateTimePickerNextService.Value = (DateTime) dr["DateOfNextService"];
                dateTimePickerLastService.Value = (DateTime) dr["DateOfLastService"];
                textBoxMileage.Text = dr["Mileage"].ToString();
                MOTCertificate.Text = (string) dr["MOTCertificate"];

                AddDataButton.Enabled = false;
                UpdateDataButton.Enabled = true;
                DeleteButton.Enabled = true;
            }

        }

        private void validationCheck(object sender, EventArgs e)
        {
            bool valid = true;

            // get data from form fields
            string VehicleIdentificationNumber = TxtVehicleID.Text;
            string rOwnerID = cmbOwner.SelectedValue.ToString();
            string rRegNum = TxtRegNum.Text;
            string rManufacturer = TxtManufacturer.Text;
            string rModel = txtModel.Text;
            string rEngineSize = txtEngineSize.Text;
            string rNoofDoors = textNoofDoors.Text;
            string rColour = textColour.Text;
            string rAirCon = TxtAircon.Text;
            string rAirBags = textAirbags.Text;
            DateTime rDateOfNextService = dateTimePickerNextService.Value;
            DateTime rDateOfLastService = dateTimePickerLastService.Value;
            string rMileage = textBoxMileage.Text;
            string rMOTCertificate = MOTCertificate.Text;


            //Check whether the buttons should be enabled depending on the boolean value 
            AddDataButton.Enabled = adding && valid;
            UpdateDataButton.Enabled = !adding && valid;
            DeleteButton.Enabled = !adding && valid;

        }

        private void TxtRegNum_KeyPress_Click(object sender, KeyPressEventArgs e)
        //Check only letters and numbers have been entered into the RegNum textbox
        {
            if (e.KeyChar < 'A' || e.KeyChar > 'Z')
            {
                if (e.KeyChar < '0' || e.KeyChar > '9')
                {
                    if (e.KeyChar != (char)8)
                    {
                    MessageBox.Show("You pressed:" + e.KeyChar + " A reg number must only contain letters and numbers.\n");
                    e.KeyChar = (char)0;
                    }
                }
            }
        }

        private void TxtManufacturer_KeyPress_Click(object sender, KeyPressEventArgs e)
        //Check only letters have been entered into the Manufacturer textbox
        {
            if (e.KeyChar < 'A' || e.KeyChar > 'Z')
            {
                if (e.KeyChar < 'a' || e.KeyChar > 'z')
                {
                    if (e.KeyChar != (char)8)
                    {
                        MessageBox.Show("You pressed:" + e.KeyChar + " A car manufacturer must only contain letters.\n");
                        e.KeyChar = (char)0;
                    }
                }
            }
        }

        private void txtModel_KeyPress_Click(object sender, KeyPressEventArgs e)
        //Check only letters have been entered into the Model textbox
        {
            if (e.KeyChar < 'A' || e.KeyChar > 'Z')
            {
                if (e.KeyChar < 'a' || e.KeyChar > 'z')
                {
                    if (e.KeyChar != (char)8)
                    {
                        MessageBox.Show("You pressed:" + e.KeyChar + " A car model must only contain letters.\n");
                        e.KeyChar = (char)0;
                    }
                }
            }
        }

        private void txtEngineSize_KeyPress_Click(object sender, KeyPressEventArgs e)
        //Check only letters have been entered into the Engine Size textbox
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != (char)8)
                {
                    MessageBox.Show("You pressed:" + e.KeyChar + " Engine size number must only contain numbers.\n");
                    e.KeyChar = (char)0;
                }
            }
        }

        private void textNoofDoors_KeyPress_Click(object sender, KeyPressEventArgs e)
        //Check only numbers have been entered into the Number of Doors textbox
        {
            if (e.KeyChar < '1' || e.KeyChar > '5')
            {
                if (e.KeyChar != (char)8)
                {
                    MessageBox.Show("You pressed:" + e.KeyChar + " Number of doors must only contain numbers.\n");
                    e.KeyChar = (char)0;
                }
            }
        }

        private void textColour_KeyPress_Click(object sender, KeyPressEventArgs e)
        //Check only letters have been entered into the Colour textbox 
        {
            if (e.KeyChar < 'A' || e.KeyChar > 'Z')
            {
                if (e.KeyChar < 'a' || e.KeyChar > 'z')
                {
                    if (e.KeyChar != (char)8)
                    {
                    MessageBox.Show("You pressed:" + e.KeyChar + "A car colour must be a valid car colour format and only contain letters.\n");
                    }
                }
            }
        }

        private void textAirbags_KeyPress_Click(object sender, KeyPressEventArgs e)
        //Check only letters have been entered into the Airbag textbox 
        {
            if (e.KeyChar < 'A' || e.KeyChar > 'Z')
            {
                if (e.KeyChar < 'a' || e.KeyChar > 'z')
                {
                    if (e.KeyChar != (char)8)
                    {
                        MessageBox.Show("You pressed:" + e.KeyChar + "Airbag must only contain letters.\n");
                    }
                }
            }
        }

        private void TxtAircon_KeyPress_Click(object sender, KeyPressEventArgs e)
        //Check only letters have been entered into the Aircon textbox address
        {
            if (e.KeyChar < 'A' || e.KeyChar > 'Z')
            {
                if (e.KeyChar < 'a' || e.KeyChar > 'z')
                {
                    if (e.KeyChar != (char)8)
                    {
                        MessageBox.Show("You pressed:" + e.KeyChar + "Aircon must only contain letters.\n");
                    }
                }
            }
        }

        private void textBoxMileage_KeyPress_Click(object sender, KeyPressEventArgs e)
        //Check only numbers have been entered into the Mileage textbox
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != (char)8)
                {
                    MessageBox.Show("You pressed:" + e.KeyChar + " Mileage must only contain numbers.\n");
                    e.KeyChar = (char)0;
                }
            }
        }

        private void MOTCertificate_KeyPress_Click(object sender, KeyPressEventArgs e)
        //Check only numbers have been entered into the MOT Certificate textbox
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != (char)8)
                {
                    MessageBox.Show("You pressed:" + e.KeyChar + " A MOT Certificate must only contain numbers.\n");
                    e.KeyChar = (char)0;
                }
            }
        }

        private void AddData_Click(object sender, EventArgs e)
        {
            bool valid = true;
            // get data from form fields
            string VehicleIdentificationNumber = TxtVehicleID.Text;
            string rOwnerID = cmbOwner.SelectedValue.ToString();
            string rRegNum = TxtRegNum.Text;
            string rManufacturer = TxtManufacturer.Text;
            string rModel = txtModel.Text;
            string rEngineSize = txtEngineSize.Text;
            string rNoofDoors = textNoofDoors.Text;
            string rColour = textColour.Text;
            string rAirCon = TxtAircon.Text;
            string rAirBags = textAirbags.Text;
            DateTime rDateOfNextService = dateTimePickerNextService.Value;
            DateTime rDateOfLastService = dateTimePickerLastService.Value;
            string rMileage = textBoxMileage.Text;
            string rMOTCertificate = MOTCertificate.Text;

            //Check VehicleID form is not empty
            if (VehicleIdentificationNumber.Length == 0)
            {
                MessageBox.Show("A Vehicle ID is required");
            }

            //Check OwnerID form is not empty
            if (cmbOwner.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a vehicle");
                valid = false;
                EditOwner.Enabled = false;
            }

            else
            {
                EditOwner.Enabled = true;
            }
            //Check RegNum form is not empty
            if (rRegNum.Length == 0)
            {
                MessageBox.Show("A registration number is required");
            }

            //Check Manufacturer form is not empty
            if (rManufacturer.Length == 0)
            {
                MessageBox.Show("A car manufacturer is required");
            }

            //Check Model form is not empty

            if (rModel.Length == 0)
            {
                MessageBox.Show("A car model is required");
            }



            //Check Engine Size form is not empty
            if (rEngineSize.Length == 0)
            {
                MessageBox.Show("A car engine size number is required");
            }

            //Check No of Doors form is not empty
            if (rNoofDoors.Length == 0)
            {
                MessageBox.Show("A number is required for number of doors");
            }

            //Check Colour form is not empty
            if (rColour.Length == 0)
            {
                MessageBox.Show("A colour of the car is required");
            }

            //Check Aircon form is not empty
            if (rAirCon.Length == 0)
            {
                MessageBox.Show("A aircon of the car is required");
            }

            //Check Airbags form is not empty
            if (rAirBags.Length == 0)
            {
                MessageBox.Show("A airbag of the car is required");
            }

            // add a new row to store the car
            DataRow dr = carDt.NewRow();

            dr["VehicleIdentificationNumber"] = VehicleIdentificationNumber;
            dr["OwnerID"] = rOwnerID;
            dr["RegistrationNumber"] = rRegNum;
            dr["Manufacturer"] = rManufacturer;
            dr["Model"] = rModel;
            dr["EngineSize"] = rEngineSize;
            dr["NoOfDoors"] = rNoofDoors;
            dr["Colour"] = rColour;
            dr["Aircon"] = rAirCon;
            dr["Airbags"] = rAirBags;
            dr["DateOfNextService"] = rDateOfNextService;
            dr["DateOfLastService"] = rDateOfLastService; 
            dr["Mileage"] = rMileage;
            dr["MOTCertificate"] = rMOTCertificate;

             // add Car row to Cars DataTable AND  update the database
             daCar.Update(carDt);
             this.Close();
            
        }

        private void DeleteData_Click(object sender, EventArgs e)
        {
            bool valid = true;
            // get data from form fields
            string VehicleIdentificationNumber = TxtVehicleID.Text;
            string rOwnerID = cmbOwner.SelectedValue.ToString();
            string rRegNum = TxtRegNum.Text;
            string rManufacturer = TxtManufacturer.Text;
            string rModel = txtModel.Text;
            string rEngineSize = txtEngineSize.Text;
            string rNoofDoors = textNoofDoors.Text;
            string rColour = textColour.Text;
            string rAirCon = TxtAircon.Text;
            string rAirBags = textAirbags.Text;
            DateTime rDateOfNextService = dateTimePickerNextService.Value;
            DateTime rDateOfLastService = dateTimePickerLastService.Value;
            string rMileage = textBoxMileage.Text;
            string rMOTCertificate = MOTCertificate.Text;
            

            //Check VehicleID form is not empty
            if (VehicleIdentificationNumber.Length == 0)
            {
                MessageBox.Show("A Vehicle ID is required");
            }

            //Check OwnerID form is not empty
            if (cmbOwner.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a vehicle");
                valid = false;
                EditOwner.Enabled = false;
            }

            else
            {
                EditOwner.Enabled = true;
            }
            //Check RegNum form is not empty
            if (rRegNum.Length == 0)
            {
                MessageBox.Show("A registration number is required");
            }

            //Check Manufacturer form is not empty
            if (rManufacturer.Length == 0)
            {
                MessageBox.Show("A car manufacturer is required");
            }

            //Check Model form is not empty

            if (rModel.Length == 0)
            {
                MessageBox.Show("A car model is required");
            }



            //Check Engine Size form is not empty
            if (rEngineSize.Length == 0)
            {
                MessageBox.Show("A car engine size number is required");
            }

            //Check No of Doors form is not empty
            if (rNoofDoors.Length == 0)
            {
                MessageBox.Show("A number is required for number of doors");
            }

            //Check Colour form is not empty
            if (rColour.Length == 0)
            {
                MessageBox.Show("A colour of the car is required");
            }

            //Check Aircon form is not empty
            if (rAirCon.Length == 0)
            {
                MessageBox.Show("A aircon of the car is required");
            }

            //Check Airbags form is not empty
            if (rAirBags.Length == 0)
            {
                MessageBox.Show("A airbag of the car is required");
            }
            //Select the current row by Vehicle Identification Number and delete it
            DataRow dr = carDt.Select("[VehicleIdentificationNumber] = '" + carId + "'")[0];
            carDt.Rows.Remove(dr);
            // remove Car row from Cars DataTable AND  update the database
            daCar.Update(carDt);
            this.Close();
        }

        private void UpdateData_Click(object sender, EventArgs e)
        {
            bool valid = true;
            // get data from form fields
            string VehicleIdentificationNumber = TxtVehicleID.Text;
            string rOwnerID = cmbOwner.SelectedValue.ToString();
            string rRegNum = TxtRegNum.Text;
            string rManufacturer = TxtManufacturer.Text;
            string rModel = txtModel.Text;
            string rEngineSize = txtEngineSize.Text;
            string rNoofDoors = textNoofDoors.Text;
            string rColour = textColour.Text;
            string rAirCon = TxtAircon.Text;
            string rAirBags = textAirbags.Text;
            DateTime rDateOfNextService = dateTimePickerNextService.Value;
            DateTime rDateOfLastService = dateTimePickerLastService.Value;
            string rMileage = textBoxMileage.Text;
            string rMOTCertificate = MOTCertificate.Text;

            //Check VehicleID form is not empty
            if (VehicleIdentificationNumber.Length == 0)
            {
                MessageBox.Show("A Vehicle ID is required");
            }

            //Check OwnerID form is not empty
            if (cmbOwner.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a vehicle");
                valid = false;
                EditOwner.Enabled = false;
            }

            else
            {
                EditOwner.Enabled = true;
            }
            //Check RegNum form is not empty
            if (rRegNum.Length == 0)
            {
                MessageBox.Show("A registration number is required");
            }

            //Check Manufacturer form is not empty
            if (rManufacturer.Length == 0)
            {
                MessageBox.Show("A car manufacturer is required");
            }

            //Check Model form is not empty

            if (rModel.Length == 0)
            {
                MessageBox.Show("A car model is required");
            }



            //Check Engine Size form is not empty
            if (rEngineSize.Length == 0)
            {
                MessageBox.Show("A car engine size number is required");
            }

            //Check No of Doors form is not empty
            if (rNoofDoors.Length == 0)
            {
                MessageBox.Show("A number is required for number of doors");
            }

            //Check Colour form is not empty
            if (rColour.Length == 0)
            {
                MessageBox.Show("A colour of the car is required");
            }

            //Check Aircon form is not empty
            if (rAirCon.Length == 0)
            {
                MessageBox.Show("A aircon of the car is required");
            }

            //Check Airbags form is not empty
            if (rAirBags.Length == 0)
            {
                MessageBox.Show("A airbag of the car is required");
            }
           
            // add a new row to store the car
            DataRow dr = carDt.Select("[VehicleIdentificationNumber] = '" + VehicleIdentificationNumber + "'")[0];
            dr["VehicleIdentificationNumber"] = VehicleIdentificationNumber;
            dr["OwnerID"] = rOwnerID;
            dr["RegistrationNumber"] = rRegNum;
            dr["Manufacturer"] = rManufacturer;
            dr["Model"] = rModel;
            dr["EngineSize"] = rEngineSize;
            dr["NoOfDoors"] = rNoofDoors;
            dr["Colour"] = rColour;
            dr["Aircon"] = rAirCon;
            dr["Airbags"] = rAirBags;
            dr["DateOfNextService"] = rDateOfNextService;
            dr["DateOfLastService"] = rDateOfLastService;
            dr["Mileage"] = rMileage;
            dr["MOTCertificate"] = rMOTCertificate;

            //Edit and update the Car row to Cars DataTable AND update the database
            daCar.Update(carDt);
            this.Close();
        }

        private void ownerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carTableAdapter1.Update(this.garageServiceDatabaseDataSet11);
        }

        private void AddOwnerForm_Click(object sender, EventArgs e)
        {
            //Bring up the Add Owner windows form once it is clicked
            OwnerForm secondForm = new OwnerForm(parent, null, true);
            secondForm.ShowDialog(this);
        }

        private void EditOwnerForm_Click(object sender, EventArgs e)
        {
            //Bring up the Edit Owner form once it is enabled and clicked on
            OwnerForm thirdForm = new OwnerForm(parent, cmbOwner.SelectedValue.ToString(), false);
            thirdForm.ShowDialog(this);
        }
      
    }
}
