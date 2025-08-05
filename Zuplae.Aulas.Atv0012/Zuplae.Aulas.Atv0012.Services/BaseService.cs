using Zuplae.Aulas.Atv0012.Models;

namespace Zuplae.Aulas.Atv0012.Services
{
    public class BaseService<M> : IService<M> where M : BaseModel
    {
        private static List<M> enderecos = new List<M>();
        public int Cadastrar(M model)
        {
            enderecos.Add(model);
            int id = model.GetId();
            return  id;
        }
        public bool Editar(M model)
        {
            M modelOriginal = this.ListarPorId(model.GetId());
            if (modelOriginal != null)
            {
                modelOriginal = model;
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<M> Listar()
        {
            return enderecos;
        }

        public M ListarPorId(int id)
        {
            M end = enderecos.Find(e => e.GetId() == id);
            return end;
        }
        public bool Deletar(int id)
        {
            M endereco = this.ListarPorId(id);
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
