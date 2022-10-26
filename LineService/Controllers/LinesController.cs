using LineDataAccess.Model;
using LineDataAccess.Providers;
using Microsoft.AspNetCore.Mvc;

namespace LineService.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LinesController : ControllerBase
    {
        ILineProvider _lineProvider;

        public LinesController(ILineProvider lineProvider) => _lineProvider = lineProvider;

        [HttpGet]
        public ActionResult<IEnumerable<Line>?> Get() => Ok(_lineProvider.GetLines());

        [HttpGet("{id}")]
        public ActionResult<Line> Get(int id) => Ok(_lineProvider.GetLine(id));

        [HttpPost]
        public int Post([FromBody] Line value) => _lineProvider.AddLine(value);

        [HttpPut()]
        public ActionResult<bool> Put([FromBody] Line value) => _lineProvider.UpdateLine(value);

        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id) => _lineProvider.DeleteLine(id) ? Ok(true) : NotFound(false);
    }
}