using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inlam2_1._0
{
    class DBmanager
    {
        public DBmanager()
        {

        }
        public void AddNewCustomer(string firstName, string lastName, string address, string postalCode, string city, string country, string phone)
        {
            using (HotelDBContext context = new HotelDBContext())
            {
                Customer customer = new Customer
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Address = address,
                    PostalCode = postalCode,
                    City = city,
                    Country = country,
                    Phone = phone

                };
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }
        public List<string> GetCustomerReservationInformationToFill(int selectedCustomerID)
        {
            var reservationInfoList = new List<string>();
            using (HotelDBContext context = new HotelDBContext())
            {
                var customer = context.Customers.SingleOrDefault(r => r.CustomerID == selectedCustomerID);
                var reservation = context.Reservations.SingleOrDefault(r => r.CustomerID == customer.CustomerID);
                if(reservation == null)
                {
                    return null;
                }
                var reservationRoom = context.ReservationRooms.SingleOrDefault(r => r.ReservationRoomsID == reservation.ReservationRoomsID);
                
                var room = context.Rooms.SingleOrDefault(r => r.RoomID == reservationRoom.RoomID);
                var roomType = context.RoomTypes.SingleOrDefault(r => r.RoomTypeID == room.RoomTypeID);
                var payment = context.Payments.SingleOrDefault(r => r.PaymentID == reservation.PaymentID);

                reservationInfoList.Add(roomType.RoomDescription);
                reservationInfoList.Add(room.RoomID.ToString());
                reservationInfoList.Add(reservation.StartDate.ToString());
                reservationInfoList.Add(reservation.EndDate.ToString()); ;
                reservationInfoList.Add(payment.PaymentAmount.ToString());
                reservationInfoList.Add(payment.Paid);
            }
            return reservationInfoList;
        }
        public void UpdateCustomerInformation(int customerID, string firstName,string LastName, string address,string postalCode, string city,
            string country,string phone)
        {
            using (HotelDBContext context = new HotelDBContext())
            {
                var customer = context.Customers.SingleOrDefault(r => r.CustomerID == customerID);

                customer.FirstName = firstName;
                customer.LastName = LastName;
                customer.Address = address;
                customer.PostalCode = postalCode;
                customer.City = city;
                customer.Country = country;
                customer.Phone = phone;

                context.SaveChanges();
            }
            MessageBox.Show("Customer information is saved");
        }
        public void UpdatePaymentCustomer(int customerID)
        {
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
        public List<Customer> SearchForCustomer(string searchedText)
        {
            List<Customer> searchedCustomer = new List<Customer>();
            using (HotelDBContext context = new HotelDBContext())
            {
                searchedCustomer = context.Customers.Where(c => c.LastName.StartsWith(searchedText)).ToList();
            }
            return searchedCustomer;
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
                    if (payed.Paid == "No")
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
                if (anwser == "No")
                {
                    MessageBox.Show("Customers who haven't payed for 10 days since there booking have been removed");
                }

            }

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
        public void DeleteReservation(int customerID)
        {
            
            var reservationToDelete = new Reservation();
            var paymentInfoToDelete = new Payment();
            var reservationRoomsToDelete = new ReservationRoom();
            var customerToDelete = new Customer();
            using (HotelDBContext context = new HotelDBContext())
            {
       
                try
                {
                    reservationToDelete = context.Reservations.SingleOrDefault(r => r.CustomerID == customerID);
                    reservationRoomsToDelete = context.ReservationRooms.SingleOrDefault(r => r.ReservationRoomsID == reservationToDelete.ReservationRoomsID);
                    customerToDelete = context.Customers.SingleOrDefault(r => r.CustomerID == reservationToDelete.CustomerID);

                    paymentInfoToDelete = context.Payments.SingleOrDefault(p => p.PaymentID == reservationToDelete.PaymentID);

                    context.Entry(reservationToDelete).State = System.Data.Entity.EntityState.Deleted;
                    context.Entry(reservationRoomsToDelete).State = System.Data.Entity.EntityState.Deleted;
                    context.Entry(paymentInfoToDelete).State = System.Data.Entity.EntityState.Deleted;                   
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
