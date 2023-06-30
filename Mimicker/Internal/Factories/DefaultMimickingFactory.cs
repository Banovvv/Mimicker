using Mimicker.Internal.Abstractions;

namespace Mimicker.Internal.Factories
{
    public static class DefaultMimickingFactory
    {
        public static IMimickingContainer Container { get; }

        public static IMimickingContext InitializeMimickingContext()
        {
            throw new NotImplementedException();
        }

        private static IMimickingContainer InitializeContainer()
        {
            throw new NotImplementedException();
        }
    }
}
