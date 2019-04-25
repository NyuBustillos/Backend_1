using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Venta.Models
{
    public enum StatusType
    {
        Activo,
        Inactivo
    }
    public class Venta
    {
        [Key]
        public int VentaID  { get; set; }
        [Required]
        public string ProductoID  { get; set; }
        public string ClienteID  { get; set; }
        public DateTime Fecha  { get; set; }
        public StatusType Estado { get; set; }

    }
}