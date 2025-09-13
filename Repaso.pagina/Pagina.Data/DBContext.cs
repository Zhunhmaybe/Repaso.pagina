// Target framework for the code: .NET 8.0
using Microsoft.EntityFrameworkCore;
using Repaso.pagina.Models.Data.Models;//importar el namespace de los modelos

namespace Repaso.pagina.Pagina.Data
{
    public class DBContext: DbContext
    {
        //constructor // builder
        public DBContext(DbContextOptions<DBContext> options ): base(options) 
        {

        }
        // to do : add dbsets (tablas de la db)
        public DbSet<Repaso.pagina.Models.Data.Models.ViewModelClientes>? Clientes { get; set; }
        public DbSet<ViewModelMeseros>? Meseros { get; set; }
    }
}
