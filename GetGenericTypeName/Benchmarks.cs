using BenchmarkDotNet.Attributes;

namespace GetGenericTypeName;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    private IdHasher _idHasher = null!;
    private IdHasherGetTypeName _idHasherGetTypeName = null!;

    [GlobalSetup]
    public void Setup()
    {
        _idHasher = new IdHasher();
        _idHasherGetTypeName = new IdHasherGetTypeName();
    }

    [Benchmark]
    public string BaseLine() => _idHasher.Encode(100);

    [Benchmark]
    public string GetTypeName() => _idHasherGetTypeName.Encode<DummyDto>(100);
}
