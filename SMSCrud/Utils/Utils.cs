using SMSCrud.wsCorreios;
using System;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMSCrud.Utils
{
    public static class UsuarioUtils
    {
        public static void ConsultarCEP(TextBox txtCEP, TextBox txtLogradouro, TextBox txtCidade, TextBox txtEstado, TextBox txtPais)
        {
            try
            {
                using (var ws = new AtendeClienteService())
                {
                    var resultado = ws.consultaCEP(txtCEP.Text);

                    txtLogradouro.Text = resultado.end;
                    txtCidade.Text = resultado.cidade;
                    txtEstado.Text = resultado.uf;
                    txtPais.Text = "Brasil";
                }
            }
            catch (Exception ex)
            {
                ExibirMensagem(ex.Message);
            }
        }

        public static void ExibirMensagem(string msg)
        {
            Page currentPage = HttpContext.Current.Handler as Page;
            currentPage?.ClientScript.RegisterStartupScript(currentPage.GetType(), "exibirMensagem", $"<script>alert('{msg}')</script>");
        }

        public static bool IsValidEmail(string email)
        {
            // Expressão regular para validar o formato do e-mail
            const string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        public static bool IsValidCPF(string cpf)
        {
            // Remove caracteres não numéricos do valor do CPF
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Verifica se o CPF tem exatamente 11 dígitos
            return cpf.Length == 11;
        }

        public static bool IsValidCEP(string cep)
        {
            // Expressão regular para validar o formato do CEP (apenas 8 dígitos numéricos)
            const string cepPattern = @"^\d{8}$";
            return Regex.IsMatch(cep, cepPattern);
        }
    }
}
