using Mimicker.Abstractions;

namespace Mimicker
{
    /// <summary>
    /// <para>Create a mimic for a specified type.</para>
    /// <para>Example usage: <c>Mimic.This&lt;IRandomInterface&gt;()</c></para>
    /// </summary>
    public class Mimic : IMimic
    {
        /// <summary>
        /// A mimic for an interface.
        /// </summary>
        /// <param name="type">The type of interface to mimic.</param>
        /// <returns>A mimic implementing the specified interface type.</returns>
        public object This(Type type)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mimic for an interface.
        /// </summary>
        /// <typeparam name="T">The type of interface to mimic.</typeparam>
        /// <returns>A mimic implementing the specified interface type.</returns>
        public T This<T>() => (T)This(typeof(T));
    }
}