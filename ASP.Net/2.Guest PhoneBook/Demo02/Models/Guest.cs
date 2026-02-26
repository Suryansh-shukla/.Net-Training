using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo02.Models
{
    public class Guest
    {
        [Required(ErrorMessage = "ID is Required")]
        [RegularExpression(@"^\d{3}$", ErrorMessage = "Only Three Digits allowed")]
        public int GuestNo { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        public string GuestName { get; set; }
        [Required(ErrorMessage = "PhoneNumber is Required")]
        [StringLength(10, ErrorMessage = "Only 10 Characters Allowed")]
        public string PhoneNumber { get; set; }
    }

    public class GuestService
    {
        private static List<Guest> guestList = null;

        static GuestService()
        {
            guestList = new List<Guest>();
            guestList.Add(new Guest { GuestNo = 101, GuestName = "Anil Patil", PhoneNumber = "9986655092" });
            guestList.Add(new Guest { GuestNo = 102, GuestName = "Ganesh", PhoneNumber = "9844567567" });
            guestList.Add(new Guest { GuestNo = 103, GuestName = "Ajit", PhoneNumber = "991234092" });
            guestList.Add(new Guest { GuestNo = 104, GuestName = "Abishek", PhoneNumber = "9841014567" });
            guestList.Add(new Guest { GuestNo = 105, GuestName = "Karthik", PhoneNumber = "9789273092" });
            guestList.Add(new Guest { GuestNo = 106, GuestName = "Shashank", PhoneNumber = "9841014567" });
            guestList.Add(new Guest { GuestNo = 107, GuestName = "Vaishali", PhoneNumber = "9841544545" });
            guestList.Add(new Guest { GuestNo = 108, GuestName = "Nachiket", PhoneNumber = "9535345787" });


        }

        public bool AddGuest(Guest newGuest)
        {
            bool guestAdded = false;
            int oldCount = guestList.Count;
            guestList.Add(newGuest);
            int newCount = guestList.Count;
            if (newCount > oldCount)
                guestAdded = true;
            return guestAdded;
        }

        public List<Guest> GetAllGuests()
        {
            return guestList;
        }


        public Guest ShowGuest(int guestNumber)
        {
            return guestList.First(g => g.GuestNo == guestNumber);
        }

        public Guest UpdateGuest(Guest updateGuest)
        {
            Guest guest = guestList.First(g => g.GuestNo == updateGuest.GuestNo);
            guest.GuestName = updateGuest.GuestName;
            guest.PhoneNumber = updateGuest.PhoneNumber;
            return guest;

        }
        public bool RemoveGuest(int id)
        {
            Guest gs = guestList.First(g => g.GuestNo == id);
            return guestList.Remove(gs);
        }
    }
}