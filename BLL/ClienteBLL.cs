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

        List<string> erros = new List<string>();



        public string Inserir(Cliente cliente)
        {
            if (this.Validar(cliente))
            {
                return clienteDal.Inserir(cliente);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < erros.Count(); i++)
            {
                sb.Append(erros[i]);
            }
            return sb.ToString();
        }

        public string Atualizar(Cliente cliente)
        {
            if (this.Validar(cliente))
            {
                return clienteDal.Atualizar(cliente);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < erros.Count(); i++)
            {
                sb.Append(erros[i]);
            }
            return sb.ToString();
        }
        #region Validar
        public bool Validar(Cliente cliente)
        {
            
            if (string.IsNullOrWhiteSpace(cliente.cpf))
            {
                if (ValidarCPF(cliente.cpf))
                {
                    erros.Add("CPF deve ser informado.");
                }
            }


            #region Nome
            if (string.IsNullOrWhiteSpace(cliente.nome))
            {
                erros.Add("Nome deve ser informado.");
            }
            else
            {
                cliente.nome = cliente.nome.Trim();
                if (cliente.nome.Length < 3 || cliente.nome.Length > 60)
                {
                    erros.Add("Nome deve conter entre 3 e 60 caracteres.");
                }
                else
                {
                    for (int i = 0; i < cliente.nome.Length; i++)
                    {
                        if (!char.IsLetter(cliente.nome[i]) && cliente.nome[i] != ' ')
                        {
                            erros.Add("Nome inválido");
                            break;
                        }
                    }
                }
            }
            #endregion

            #region Telefone2
            if (string.IsNullOrWhiteSpace(cliente.telefone2))
            {
                erros.Add("Segundo número de telefone deve ser informado.");
            }
            else
            {
                cliente.telefone2 =
                    cliente.telefone2.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (cliente.telefone2.Length < 8 || cliente.telefone2.Length > 15)
                {
                    erros.Add("Telefone deve conter entre 8 e 15 caracteres.");
                }
            }
            #endregion

            #region Telefone1
            if (string.IsNullOrWhiteSpace(cliente.telefone1))
            {
                erros.Add("Primeiro número de telefone deve ser informado.");
            }
            else
            {
                cliente.telefone1 =
                    cliente.telefone1.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (cliente.telefone1.Length < 8 || cliente.telefone1.Length > 15)
                {
                    erros.Add("Telefone deve conter entre 8 e 15 caracteres.");
                }
            }
            #endregion


            #region email
            bool isEmail = Regex.IsMatch(cliente.email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!isEmail)
            {
                erros.Add("Email deve ser informado.");
            }
            #endregion

            #region RG
            if (string.IsNullOrWhiteSpace(cliente.rg))
            {
                erros.Add("RG deve ser informado.");
            }
            else
            {
                cliente.rg = cliente.rg.Trim();
                cliente.rg = cliente.rg.Replace(".", "").Replace("/", "").Replace("-", "");
                if (cliente.rg.Length < 5 || cliente.rg.Length > 9)
                {
                    erros.Add("RG deve conter entre 5 e 9 caracteres.");
                }
            }
            #endregion


            if (erros.Count() < 1)
            {
                return true;

            }
            return false;
        }
        #endregion
        #region Validar CPF
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
        #endregion



        public Cliente LerPorID(int id)
        {

            return clienteDal.LerPorID(id);

        }
        public List<Cliente> LerTodos()
        {
            return clienteDal.LerTodos();
        }
    }


}