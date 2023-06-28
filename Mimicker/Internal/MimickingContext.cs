using Mimicker.Internal.Abstractions;

namespace Mimicker.Internal
{
    public class MimickingContext : IMimickingContext
    {
        public static IMimickingContext Context { get; }

        public IMimickingFactory MimickingFactory => throw new NotImplementedException();

        static MimickingContext()
        {
            throw new NotImplementedException();
            // Context = ?
        }
    }
}
