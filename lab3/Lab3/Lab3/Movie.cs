/*
  Class: Movie.cs
  Date: Novemeber 3 2024
  Purpose: To contain director, summary, title and year information about a Movie object, as well as encrypt, decrypt and search capabilities

*/

namespace Lab3
{
    /// <summary>
    /// Movie class that represents a single Movie object. The director, summary, title and year are contained within the object.
    /// Has a toString method to use for displaying the Movie object.
    /// Inherits from Media class which holds the Movie object's title and year. The Media class also enables the Movie object to use the Search method.
    /// Inherits from the IEncryptable interface with Encrypt and decrypt implementations.
    /// </summary>
    public class Movie : Media, IEncryptable
    {
        // Instance properties
        public string Director {  get; protected set; }
        public string Summary { get; protected set; }

        /// <summary>
        /// Four argument constructor that sets the two properties Movie objects have and the two properties that Media objects have
        /// </summary>
        /// <param name="Director">The director of the movie</param>
        /// <param name="Summary">A summary of the movie</param>
        /// <param name="title">The title of the movie</param>
        /// <param name="year">the year the movie was released</param>
        public Movie(string Director, string Summary, string title, int year) : base(title, year)
        {
            this.Director = Director;
            this.Summary = Summary;
        }

        /// <summary>
        /// This method encrypts characters using ROT13. This shifts only letters by 13. The method will iterate over each character one by one, 
        /// and as long as the character is a letter, it will apply the shift, ignoring other characters and reconstructing the string.
        /// </summary>
        /// <returns>the encrypted string</returns>
        public string Encrypt()
        {
            string encrypt = string.Empty;
            for (int i = 0; i <= Summary.Length - 1; i++)
            {
                char c = Summary[i];
                // lowercase boundaries
                if (c >= 97 && c <= 122)
                {
                    int newChar = c + 13;
                    // if over boundary, start from beginning of letters again
                    if (newChar > 122)
                    {
                        newChar -= 26;
                    }
                    encrypt += (char)newChar;
                }
                // uppercase boundaries
                else if (c >= 65 && c <= 90)
                {
                    int newChar = c + 13;
                    // if over boundary, start from beginning of letters again
                    if (newChar > 90)
                    {
                        newChar -= 26;
                    }
                    encrypt += (char)newChar;
                }
                // only change letters
                else
                {
                    encrypt += (char)c;
                }
            }
            return encrypt;
        }

        /// <summary>
        /// Due to the encryption method being ROT13, this method just calls Encrypt() which will also decrypt the string
        /// </summary>
        /// <returns>the decrypted string</returns>
        public string Decrypt()
        {
            return Encrypt();
        }

        /// <summary>
        /// ToString method used for the display of the Movie object
        /// </summary>
        /// <returns>The title, director, and year of the Movie object</returns>
        public override string ToString()
        {
            return $"{base.Title} by {Director} released in {base.Year}";
        }
    }
}
