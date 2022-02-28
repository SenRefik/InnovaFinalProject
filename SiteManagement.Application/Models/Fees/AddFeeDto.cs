using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Application.Models.Fees
{
    public class AddFeeDto
    {
        public int FlatId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public decimal FeePrice { get; set; }
    }
}
