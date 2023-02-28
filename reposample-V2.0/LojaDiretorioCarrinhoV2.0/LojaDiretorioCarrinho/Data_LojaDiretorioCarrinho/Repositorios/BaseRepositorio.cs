using Data_LojaDiretorioCarrinho.Models;
using DATA_LojaDiretorioCarrinho.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_LojaDiretorioCarrinho.Repositorios
{
    // Classe do Repositório Base, relacionado ao Modelo de Repositório de classe, com o método Dispose, para liberar recursos.
    public class BaseRepositorio<T> : IModeloRepositorio<T>, IDisposable where T : class
    {
        // Contexto gerado com o EF Core Power Tools
        protected BancoCarrinhoContext _Contexto;
        public bool _SaveChanges = true;

        // Construtor do Repositório Base com Instância do Contexto.
        public BaseRepositorio(bool saveChanges = true)
        {
            _SaveChanges = saveChanges;
            _Contexto = new BancoCarrinhoContext();
        }
        public T Alterar(T objeto)
        {
            // Possibilita a alteração do objeto no banco.
            _Contexto.Entry(objeto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            // Teste do Salvamento das Alterações.
            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }

            return objeto;
        }

        // Método de Limpeza do Objeto.
        public void Dispose()
        {
            _Contexto.Dispose();
        }

        // Remove um Objeto.
        public void Excluir(T objeto)
        {
            _Contexto.Set<T>().Remove(objeto);

            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }
        }

        // Exclui um objeto pela sua Primary Key.
        public void Excluir(params object[] variavel)
        {
            var obj = SelecionarPk(variavel);
            Excluir(obj);
        }

        // Adiciona um Objeto.
        public T Incluir(T objeto)
        {
            _Contexto.Set<T>().Add(objeto);

            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }

            return objeto;
        }

        // Contexto do SaveChanges (Salvar Mudanças).
        public void SaveChanges()
        {
            _Contexto.SaveChanges();
        }

        // Seleciona o Objeto pela sua Chave Primária (Primary Key).
        public T SelecionarPk(params object[] variavel)
        {
            return _Contexto.Set<T>().Find(variavel);
        }

        // Retorna todos os Objetos.
        public List<T> SelecionarTodos()
        {
            return _Contexto.Set<T>().ToList();
        }
    }
}
