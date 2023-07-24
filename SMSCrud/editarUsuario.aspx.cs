using System;
using SMSCrud.DAL;
using SMSCrud.Utils;

namespace SMSCrud
{
    public partial class editarUsuario : System.Web.UI.Page
    {
        // Criando  uma instância de UsuarioDAL
        private UsuarioDAL uDal = new UsuarioDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Verificando se o ID do usuário foi passado na QueryString
                if (Request.QueryString["id"] != null)
                {
                    int idUsuario = Convert.ToInt32(Request.QueryString["id"]);

                    // Carregando os dados do usuário para edição
                    CarregarUsuarioParaEdicao(idUsuario);
                }
                else
                {
                    // Se não houver ID na QueryString, redirecione de volta para a página de cadastro
                    Response.Redirect("cadUsuario.aspx");
                }
            }
        }
        protected void btnConsultaCEP_Click(object sender, EventArgs e)
        {
            UsuarioUtils.ConsultarCEP(txtCEP, txtLogradouro, txtCidade, txtEstado, txtPais);
        }

        private void CarregarUsuarioParaEdicao(int idUsuario)
        {
            Usuarios usuario = uDal.consultaPorId(idUsuario);

            if (usuario != null)
            {
                // Preencha os campos do formulário com os dados do usuário a ser editado
                txtNome.Text = usuario.Nome;
                txtEmail.Text = usuario.Email;
                txtSenha.Text = usuario.Senha; // Lembre-se de que a senha não está criptografada neste exemplo, é apenas para fins ilustrativos.
                txtCPF.Text = usuario.CPF;
                txtDataNascimento.Text = usuario.DataNascimento.ToString("yyyy-MM-dd");
                txtDataCriacao.Text = usuario.DataHoraCriacao.ToString("yyyy-MM-dd HH:mm:ss");
                txtDataAtualizacao.Text = usuario.DataHoraAtualizacao.ToString("yyyy-MM-dd HH:mm:ss");
                txtTelefones.Text = usuario.Telefones;
                ddlPerfil.SelectedValue = usuario.Perfil;
                txtCEP.Text = usuario.CEP;
                txtLogradouro.Text = usuario.Logradouro;
                txtComplemento.Text = usuario.Complemento;
                txtNumero.Text = usuario.Numero;
                txtCidade.Text = usuario.Cidade;
                txtEstado.Text = usuario.Estado;
                txtPais.Text = usuario.Pais;
            }
            else
            {
                // Se o usuário não for encontrado, redirecione de volta para a página de cadastro
                Response.Redirect("cadUsuario.aspx");
            }
        }
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            // Obtendo o ID do usuário da QueryString
            if (Request.QueryString["id"] != null)
            {
                int idUsuario = Convert.ToInt32(Request.QueryString["id"]);

                // Carregue o usuário para edição
                Usuarios usuario = uDal.consultaPorId(idUsuario);

                if (usuario != null)
                {
                    // Atualiza os dados do usuário com base nos campos do formulário
                    usuario.Nome = txtNome.Text;
                    usuario.Email = txtEmail.Text;
                    usuario.Senha = txtSenha.Text; // Lembre-se de que a senha não está criptografada neste exemplo, é apenas para fins ilustrativos. 
                    usuario.DataNascimento = DateTime.Parse(txtDataNascimento.Text);
                    usuario.Telefones = txtTelefones.Text;
                    usuario.Perfil = ddlPerfil.SelectedValue;
                    usuario.CEP = txtCEP.Text;
                    usuario.Logradouro = txtLogradouro.Text;
                    usuario.Complemento = txtComplemento.Text;
                    usuario.Numero = txtNumero.Text;
                    usuario.Cidade = txtCidade.Text;
                    usuario.Estado = txtEstado.Text;
                    usuario.Pais = txtPais.Text;
                    usuario.DataHoraAtualizacao = DateTime.Now; // Atualiza a data/hora de atualização

                    // Chama a função para atualizar o usuário no banco de dados
                    uDal.atualizarUsuario(usuario);

                    // Redirecione o usuário de volta para a página de cadastro após a edição
                    Response.Redirect("cadUsuario.aspx");
                }
                else
                {
                    // Se o usuário não for encontrado, redirecione de volta para a página de cadastro
                    Response.Redirect("cadUsuario.aspx");
                }
            }
            else
            {
                // Se não houver ID na QueryString, redirecione de volta para a página de cadastro
                Response.Redirect("cadUsuario.aspx");
            }
        }
    }
}
