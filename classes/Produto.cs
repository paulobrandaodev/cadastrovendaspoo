using System;

/// <summary>
/// A classe Produto possui informações sobre o produto
/// </summary>
namespace CadastroVendasPoo.classes{
    public class Produto{
        private int id;
        private string nomedoproduto;
        private string descricao;
        private double preco;

        /// <summary>
        /// Constói o objeto Produto
        /// </summary>
        public Produto()
        {
            
        }

        /// <summary>
        /// Cria o objeto pedindo os parâmetros
        /// </summary>
        /// <param name="id">Id em inteiro</param>
        /// <param name="nomedoproduto">Nome em texto</param>
        /// <param name="descricao">Descrição em texto</param>
        /// <param name="preco">Preço em formato USA</param>
         public Produto(int id, string nomedoproduto, string descricao, double preco)
        {
            this.id = id;
            this.nomedoproduto = nomedoproduto;
            this.descricao = descricao;
            this.preco = preco;

        }

        public int Id { get{return id;} set{id = value;}}
        public string NomeDoProduto { get{return nomedoproduto;} set{nomedoproduto = value;} }
        public string Descricao { get{return descricao;} set{descricao = value;} }        
        public double Preco { get{return preco;} set{preco = value;} }

    }
}