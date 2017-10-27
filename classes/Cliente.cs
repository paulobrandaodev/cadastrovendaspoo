using System;

/// <summary>
/// A classe Cliente possui informações sobre o cliente
/// </summary>
namespace CadastroVendasPoo.classes{
    public class Cliente{
        private string nome;
        private string email;
        private string cpf;
        private DateTime datacadastro;

        /// <summary>
        /// Constói o objeto Cliente
        /// </summary>
        public Cliente()
        {
            
        }

        /// <summary>
        /// Constrói o objeto Cliente e você precisa passar todos os parâmetros
        /// </summary>
        /// <param name="nome">Nome do cliente em corma de texto</param>
        /// <param name="email">Email do cliente em corma de texto</param>
        /// <param name="cpf">CPF do cliente em corma de texto</param>
        /// <param name="datacadastro">Passe a data de cadastro como DateTime</param>
        public Cliente(string nome, string email, string cpf, DateTime datacadastro)
        {
            this.nome = nome;
            this.email = email;
            this.cpf = cpf;
            this.datacadastro = datacadastro;

        }

        public string Nome { get{return nome;} set{nome = value;}}
        public string Email { get{return email;} set{email = value;} }
        public string Cpf { get{return cpf;} set{cpf = value;} }
        public DateTime DataCadastro { get{return datacadastro;} set{datacadastro = value;} }

    }
}