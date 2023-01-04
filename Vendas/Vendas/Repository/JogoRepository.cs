using Microsoft.EntityFrameworkCore;
using Vendas.Context;
using Vendas.Models;
using Vendas.Repository.Interfaces;

namespace Vendas.Repository
{
    public class JogoRepository : IJogosRepository
    {
        private readonly AppDbContext _context;

        public JogoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Jogo> Jogos => _context.Jogos.Include(c => c.Categoria);

        public IEnumerable<Jogo> JogosPreferidos => _context.Jogos.Where(I => I.JogoPreferido).Include(c => c.Categoria);

        public Jogo GetJogoById(int JogoId)
        {
            return _context.Jogos.FirstOrDefault(I => I.Jogoid == JogoId);
        }
    }
}
