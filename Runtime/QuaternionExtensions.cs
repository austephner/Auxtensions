using UnityEngine;

namespace Auxtensions
{
    public static class QuaternionExtensions
    {
        /// <summary> Removes all "NaN" values from this <see cref="Quaternion"/>. </summary>
        /// <param name="value">This <see cref="Quaternion"/>.</param>
        /// <returns>A new <see cref="Quaternion"/> without "NaN" values.</returns>
        public static Quaternion RemoveNaNs(this Quaternion value)
        {
            value.x = value.x.RemoveNaN();
            value.y = value.y.RemoveNaN();
            value.z = value.z.RemoveNaN();

            return value;
        }
    }
}