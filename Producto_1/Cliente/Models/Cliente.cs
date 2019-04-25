using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cliente.Models
{
    public enum StatusType
    {
        Activo,
        Inactivo
    }
    public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }
        [Required]
        public string NombreCompleto{ get; set; }
        public string CorreoElectronico{ get; set; }
        public StatusType Estado { get; set; }

    }
}