using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Naruto.DbContexts;
using Naruto.Entities;
using Naruto.Models;

namespace Naruto.Controllers
{
    [ApiController]
    [Route("/new")]
    public class New : ControllerBase
    {
        private readonly NarutoContext _context;
        private readonly IMapper _mapper;

        public New(NarutoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<Shinobi>> CreateShinobiAsync(ShinobiInputDto shinobiInputDto)
        {
            var shinobi = _mapper.Map<Shinobi>(shinobiInputDto);
            await _context.Shinobis.AddAsync(shinobi);
            await _context.SaveChangesAsync();

            return shinobi;
        }
        
        [HttpPost("{shinobiId:guid}/tiers")]
        public async Task<ActionResult<Tier>> CreateTierAsync(Guid shinobiId, TierInputDto tierInputDto)
        {
            var shinobi = await _context.Shinobis.FirstOrDefaultAsync(s => s.Id == shinobiId);

            if (shinobi == null)
            {
                return NotFound();
            }
            
            var tier = _mapper.Map<Tier>(tierInputDto);
            tier.Shinobi = shinobi;
            await _context.Tiers.AddAsync(tier);
            await _context.SaveChangesAsync();

            return tier;
        }
    }
}