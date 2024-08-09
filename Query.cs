namespace WebApplication1;

public class Query
{
    public async Task<string> GetData(TestService testService, int key)
    {
        return await testService.GetData(key);
    }
}