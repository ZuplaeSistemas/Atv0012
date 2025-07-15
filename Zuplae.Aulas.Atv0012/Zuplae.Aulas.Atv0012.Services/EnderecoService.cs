using Zuplae.Aulas.Atv0012.Models;

namespace Zuplae.Aulas.Atv0012.Services
{
    public class EnderecoService
    {
        private static List<Endereco> enderecos = new List<Endereco>();
        public int Cadastrar(string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string cep)
        {
            Endereco endereco1 = new Endereco();
            endereco1.SetLogradouro(logradouro);
            endereco1.SetNumero(numero);
            endereco1.SetComplemento(complemento);
            endereco1.SetBairro(bairro);
            endereco1.SetCidade(cidade);
            endereco1.SetEstado(estado);
            endereco1.SetCep(cep);
            enderecos.Add(endereco1);

            int id = endereco1.GetId();
            return  id;
        }
        public void Editar()
        {
        }
        public void Listar()
        {
        }

        public Endereco ListarPorId(int id)
        {
            Endereco end = enderecos.Find(e => e.GetId() == id);
            return end;
        }
        public void Deletar()
        {
        }
    }
}
