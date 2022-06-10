using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financiera.Data;
using Financiera.Core;
namespace Tienda.Logic
{
    public class ClienteBL
    {
        public static List<Cliente> Listar()
        {
            using (var db = new FinancieraEntities())
            {
                return db.Cliente.ToList();
            }
        }

        public static Cliente Buscar(int id)
        {
            using (var db = new FinancieraEntities())
            {
                return db.Cliente.Find(id);
            }
        }
    }
}
