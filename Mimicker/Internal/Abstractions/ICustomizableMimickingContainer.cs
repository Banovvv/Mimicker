namespace Mimicker.Internal.Abstractions
{
    public interface ICustomizableMimickingContainer : IMimickingContainer
    {
        ICustomizableMimickingContainer Register<TKey, TValue>(Lifetime lifetime)
            where TKey : notnull
            where TValue : TKey;

        ICustomizableMimickingContainer Register<T>(Func<IMimickingResolver, T> factory, Lifetime lifetime)
            where T : notnull;

        ICustomizableMimickingContainer Decorate<T>(Func<T, IMimickingResolver, T> factory)
            where T : notnull;
    }
}
