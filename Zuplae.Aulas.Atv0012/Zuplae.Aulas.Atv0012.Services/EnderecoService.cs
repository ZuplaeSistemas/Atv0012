using Zuplae.Aulas.Atv0012.Models;

namespace Zuplae.Aulas.Atv0012.Services
{
    public class EnderecoService : IEnderecoService
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
        public bool Editar(int id, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string cep)
        {
            Endereco endereco = this.ListarPorId(id);
            if (endereco != null)
            {
                endereco.SetLogradouro(logradouro);
                endereco.SetNumero(numero);
                endereco.SetComplemento(complemento);
                endereco.SetBairro(bairro);
                endereco.SetCidade(cidade);
                endereco.SetEstado(estado);
                endereco.SetCep(cep);
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Endereco> Listar()
        {
            return enderecos;
        }

        public Endereco ListarPorId(int id)
        {
            Endereco end = enderecos.Find(e => e.GetId() == id);
            return end;
        }
        public bool Deletar(int id)
        {
            Endereco endereco = this.ListarPorId(id);
            if(endereco != null)
            {
                enderecos.Remove(endereco);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
