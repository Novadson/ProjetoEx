using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace StockControl
{
    public class DataServices
    {
        private readonly ApplicationContext contexto;

        public DataServices(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public async Task InicializaDB()
        {
            await contexto.Database.MigrateAsync();
         
        }
    }
}
