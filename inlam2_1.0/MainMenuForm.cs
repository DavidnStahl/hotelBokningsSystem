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
            RemoveAllBookingsWichIsntPayedIn10Days();
        }
        public int GetSelectedCustomerID()
        {
            var selectedItem = listBoxSearchedCustomers.SelectedItem.ToString();
            var strArr = selectedItem.Split(' ');
            int selectedCustomerID = Convert.ToInt32(strArr[0]);


            using (HotelDBContext context = new HotelDBContext())
            {
                Customer customer = context.Customers.FirstOrDefault(c => c.CustomerID == selectedCustomerID);
                return customer.CustomerID;
            }
            
        }
        public void UpdatePaymentCustomer()
        {
            var customerID = GetSelectedCustomerID();
            using (HotelDBContext context = new HotelDBContext())
            {
                var reservation = context.Reservations.Where(r => r.CustomerID == customerID).ToList();
                
                foreach (var reserv in reservation)
                {
                    var payment = context.Payments.FirstOrDefault(r => r.PaymentID == reserv.PaymentID);
                    payment.Paid = "Yes";
                }
                
                context.SaveChanges();
            }
            MessageBox.Show("Customers reservation is Payed");
        }
        public void RemoveAllBookingsWichIsntPayedIn10Days()
        {
            var reservationToDelete = new Reservation();
            var paymentInfoToDelete = new Payment();
            var reservationRoomsToDelete = new ReservationRoom();
            var customerToDelete = new Customer();
            var anwser = "Yes";
            using (HotelDBContext context = new HotelDBContext())              
            {
                
                var payment = context.Payments.Where(r => r.LastDayToPay < DateTime.Now).ToList();
                foreach (var payed in payment)
                {
                    if(payed.Paid == "No")
                    {
                        try
                        {                          
                            reservationToDelete = context.Reservations.SingleOrDefault(r => r.PaymentID == payed.PaymentID);
                            reservationRoomsToDelete = context.ReservationRooms.SingleOrDefault(r => r.ReservationRoomsID == reservationToDelete.ReservationRoomsID);
                            customerToDelete = context.Customers.SingleOrDefault(r => r.CustomerID == reservationToDelete.CustomerID);

                            paymentInfoToDelete = payed;
                            anwser = "No";

                            
                            
                            context.Entry(reservationToDelete).State = System.Data.Entity.EntityState.Deleted;
                            context.Entry(reservationRoomsToDelete).State = System.Data.Entity.EntityState.Deleted;
                            context.Entry(paymentInfoToDelete).State = System.Data.Entity.EntityState.Deleted;
                            context.Entry(reservationToDelete).State = System.Data.Entity.EntityState.Deleted;
                            context.SaveChanges();                          
                        }                       
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                        }

                    }
                }
                
                if(anwser == "No")
                {
                    MessageBox.Show("Customers who haven't payed for 10 days since there booking have been removed");
                }
                
            }
            
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
            List<Customer> searchedCustomer = new List<Customer>();
            using (HotelDBContext context = new HotelDBContext())
            {
                searchedCustomer = context.Customers.Where(c => c.LastName.StartsWith(tBoxSearchCustomers.Text)).ToList();           
            }
            foreach (var customer in searchedCustomer)
            {
                listBoxSearchedCustomers.Items.Add($"{customer.CustomerID} {customer.FirstName} {customer.LastName}");
            }

        }      

        private void btnShowCustomerInformation_Click(object sender, EventArgs e)
        {
            using (var subform = new ShowCustomerInformation(this))
            {
                subform.ShowDialog();
            }
        }

        private void btnBookARoom_Click(object sender, EventArgs e)
        {
            using (var subform = new BookARoomForm(this))
            {
                subform.ShowDialog();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            UpdatePaymentCustomer();
        }
    }
}
