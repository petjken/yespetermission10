using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using the10thmission.Data;

namespace the10thmission.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {


        private BowlerDbContext _bowlerContext;

        public BowlerController(BowlerDbContext temp)
        {
            _bowlerContext = temp;
        }

        

        [HttpGet(Name ="GetBowlerInfo")]
        public IEnumerable<BowlerInfo> Get()
        {
            var bowlerList = _bowlerContext.Bowlers.ToList();
            return _bowlerContext.Bowlers
                .Include(x => x.Team) // <--- THIS IS CRITICAL
                .Where(x => x.Team!= null && (x.Team.TeamName == "Marlins" || x.Team.TeamName == "Sharks"))
                .ToArray();
        }


    }
}
