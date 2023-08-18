

namespace Chore_Score.Controllers
{

    [ApiController]
    [Route ("api/chores")]
    public class ChoresController : ControllerBase
    {

        // [HttpGet]
        // public string Test()
        // {
        //     return "Test Successful!";

        // }


    private readonly ChoresService _choresService;

    public ChoresController(ChoresService choresService)
    {
        _choresService = choresService;
    }

        
        
        
        [HttpGet]
        public ActionResult<List<Chore>> GetChores()
        {
            try
            {
                List<Chore> chores = _choresService.GetChores();
                return Ok(chores);
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }








    [HttpGet("{choreName}")]
    public ActionResult<Chore> GetChoreByName(string choreName)
    {
        try
        {
            Chore chore = _choresService.GetChoreByName(choreName);
            return Ok(chore);
        }
            catch (Exception e)
        {
    
            return BadRequest(e.Message);
        }
    }






    [HttpPost]
    public ActionResult<Chore> CreateChore([FromBody] Chore choreData)
    {
        try
        {
            Chore chore = _choresService.CreateChore(choreData);
            return Ok(chore);
        }
        catch (Exception e)
        {
            
            return BadRequest(e.Message);
        }
    }





    [HttpDelete("{choreName}")]
    public ActionResult<string> RemoveChore(string choreName)
    {
        try
        {
            Chore chore = _choresService.RemoveChore(choreName);
            return Ok($"{chore.Name} has been removed!");
        }
            catch (Exception e)
        {
            return BadRequest(e.Message);
        }
        }
            
            
    }
}