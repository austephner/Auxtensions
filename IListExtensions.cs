using System;
using System.Collections.Generic;

namespace Auxtensions
{
    /// <summary>
    /// List extensions which provide additional functionality for <see cref="IList{T}"/> collections.
    /// </summary>
    public static class IListExtensions
    {
        /// <summary>
        ///     Adds an <see cref="IList{T}"/> onto the end of this <see cref="IList{T}"/>.
        /// </summary>
        /// <param name="list">
        ///     This <see cref="IList{T}"/>.
        /// </param>
        /// <param name="append">
        ///     The <see cref="IList{T}"/> of items to append.
        /// </param>
        /// <typeparam name="T">
        ///     The type.
        /// </typeparam>
        /// <returns>
        ///     This original <see cref="IList{T}"/> but with all items appended from the given <see cref="IList{T}"/> <see cref="append"/>.
        /// </returns>
        public static IList<T> Append<T>(this IList<T> list, IList<T> append)
        {
            for (int i = 0; i < append.Count; i++)
            {
                list.Add(append[i]);
            }

            return list;
        }

        /// <summary>
        ///     Gets and removes the first element of this <see cref="IList{T}"/>. 
        /// </summary>
        /// <param name="list">
        ///     This <see cref="IList{T}"/>.
        /// </param>
        /// <typeparam name="T">
        ///     The type.
        /// </typeparam>
        /// <returns>
        ///     The first element of this <see cref="IList{T}"/>.
        /// </returns>
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

        /// <summary>
        ///     Gets a random element from this <see cref="IList{T}"/>.
        /// </summary>
        /// <param name="list">
        ///     This <see cref="IList{T}"/>.
        /// </param>
        /// <typeparam name="T">
        ///     The type.
        /// </typeparam>
        /// <returns>
        ///     A random element.
        /// </returns>
        public static T GetRandom<T>(this IList<T> list)
        {
            return list == null || list.Count == 0 
                ? default 
                : list[UnityEngine.Random.Range(0, list.Count)];
        }

        /// <summary>
        ///     Gets a random element from this <see cref="IList{T}"/> using a <see cref="Func{TResult, TFloat}"/> function to get an element's <see cref="float"/> weight.
        /// </summary>
        /// <param name="list">
        ///     This <see cref="IList{T}"/>.
        /// </param>
        /// <param name="getWeight">
        ///     A function to check the weight of the given item.
        /// </param>
        /// <typeparam name="T">
        ///     The type.
        /// </typeparam>
        /// <returns>
        ///     A random element.
        /// </returns>
        public static T GetRandomByWeight<T>(this IList<T> list, Func<T, float> getWeight)
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
        
        /// <summary>
        ///     Moves each element of this <see cref="IList{T}"/> to a random index.
        /// </summary>
        /// <param name="list">
        ///     This <see cref="IList{T}"/>.
        /// </param>
        /// <typeparam name="T">
        ///     The type.
        /// </typeparam>
        /// <returns>
        ///     This <see cref="IList{T}"/>.
        /// </returns>
        public static void Shuffle<T>(this IList<T> list)
        {
            for (var i = list.Count; i > 1; i--)
            {
                var randomIndex = UnityEngine.Random.Range(0, i + 1);
                var randomValue = list[randomIndex];
                list[randomIndex] = list[i];
                list[i] = randomValue;
            }
        }
        
        /// <summary>
        ///     Moves each element of this <see cref="IList{T}"/> to a random index. This will not create a new list, it'll assign the positions to within itself.
        /// </summary>
        /// <param name="list">
        ///     This <see cref="IList{T}"/>.
        /// </param>
        /// <typeparam name="T">
        ///     The type.
        /// </typeparam>
        /// <returns>
        ///     This <see cref="IList{T}"/>.
        /// </returns>
        public static IList<T> ShuffleToNew<T>(this IList<T> list)
        {
            var result = new List<T>(list);
            
            for (var i = list.Count; i > 1; i--)
            {
                var randomIndex = UnityEngine.Random.Range(0, i + 1);
                var randomValue = result[randomIndex];
                result[randomIndex] = result[i];
                result[i] = randomValue;
            }

            return result;
        }
    }
}