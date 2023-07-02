using Microsoft.AspNetCore.Mvc.RazorPages;
using slimeTAP.Models;
using SlimeTAP.RazorPages.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace slimeTAP.Pages.Rank
{
    public class Rank : PageModel
    {
        private readonly ILogger<Rank> _logger;
        private readonly AppDbContext _context;

        public List<UsuarioModel> MoedaRank { get; set; }
        public List<UsuarioModel> XpRank { get; set; }

        public Rank(ILogger<Rank> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            MoedaRank = _context.Cliente.OrderByDescending(u => u.MoedaTotal).Take(10).ToList();
            XpRank = _context.Cliente.OrderByDescending(u => u.Xp).Take(10).ToList();
        }
    }
}
