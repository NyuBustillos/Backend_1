using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Venta.Models
{
    public class DataContextV:DbContext
    {
        public DataContextV() : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<Venta.Models.Venta> Ventas { get; set; }
    }
}