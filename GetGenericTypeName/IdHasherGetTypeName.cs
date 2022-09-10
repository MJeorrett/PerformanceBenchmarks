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

    private static Hashids CreateInstance<T>()
    {
        var typeName = typeof(T).Name;

        return new Hashids(
            $"HimalayanMountain:{typeName}",
            11);
    }
}
