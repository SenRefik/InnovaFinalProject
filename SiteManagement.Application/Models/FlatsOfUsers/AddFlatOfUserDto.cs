using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Application.Models.FlatsOfUsers
{
    public class AddFlatOfUserDto
    {
        public int UserId { get; set; }
        public int FlatId { get; set; }
        public bool IsOwner { get; set; }
        public bool IsTenant { get; set; }
    }
}
