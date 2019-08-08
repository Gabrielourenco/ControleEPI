using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleEPI.MODEL;
using ControleEPI.MODEL.Repositories;

namespace ControleEPI.VIEW.Controller
{
    public class CColaboradores : IDisposable
    {
        Repository_Colaborador _Repository;

        public CColaboradores()
        {
            _Repository = new Repository_Colaborador();
        }

        public void Incluir(Colaborador oColaborador)
        {
            _Repository.Incluir(oColaborador);
        }
        public void Alterar(Colaborador oColaborador)
        {
            _Repository.Alterar(oColaborador);
        }
        public void Excluir(Colaborador oColaborador)
        {
            _Repository.Excluir(oColaborador);
        }
        public Colaborador Selecionar(int RE)
        {
            return _Repository.Selecionar(RE);
        }
        public List<Colaborador> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }
        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
    
    }

