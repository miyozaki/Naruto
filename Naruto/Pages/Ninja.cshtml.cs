using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Naruto.DbContexts;
using Naruto.Entities;
using Naruto.Models;

namespace Naruto.Pages
{
    public class Ninja : PageModel
    {
        private readonly NarutoContext _context;
        private readonly IMapper _mapper;
        public ShinobiOutputDto Shinobi { get; set; }

        public Ninja(NarutoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public async Task OnGetAsync()
        {
            var slug = RouteData.Values["title"].ToString();

            var shinobi = await _context.Shinobis.FirstOrDefaultAsync(s => s.Slug == slug);

            if (shinobi == null)
            {
                RedirectToPage("/Error");
            }

            Shinobi = _mapper.Map<ShinobiOutputDto>(shinobi);
        }
    }
}