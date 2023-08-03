using UnityEngine;

namespace Auxtensions
{
    /// <summary>
    /// Vector3 extensions which provide additional functionality for <see cref="Vector3"/> typed variables.
    /// </summary>
    public static class Vector3Extensions
    {
        /// <summary> Calculates the absolute value of each field on this <see cref="Vector3"/>. </summary>
        /// <param name="value"> This <see cref="Vector3"/> value. </param>
        /// <returns> A <see cref="Vector3"/> with absolute values. </returns>
        public static Vector3 Abs(this Vector3 value)
        {
            value.x = Mathf.Abs(value.x);
            value.y = Mathf.Abs(value.y);
            value.z = Mathf.Abs(value.z);

            return value;
        }
        
        /// <summary> Clamps all fields on this <see cref="Vector3"/> to a new <see cref="Vector3"/>. </summary>
        /// <param name="value"> This <see cref="Vector3"/> value. </param>
        /// <param name="min"> The min <see cref="float"/> any field can be. </param>
        /// <param name="max"> The max <see cref="float"/> any field can be. </param>
        /// <returns> A clamped <see cref="Vector3"/>. </returns>
        public static Vector3 ClampAllFields(this Vector3 value, float min, float max)
        {
            value.x = value.x.Clamp(min, max);
            value.y = value.y.Clamp(min, max);
            value.z = value.z.Clamp(min, max);

            return value;
        }
        
        /// <summary> Clamps this <see cref="Vector3"/>'s magnitude to a new <see cref="Vector3"/> using the given <see cref="magnitude"/>. </summary>
        /// <param name="value"> This <see cref="Vector3"/> value. </param>
        /// <param name="magnitude"> The magnitude to which this <see cref="Vector3"/>'s magnitude will be clamped to. </param>
        /// <returns> A <see cref="Vector3"/> with a clamped magnitude. </returns>
        public static Vector3 ClampMagnitude(this Vector3 value, float magnitude)
        {
            return Vector3.ClampMagnitude(value, magnitude);
        }
        
        /// <summary> Creates a new <see cref="Vector2"/> and assigns its <c>x</c> field with this <see cref="Vector3"/>'s <c>x</c> field and its <c>y</c> field with the <see cref="Vector3"/>'s <c>z</c> field. </summary>
        /// <param name="value"> This <see cref="Vector3"/> value. </param>
        /// <returns> A new <see cref="Vector2"/> with its <c>x</c> and <c>y</c> fields matching this <see cref="Vector3"/>'s <c>x</c> and <c>z</c> fields respectively. </returns>
        public static Vector2 CreateVector2FromVector3xz(this Vector3 value)
        {
            return new Vector2(value.x, value.z);
        }

        /// <summary> Returns the largest <see cref="float"/> value amongst all fields on this <see cref="Vector3"/>. </summary>
        /// <param name="value"> This <see cref="Vector3"/> value. </param>
        /// <returns> The largest <see cref="float"/> value amongst all fields on this <see cref="Vector3"/>. </returns>
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
        
        /// <summary> Returns the smallest <see cref="float"/> value amongst all fields on this <see cref="Vector3"/>. </summary>
        /// <param name="value"> This <see cref="Vector3"/> value. </param>
        /// <returns> The smallest <see cref="float"/> value amongst all fields on this <see cref="Vector3"/>. </returns>
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

        /// <summary> Checks to see if all fields of this <see cref="Vector3"/> are within a <see cref="min"/> and <see cref="max"/> <see cref="float"/> range. </summary>
        /// <param name="value"> This <see cref="Vector3"/> value. </param>
        /// <param name="min"> The minimum <see cref="float"/> range. </param>
        /// <param name="max"> The maximum <see cref="float"/> range. </param>
        /// <param name="inclusive"> (Optional) If <c>true</c>, the fields of this <see cref="value"/> will be compared with "or-equal-to" operators. </param>
        /// <returns> Whether or not the fields of this <see cref="value"/> are within the given <see cref="min"/> and <see cref="max"/> range. </returns>
        public static bool IsInsideRange(this Vector3 value, float min, float max, bool inclusive = true)
            => value.x.IsInsideRange(min, max, inclusive) && value.y.IsInsideRange(min, max, inclusive) && value.z.IsInsideRange(min, max, inclusive);

        /// <summary> Checks to see if the magnitude of this <see cref="Vector3"/> is within 0 and <see cref="max"/> <see cref="float"/> range. </summary>
        /// <param name="value"> This <see cref="Vector3"/> value. </param>
        /// <param name="max"> The maximum <see cref="float"/> range. </param>
        /// <param name="inclusive"> (Optional) If <c>true</c>, the fields of this <see cref="value"/> will be compared with "or-equal-to" operators. </param>
        /// <returns> Whether or not the magnitude of this <see cref="value"/> is within the 0 given <see cref="min"/> and <see cref="max"/> range. </returns>        
        public static bool IsMagnitudeInsideRange(this Vector3 value, float max, bool inclusive = true)
            => value.magnitude.IsInsideRange(0, max, inclusive);

        /// <summary> Checks to see if the magnitude of this <see cref="Vector3"/> is outside of a 0 and <see cref="max"/> <see cref="float"/> range. </summary>
        /// <param name="value"> This <see cref="Vector3"/> value. </param>
        /// <param name="max"> The maximum <see cref="float"/> range. </param>
        /// <param name="inclusive"> (Optional) If <c>true</c>, the fields of this <see cref="value"/> will be compared with "or-equal-to" operators. </param>
        /// <returns> Whether or not the magnitude of this <see cref="value"/> is outside the 0 and <see cref="max"/> range. </returns>    
        public static bool IsMagnitudeOutsideRange(this Vector3 value, float max, bool inclusive = false)
            => value.magnitude.IsOutsideRange(0, max, inclusive);
        
        /// <summary> Checks to see if all fields of this <see cref="Vector3"/> are outside a <see cref="min"/> and <see cref="max"/> <see cref="float"/> range. </summary>
        /// <param name="value"> This <see cref="Vector3"/> value. </param>
        /// <param name="min"> The minimum <see cref="float"/> range. </param>
        /// <param name="max"> The maximum <see cref="float"/> range. </param>
        /// <param name="inclusive"> (Optional) If <c>true</c>, the fields of this <see cref="value"/> will be compared with "or-equal-to" operators. </param>
        /// <returns> Whether or not the fields of this <see cref="value"/> are outside the given <see cref="min"/> and <see cref="max"/> range. </returns>
        public static bool IsOutsideRange(this Vector3 value, float min, float max, bool inclusive = false)
            => value.x.IsOutsideRange(min, max, inclusive) && value.y.IsOutsideRange(min, max, inclusive) && value.z.IsOutsideRange(min, max, inclusive);

        /// <summary> Randomizes each field on this <see cref="Vector3"/> to a <see cref="float"/> between the <see cref="min"/> and <see cref="max"/>. </summary>
        /// <param name="value"> This <see cref="Vector3"/> value. </param>
        /// <param name="min"> The minimum <see cref="float"/> value any field can be. </param>
        /// <param name="max"> The maximum <see cref="float"/> value any field can be. </param>
        /// <returns> This <see cref="Vector3"/>. </returns>
        public static Vector3 RandomizeByRange(this Vector3 value, float min, float max)
        {
            value.x = Random.Range(min, max);
            value.y = Random.Range(min, max);
            value.z = Random.Range(min, max);

            return value;
        }
        
        /// <summary> Rounds all fields on this <see cref="Vector3"/> to a multiple of the given value onto a new <see cref="Vector3"/>. </summary>
        /// <param name="value"> This <see cref="Vector3"/> value. </param>
        /// <param name="multiple"> The multiple to round to. </param>
        /// <returns> This <see cref="Vector3"/>. </returns>
        public static Vector3 RoundToMultipleOf(this Vector3 value, int multiple)
        {
            value.x = value.x.RoundToMultipleOf(multiple);
            value.y = value.y.RoundToMultipleOf(multiple);
            value.z = value.z.RoundToMultipleOf(multiple);

            return value;
        }
        
        /// <summary> Sets this <see cref="Vector3"/>'s <c>x</c> and <c>z</c> fields from a <see cref="Vector2"/>'s <c>x</c> and <c>y</c> fields. </summary>
        /// <param name="value"> This <see cref="Vector3"/> value. </param>
        /// <param name="vector2"> A <see cref="Vector2"/> to assign values with. </param>
        /// <returns> This <see cref="Vector3"/>. </returns>
        public static Vector3 ToVector3XZFromVector2(this Vector3 value, Vector2 vector2)
        {
            value.x = vector2.x;
            value.z = vector2.y;

            return value;
        }
        
        /// <summary> Flips this <see cref="Vector3"/>'s <c>y</c> and <c>z</c> fields. </summary>
        /// <param name="value"> This <see cref="Vector3"/> value. </param>
        /// <returns> This <see cref="Vector3"/>. </returns>
        public static Vector3 FlipYZ(this Vector3 value)
        {
            var originalZ = value.z;
            value.z = value.y;
            value.y = originalZ;

            return value;
        }
        
        /// <summary> Creates a new <see cref="Vector3"/> by copying this <see cref="Vector3"/>'s <c>x</c> field to the new <see cref="Vector3"/>'s <c>x</c> field and this <see cref="Vector3"/>'s <c>y</c> field to the new <see cref="Vector3"/>'s <c>z</c> field. </summary>
        /// <param name="value"> This <see cref="Vector3"/> value. </param>
        /// <returns> A new <see cref="Vector3"/> with its <c>x</c> field matching this <see cref="Vector3"/>'s <c>x</c> field and its <c>z</c> field matching this <see cref="Vector3"/>'s <c>y</c> field. </returns>
        public static Vector3 ToVector3XZFromVector3XY(this Vector3 value) 
            => new Vector3(value.x, 0, value.y);

        /// <summary> Removes all "NaN" values from each field on this <see cref="Vector3"/>. </summary>
        /// <param name="value">This <see cref="Vector3"/> value.</param>
        /// <returns>A new <see cref="Vector3"/> with no "NaN" values.</returns>
        public static Vector3 RemoveNaNs(this Vector3 value)
        {
            value.x = value.x.RemoveNaN();
            value.y = value.y.RemoveNaN();
            value.z = value.z.RemoveNaN();

            return value;
        }

        /// <summary> Creates a new <see cref="Vector2"/> using the <c>x</c> and <c>y</c> values from this <see cref="Vector3"/>. </summary>
        /// <param name="value">This <see cref="Vector3"/> value.</param>
        /// <returns>A new <see cref="Vector2"/>.</returns>
        public static Vector2 ToVector2FromXY(this Vector3 value)
            => new Vector2(value.x, value.y);
        
        /// <summary> Creates a new <see cref="Vector2"/> using the <c>x</c> and <c>z</c> values from this <see cref="Vector3"/>. </summary>
        /// <param name="value">This <see cref="Vector3"/> value.</param>
        /// <returns>A new <see cref="Vector2"/>.</returns>
        public static Vector2 ToVector2FromXZ(this Vector3 value)
            => new Vector2(value.x, value.z);
        
        /// <summary> Creates a "look rotation" out of this <see cref="Vector3"/> value. </summary>
        /// <param name="value">This <see cref="Vector3"/>.</param>
        /// <returns>A "look rotation" <see cref="Quaternion"/></returns>
        public static Quaternion ToLookRotation(this Vector3 value) 
            => Quaternion.LookRotation(value);
        
        /// <summary> Creates a "euler" <see cref="Quaternion"/> out of this <see cref="Vector3"/> value. </summary>
        /// <param name="value">This <see cref="Vector3"/>.</param>
        /// <returns>A "euler" <see cref="Quaternion"/></returns>
        public static Quaternion Euler(this Vector3 value) 
            => Quaternion.Euler(value);

        /// <summary> Transforms this world direction to a local direction.</summary>
        /// <param name="value">This <see cref="Vector3"/>.</param>
        /// <param name="transform">The <see cref="Transform"/> to use.</param>
        /// <returns>A converted direction.</returns>
        public static Vector3 InverseTransformDirection(this Vector3 value, Transform transform) 
            => transform.InverseTransformDirection(value);
        
        /// <summary> Transforms this local direction to a world direction.</summary>
        /// <param name="value">This <see cref="Vector3"/>.</param>
        /// <param name="transform">The <see cref="Transform"/> to use.</param>
        /// <returns>A converted direction.</returns>
        public static Vector3 TransformDirection(this Vector3 value, Transform transform) 
            => transform.TransformDirection(value);
        
        /// <summary> Transforms this local point into a world point. </summary>
        /// <param name="value">This <see cref="Vector3"/>.</param>
        /// <param name="transform">The <see cref="Transform"/> to use.</param>
        /// <returns>A converted point.</returns>
        public static Vector3 TransformPoint(this Vector3 value, Transform transform) 
            => transform.TransformPoint(value);
        
        /// <summary> Transforms this world point into a local point. </summary>
        /// <param name="value">This <see cref="Vector3"/>.</param>
        /// <param name="transform">The <see cref="Transform"/> to use.</param>
        /// <returns>A converted point.</returns>
        public static Vector3 InverseTransformPoint(this Vector3 value, Transform transform) 
            => transform.TransformPoint(value);

        /// <summary> Creates a <see cref="Quaternion"/> rotation based on this <see cref="from"/> and <see cref="to"/> directions.</summary>
        /// <param name="from">This <see cref="Vector3"/> direction.</param>
        /// <param name="to">The target direction.</param>
        /// <returns>A <see cref="Quaternion"/>.</returns>
        public static Quaternion FromToRotation(this Vector3 from, Vector3 to)
            => Quaternion.FromToRotation(from, to);

        /// <summary> Creates a "look rotation" based on this <see cref="Vector3"/>. </summary>
        /// <param name="value">This <see cref="Vector3"/>.</param>
        /// <returns>A <see cref="Quaternion"/>.</returns>
        public static Quaternion LookRotation(this Vector3 value)
            => Quaternion.LookRotation(value);

        /// <summary> Creates a "look rotation" based on this <see cref="Vector3"/>. </summary>
        /// <param name="value">This <see cref="Vector3"/>.</param>
        /// <param name="upAxis">The upwards axis.</param>
        /// <returns>A <see cref="Quaternion"/>.</returns>
        public static Quaternion LookRotation(this Vector3 value, Vector3 upAxis)
            => Quaternion.LookRotation(value, upAxis);
        
        /// <summary>
        /// Remaps the X, Y, and Z values to the given ranges.
        /// </summary>
        /// <param name="value">This <see cref="Vector3"/>.</param>
        /// <param name="fromMin">The current "min" value.</param>
        /// <param name="toMin">The target "min" value.</param>
        /// <param name="fromMax">The current "max" value.</param>
        /// <param name="toMax">The target "max" value.</param>
        /// <returns>A remapped <see cref="Vector3"/>.</returns>
        /// <example>
        /// var vector = new Vector3(0.123f, 0, 812.831f);
        /// var remapped = vector.RemapAll(0, 0, 1000, 1);
        /// </example>
        public static Vector3 RemapAll(this Vector3 value, float fromMin, float toMin, float fromMax, float toMax)
        {
            value.x = value.x.Remap(fromMin, fromMax, toMin, toMax);
            value.y = value.y.Remap(fromMin, fromMax, toMin, toMax);
            value.z = value.z.Remap(fromMin, fromMax, toMin, toMax);
            return value;
        }

        /// <summary>
        /// Sets each value of this <see cref="Vector3"/> and returns the updated value. This makes it easy to update
        /// a <see cref="Vector3"/> inline and use its return value to chain or continue using extension functions.
        /// </summary>
        /// <param name="value">This <see cref="Vector3"/>.</param>
        /// <param name="x">The next X value.</param>
        /// <param name="y">The next Y value.</param>
        /// <param name="z">The next Z value.</param>
        /// <returns></returns>
        public static Vector3 Set(this Vector3 value, float x, float y, float z)
        {
            value.x = x;
            value.y = y;
            value.z = z;
            return value;
        }

        /// <summary>
        /// Sets the X value of this <see cref="Vector3"/> and returns the updated value. This makes it easy to update
        /// a <see cref="Vector3"/> inline and use its return value to chain or continue using extension functions.
        /// </summary>
        /// <param name="value">This <see cref="Vector3"/>.</param>
        /// <param name="x">The next X value.</param>
        /// <returns></returns>
        public static Vector3 SetX(this Vector3 value, float x)
        {
            value.x = x;
            return value;
        }
        
        /// <summary>
        /// Sets the Y value of this <see cref="Vector3"/> and returns the updated value. This makes it easy to update
        /// a <see cref="Vector3"/> inline and use its return value to chain or continue using extension functions.
        /// </summary>
        /// <param name="value">This <see cref="Vector3"/>.</param>
        /// <param name="y">The next Y value.</param>
        /// <returns></returns>
        public static Vector3 SetY(this Vector3 value, float y)
        {
            value.y = y;
            return value;
        }
        
        /// <summary>
        /// Sets the Z value of this <see cref="Vector3"/> and returns the updated value. This makes it easy to update
        /// a <see cref="Vector3"/> inline and use its return value to chain or continue using extension functions.
        /// </summary>
        /// <param name="value">This <see cref="Vector3"/>.</param>
        /// <param name="z">The nezt Z value.</param>
        /// <returns></returns>
        public static Vector3 SetZ(this Vector3 value, float z)
        {
            value.z = z;
            return value;
        }

        /// <summary>
        /// Multiplies this <see cref="Vector3"/> by the given <see cref="float"/> <see cref="multiplier"/>.
        /// </summary>
        /// <param name="value">This <see cref="Vector3"/>.</param>
        /// <param name="multiplier">The <see cref="float"/> value to multiply by.</param>
        /// <returns>The product of <see cref="value"/> and <see cref="multiplier"/>.</returns>
        public static Vector3 Multiply(this Vector3 value, float multiplier)
            => value * multiplier;
        
        /// <summary>
        /// Multiplies this <see cref="Vector3"/> by the given <see cref="int"/> <see cref="multiplier"/>.
        /// </summary>
        /// <param name="value">This <see cref="Vector3"/>.</param>
        /// <param name="multiplier">The <see cref="int"/> value to multiply by.</param>
        /// <returns>The product of <see cref="value"/> and <see cref="multiplier"/>.</returns>
        public static Vector3 Multiply(this Vector3 value, int multiplier)
            => value * multiplier;
        
        /// <summary>
        /// Divides this <see cref="Vector3"/> by the given <see cref="float"/> <see cref="divisor"/>.
        /// </summary>
        /// <param name="value">This <see cref="Vector3"/>.</param>
        /// <param name="divisor">The <see cref="float"/> value to divide by.</param>
        /// <returns>The quotient of <see cref="value"/> and <see cref="divisor"/>.</returns>
        public static Vector3 Divide(this Vector3 value, float divisor)
            => value * divisor;
        
        /// <summary>
        /// Divides this <see cref="Vector3"/> by the given <see cref="int"/> <see cref="divisor"/>.
        /// </summary>
        /// <param name="value">This <see cref="Vector3"/>.</param>
        /// <param name="divisor">The <see cref="int"/> value to divide by.</param>
        /// <returns>The quotient of <see cref="value"/> and <see cref="divisor"/>.</returns>
        public static Vector3 Divide(this Vector3 value, int divisor)
            => value * divisor;

        /// <summary>
        /// Adds this <see cref="Vector3"/> to the given <see cref="Vector3"/> <see cref="additive"/>.
        /// </summary>
        /// <param name="value">This <see cref="Vector3"/>.</param>
        /// <param name="additive">The <see cref="Vector3"/> to add.</param>
        /// <returns>The sum of <see cref="value"/> and <see cref="additive"/>.</returns>
        public static Vector3 Add(this Vector3 value, Vector3 additive)
            => value + additive;

        /// <summary>
        /// Subtracts the given <see cref="Vector3"/> <see cref="subtraction"/> from this <see cref="Vector3"/>.
        /// </summary>
        /// <param name="value">This <see cref="Vector3"/>.</param>
        /// <param name="subtraction">The <see cref="Vector3"/> to subtract from this <see cref="value"/>.</param>
        /// <returns>The difference between <see cref="value"/> and <see cref="subtraction"/>.</returns>
        public static Vector3 Subtract(this Vector3 value, Vector3 subtraction)
            => value - subtraction;
    }
}