using HashidsNet;

namespace GetGenericTypeName;

public class IdHasher
{
    private readonly Hashids hashids;

    public IdHasher()
    {
        hashids = new Hashids(
            "DummyDto",
            11);
    }

    public string Encode(int id)
    {
        return hashids.Encode(id);
    }

    public string? Encode(int? id)
    {
        if (id is null) return null;

        return hashids.Encode(id.Value);
    }

    public int Decode(string hash)
    {
        return hashids.DecodeSingle(hash);
    }

    public bool TryDecode(string hash, out int id)
    {
        return hashids.TryDecodeSingle(hash, out id);
    }
}
