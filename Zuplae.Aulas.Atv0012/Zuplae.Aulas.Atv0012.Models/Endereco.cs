using System.Runtime.ConstrainedExecution;

namespace Zuplae.Aulas.Atv0012.Models
{
    // classe filha ou derivada - classe Mãe ou base
    public class Endereco : BaseModel // Herança
    {
        #region Propriedades
        // Campos privados são acessíveis apenas dentro da classe Endereco

            public string Logradouro { get; set; }
            public string Numero { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string Estado { get; set; }
            public string Cep { get; set; }
        #endregion
        #region Metodos
            public override string ToString()
            {
                return $"{Logradouro}, {Numero} {Complemento}, {Bairro}, {Cidade} - {Estado}, CEP: {Cep}";
            }
        #endregion
    }
}
