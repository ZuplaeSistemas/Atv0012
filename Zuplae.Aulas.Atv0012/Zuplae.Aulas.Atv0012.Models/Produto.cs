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
            private string _nome;
            public string Nome 
            { 
                get { return this._nome.ToUpper(); } 
                set { this._nome = value; } 
            }

            public string Codigo { get; private set; }
            private decimal _preco;
            public decimal Preco 
            { 
                get { return this._preco; } 
                set {
                        //O Preco não pode ser negativo e nem superior a R$100.00
                        if (value < 0 || value > 100.00m)
                        {
                            throw new Exception("Preço deve ser entre R$0,00 e R$100,00.");
                        }
                        this._preco = value;
                    } 
            }

            public Fornecedor Fornecedor { get; set; }
        
        #endregion
       

        #region Construtores
            public Produto()
            {
                this.GerarCodigo();
            }

            public Produto(string nome, decimal preco, Fornecedor fornecedor)
            {
                this.Nome = nome;
                this.Preco = preco;
                this.Fornecedor = fornecedor;

                this.GerarCodigo();
            }
        #endregion

        #region Metodos
            public override string ToString()
            {
                return $"Produto: {Nome}, Código: {Codigo}, Preço: {Preco:C}, Fornecedor: {Fornecedor}";
            }

            private void GerarCodigo()
            {
                Codigo = "ZPEL" + Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            }

        #endregion

    }
}
