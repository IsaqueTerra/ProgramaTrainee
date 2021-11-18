using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramaTrainee.BLL
{
    public class BLLUsuario
    {
        public classUsuario ValidarLogin(classUsuario objUsuario)
        {
            DAL.DALUsuario dalUsuario = new DAL.DALUsuario();

            return dalUsuario.ValidarLogin(objUsuario.Login, objUsuario.Senha);

            
        }
        public Boolean InserirUsuario(classUsuario objUsuario)
        {
            DAL.DALUsuario dALUsuario = new DAL.DALUsuario();

            return dALUsuario.InserirUsuario(objUsuario);


        }
        public Boolean SP_ExcluirUsuario(classUsuario objUsuario)
        {
            DAL.DALUsuario dalUsuario = new DAL.DALUsuario();

            return dalUsuario.SP_ExcluirUsuario(objUsuario);
        }
        public Boolean SP_AlterarUsuario(classUsuario objUsuario)
        {
            DAL.DALUsuario dALUsuario = new DAL.DALUsuario();

            return dALUsuario.SP_AlterarUsuario(objUsuario);
        }
        public classUsuario SP_ChamarUsuario(classUsuario objUsuario)
        {
            DAL.DALUsuario dalUsuario = new DAL.DALUsuario();

            return dalUsuario.SP_ChamarLogin(objUsuario);

        }

        public List<classUsuario> ConsultaUsuarios(classUsuario objUsuario)
        {
            DAL.DALUsuario dalUsuario = new DAL.DALUsuario();

            return dalUsuario.ConsultaUsuarios(objUsuario);
        }
    }
}