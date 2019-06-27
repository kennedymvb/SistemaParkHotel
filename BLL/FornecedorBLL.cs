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
    public class FornecedorBLL
    {
        List<string> erros = new List<string>();

        FornecedorDAL fornecedorDAL = new FornecedorDAL();

        public string inserir(Fornecedor fornecedor)
        {
            if (this.Validar(fornecedor))
            {
                return fornecedorDAL.Inserir(fornecedor);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < erros.Count(); i++)
            {
                sb.Append(erros[i]);
            }
            return sb.ToString();
        }

        public string Atualizar(Fornecedor fornecedor)
        {
            if (this.Validar(fornecedor))
            {
                return fornecedorDAL.Atualizar(fornecedor);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < erros.Count(); i++)
            {
                sb.Append(erros[i]);
            }
            return sb.ToString();
        }
        public bool Validar(Fornecedor fornecedor)
        {
            if (!IsCnpj(fornecedor.cnpj))
            {
                erros.Add("o cpnj está incorreto");
            }
            #region email
            bool isEmail = Regex.IsMatch(fornecedor.email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!isEmail)
            {
                erros.Add("Email deve ser informado.");
            }
            #endregion

            #region RG
            if (string.IsNullOrWhiteSpace(fornecedor.rg))
            {
                erros.Add("rg deve ser informado.");
            }
            else
            {
                fornecedor.rg = fornecedor.rg.Trim();
                fornecedor.rg = fornecedor.rg.Replace(".", "").Replace("/", "").Replace("-", "");
                if (fornecedor.rg.Length < 5 || fornecedor.rg.Length > 9)
                {
                    erros.Add("rg deve conter entre 5 e 9 caracteres.");
                }
            }
            #endregion
            #region Nome
            if (string.IsNullOrWhiteSpace(fornecedor.nomeContato))
            {
                erros.Add("Nome deve ser informado.");
            }
            else
            {
                fornecedor.nomeContato = fornecedor.nomeContato.Trim();
                if (fornecedor.nomeContato.Length < 3 || fornecedor.nomeContato.Length > 60)
                {
                    erros.Add("nomeContato deve conter entre 3 e 60 caracteres.");
                }
                else
                {
                    for (int i = 0; i < fornecedor.nomeContato.Length; i++)
                    {
                        if (!char.IsLetter(fornecedor.nomeContato[i]) && fornecedor.nomeContato[i] != ' ')
                        {
                            erros.Add("Nome inválido");
                            break;
                        }
                    }
                }
            }
            #endregion
            if (erros.Count() < 1)
            {
                return true;

            }
            return false;
        }
        #region cnpj
        public static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }
        #endregion

        public Fornecedor LerPorID(int id)
        {
                return fornecedorDAL.LerPorID(id);
        }
        public List<Fornecedor> LerTodos()
        {
            return fornecedorDAL.LerTodos();
        }
    }
}