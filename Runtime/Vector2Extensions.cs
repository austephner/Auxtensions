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
    }
}