namespace WebApplication1;

public class TestDataLoader : BatchDataLoader<int, string>
{
    public TestDataLoader(IBatchScheduler batchScheduler, DataLoaderOptions? options = null) : base(batchScheduler,
        options)
    {
    }

    protected override async Task<IReadOnlyDictionary<int, string>> LoadBatchAsync(IReadOnlyList<int> keys,
        CancellationToken cancellationToken)
    {
        var result = new Dictionary<int, string>();

        foreach (var key in keys)
        {
            result[key] = "asdf";
        }

        return await Task.FromResult(result);
    }
}