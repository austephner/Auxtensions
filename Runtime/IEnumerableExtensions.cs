using System.Collections.Generic;
using System.Linq;

namespace Auxtensions
{
    /// <summary>
    /// Enumerable extensions which provide additional functionality for <see cref="IEnumerable{T}"/> data structures.
    /// Please note that these extensions functions use <see cref="Linq"/> and are not as performant. It's recommended
    /// to use <see cref="IList{T}"/> for enumerations instead.
    /// </summary>
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Gets a random element from this <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <param name="enumerable">
        /// This <see cref="IEnumerable{T}"/>.
        /// </param>
        /// <typeparam name="T">
        /// The type.
        /// </typeparam>
        /// <returns>
        /// A random element.
        /// </returns>
        public static T RandomOrDefault<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.ElementAtOrDefault(UnityEngine.Random.Range(0, enumerable.Count()));
        }

        /// <summary>
        /// Gets a random element from this <see cref="IEnumerable{T}"/> with the option to exclude any items from being chosen.
        /// </summary>
        /// <param name="enumerable">
        /// This <see cref="IEnumerable{T}"/>.
        /// </param>
        /// <param name="exclude">
        /// An <see cref="IEnumerable{T}"/> with elements that should be excluded from the random selection process.
        /// </param>
        /// <typeparam name="T">
        /// The type.
        /// </typeparam>
        /// <returns>
        /// A random element.
        /// </returns>
        public static T RandomOrDefault<T>(this IEnumerable<T> enumerable, IEnumerable<T> exclude)
        {
            return enumerable.Where(e => !exclude.Contains(e)).RandomOrDefault();
        }
    }
}