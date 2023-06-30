namespace Mimicker.Internal.Abstractions
{
    public interface IMimickingStateFactory
    {
        IMimickingState Initialize(IMimickingFactory factory);
    }
}
