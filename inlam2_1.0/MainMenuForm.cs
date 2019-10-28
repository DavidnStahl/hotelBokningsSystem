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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            var dbm = new DBmanager();
            dbm.RemoveAllBookingsWichIsntPayedIn10Days();
        }
        public int GetSelectedCustomerID()
        {
            var selectedItem = listBoxSearchedCustomers.SelectedItem.ToString();
            var strArr = selectedItem.Split(' ');
            var selectedCustomerID = Convert.ToInt32(strArr[0]);
            return selectedCustomerID;
        }       
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            using (var subform = new AddNewCustomer(this))
            {
                subform.ShowDialog();
            }
        }
        private void btnSearchCustomers_Click(object sender, EventArgs e)
        {
            listBoxSearchedCustomers.Items.Clear();
            var dbm = new DBmanager();
            var searchedCustomer = dbm.SearchForCustomer(tBoxSearchCustomers.Text); 
            
            foreach (var customer in searchedCustomer)
            {
                listBoxSearchedCustomers.Items.Add($"{customer.CustomerID} {customer.FirstName} {customer.LastName}");
            }

        }      

        private void btnShowCustomerInformation_Click(object sender, EventArgs e)
        {
            if(listBoxSearchedCustomers.SelectedIndex > -1)
            {
                using (var subform = new ShowCustomerInformation(this))
                {
                    subform.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("You need to choose customer first");
            }
            
        }

        private void btnBookARoom_Click(object sender, EventArgs e)
        {
            if (listBoxSearchedCustomers.SelectedIndex > -1)
            {
                using (var subform = new BookARoomForm(this))
                {
                    subform.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("You need to choose customer first");
            }

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (listBoxSearchedCustomers.SelectedIndex > -1)
            {
                var customerID = GetSelectedCustomerID();
                var dbm = new DBmanager();
                dbm.UpdatePaymentCustomer(customerID);
            }
            else
            {
                MessageBox.Show("You need to choose customer first");
            }
            
        }
        public List<string> FillReservationInfo()
        {
            
            var selectedCustomerID = GetSelectedCustomerID();
            var dbm = new DBmanager();
            var reservationList = dbm.GetCustomerReservationInformationToFill(selectedCustomerID);
            return reservationList;
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (listBoxSearchedCustomers.SelectedIndex > -1)
            {
                var customerID = GetSelectedCustomerID();
                var cdbm = new DBmanager();
                cdbm.DeleteCustomer(customerID);
            }
            else
            {
                MessageBox.Show("You need to choose customer first");
            }
            
        }
        private void btnHandleReservations_Click_1(object sender, EventArgs e)
        {
            if (listBoxSearchedCustomers.SelectedIndex > -1)
            {
                var reservationList = FillReservationInfo();
                if (reservationList == null)
                {
                    MessageBox.Show("Kunden har ingen bokning");

                }
                else if (reservationList != null)
                {
                    using (var subform = new HandleCustomerForm(this, reservationList))
                    {
                        subform.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("You need to choose customer first");
            }
            
            
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (listBoxSearchedCustomers.SelectedIndex > -1)
            {
                using (var subform = new UpdateCustomers(this))
                {
                    subform.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("You need to choose customer first");
            }
            
        }
    }
}
