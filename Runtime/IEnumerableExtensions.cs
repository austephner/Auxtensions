using System;
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
        /// <summary> Gets a random element from this <see cref="IEnumerable{T}"/>. </summary>
        /// <param name="enumerable"> This <see cref="IEnumerable{T}"/>. </param>
        /// <typeparam name="T"> The type. </typeparam>
        /// <returns> A random element. </returns>
        public static T RandomOrDefault<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.ElementAtOrDefault(UnityEngine.Random.Range(0, enumerable.Count()));
        }

        /// <summary> Gets a random element from this <see cref="IEnumerable{T}"/> with the option to exclude any items from being chosen. </summary>
        /// <param name="enumerable"> This <see cref="IEnumerable{T}"/>. </param>
        /// <param name="exclude"> An <see cref="IEnumerable{T}"/> with elements that should be excluded from the random selection process. </param>
        /// <typeparam name="T"> The type. </typeparam>
        /// <returns> A random element. </returns>
        public static T RandomOrDefault<T>(this IEnumerable<T> enumerable, IEnumerable<T> exclude)
        {
            return enumerable.Where(e => !exclude.Contains(e)).RandomOrDefault();
        }

        /// <summary> Performs a simple <c>foreach(...)</c>, invoking the given <see cref="Action"/> for each element. </summary>
        /// <param name="enumerable">This <see cref="IEnumerable{T}"/></param>
        /// <param name="action">The <see cref="Action"/> to invoke.</param> 
        /// <typeparam name="T">The type.</typeparam>
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var element in enumerable) action?.Invoke(element);
        }

        /// <summary>
        /// Creates a new <see cref="Queue{T}"/> out of this <see cref="Enumerable"/>.
        /// </summary>
        /// <param name="enumerable">This <see cref="Enumerable"/></param>
        /// <typeparam name="T">The type.</typeparam>
        /// <returns>A new <see cref="Queue{T}"/></returns>
        public static Queue<T> ToQueue<T>(this IEnumerable<T> enumerable)
        {
            return new Queue<T>(enumerable);
        }
        
        /// <summary>
        /// Splits this <see cref="enumerable"/> into multiple <see cref="IEnumerable{T}"/> with a max length of
        /// <see cref="chunkSize"/>. 
        /// </summary>
        /// <param name="enumerable">This <see cref="IEnumerable{T}"/></param>
        /// <param name="chunkSize">The max number of elements per chunk.</param>
        /// <typeparam name="T">The type.</typeparam>
        /// <returns>An <see cref="IEnumerable{T}"/> of chunked <see cref="IEnumerable{T}"/>.</returns>
        /// <exception cref="ArgumentException">Chunk size must be greater than 0.</exception>
        public static IEnumerable<IEnumerable<T>> ChunkBy<T>(this IEnumerable<T> enumerable, int chunkSize)
        {
            if (chunkSize <= 0)
            {
                throw new ArgumentException("Chunk size must be greater than 0.");
            }

            while (enumerable.Any())
            {
                yield return enumerable.Take(chunkSize);
                enumerable = enumerable.Skip(chunkSize);
            }
        }
    }
}