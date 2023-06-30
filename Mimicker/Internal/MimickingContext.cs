using Mimicker.Internal.Abstractions;
using Mimicker.Internal.Factories;

namespace Mimicker.Internal
{
    public class MimickingContext : IMimickingContext
    {
        public static IMimickingContext Context { get; }

        public IMimickingFactory MimickingFactory => throw new NotImplementedException();

        static MimickingContext()
        {
            Context = DefaultMimickingFactory.InitializeMimickingContext();
        }
    }
}
