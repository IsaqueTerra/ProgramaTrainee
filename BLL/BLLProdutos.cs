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



    }
}