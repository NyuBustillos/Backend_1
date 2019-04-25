using System.ComponentModel.DataAnnotations;

namespace ClienteAPI.Models
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