using UnityEngine;

namespace Flintex
{
    /// <summary>
    /// Float extensions which provide additional functionality for <c>float</c> typed variables.
    /// </summary>
    // todo: add function attributes similar to Mathf functions such as [FreeFunction(IsThreadSafe = true)]
    public static class FloatExtensions
    {
        /// <summary>
        ///     Rounds this <see cref="float"/> to an <see cref="int"/> using <see cref="Mathf.RoundToInt"/>.
        /// </summary>
        /// <param name="value">
        ///     This <see cref="float"/> value.
        /// </param>
        /// <returns>
        ///     A rounded <see cref="int"/>.
        /// </returns>
        /// <example>
        ///     (1.8215f).RoundToInt()
        /// </example>
        public static int RoundToInt(this float value) => Mathf.RoundToInt(value);

        /// <summary>
        ///     Rounds this <see cref="float"/> down to an <see cref="int"/> using <see cref="Mathf.FloorToInt"/>.
        /// </summary>
        /// <param name="value">
        ///     This <see cref="float"/> value.
        /// </param>
        /// <returns>
        ///     A rounded <see cref="int"/>.
        /// </returns>
        /// <example>
        ///     (1.8215f).FloorToInt()
        /// </example>
        public static int FloorToInt(this float value) => Mathf.FloorToInt(value);

        /// <summary>
        ///     Rounds this <see cref="float"/> up to an <see cref="int"/> using <see cref="Mathf.CeilToInt"/>.
        /// </summary>
        /// <param name="value">
        ///     This <see cref="float"/> value.
        /// </param>
        /// <returns>
        ///     A rounded <see cref="int"/>.
        /// </returns>
        /// <example>
        ///     (1.8215f).CeilToInt()
        /// </example>
        public static int CeilToInt(this float value) => Mathf.CeilToInt(value);

        /// <summary>
        ///     Multiplies this <see cref="float"/> with itself, effectively squaring it.
        /// </summary>
        /// <param name="value">
        ///     This <see cref="float"/> value.
        /// </param>
        /// <returns>
        ///     A squared <see cref="float"/>.
        /// </returns>
        /// <example>
        ///     (1.8215f).Square()
        /// </example>
        public static float Square(this float value) => value * value;

        /// <summary>
        ///     Raises this <see cref="float"/> to the given <see cref="power"/> using <see cref="Mathf.Pow"/>.
        /// </summary>
        /// <param name="value">
        ///     This <see cref="float"/> value.
        /// </param>
        /// <param name="power">
        ///     The power to raise this <see cref="float"/> value to.
        /// </param>
        /// <returns>
        ///     A squared <see cref="float"/>.
        /// </returns>
        /// <example>
        ///     (1.8215f).Pow(5)
        /// </example>
        public static float Pow(this float value, float power) => Mathf.Pow(value, power);

        /// <summary>
        ///     Calculates the square root of this <see cref="float"/> using <see cref="Mathf.Sqrt"/>.
        /// </summary>
        /// <param name="value">
        ///     This <see cref="float"/> value.
        /// </param>
        /// <returns>
        ///     The square of this <see cref="float"/> value.
        /// </returns>
        /// <example>
        ///     (1.8215f).Sqrt()
        /// </example>
        public static float Sqrt(this float value) => Mathf.Sqrt(value);
    }
}