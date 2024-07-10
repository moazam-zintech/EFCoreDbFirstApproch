using EFCoreDbFirstApproch.Models;
using EFCoreDbFirstApproch.UserInfoModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace EFCoreDbFirstApproch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly EmailsDataDbContext _context;
        private readonly DbfirstApproachContext _dbcontext;
        public EmailController(DbfirstApproachContext dbcontext,EmailsDataDbContext context)
        {
            _context = context;
            _dbcontext = dbcontext;
        }
        //Connect OLD DB which was created by migrations 
        [HttpGet]
        public async Task<IActionResult> Get() {
            var res=await (_context.EmailAddresses.ToListAsync());
            return Ok(res);
        }
        //New DB which is created in SSMS
        [HttpGet("NewDB")]
        public async Task<IActionResult> GetDB()
        {
            var res = await _dbcontext.Infos.ToListAsync();
            return Ok(res);
        }
    }
}
