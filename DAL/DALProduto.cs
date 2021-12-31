using ProgramaTrainee.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;


namespace ProgramaTrainee.DAL
{
    public class DALProduto
    {
        public List<classProduto> ListarTodosProdutos(classProduto objProduto)
        {
            List<classProduto> lstProdutos = new List<classProduto>();

            SqlConnection co = new SqlConnection();

            co.ConnectionString = ConfigurationManager.ConnectionStrings["ConexaoProgramaTrainee"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = co;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Consultar_Produto";

            co.Open();

            cmd.Parameters.Add("@ID_Produtos", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@ID_Produtos"].Value = objProduto.ID_Produtos;

            cmd.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Nome"].Value = objProduto.Nome;

            cmd.Parameters.Add("@Cor", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Cor"].Value = objProduto.Cor;

            cmd.Parameters.Add("@Valor", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Valor"].Value = objProduto.Valor;

            cmd.Parameters.Add("@Quantidade", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Quantidade"].Value = objProduto.Quantidade;

            cmd.Parameters.Add("@Tecido", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Tecido"].Value = objProduto.Tecido;

            cmd.Parameters.Add("@Tamanho", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Tamanho"].Value = objProduto.Tamanho;

            cmd.Parameters.Add("@data_criacao_de", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@data_criacao_de"].Value = "";

            cmd.Parameters.Add("@data_criacao_ate", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@data_criacao_ate"].Value = "";

            cmd.Parameters.Add("@Data_Alteracao_De", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Data_Alteracao_De"].Value = "";

            cmd.Parameters.Add("@Data_Alteracao_Ate", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Data_Alteracao_Ate"].Value = "";

            DbDataReader dtrDados = cmd.ExecuteReader();
            {
                if (dtrDados != null && dtrDados.HasRows)
                {

                    while (dtrDados.Read())
                    {
                        objProduto = new classProduto();

                        objProduto.ID_Produtos = Convert.ToInt32(dtrDados["ID_Produtos"]);
                        objProduto.Nome = Convert.ToString(dtrDados["Nome"]);
                        objProduto.Cor = Convert.ToString(dtrDados["Cor"]);
                        objProduto.Valor = Convert.ToDouble(dtrDados["Valor"]);
                        objProduto.Quantidade = Convert.ToInt32(dtrDados["Quantidade"]);
                        objProduto.Tecido = Convert.ToString(dtrDados["Tecido"]);
                        objProduto.Tamanho =  Convert.ToString(dtrDados["Tamanho"]).Trim();
                        objProduto.Data_Criacao = Convert.ToDateTime(dtrDados["Data_criacao"]);
                        objProduto.Data_Alteracao = Convert.ToDateTime(dtrDados["Data_alteracao"]);

                        lstProdutos.Add(objProduto);
                    }

                    dtrDados.Close();

                    return lstProdutos;
                }
                else
                {
                    return new List<classProduto>();
                }
            }

        }
        //public List<classProduto> ConsultaProdutos(classProduto objProduto)
        //{
        //    List<classProduto> lstProduto = new List<classProduto>();

        //    SqlConnection co = new SqlConnection();

        //    co.ConnectionString = ConfigurationManager.ConnectionStrings["ConexaoProgramaTrainee"].ConnectionString;

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = co;
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    cmd.CommandText = "Consultar_Produto";

        //    co.Open();

        //    cmd.Parameters.Add("@ID_Produtos", System.Data.SqlDbType.Int);
        //    cmd.Parameters["@ID_Produtos"].Value = objProduto.ID_Produtos;
        //    cmd.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
        //    cmd.Parameters["@Nome"].Value = objProduto.Nome;
        //    cmd.Parameters.Add("@Cor", System.Data.SqlDbType.NVarChar);
        //    cmd.Parameters["@Cor"].Value = objProduto.Cor;
        //    cmd.Parameters.Add("@Valor", System.Data.SqlDbType.Money);
        //    cmd.Parameters["@Valor"].Value = objProduto.Valor;
        //    cmd.Parameters.Add("@Quantidade", System.Data.SqlDbType.Int);
        //    cmd.Parameters["@Quantidade"].Value = objProduto.Quantidade;
        //    cmd.Parameters.Add("@Tecido", System.Data.SqlDbType.NVarChar);
        //    cmd.Parameters["@Tecido"].Value = objProduto.Tecido;
        //    cmd.Parameters.Add("@Tamanho", System.Data.SqlDbType.NVarChar);
        //    cmd.Parameters["@Tamanho"].Value = objProduto.Tamanho;
        //    cmd.Parameters.Add("@data_criacao_de", System.Data.SqlDbType.DateTime);
        //    cmd.Parameters["@data_criacao_de"].Value = DateTime.Now;
        //    cmd.Parameters.Add("@data_criacao_ate", System.Data.SqlDbType.DateTime);
        //    cmd.Parameters["@data_criacao_ate"].Value = objProduto.Data_Criacao;
        //    cmd.Parameters.Add("@Data_Alteracao_De", System.Data.SqlDbType.DateTime);
        //    cmd.Parameters["@Data_Alteracao_De"].Value = DateTime.Now;
        //    cmd.Parameters.Add("@Data_Alteracao_Ate", System.Data.SqlDbType.DateTime);
        //    cmd.Parameters["@Data_Alteracao_Ate"].Value = objProduto.Data_Alteracao;

        //    DbDataReader dtrDados = cmd.ExecuteReader();
        //    {
        //        if (dtrDados != null && dtrDados.HasRows)
        //        {

        //            while (dtrDados.Read())
        //            {
        //                objProduto = new classProduto();

        //                objProduto.ID_Produtos = Convert.ToInt32(dtrDados["ID_Produtos"]);
        //                objProduto.Nome = Convert.ToString(dtrDados["Nome"]);
        //                objProduto.Cor = Convert.ToString(dtrDados["Cor"]);
        //                objProduto.Valor = Convert.ToDouble(dtrDados["Valor"]);
        //                objProduto.Quantidade = Convert.ToInt32(dtrDados["Quantidade"]);
        //                objProduto.Tecido = Convert.ToString(dtrDados["Tecido"]);
        //                objProduto.Tamanho = Convert.ToString(dtrDados["Tamanho"]).Trim();
        //                objProduto.Data_Criacao = Convert.ToDateTime(dtrDados["Data_criacao"]);
        //                objProduto.Data_Alteracao = Convert.ToDateTime(dtrDados["Data_alteracao"]);


        //                lstProduto.Add(objProduto);
        //            }

        //            dtrDados.Close();

        //            return lstProduto;
        //        }
        //        else
        //        {
        //            return new List<classProduto>();
        //        }
        //    }
        //}
        public List<classProduto> ConsultaProdutos(classProduto objProduto)
        {
            List<classProduto> lstProdutos = new List<classProduto>();

            SqlConnection co = new SqlConnection();

            co.ConnectionString = ConfigurationManager.ConnectionStrings["ConexaoProgramaTrainee"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = co;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Consultar_Produto";

            co.Open();

            cmd.Parameters.Add("@ID_Produtos", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@ID_Produtos"].Value = objProduto.ID_Produtos;

            cmd.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Nome"].Value = objProduto.Nome;

            cmd.Parameters.Add("@Cor", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Cor"].Value = objProduto.Cor;

            cmd.Parameters.Add("@Valor", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Valor"].Value = objProduto.Valor;

            cmd.Parameters.Add("@Quantidade", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Quantidade"].Value = objProduto.Quantidade;

            cmd.Parameters.Add("@Tecido", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Tecido"].Value = objProduto.Tecido;

            cmd.Parameters.Add("@Tamanho", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Tamanho"].Value = objProduto.Tamanho;

            cmd.Parameters.Add("@data_criacao_de", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@data_criacao_de"].Value = "";

            cmd.Parameters.Add("@data_criacao_ate", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@data_criacao_ate"].Value = "";

            cmd.Parameters.Add("@Data_Alteracao_De", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Data_Alteracao_De"].Value = "";

            cmd.Parameters.Add("@Data_Alteracao_Ate", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Data_Alteracao_Ate"].Value = "";

            DbDataReader dtrDados = cmd.ExecuteReader();
            {
                if (dtrDados != null && dtrDados.HasRows)
                {

                    while (dtrDados.Read())
                    {
                        objProduto = new classProduto();

                        objProduto.ID_Produtos = Convert.ToInt32(dtrDados["ID_Produtos"]);
                        objProduto.Nome = Convert.ToString(dtrDados["Nome"]);
                        objProduto.Cor = Convert.ToString(dtrDados["Cor"]);
                        objProduto.Valor = Convert.ToDouble(dtrDados["Valor"]);
                        objProduto.Quantidade = Convert.ToInt32(dtrDados["Quantidade"]);
                        objProduto.Tecido = Convert.ToString(dtrDados["Tecido"]);
                        objProduto.Tamanho = Convert.ToString(dtrDados["Tamanho"]).Trim();
                        objProduto.Data_Criacao = Convert.ToDateTime(dtrDados["Data_criacao"]);
                        objProduto.Data_Alteracao = Convert.ToDateTime(dtrDados["Data_alteracao"]);

                        lstProdutos.Add(objProduto);
                    }

                    dtrDados.Close();

                    return lstProdutos;
                }
                else
                {
                    return new List<classProduto>();
                }
            }
        }
        public Boolean InserirProdutos(classProduto objProduto)
        {
            //Aqui é o objeto de conexão
            SqlConnection co = new SqlConnection();

            //Pegando as configurações da conexão do arquivo web.config 
            co.ConnectionString = ConfigurationManager.ConnectionStrings["ConexaoProgramaTrainee"].ConnectionString;

            //Criando o objeto para fazer os comandos sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = co;

            //Informando que o tipo do comando será procedure
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //nome da procedure 
            cmd.CommandText = "Inserir_Produto";

            //abrindo a conexão
            co.Open();

            //Adicionando os parâmetros que a procerude recebe

            cmd.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Nome"].Value = objProduto.Nome;

            cmd.Parameters.Add("@Cor", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Cor"].Value = objProduto.Cor;

            cmd.Parameters.Add("@Valor", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Valor"].Value = objProduto.Valor;

            cmd.Parameters.Add("@Quantidade", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Quantidade"].Value = objProduto.Quantidade;

            cmd.Parameters.Add("@Tecido", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Tecido"].Value = objProduto.Tecido;

            cmd.Parameters.Add("@Tamanho", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Tamanho"].Value = objProduto.Tamanho;


            //Executa a procedure de inserir
            Int32 QuantidadeDeLinhas = cmd.ExecuteNonQuery();

            return (QuantidadeDeLinhas > 0);


        }

        public Boolean ExcluirProdutos(classProduto objProduto)
        {

            SqlConnection co = new SqlConnection();

            co.ConnectionString = ConfigurationManager.ConnectionStrings["ConexaoProgramaTrainee"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = co;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.CommandText = "Excluir_Produto";

            co.Open();

            cmd.Parameters.Add("@ID_Produtos", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);

            cmd.Parameters["@ID_Produtos"].Value = objProduto.ID_Produtos;
            cmd.Parameters["@Nome"].Value = objProduto.Nome;

            Int32 QuantidadeDeLinhas = cmd.ExecuteNonQuery();

            return (QuantidadeDeLinhas > 0);
        }

        public Boolean AlterarProduto(classProduto objProduto)
        {
            //Aqui é o objeto de conexão
            SqlConnection co = new SqlConnection();

            //Pegando as configurações da conexão do arquivo web.config 
            co.ConnectionString = ConfigurationManager.ConnectionStrings["ConexaoProgramaTrainee"].ConnectionString;

            //Criando o objeto para fazer os comandos sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = co;

            //Informando que o tipo do comando será procedure
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //nome da procedure 
            cmd.CommandText = "Alterar_Produto";

            //abrindo a conexão
            co.Open();

            //Adicionando os parâmetros que a procerude recebe

            cmd.Parameters.Add("@ID_Produtos", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("@Cor", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("@Valor", System.Data.SqlDbType.Money);
            cmd.Parameters.Add("@Quantidade", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@Tecido", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("@Tamanho", System.Data.SqlDbType.NVarChar);


            cmd.Parameters["@ID_Produtos"].Value = objProduto.ID_Produtos;
            cmd.Parameters["@Nome"].Value = objProduto.Nome;
            cmd.Parameters["@Cor"].Value = objProduto.Cor;
            cmd.Parameters["@Valor"].Value = objProduto.Valor;
            cmd.Parameters["@Quantidade"].Value = objProduto.Quantidade;
            cmd.Parameters["@Tecido"].Value = objProduto.Tecido;
            cmd.Parameters["@Tamanho"].Value = objProduto.Tamanho;


            //Executa a procedure de inserir
            Int32 QuantidadeDeLinhas = cmd.ExecuteNonQuery();

            return (QuantidadeDeLinhas > 0);

        }
       

    }
}