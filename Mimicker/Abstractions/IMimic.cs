namespace Mimicker.Abstractions
{
    public interface IMimic
    {
        T This<T>();
        object This(Type type);
    }
}
