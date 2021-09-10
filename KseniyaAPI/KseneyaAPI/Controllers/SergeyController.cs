using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KseneyaAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SergeyController : ControllerBase
  {
    // GET: api/<SergeyController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "Андрей поедет в КАБУЛ" };
    }

    // GET api/<SergeyController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "Андрей съел " + id.ToString() + " ЁЖИКОВ";
    }

    // POST api/<SergeyController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<SergeyController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<SergeyController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
