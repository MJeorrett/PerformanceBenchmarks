# Get generic type name
Quick assessment of the performance impact of using reflection to get a generic type's name at runtime.

## Results
|      Method |       Mean |    Error |    StdDev | Allocated |
|------------ |------------|----------|-----------|-----------|
|    BaseLine |   469.2 ns |  6.23 ns |   5.82 ns |     200 B |
| GetTypeName | 3,788.2 ns | 74.73 ns | 183.31 ns |    7848 B |