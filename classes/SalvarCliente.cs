using System;
using System.IO;

namespace CadastroVendasPoo.classes{
    /// <summary>
    /// Salva o cliente em um CSV
    /// </summary>
    public class SalvarCliente{

        /// <summary>
        /// Salva o cliente
        /// </summary>
        /// <param name="cliente">Precisa dos dados do cliente</param>
        /// <returns></returns>
        public string Salvar(Cliente cliente){

            string msg = "";
            StreamWriter arquivo = null;

            try{
                arquivo = new StreamWriter("cadClientes.csv", true);
                if(cpfValido(cliente.Cpf)){
                  
                  arquivo.WriteLine(
                      cliente.Nome+";"+
                      cliente.Cpf+";"+
                      cliente.DataCadastro+";"
                  );
                  msg = "Cliente salvo com sucesso";
                } else {
                  msg = "CPF inválido!";
                }
            }catch(Exception ex){
                 msg = "Erro: Falha ao gravar o arquivo: "+ ex.Message;
            }finally{
                 arquivo.Close();
            }

            return msg;

        }
        
        private bool cpfValido(string cpfUsuario){
            bool retorno = true;
            string cpfCalculo = "";
            
            int[] v1 = {10,9,8,7,6,5,4,3,2};
            int[] v2 = {11,10,9,8,7,6,5,4,3,2};

            int resultado = 0;
            int resto = 0;

            cpfCalculo = cpfUsuario.Substring(0,9);

            //Validando 1° dígito
            for(int i = 0; i < cpfCalculo.Length; i++){
                resultado += Int16.Parse(cpfCalculo[i].ToString())*v1[i];
            }

            resto = resultado % 11;
            if(resto < 2){
                cpfCalculo += "0";
            }else{
             cpfCalculo += (+11-resto).ToString();
            }

            //Zerando as variáveis para 2° dígito
            resultado = 0;
            resto = 0;

            //Validando 2° dígito
            for(int j = 0; j < cpfCalculo.Length; j++){
                resultado += Int16.Parse(cpfCalculo[j].ToString())*v2[j];
            }

            resto = resultado % 11;
            if(resto < 2){
                cpfCalculo += "0";
            }else{
             cpfCalculo += (+11-resto).ToString();
            }

            if(cpfUsuario != cpfCalculo)
                retorno = false;
            
           return retorno;
        }

    }

}

