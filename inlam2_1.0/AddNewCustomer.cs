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
            if (tBoxFirstName.Text.Length >= 1 && tBoxLastName.Text.Length >= 1 && tBoxAddress.Text.Length >= 1 &&
                tBoxPostalCode.Text.Length >= 1 && tBoxCity.Text.Length >= 1 && tBoxCountry.Text.Length >= 1 && tBoxPhone.Text.Length >= 1)
            {
                var dbm = new DBmanager();
                dbm.AddNewCustomer(tBoxFirstName.Text, tBoxLastName.Text, tBoxAddress.Text, tBoxPostalCode.Text, tBoxCity.Text, tBoxCountry.Text, tBoxPhone.Text);

                this.Close();
            }
            else
            {
                MessageBox.Show("You need to put information into every textbox");
            }
            
        }
    }
}
