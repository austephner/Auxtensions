using System.Collections.Generic;

namespace Auxtensions
{
    public static class IDictionaryExtensions
    {
        /// <summary>
        /// Gets a random element from the dictionary or default if the dictionary's length is 0.
        /// </summary>
        /// <param name="value">This <see cref="IDictionary{TKey,TValue}"/>.</param>
        /// <typeparam name="T">The key type.</typeparam>
        /// <typeparam name="K">The value type.</typeparam>
        /// <returns>An element or default value.</returns>
        public static K RandomOrDefault<T, K>(this IDictionary<T, K> value)
            => value.Count > 0 ? value[value.Keys.RandomOrDefault()] : default;
    }
}