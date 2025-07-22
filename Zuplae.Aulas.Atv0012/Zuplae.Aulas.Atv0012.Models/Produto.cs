using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0012.Models
{
    public class Produto : BaseModel
    {
        #region CamposPrivados
            private string nome;
            private string codigo;
            private decimal preco;
            private Fornecedor fornecedor;
        #endregion

        #region Nome
            public void SetNome(string nome) 
            { 
                this.nome = nome;
            }
            public string GetNome() 
            { 
                return this.nome.ToUpper();
            }
        #endregion
        #region Codigo
            public string GetCodigo() 
            { 
                return this.codigo;
            }
        #endregion
        #region Preco
            public void SetPreco(decimal preco) 
            {
                //O Preco não pode ser negativo e nem superior a R$100.00
                if (preco < 0 || preco > 100.00m)
                {
                    throw new Exception("Preço deve ser entre R$0,00 e R$100,00.");
                }
                this.preco = preco;
            }
            public decimal GetPreco() 
            { 
                return this.preco;
            }
        #endregion
        #region Fornecedor
            public void SetFornecedor(Fornecedor fornecedor) 
            { 
                this.fornecedor = fornecedor;
            }
            public Fornecedor GetFornecedor() 
            { 
                return this.fornecedor;
            }
        #endregion

        #region Construtores
            public Produto()
            {
                this.GerarCodigo();
            }

            public Produto(string nome, decimal preco, Fornecedor fornecedor)
            {
                this.SetNome(nome);
                this.SetPreco(preco);
                this.SetFornecedor(fornecedor);

                this.GerarCodigo();
            }
        #endregion

        #region Metodos
            public override string ToString()
            {
                return $"Produto: {GetNome()}, Código: {GetCodigo()}, Preço: {GetPreco():C}, Fornecedor: {GetFornecedor()}";
            }

            private void GerarCodigo()
            {
                this.codigo = "ZPEL" + Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            }

        #endregion

    }
}
