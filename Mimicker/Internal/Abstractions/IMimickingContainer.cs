namespace Mimicker.Internal.Abstractions
{
    public interface IMimickingContainer : IMimickingResolver
    {
        IMimickingResolver CreateScope();
        ICustomizableMimickingContainer Configure();
    }
}
