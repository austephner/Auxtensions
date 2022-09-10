using UnityEngine;

namespace Auxtensions
{
    /// <summary>
    /// Object extensions which provide additional functionality for <see cref="object"/> and Unity's <see cref="Object"/> types.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary> Uses the <see cref="JsonUtility"/> class to quickly convert this <see cref="object"/> into JSON. </summary>
        /// <param name="object"> This <see cref="object"/> to convert to JSON. </param>
        /// <param name="prettyPrint"> When true, enables formatting for easily reading the result JSON. </param>
        /// <returns> JSON <see cref="string"/>. </returns>
        public static string ToJson(this object @object, bool prettyPrint = false)
        {
            return JsonUtility.ToJson(@object, prettyPrint);
        }
    }
}