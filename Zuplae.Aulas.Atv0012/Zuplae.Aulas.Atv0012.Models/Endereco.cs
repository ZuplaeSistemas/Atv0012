using System.Runtime.ConstrainedExecution;

namespace Zuplae.Aulas.Atv0012.Models
{
    public class Endereco
    {
        #region CamposPrivados
            private string logradouro;
            private string numero; //Correios 280-A , 280B, 280C, etc
            private string complemento;
            private string bairro;
            private string cidade;
            private string estado;
            private string cep;
        #endregion

        #region Logradouro
            public void SetLogradouro(string logradouro) 
            { 
                this.logradouro = logradouro;        
            }
            public string GetLogradouro() 
            {             
                return this.logradouro;
            }
        #endregion
        #region Numero
            public void SetNumero(string numero) 
            { 
                this.numero = numero;
            }
            public string GetNumero() 
            { 
                return this.numero;
            }
        #endregion
        #region Complemento
            public void SetComplemento(string complemento) 
            { 
                this.complemento = complemento;
            }
            public string GetComplemento() 
            { 
                return this.complemento;
        }
        #endregion
        #region Bairro
            public void SetBairro(string bairro) 
            { 
                this.bairro = bairro;
            }
            public string GetBairro() 
            { 
                return this.bairro;
        }
        #endregion
        #region Cidade
            public void SetCidade(string cidade) 
            { 
                this.cidade = cidade;
            }
            public string GetCidade() 
            { 
                return this.cidade;
        }
        #endregion
        #region Estado
            public void SetEstado(string estado) 
            { 
                this.estado = estado;
            }
            public string GetEstado() 
            { 
                return this.estado;
        }
        #endregion
        #region CEP
            public void SetCep(string cep) 
            { 
                this.cep = cep;
            }
            public string GetCep() 
            { 
                return this.cep;
        }
        #endregion

        #region Metodos
            public override string ToString()
            {
                return $"{GetLogradouro()}, {GetNumero()} {GetComplemento()}, {GetBairro()}, {GetCidade()} - {GetEstado()}, CEP: {GetCep()}";
            }
        #endregion
    }
}
