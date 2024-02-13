using System;

namespace BookClass
{
    //Book class
    class Book
    {
        //attributes
        string title;
        string author;
        int publicationYear;
        string genre;

        //constructor
        public Book(string bookTitle, string bookAuthor, int bookPublicationYear, string bookGenre)
        {
            title = bookTitle;
            author = bookAuthor;
            publicationYear = bookPublicationYear;
            genre = bookGenre;
        }

        //Method to get summary of the book
        public void GetSummary()
        {
            Console.WriteLine("Book Summary...");
            Console.WriteLine("Title : " + title);
            Console.WriteLine("Author : " + author);
            Console.WriteLine("Publication Year : " + publicationYear);
            Console.WriteLine("Genre : " + genre);
        }

    }
}