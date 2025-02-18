/*
  Class: Book.cs
  Date: Novemeber 3 2024
  Purpose: To contain author, summary, title and year information about a book object

*/

namespace Lab3
{
    /// <summary>
    /// Book class that represents a single Book object. The author, summary, title and year are contained within the object.
    /// Has a toString method to use for displaying the Book object.
    /// Inherits from Media class which holds the Book object's title and year. The Media class also enables the Book object to use the Search method.
    /// Inherits from the IEncryptable interface with Encrypt and decrypt implementations.
    /// </summary>
    public class Book : Media, IEncryptable
    {
        // Instance properties
        public string Author { get; protected set; }
        public string Summary { get; protected set; }

        /// <summary>
        /// Four argument constructor that sets the two properties Book objects have and the two properties that Media objects have
        /// </summary>
        /// <param name="Author">The author of the book</param>
        /// <param name="Summary">A summary of the book</param>
        /// <param name="title">The title of the book</param>
        /// <param name="year">The year the book was released</param>
        public Book(string Author, string Summary, string title, int year) : base(title, year)
        {
            this.Author = Author;
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
        /// ToString method used for the display of the Book object
        /// </summary>
        /// <returns>The title, author, and year of the Book object</returns>
        public override string ToString()
        {
            return $"{base.Title} by {Author} released in {base.Year}";
        }
    }
}
