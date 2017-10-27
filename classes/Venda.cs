using System;

/// <summary>
/// A classe Venda possui informações sobre o venda
/// </summary>
namespace CadastroVendasPoo.classes{
    public class Venda{
        private string cpf;
        private int id;
        private DateTime datavenda;

        public DateTime DataVenda
        {
            get { return datavenda;}
            set { datavenda = value;}
        }
        
        public int Id
        {
            get { return id;}
            set { id = value;}
        }
        
        public string Cpf
        {
            get { return cpf;}
            set { cpf = value;}
        }
        
        /// <summary>
        /// Cria o método Venda
        /// </summary>
        public Venda(){}
        /// <summary>
        /// Cria o método Venda solocotando todos os parâmetros
        /// </summary>
        /// <param name="cpf">Cpf em forma de texto</param>
        /// <param name="id">Id em forma de inteiro</param>
        /// <param name="datavenda">Data da venda em formato DateTime</param>
        public Venda(string cpf, int id, DateTime datavenda){
            this.cpf       = cpf;
            this.id        = id;
            this.datavenda = datavenda;
        }

        

    }
}