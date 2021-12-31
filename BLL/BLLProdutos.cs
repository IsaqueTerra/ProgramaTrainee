using ProgramaTrainee.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProgramaTrainee.BLL
{
    public class BLLProdutos
    {
        public List<classProduto> ListarTodosProdutos(classProduto objProduto)
        {
            DAL.DALProduto dalProduto = new DAL.DALProduto();

            return dalProduto.ListarTodosProdutos(objProduto);


        }
        public Boolean InserirProduto(classProduto objProduto)
        {
            DAL.DALProduto dALProduto = new DAL.DALProduto();

            return dALProduto.InserirProdutos(objProduto);


        }
        public List<classProduto> ConsultaProduto(classProduto objProduto)
        {
            DAL.DALProduto dalProduto = new DAL.DALProduto();

            return dalProduto.ConsultaProdutos(objProduto);
        }

        public Boolean ExcluirProduto(classProduto objProduto)
        {
            DAL.DALProduto dalProduto = new DAL.DALProduto();

            return dalProduto.ExcluirProdutos(objProduto);
        }

        public Boolean AlterarProdutos(classProduto objProduto)
        {
            DAL.DALProduto dALProduto = new DAL.DALProduto();

            return dALProduto.AlterarProduto(objProduto);
        }



    }
}