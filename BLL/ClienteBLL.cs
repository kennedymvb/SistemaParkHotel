using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metadata;
using DAL;
using System.Text.RegularExpressions;

namespace BLL
{
   public class ClienteBLL
   {

        ClienteDAL clienteDal = new ClienteDAL();


        private bool ValidarCPF(string cpf)
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


        public string Cadastrar(Cliente cli)
        {
            List<string> erros = new List<string>();

            #region Nome
            if (string.IsNullOrWhiteSpace(cli.nome))
            {
                erros.Add("Nome deve ser informado.");
            }
            else
            {
                cli.nome = cli.nome.Trim();
                if (cli.nome.Length < 3 || cli.nome.Length > 60)
                {
                    erros.Add("Nome deve conter entre 3 e 60 caracteres.");
                }
                else
                {
                    for (int i = 0; i < cli.nome.Length; i++)
                    {
                        if (!char.IsLetter(cli.nome[i]) && cli.nome[i] != ' ')
                        {
                            erros.Add("Nome inválido");
                            break;
                        }
                    }
                }
            }
            #endregion

            #region CPF
            if (string.IsNullOrWhiteSpace(cli.cpf))
            {
                erros.Add("CPF deve ser informado.");
            }
            else
            {
              
                cli.cpf = cli.cpf.Trim();
                cli.cpf = cli.cpf.Replace(".", "").Replace("-", "");
                if (!this.ValidarCPF(cli.cpf))
                {
                    erros.Add("CPF inválido");
                }
            }
            #endregion

            #region RG
            if (string.IsNullOrWhiteSpace(cli.rg))
            {
                erros.Add("RG deve ser informado.");
            }
            else
            {
                cli.rg = cli.rg.Trim();
                cli.rg = cli.rg.Replace(".", "").Replace("/", "").Replace("-", "");
                if (cli.rg.Length < 5 || cli.rg.Length > 9)
                {
                    erros.Add("RG deve conter entre 5 e 9 caracteres.");
                }
            }
            #endregion


            #region Telefone1
            if (string.IsNullOrWhiteSpace(cli.telefone1))
            {
                erros.Add("Primeiro número de telefone deve ser informado.");
            }
            else
            {
                cli.telefone1 =
                    cli.telefone1.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (cli.telefone1.Length < 8 || cli.telefone1.Length > 15)
                {
                    erros.Add("Telefone deve conter entre 8 e 15 caracteres.");
                }
            }
            #endregion



            #region Telefone2
            if (string.IsNullOrWhiteSpace(cli.telefone2))
            {
                erros.Add("Segundo número de telefone deve ser informado.");
            }
            else
            {
                cli.telefone2 =
                    cli.telefone2.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (cli.telefone2.Length < 8 || cli.telefone2.Length > 15)
                {
                    erros.Add("Telefone deve conter entre 8 e 15 caracteres.");
                }
            }
            #endregion



            #region Email

            bool isEmail = Regex.IsMatch(cli.email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!isEmail)
            {
                erros.Add("Email deve ser informado.");
            }

           

            StringBuilder builder = new StringBuilder();
            if (erros.Count != 0)
            {
                for (int i = 0; i < erros.Count; i++)
                {
                    builder.AppendLine(erros[i]);
                }
                return builder.ToString();
            }
            new ClienteDAL().Inserir(cli);
            return "Cliente cadastrado com sucesso";

            #endregion

        }
   }
}

