using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Metadata;
using DAL;

namespace BLL
{
    public class UsuarioBLL
    {
        List<string> erros = new List<string>();

        public bool Validar(Usuario usuario)
        {
            #region Nome
            if (string.IsNullOrWhiteSpace(usuario.nome))
            {
                erros.Add("Nome deve ser informado.");
            }
            else
            {
                usuario.nome = usuario.nome.Trim();
                if (usuario.nome.Length < 3 || usuario.nome.Length > 60)
                {
                    erros.Add("nome deve conter entre 3 e 60 caracteres.");
                }
                else
                {
                    for (int i = 0; i < usuario.nome.Length; i++)
                    {
                        if (!char.IsLetter(usuario.nome[i]) && usuario.nome[i] != ' ')
                        {
                            erros.Add("Nome inválido");
                            break;
                        }
                    }
                }
            }
            #endregion

            #region cpf
            if (string.IsNullOrWhiteSpace(usuario.cpf))
            {
                erros.Add("cpf deve ser informado.");
            }
            else
            {

                usuario.cpf = usuario.cpf.Trim();
                usuario.cpf = usuario.cpf.Replace(".", "").Replace("-", "");
                if (!Validarcpf(usuario.cpf))
                {
                    erros.Add("cpf inválido");
                }
            }
            #endregion

            #region RG
            if (string.IsNullOrWhiteSpace(usuario.rg))
            {
                erros.Add("rg deve ser informado.");
            }
            else
            {
                usuario.rg = usuario.rg.Trim();
                usuario.rg = usuario.rg.Replace(".", "").Replace("/", "").Replace("-", "");
                if (usuario.rg.Length < 5 || usuario.rg.Length > 9)
                {
                    erros.Add("rg deve conter entre 5 e 9 caracteres.");
                }
            }
            #endregion



            #region telefone
            if (string.IsNullOrWhiteSpace(usuario.telefone))
            {
                erros.Add("telefone deve ser informado.");
            }
            else
            {
                usuario.telefone =
                    usuario.telefone.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (usuario.telefone.Length < 8 || usuario.telefone.Length > 15)
                {
                    erros.Add("telefone deve conter entre 8 e 15 caracteres.");
                }
            }
            #endregion





            #region email
            bool isEmail = Regex.IsMatch(usuario.email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!isEmail)
            {
                erros.Add("Email deve ser informado.");
            }






            #endregion


            #region endereco
            if (string.IsNullOrWhiteSpace(usuario.endereco))
            {
                erros.Add("endereço deve ser informado.");
            }
            else
            {
                usuario.endereco = usuario.endereco.Trim();
                if (usuario.endereco.Length < 3 || usuario.endereco.Length > 60)
                {
                    erros.Add("endereço deve conter entre 3 e 60 caracteres.");
                }

            }
            #endregion

            #region senha
            if (string.IsNullOrWhiteSpace(usuario.nome))
            {
                erros.Add("Nome deve ser informado.");
            }
            else
            {
                if (usuario.senha.Length < 8)
                {
                    erros.Add("senha com tem que ser maior que 8");

                    {


                    }

                    #endregion

                    

                }
            }
            if (erros.Count() > 0)
            {
                return false;
            }
            return true;
        }   
        

    
    

    bool Validarcpf(string cpf)
{
    int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
    int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
    string tempCpf;
    string digito;
    int soma;
    int resto;

    if (cpf.Length != 11)
        return false;
    tempCpf = cpf.Substring(0, 9);
    soma = 0;

    for (int i = 0; i < 9; i++)
        soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
    resto = soma % 11;
    if (resto < 2)
        resto = 0;
    else
        resto = 11 - resto;
    digito = resto.ToString();
    tempCpf = tempCpf + digito;
    soma = 0;
    for (int i = 0; i < 10; i++)
        soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
    resto = soma % 11;
    if (resto < 2)
        resto = 0;
    else
        resto = 11 - resto;
    digito = digito + resto.ToString();
    return cpf.EndsWith(digito);
}