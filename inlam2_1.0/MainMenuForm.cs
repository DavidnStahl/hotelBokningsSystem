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
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            using (var subform = new AddNewCustomer(this))
            {
                subform.ShowDialog();
            }
        }
        public string selectedLastNameInListBox()
        {
            return listBoxSearchedCustomers.Text;
        }


        private void btnSearchCustomers_Click(object sender, EventArgs e)
        {
            listBoxSearchedCustomers.Items.Clear();
            List<Customer> searchedCustomer = new List<Customer>();
            using (HotelDBContext context = new HotelDBContext())
            {
                searchedCustomer = context.Customers.Where(c => c.LastName.StartsWith(tBoxSearchCustomers.Text)).ToList();           
            }
            foreach (var customer in searchedCustomer)
            {
                listBoxSearchedCustomers.Items.Add($"{customer.LastName}");
            }

        }

        private void btnShowCustomerInformation_Click(object sender, EventArgs e)
        {
            using (var subform = new ShowCustomerInformation(this))
            {
                subform.ShowDialog();
            }
        }
    }
}
