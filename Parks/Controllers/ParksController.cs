using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Parks.Models;
using Microsoft.EntityFrameworkCore;


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

    [HttpGet]
    public ActionResult<IEnumerable<Park>> Get(string name, string state, string stateOrNational, int rating)
    {
      var query = _db.Parks.AsQueryable(); 
      if(name !=null)
      {
        query = query.Where(entry=>entry.Name == name);
      }

      if(stateOrNational !=null)
      {
        query = query.Where(entry=>entry.StateOrNational == stateOrNational);
      }
        
      if(state !=null)
      {
        query = query.Where(entry=>entry.State == state);
      }
        if(rating !=0)
      {
        query = query.Where(entry=>entry.Rating == rating);
      }
      return query.ToList();
    }

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

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Park park)
    {
        park.ParkId = id;
        _db.Entry(park).State = EntityState.Modified;
        _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
      _db.Parks.Remove(parkToDelete);
      _db.SaveChanges();
    }

  }
}