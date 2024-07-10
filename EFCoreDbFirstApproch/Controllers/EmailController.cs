using EFCoreDbFirstApproch.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDbFirstApproch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly EmailsDataDbContext _context;
        public EmailController(EmailsDataDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Get() {

            var res=await (_context.EmailAddresses.ToListAsync());
            return Ok(res);
        }
    }
}
