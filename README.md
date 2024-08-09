Executing this query deadlocks, because the data loader is never called

```gql
{
    data(key: 1)
}
```

This only happens with `.RegisterService<TestService>(ServiceKind.Resolver)`

Changing it to `.RegisterService<TestService>()` it works fine
