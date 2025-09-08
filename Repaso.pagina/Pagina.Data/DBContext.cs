// Target framework for the code: .NET 8.0
using Microsoft.EntityFrameworkCore;

namespace Repaso.pagina.Pagina.Data
{
    public class DBContext: DbContext
    {
        //constructor // builder
        public DBContext(DbContextOptions<DBContext> options ): base(options) 
        {

        }
        // to do : add dbsets (tablas de la db)
    }
}
