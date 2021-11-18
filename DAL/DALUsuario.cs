using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Text;
using System.Data.Common;
using System.Globalization;
using System.Xml;
using System.Data.Entity;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace ProgramaTrainee.DAL
{
    public class DALUsuario
    {
        public List<classUsuario>  ConsultaUsuarios(classUsuario objUsuario)
        {
            List<classUsuario> lstUsuarios = new List<classUsuario>();

            SqlConnection co = new SqlConnection();

            co.ConnectionString = ConfigurationManager.ConnectionStrings["ConexaoProgramaTrainee"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = co;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "SP_ListarUsuarios";

            co.Open();

            cmd.Parameters.Add("@login", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@login"].Value = objUsuario.Login;
            cmd.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@nome"].Value = objUsuario.Nome;
            cmd.Parameters.Add("@apelido", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@apelido"].Value = objUsuario.Apelido;
            cmd.Parameters.Add("@cargo", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@cargo"].Value = objUsuario.Cargo;
            cmd.Parameters.Add("@departamento", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@departamento"].Value = objUsuario.Departamento;
            cmd.Parameters.Add("@data_criacao_de", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@data_criacao_de"].Value = "";
            cmd.Parameters.Add("@data_criacao_ate", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@data_criacao_ate"].Value = "";
            cmd.Parameters.Add("@sexo", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@sexo"].Value = "";

            DbDataReader dtrDados = cmd.ExecuteReader();
            {
                if (dtrDados != null && dtrDados.HasRows)
                {

                    while (dtrDados.Read())
                    {
                        objUsuario = new classUsuario();

                        objUsuario.ID_Usuario = Convert.ToInt32(dtrDados["ID_Usuario"]);
                        objUsuario.Login = Convert.ToString(dtrDados["Login"]);
                        objUsuario.Senha = Convert.ToString(dtrDados["Senha"]);
                        objUsuario.Nome = Convert.ToString(dtrDados["Nome"]);
                        objUsuario.Apelido = Convert.ToString(dtrDados["Apelido"]);
                        objUsuario.Cargo = Convert.ToString(dtrDados["Cargo"]);
                        objUsuario.Departamento = Convert.ToString(dtrDados["Departamento"]);
                        objUsuario.Sexo = Convert.ToString(dtrDados["Sexo"]);
                        objUsuario.Data_criacao = Convert.ToDateTime(dtrDados["Data_criacao"]);
                        objUsuario.Data_alteracao = Convert.ToDateTime(dtrDados["Data_alteracao"]);

                        lstUsuarios.Add(objUsuario);
                    }

                    dtrDados.Close();

                    return lstUsuarios;
                }
                else
                {
                    return new List<classUsuario>();
                }
            }
        }

        public classUsuario SP_ChamarLogin(classUsuario objUsuario)
        {
            SqlConnection co = new SqlConnection();

            co.ConnectionString = ConfigurationManager.ConnectionStrings["ConexaoProgramaTrainee"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = co;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "SP_ChamarUsuario";

            co.Open();



            cmd.Parameters.Add("@Login", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Login"].Value = objUsuario.Login;
            cmd.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Nome"].Value = objUsuario.Nome;
            cmd.Parameters.Add("@Apelido", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Apelido"].Value = objUsuario.Apelido;
            cmd.Parameters.Add("@cargo", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@cargo"].Value = objUsuario.Cargo;
            cmd.Parameters.Add("@Departamento", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@Departamento"].Value = objUsuario.Departamento;

            DbDataReader dtrDados = cmd.ExecuteReader();
            {
                if (dtrDados != null && dtrDados.HasRows)
                {

                    while (dtrDados.Read())
                    {
                        objUsuario.ID_Usuario = Convert.ToInt32(dtrDados["ID_Usuario"]);
                        objUsuario.Login = Convert.ToString(dtrDados["Login"]);
                        objUsuario.Senha = Convert.ToString(dtrDados["Senha"]);
                        objUsuario.Nome = Convert.ToString(dtrDados["Nome"]);
                        objUsuario.Apelido = Convert.ToString(dtrDados["Apelido"]);
                        objUsuario.Cargo = Convert.ToString(dtrDados["Cargo"]);
                        objUsuario.Departamento = Convert.ToString(dtrDados["Departamento"]);
                        objUsuario.Sexo = Convert.ToString(dtrDados["Sexo"]);
                        objUsuario.Data_criacao = Convert.ToDateTime(dtrDados["Data_criacao"]);
                        objUsuario.Data_alteracao = Convert.ToDateTime(dtrDados["Data_alteracao"]);
                    }

                    dtrDados.Close();

                    return objUsuario;
                }
                else
                {
                    return new classUsuario();
                }
            }
        }
        //Editar Usuário
        public Boolean SP_AlterarUsuario(classUsuario objUsuario)
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
            cmd.CommandText = "SP_AlterarUsuario";

            //abrindo a conexão
            co.Open();

            //Adicionando os parâmetros que a procerude recebe

            cmd.Parameters.Add("@ID_Usuario", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@Login", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("@Senha", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("@Apelido", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("@cargo", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("@Departamento", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("@Sexo", System.Data.SqlDbType.NVarChar);

            cmd.Parameters["@ID_Usuario"].Value = objUsuario.ID_Usuario;
            cmd.Parameters["@Login"].Value = objUsuario.Login;
            cmd.Parameters["@Senha"].Value = objUsuario.Senha;
            cmd.Parameters["@Nome"].Value = objUsuario.Nome;
            cmd.Parameters["@Apelido"].Value = objUsuario.Apelido;
            cmd.Parameters["@cargo"].Value = objUsuario.Cargo;
            cmd.Parameters["@Departamento"].Value = objUsuario.Departamento;
            cmd.Parameters["@Sexo"].Value = objUsuario.Sexo;

            //Executa a procedure de inserir
            Int32 QuantidadeDeLinhas = cmd.ExecuteNonQuery();

            return (QuantidadeDeLinhas > 0);

        }
        //Deletar Usuário
        public Boolean SP_ExcluirUsuario(classUsuario objUsuario)
        {

            SqlConnection co = new SqlConnection();

            co.ConnectionString = ConfigurationManager.ConnectionStrings["ConexaoProgramaTrainee"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = co;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.CommandText = "SP_ExcluirUsuario";

            co.Open();

            cmd.Parameters.Add("@ID_Usuario", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@Login", System.Data.SqlDbType.NVarChar);

            cmd.Parameters["@ID_Usuario"].Value = objUsuario.ID_Usuario;
            cmd.Parameters["@Login"].Value = objUsuario.Login;

            Int32 QuantidadeDeLinhas = cmd.ExecuteNonQuery();

            return (QuantidadeDeLinhas > 0);
        }
        public Boolean InserirUsuario(classUsuario objUsuario) 
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
            cmd.CommandText = "InserirUsuario";

            //abrindo a conexão
            co.Open();

            //Adicionando os parâmetros que a procerude recebe
            cmd.Parameters.Add("@Login", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("@Senha", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("@Apelido", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("@cargo", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("@Departamento", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("@Sexo", System.Data.SqlDbType.NVarChar);

            cmd.Parameters["@Login"].Value = objUsuario.Login;
            cmd.Parameters["@Senha"].Value = objUsuario.Senha;
            cmd.Parameters["@Nome"].Value = objUsuario.Nome;
            cmd.Parameters["@Apelido"].Value = objUsuario.Apelido;
            cmd.Parameters["@cargo"].Value = objUsuario.Cargo;
            cmd.Parameters["@Departamento"].Value = objUsuario.Departamento;
            cmd.Parameters["@Sexo"].Value = objUsuario.Sexo;

            //Executa a procedure de inserir
            Int32 QuantidadeDeLinhas = cmd.ExecuteNonQuery();

            return (QuantidadeDeLinhas > 0);


            }

        public classUsuario ValidarLogin(String Login, String Senha)
        {
            SqlConnection co = new SqlConnection();

            co.ConnectionString = ConfigurationManager.ConnectionStrings["ConexaoProgramaTrainee"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = co;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "ValidarLogin";
            

            co.Open();

            cmd.Parameters.Add("@Login", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("@Senha", System.Data.SqlDbType.NVarChar);

            cmd.Parameters["@Login"].Value = Login;
            cmd.Parameters["@Senha"].Value = Senha;

            using (DbDataReader dtrDados = cmd.ExecuteReader())
            {
                if (dtrDados != null && dtrDados.HasRows)
                {
                    classUsuario objUsuario = new classUsuario();

                    while (dtrDados.Read())
                    {
                        objUsuario.ID_Usuario = Convert.ToInt32(dtrDados["ID_Usuario"]);
                        objUsuario.Nome = Convert.ToString(dtrDados["Nome"]);
                        objUsuario.Login = Convert.ToString(dtrDados["Login"]);
                        objUsuario.Apelido = Convert.ToString(dtrDados["Apelido"]);
                        objUsuario.Cargo = Convert.ToString(dtrDados["Cargo"]);
                        objUsuario.Data_alteracao = Convert.ToDateTime(dtrDados["Data_alteracao"]);
                        objUsuario.Data_criacao = Convert.ToDateTime(dtrDados["Data_criacao"]);
                        objUsuario.Departamento = Convert.ToString(dtrDados["Departamento"]);
                    }

                    dtrDados.Close();

                    return objUsuario;
                }
                else
                {
                    return new classUsuario();
                }
            }

        }
    }
}