using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Auxtensions
{
    /// <summary>
    /// Object extensions which provide additional functionality for <see cref="object"/> and Unity's <see cref="UnityEngine.Object"/> types.
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
        
        /// <summary>
        /// Destroys this object so you don't have to call Object.Destroy(...).
        /// </summary>
        /// <param name="obj">This <see cref="Object"/></param>
        public static void DestroySelf(this Object obj) 
            => Object.Destroy(obj);

        /// <summary>
        /// Destroys elements in <see cref="objects"/> that match the <see cref="condition"/>.
        /// </summary>
        /// <param name="objects">This set of <see cref="Object"/></param>
        /// <param name="condition">The <see cref="Func{TParam,TResult}"/> condition. If <c>true</c> is returned, the
        /// object will be destroyed.</param>
        /// <typeparam name="T">The type.</typeparam>
        public static void DestroyWhere<T>(this IEnumerable<T> objects, Func<T, bool> condition) where T : Object
        {
            foreach (var obj in objects)
            {
                if (condition?.Invoke(obj) == true) Object.Destroy(obj);
            }
        }
    }
}