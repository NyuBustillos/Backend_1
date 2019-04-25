using System.ComponentModel.DataAnnotations;

namespace ProductoAPI.Models
{
    public enum StatusType
    {
        Activo,
        Inactivo
    }
    public class Producto 
    {
        [Key]
        public int ProductoID { get; set; }
        [Required]
        public string Nombre_Producto { get; set; }
        public double Precio_producto{ get; set; }
        public StatusType Estado { get; set; }

    }
    
}