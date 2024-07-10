/*using EFCoreDbFirstApproch.UserInfoModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace EFCoreDbFirstApproch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DbfirstApproachContext _context;
        public UserController(DbfirstApproachContext context)
        {
            _context =context;
        }
        public async Task<IActionResult> Get()
        {
            var res=await _context.Infos.ToListAsync();
            return Ok(res);
        }
    }
}
*/