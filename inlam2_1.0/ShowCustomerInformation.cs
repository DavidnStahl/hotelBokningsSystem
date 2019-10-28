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
    public partial class ShowCustomerInformation : Form
    {
        private readonly MainMenuForm mainForm;

        public ShowCustomerInformation(MainMenuForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            FillIformation();
        }
        public void FillIformation()
        {
            var selectedcustomerID = mainForm.GetSelectedCustomerID();
            var cdbm = new DBmanager();
            var selectedCustomer = cdbm.GetCustomerInformation(selectedcustomerID);

            tBoxFirstName.Text = selectedCustomer.FirstName.ToString();
            tBoxLastName.Text = selectedCustomer.LastName.ToString();
            tBoxAddress.Text = selectedCustomer.Address.ToString();
            tBoxPostalCode.Text = selectedCustomer.PostalCode.ToString();
            tBoxCity.Text = selectedCustomer.City.ToString();
            tBoxCountry.Text = selectedCustomer.Country.ToString();
            tBoxPhone.Text = selectedCustomer.Phone.ToString();
        }

        private void btnBookARoom_Click(object sender, EventArgs e)
        {
            using (var subform = new BookARoomForm(mainForm))
            {
                subform.ShowDialog();
            }
        }
    }
}
