<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editarUsuario.aspx.cs" Inherits="SMSCrud.editarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="Style/style.css" />
    <title>Editar Usuário</title>
</head>
<body>
    <form id="formEditar" runat="server">
      <div class="card">
        <div>
            <h2>Editar Usuário</h2>
            <div>
                <label>Nome:</label>
                <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" />
            </div>
            <div>
                <label>Email:</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"/>
            </div>
            <div>
                <label>Senha:</label>
                <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" CssClass="form-control" />
            </div>
            <div>
                <label>CPF:</label>
                <asp:TextBox ID="txtCPF" runat="server" CssClass="form-control" />
            </div>
            <div>
                <label>Data de Nascimento:</label>
                <asp:TextBox ID="txtDataNascimento" runat="server" CssClass="form-control"/>
            </div>
            <div>
                <label>Data de Criação:</label>
                <asp:TextBox ID="txtDataCriacao" runat="server" Enabled="false" CssClass="form-control" />
           </div>
           <div>
                <label>Data de Atualização:</label>
                <asp:TextBox ID="txtDataAtualizacao" runat="server" Enabled="false" CssClass="form-control" />
            </div>
            <div>
                <label>Telefones:</label>
                <asp:TextBox ID="txtTelefones" runat="server" CssClass="form-control" />
            </div>
            <div>
                <label>Perfil:</label>
                <asp:DropDownList ID="ddlPerfil" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Admin" Value="Admin" CssClass="form-control" />
                    <asp:ListItem Text="Supervisor" Value="Supervisor" CssClass="form-control" />
                    <asp:ListItem Text="Operador" Value="Operador" CssClass="form-control" />
                </asp:DropDownList>
            </div>
            <div>
                <label>CEP:</label>
                <asp:TextBox ID="txtCEP" runat="server" onkeypress="return onlyNumbers(event)" CssClass="txtCEP" />
                <asp:Button ID="btnConsultaCEP" runat="server" Text="Consultar CEP" OnClick="btnConsultaCEP_Click" CssClass="btnConsultaCEP" />
            </div>
            <div>
                <label>Logradouro:</label>
                <asp:TextBox ID="txtLogradouro" runat="server" CssClass="form-control" />
            </div>
            <div>
                <label>Complemento:</label>
                <asp:TextBox ID="txtComplemento" runat="server" CssClass="form-control" />
            </div>
            <div>
                <label>Número:</label>
                <asp:TextBox ID="txtNumero" runat="server" CssClass="form-control" />
            </div>
            <div>
                <label>Cidade:</label>
                <asp:TextBox ID="txtCidade" runat="server" CssClass="form-control"/>
            </div>
            <div>
                <label>Estado:</label>
                <asp:TextBox ID="txtEstado" runat="server" CssClass="form-control" />
            </div>
            <div>
                <label>País:</label>
                <asp:TextBox ID="txtPais" runat="server" CssClass="form-control" />
            </div>

            <asp:Button ID="btnEditar" runat="server" Text="Salvar Edição" OnClick="btnEditar_Click" CssClass="btnCadastrar" />
        </div>
    </div>
    </form>
</body>
</html>
