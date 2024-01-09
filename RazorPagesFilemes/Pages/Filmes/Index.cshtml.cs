using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesFilemes.Data;
using RazorPagesFilemes.Modelo;

namespace RazorPagesFilemes.Pages.Filmes
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesFilemes.Data.RazorPagesFilemesContext _context;

        public IndexModel(RazorPagesFilemes.Data.RazorPagesFilemesContext context)
        {
            _context = context;
        }

        public IList<Filme> Filme { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string TermoBusca { get; set; }

        [BindProperty(SupportsGet = true)]
        public string FilmeGenero { get; set; } 

        public SelectList Generos {  get; set; } 

        public async Task OnGetAsync()
        {
            if (_context.Filme != null)
            {
                var filmes = from m in _context.Filme
                             select m;
                if (!string.IsNullOrWhiteSpace(TermoBusca))
                {
                    filmes = filmes.Where(f => f.Titulo.Contains(TermoBusca));
                }
                if (!string.IsNullOrWhiteSpace(FilmeGenero))
                {
                    filmes = filmes.Where(f => f.Genero == FilmeGenero);
                }

                Generos = new SelectList(await _context.Filme.Select(o => o.Genero).Distinct().ToListAsync());
                Filme = await  filmes.ToListAsync();
            }
        }
    }
}
