

namespace Chore_Score.Controllers
{

    [ApiController]
    [Route ("api/assignments")]
    public class AssignmentsController : ControllerBase
    {
        private readonly AssignmentsService _assignmentsService;
        
        public AssignmentsController(AssignmentsService assignmentsService)
        {
            _assignmentsService = assignmentsService;
        }



    [HttpGet]
    public ActionResult<List<Assignment>> GetAssignments()
    {
        try
        {
            List<Assignment> assignments = _assignmentsService.GetAssignments();
            return Ok(assignments);
        }
        catch (Exception e)
        {
            
            return BadRequest(e.Message);
        }
    }


    [HttpGet("{assignmentName}")]
    public ActionResult<List<Assignment>> GetAssignmentByName(string assignmentName)
    {
        try
        {
            Assignment assignment = _assignmentsService.GetAssignmentByName(assignmentName);
            return Ok(assignment);
        }
        catch (Exception e)
        {
            
            return BadRequest(e.Message);
        }
    }



    [HttpPut("{assignmentName}")]
    public ActionResult<List<Assignment>> EditAssignment([FromBody] Assignment assignmentData, string assignmentName)
    {
        try
        {
            Assignment assignment = _assignmentsService.EditAssignment(assignmentData, assignmentName);
            return Ok(assignment);

        }
        catch (Exception e)
        {
            
            return BadRequest(e.Message);
        }
    }
    }
}