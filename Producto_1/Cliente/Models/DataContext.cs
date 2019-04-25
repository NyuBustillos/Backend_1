namespace Cliente.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<Cliente.Models.Cliente> Clientes { get; set; }
    }
}