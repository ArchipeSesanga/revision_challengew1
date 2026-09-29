using System.Collections.Concurrent;

public class ToolRepository : IToolsRepository
{
     private readonly ConcurrentDictionary<Guid, Tool> _tools = new();

     public ToolRepository(ConcurrentDictionary<Guid, Tool> tools)
    {

        //TODO; i need to review this 
        _tools = tools;
        
    }
    public Task CreateToolAsync()
    {

        throw new NotImplementedException();
    }

    public Task DeleteToolAsync()
    {
        throw new NotImplementedException();
    }

    public Task GetAllToolsAsync()
    {
        throw new NotImplementedException();
    }

    public Task GetToolByIdAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateToolAsunc()
    {
        throw new NotImplementedException();
    }
}