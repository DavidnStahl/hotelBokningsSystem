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
    public partial class HandleCustomerForm : Form
    {
        private readonly MainMenuForm mainForm;

        public HandleCustomerForm(MainMenuForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnChangeReservation_Click(object sender, EventArgs e)
        {
            var customerID = mainForm.GetSelectedCustomerID();
            var dbm = new DBmanager();
            dbm.DeleteReservation(customerID);
            using (var subform = new BookARoomForm(mainForm))
            {
                subform.ShowDialog();
            }
            this.Close();
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            var customerID = mainForm.GetSelectedCustomerID();
            var dbm = new DBmanager();
            dbm.DeleteReservation(customerID);
            MessageBox.Show("Reservation is now annulled");
            this.Close();
        }
    }
}
