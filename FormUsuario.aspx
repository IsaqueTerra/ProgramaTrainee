<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormUsuario.aspx.cs" Inherits="ProgramaTrainee.WebForm2" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="style.css" />
    <style type="text/css"></style>
</head>
<body>
    <form id="form1" runat="server" class="Usuario">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <fieldset style="margin-top: 5px; margin-left: 5%; margin-right: 5%; vertical-align: central">
                <legend style="font-weight: bold; color: #072452;">Cadastro do Usuário </legend>
                <table>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label1" runat="server" Text="Nome:" Font-Bold="True">
                            </asp:Label>
                            <asp:HiddenField ID="lblIDusuario" runat="server"/>
                        </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtNome" runat="server" TabIndex="1"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Login:" Font-Bold="True"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtLogin" runat="server" TabIndex="2"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Senha:" Font-Bold="True"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtSenha" runat="server" TabIndex="4"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Apelido:" Font-Bold="True"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtApelido" runat="server" TabIndex="3"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Cargo:" Font-Bold="True"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCargo" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text="Departamento:" Font-Bold="True">
                            </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtDepartamento" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label9" runat="server" Text="Sexo:" Font-Bold="True"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="drpSexo" runat="server">
                                <asp:ListItem Value="M">Masculino</asp:ListItem>
                                <asp:ListItem Value="F">Feminino</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="Label7" runat="server" Text="Data de Criação:" Font-Bold="True">
                            </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TxtBxDataCriacao" runat="server" Width="80px" TabIndex="6">
                            </asp:TextBox>
                            <asp:ImageButton ID="ImgBttnDataCriacao" runat="server"
                                ImageUrl="~/img/calendario.gif" TabIndex="7" />
                            <cc1:MaskedEditExtender ID="MskdEdtExtndrDataCriacao" runat="server"
                                Mask="99/99/9999" MaskType="Date" PromptCharacter=" "
                                TargetControlID="TxtBxDataCriacao">
                            </cc1:MaskedEditExtender>
                            <cc1:CalendarExtender ID="ClndrExtndrDataCriacao" runat="server" Format="dd/MM/yyyy"
                                PopupButtonID="ImgBttnDataCriacao" TargetControlID="TxtBxDataCriacao">
                            </cc1:CalendarExtender>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label8" runat="server" Text="Data de Alteração:" Font-Bold="True">
                            </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TxtBxDataAlteracao" runat="server" Width="80px" TabIndex="6">
                            </asp:TextBox>
                            <asp:ImageButton ID="ImgBttnDataAlteracao" runat="server"
                                ImageUrl="~/img/calendario.gif" TabIndex="7" />
                            <cc1:MaskedEditExtender ID="MaskedEditExtender1" runat="server" Mask="99/99/9999"
                                MaskType="Date" PromptCharacter=" " TargetControlID="TxtBxDataAlteracao">
                            </cc1:MaskedEditExtender>
                            <cc1:CalendarExtender ID="ClndrExtndrDataAlteracao" runat="server"
                                Format="dd/MM/yyyy" PopupButtonID="ImgBttnDataAlteracao"
                                TargetControlID="TxtBxDataAlteracao">
                            </cc1:CalendarExtender>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p></p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:ImageButton ID="btnInserirUsuario" runat="server"
                                ImageUrl="~/img/btn_inserir.ico" OnClick="btnInserirUsuario_Click"
                                 />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:ImageButton ID="btnAlterarUsuario" runat="server"
                                ImageUrl="~/img/btn_alterar.ico" OnClick="btnAlterarUsuario_Click"
                                 />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:ImageButton ID="btnExcluirUsuario" runat="server"
                                ImageUrl="~/img/btn_excluir.ico" OnClick="btnExcluirUsuario_Click"
                                 />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:ImageButton ID="btnBuscarUsuario" runat="server"
                                ImageUrl="~/img/btn_buscar.ico" OnClick="btnBuscarUsuario_Click"
                                 />
                        </td>
                    </tr>
                </table>
            </fieldset>
        </div>
<%--       <asp:GridView ID="GrdVwUsuario" runat="server" CellPadding="2" ForeColor="#333333" 
                                    GridLines="None" AutoGenerateColumns="False" AllowPaging="True" ViewStateMode="Enabled"
                                    PageSize="10" 
                                    Font-Size="Smaller" 
                                    OnPageIndexChanging="GrdVwUsuario_PageIndexChanging" 
                                    OnSelectedIndexChanged="GrdVwUsuario_SelectedIndexChanged">
                                    <RowStyle BackColor="#CCCCFF" />
                                    <FooterStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black" />
                                    <PagerStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#FFFFCC" Font-Bold="True" ForeColor="Black" />
                                    <HeaderStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black" />
                                    <EditRowStyle BackColor="#CCCCCC" />
                                    <AlternatingRowStyle BackColor="White" />--%>


<asp:GridView ID="GrdVwUsuario" runat="server" CellPadding="2" ForeColor="#333333" 
                                    GridLines="None" AutoGenerateColumns="False" AllowPaging="True" ViewStateMode="Enabled"
                                    PageSize="10" 
                                    Font-Size="Smaller" 
                                    OnPageIndexChanging="GrdVwUsuario_PageIndexChanging" 
                                    OnSelectedIndexChanged="GrdVwUsuario_SelectedIndexChanged">
                                    <RowStyle BackColor="#CCCCFF" />
                                    <FooterStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black" />
                                    <PagerStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#FFFFCC" Font-Bold="True" ForeColor="Black" />
                                    <HeaderStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="Black" />
                                    <EditRowStyle BackColor="#CCCCCC" />
                                    <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:CommandField buttontype="Image" selectimageurl="~/img/SelGrid.jpeg" 
                                        showselectbutton="True">
                                        <ItemStyle width="1%" />
                                    </asp:CommandField>
          
                                    <asp:TemplateField headertext="Nome">
                                        <ItemTemplate>
                                            <%# DataBinder.Eval(Container.DataItem, "Nome")%>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Left" />
                                        <ItemStyle horizontalalign="Left" width="20%" ></ItemStyle>
                                    </asp:TemplateField>    
                                   
                                    <asp:TemplateField headertext="Apelido">
                                        <ItemTemplate>
                                            <%# DataBinder.Eval(Container.DataItem, "Apelido")%>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <ItemStyle horizontalalign="Center" width="10%" ></ItemStyle>
                                    </asp:TemplateField>
                                    <asp:TemplateField headertext="Cargo">
                                        <ItemTemplate>
                                            <%# DataBinder.Eval(Container.DataItem, "Cargo") %>
                                        </ItemTemplate>
                                        <HeaderStyle horizontalalign="Left" />
                                        <ItemStyle HorizontalAlign="Left" width="10%" />
                                    </asp:TemplateField>
                                    <asp:TemplateField headertext="Departamento">
                                        <ItemTemplate>
                                            <%# DataBinder.Eval(Container.DataItem, "Departamento") %>
                                        </ItemTemplate>
                                        <HeaderStyle horizontalalign="Left" />
                                        <ItemStyle HorizontalAlign="Left" width="10%" />
                                    </asp:TemplateField>
                                    <asp:TemplateField headertext="Data Cadastro">
                                        <ItemTemplate>
                                            <%# System.Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "Data_criacao"))%> 
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <ItemStyle horizontalalign="Center" width="10%" ></ItemStyle>
                                    </asp:TemplateField> 
                                    <asp:TemplateField headertext="Data Alteração">
                                        <ItemTemplate>
                                            <%# System.Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "Data_alteracao"))%> 
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <ItemStyle horizontalalign="Center" width="10%" ></ItemStyle>
                                    </asp:TemplateField> 

                                </Columns>
                            </asp:GridView>

    </form>
</body>

</html>
