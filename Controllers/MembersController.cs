using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyDatingAppAPI.Data;

namespace MyDatingAppAPI.Controllers
{
    [Authorize]
    public class MembersController : BaseApiController
    {
        private readonly AppDbContext _context;
        public MembersController(AppDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetMembers()
        {
            var members = await _context.Users.ToListAsync();
            return Ok(members);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMember(string id)
        {
            var member = await _context.Users.FindAsync(id);
            if (member == null)
            {
                return NotFound();
            }
            return Ok(member);
        }
    }
}
