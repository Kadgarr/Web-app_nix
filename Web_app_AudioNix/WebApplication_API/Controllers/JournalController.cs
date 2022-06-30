using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JournalController : ControllerBase
    {
        static List<Journal> _journals = new List<Journal>
        {
            new Journal( Guid.NewGuid(), "Name1", new DateTime(2015, 7, 20), true),
            new Journal( Guid.NewGuid(), "Name2", new DateTime(2015, 7, 20), false),
            new Journal( Guid.NewGuid(), "Name3", new DateTime(2015, 7, 20), false),
            new Journal( Guid.NewGuid(), "Name4", new DateTime(2015, 7, 20), true),
            new Journal( Guid.NewGuid(), "Name5", new DateTime(2015, 7, 20), false)
        };


        private readonly ILogger<JournalController> _logger;

        public JournalController(ILogger<JournalController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Journal>> Get()
        {
            return _journals.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Journal> Get(Guid id)
        {
            var user =  _journals.FirstOrDefault(x => x.Id == id);
            if (user == null)
                return NotFound();
            return new ObjectResult(user);
        }

        [HttpPost]
        public ActionResult<Journal> Post(Journal journal)
        {
            if (journal == null)
            {
                return BadRequest();
            }

            _journals.Add(journal);
            
            return Ok(_journals);
        }

        [HttpPut]
        public ActionResult<Journal> Patch(Journal journal)
        {
            if (journal == null)
            {
                return BadRequest();
            }
            if (!_journals.Any(x => x.Id == journal.Id))
            {
                return NotFound();
            }

            var index = _journals.IndexOf(_journals.Where(x => x.Id == journal.Id).FirstOrDefault());

            _journals[index]=journal;

            
            return Ok(journal);
        }

        [HttpDelete("{id}")]
        public ActionResult<Journal> Delete(Guid id)
        {
            var journal = _journals.FirstOrDefault(x => x.Id == id);
            if (journal == null)
                return NotFound();
            _journals.Remove(journal);
            return Ok(journal);
        }
    }
}

