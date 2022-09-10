using UnityEngine;

namespace Auxtensions
{
    /// <summary>
    /// Int extensions which provide additional functionality for <see cref="int"/> typed variables.
    /// </summary>
    public static class IntExtensions
    {
        #region Mathf Functions

        /// <summary>
        /// Calculates the absolute value of this <see cref="int"/>.
        /// </summary>
        /// <param name="value">
        /// This <see cref="int"/> value.
        /// </param>
        /// <returns>
        /// The absolute value.
        /// </returns>
        public static int Abs(this int value) 
            => Mathf.Abs(value);

        /// <summary>
        /// Gets the closest power of 2 to this <see cref="int"/> value.
        /// </summary>
        /// <param name="value">
        /// This <see cref="int"/> value.
        /// </param>
        /// <returns>
        /// The closest power of 2.
        /// </returns>
        public static int ClosestPowerOfTwo(this int value) 
            => Mathf.ClosestPowerOfTwo(value);
        
        /// <summary>
        /// Checks to see if this <see cref="int"/> value is a power of 2.
        /// </summary>
        /// <param name="value">
        /// This <see cref="int"/> value.
        /// </param>
        /// <returns>
        /// <c>True</c> if this <see cref="int"/> is a power of 2, otherwise <c>false</c>.
        /// </returns>
        public static bool IsPowerOfTwo(this int value) 
            => Mathf.IsPowerOfTwo(value);
        
        /// <summary>
        /// Gets the next power of 2 that is either greater than or equal to this <see cref="int"/>.
        /// </summary>
        /// <param name="value">
        /// This <see cref="int"/> value.
        /// </param>
        /// <returns>
        /// A power of 2.
        /// </returns>
        public static int NextPowerOfTwo(this int value) 
            => Mathf.NextPowerOfTwo(value);

        #endregion

        #region Custom Functions

        /// <summary>
        /// Checks to see if this <see cref="int"/> is within a <see cref="min"/> and <see cref="max"/> <see cref="int"/> range.
        /// </summary>
        /// <param name="value">
        /// This <see cref="int"/> value.
        /// </param>
        /// <param name="min">
        /// The minimum <see cref="int"/> range.
        /// </param>
        /// <param name="max">
        /// The maximum <see cref="int"/> range.
        /// </param>
        /// <param name="inclusive">
        /// (Optional) If <c>true</c>, this <see cref="value"/> will be compared with "or-equal-to" operators.
        /// </param>
        /// <returns>
        /// Whether or not this <see cref="value"/> is within the given <see cref="min"/> and <see cref="max"/> range.
        /// </returns>
        public static bool IsInsideRange(this int value, int min, int max, bool inclusive = true) 
            => inclusive ? value >= min && value <= max : value > min && value < max;
        
        /// <summary>
        /// Checks to see if this <see cref="int"/> is outside of a <see cref="min"/> and <see cref="max"/> <see cref="int"/> range.
        /// </summary>
        /// <param name="value">
        /// This <see cref="int"/> value.
        /// </param>
        /// <param name="min">
        /// The minimum <see cref="int"/> range.
        /// </param>
        /// <param name="max">
        /// The maximum <see cref="int"/> range.
        /// </param>
        /// <param name="inclusive">
        /// (Optional) If <c>true</c>, this <see cref="value"/> will be compared with "or-equal-to" operators.
        /// </param>
        /// <returns>
        /// Whether or not this <see cref="value"/> is outside of the given <see cref="min"/> and <see cref="max"/> range.
        /// </returns>
        public static bool IsOutsideRange(this int value, int min, int max, bool inclusive = false)
            => inclusive ? value <= min || value >= max : value < min && value > max;

        #endregion
    }
}