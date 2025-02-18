/*
  Class: Song.cs
  Date: Novemeber 3 2024
  Purpose: To contain album, artist, title and year information about a song object as well as search capablilites

*/

namespace Lab3
{
    /// <summary>
    /// Song class that represents a single Song object. The Song's album, artist, title and year are contained within the object.
    /// Has a toString method to use for displaying the Song object.
    /// Inherits from Media class which holds the Song object's title and year. The Media class also enables the Song object to use the Search method.
    /// </summary>
    public class Song : Media
    {
        // Instance properties with public getters and protected setters
        public string Album {  get; protected set; }
        public string Artist { get; protected set; }

        /// <summary>
        /// Four argument constructor that sets the two properties Song objects have and the two properties that media objects have
        /// </summary>
        /// <param name="Album">The album the song is bundled with</param>
        /// <param name="Artist">The artist responsible for making the song</param>
        /// <param name="title">The title of the song</param>
        /// <param name="year">The year the song was released</param>
        public Song(string Album, string Artist, string title, int year) : base(title, year)
        {
            this.Album = Album;
            this.Artist = Artist;
        }

        /// <summary>
        /// ToString method used for the display of the Song object
        /// </summary>
        /// <returns>The title, artist, album and year of the Song object</returns>
        public override string ToString()
        {
            return $"{base.Title} by {Artist} featured in {Album} released in {base.Year}";
        }
    }
}
