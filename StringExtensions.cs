using System.IO;
using System.Linq;
using UnityEngine;

namespace Auxtensions
{
    /// <summary>
    /// String extensions which provide additional functionality for <c>string</c> typed variables.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        ///     Converts this <see cref="string"/> from JSON to the given type <see cref="T"/>.
        /// </summary>
        /// <param name="string">
        ///     This <see cref="string"/> based JSON.
        /// </param>
        /// <typeparam name="T">
        ///     The output type.
        /// </typeparam>
        /// <returns>
        ///     A deserialized object of type <see cref="T"/>.
        /// </returns>
        /// <example>
        ///     "{ \"objectName\": \"Unicorn\" }".FromJson&lt;MyType&gt;();
        /// </example>
        public static T FromJson<T>(this string @string)
        {
            return JsonUtility.FromJson<T>(@string);
        }
        
        /// <summary>
        ///     Reads all text from this <see cref="string"/> file path and converts content from JSON to the given type <see cref="T"/>.
        /// </summary>
        /// <param name="string">
        ///     This filepath.
        /// </param>
        /// <typeparam name="T">
        ///     The output type.
        /// </typeparam>
        /// <returns>
        ///     A deserialized object of type <see cref="T"/>.
        /// </returns>
        /// <example>
        ///     
        /// </example>
        public static T FromJsonFile<T>(this string @string)
        {
            return JsonUtility.FromJson<T>(File.ReadAllText(@string));
        }

        /// <summary>
        ///     Overwrites the given object by deserializing this <see cref="string"/> which should be in JSON format.     
        /// </summary>
        /// <param name="string">
        ///     This <see cref="string"/> based JSON.
        /// </param>
        /// <param name="overwriteObject">
        ///     The <see cref="object"/> to overwrite.
        /// </param>
        public static void FromJsonOverwrite(this string @string, object overwriteObject)
        {
            JsonUtility.FromJsonOverwrite(@string, overwriteObject);
        }
        
        /// <summary>
        ///     Determines whether or not this <see cref="string"/> is null or whitespace. 
        /// </summary>
        /// <param name="string">
        ///     This <see cref="string"/>.
        /// </param>
        /// <returns>
        ///     <c>True</c> if this <see cref="string"/> is null or whitespace, otherwise <c>false</c>.
        /// </returns>
        public static bool IsNullOrWhiteSpace(this string @string)
        {
            return string.IsNullOrWhiteSpace(@string);
        }

        /// <summary>
        ///     Determines whether or not this <see cref="string"/> is null or empty. 
        /// </summary>
        /// <param name="string">
        ///     This <see cref="string"/>.
        /// </param>
        /// <returns>
        ///     <c>True</c> if this <see cref="string"/> is null or empty, otherwise <c>false</c>.
        /// </returns>
        public static bool IsNullOrEmpty(this string @string)
        {
            return string.IsNullOrEmpty(@string);
        }

        /// <summary>
        ///     Removes the last item in this <see cref="string"/> if it were separated by a <see cref="char"/> <see cref="separator"/>.
        /// </summary>
        /// <param name="string">
        ///     This <see cref="string"/>.
        /// </param>
        /// <param name="separator">
        ///     The <see cref="char"/> separator value.
        /// </param>
        /// <returns>
        ///     The original <see cref="string"/> with the final occurrence of the <see cref="separator"/> split from the end.
        /// </returns>
        public static string PopLastSplitValue(this string @string, char separator)
        {
            return string.Join(separator.ToString(), @string.Split(separator));
        }
        
        /// <summary>
        ///     Creates a new randomly generated <see cref="string"/> based on the characters provided in this <see cref="string"/>.
        /// </summary>
        /// <param name="string">
        ///     This <see cref="string"/>.
        /// </param>
        /// <param name="length">
        ///     The "length" or number of characters to use for the resulting <see cref="string"/>.
        /// </param>
        /// <returns>
        ///     A randomly generated <see cref="string"/>.
        /// </returns>
        public static string Random(this string @string, int length = 1)
        {
            var result = "";

            for (int i = 0; i < length; i++)
            {
                result += @string[UnityEngine.Random.Range(0, @string.Length)];
            }

            return result;
        }
    }
}