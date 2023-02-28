using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_LojaDiretorioCarrinho.Interfaces
{
    // Interface de classe genérica (T)
    public interface IModeloRepositorio<T> where T : class
    {
        // Métodos para adicionar nos Repositórios
        List<T> SelecionarTodos();
        T SelecionarPk(params object[] variavel);
        T Incluir(T objeto); // "T objeto" como parâmetro
        T Alterar(T objeto);
        void Excluir(T objeto);
        void Excluir(params object[] variavel);
        void SaveChanges();

    }
}
