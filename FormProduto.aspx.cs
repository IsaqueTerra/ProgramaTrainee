using ProgramaTrainee.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgramaTrainee
{
    public partial class WebFormProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            classProduto objProduto = new classProduto();
            objProduto.Nome = "";
            objProduto.Cor = "";
            objProduto.ID_Produtos = 0;
            objProduto.Valor = 0;
            objProduto.Quantidade = 0;
            objProduto.Tecido = "";
            objProduto.Tamanho = "";
            objProduto.Data_Criacao = DateTime.MinValue;
            objProduto.Data_Alteracao = DateTime.MinValue;
            PopulaGridProduto(objProduto);
        }

        protected void btnInserirProduto_Click(object sender, ImageClickEventArgs e)
        {
            BLL.BLLProdutos bLLProdutos = new BLL.BLLProdutos();

            classProduto objProduto = new classProduto();
            objProduto.Nome = txtNome.Text;
            objProduto.Cor = txtCor.Text;
            objProduto.Valor = Convert.ToDouble(txtValor.Text);
            objProduto.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            objProduto.Tecido = txtTecido.Text;
            objProduto.Tamanho = txtTamanho.Text;
  





            if (bLLProdutos.InserirProduto(objProduto))
            {
                clsBase.Alert("Produto inserido com sucesso.", this);

            }
            else
            {
                clsBase.Alert("Erro ao inserir o Produto.", this);
            }
        }
        protected void btnAlterarUsuario_Click(object sender, ImageClickEventArgs e)
        {
            BLL.BLLProdutos bLLProdutos = new BLL.BLLProdutos();

            classProduto objProduto = new classProduto();

            objProduto.ID_Produtos = Convert.ToInt32(lblIDproduto.Value);
            objProduto.Nome = txtNome.Text;
            objProduto.Cor = txtCor.Text;
            objProduto.Valor = Convert.ToDouble(txtValor.Text);
            objProduto.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            objProduto.Tecido = txtTecido.Text;
            objProduto.Tamanho = txtTamanho.Text;



            if (txtNome.Text == "")
            {
                clsBase.Alert("Insira o nome do produto", this);
            }
            else
            if (bLLProdutos.AlterarProdutos(objProduto))
            {
                clsBase.Alert("Produto alterado com sucesso.", this);

                txtNome.Text = "";
                txtCor.Text = "";
                txtValor.Text = "";
                lblIDproduto.Value = "";
                txtQuantidade.Text = "";
                txtTecido.Text = "";
                txtTamanho.Text = "";
            }
            else
            {
                clsBase.Alert("Erro ao alterar o produto.", this);
            }

        }
        protected void btnExcluirUsuario_Click(object sender, ImageClickEventArgs e)
        {
            classProduto objProduto = new classProduto();

            objProduto.Nome = txtNome.Text;

            BLL.BLLProdutos bllProduto = new BLL.BLLProdutos();

            if (bllProduto.ExcluirProduto(objProduto))
            {
                clsBase.Alert("Usuário excluido com sucesso.", this);

                txtNome.Text = "";
                txtCor.Text = "";
                lblIDproduto.Value = "";
                txtQuantidade.Text = "";
                txtTamanho.Text = "";
                txtTecido.Text = "";
                txtValor.Text = "";
            }
            else
            {
                clsBase.Alert("Erro ao excluir usuário.", this);
            }
        }

        protected void btnBuscarProduto_Click(object sender, ImageClickEventArgs e)
        {

            classProduto objProduto = new classProduto();
            BLL.BLLProdutos bLLProduto = new BLL.BLLProdutos();

            objProduto.Nome = txtNome.Text;
            objProduto.Cor = txtCor.Text;
            objProduto.Valor = Convert.ToDouble(txtValor.Text);
            objProduto.Quantidade = Convert.ToInt32(txtQuantidade.Text.ToString());
            objProduto.Tecido = txtTecido.Text;
            objProduto.Tamanho = txtTamanho.Text;
            PopulaGridProduto(objProduto);
        }
        public void PopulaGridProduto(classProduto objProduto)
        {
            BLL.BLLProdutos bLLProdutos = new BLL.BLLProdutos();

            if (objProduto.Nome == null)
                objProduto.Nome = "";

            if (objProduto.Cor == null)
                objProduto.Cor = "";

            if (objProduto.Valor == double.MaxValue)
                objProduto.Valor = 0;

            if (objProduto.Quantidade == int.MinValue)
                objProduto.Quantidade = 0;

            if (objProduto.Tecido == null)
                objProduto.Tecido = "";

            if (objProduto.Tamanho == null)
                objProduto.Tamanho = "";


            GrdVwProduto.DataSource = bLLProdutos.ConsultaProduto(objProduto);
            GrdVwProduto.DataBind();




        }

        protected void GrdVwProduto_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GrdVwProduto.PageIndex = e.NewPageIndex;


            PopulaGridProduto(new classProduto());
        }

        protected void GrdVwProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 Indice = GrdVwProduto.SelectedRow.RowIndex + (GrdVwProduto.PageIndex * GrdVwProduto.PageSize);

            BLL.BLLProdutos bllProdutos = new BLL.BLLProdutos();

            classProduto objProduto = new classProduto();

            objProduto.ID_Produtos = 0;
            objProduto.Nome = "";
            objProduto.Cor = "";
            objProduto.Valor = 0;
            objProduto.Quantidade = 0;
            objProduto.Tecido = "";
            objProduto.Tamanho = "";
 

            objProduto = bllProdutos.ConsultaProduto(objProduto)[Indice];

            lblIDproduto.Value = objProduto.ID_Produtos.ToString();
            txtNome.Text = objProduto.Nome;
            txtCor.Text = objProduto.Cor;
            txtValor.Text = objProduto.Valor.ToString();
            txtQuantidade.Text = objProduto.Quantidade.ToString();
            txtTecido.Text = objProduto.Tecido;
            txtTamanho.Text = objProduto.Tamanho;
            TxtBxDataCriacao.Text = objProduto.Data_Criacao.ToString();
            TxtBxDataAlteracao.Text = objProduto.Data_Alteracao.ToString();


        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            lblIDproduto.Value = "";
            txtNome.Text = "";
            txtCor.Text = "";
            txtQuantidade.Text = "";
            txtTamanho.Text = "";
            txtTecido.Text = "";
            txtValor.Text = "";
            TxtBxDataCriacao.Text = "";
            TxtBxDataAlteracao.Text = "";

        }
    }
}