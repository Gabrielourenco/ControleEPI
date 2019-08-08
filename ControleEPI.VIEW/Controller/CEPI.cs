using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleEPI.MODEL;
using ControleEPI.MODEL.Repositories;

namespace ControleEPI.VIEW.Controller
{
    public class CEPI :IDisposable
    {
        Repository_EPI _Repository;

        public CEPI()
        {
            _Repository = new Repository_EPI();
        }
        public void Incluir(EPI oEPI)
        {
            _Repository.Incluir(oEPI);
        }
        public void Alterar(EPI oEPI)
        {
            _Repository.Alterar(oEPI);
        }
        public void Excluir(EPI oEPI)
        {
            _Repository.Excluir(oEPI);
        }
        public EPI Selecionar(int Codigo)
        {
            return _Repository.Selecionar(Codigo);
        }
        public List<EPI> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }
        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}

