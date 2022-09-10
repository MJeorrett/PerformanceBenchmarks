using HashidsNet;

namespace GetGenericTypeName;

public class IdHasherGetTypeName
{
    public IdHasherGetTypeName()
    {
    }

    public string Encode<T>(int id)
    {
        var hashids = CreateInstance<T>();
        return hashids.Encode(id);
    }

    public string? Encode<T>(int? id)
    {
        if (id is null) return null;

        return Encode<T>(id);
    }

    public int Decode<T>(string hash)
    {
        var hashids = CreateInstance<T>();

        return hashids.DecodeSingle(hash);
    }

    public bool TryDecode<T>(string hash, out int id)
    {
        var hashids = CreateInstance<T>();

        return hashids.TryDecodeSingle(hash, out id);
    }

    private static Hashids CreateInstance<T>()
    {
        var typeName = typeof(T).Name;

        return new Hashids(
            $"HimalayanMountain:{typeName}",
            11);
    }
}
