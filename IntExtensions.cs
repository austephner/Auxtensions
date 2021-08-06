using UnityEngine;

namespace Flintor
{
    /// <summary>
    /// Int extensions which provide additional functionality for <see cref="int"/> typed variables.
    /// </summary>
    // todo: documentation
    public static class IntExtensions
    {
        #region Mathf Functions

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int Abs(this int value) => Mathf.Abs(value);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ClosestPowerOfTwo(this int value) => Mathf.ClosestPowerOfTwo(value);
        
        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsPowerOfTwo(this int value) => Mathf.IsPowerOfTwo(value);
        
        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int NextPowerOfTwo(this int value) => Mathf.NextPowerOfTwo(value);

        #endregion
    }
}