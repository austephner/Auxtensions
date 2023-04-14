using UnityEngine;

namespace Auxtensions
{
    public static class QuaternionExtensions
    {
        /// <summary>
        /// Removes all "NaN" values from this <see cref="Quaternion"/>.
        /// </summary>
        /// <param name="value">This <see cref="Quaternion"/>.</param>
        /// <returns>A new <see cref="Quaternion"/> without "NaN" values.</returns>
        public static Quaternion RemoveNaNs(this Quaternion value)
        {
            value.x = value.x.RemoveNaN();
            value.y = value.y.RemoveNaN();
            value.z = value.z.RemoveNaN();

            return value;
        }

        /// <summary>
        /// Gets the angle between this <see cref="Quaternion"/> and some <see cref="other"/> <see cref="Quaternion"/>
        /// using <see cref="Quaternion.Angle"/>.
        /// </summary>
        /// <param name="value">This <see cref="Quaternion"/>.</param>
        /// <param name="other">The <see cref="other"/> <see cref="Quaternion"/> to measure an angle with.</param>
        /// <returns>The angle between both values.</returns>
        public static float Angle(this Quaternion value, Quaternion other) 
            => Quaternion.Angle(value, other);

        /// <summary>
        /// Gets the dot product between this <see cref="Quaternion"/> and some <see cref="other"/> <see cref="Quaternion"/>
        /// using <see cref="Quaternion.Dot"/>.
        /// </summary>
        /// <param name="value">This <see cref="Quaternion"/>.</param>
        /// <param name="other">The <see cref="other"/> <see cref="Quaternion"/> to measure the dot product with.</param>
        /// <returns>The dot product of both values.</returns>
        public static float Dot(this Quaternion value, Quaternion other) 
            => Quaternion.Dot(value, other);

        /// <summary>
        /// Gets the inverse of this <see cref="Quaternion"/> using <see cref="Quaternion.Inverse"/>.
        /// </summary>
        /// <param name="value">This <see cref="Quaternion"/>.</param>
        /// <returns>The inverse of the this <see cref="Quaternion"/>.</returns>
        public static Quaternion Inverse(this Quaternion value) 
            => Quaternion.Inverse(value);

        /// <summary>
        /// Normalizes this <see cref="Quaternion"/> using <see cref="Quaternion.Normalize"/>.
        /// </summary>
        /// <param name="value">This <see cref="Quaternion"/>.</param>
        /// <returns>The normalized value of the this <see cref="Quaternion"/>.</returns>
        public static Quaternion Normalize(this Quaternion value) 
            => Quaternion.Normalize(value);
    }
}