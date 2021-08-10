using UnityEngine;

namespace Auxtensions
{
    /// <summary>
    /// Vector3 extensions which provide additional functionality for <see cref="Vector3"/> typed variables.
    /// </summary>
    public static class Vector3Extensions
    {
        /// <summary>
        ///     Calculates the absolute value of each field on this <see cref="Vector3"/>.
        /// </summary>
        /// <param name="vector3">
        ///     This <see cref="Vector3"/>.
        /// </param>
        /// <returns>
        ///     A <see cref="Vector3"/> with absolute values.
        /// </returns>
        public static Vector3 Abs(this Vector3 vector3)
        {
            var result = new Vector3();
            
            result.x = Mathf.Abs(vector3.x);
            result.y = Mathf.Abs(vector3.y);
            result.z = Mathf.Abs(vector3.z);

            return result;
        }
        
        /// <summary>
        ///     Clamps all fields on this <see cref="Vector3"/> to a new <see cref="Vector3"/>.
        /// </summary>
        /// <param name="vector3">
        ///     This <see cref="Vector3"/>.
        /// </param>
        /// <param name="min">
        ///     The min <see cref="float"/> any field can be.
        /// </param>
        /// <param name="max">
        ///     The max <see cref="float"/> any field can be.
        /// </param>
        /// <returns>
        ///     A clamped <see cref="Vector3"/>.
        /// </returns>
        public static Vector3 ClampAllFields(this Vector3 vector3, float min, float max)
        {
            var result = new Vector3();
            
            result.x = vector3.x.Clamp(min, max);
            result.y = vector3.y.Clamp(min, max);
            result.z = vector3.z.Clamp(min, max);

            return result;
        }
        
        /// <summary>
        ///     Clamps this <see cref="Vector3"/>'s magnitude to a new <see cref="Vector3"/> using the given <see cref="magnitude"/>.
        /// </summary>
        /// <param name="value">
        ///     This <see cref="Vector3"/>.
        /// </param>
        /// <param name="magnitude">
        ///     The magnitude to which this <see cref="Vector3"/>'s magnitude will be clamped to.
        /// </param>
        /// <returns>
        ///     A <see cref="Vector3"/> with a clamped magnitude.
        /// </returns>
        public static Vector3 ClampMagnitude(this Vector3 value, float magnitude)
        {
            return Vector3.ClampMagnitude(value, magnitude);
        }
        
        /// <summary>
        ///     Creates a new <see cref="Vector2"/> and assigns its <c>x</c> field with this <see cref="Vector3"/>'s <c>x</c> field and its <c>y</c> field with the <see cref="Vector3"/>'s <c>z</c> field.
        /// </summary>
        /// <param name="value">
        ///     This <see cref="Vector3"/>.
        /// </param>
        /// <returns>
        ///     A new <see cref="Vector2"/> with its <c>x</c> and <c>y</c> fields matching this <see cref="Vector3"/>'s <c>x</c> and <c>z</c> fields respectively.
        /// </returns>
        public static Vector2 CreateVector2FromVector3xz(this Vector3 value)
        {
            return new Vector2(value.x, value.z);
        }

        /// <summary>
        ///     Assigns a <see cref="Vector2"/>'s <c>x</c> field to this <see cref="Vector3"/>'s <c>x</c> field and the <see cref="Vector2"/>'s <c>y</c> field to this <see cref="Vector3"/>'s <c>z</c> field.
        /// </summary>
        /// <param name="vector3">
        ///     This <see cref="Vector3"/>.
        /// </param>
        /// <param name="vector2">
        ///     A <see cref="Vector2"/> to assign values with.
        /// </param>
        public static void CreateVector3xzFromVector2(this Vector3 vector3, Vector2 vector2)
        {
            vector3.x = vector2.x;
            vector3.z = vector2.y;
        }
        
        /// <summary>
        ///     Creates a new <see cref="Vector3"/> by copying this <see cref="Vector3"/>'s <c>x</c> field to the new <see cref="Vector3"/>'s <c>x</c> field and this <see cref="Vector3"/>'s <c>y</c> field to the new <see cref="Vector3"/>'s <c>z</c> field.
        /// </summary>
        /// <param name="value">
        ///     This <see cref="Vector3"/>.
        /// </param>
        /// <returns>
        ///     A new <see cref="Vector3"/> with its <c>x</c> field matching this <see cref="Vector3"/>'s <c>x</c> field and its <c>z</c> field matching this <see cref="Vector3"/>'s <c>y</c> field.
        /// </returns>
        public static Vector3 CreateVector3xzFromVector3xy(this Vector3 value)
        {
            return new Vector3(value.x, 0, value.y);
        }
        
        /// <summary>
        ///     Returns the largest <see cref="float"/> value amongst all fields on this <see cref="Vector3"/>.
        /// </summary>
        /// <param name="value">
        ///     This <see cref="Vector3"/>.
        /// </param>
        /// <returns>
        ///     The largest <see cref="float"/> value amongst all fields on this <see cref="Vector3"/>.
        /// </returns>
        public static float GetMax(this Vector3 value)
        {
            if (value.x > value.y && value.x > value.z)
            {
                return value.x;
            } 
            
            if (value.y > value.x && value.y > value.z)
            {
                return value.y;
            }

            return value.z;
        }
        
        /// <summary>
        ///     Returns the smallest <see cref="float"/> value amongst all fields on this <see cref="Vector3"/>.
        /// </summary>
        /// <param name="value">
        ///     This <see cref="Vector3"/>.
        /// </param>
        /// <returns>
        ///     The smallest <see cref="float"/> value amongst all fields on this <see cref="Vector3"/>.
        /// </returns>
        public static float GetMin(this Vector3 value)
        {
            if (value.x < value.y && value.x < value.z)
            {
                return value.x;
            } 
            
            if (value.y < value.x && value.y < value.z)
            {
                return value.y;
            }

            return value.z;
        }

        /// <summary>
        ///     Checks to see if all fields of this <see cref="Vector3"/> are within a <see cref="min"/> and <see cref="max"/> <see cref="float"/> range.
        /// </summary>
        /// <param name="vector3">
        ///     This <see cref="Vector3"/> value.
        /// </param>
        /// <param name="min">
        ///     The minimum <see cref="float"/> range.
        /// </param>
        /// <param name="max">
        ///     The maximum <see cref="float"/> range.
        /// </param>
        /// <param name="inclusive">
        ///     (Optional) If <c>true</c>, the fields of this <see cref="vector3"/> will be compared with "or-equal-to" operators.
        /// </param>
        /// <returns>
        ///     Whether or not the fields of this <see cref="vector3"/> are within the given <see cref="min"/> and <see cref="max"/> range.
        /// </returns>
        public static bool IsInsideRange(this Vector3 vector3, float min, float max, bool inclusive = true)
            => vector3.x.IsInsideRange(min, max, inclusive) && vector3.y.IsInsideRange(min, max, inclusive) && vector3.z.IsInsideRange(min, max, inclusive);

        /// <summary>
        ///     Checks to see if the magnitude of this <see cref="Vector3"/> is within 0 and <see cref="max"/> <see cref="float"/> range.
        /// </summary>
        /// <param name="vector3">
        ///     This <see cref="Vector3"/> value.
        /// </param>
        /// <param name="max">
        ///     The maximum <see cref="float"/> range.
        /// </param>
        /// <param name="inclusive">
        ///     (Optional) If <c>true</c>, the fields of this <see cref="vector3"/> will be compared with "or-equal-to" operators.
        /// </param>
        /// <returns>
        ///     Whether or not the magnitude of this <see cref="vector3"/> is within the 0 given <see cref="min"/> and <see cref="max"/> range.
        /// </returns>        
        public static bool IsMagnitudeInsideRange(this Vector3 vector3, float max, bool inclusive = true)
            => vector3.magnitude.IsInsideRange(0, max, inclusive);

        /// <summary>
        ///     Checks to see if the magnitude of this <see cref="Vector3"/> is outside of a 0 and <see cref="max"/> <see cref="float"/> range.
        /// </summary>
        /// <param name="vector3">
        ///     This <see cref="Vector3"/> value.
        /// </param>
        /// <param name="max">
        ///     The maximum <see cref="float"/> range.
        /// </param>
        /// <param name="inclusive">
        ///     (Optional) If <c>true</c>, the fields of this <see cref="vector3"/> will be compared with "or-equal-to" operators.
        /// </param>
        /// <returns>
        ///     Whether or not the magnitude of this <see cref="vector3"/> is outside the 0 and <see cref="max"/> range.
        /// </returns>    
        public static bool IsMagnitudeOutsideRange(this Vector3 vector3, float max, bool inclusive = false)
            => vector3.magnitude.IsOutsideRange(0, max, inclusive);
        
        /// <summary>
        ///     Checks to see if all fields of this <see cref="Vector3"/> are outside a <see cref="min"/> and <see cref="max"/> <see cref="float"/> range.
        /// </summary>
        /// <param name="vector3">
        ///     This <see cref="Vector3"/> value.
        /// </param>
        /// <param name="min">
        ///     The minimum <see cref="float"/> range.
        /// </param>
        /// <param name="max">
        ///     The maximum <see cref="float"/> range.
        /// </param>
        /// <param name="inclusive">
        ///     (Optional) If <c>true</c>, the fields of this <see cref="vector3"/> will be compared with "or-equal-to" operators.
        /// </param>
        /// <returns>
        ///     Whether or not the fields of this <see cref="vector3"/> are outside the given <see cref="min"/> and <see cref="max"/> range.
        /// </returns>
        public static bool IsOutsideRange(this Vector3 vector3, float min, float max, bool inclusive = false)
            => vector3.x.IsOutsideRange(min, max, inclusive) && vector3.y.IsOutsideRange(min, max, inclusive) && vector3.z.IsOutsideRange(min, max, inclusive);

        /// <summary>
        ///     Randomizes each field on this <see cref="Vector3"/> to a <see cref="float"/> between the <see cref="min"/> and <see cref="max"/>.
        /// </summary>
        /// <param name="vector3">
        ///     This <see cref="Vector3"/>.
        /// </param>
        /// <param name="min">
        ///     The minimum <see cref="float"/> value any field can be.
        /// </param>
        /// <param name="max">
        ///     The maximum <see cref="float"/> value any field can be.
        /// </param>
        public static void RandomizeByRange(this Vector3 vector3, float min, float max)
        {
            vector3.x = Random.Range(min, max);
            vector3.y = Random.Range(min, max);
            vector3.z = Random.Range(min, max);
        }
        
        /// <summary>
        ///     Rounds all fields on this <see cref="Vector3"/> to a multiple of the given value onto a new <see cref="Vector3"/>.
        /// </summary>
        /// <param name="vector3">
        ///     This <see cref="Vector3"/>.
        /// </param>
        /// <param name="multiple">
        ///     The multiple to round to.
        /// </param>
        /// <returns></returns>
        public static Vector3 RoundToMultipleOf(this Vector3 vector3, int multiple)
        {
            var result = new Vector3();
            
            result.x = vector3.x.RoundToMultipleOf(multiple);
            result.y = vector3.y.RoundToMultipleOf(multiple);
            result.z = vector3.z.RoundToMultipleOf(multiple);
            
            return result;
        }

        /// <summary>
        ///     Calculates the transform direction to a new <see cref="Vector3"/> using this <see cref="Vector3"/> as a direction.
        /// </summary>
        /// <param name="value">
        ///     This <see cref="Vector3"/> direction.
        /// </param>
        /// <param name="transform">
        ///     The <see cref="Transform"/> to use for calculating a relative direction.
        /// </param>
        /// <returns>
        ///     A transformed direction.
        /// </returns>
        public static Vector3 TransformDirection(this Vector3 value, Transform transform)
        {
            return transform.TransformDirection(value);
        }
    }
}