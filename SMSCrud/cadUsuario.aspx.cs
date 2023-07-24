using SMSCrud.DAL;
using SMSCrud.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMSCrud
{
    public partial class cadUsuario : System.Web.UI.Page
    {
        private UsuarioDAL uDal = new UsuarioDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
     
                CarregarDadosGridView();
                txtDataCriacao.Text = DateTime.Now.ToString("dd/MM/yyyy");
                txtDataAtualizacao.Text= DateTime.Now.ToString("dd/MM/yyyy");

            }
        }
       
        protected void btnConsultaCEP_Click(object sender, EventArgs e)
        {
            UsuarioUtils.ConsultarCEP(txtCEP, txtLogradouro, txtCidade, txtEstado, txtPais);
        }
        public void ExibirMensagem(string msg)
        {
            Response.Write("<script>alert('" + msg + "')</script>");
        }
        public void LimparCampos()
        {
            txtNome.Text = "";
            txtSenha.Text = "";
            txtEmail.Text = "";
            txtCPF.Text = "";
            txtDataNascimento.Text = "";
            txtTelefones.Text = "";
            txtCEP.Text = "";
            txtLogradouro.Text = "";
            txtComplemento.Text = "";
            txtNumero.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtPais.Text = "";
        }
        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validações de campos obrigatórios
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    ExibirMensagem("O campo Nome é obrigatório!");
                    return;
                }

                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    ExibirMensagem("O campo Email é obrigatório!");
                    return;
                }

                if (string.IsNullOrEmpty(txtCPF.Text))
                {
                    ExibirMensagem("O campo CPF é obrigatório!");
                    return;
                }

                if (string.IsNullOrEmpty(txtDataNascimento.Text))
                {
                    ExibirMensagem("O campo Data de Nascimento é obrigatório!");
                    return;
                }

                // Validação de formato do e-mail
                if (!UsuarioUtils.IsValidEmail(txtEmail.Text))
                {
                    ExibirMensagem("O email informado é inválido!");
                    return;
                }

                // Validação de formato do CPF
                if (!UsuarioUtils.IsValidCPF(txtCPF.Text))
                {
                    ExibirMensagem("O CPF informado é inválido!");
                    return;
                }

                // Validação do formato do CEP
                if (!string.IsNullOrEmpty(txtCEP.Text) && !UsuarioUtils.IsValidCEP(txtCEP.Text))
                {
                    ExibirMensagem("O CEP informado é inválido!");
                    return;
                }

                // Validação da data de nascimento
                if (!DateTime.TryParseExact(txtDataNascimento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataNascimento))
                {
                    ExibirMensagem("A data de nascimento informada é inválida! Use o formato dd/MM/yyyy.");
                    return;
                }

                Usuarios objusuario = new Usuarios();

                // Atribuição de valores após as validações
                objusuario.Nome = txtNome.Text;
                objusuario.Senha = txtSenha.Text;
                objusuario.Email = txtEmail.Text;
                objusuario.CPF = txtCPF.Text;
                objusuario.DataNascimento = DateTime.Parse(txtDataNascimento.Text);
                objusuario.Telefones = txtTelefones.Text;
                objusuario.Perfil = ddlPerfil.SelectedValue;
                objusuario.CEP = txtCEP.Text;
                objusuario.Logradouro = txtLogradouro.Text;
                objusuario.Complemento = txtComplemento.Text;
                objusuario.Numero = txtNumero.Text;
                objusuario.Cidade = txtCidade.Text;
                objusuario.Estado = txtEstado.Text;
                objusuario.Pais = txtPais.Text;
                objusuario.DataHoraCriacao = DateTime.Now;
                objusuario.DataHoraAtualizacao = DateTime.Now;

                Usuarios objValidador = new Usuarios();
                UsuarioDAL uDal = new UsuarioDAL();

                objValidador = uDal.consultaPorCPF(txtCPF.Text);

                if (objValidador != null)
                {
                    ExibirMensagem("Usuário já existe no banco de dados!");
                }
                else
                {
                    uDal.cadastrarUsuario(objusuario);

                    ExibirMensagem("Usuário cadastrado com sucesso!");
                    LimparCampos();
                    CarregarDadosGridView();
                }
            }
            catch (Exception)
            {
                ExibirMensagem("Erro ao salvar cadastro! Entre em contato com o administrador do sistema.");
            }
        }
       
        private void CarregarDadosGridView()
        {
            gridUsuarios.DataSource = uDal.listarUsuarios();
            gridUsuarios.DataBind();
        }
        protected void gridUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Deletar")
            {
                // Obtendo o ID do usuário a ser deletado
                int idUsuario = Convert.ToInt32(e.CommandArgument);

                // Função para deletar o usuário do banco de dados
                uDal.deletarUsuario(idUsuario);

                // Atualize a GridView após a exclusão
                CarregarDadosGridView();
            }
            else if (e.CommandName == "Editar")
            {
               
                int idUsuario = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("editarUsuario.aspx?id=" + idUsuario);
            }
        }


    }
}