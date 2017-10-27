using System;
using System.IO;

namespace CadastroVendasPoo.classes{
    /// <summary>
    /// Salva o produto
    /// </summary>
    public class SalvarProduto{

        /// <summary>
        /// Salva o produto em CSV
        /// </summary>
        /// <param name="produto">Necessita da classe de produto</param>
        /// <returns>Sucesso ou erro ao salvar o produto</returns>
        public string Salvar(Produto produto){

            string msg = "";
            StreamWriter arquivo = null;

            try{
                  arquivo = new StreamWriter("cadProdutos.csv", true);
                  arquivo.WriteLine(
                      produto.Id+";"+
                      produto.NomeDoProduto+";"+
                      produto.Descricao+";"+
                      produto.Preco+";"
                  );
                  msg = "Produto salvo com sucesso";
            }catch(Exception ex){
                 msg = "Erro: Falha ao gravar o arquivo: "+ ex.Message;
            }finally{
                 arquivo.Close();
            }

            return msg;

        }
        

    }

}