using System.Collections.Generic;

namespace Auxtensions
{
    /// <summary>
    /// Set of generic extensions for types in relation to other classes/types.
    /// </summary>
    public static class GenericExtensions
    {
        /// <summary> Checks to see whether or not this <see cref="value"/> is contained within the given <see cref="List{T}"/>. </summary>
        /// <param name="value">This <see cref="value"/>.</param>
        /// <param name="list">The <see cref="IList{T}"/> to check if this <see cref="value"/> is contained within.</param>
        /// <typeparam name="T">The type.</typeparam>
        /// <returns><c>true</c> if the <see cref="value"/> is contained within the <see cref="List{T}"/>.</returns>
        public static bool IsContainedIn<T>(this T value, IList<T> list)
            => list.Contains(value);
    }
}