using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEPI.MODEL.Repositories
{
    public class Repository_EPI : IDisposable
    {
        private ControleEPIEntities _Contexto;

        public Repository_EPI()
        {
            _Contexto = new ControleEPIEntities();
        }
        public void Incluir(EPI oEPI)
        {
            _Contexto.EPI.Add(oEPI);
            _Contexto.SaveChanges();
        }
        public void Alterar(EPI oEPI)
        {
            _Contexto.Entry(oEPI).State = System.Data.Entity.EntityState.Modified;
            _Contexto.SaveChanges();
        }
        public void Excluir(EPI oEPI)
        {
            _Contexto.EPI.Remove(oEPI);
            _Contexto.SaveChanges();
        }


        public EPI Selecionar(int Codigo)
        {
            return (from p in _Contexto.EPI where p.Codigo == Codigo select p).FirstOrDefault();
        }

        public List<EPI> SelecionarTodos()
        {
            return (from p in _Contexto.EPI orderby p.Nome select p).ToList();
        }
        public void Dispose()
        {
            _Contexto.Dispose();
        }
        
    }
}
