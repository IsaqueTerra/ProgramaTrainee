<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormUsuario.aspx.cs" Inherits="ProgramaTrainee.WebFormUsuario" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" lang="pt-br" />

    <title></title>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"
        rel="stylesheet"
        integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"
        crossorigin="anonymous" />
    <style>
        div {
            display: inline-block;
        }
    </style>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <div class="container-fluid">
            <a class="navbar-brand" style="margin-left: 50px" href="FormProduto.aspx">Produtos</a>
            <a class="navbar-brand" href="FormUsuario.aspx" style="margin-right: 100%"><strong>Usuários</strong></a>
        </div>
    </nav>
    <p></p>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div style="margin-top: 60px;">
            <table style="margin-left: 150px">
                <tr>
                            <asp:HiddenField ID="lblIDusuario" runat="server" />
                       
                    <td class="input-group mb-3">
                        <span class="input-group-text" style="width: 105px" id="inputGroup-sizing-default">Nome:</span>
                        <asp:TextBox ID="txtNome" runat="server" TabIndex="1" Style="width: 300px" class="form-control"></asp:TextBox>
                    </td>
                    <td class="input-group mb-3">
                        <span class="input-group-text" style="width: 105px" id="inputGroup-sizing-default1">Login:</span>
                        <asp:TextBox ID="txtLogin" runat="server" TabIndex="1" Style="width: 300px" class="form-control"></asp:TextBox>
                    </td>
                    <td class="input-group mb-3">
                        <span class="input-group-text" style="width: 105px" id="inputGroup-sizing-default2">Senha:</span>
                        <asp:TextBox ID="txtSenha" runat="server" TabIndex="1" Style="width: 300px" class="form-control"></asp:TextBox>
                    </td>
                    <td class="input-group mb-3">
                        <span class="input-group-text" style="width: 105px" id="inputGroup-sizing-default3">Apelido:</span>
                        <asp:TextBox ID="txtApelido" runat="server" TabIndex="1" Style="width: 300px" class="form-control"></asp:TextBox>
                    </td>
                    <td class="input-group mb-3">
                        <span class="input-group-text" style="width: 105px" id="inputGroup-sizing-default4">Cargo:</span>
                        <asp:TextBox ID="txtCargo" runat="server" TabIndex="1" Style="width: 300px" class="form-control"></asp:TextBox>
                    </td>
                    <td class="input-group mb-3">
                        <span class="input-group-text" style="width: 135px" id="inputGroup-sizing-default5">Departamento:</span>
                        <asp:TextBox ID="txtDepartamento" runat="server" TabIndex="1" Style="width: 300px" class="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="input-group mb-3">
                        <span class="input-group-text" style="width: 105px" id="inputGroup-sizing-default6">Sexo:</span>
                        <asp:DropDownList ID="txtSexo" runat="server" class="btn btn-secondary dropdown-toggle">  
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem Value="M">Masculino</asp:ListItem>
                            <asp:ListItem Value="F">Feminino</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
            <div style="margin-left: 150px">
                <span class="input-group-text" style="width: 150px; display: inline-block" id="inputGroup-sizing-default9">Data de Criação:</span>
               
                             <asp:TextBox ID="TxtBxDataCriacao" class="form-control" runat="server" TabIndex="6"  style="width: 250px; display: inline-block">
                            </asp:TextBox>
                            <asp:ImageButton ID="ImgBttnDataCriacao" runat="server" style="position: relative; transform: translate(4px,3px)"
                                ImageUrl="~/img/icone_calendar.ico" TabIndex="7" Width="20px"   />
                            <cc1:MaskedEditExtender ID="MskdEdtExtndrDataCriacao" runat="server"
                                Mask="99/99/9999" MaskType="Date" PromptCharacter=" "
                                TargetControlID="TxtBxDataCriacao">
                            </cc1:MaskedEditExtender>
                            <cc1:CalendarExtender ID="ClndrExtndrDataCriacao" runat="server" Format="dd/MM/yyyy"
                                PopupButtonID="ImgBttnDataCriacao" TargetControlID="TxtBxDataCriacao">
                           </cc1:CalendarExtender>
            </div>
            <p></p>
            <div style="margin-left: 150px">
                <span class="input-group-text" style="width: 150px; display: inline-block" id="inputGroup-sizing-default10">Data de Alteração:</span>

                           <asp:TextBox ID="TxtBxDataAlteracao" class="form-control" runat="server" TabIndex="6"  style="width: 250px; display: inline-block">
                            </asp:TextBox>
                            <asp:ImageButton ID="ImgBttnDataAlteracao" runat="server" style="position: relative; transform: translate(4px,3px)"
                                 ImageUrl="~/img/icone_calendar.ico" TabIndex="7" Width="20px"  />
                            <cc1:MaskedEditExtender ID="MaskedEditExtender1" runat="server"
                                Mask="99/99/9999" MaskType="Date" PromptCharacter=" "
                                TargetControlID="TxtBxDataAlteracao">
                            </cc1:MaskedEditExtender>
                            <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Format="dd/MM/yyyy"
                                PopupButtonID="ImgBttnDataAlteracao" TargetControlID="TxtBxDataAlteracao">
                           </cc1:CalendarExtender>
            </div>
            <p></p>
            <div>
                <asp:Button ID="btnLimparUsuario" Text="Limpar Campos" runat="server" OnClick="btnLimpar_Click"
                    Width="120px" BorderStyle="None" Style="background-color: white; color: red; margin-left: 150px" />
            </div>

            <hr style="width: 400px; margin-left: 150px" />
            <table style="margin-left: 160px">
                <tr>
                    <td>
                        <asp:ImageButton ID="btnInserirUsuario" runat="server" ImageUrl="~/img/btn_inserir.ico"
                            OnClick="btnInserirUsuario_Click" />
                    </td>
                    <td>
                        <asp:ImageButton ID="btnAlterarUsuario" runat="server" ImageUrl="~/img/btn_alterar.ico"
                            OnClick="btnAlterarUsuario_Click" />
                    </td>
                    <td>
                        <asp:ImageButton ID="btnExcluirUsuario" runat="server" ImageUrl="~/img/btn_excluir.ico"
                            OnClick="btnExcluirUsuario_Click" />
                    </td>
                    <td>
                        <asp:ImageButton ID="btnBuscarUsuario" runat="server" ImageUrl="~/img/btn_buscar.ico"
                            OnClick="btnBuscarUsuario_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <div style="width: 270px"></div>
        <div>
            <asp:GridView ID="GrdVwUsuario"  style="margin-bottom: 120px" runat="server" CellPadding="7" ForeColor="Black"
                AutoGenerateColumns="False" AllowPaging="True" ViewStateMode="Enabled" Font-Size="Smaller"
                OnPageIndexChanging="GrdVwUsuario_PageIndexChanging"
                OnSelectedIndexChanged="GrdVwUsuario_SelectedIndexChanged" Width="800px"
                BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="0px" CellSpacing="5" Height="400px">
                <FooterStyle BackColor="#CCCCCC" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Center" Font-Bold="True" Font-Italic="True" Wrap="True" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="gray" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black" />
                <Columns>
                    <asp:CommandField ButtonType="Image" SelectImageUrl="~/img/SelGrid.jpeg"
                        ShowSelectButton="True">
                        <ItemStyle Width="1%" />
                    </asp:CommandField>
                    <asp:TemplateField HeaderText="Nome">
                        <ItemTemplate>
                            <%# DataBinder.Eval(Container.DataItem, "Nome")%>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemStyle HorizontalAlign="Left" Width="20%"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Apelido">
                        <ItemTemplate>
                            <%# DataBinder.Eval(Container.DataItem, "Apelido")%>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" Width="10%"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Cargo">
                        <ItemTemplate>
                            <%# DataBinder.Eval(Container.DataItem, "Cargo") %>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemStyle HorizontalAlign="Left" Width="10%" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Departamento">
                        <ItemTemplate>
                            <%# DataBinder.Eval(Container.DataItem, "Departamento") %>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemStyle HorizontalAlign="Left" Width="10%" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Data Cadastro">
                        <ItemTemplate>
                            <%# System.Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "Data_criacao"))%>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" Width="20%"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Data Alteração">
                        <ItemTemplate>
                            <%# System.Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "Data_alteracao"))%>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" Width="20%"></ItemStyle>
                    </asp:TemplateField>

                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>

</html>
