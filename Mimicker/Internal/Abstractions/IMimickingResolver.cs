namespace Mimicker.Internal.Abstractions
{
    public interface IMimickingResolver
    {
        T Resolve<T>();
    }
}
