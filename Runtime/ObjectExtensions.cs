using System.Collections;
using UnityEngine;

namespace Auxtensions
{
    /// <summary>
    /// Object extensions which provide additional functionality for <see cref="object"/> and Unity's <see cref="Object"/> types.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary> Uses the <see cref="JsonUtility"/> class to quickly convert this <see cref="object"/> into JSON. </summary>
        /// <param name="value"> This <see cref="object"/> to convert to JSON. </param>
        /// <param name="prettyPrint"> When true, enables formatting for easily reading the result JSON. </param>
        /// <returns> JSON <see cref="string"/>. </returns>
        public static string ToJson(this object value, bool prettyPrint = false) 
            => JsonUtility.ToJson(value, prettyPrint);

        /// <summary>
        /// Checks to see if this <see cref="value"/> is contained in the given <see cref="IList"/>.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="list"></param>
        /// <returns><c>true</c> if the item is contained in the list, <c>false</c> if it is not.</returns>
        public static bool IsContainedIn(this object value, IList list) 
            => list.Contains(value);
    }
}