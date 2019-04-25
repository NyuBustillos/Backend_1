using System.ComponentModel.DataAnnotations;

namespace Producto_1.Models
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