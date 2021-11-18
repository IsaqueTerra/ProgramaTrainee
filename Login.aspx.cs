using System;
using System.Web.UI;

namespace ProgramaTrainee
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        String _Nome = "Fernando";

        protected void Page_Load(object sender, EventArgs e)
        {
            classUsuario objUsuario = new classUsuario();

            objUsuario.Apelido = _Nome;

            clsBase.Alert(objUsuario.Apelido, this);

        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            
            classUsuario objUsuario = new classUsuario();

            objUsuario.Login = TxtBxLogin.Text;
            objUsuario.Senha = TxtBxSenha.Text;

            BLL.BLLUsuario bllUsuario = new BLL.BLLUsuario();

            objUsuario = bllUsuario.ValidarLogin(objUsuario);

            if (objUsuario.Login != null)
            {
                clsBase.Alert("Bem vindo usuário: " + objUsuario.Login, this);
            }
            else
            {
                clsBase.Alert("Usuário ou senha não encontrado", this);
            }

        }
    }
}