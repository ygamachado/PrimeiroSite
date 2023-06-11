using PrimeiroSite.Models;

namespace PrimeiroSite.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel Adicionar(ContatoModel contato);
    }
}
