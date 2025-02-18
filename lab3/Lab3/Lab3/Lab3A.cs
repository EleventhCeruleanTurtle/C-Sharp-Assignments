using System;
using System.IO;

/*
  Class: Lab3A.cs
  Date: Novemeber 3 2024
  Purpose: To read data from a file to an array for user viewing and searching.

*/

namespace Lab3
{
    /// <summary>
    /// Main for the Lab3A assignment.
    /// This program will read through the Data.txt file, determine the type of media, create the appropriate Media object, and then add it to the data array.
    /// This program then prompts the user with a menu allowing them to view the media and search for a specific entry.
    /// </summary>
    public class Lab3A
    {
        /// <summary>
        /// Reads the data from the provided file. Built specifically for the Data.txt file format which involves | seperating data and ----- indicating the end of an entry
        /// Reads line by line to determine the type of media, then continues reading to collect the relevant summary until the end of the entry is located. 
        /// Then the program adds the new Media object to the data array.
        /// </summary>
        /// <param name="filepath">the deignated filepath to read from</param>
        /// <returns>an ISeachable array of media from the provided file</returns>
        internal static ISearchable[] ReadData(string filepath)
        {
            // instatiate variables
            ISearchable[] data = new ISearchable[100];
            // check if file exists
            if (!File.Exists(filepath)) 
            { 
                Console.WriteLine($"The filepath ({filepath}) does not exist"); 
                return data;
            }
            FileStream file = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(file);
            int count = 0;
            string desc = string.Empty;
            string[] exploded = new string[4];

            // read file until end of data
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                
                // determine what the media is an split it by the designated | symbol
                if (line.Contains("MOVIE"))
                {
                    exploded = line.Split('|');
                } else if (line.Contains("BOOK"))
                {
                    exploded = line.Split('|');
                    
                } else if (line.Contains("SONG"))
                {
                    exploded = line.Split('|');
                    
                } else if (line.Contains("-----"))
                {
                    // when end of entry is found, complile exploded array containing media infomation and desc string variable into appropriate Media object
                    if (exploded[0] == "MOVIE")
                    {
                        Movie movie = new Movie(exploded[3], desc, exploded[1], Int32.Parse(exploded[2]));
                        data[count++] = movie;
                        desc = string.Empty;
                    } else if (exploded[0] == "BOOK")
                    {
                        Book book = new Book(exploded[3], desc, exploded[1], Int32.Parse(exploded[2]));
                        data[count++] = book;
                        desc = string.Empty;
                    } else if (exploded[0] == "SONG")
                    {
                        Song song = new Song(exploded[3], exploded[4], exploded[1], Int32.Parse(exploded[2]));
                        data[count++] = song;
                        desc = string.Empty;
                    }

                } else
                {
                    // if new entry or end of entry not found, add line to desc
                    desc += line;
                }
            }
            return data;
        }
        /// <summary>
        /// calls the ReadData method to create an ISearchable array of data from Data.txt
        /// Then display menu to enable viewing of specific Media object types or to search for a specific entry.
        /// </summary>
        /// <param name="args">Unused default parameter</param>
        static void Main(string[] args)
        {
            ISearchable[] data = ReadData("Data.txt");
            // menu
            while (true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. List All Books");
                Console.WriteLine("2. List All Movies");
                Console.WriteLine("3. List All Songs");
                Console.WriteLine("4. List All Media");
                Console.WriteLine("5. Search All Media by Title");
                Console.WriteLine("6. Exit Program");
                string response = Console.ReadLine();
                // list all books
                if (response == "1") 
                {
                    foreach (ISearchable item in data) 
                    {
                        if(item != null && item.GetType() == typeof(Book))
                        {
                            Console.WriteLine(item);
                        }
                    }
                } 
                // list all movies
                else if (response == "2") 
                {
                    foreach (ISearchable item in data)
                    {
                        if (item != null && item.GetType() == typeof(Movie))
                        {
                            Console.WriteLine(item);
                        }
                    }
                } 
                // list all songs
                else if (response == "3") 
                {
                    foreach (ISearchable item in data)
                    {
                        if (item != null && item.GetType() == typeof(Song))
                        {
                            Console.WriteLine(item);
                        }
                    }
                } 
                // list all media
                else if (response == "4") 
                {
                    foreach (ISearchable item in data)
                    {
                        if (item != null)
                        {
                            Console.WriteLine(item);
                        }
                    }
                } 
                // search for specific entry given a key
                else if (response == "5") 
                {
                    Console.WriteLine("Enter the title you are searching for: ");
                    string searchQuery = Console.ReadLine();
                    Console.WriteLine("Results:");
                    foreach (ISearchable item in data)
                    {
                        if (item != null)
                        {
                            if (item.Search(searchQuery))
                            {
                                Console.WriteLine(item);
                                if (item.GetType() == typeof(Book))
                                {
                                    Book book = (Book)item;
                                    Console.WriteLine(book.Decrypt());
                                } else if (item.GetType() == typeof(Movie))
                                {
                                    Movie movie = (Movie)item;
                                    Console.WriteLine(movie.Decrypt());
                                }
                            }
                        }
                    }
                } 
                // exit
                else if (response == "6") 
                {
                    break;
                } 
                // catch all for invalid input
                else { Console.WriteLine("Invalid input."); }
            }
        }
    }
}
