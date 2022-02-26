using SiteManagement.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Domain.Entities.Flats
{
    public class Flats : EntityBase
    {
        public int Id { get; set; }
        public int BlockId { get; set; }
        public int Floor { get; set; }
        public bool IsEmpty { get; set; }
        public string Type { get; set; }
        public string UserId { get; set; }
    }
}
