namespace ClienteAPI.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<ClienteAPI.Models.Cliente> Clientes { get; set; }
    }
}