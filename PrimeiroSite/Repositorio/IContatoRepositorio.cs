using PrimeiroSite.Models;

namespace PrimeiroSite.Repositorio;

public interface IContatoRepositorio
{
    List<ContatoModel> BuscarTodos();
    ContatoModel Adicionar(ContatoModel contato);
}
