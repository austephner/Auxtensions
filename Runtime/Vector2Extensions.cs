using UnityEngine;

namespace Auxtensions
{
    /// <summary>
    /// todo: documentation
    /// </summary>
    public static class Vector2Extensions
    {
        public static int RandomIntFromRange(this Vector2 value)
        {
            return value.RandomFloatFromRange().RoundToInt();
        }

        public static float RandomFloatFromRange(this Vector2 value)
        {
            return Random.Range(value.x, value.y);
        }
        
        public static Vector2 RemoveNaNs(this Vector2 value)
        {
            value.x = value.x.RemoveNaN();
            value.y = value.y.RemoveNaN();

            return value;
        }

        /// <summary>
        /// Converts a <see cref="Vector2"/> with X and Y values to a <see cref="Vector3"/> with X and Z values. This
        /// is useful for top-down games that focus on one lateral Y plane.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Vector3 ToVector3xz(this Vector2 value, float y = 0)
        {
            return new Vector3(value.x, y, value.y);
        }
    }
}