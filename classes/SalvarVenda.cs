using System;
using System.IO;

namespace CadastroVendasPoo.classes{
    /// <summary>
    /// Salva a venda
    /// </summary>
    public class SalvarVenda{

        /// <summary>
        /// Salva a venda em CSV
        /// </summary>
        /// <param name="venda">Precisa dos dados da venda</param>
        /// <returns>Retorna se foi salvo com sucesso ou com erro</returns>
        public string Salvar(Venda venda){

            string msg = "";
            StreamWriter arquivo = null;
            FileInfo cadCliente = new FileInfo("cadClientes.csv");

            try{
                if(cadCliente.Exists){
                  arquivo = new StreamWriter("cadVendas.csv", true);
                  arquivo.WriteLine(
                      venda.Id+";"+
                      venda.Cpf+";"+
                      venda.DataVenda+";"
                  );
                  msg = "Venda venda efetuada com sucesso";
                }else{
                  msg = "O cliente não existe";
                }
            }catch(Exception ex){
                 msg = "Erro: Falha ao gravar o arquivo: "+ ex.Message;
            }finally{
                 arquivo.Close();                
            }

            return msg;

        }

        

    }

}

