<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProgramaTrainee.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="text-align:center">
    <div>
         <fieldset style="MARGIN-TOP: 10%; MARGIN-LEFT: 30%; MARGIN-RIGHT: 30%">
         <legend style="font-weight: bold; "> Programa Trainee </legend>
           <table cellspacing="1" cellpadding="1" width="100%" align="center" >
             <tr>
                   <td width="30%" style="text-align:right">
                       <asp:Label ID="LblLogin" runat="server" Text="Login:" ></asp:Label>
                   </td>
                   <td  width="80%" style="text-align:left">
                       <asp:TextBox ID="TxtBxLogin" runat="server" Width="120px" MaxLength="15" TabIndex="1" ></asp:TextBox>
                   </td>
             </tr>
             <tr>
                   <td  width="30%" style="text-align:right">
                       <asp:Label ID="LblSenha" runat="server" Text="Senha:" ></asp:Label>
                   </td>
                   <td  width="80%"style="text-align:left">
                       <asp:TextBox ID="TxtBxSenha" runat="server" Width="120px" MaxLength="15" TabIndex="2" TextMode="Password"></asp:TextBox>
                   </td>
             </tr>
             <tr>
                    <td  width="80%" colspan="2">
                       <asp:Button ID="btnLogar" runat="server" Text="Logar" Font-Size="Large" OnClick="btnLogar_Click" />
                   </td>  
             </tr>                          

           </table>
         </fieldset>      
    </div>



    </form>
</body>
</html>
