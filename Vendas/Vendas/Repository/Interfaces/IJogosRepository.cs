using Vendas.Models;

namespace Vendas.Repository.Interfaces
{
    public interface IJogosRepository
    {
        IEnumerable<Jogo> Jogos { get; }
        IEnumerable<Jogo> JogosPreferidos { get; }
        Jogo GetJogoById(int JogoId);
        
    }
}
