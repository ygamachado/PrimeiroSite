using PrimeiroSite.Data;
using PrimeiroSite.Models;

namespace PrimeiroSite.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext) 
        { 
            _bancoContext = bancoContext;
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }

        ContatoModel IContatoRepositorio.Adicionar(ContatoModel contato)
        {
            //Gravar no banco
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }
    }
}
