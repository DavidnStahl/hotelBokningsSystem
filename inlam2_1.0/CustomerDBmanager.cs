using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inlam2_1._0
{
    class CustomerDBmanager
    {
        public CustomerDBmanager()
        {

        }
        public Customer GetCustomerInformation(int customerID)
        {
            Customer selectedCustomer = new Customer();
            using (HotelDBContext context = new HotelDBContext())
            {
                selectedCustomer = context.Customers.FirstOrDefault(c => c.CustomerID == customerID);
            }
            return selectedCustomer;
        }
        public void DeleteCustomer(int customerID)
        {
            var reservationsToDelete = new List<Reservation>();
            var paymentsInfoToDelete = new Payment();
            var reservationRoomsToDelete = new ReservationRoom();
            using (HotelDBContext context = new HotelDBContext())
            {
                var customer = context.Customers.FirstOrDefault(c => c.CustomerID == customerID);               
                try
                {
                    reservationsToDelete = context.Reservations.Where(r => r.CustomerID == customer.CustomerID).ToList();

                    foreach (var reservation in reservationsToDelete)
                    {
                        
                        context.Entry(reservation).State = System.Data.Entity.EntityState.Deleted;
                        reservationRoomsToDelete = context.ReservationRooms.SingleOrDefault(r => r.ReservationRoomsID == reservation.ReservationRoomsID);
                        context.Entry(reservationRoomsToDelete).State = System.Data.Entity.EntityState.Deleted;
                        paymentsInfoToDelete = context.Payments.FirstOrDefault(p => p.PaymentID == reservation.PaymentID);
                        context.Entry(paymentsInfoToDelete).State = System.Data.Entity.EntityState.Deleted;
                    }
                    context.Entry(customer).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }
                MessageBox.Show("Customer Have been Deleted");
            }
        }
    }
}
