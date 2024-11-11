namespace HtTemplate.Status;

public class StatusController : ControllerBase
{
    [HttpGet("/status")]
    public async Task<ActionResult> GetTheStatus()
    {
        return Ok("This is the status for right now");
    }

    [HttpGet("/status/{year:int}/{month:int:max(12):min(1)}/{day:int}")]
    public async Task<ActionResult> GetTheStatus(int year, int month, int day)
    {
        return Ok();
    }

    [HttpGet("/employees")]
    public async Task<ActionResult> GetEmployees(
        [FromQuery]
        string department = "All")
    {
        return Ok($"here are {department} the the employees...");
    }
}
