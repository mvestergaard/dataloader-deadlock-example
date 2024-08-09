namespace WebApplication1;

public class TestService
{
    private readonly TestDataLoader _dataLoader;

    public TestService(TestDataLoader dataLoader)
    {
        _dataLoader = dataLoader;
    }
    
    public async Task<string> GetData(int key)
    {
        return await _dataLoader.LoadAsync(key);
    }
}