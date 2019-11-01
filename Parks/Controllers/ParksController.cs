using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Parks.Models;

namespace Parks.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private ParksContext _db;

    public ParksController(ParksContext db)
    {
      _db = db;
    }

    // GET api/parks
    [HttpGet]
    public ActionResult<IEnumerable<Park>> Get()
    {
      return _db.Parks.ToList();
    }


    // POST api/parks
    [HttpPost]
    public void Post([FromBody] Park park)
    {
      _db.Parks.Add(park);
      _db.SaveChanges();
    }
    
    [HttpGet("{id}")]
    public ActionResult<Park> Get(int id)
    {
        return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
    }
  }
}