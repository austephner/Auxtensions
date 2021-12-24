namespace Auxtensions
{
    /// <summary>
    /// Character extensions which provide additional functionality for <see cref="char"/> typed variables.
    /// </summary>
    public static class CharExtensions
    {
        /// <summary>
        ///     Determines whether or not this <see cref="char"/> is a letter or digit.
        /// </summary>
        /// <param name="character">
        ///     This <see cref="char"/>.
        /// </param>
        /// <returns>
        ///     <c>True</c> if this <see cref="char"/> is a letter or digit, otherwise <c>false</c>.
        /// </returns>
        public static bool IsLetterOrDigit(this char character)
        {
            return char.IsLetterOrDigit(character);
        }

        /// <summary>
        ///     Determines whether or not this <see cref="char"/> is a.
        /// </summary>
        /// <param name="character">
        ///     This <see cref="char"/>.
        /// </param>
        /// <returns>
        ///     <c>True</c> if this <see cref="char"/> is a letter, otherwise <c>false</c>.
        /// </returns>
        public static bool IsLetter(this char character)
        {
            return char.IsLetter(character);
        }

        /// <summary>
        ///     Determines whether or not this <see cref="char"/> is a digit.
        /// </summary>
        /// <param name="character">
        ///     This <see cref="char"/>.
        /// </param>
        /// <returns>
        ///     <c>True</c> if this <see cref="char"/> is a digit, otherwise <c>false</c>.
        /// </returns>
        public static bool IsDigit(this char character)
        {
            return char.IsDigit(character);
        }

        /// <summary>
        ///     Determines whether or not this <see cref="char"/> is a special character (punctuation, symbol, control, or separator).
        /// </summary>
        /// <param name="character">
        ///     This <see cref="char"/>.
        /// </param>
        /// <returns>
        ///     <c>True</c> if this <see cref="char"/> is a special character, otherwise <c>false</c>.
        /// </returns>
        public static bool IsSpecialCharacter(this char character)
        {
            return char.IsPunctuation(character) ||
                   char.IsSymbol(character) ||
                   char.IsControl(character) ||
                   char.IsSeparator(character);
        }

        /// <summary>
        ///     Determines whether or not this <see cref="char"/> is a period (".") character.
        /// </summary>
        /// <param name="character">
        ///     This <see cref="char"/>.
        /// </param>
        /// <returns>
        ///     <c>True</c> if this <see cref="char"/> is a period, otherwise <c>false</c>.
        /// </returns>
        public static bool IsPeriod(this char character)
        {
            return character == '.'; 
        }

        /// <summary>
        ///     Determines whether or not this <see cref="char"/> is a whitespace character (" ").
        /// </summary>
        /// <param name="character">
        ///     This <see cref="char"/>.
        /// </param>
        /// <returns>
        ///     <c>True</c> if this <see cref="char"/> is a whitespace character, otherwise <c>false</c>.
        /// </returns>
        public static bool IsWhiteSpace(this char character)
        {
            return char.IsWhiteSpace(character);
        }
    }
}