using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Domain.Entities.Commons
{
    public abstract class EntityBase
    {
        public int Id { get; set; }

    }
}
