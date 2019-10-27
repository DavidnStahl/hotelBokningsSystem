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
    public partial class BookARoomForm : Form
    {
        private readonly MainMenuForm mainForm;

        public BookARoomForm(MainMenuForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            FillComboBox();
        }
        public void FillComboBox()
        {
            for(int i = 0; i < 6; i++)
            {
                cBoxNumberOfPeople.Items.Add(i+1);
            }
            
        }
        public void GetAvaibleRooms()
        {            
            var startDate = CheckInStartDate.Value.Date;
            var endDate = checkOutEndDate.Value.Date;
            var unavaibleRooms = new List<Room>();
            lstAvaibleRooms.Items.Clear();
            using (HotelDBContext context = new HotelDBContext())
            {
                var AllRoomTypes = context.Rooms.ToList();
                foreach (var reserv in context.Reservations)
                {
                    if ((startDate >= reserv.StartDate && startDate < reserv.EndDate) || (endDate > reserv.StartDate && endDate < reserv.EndDate))
                    {
                        var reservationRooms = context.ReservationRooms.FirstOrDefault(r => r.ReservationRoomsID == reserv.ReservationRoomsID);
                        var roomID = context.Rooms.FirstOrDefault(r => r.RoomID == reservationRooms.RoomID);                       
                        unavaibleRooms.Add(roomID);
                    }
                }
                var avaibleRooms = GetAvaibleRooms(AllRoomTypes, unavaibleRooms);
                foreach (var room in avaibleRooms)
                {
                    var roomTypes = context.RoomTypes.FirstOrDefault(r => r.RoomTypeID == room.RoomTypeID);
                    if(cBoxNumberOfPeople.Text == "1" && roomTypes.RoomSize == 1)
                    {
                        lstAvaibleRooms.Items.Add(roomTypes.RoomDescription);
                    }
                    else if(cBoxNumberOfPeople.Text == "2" && roomTypes.RoomSize == 2)
                    {
                        lstAvaibleRooms.Items.Add(roomTypes.RoomDescription);
                    }
                    else if(cBoxNumberOfPeople.Text == "3" && roomTypes.RoomSize == 3)
                    {
                        lstAvaibleRooms.Items.Add(roomTypes.RoomDescription);
                    }
                    else if(cBoxNumberOfPeople.Text == "4" && roomTypes.RoomSize == 4)
                    {
                        lstAvaibleRooms.Items.Add(roomTypes.RoomDescription);
                    }
                    else if (cBoxNumberOfPeople.Text == "5" && roomTypes.RoomSize == 5)
                    {
                        lstAvaibleRooms.Items.Add(roomTypes.RoomDescription);
                    }
                    else if (cBoxNumberOfPeople.Text == "6" && roomTypes.RoomSize == 6)
                    {
                        lstAvaibleRooms.Items.Add(roomTypes.RoomDescription);
                    }
                    else if(cBoxNumberOfPeople.SelectedIndex <= -1)
                    {
                        lstAvaibleRooms.Items.Add(roomTypes.RoomDescription);
                    }                    
                }                
            }     
        }
        public List<Room> GetAvaibleRooms(List<Room> AllRoomTypes, List<Room> roomID)
        {
            var avaibleRooms = new List<Room>();
            foreach (var room in AllRoomTypes)
            {
                avaibleRooms.Add(room);

                foreach (var unavaibleroom in roomID)
                {
                    if (room.RoomID == unavaibleroom.RoomID)
                    {
                        avaibleRooms.Remove(room);
                        continue;
                    }
                }
            }
            return avaibleRooms;
        }

        private void btnSearchAvaibleRooms_Click(object sender, EventArgs e)
        {
            GetAvaibleRooms(); 
        }
        public RoomType GetRoomType(string selectedRoomDescription)
        {
            using (HotelDBContext context = new HotelDBContext())
            {
                return context.RoomTypes.FirstOrDefault(r => r.RoomDescription == selectedRoomDescription);  
            }
        }

        private void btnBookTheRoom_Click(object sender, EventArgs e)
        {

            var selectedRoomType = GetRoomType(lstAvaibleRooms.Text);
            int days = Convert.ToInt32((checkOutEndDate.Value - CheckInStartDate.Value).TotalDays);
            
            var bookingDate = DateTime.Today;
            var lastDayToPay = bookingDate.AddDays(10);

            using (HotelDBContext context = new HotelDBContext())
            {
                Room room = context.Rooms.FirstOrDefault(r => r.RoomTypeID == selectedRoomType.RoomTypeID);

                ReservationRoom reservationRoom = new ReservationRoom
                {
                    RoomID = room.RoomID
                };
                Payment payment = new Payment
                {
                    PaymentAmount = selectedRoomType.PricePerDay * days,
                    Paid = "No",
                    BookingDate = DateTime.Today,
                    LastDayToPay = lastDayToPay

                };
                Reservation reservation = new Reservation
                {
                    StartDate = CheckInStartDate.Value,
                    EndDate = checkOutEndDate.Value,
                    CustomerID = mainForm.GetSelectedCustomerID(),
                    ReservationRoomsID = reservationRoom.ReservationRoomsID,
                    PaymentID = payment.PaymentID
                    

                };

                context.ReservationRooms.Add(reservationRoom);
                context.Payments.Add(payment);
                context.Reservations.Add(reservation);
                context.SaveChanges();
                this.Close();
            }
        }
    }
}
