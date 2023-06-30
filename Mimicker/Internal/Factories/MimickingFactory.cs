using Mimicker.Internal.Abstractions;

namespace Mimicker.Internal
{
    /// <summary>
    /// Factory to create mimics
    /// </summary>
    public class MimickingFactory : IMimickingFactory
    {
        private readonly IMimickingStateFactory _stateFactory;

        public MimickingFactory(IMimickingStateFactory stateFactory)
        {
            _stateFactory = stateFactory;
        }

        /// <summary>
        /// Create a mimic for the given interface.
        /// </summary>
        /// <param name="type">The type of interface to mimic.</param>
        /// <returns>A mimic implementing the specified interface type.</returns>
        public object Initialize(Type type)
        {
            var mockingState = _stateFactory.Initialize(this);
            throw new NotImplementedException();
        }
    }
}
