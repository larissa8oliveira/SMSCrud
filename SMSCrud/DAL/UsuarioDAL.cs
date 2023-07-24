using System;
using System.Collections.Generic;
using System.Linq;

namespace SMSCrud.DAL
{
    public class UsuarioDAL
    {
        public Usuarios consultaPorCPF(string CPF)
        {
            using (usersEntities conexao = new usersEntities())
            {
                return conexao.Usuarios.Where(c => c.CPF == CPF).FirstOrDefault();
            }
        }

        public void cadastrarUsuario(Usuarios objU)
        {
            using (usersEntities conexao = new usersEntities())
            {
                conexao.Usuarios.Add(objU);
                conexao.SaveChanges();
            }
        }

        public void deletarUsuario(int idUsuario)
        {
            using (usersEntities conexao = new usersEntities())
            {
                Usuarios usuario = conexao.Usuarios.FirstOrDefault(c => c.Id == idUsuario);

                if (usuario != null)
                {
                    conexao.Usuarios.Remove(usuario);
                    conexao.SaveChanges();
                }
            }
        }

        public List<Usuarios> listarUsuarios()
        {
            using (usersEntities conexao = new usersEntities())
            {
                return conexao.Usuarios.ToList();
            }
        }
        public Usuarios consultaPorId(int idUsuario)
        {
            using (usersEntities conexao = new usersEntities())
            {
                return conexao.Usuarios.FirstOrDefault(c => c.Id == idUsuario);
            }
        }

        public void atualizarUsuario(Usuarios usuarioAtualizado)
        {
            using (usersEntities conexao = new usersEntities())
            {
                Usuarios usuario = conexao.Usuarios.FirstOrDefault(c => c.Id == usuarioAtualizado.Id);

                if (usuario != null)
                {
                    // Atualize os campos do usuário com os dados do usuário atualizado
                    usuario.Nome = usuarioAtualizado.Nome;
                    usuario.Email = usuarioAtualizado.Email;
                    usuario.Senha = usuarioAtualizado.Senha;
                    usuario.CPF = usuarioAtualizado.CPF;
                    usuario.DataNascimento = usuarioAtualizado.DataNascimento;
                    usuario.Telefones = usuarioAtualizado.Telefones;
                    usuario.Perfil = usuarioAtualizado.Perfil;
                    usuario.CEP = usuarioAtualizado.CEP;
                    usuario.Logradouro = usuarioAtualizado.Logradouro;
                    usuario.Complemento = usuarioAtualizado.Complemento;
                    usuario.Numero = usuarioAtualizado.Numero;
                    usuario.Cidade = usuarioAtualizado.Cidade;
                    usuario.Estado = usuarioAtualizado.Estado;
                    usuario.Pais = usuarioAtualizado.Pais;
                    usuario.DataHoraAtualizacao = DateTime.Now; // Atualize a data/hora de atualização

                    conexao.SaveChanges();
                }
            }
        }


    }
}
