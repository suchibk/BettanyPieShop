using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BettanyPieServices.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PieDetailsController : ControllerBase
{
    // GET: api/<PieDetailsController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<PieDetailsController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<PieDetailsController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<PieDetailsController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<PieDetailsController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
