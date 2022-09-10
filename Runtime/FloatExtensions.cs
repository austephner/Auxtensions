using System;
using UnityEngine;

namespace Auxtensions
{
    /// <summary>
    /// Float extensions which provide additional functionality for <see cref="float"/> typed variables. These
    /// extensions include common <see cref="Mathf"/> usages where applicable.
    /// </summary>
    // todo: add function attributes similar to Mathf functions such as [FreeFunction(IsThreadSafe = true)]
    // todo: Mathf.Min, Mathf.Max, Mathf.LerpAngle, Mathf.LerpClamped, Mathf.FloatToHalf, Mathf.HalfToFloat, Mathf.GammaToLinearSpace, Mathf.LinearToGammaSpace
    // todo: documentation
    public static class FloatExtensions
    {
        #region Mathf Functions
        
        /// <summary>
        /// Calculates the absolute value of this <see cref="float"/>.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <returns>
        /// The absolute value of the given <see cref="float"/>.
        /// </returns>
        public static float Abs(this float value) 
            => Mathf.Abs(value);
        
        /// <summary>
        /// Calculates the arc cosine of this <see cref="float"/> angle, measured in radians.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <returns>
        /// The arc cosine of this <see cref="float"/>.
        /// </returns>
        public static float Acos(this float value) 
            => Mathf.Acos(value);
        
        /// <summary>
        /// Determines if this <see cref="float"/> is similar to the given <see cref="approximation"/> <see cref="float"/>. 
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="approximation">
        /// The <see cref="float"/> value to compare against this <see cref="float"/>. 
        /// </param>
        /// <returns>
        /// <c>True</c> if this value is similar to the given <see cref="approximation"/>, otherwise <c>false</c>.
        /// </returns>
        public static bool Approximately(this float value, float approximation) 
            => Mathf.Approximately(value, approximation); 

        /// <summary>
        /// Calculates the arc sine of this <see cref="float"/> angle, measured in radians.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <returns>
        /// The arc sine of this <see cref="float"/>.
        /// </returns>
        public static float Asin(this float value) 
            => Mathf.Asin(value);
        
        /// <summary>
        /// Calculates the arc tangent of this <see cref="float"/> angle, measured in radians.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <returns>
        /// The arc tangent of this <see cref="float"/>.
        /// </returns>
        public static float Atan(this float value) 
            => Mathf.Atan(value);

        /// <summary>
        /// Calculates the radian angles of the arc tangent between this <see cref="float"/> <c>x</c> value given another <see cref="y"/> value.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="y">
        /// The <c>y</c> value used to calculate an arc tangent.
        /// </param>
        /// <returns>
        /// A degree in radians.
        /// </returns>
        public static float Atan2(this float value, float y) 
            => Mathf.Atan2(value, y);

        /// <summary>
        /// Rounds this <see cref="float"/> up.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <returns>
        /// A rounded <see cref="float"/>.
        /// </returns>
        /// <example>
        /// (1.618f).CeilToInt()
        /// </example>
        public static float Ceil(this float value) 
            => Mathf.Ceil(value);
        
        /// <summary>
        /// Rounds this <see cref="float"/> up to an <see cref="int"/>.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <returns>
        /// A rounded <see cref="int"/>.
        /// </returns>
        /// <example>
        /// (1.618f).CeilToInt()
        /// </example>
        public static int CeilToInt(this float value) 
            => Mathf.CeilToInt(value);
        
        /// <summary>
        /// Clamps this <see cref="float"/> between a <see cref="min"/> and <see cref="max"/>.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="min">
        /// The value this <see cref="float"/> must be greater than or equal to.
        /// </param>
        /// <param name="max">
        /// The value this <see cref="float"/> must be less than or equal to.
        /// </param>
        /// <returns>
        /// A clamped value between the given min and max.
        /// </returns>
        public static float Clamp(this float value, float min, float max) 
            => Mathf.Clamp(value, min, max);

        /// <summary>
        /// Clamps this <see cref="float"/> between <c>0.0f</c> and <c>1.0f</c>.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <returns>
        /// A clamped value between <c>0.0f</c> and <c>1.0f</c>.
        /// </returns>
        public static float Clamp01(this float value) 
            => Mathf.Clamp01(value);
        
        /// <summary>
        /// Calculates the cosine of this <see cref="float"/>'s angle value.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <returns>
        /// The cosine of this <see cref="float"/>'s angle.
        /// </returns>
        public static float Cos(this float value) 
            => Mathf.Cos(value);

        /// <summary>
        /// Calculates the shortest distance between this <see cref="float"/> and a <see cref="target"/> <see cref="float"/> measured in radians.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="target">
        /// The target angle in radians.
        /// </param>
        /// <returns>
        /// The delta angle in radians.
        /// </returns>
        public static float DeltaAngle(this float value, float target) 
            => Mathf.DeltaAngle(value, target);
        
        /// <summary>
        /// Returns <c>e</c> raised to the power of this <see cref="float"/>.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <returns>
        /// <c>e</c> raised to this <see cref="float"/>.
        /// </returns>
        public static float Exp(this float value) 
            => Mathf.Exp(value);
        
        /// <summary>
        /// Rounds this <see cref="float"/> down.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <returns>
        /// A rounded <see cref="float"/>.
        /// </returns>
        /// <example>
        /// (1.618f).FloorToInt()
        /// </example>
        public static float Floor(this float value) 
            => Mathf.Floor(value);
        
        /// <summary>
        /// Rounds this <see cref="float"/> down to an <see cref="int"/>.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <returns>
        /// A rounded <see cref="int"/>.
        /// </returns>
        /// <example>
        /// (1.618f).FloorToInt()
        /// </example>
        public static int FloorToInt(this float value) 
            => Mathf.FloorToInt(value);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="absMax"></param>
        /// <param name="gamma"></param>
        /// <returns></returns>
        public static float Gamma(this float value, float absMax, float gamma) 
            => Mathf.Gamma(value, absMax, gamma);

        /// <summary>
        /// Inverse lerps this <see cref="float"/> value to the given target value over the given <see cref="time"/>.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="to">
        /// The target value.
        /// </param>
        /// <param name="time">
        /// The time lerp percentage.
        /// </param>
        /// <returns>
        /// An inversed lerp value.
        /// </returns>
        public static float InverseLerpTo(this float value, float to, float time) 
            => Mathf.InverseLerp(value, to, time);

        /// <summary>
        /// Inverse lerps from the given origin value to this <see cref="float"/> value over the given <see cref="time"/>.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="from">
        /// The target value.
        /// </param>
        /// <param name="time">
        /// The time lerp percentage.
        /// </param>
        /// <returns>
        /// A inversed lerp value.
        /// </returns>
        public static float InverseLerpFrom(this float value, float from, float time) 
            => Mathf.InverseLerp(from, value, time);

        /// <summary>
        /// Inverse lerps between the given origin value and the given target value over this <see cref="float"/> time.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="from">
        /// The origin value.
        /// </param>
        /// <param name="to">
        /// The target value.
        /// </param>
        /// <returns>
        /// An inversed lerp value.
        /// </returns>
        public static float InverseLerpOver(this float value, float from, float to) 
            => Mathf.InverseLerp(from, to, value);

        /// <summary>
        /// Lerps this <see cref="float"/> value to the given target value over the given <see cref="time"/>.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="to">
        /// The target value.
        /// </param>
        /// <param name="time">
        /// The time lerp percentage.
        /// </param>
        /// <returns>
        /// A lerped value.
        /// </returns>
        public static float LerpTo(this float value, float to, float time) 
            => Mathf.Lerp(value, to, time);

        /// <summary>
        /// Lerps from the given origin value to this <see cref="float"/> value over the given <see cref="time"/>.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="from">
        /// The target value.
        /// </param>
        /// <param name="time">
        /// The time lerp percentage.
        /// </param>
        /// <returns>
        /// A lerped value.
        /// </returns>
        public static float LerpFrom(this float value, float from, float time) 
            => Mathf.Lerp(from, value, time);

        /// <summary>
        /// Lerps between the given origin value and the given target value over this <see cref="float"/> time.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="from">
        /// The origin value.
        /// </param>
        /// <param name="to">
        /// The target value.
        /// </param>
        /// <returns>
        /// A lerped value.
        /// </returns>
        public static float LerpOver(this float value, float from, float to) 
            => Mathf.Lerp(from, to, value);
        
        /// <summary>
        /// Calculates the log base <c>e</c> of this <see cref="float"/> value.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <returns>
        /// The log base <c>e</c> of this <see cref="float"/> value.
        /// </returns>
        public static float Log(this float value) 
            => Mathf.Log(value);

        /// <summary>
        /// Calculates the log of this <see cref="float"/> value with the given <see cref="@base"/> value.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="base">
        /// The base to calculate a log with.
        /// </param>
        /// <returns>
        /// A log value.
        /// </returns>
        public static float Log(this float value, float @base) 
            => Mathf.Log(value, @base);
        
        /// <summary>
        /// Calculates the log base 10 of this <see cref="float"/>.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <returns>
        /// The log base 10 of this <see cref="float"/>.
        /// </returns>
        public static float Log10(this float value) 
            => Mathf.Log10(value);

        /// <summary>
        /// Calculates a value between this <see cref="float"/> and the given <see cref="target"/> <see cref="float"/> with a max change rate of the given <see cref="maxDelta"/> value.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="target">
        /// The desired end value.
        /// </param>
        /// <param name="maxDelta">
        /// The maximum amount of change this value can undergo during one call to this function.
        /// </param>
        /// <returns>
        /// A value between this <see cref="float"/> and the given <see cref="target"/>.
        /// </returns>
        public static float MoveTowards(this float value, float target, float maxDelta) 
            => Mathf.MoveTowards(value, target, maxDelta);
        
        /// <summary>
        /// Calculates a value between this <see cref="float"/> angle and the given <see cref="target"/> <see cref="float"/> angle with a max change rate of the given <see cref="maxDelta"/> value, looping through 0 to 360 degrees and wrapping around as needed.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="target">
        /// The desired end value.
        /// </param>
        /// <param name="maxDelta">
        /// The maximum amount of change this value can undergo during one call to this function.
        /// </param>
        /// <returns>
        /// A value between this <see cref="float"/> and the given <see cref="target"/>.
        /// </returns>
        public static float MoveTowardsAngle(this float value, float target, float maxDelta) 
            => Mathf.MoveTowardsAngle(value, target, maxDelta);

        /// <summary>
        /// Loops this <see cref="float"/> between <c>0</c> and the given <see cref="length"/> by calculating the modulus of this <see cref="float"/> and determining what the final position is. An alternative to clamping.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="length">
        /// The maximum size of the ping pong effect.
        /// </param>
        /// <returns>
        /// A value that has been ping-ponged between 0 and the <see cref="length"/>.
        /// </returns>
        public static float PingPong(this float value, float length) 
            => Mathf.PingPong(value, length);
        
        /// <summary>
        /// Raises this <see cref="float"/> to the given <see cref="power"/>.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="power">
        /// The power to raise this <see cref="float"/> value to.
        /// </param>
        /// <returns>
        /// A squared <see cref="float"/>.
        /// </returns>
        /// <example>
        /// (1.618f).Pow(5)
        /// </example>
        public static float Pow(this float value, float power) 
            => Mathf.Pow(value, power);

        /// <summary>
        /// Loops this <see cref="float"/> value between <c>0</c> and the given <see cref="length"/> such that the result can never be beyond <c>0</c> and the given <see cref="length"/>. An alternative to clamping a value while retaining its relative value to the start and end.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="length">
        /// The max length of the repeat loop.
        /// </param>
        /// <returns>
        /// A value between 0 and <see cref="length"/>.
        /// </returns>
        public static float Repeat(this float value, float length) 
            => Mathf.Repeat(value, length);
        
        /// <summary>
        /// Rounds this <see cref="float"/>.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <returns>
        /// A rounded <see cref="float"/>.
        /// </returns>
        /// <example>
        /// (1.618f).Round()
        /// </example>
        public static float Round(this float value) 
            => Mathf.Round(value);

        /// <summary>
        /// Rounds this <see cref="float"/> to an <see cref="int"/>.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <returns>
        /// A rounded <see cref="int"/>.
        /// </returns>
        /// <example>
        /// (1.618f).RoundToInt()
        /// </example>
        public static int RoundToInt(this float value) 
            => Mathf.RoundToInt(value);
        
        /// <summary>
        /// Gets the sign of this <see cref="float"/> value.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <returns>
        /// <c>1.0f</c> if this <see cref="float"/> is positive and <c>-1.0f</c> if this <see cref="float"/> is negative.
        /// </returns>
        public static float Sign(this float value) 
            => Mathf.Sign(value);
        
        /// <summary>
        /// Calculates the sine of this <see cref="float"/>.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <returns>
        /// The sine of this <see cref="float"/>.
        /// </returns>
        public static float Sin(this float value) 
            => Mathf.Sin(value);

        /// <summary>
        /// Calculates the square root of this <see cref="float"/>.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <returns>
        /// The square of this <see cref="float"/> value.
        /// </returns>
        public static float Sqrt(this float value) 
            => Mathf.Sqrt(value);
        
        /// <summary>
        /// Calculates the tangent of this <see cref="float"/>.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <returns>
        /// The tangent of this <see cref="float"/>.
        /// </returns>
        public static float Tan(this float value) 
            => Mathf.Tan(value);

        #endregion

        #region Custom Extensions

        /// <summary>
        /// Clamps this <see cref="float"/> to a <see cref="max"/> value.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="max">
        /// The maximum <see cref="float"/> range.
        /// </param>
        /// <returns>
        /// This clamped <see cref="float"/>.
        /// </returns>
        public static float ClampToMax(this float value, float max)
            => Mathf.Clamp(value, float.MinValue, max);
        
        /// <summary>
        /// Clamps this <see cref="float"/> to a <see cref="min"/> value.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="min">
        /// The minimum <see cref="float"/> range.
        /// </param>
        /// <returns>
        /// This clamped <see cref="float"/>.
        /// </returns>
        public static float ClampToMin(this float value, float min)
            => Mathf.Clamp(value, min, float.MaxValue);

        /// <summary>
        /// Checks to see if this <see cref="float"/> is within a <see cref="min"/> and <see cref="max"/> <see cref="float"/> range.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="min">
        /// The minimum <see cref="float"/> range.
        /// </param>
        /// <param name="max">
        /// The maximum <see cref="float"/> range.
        /// </param>
        /// <param name="inclusive">
        /// (Optional) If <c>true</c>, this <see cref="value"/> will be compared with "or-equal-to" operators.
        /// </param>
        /// <returns>
        /// Whether or not this <see cref="value"/> is within the given <see cref="min"/> and <see cref="max"/> range.
        /// </returns>
        public static bool IsInsideRange(this float value, float min, float max, bool inclusive = true) 
            => inclusive ? value >= min && value <= max : value > min && value < max;
        
        /// <summary>
        /// Checks to see if this <see cref="float"/> is "not a number".
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <returns>
        /// Whether or not the <see cref="float"/> is a number.
        /// </returns>
        /// <example>
        /// (1.618f).IsNaN()
        /// </example>
        public static bool IsNaN(this float value) 
            => float.IsNaN(value);

        /// <summary>
        /// Returns <c>0.0f</c> if this <see cref="value"/> is "not a number", otherwise returns the <see cref="value"/>.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <returns>
        /// <c>0.0f</c> if the <see cref="value"/> is "not a number", otherwise returns the <see cref="value"/>.
        /// </returns>
        /// <example>
        /// (1.6185f).RemoveNaN()
        /// </example>
        public static float RemoveNaN(this float value) 
            => float.IsNaN(value) ? 0 : value;

        /// <summary>
        /// Checks to see if this <see cref="float"/> is outside of a <see cref="min"/> and <see cref="max"/> <see cref="float"/> range.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="min">
        /// The minimum <see cref="float"/> range.
        /// </param>
        /// <param name="max">
        /// The maximum <see cref="float"/> range.
        /// </param>
        /// <param name="inclusive">
        /// (Optional) If <c>true</c>, this <see cref="value"/> will be compared with "or-equal-to" operators.
        /// </param>
        /// <returns>
        /// Whether or not this <see cref="value"/> is outside of the given <see cref="min"/> and <see cref="max"/> range.
        /// </returns>
        public static bool IsOutsideRange(this float value, float min, float max, bool inclusive = false)
            => inclusive ? value <= min || value >= max : value < min && value > max;

        /// <summary>
        /// Remaps this <see cref="float"/> relative to an "in range" and "out range". Advanced normalization.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="fromMin">
        /// The lower input range value.
        /// </param>
        /// <param name="fromMax">
        /// The upper input range value.
        /// </param>
        /// <param name="toMin">
        /// The lower output range value.
        /// </param>
        /// <param name="toMax">
        /// The upper output range value.
        /// </param>
        /// <param name="clamp">
        /// Clamps the resulting value between the <see cref="toMin"/> value and <see cref="toMax"/> value.
        /// </param>
        /// <returns>
        /// A remapped <see cref="float"/>.
        /// </returns>
        /// <example>
        /// (1.618f).Remap(0.0f, 2.0f, 0.0f, 1.0f)
        /// </example>
        public static float Remap (this float value, float fromMin, float fromMax, float toMin,  float toMax, bool clamp = true)
        {
            var result = (toMax - toMin) * ((value - fromMin) / (fromMax - fromMin)) + toMin;
            return clamp ? result.Clamp(toMin, toMax) : result;
        }
        
        /// <summary>
        /// Rounds this <see cref="float"/> value to a specified number of decimal points.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="decimalPoints">
        /// The number of decimal points to round to.
        /// </param>
        /// <returns>
        /// A rounded <see cref="float"/> value.
        /// </returns>
        /// <example>
        /// (1.618f).RoundToDecimalPoints(2)
        /// </example>
        public static float RoundToDecimalPoints(this float value, int decimalPoints)
            => (float) Math.Round(value, decimalPoints);

        /// <summary>
        /// Rounds this <see cref="float"/> to a multiple of the given value.
        /// </summary>
        /// <param name="value">
        /// This <see cref="float"/> value.
        /// </param>
        /// <param name="multiple">
        /// The multiple for which to divide the value before rounding then multiply afterwards.
        /// </param>
        /// <returns>
        /// A <see cref="float"/> value that has been rounded to a multiple of the given value.
        /// </returns>
        /// <example>
        /// (1.618f).RoundToMultipleOf(5)
        /// </example>
        public static float RoundToMultipleOf(this float value, int multiple) 
            => Mathf.Round(value / multiple) * multiple;

        #endregion
    }
}