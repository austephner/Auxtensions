using UnityEngine;

namespace Auxtensions
{
    public static class GameObjectExtensions
    {
        /// <summary>
        ///     Instantiates a new <see cref="GameObject"/> based on this one.
        /// </summary>
        /// <param name="prefab">
        ///     This <see cref="GameObject"/>.
        /// </param>
        /// <returns>
        ///     The instantiated <see cref="GameObject"/>.
        /// </returns>
        public static GameObject Instantiate(this GameObject prefab)
        {
            return Object.Instantiate(prefab);
        }

        /// <summary>
        ///     Instantiates a new <see cref="GameObject"/> based on this one, assigning its parent to the given
        ///     <see cref="parent"/> <see cref="Transform"/>.
        /// </summary>
        /// <param name="prefab">
        ///     This <see cref="GameObject"/>.
        /// </param>
        /// <param name="parent">
        ///     The <see cref="Transform"/> to parent the instantiated <see cref="GameObject"/> to.
        /// </param>
        /// <returns>
        ///     The instantiated <see cref="GameObject"/>.
        /// </returns>
        public static GameObject Instantiate(this GameObject prefab, Transform parent)
        {
            return Object.Instantiate(prefab, parent);
        }

        /// <summary>
        ///     Attempts to get a component <see cref="T"/> from this <see cref="GameObject"/>.
        /// </summary>
        /// <param name="gameObject">
        ///     This <see cref="GameObject"/>.
        /// </param>
        /// <param name="component">
        ///     The outward <see cref="Component"/> of type <see cref="T"/> if successful.
        /// </param>
        /// <typeparam name="T">
        ///     The <see cref="Component"/> type to retrieve.
        /// </typeparam>
        /// <returns>
        ///     <c>True</c> if a <see cref="Component"/> was successfully gotten from this <see cref="GameObject"/>.
        /// </returns>
        public static bool TryGetComponent<T>(this GameObject gameObject, out T component) where T : Component
        {
            return component = gameObject.GetComponent<T>();
        }
    }
}