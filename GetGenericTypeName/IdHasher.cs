using HashidsNet;

namespace GetGenericTypeName;

public class IdHasher
{
    public string Encode(int id)
    {
        var hashids = CreateInstance();

        return hashids.Encode(id);
    }

    private static Hashids CreateInstance()
    {
        return new Hashids(
            "DummyDto",
            11);
    }
}
