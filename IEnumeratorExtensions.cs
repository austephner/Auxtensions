using System;
using System.Collections;

namespace Auxtensions
{
    /// <summary>
    /// Enumerator extensions which provide additional functionality for <see cref="IEnumerator"/> coroutines.
    /// </summary>
    public static class IEnumeratorExtensions
    {
        /// <summary>
        ///     Iterates over this <see cref="IEnumerator"/> then iterates over the given <see cref="IEnumerator"/>.
        /// </summary>
        /// <param name="enumerator">
        ///     This <see cref="IEnumerator"/>.
        /// </param>
        /// <param name="run">
        ///     The subsequent <see cref="IEnumerator"/> to iterate over.
        /// </param>
        public static IEnumerator Then(this IEnumerator enumerator, IEnumerator run)
        {
            yield return enumerator;
            yield return run;
        }

        /// <summary>
        ///     Iterates over this <see cref="IEnumerator"/> then invokes the given <see cref="Action"/>.
        /// </summary>
        /// <param name="enumerator">
        ///     This <see cref="IEnumerator"/>.
        /// </param>
        /// <param name="action">
        ///     The subsequent <see cref="Action"/> to invoke.
        /// </param>
        public static IEnumerator Then(this IEnumerator enumerator, Action action)
        {
            yield return enumerator;
            action?.Invoke();
        }
    }
}