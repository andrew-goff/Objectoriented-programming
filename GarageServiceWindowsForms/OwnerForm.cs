//AndrewG8460
//Owner form that allows editing or adding details of a owner service
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
    public partial class OwnerForm : Form
    {
        //Intialise the boolean value, the data table and the dataset
        SearchForm parent;

        DataTable dt;
        SqlDataAdapter daOwner;
        bool adding = false;
        string ownerId;

        public OwnerForm(SearchForm parent, string ownerId, bool addMode)
        {
            this.parent = parent;
            this.adding = addMode;
            this.ownerId = ownerId;

            InitializeComponent();
            dt = new DataTable();
        }

        private void ServiceForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OwnerForm_Load(object sender, EventArgs e)
        {
            // load up the owner form and connect to the local database
            try
            {
                // set up the database connection and retrieve the Owner
                string connectString = Properties.Settings.Default.GarageServiceDatabaseConnectionString;

                SqlConnection con = new SqlConnection(connectString);
                con.Open();
                
                string sqlString = "Select * FROM Owner;";
                daOwner = new SqlDataAdapter(sqlString, con);
                SqlCommandBuilder cbOwner = new SqlCommandBuilder(daOwner); // enables update and delete

                //caches the owner in the dataset
                daOwner.Fill(dt);
                if (ownerId != null)
                {
                        sqlString = sqlString + string.Format(" WHERE OwnerID = '{0}'", ownerId);
                }

                //cmbOwner_Load();
                con.Close();
                
             }
            //Brings up an error message if the database cannot be read
            catch (Exception ex)
            {
                MessageBox.Show("Error reading the database:" + ex.ToString());
            }
            //Disables the update data and delete data buttons if the add owner button has been clicked on
            AddDataButton.Enabled = false;

            if (adding)
            {
                //Enable Add button, disable the add Update, delete buttons
                txtOwnerID.Text = Guid.NewGuid().ToString();
                AddDataButton.Enabled = true;
                UpdateData.Enabled = false;
                DeleteDatabutton.Enabled = false;
            }
            //Enables the update data and delete data buttons if the edit car button has been clicked on
            else
            {
                // Add new row to the Dataset
                // disable Add button, enable the add Update, delete buttons
                DataRow dr = dt.Select("OwnerID = '" + ownerId + "'")[0];
                txtOwnerID.Text = ownerId;
                TxtOwnerFirstName.Text = dr["OwnerFirstName"].ToString();
                TxtOwnerLastName.Text = dr["OwnerLastName"].ToString();
                textEmail.Text = dr["OwnerEmail"].ToString();
                txtTelNo.Text = dr["OwnerTelNo"].ToString();

                UpdateData.Enabled = true;
                DeleteDatabutton.Enabled = true;
            }
        }

        private void validationCheck(object sender, EventArgs e)
        {
            bool valid = true;

            // get data from form fields
            ownerId = txtOwnerID.Text;
            string rName = TxtOwnerFirstName.Text;
            string rlastName = TxtOwnerLastName.Text;
            string rEmail = textEmail.Text;
            string rTelNo = txtTelNo.Text;

            //Check whether the buttons should be enabled depending on the boolean value 
            AddDataButton.Enabled = adding && valid;
            UpdateData.Enabled = !adding && valid;
            DeleteDatabutton.Enabled = !adding && valid;
        }

        private void TxtOwnerFirstName_KeyPress_Click(object sender, KeyPressEventArgs e)
        //Check only letters have been entered into the ownerFirstName textbox
        {
            if (e.KeyChar < 'A' || e.KeyChar > 'z')
            {
                if (e.KeyChar != (char)8)
                {
                    MessageBox.Show("You pressed:" + e.KeyChar + " A owner last name must be valid and only contain letters.\n");
                    e.KeyChar = (char)0;
                }
            }
        }

        private void TxtOwnerLastName_KeyPress_Click(object sender, KeyPressEventArgs e)
        //Check only letters have been entered into the ownerLastName textbox
        {
            if (e.KeyChar < 'A' || e.KeyChar > 'z')
            {
                if (e.KeyChar != (char)8)
                {
                    MessageBox.Show("You pressed:" + e.KeyChar + " A owner last name must be valid and only contain letters.\n");
                    e.KeyChar = (char)0;
                }
            }
        }

        private void txtTelNo_KeyPress_Click(object sender, KeyPressEventArgs e)
        //Check only numbers have been entered into the telNo textbox
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                    if (e.KeyChar !=(char)8)
                    { 
                    MessageBox.Show("You pressed:" + e.KeyChar + " A telephone number must only contain numbers.\n");
                    e.KeyChar = (char)0;
                    }
            }
        }

        private void AddData_Click(object sender, EventArgs e)
        {
            bool valid = true;

            // get data from form fields
            ownerId = txtOwnerID.Text;
            string rName = TxtOwnerFirstName.Text;
            string rlastName = TxtOwnerLastName.Text;
            string rEmail = textEmail.Text;
            string rTelNo = txtTelNo.Text;           
            
            //Check OwnerID form is not empty
            if (ownerId.Length == 0)
            {
                MessageBox.Show("A Owner ID is required");
                valid = false;
            }

            //Check FirstName form is not empty
            if (rName.Length == 0)
            {
                MessageBox.Show("A first name is required");
                valid = false;
            }

            //Check LastName form is not empty
            if (rlastName.Length == 0)
            {
                MessageBox.Show("A last name is required");
                valid = false;
            }

            //Check Email form is not empty

            if (rEmail.Length == 0)
            {
                MessageBox.Show("A email address is required");
                valid = false;
            }

            //Check the email has . and @ symbols in the address
            if (rEmail.IndexOf("@") > -1)
            {
                if (rEmail.IndexOf(".", rEmail.IndexOf("@")) > rEmail.IndexOf("@"))
                {
                    MessageBox.Show("A e-mail address must be a valid e-mail address format.\n");
                    valid = false;
                }
            }

            //Check TelNo form is not empty
            if (rTelNo.Length == 0)
            {
                MessageBox.Show("A telephone number is required");
                valid = false;
            }

            // add a new row to store data from form fields
            DataRow dr = dt.NewRow();
            dr["OwnerID"] = ownerId;
            dr["OwnerFirstName"] = rName;
            dr["OwnerLastName"] = rlastName;
            dr["OwnerEmail"] = rEmail;
            dr["OwnerTelNo"] = rTelNo;



            // add Owner to Owners DataTable AND  update the database
            dt.Rows.Add(dr); // Manually add the data row to table
            daOwner.Update(dt);//Update the Owner datatable 
            this.Close();
        }

        private void DeleteData_Click(object sender, EventArgs e)
        {
            bool valid = true;

            // get data from form fields
            ownerId = txtOwnerID.Text;
            string rName = TxtOwnerFirstName.Text;
            string rlastName = TxtOwnerLastName.Text;
            string rEmail = textEmail.Text;
            string rTelNo = txtTelNo.Text;  

            DataRow dr = dt.Select("OwnerID = '" + ownerId + "'")[0];

            //Check OwnerID form is not empty
            if (ownerId.Length == 0)
            {
                MessageBox.Show("A Owner ID is required");
                valid = false;
            }

            //Check FirstName form is not empty
            if (rName.Length == 0)
            {
                MessageBox.Show("A first name is required");
                valid = false;
            }

            //Check LastName form is not empty
            if (rlastName.Length == 0)
            {
                MessageBox.Show("A last name is required");
                valid = false;
            }

            //Check Email form is not empty

            if (rEmail.Length == 0)
            {
                MessageBox.Show("A email address is required");
                valid = false;
            }

            //Check the email has . and @ symbols in the address
            if (rEmail.IndexOf("@") > -1)
            {
                if (rEmail.IndexOf(".", rEmail.IndexOf("@")) > rEmail.IndexOf("@"))
                {
                    MessageBox.Show("A e-mail address must be a valid e-mail address format.\n");
                    valid = false;
                }
            }

            //Check TelNo form is not empty
            if (rTelNo.Length == 0)
            {
                MessageBox.Show("A telephone number is required");
                valid = false;
            }

            dt.Rows.Remove(dr); // Manually remove the row from the table
            daOwner.Update(dt); //Update and remove the row from the Owner datatable AND the database
            this.Close();
        } 
        
        private void UpdateData_Click(object sender, EventArgs e)
        {
            bool valid = true;

            // get data from form fields
            string rName = TxtOwnerFirstName.Text;
            string rlastName = TxtOwnerLastName.Text;
            string rEmail = textEmail.Text;
            string rTelNo = txtTelNo.Text;

            //Check OwnerID form is not empty
            if (ownerId.Length == 0)
            {
                MessageBox.Show("A Owner ID is required");
                valid = false;
            }

            //Check FirstName form is not empty
            if (rName.Length == 0)
            {
                MessageBox.Show("A first name is required");
                valid = false;
            }

            //Check LastName form is not empty
            if (rlastName.Length == 0)
            {
                MessageBox.Show("A last name is required");
                valid = false;
            }

            //Check Email form is not empty

            if (rEmail.Length == 0)
            {
                MessageBox.Show("A email address is required");
                valid = false;
            }

            //Check the email has . and @ symbols in the address
            if (rEmail.IndexOf("@") > -1)
            {
                if (rEmail.IndexOf(".", rEmail.IndexOf("@")) > rEmail.IndexOf("@"))
                {
                    MessageBox.Show("A e-mail address must be a valid e-mail address format.\n");
                    valid = false;
                }
            }

            //Check TelNo form is not empty
            if (rTelNo.Length == 0)
            {
                MessageBox.Show("A telephone number is required");
                valid = false;
            }

            // update data from the owner table using form fields
            DataRow dr = dt.Select("OwnerID = '" + ownerId + "'")[0];
            dr["OwnerFirstName"] = rName;
            dr["OwnerLastName"] = rlastName;
            dr["OwnerEmail"] = rEmail;
            dr["OwnerTelNo"] = rTelNo;

            //Edit Owner row from the Owners DataTable AND  update the database
            daOwner.Update(dt);
            this.Close();
        }

        private void ownerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ownerTableAdapter1.Update(this.garageServiceDatabaseDataSet11);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
