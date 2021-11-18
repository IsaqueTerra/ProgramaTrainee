﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgramaTrainee
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            classUsuario objUsuario = new classUsuario();

            PopulaGridUsuarios(objUsuario);
        }
        
        protected void btnInserirUsuario_Click(object sender, ImageClickEventArgs e)
        {
            BLL.BLLUsuario bLLUsuario = new BLL.BLLUsuario();

            classUsuario objUsuario = new classUsuario();
            objUsuario.Login = txtLogin.Text;
            objUsuario.Senha = txtSenha.Text;
            objUsuario.Nome = txtNome.Text;
            objUsuario.ID_Usuario = Convert.ToInt32(lblIDusuario.Value);
            objUsuario.Apelido = txtApelido.Text;
            objUsuario.Cargo = txtCargo.Text;
            objUsuario.Departamento = txtDepartamento.Text;
            objUsuario.Sexo = drpSexo.SelectedValue;



           if ( bLLUsuario.InserirUsuario(objUsuario))
            {
                clsBase.Alert("Usuario inserido com sucesso.", this);

            }
            else
            {
                clsBase.Alert("Erro ao inserir o usuario.", this);
            }
        }
        protected void btnAlterarUsuario_Click(object sender, ImageClickEventArgs e)
        {
            BLL.BLLUsuario bLLUsuario = new BLL.BLLUsuario();

            classUsuario objUsuario = new classUsuario();

            objUsuario.ID_Usuario = 0;
            objUsuario.Login = txtLogin.Text;
            objUsuario.Senha = txtSenha.Text;
            objUsuario.Nome = txtNome.Text;
            objUsuario.ID_Usuario = Convert.ToInt32(lblIDusuario.Value);
            objUsuario.Apelido = txtApelido.Text;
            objUsuario.Cargo = txtCargo.Text;
            objUsuario.Departamento = txtDepartamento.Text;
            objUsuario.Sexo = drpSexo.Text;
            String SenhaA = txtSenha.Text;

            if (txtNome.Text == "" || txtLogin.Text == "" || txtSenha.Text == "")
                {
                    clsBase.Alert("Inserir pelo menos nome,login e senha", this);
                }
            else
            if (bLLUsuario.SP_AlterarUsuario(objUsuario))
                {
                    clsBase.Alert("Usuario alterado com sucesso.", this);

                    txtLogin.Text = "";
                    txtSenha.Text = "";
                    txtNome.Text = "";
                    lblIDusuario.Value = "";
                    txtApelido.Text = "";
                    txtCargo.Text = "";
                    txtDepartamento.Text = "";
                }
                else
                {
                    clsBase.Alert("Erro ao alterar o usuario.", this);
                }

        }
        protected void btnExcluirUsuario_Click(object sender, ImageClickEventArgs e)
        {
            classUsuario objUsuario = new classUsuario();

            objUsuario.Login = txtLogin.Text;

            BLL.BLLUsuario bllUsuario = new BLL.BLLUsuario();

            if (bllUsuario.SP_ExcluirUsuario(objUsuario))
            {
                clsBase.Alert("Usuário excluido com sucesso.", this);

                txtApelido.Text = "";
                txtCargo.Text = "";
                txtDepartamento.Text = "";
                txtLogin.Text = "";
                txtNome.Text = "";
                lblIDusuario.Value = "";
                txtSenha.Text = "";
                TxtBxDataCriacao.Text = "";
                TxtBxDataAlteracao.Text = "";
            }
            else
            {
                clsBase.Alert("Erro ao excluir usuário.", this);
            }
        }

            protected void btnBuscarUsuario_Click(object sender, ImageClickEventArgs e)
            {
            
                    classUsuario objUsuario = new classUsuario();
                    BLL.BLLUsuario bLLUsuario = new BLL.BLLUsuario();

                    objUsuario.Login = txtLogin.Text;
                    objUsuario.Nome = txtNome.Text;
                    objUsuario.Apelido = txtApelido.Text;
                    objUsuario.Departamento = txtDepartamento.Text;
                    objUsuario.Cargo = txtCargo.Text;

                    PopulaGridUsuarios(objUsuario);
            }
        public void PopulaGridUsuarios(classUsuario objUsuario)
        {
            BLL.BLLUsuario bllUsuario = new BLL.BLLUsuario();

            if(objUsuario.Login == null)    
                objUsuario.Login = "";

            if (objUsuario.Nome == null)
                objUsuario.Nome = "";

            if (objUsuario.Apelido == null)
                objUsuario.Apelido = "";

            if (objUsuario.Cargo == null)
                objUsuario.Cargo = "";

            if (objUsuario.Departamento == null)
                objUsuario.Departamento = "";

            GrdVwUsuario.DataSource = bllUsuario.ConsultaUsuarios(objUsuario);
            GrdVwUsuario.DataBind();

        }

        protected void GrdVwUsuario_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GrdVwUsuario.PageIndex = e.NewPageIndex;


            PopulaGridUsuarios(new classUsuario());
        }

        protected void GrdVwUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 Indice = GrdVwUsuario.SelectedRow.RowIndex + (GrdVwUsuario.PageIndex * GrdVwUsuario.PageSize);

            BLL.BLLUsuario bllUsuario = new BLL.BLLUsuario();

            classUsuario objUsuario = new classUsuario();

            objUsuario.Login = "";
            objUsuario.Nome = "";
            objUsuario.Apelido = "";
            objUsuario.Cargo = "";
            objUsuario.Departamento = "";

            objUsuario = bllUsuario.ConsultaUsuarios(objUsuario)[Indice];

            txtLogin.Text = objUsuario.Login;
            txtNome.Text = objUsuario.Nome;
            lblIDusuario.Value = objUsuario.ID_Usuario.ToString();
            txtApelido.Text = objUsuario.Apelido;
            txtCargo.Text = objUsuario.Cargo;
            txtDepartamento.Text = objUsuario.Departamento;
            TxtBxDataCriacao.Text = objUsuario.Data_criacao.ToString();
            TxtBxDataAlteracao.Text = objUsuario.Data_alteracao.ToString();

        }
    }
}