using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/tools")]
public class ToolController : ControllerBase
{
    private readonly IToolsRepository _toolsRepository;

    public ToolController(IToolsRepository toolsRepository)
    {
        _toolsRepository = toolsRepository;
    }


    [HttpGet]
    [EndpointSummary("Get all tools")]
    [EndpointDescription("Returns all tools.")]
    public ActionResult<IEnumerable<Tool>> GetAll() =>
            Ok(_toolsRepository.GetAll());

    [HttpGet("{id:guid}")]
    [EndpointSummary("Get a tool by id")]
    [EndpointDescription("Returns a single tools.")]
    public ActionResult<Tool> GetById(Guid id)
    {
        var user = _toolsRepository.GetById(id)
            ?? throw new NotFoundException("user", id);

        return Ok(user);
    }

    [HttpPut]
    [EndpointSummary("Update a tool")]
    [EndpointDescription("Returns Ok")]
    public async Task<ActionResult<Tool>> updateTooolDetails(Guid id, string name)
    {
        var tool = _toolsRepository.updateToolDetail(id, name);
        return Ok();
    }

    [HttpDelete("{id:guid}/tools")]
    public ActionResult<Tool> RemoveMember(Guid id)
    {
        //TODO: need to find first the object to be deleted for precision

        _toolsRepository.Remove(id);
        return Ok("Tool removed ");
    }

}