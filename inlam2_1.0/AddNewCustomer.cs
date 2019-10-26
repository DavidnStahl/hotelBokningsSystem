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
    public partial class AddNewCustomer : Form
    {
        private readonly MainMenuForm mainForm;

        public AddNewCustomer(MainMenuForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            using(HotelDBContext context = new HotelDBContext())
            {
                Customer customer = new Customer
                {
                    FirstName = tBoxFirstName.Text,
                    LastName = tBoxLastName.Text,
                    Address = tBoxAddress.Text,
                    PostalCode = tBoxPostalCode.Text,
                    City = tBoxCity.Text,
                    Country = tBoxCountry.Text,
                    Phone = tBoxPhone.Text

                };
                context.Customers.Add(customer);
                context.SaveChanges();
                this.Close();
            }
        }
    }
}
