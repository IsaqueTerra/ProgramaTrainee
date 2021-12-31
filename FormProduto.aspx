<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormProduto.aspx.cs" Inherits="ProgramaTrainee.WebFormProduto" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
            <a class="navbar-brand" style="margin-left: 50px;" href="FormProduto.aspx"><strong>Produtos</strong></a>
            <a class="navbar-brand" href="FormUsuario.aspx" style="margin-right: 100%">Usuários</a>
        </div>
    </nav>
    <p></p>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div style="margin-top: 60px;">
            <table style="margin-left: 150px">
                <tr>

                    <asp:HiddenField ID="lblIDproduto" runat="server" />


                    <td class="input-group mb-3">
                        <span class="input-group-text" style="width: 105px" id="inputGroup-sizing-default">Produto:</span>
                        <asp:TextBox ID="txtNome" runat="server" TabIndex="1" Style="width: 300px" class="form-control"></asp:TextBox>
                    </td>

                    <td class="input-group mb-3">
                        <span class="input-group-text" style="width: 105px" id="inputGroup-sizing-default2">Cor:</span>
                        <asp:TextBox ID="txtCor" runat="server" TabIndex="1" Style="width: 300px" class="form-control"></asp:TextBox>
                    </td>

                    <td class="input-group mb-3">
                        <span class="input-group-text" style="width: 105px" id="inputGroup-sizing-default3">Valor:</span>
                        <asp:TextBox ID="txtValor" runat="server" TabIndex="1" Style="width: 300px" class="form-control"></asp:TextBox>
                    </td>

                    <td class="input-group mb-3">
                        <span class="input-group-text" style="width: 105px" id="inputGroup-sizing-default4">Quantidade:</span>
                        <asp:TextBox ID="txtQuantidade" runat="server" TabIndex="1" Style="width: 300px" class="form-control"></asp:TextBox>
                    </td>

                    <td class="input-group mb-3">
                        <span class="input-group-text" style="width: 105px" id="inputGroup-sizing-default5">Tecido:</span>
                        <asp:TextBox ID="txtTecido" runat="server" TabIndex="1" Style="width: 300px" class="form-control"></asp:TextBox>
                    </td>
                    <td class="input-group mb-3">
                        <span class="input-group-text" style="width: 105px" id="inputGroup-sizing-default6">Tamanho:</span>
                        <asp:TextBox ID="txtTamanho" runat="server" TabIndex="1" Style="width: 300px" class="form-control"></asp:TextBox>
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
            <asp:Button ID="btnLimpar" Text="Limpar Campos" runat="server" OnClick="btnLimpar_Click"
                Width="120px" BorderStyle="None" Style="background-color: white; color: red; margin-left: 150px" />
            <hr style="width: 400px; margin-left: 150px" />
            <table style="margin-left: 160px">
                <tr>
                    <td>
                        <asp:ImageButton ID="btnInserirProduto" runat="server" ImageUrl="~/img/btn_inserir.ico"
                            OnClick="btnInserirProduto_Click" />
                    </td>
                    <td>
                        <asp:ImageButton ID="btnAlterarProduto" runat="server" ImageUrl="~/img/btn_alterar.ico"
                            OnClick="btnAlterarUsuario_Click" />
                    </td>
                    <td>
                        <asp:ImageButton ID="btnExcluirProduto" runat="server" ImageUrl="~/img/btn_excluir.ico"
                            OnClick="btnExcluirUsuario_Click" />
                    </td>
                    <td>
                        <asp:ImageButton ID="btnBuscarProduto" runat="server" ImageUrl="~/img/btn_buscar.ico"
                            OnClick="btnBuscarProduto_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <div style="width: 300px"></div>
        <div>
            <asp:GridView ID="GrdVwProduto" style="margin-bottom: -25px" runat="server" CellPadding="7" ForeColor="Black"
                AutoGenerateColumns="False" AllowPaging="True" ViewStateMode="Enabled" Font-Size="Smaller"
                OnPageIndexChanging="GrdVwProduto_PageIndexChanging"
                OnSelectedIndexChanged="GrdVwProduto_SelectedIndexChanged" Width="800px"
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
                            <%# DataBinder.Eval(Container.DataItem, "Nome" )%>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemStyle HorizontalAlign="Left" Width="10%"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Cor">
                        <ItemTemplate>
                            <%# DataBinder.Eval(Container.DataItem, "Cor" )%>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemStyle HorizontalAlign="Left" Width="10%"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Valor">
                        <ItemTemplate>
                            <%# DataBinder.Eval(Container.DataItem, "Valor" )%>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemStyle HorizontalAlign="Left" Width="10%"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Quantidade">
                        <ItemTemplate>
                            <%# DataBinder.Eval(Container.DataItem, "Quantidade" )%>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemStyle HorizontalAlign="Left" Width="10%"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tecido">
                        <ItemTemplate>
                            <%# DataBinder.Eval(Container.DataItem, "Tecido" )%>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemStyle HorizontalAlign="Left" Width="10%"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tamanho">
                        <ItemTemplate>
                            <%# DataBinder.Eval(Container.DataItem, "Tamanho" )%>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemStyle HorizontalAlign="Left" Width="10%"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Data Criação">
                        <ItemTemplate>
                            <%# DataBinder.Eval(Container.DataItem, "Data_criacao" )%>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemStyle HorizontalAlign="Left" Width="20%"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Data Alteração">
                        <ItemTemplate>
                            <%# DataBinder.Eval(Container.DataItem, "Data_alteracao" )%>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemStyle HorizontalAlign="Left" Width="20%"></ItemStyle>
                    </asp:TemplateField>

                </Columns>
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
        </div>
    </form>

</body>

</html>
