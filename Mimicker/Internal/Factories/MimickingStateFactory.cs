using Mimicker.Internal.Abstractions;

namespace Mimicker.Internal.Factories
{
    public class MimickingStateFactory : IMimickingStateFactory
    {
        private readonly IMimickingState _state;

        public MimickingStateFactory(IMimickingState state)
        {
            _state = state;
        }

        public IMimickingState Initialize(IMimickingFactory factory)
        {
            throw new NotImplementedException();
        }
    }
}
