namespace Mimicker.Internal.Abstractions
{
    public interface IMimicFactory
    {
        object Initialize(Type type);
    }
}
