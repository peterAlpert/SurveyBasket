


namespace SurveyBasket.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class pollsController : ControllerBase
    {
        public IPollRepo PollRepo { get; }

        public pollsController(IPollRepo _pollRepo)
        {
            PollRepo = _pollRepo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(PollRepo.Polls());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Poll poll = PollRepo.Poll(id);
            if(poll == null)
                return NotFound();
            return Ok(poll);
        }


    }
}
