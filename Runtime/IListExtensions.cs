using System;
using System.Collections.Generic;
using UnityEngine;

namespace Auxtensions
{
    /// <summary>
    /// List extensions which provide additional functionality for <see cref="IList{T}"/> collections.
    /// </summary>
    public static class IListExtensions
    {
        #region Generic Lists
        
        /// <summary> Adds an <see cref="IList{T}"/> onto the end of this <see cref="IList{T}"/>. </summary>
        /// <param name="list"> This <see cref="IList{T}"/>. </param>
        /// <param name="append"> The <see cref="IList{T}"/> of items to append. </param>
        /// <typeparam name="T"> The type. </typeparam>
        /// <returns> This original <see cref="IList{T}"/> but with all items appended from the given <see cref="IList{T}"/> <see cref="append"/>. </returns>
        public static IList<T> Append<T>(this IList<T> list, IList<T> append)
        {
            for (int i = 0; i < append.Count; i++)
            {
                list.Add(append[i]);
            }

            return list;
        }

        /// <summary> Gets and removes the first element of this <see cref="IList{T}"/>, similar to a <see cref="Queue{T}"/>'s behaviour. </summary>
        /// <param name="list"> This <see cref="IList{T}"/>. </param>
        /// <typeparam name="T"> The type. </typeparam>
        /// <returns> The first element of this <see cref="IList{T}"/>. </returns>
        public static T Dequeue<T>(this IList<T> list)
        {
            if (list == null || list.Count == 0)
            {
                return default;
            }
            
            var firstItem = list[0];

            list.RemoveAt(0);

            return firstItem;
        }

        /// <summary> Gets a random element from this <see cref="IList{T}"/>. </summary>
        /// <param name="list"> This <see cref="IList{T}"/>. </param>
        /// <typeparam name="T"> The type. </typeparam>
        /// <returns> A random element. </returns>
        public static T Random<T>(this IList<T> list)
        {
            return list[UnityEngine.Random.Range(0, list.Count)];
        }

        /// <summary> Gets a random element from this <see cref="IList{T}"/> if possible, otherwise returns the default of <see cref="T"/>. </summary>
        /// <param name="list"> This <see cref="IList{T}"/>. </param>
        /// <typeparam name="T"> The type. </typeparam>
        /// <returns> A random element. </returns>
        public static T RandomOrDefault<T>(this IList<T> list)
        {
            return list == null || list.Count == 0 
                ? default 
                : list[UnityEngine.Random.Range(0, list.Count)];
        }

        /// <summary> Gets a random element from this <see cref="IList{T}"/> based on its <see cref="float"/> weight. </summary>
        /// <param name="list"> This <see cref="IList{T}"/>. </param>
        /// <param name="getWeight"> A function to check the weight of the given item. </param>
        /// <typeparam name="T"> The type. </typeparam>
        /// <returns> A random element. </returns>
        public static T RandomByWeight<T>(this IList<T> list, Func<T, float> getWeight)
        {
            var accumulatedWeights = new List<float>();
            var totalWeight = 0.0f;

            // calculate weight
            
            for (int i = 0; i < list.Count; i++)
            {
                totalWeight += getWeight?.Invoke(list[i]) ?? 0.0f;
                accumulatedWeights.Add(totalWeight);
            }
            
            // choose a value based on weight

            var random = UnityEngine.Random.value * totalWeight;

            for (int i = 0; i < list.Count; i++)
            {
                if (accumulatedWeights[i] >= random)
                {
                    return list[i];
                }
            }

            return default;
        }
        
        /// <summary> Remove items using a <see cref="Func{T1, T2}"/> to filter them out. </summary>
        /// <param name="list"> This <see cref="IList{T}"/>. </param>
        /// <param name="where"> The filter function. </param>
        /// <typeparam name="T"> The type. </typeparam>
        public static void RemoveWhere<T>(this IList<T> list, Func<T, bool> where)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (where?.Invoke(list[i]) == true)
                {
                    list.RemoveAt(i);
                }
            }
        }
        
        /// <summary> Rearranges all elements of this <see cref="IList{T}"/> with random ordering. </summary>
        /// <param name="list"> This <see cref="IList{T}"/>. </param>
        /// <typeparam name="T"> The type. </typeparam>
        /// <returns>Returns itself to make chaining functions easier.</returns>
        public static IList<T> Shuffle<T>(this IList<T> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list.SwapElementsAt(i, UnityEngine.Random.Range(0, list.Count));
            }

            return list;
        }
        
        /// <summary> Rearranges all elements of this <see cref="IList{T}"/> into a new <see cref="IList{T}"/>. </summary>
        /// <param name="list"> This <see cref="IList{T}"/>. </param>
        /// <typeparam name="T"> The type. </typeparam>
        /// <returns> A new <see cref="IList{T}"/> with randomly ordered items from this <see cref="IList{T}"/>. </returns>
        public static IList<T> ShuffleToNew<T>(this IList<T> list)
        {
            var result = new List<T>(list);

            for (int i = 0; i < list.Count; i++)
            {
                result.SwapElementsAt(i, UnityEngine.Random.Range(0, result.Count));
            }

            return result;
        }

        /// <summary>
        /// Replaces an element at the <see cref="fromIndex"/> with the element at the <see cref="toIndex"/>.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="fromIndex"></param>
        /// <param name="toIndex"></param>
        /// <typeparam name="T"></typeparam>
        public static void SwapElementsAt<T>(this IList<T> list, int fromIndex, int toIndex)
        {
            (list[toIndex], list[fromIndex]) = (list[fromIndex], list[toIndex]);
        }
        
        /// <summary> Performs a simple <c>foreach(...)</c>, invoking the given <see cref="Action"/> for each element. </summary>
        /// <param name="list">This <see cref="IEnumerable{T}"/></param>
        /// <param name="action">The <see cref="Action"/> to invoke.</param> 
        /// <typeparam name="T">The type.</typeparam>
        public static void ForEach<T>(this IList<T> list, Action<T> action)
        {
            // a for loop can be used here instead of foreach (more performant)
            for (var i = 0; i < list.Count; i++)
            {
                action?.Invoke(list[i]);
            }
        }
        
        /// <summary> Creates a new <see cref="IList{T}"/> out of the given <see cref="value"/>. </summary>
        /// <param name="value">This <see cref="IList{T}"/>.</param>
        /// <typeparam name="T">The type.</typeparam>
        /// <returns>A new <see cref="IList{T}"/>.</returns>
        public static List<T> Clone<T>(this List<T> value)
        {
            var result = new List<T>();

            for (int i = 0; i < value.Count; i++)
            {
                result.Add(value[i]);
            }
            
            return result;
        }

        /// <summary> Adds all elements from <see cref="concat"/> to this <see cref="List{T}"/>. </summary>
        /// <param name="list">This <see cref="IList{T}"/>.</param>
        /// <param name="concat">The <see cref="IList{T}"/> to concatenate.</param>
        /// <typeparam name="T">The type.</typeparam>
        /// <returns>This <see cref="IList{T}"/> with all elements from <see cref="concat"/>.</returns>
        public static IList<T> Concatenate<T>(this IList<T> list, IList<T> concat)
        {
            for (int i = 0; i < concat.Count; i++)
            {
                list.Add(concat[i]);
            }

            return list;
        }
        
        #endregion

        #region Type Based Lists

        /// <summary> Calculates the average value given a list of <see cref="Vector3"/>. </summary>
        /// <param name="list">This <see cref="IList{T}"/>.</param>
        /// <returns>The average <see cref="Vector3"/>.</returns>
        public static Vector3 Average(this IList<Vector3> list)
        {
            var result = new Vector3();

            for (int i = 0; i < list.Count; i++)
            {
                result += list[i];
            }
            
            return result / list.Count;
        }
        
        /// <summary> Calculates the average value given a list of <see cref="Vector2"/>. </summary>
        /// <param name="list">This <see cref="IList{T}"/>.</param>
        /// <returns>The average <see cref="Vector2"/>.</returns>
        public static Vector2 Average(this IList<Vector2> list)
        {
            var result = new Vector2();

            for (int i = 0; i < list.Count; i++)
            {
                result += list[i];
            }
            
            return result / list.Count;
        }
        
        /// <summary> Calculates the average value given a list of <see cref="float"/>. </summary>
        /// <param name="list">This <see cref="IList{T}"/>.</param>
        /// <returns>The average <see cref="float"/>.</returns>
        public static float Average(this IList<float> list)
        {
            var result = new float();

            for (int i = 0; i < list.Count; i++)
            {
                result += list[i];
            }
            
            return result / list.Count;
        }
        
        /// <summary> Calculates the average value given a list of <see cref="int"/>. </summary>
        /// <param name="list">This <see cref="IList{T}"/>.</param>
        /// <returns>The average <see cref="int"/>.</returns>
        public static int Average(this IList<int> list)
        {
            var result = new int();

            for (int i = 0; i < list.Count; i++)
            {
                result += list[i];
            }
            
            return result / list.Count;
        }

        #endregion
    }
}