using Parking.EFCore.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Parking.EFCore.Repository
{
    public class VeiculoRepository : BaseRepository<Veiculo>, IVeiculoRepository
    {
        public VeiculoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public bool Add(Veiculo veiculo)
        {
            bool _Ok = false;

            try
            {
                Veiculo _veiculo = this.GetPlaca(veiculo.Placa);

                if (_veiculo == null)
                {
                    dbSet.Add(veiculo);
                    contexto.SaveChanges();

                    _Ok = true;
                }
            }
            catch (System.Exception)
            {

                _Ok = false;
            }

            return _Ok;            
        }

        public Veiculo Find(long id)
        {
            return dbSet.FirstOrDefault(v => v.Id == id);
        }

        public IEnumerable<Veiculo> GetAll()
        {
            return dbSet.ToList();
        }

        public Veiculo GetPlaca(string placa)
        {
            return this.GetAll().FirstOrDefault(v => v.Placa == placa);
        }

        public void Remove(long id)
        {
            try
            {
                var veiculo = Find(id);

                if (veiculo != null)
                {
                    dbSet.Remove(veiculo);
                    contexto.SaveChanges();
                }
            }
            catch (System.Exception)
            {
                throw;
            }
            
            
        }

        public void Update(Veiculo veiculo)
        {
            dbSet.Update(veiculo);
            contexto.SaveChanges();
        }
        
    }
}
