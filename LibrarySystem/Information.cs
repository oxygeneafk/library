using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Information
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string ReceivedBook { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime DateOfReceipt { get; set; }
    }
}
