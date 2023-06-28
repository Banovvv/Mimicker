using Mimicker.Internal.Abstractions;

namespace Mimicker.Internal
{
    public class MimickingContainer : IMimickingContainer
    {
        public ICustomizableMimickingContainer Configure()
        {
            throw new NotImplementedException();
        }

        public IMimickingResolver CreateScope()
        {
            throw new NotImplementedException();
        }

        public T Resolve<T>()
        {
            throw new NotImplementedException();
        }
    }
}
