using BenchmarkDotNet.Attributes;

namespace GetGenericTypeName;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    [Benchmark]
    public string BaseLine() => new IdHasher().Encode(100);

    [Benchmark]
    public string GetTypeName() => new IdHasherGetTypeName().Encode<DummyDto>(100);
}
