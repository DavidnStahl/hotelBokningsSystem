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
        private readonly List<string> reservationList;

        public HandleCustomerForm(MainMenuForm mainForm, List<string> reservationList)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.reservationList = reservationList;
            FillReservationInfo();
        }
        public void FillReservationInfo()
        {            
                tBoxRoomDescription.Text = reservationList[0];
                tBoxRoomNumber.Text = reservationList[1];
                tBoxDates.Text = $"{reservationList[2]} - {reservationList[3]}";
                tBoxAmountToPay.Text = reservationList[4];
                tBoxHaveCustomerPayed.Text = reservationList[5];
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
