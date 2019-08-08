using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEPI.MODEL.Repositories
{
    public class Repository_Colaborador : IDisposable
    {
        private ControleEPIEntities _Contexto;

        public Repository_Colaborador()
        {
            _Contexto = new ControleEPIEntities();
        }

        public void Incluir(Colaborador oColaborador)
        {
            _Contexto.Colaborador.Add(oColaborador);
            _Contexto.SaveChanges();
        }

        public void Alterar(Colaborador oColaborador)
        {
            _Contexto.Entry(oColaborador).State = System.Data.Entity.EntityState.Modified;
            _Contexto.SaveChanges();
        }

        public void Excluir (Colaborador oColaborador)
        {
            _Contexto.Colaborador.Remove(oColaborador);
            _Contexto.SaveChanges();
        }
        public Colaborador Selecionar(int RE)
        {
            return (from p in _Contexto.Colaborador where p.RE == RE select p).FirstOrDefault();
        }
        public List<Colaborador> SelecionarTodos()
        {
            return (from p in _Contexto.Colaborador orderby p.Nome select p).ToList();
        }
        public void Dispose()
        {
            _Contexto.Dispose();
        }
    }
}
