using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks2014;

namespace AdventureWorks2014.BL.Repositorios
{
    public class RepStores
    {
        private readonly Model.Models.AdventureWorksEntities _context = new Model.Models.AdventureWorksEntities();

        public IEnumerable<Model.Models.Store> ListarStoresPorNombre(string patronConsulta)
        {
            IEnumerable<Model.Models.Store> listaStores = _context.Stores.Where(
                            o => o.Name.Contains(patronConsulta));
            return (listaStores);
        }

        public void Agregar(Model.Models.Store store)
        {
            _context.Stores.Add(store);
        }

        public void Borrar(Model.Models.Store store)
        {
            _context.Stores.Remove(store);
        }

        public void Guardar()
        {
            _context.SaveChanges();
        }

        public void Editar(Model.Models.Store store)
        {
            _context.Entry<Model.Models.Store>(store).State = System.Data.Entity.EntityState.Modified;
        }

        public IQueryable<Model.Models.Store> ObtenerTodos()
        {
            IQueryable<Model.Models.Store> query = _context.Stores;
            return query;
        }

        public Model.Models.Store Obtener( int idStore)
        {
            var query = this.ObtenerTodos().FirstOrDefault(
                                x => x.BusinessEntityID == idStore);
            return query;
        }
    }
}
