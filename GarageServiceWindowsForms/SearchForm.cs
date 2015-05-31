//AndrewG8460
//Initial form that is loaded once the windows application has been published and allows the searching of existing data
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
    public partial class SearchForm : Form
    {
        //Intialise the dataset
        DataSet ds;

        public SearchForm()
        {
            InitializeComponent();
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // Load the data from the car table adapter into the 'garageServiceDatabaseDataSet11.Car' table. 
            this.carTableAdapter.Fill(this.garageServiceDatabaseDataSet11.Car);

            // Load the data from the service table adapter into the 'garageServiceDatabaseDataSet11.Service' table. 
            this.serviceTableAdapter.Fill(this.garageServiceDatabaseDataSet11.Service);

            // Load the data from the owner table adapter into the 'garageServiceDatabaseDataSet1.Owner' table. 
            this.ownerTableAdapter.Fill(this.garageServiceDatabaseDataSet11.Owner);
                    
           
        }

        private void Search_Click(object sender, EventArgs e)
        {
            String filter = "";

            //Check that the car checkbox has been clicked on and a value selected
            if (Carcheckbox.Checked && Car.SelectedIndex != -1) {
                filter = filter + string.Format(" VehicleIdentificationNumber = '{0}'", Car.SelectedValue.ToString());
            }
            //Check that the owner checkbox has been clicked on and a value selected
            if (Ownercheckbox.Checked && cmbOwner.SelectedIndex != -1)
            {
                if (filter.Length > 0)
                {
                    filter = filter + " AND ";
                }
                filter = filter + string.Format(" VehicleIdentificationNumber = '{0}'", Car.SelectedValue.ToString());
            }
            //Check that the checkbox 3 has been clicked on and a value selected
            if (checkBox3.Checked)
            {
                if (filter.Length > 0)
                {
                    filter = filter + " AND ";
                }
                filter = filter + " DateOfService = '" +  ServiceDate.Value.ToString("yyyy-MM-dd") + "'";
            }
            if (filter.Length > 0)
            {
                serviceBindingSource.Filter = filter;
            }

            //Refresh the data grid view
            dataGridView1.Refresh();
        }

        private void ServiceForm_Click(object sender, EventArgs e)
        {
            //place the data from the current row in the datagrid view in the edit service form
            string serviceId = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            //refresh the data grid view and open up the edit service form
            ServiceForm fourthForm = new ServiceForm(this, serviceId, false);
            fourthForm.ShowDialog(this);
            dataGridView1.Refresh();
        }

        private void checkbox_click(object sender, EventArgs e)
        {
            //enable the search button if any of the checkboxes have been clicked on
            if (Carcheckbox.Checked == true || Ownercheckbox.Checked || checkBox3.Checked )
            {
                SearchButton.Enabled = true;
            } 
            else
            {
                 SearchButton.Enabled = false;
            }
        }

        private void addService_Click(object sender, EventArgs e)
        {
            //refresh the data grid view and open up the service form
            ServiceForm fourthForm = new ServiceForm(this, null, true);
            fourthForm.ShowDialog(this);
            dataGridView1.Refresh();
        }
    }
}
