using UnityEngine;

namespace Flintor
{
    /// <summary>
    /// Float extensions which provide additional functionality for <c>float</c> typed variables.
    /// </summary>
    // todo: add function attributes similar to Mathf functions such as [FreeFunction(IsThreadSafe = true)]
    // todo: Mathf.Min, Mathf.Max, Mathf.LerpAngle, Mathf.LerpClamped, Mathf.FloatToHalf, Mathf.HalfToFloat, Mathf.GammaToLinearSpace, Mathf.LinearToGammaSpace
    // todo: documentation
    public static class FloatExtensions
    {
        #region Mathf Functions
        
        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float Abs(this float value) => Mathf.Abs(value);
        
        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float Acos(this float value) => Mathf.Acos(value);
        
        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="approximation"></param>
        /// <returns></returns>
        public static bool Approximately(this float value, float approximation) => Mathf.Approximately(value, approximation); 

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float Asin(this float value) => Mathf.Asin(value);
        
        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float Atan(this float value) => Mathf.Atan(value);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static float Atan2(this float value, float y) => Mathf.Atan2(value, y);

        /// <summary>
        ///     Rounds this <see cref="float"/> up using <see cref="Mathf.CeilToInt"/>.
        /// </summary>
        /// <param name="value">
        ///     This <see cref="float"/> value.
        /// </param>
        /// <returns>
        ///     A rounded <see cref="float"/>.
        /// </returns>
        /// <example>
        ///     (1.618f).CeilToInt()
        /// </example>
        public static float Ceil(this float value) => Mathf.Ceil(value);
        
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
        ///     (1.618f).CeilToInt()
        /// </example>
        public static int CeilToInt(this float value) => Mathf.CeilToInt(value);
        
        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static float Clamp(this float value, float min, float max) => Mathf.Clamp(value, min, max);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float Clamp01(this float value) => Mathf.Clamp01(value);
        
        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float Cos(this float value) => Mathf.Cos(value);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static float DeltaAngle(this float value, float target) => Mathf.DeltaAngle(value, target);
        
        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float Exp(this float value) => Mathf.Exp(value);
        
        /// <summary>
        ///     Rounds this <see cref="float"/> down using <see cref="Mathf.FloorToInt"/>.
        /// </summary>
        /// <param name="value">
        ///     This <see cref="float"/> value.
        /// </param>
        /// <returns>
        ///     A rounded <see cref="float"/>.
        /// </returns>
        /// <example>
        ///     (1.618f).FloorToInt()
        /// </example>
        public static float Floor(this float value) => Mathf.Floor(value);
        
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
        ///     (1.618f).FloorToInt()
        /// </example>
        public static int FloorToInt(this float value) => Mathf.FloorToInt(value);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="absMax"></param>
        /// <param name="gamma"></param>
        /// <returns></returns>
        public static float Gamma(this float value, float absMax, float gamma) => Mathf.Gamma(value, absMax, gamma);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="to"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static float InverseLerpTo(this float value, float to, float time) => Mathf.InverseLerp(value, to, time);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="from"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static float InverseLerpFrom(this float value, float from, float time) => Mathf.InverseLerp(from, value, time);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static float InverseLerpOver(this float value, float from, float to) => Mathf.InverseLerp(from, to, value);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="to"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static float LerpTo(this float value, float to, float time) => Mathf.Lerp(value, to, time);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="from"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static float LerpFrom(this float value, float from, float time) => Mathf.Lerp(from, value, time);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static float LerpOver(this float value, float from, float to) => Mathf.Lerp(from, to, value);
        
        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float Log(this float value) => Mathf.Log(value);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="base"></param>
        /// <returns></returns>
        public static float Log(this float value, float @base) => Mathf.Log(value, @base);
        
        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float Log10(this float value) => Mathf.Log10(value);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="target"></param>
        /// <param name="maxDelta"></param>
        /// <returns></returns>
        public static float MoveTowards(this float value, float target, float maxDelta) => Mathf.MoveTowards(value, target, maxDelta);
        
        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="target"></param>
        /// <param name="maxDelta"></param>
        /// <returns></returns>
        public static float MoveTowardsAngle(this float value, float target, float maxDelta) => Mathf.MoveTowardsAngle(value, target, maxDelta);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static float PerlinNoiseX(this float value, float y) => Mathf.PerlinNoise(value, y);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static float PerlinNoiseY(this float value, float x) => Mathf.PerlinNoise(x, value);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static float PingPong(this float value, float length) => Mathf.PerlinNoise(value, length);
        
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
        ///     (1.618f).Pow(5)
        /// </example>
        public static float Pow(this float value, float power) => Mathf.Pow(value, power);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static float Repeat(this float value, float length) => Mathf.Repeat(value, length);
        
        /// <summary>
        ///     Rounds this <see cref="float"/> using <see cref="Mathf.RoundToInt"/>.
        /// </summary>
        /// <param name="value">
        ///     This <see cref="float"/> value.
        /// </param>
        /// <returns>
        ///     A rounded <see cref="float"/>.
        /// </returns>
        /// <example>
        ///     (1.618f).Round()
        /// </example>
        public static float Round(this float value) => Mathf.Round(value);

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
        ///     (1.618f).RoundToInt()
        /// </example>
        public static int RoundToInt(this float value) => Mathf.RoundToInt(value);
        
        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float Sign(this float value) => Mathf.Sign(value);
        
        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float Sin(this float value) => Mathf.Sin(value);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="target"></param>
        /// <param name="currentVelocity"></param>
        /// <param name="smoothTime"></param>
        /// <returns></returns>
        public static float SmoothDamp(this float value, float target, ref float currentVelocity, float smoothTime) => Mathf.SmoothDamp(value, target, ref currentVelocity, smoothTime);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="target"></param>
        /// <param name="currentVelocity"></param>
        /// <param name="smoothTime"></param>
        /// <param name="maxSpeed"></param>
        /// <returns></returns>
        public static float SmoothDamp(this float value, float target, ref float currentVelocity, float smoothTime, float maxSpeed) => Mathf.SmoothDamp(value, target, ref currentVelocity, smoothTime, maxSpeed);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="target"></param>
        /// <param name="currentVelocity"></param>
        /// <param name="smoothTime"></param>
        /// <param name="maxSpeed"></param>
        /// <param name="deltaTime"></param>
        /// <returns></returns>
        public static float SmoothDamp(this float value, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) => Mathf.SmoothDamp(value, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
        
        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="target"></param>
        /// <param name="currentVelocity"></param>
        /// <param name="smoothTime"></param>
        /// <returns></returns>
        public static float SmoothDampAngle(this float value, float target, ref float currentVelocity, float smoothTime) => Mathf.SmoothDampAngle(value, target, ref currentVelocity, smoothTime);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="target"></param>
        /// <param name="currentVelocity"></param>
        /// <param name="smoothTime"></param>
        /// <param name="maxSpeed"></param>
        /// <returns></returns>
        public static float SmoothDampAngle(this float value, float target, ref float currentVelocity, float smoothTime, float maxSpeed) => Mathf.SmoothDampAngle(value, target, ref currentVelocity, smoothTime, maxSpeed);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="target"></param>
        /// <param name="currentVelocity"></param>
        /// <param name="smoothTime"></param>
        /// <param name="maxSpeed"></param>
        /// <param name="deltaTime"></param>
        /// <returns></returns>
        public static float SmoothDampAngle(this float value, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) => Mathf.SmoothDampAngle(value, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);

        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <param name="to"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static float SmoothStep(this float value, float to, float time) => Mathf.SmoothStep(value, to, time);

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
        ///     (1.618f).Sqrt()
        /// </example>
        public static float Sqrt(this float value) => Mathf.Sqrt(value);
        
        /// <summary>
        /// todo: documentation
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float Tan(this float value) => Mathf.Tan(value);

        #endregion

        #region Custom Extensions

        /// <summary>
        ///     Remaps this <see cref="float"/> relative to an "in range" and "out range". Advanced normalization.
        /// </summary>
        /// <param name="value">
        ///     This <see cref="float"/> value.
        /// </param>
        /// <param name="inMin">
        ///     The lower input range value.
        /// </param>
        /// <param name="inMax">
        ///     The upper input range value.
        /// </param>
        /// <param name="outMin">
        ///     The lower output range value.
        /// </param>
        /// <param name="outMax">
        ///     The upper output range value.
        /// </param>
        /// <returns>
        ///     A remapped <see cref="float"/>.
        /// </returns>
        /// <example>
        ///     (1.618f).Remap(0.0f, 2.0f, 0.0f, 1.0f)
        /// </example>
        public static float Remap(this float value, float inMin, float inMax, float outMin, float outMax) => outMin + (value - inMin) * (outMax - outMin) / (inMax - inMin);

        /// <summary>
        ///     Checks to see if this <see cref="float"/> is "not a number" using <see cref="float.IsNaN"/>
        /// </summary>
        /// <param name="value">
        ///     This <see cref="float"/> value.
        /// </param>
        /// <returns>
        ///     Whether or not the <see cref="float"/> is a number.
        /// </returns>
        /// <example>
        ///     (1.618f).IsNan()
        /// </example>
        public static bool IsNan(this float value) => float.IsNaN(value);

        /// <summary>
        ///     Rounds this <see cref="float"/> to a multiple of the given value.
        /// </summary>
        /// <param name="value">
        ///     This <see cref="float"/> value.
        /// </param>
        /// <param name="multiple">
        ///     The multiple for which to divide the value before rounding then multiply afterwards.
        /// </param>
        /// <returns>
        ///     A <see cref="float"/> value that has been rounded to a multiple of the given value.
        /// </returns>
        /// <example>
        ///     (1.618f).RoundToMultipleOf(5)
        /// </example>
        public static float RoundToMultipleOf(this float value, int multiple) => Mathf.Round(value / multiple) * multiple;

        #endregion
    }
}