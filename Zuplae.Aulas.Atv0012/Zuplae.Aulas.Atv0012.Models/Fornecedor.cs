using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0012.Models
{
    public class Fornecedor : BaseModel
    {
        #region CamposPrivados
            private string razaoSocial;
            private string cnpj;
            private Endereco endereco;
        #endregion

        #region RazaoSocial
            public void SetRazaoSocial(string razaoSocial) 
            { 
                this.razaoSocial = razaoSocial;
            }
            public string GetRazaoSocial() 
            { 
                return this.razaoSocial;
            }
        #endregion
        #region CNPJ
            public void SetCnpj(string cnpj) 
            { 
                this.cnpj = cnpj;
            }
            public string GetCnpj() 
            { 
                return this.cnpj;
            }
        #endregion
        #region Endereco
            public void SetEndereco(Endereco endereco) 
            { 
                this.endereco = endereco;
            }
            public Endereco GetEndereco() 
            { 
                return this.endereco;
        }
        #endregion

        #region Metodos
            public override string ToString()
            {
                return $"Razao Social: {GetRazaoSocial()}, CNPJ: {GetCnpj()}, Endereço: {GetEndereco()}";
            }
        #endregion
    }
}
