using LineDataAccess.Model;
using LineDataAccess.Providers;
using Microsoft.AspNetCore.Mvc;

namespace LineService.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class LinesController : ControllerBase
{
    ILineDAO _lineProvider;

    public LinesController(ILineDAO lineProvider) => _lineProvider = lineProvider;

    [HttpGet]
    public ActionResult<IEnumerable<Line>?> Get() => Ok(_lineProvider.GetAll());

    [HttpGet("{id}")]
    public ActionResult<Line> Get(int id) => Ok(_lineProvider.Get(id));

    [HttpPost]
    public int Post([FromBody] Line value) => _lineProvider.Insert(value);

    [HttpPut()]
    public ActionResult<bool> Put(int id, [FromBody] Line value) => _lineProvider.Update(value);

    [HttpDelete("{id}")]
    public ActionResult<bool> Delete(int id) => _lineProvider.Delete(id) ? Ok(true) : NotFound  (false);
}