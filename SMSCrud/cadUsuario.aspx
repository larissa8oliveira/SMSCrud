<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadUsuario.aspx.cs" Inherits="SMSCrud.cadUsuario" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <link rel="stylesheet" href="Style/style.css" />
<title>Cadastro de Usuário</title>
</head>
<body>
    <form id="formCadastro" runat="server">
     <div class="card">
        <div>
            <h2>Cadastro de Usuário</h2>
         <div>
           <div>
             <div >
                <label>Nome:</label>
                <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"  />
            </div>
            <div >
                <label>Email:</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" />
            </div>
            <div>
                <label>Senha:</label>
                <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" CssClass="form-control"  />
            </div>
            <div >
                <label>CPF:</label>
                <asp:TextBox ID="txtCPF" runat="server" CssClass="form-control"  />
            </div>
            <div>
                <label>Data de Nascimento:</label>
                <asp:TextBox ID="txtDataNascimento" runat="server" CssClass="form-control"  />
            </div>
             <div>
                <label>Data de Criação:</label>
                <asp:TextBox ID="txtDataCriacao" runat="server" CssClass="form-control" Enabled="false" Text="" />
           </div>
            <div>
                <label>Data de Atualização:</label>
                <asp:TextBox ID="txtDataAtualizacao" runat="server" CssClass="form-control" Enabled="false" Text="" />
            </div>
            <div>
                <label>Telefones:</label>
                <asp:TextBox ID="txtTelefones" runat="server" CssClass="form-control" />
            </div>

            <div>
                <label>Perfil:</label>
                <asp:DropDownList ID="ddlPerfil" runat="server" CssClass="form-control" >
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
                <asp:TextBox ID="txtLogradouro" runat="server" CssClass="form-control"/>
            </div>
             <div >
                <label>Complemento:</label>
                <asp:TextBox ID="txtComplemento" runat="server" CssClass="form-control"/>
            </div>
             <div >
                <label>Número:</label>
                <asp:TextBox ID="txtNumero" runat="server" CssClass="form-control" />
            </div>
            <div>
                <label>Cidade:</label>
                <asp:TextBox ID="txtCidade" runat="server" CssClass="form-control" />
            </div>
            <div >
                <label>Estado:</label>
                <asp:TextBox ID="txtEstado" runat="server" CssClass="form-control" />
            </div>
            <div >
                <label>País:</label>
                <asp:TextBox ID="txtPais" runat="server" CssClass="form-control" />
            </div>
        
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click"  CssClass="btnCadastrar" />
        </div>
      </div>
     </div>
    </div>
        <div class="table">

           <asp:GridView ID="gridUsuarios" runat="server" AutoGenerateColumns="False" OnRowCommand="gridUsuarios_RowCommand" CssClass="table table-striped">
        <Columns>
                <asp:BoundField DataField="Nome" HeaderText="Nome" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="CPF" HeaderText="CPF" />
                <asp:BoundField DataField="DataNascimento" HeaderText="Data de Nascimento" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="Telefones" HeaderText="Telefones" />
                <asp:BoundField DataField="Perfil" HeaderText="Perfil" />
                <asp:BoundField DataField="CEP" HeaderText="CEP" />
                <asp:BoundField DataField="Logradouro" HeaderText="Logradouro" />
                <asp:BoundField DataField="Complemento" HeaderText="Complemento" />
                <asp:BoundField DataField="Numero" HeaderText="Número" />
                <asp:BoundField DataField="Cidade" HeaderText="Cidade" />
                <asp:BoundField DataField="Estado" HeaderText="Estado" />
                <asp:BoundField DataField="Pais" HeaderText="País" />
                <asp:BoundField DataField="DataHoraCriacao" HeaderText="Data de Criação" DataFormatString="{0:dd/MM/yyyy HH:mm:ss}" />
                <asp:BoundField DataField="DataHoraAtualizacao" HeaderText="Data de Atualização" DataFormatString="{0:dd/MM/yyyy HH:mm:ss}" />
                <asp:TemplateField HeaderText="Ações">
                    <ItemTemplate>
                        <div class="d-inline-block">
                            <asp:Button ID="btnEditar" runat="server" CommandName="Editar" CommandArgument='<%# Eval("Id") %>' Text="Editar" CssClass="btn btn-edit" />
                        </div>
                        <div class="d-inline-block">
                            <asp:Button ID="btnDeletar" runat="server" CommandName="Deletar" CommandArgument='<%# Eval("Id") %>' Text="Deletar" CssClass="btn btn-delete" OnClientClick="return confirm('Deseja realmente deletar este usuário?');" />
                        </div>
                    </ItemTemplate>
               </asp:TemplateField>
            </Columns>
         </asp:GridView>
    </div>

    </form>
</body>
</html>
