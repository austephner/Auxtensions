using System;
using System.Collections;
using System.IO;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Auxtensions
{
    /// <summary>
    /// String extensions which provide additional functionality for <see cref="string"/> typed variables.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Converts this <see cref="string"/> from JSON to the given type <see cref="T"/>.
        /// </summary>
        /// <param name="value"> This <see cref="string"/> based JSON. </param>
        /// <typeparam name="T"> The output type. </typeparam>
        /// <returns> A deserialized object of type <see cref="T"/>. </returns>
        /// <example> "{ \"objectName\": \"Unicorn\" }".FromJson&lt;MyType&gt;(); </example>
        public static T FromJson<T>(this string value)
        {
            return JsonUtility.FromJson<T>(value);
        }

        /// <summary>
        /// Tries to convert the <see cref="string"/> from JSON to the given type <see cref="T"/>.
        /// </summary>
        /// <param name="value"> ThIs <see cref="string"/> based JSON. </param>
        /// <param name="result"> The result of type <see cref="T"/> if the value can be converted from JSON. </param>
        /// <typeparam name="T"> The type to attempt to deserialize <see cref="value"/> to. </typeparam>
        /// <returns> <c>True</c> if <see cref="value"/> can be deserialized from JSON to the given type <see cref="T"/>. </returns>
        /// <example>
        /// if ("{ \"objectName\": \"Unicorn\" }".TryFromJson&lt;MyType&gt;()) {
        ///     Debug.Log("Yup, it works.");
        /// }
        /// </example>
        public static bool TryFromJson<T>(this string value, out T result)
        {
            try
            {
                result = value.FromJson<T>();
                return true;
            }
            catch
            {
                result = default;
                return false;
            }
        }
        
        /// <summary>
        /// Reads all text from this <see cref="string"/> file path and converts content from JSON to the given type <see cref="T"/>.
        /// </summary>
        /// <param name="value"> This filepath. </param>
        /// <typeparam name="T"> The output type. </typeparam>
        /// <returns> A deserialized object of type <see cref="T"/>. </returns>
        /// <example> "myFolder/MyFile.JSON".FromJsonFile&lt;MyType&gt;(); </example>
        public static T FromJsonFile<T>(this string value)
        {
            return JsonUtility.FromJson<T>(File.ReadAllText(value));
        }

        /// <summary>
        /// Overwrites the given object by deserializing this <see cref="string"/> which should be in JSON format.     
        /// </summary>
        /// <param name="value"> This <see cref="string"/> based JSON. </param>
        /// <param name="overwriteObject"> The <see cref="object"/> to overwrite. </param>
        /// <example> "{ \"objectName\": \"Unicorn\" }".FromJsonOverwrite(new object()); </example>
        public static void FromJsonOverwrite(this string value, object overwriteObject)
        {
            JsonUtility.FromJsonOverwrite(value, overwriteObject);
        }
        
        /// <summary>
        /// Determines whether or not this <see cref="string"/> is null or whitespace. 
        /// </summary>
        /// <param name="value"> This <see cref="string"/>. </param>
        /// <returns> <c>True</c> if this <see cref="string"/> is null or whitespace, otherwise <c>false</c>. </returns>
        /// <example> "nonEmptyString".IsNullOrWhiteSpace(); </example>
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// Determines whether or not this <see cref="string"/> is null or empty. 
        /// </summary>
        /// <param name="value"> This <see cref="string"/>. </param>
        /// <returns> <c>True</c> if this <see cref="string"/> is null or empty, otherwise <c>false</c>. </returns>
        /// <example> "nonEmptyString".IsNullOrEmpty(); </example>
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
        
        /// <summary>
        /// Determines whether or not this <see cref="string"/> is null, empty, or whitespace. For those who want to be
        /// extra sure.
        /// </summary>
        /// <param name="value">This <see cref="string"/>.</param>
        /// <returns><c>True</c> if the string is null, empty, or whitespace.</returns>
        public static bool IsNullOrEmptyOrWhitespace(this string value)
        {
            return string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// Gets the last occurrence in this <see cref="string"/> after splitting it by the given <see cref="char"/> <see cref="separator"/>.
        /// </summary>
        /// <param name="value"> This <see cref="string"/>. </param>
        /// <param name="separator"> The <see cref="char"/> separator value. </param>
        /// <returns> The last occurrence of an item after splitting this <see cref="string"/>. </returns>
        public static string GetLastSplitValue(this string value, char separator)
        {
            var split = value.Split(separator);
            return split.Length > 0 ? split[split.Length - 1] : null;
        }

        /// <summary>
        /// Removes the last occurrence in this <see cref="string"/> after splitting it by the given <see cref="char"/> <see cref="separator"/> and then rejoining it.
        /// </summary>
        /// <param name="value"> This <see cref="string"/>. </param>
        /// <param name="separator"> The <see cref="char"/> separator value. </param>
        /// <returns> The original <see cref="string"/> with the final occurrence of the <see cref="separator"/> split from the end. </returns>
        /// <example> "myString,separated,ByCommas".PopLastSplitValue(',') </example>
        public static string PopLastSplitValue(this string value, char separator)
        {
            return string.Join(separator.ToString(), value.Split(separator));
        }
        
        /// <summary>
        /// Creates a new randomly generated <see cref="string"/> based on the characters provided in this <see cref="string"/>.
        /// </summary>
        /// <param name="value"> This <see cref="string"/>. </param>
        /// <param name="length"> The "length" or number of characters to use for the resulting <see cref="string"/>. </param>
        /// <returns> A randomly generated <see cref="string"/>. </returns>
        /// <example> "abcdefg".Random(20); </example>
        public static string CreateRandomStringFromSource(this string value, int length = 1)
        {
            var result = "";

            for (int i = 0; i < length; i++)
            {
                result += value[UnityEngine.Random.Range(0, value.Length)];
            }

            return result;
        }

        /// <summary>
        /// Tries to parse this <see cref="string"/> to an <see cref="int"/>.
        /// </summary>
        /// <param name="value">This <see cref="string"/>.</param>
        /// <param name="result">The result <see cref="int"/> if the operation was successful.</param>
        /// <returns><c>true</c> if the operation was successful.</returns>
        public static bool TryParseToInt(this string value, out int result)
        {
            return int.TryParse(value, out result);
        }
        
        /// <summary>
        /// Tries to parse this <see cref="string"/> to an <see cref="float"/>.
        /// </summary>
        /// <param name="value">This <see cref="string"/>.</param>
        /// <param name="result">The result <see cref="float"/> if the operation was successful.</param>
        /// <returns><c>true</c> if the operation was successful.</returns>
        public static bool TryParseToFloat(this string value, out float result)
        {
            return float.TryParse(value, out result);
        }
        
        /// <summary>
        /// Tries to parse this <see cref="string"/> to an <see cref="bool"/>.
        /// </summary>
        /// <param name="value">This <see cref="string"/>.</param>
        /// <param name="result">The result <see cref="bool"/> if the operation was successful.</param>
        /// <returns><c>true</c> if the operation was successful.</returns>
        public static bool TryParseToBool(this string value, out bool result)
        {
            return bool.TryParse(value, out result);
        }

        /// <summary> Loads a resource using this <see cref="string"/> as a path. </summary>
        /// <param name="path">This <see cref="string"/> path.</param>
        /// <typeparam name="T">The <see cref="UnityEngine.Object"/> type to load.</typeparam>
        /// <returns>The resource if found.</returns>
        public static T LoadResource<T>(this string path) where T : Object
            => Resources.Load<T>(path);

        /// <summary> Loads all resources using this <see cref="string"/> as a path. </summary>
        /// <param name="path">This <see cref="string"/> path.</param>
        /// <typeparam name="T">The <see cref="Object"/> type to load.</typeparam>
        /// <returns>The resources if found.</returns>
        public static T[] LoadResources<T>(this string path) where T : Object
            => Resources.LoadAll<T>(path);

        /// <summary> Loads a resource asynchronously using this <see cref="string"/> as a path. </summary>
        /// <param name="path">This <see cref="string"/> path.</param>
        /// <typeparam name="T">The <see cref="Object"/> type to load.</typeparam>
        /// <returns>A <see cref="ResourceRequest"/> representing the asynchronous process.</returns>
        public static ResourceRequest LoadResourcesAsync<T>(this string path) where T : Object
            => Resources.LoadAsync<T>(path);
        
        /// <summary>
        /// Converts this <see cref="value"/> into an enumeration value of the given <see cref="T"/> type. If the value
        /// cannot be parsed, the <c>default</c> value is returned instead.
        /// </summary>
        /// <param name="value">The <see cref="string"/> to parse.</param>
        /// <typeparam name="T">The type.</typeparam>
        /// <returns>The parsed type.</returns>
        public static T ParseToEnum<T>(this string value) where T : struct, Enum
        {
            return Enum.TryParse(value, out T result) ? result : default;
        }
        
        /// <summary>
        /// Clamps this <see cref="value"/> string to the given <see cref="length"/>.
        /// </summary>
        /// <param name="value">This <see cref="string"/> to clamp.</param>
        /// <param name="length">The length to clamp the string to.</param>
        /// <returns>A string clamped to the given length.</returns>
        public static string ClampLength(this string value, int length)
        {
            return value != null ? value.Length > length ? value.Substring(0, length) : value : null;
        }
    }
}