using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Application.Models.Flats
{
    public class AddFlatDto
    {
        public int BlockId { get; set; }
        public int Floor { get; set; }
        public bool IsFull { get; set; }
        public int DoorNumber { get; set; }
        public string Type { get; set; }
    }
}
