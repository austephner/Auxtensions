using System.Collections.Generic;
using UnityEngine;

namespace Auxtensions
{
    public static class GameObjectExtensions
    {
        /// <summary>
        /// Instantiates a new <see cref="GameObject"/> based on this one.
        /// </summary>
        /// <param name="prefab">
        /// This <see cref="GameObject"/>.
        /// </param>
        /// <returns>
        /// The instantiated <see cref="GameObject"/>.
        /// </returns>
        public static GameObject Instantiate(this GameObject prefab)
        {
            return Object.Instantiate(prefab);
        }

        /// <summary>
        /// Instantiates a new <see cref="GameObject"/> based on this one, assigning its parent to the given
        /// <see cref="parent"/> <see cref="Transform"/>.
        /// </summary>
        /// <param name="prefab">
        /// This <see cref="GameObject"/>.
        /// </param>
        /// <param name="parent">
        /// The <see cref="Transform"/> to parent the instantiated <see cref="GameObject"/> to.
        /// </param>
        /// <returns>
        /// The instantiated <see cref="GameObject"/>.
        /// </returns>
        public static GameObject Instantiate(this GameObject prefab, Transform parent)
        {
            return Object.Instantiate(prefab, parent);
        }

        /// <summary>
        /// Instantiates a new <see cref="GameObject"/> based on this one, assigning its parent to the given
        /// <see cref="parent"/> <see cref="Transform"/>. Instead of returning the <see cref="GameObject"/>, the
        /// component specified by <see cref="T"/> will be returned with <c>GetComponent()</c>.
        /// </summary>
        /// <param name="gameObject">
        /// This <see cref="GameObject"/> (often a prefab) that should be instantiated and returned of type
        /// <see cref="T"/>.
        /// </param>
        /// <param name="parent">
        /// The <see cref="Transform"/> to parent the instantiated <see cref="GameObject"/> to.
        /// </param>
        /// <returns>
        /// The instantiated <see cref="GameObject"/>.
        /// </returns>
        public static T Instantiate<T>(this GameObject gameObject, Transform parent) where T : Component
        {
            return Object.Instantiate(gameObject, parent).GetComponent<T>();
        }

        /// <summary>
        /// Attempts to get a component <see cref="T"/> from this <see cref="GameObject"/>.
        /// </summary>
        /// <param name="gameObject">
        /// This <see cref="GameObject"/>.
        /// </param>
        /// <param name="component">
        /// The outward <see cref="Component"/> of type <see cref="T"/> if successful.
        /// </param>
        /// <typeparam name="T">
        /// The <see cref="Component"/> type to retrieve.
        /// </typeparam>
        /// <returns>
        /// <c>True</c> if a <see cref="Component"/> was successfully gotten from this <see cref="GameObject"/>.
        /// </returns>
        public static bool TryGetComponent<T>(this GameObject gameObject, out T component) where T : Component
        {
            return component = gameObject.GetComponent<T>();
        }
        
        /// <summary>
        /// Destroys each <see cref="GameObject"/> of every component in this <see cref="IList{T}"/>.
        /// </summary>
        /// <param name="objects">
        /// The <see cref="IList{T}"/> of objects to destroy.
        /// </param>
        /// <param name="destroyImmediate">
        /// Whether or not to use <c>DestroyImmediate()</c> or <c>Destroy()</c>.
        /// </param>
        /// <typeparam name="T">
        /// The <see cref="Component"/> type of this <see cref="IList{T}"/>.
        /// </typeparam>
        public static void DestroyAll<T>(this IList<T> objects, bool destroyImmediate = false) where T : Component
        {
            for (int i = objects.Count - 1; i >= 0; i--)
            {
                if (destroyImmediate) Object.DestroyImmediate(objects[i].gameObject);
                else Object.Destroy(objects[i].gameObject);
            }

            objects.Clear();
        }
    }
}