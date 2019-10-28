using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inlam2_1._0
{
    public partial class UpdateCustomers : Form
    {
        private readonly MainMenuForm mainForm;

        public UpdateCustomers(MainMenuForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            FillInformation();
            
        }
        public void FillInformation()
        {
            
            var selectedcustomerID = mainForm.GetSelectedCustomerID();
            var dbm = new DBmanager();
            var selectedCustomer = dbm.GetCustomerInformation(selectedcustomerID);

            tBoxFirstName.Text = selectedCustomer.FirstName.ToString();
            tBoxLastName.Text = selectedCustomer.LastName.ToString();
            tBoxAddress.Text = selectedCustomer.Address.ToString();
            tBoxPostalCode.Text = selectedCustomer.PostalCode.ToString();
            tBoxCity.Text = selectedCustomer.City.ToString();
            tBoxCountry.Text = selectedCustomer.Country.ToString();
            tBoxPhone.Text = selectedCustomer.Phone.ToString();           
        }

        private void btnUpdateCustomerInformation_Click(object sender, EventArgs e)
        {
            var customerID = mainForm.GetSelectedCustomerID();
            var dbm = new DBmanager();
            if(tBoxFirstName.Text.Length >= 1 && tBoxLastName.Text.Length >= 1 && tBoxAddress.Text.Length >= 1 &&
                tBoxPostalCode.Text.Length >= 1 && tBoxCity.Text.Length >= 1 && tBoxCountry.Text.Length >= 1 && tBoxPhone.Text.Length >= 1)
            {
                dbm.UpdateCustomerInformation(customerID, tBoxFirstName.Text, tBoxLastName.Text, tBoxAddress.Text,
                tBoxPostalCode.Text, tBoxCity.Text, tBoxCountry.Text, tBoxPhone.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("You need to put information into every textbox");
            }
            
        }
    }
}
