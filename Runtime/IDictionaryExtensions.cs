using System;
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
        [Obsolete("Use RandomKeyOrDefault() or RandomValueOrDefault()")]
        public static K RandomOrDefault<T, K>(this IDictionary<T, K> value)
            => value.RandomValueOrDefault();

        public static K RandomValueOrDefault<T, K>(this IDictionary<T, K> dictionary)
            => dictionary.Count > 0 ? dictionary[dictionary.Keys.RandomOrDefault()] : default;

        public static T RandomKeyOrDefault<T, K>(this IDictionary<T, K> dictionary)
            => dictionary.Count > 0 ? dictionary.Keys.RandomOrDefault() : default;
    }
}