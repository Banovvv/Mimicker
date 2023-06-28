namespace Mimicker.Internal
{
    /// <summary>
    /// Enumeration defining the lifetime of Mimicking DI
    /// </summary>
    public enum Lifetime
    {
        /// <summary>
        /// New instance is created only once.
        /// </summary>
        Singleton,
        /// <summary>
        /// New instance is created once for each different scope.
        /// </summary>
        Scoped,
        /// <summary>
        /// New instance is create every time.
        /// </summary>
        Transient
    }
}
