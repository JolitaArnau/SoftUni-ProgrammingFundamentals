namespace Pr05BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    class Pr05And06BookLibrary
    {
        static void Main()
        {
            int countOfBooks = int.Parse(Console.ReadLine());

            var library = new Library()
            {
                Books = new List<Book>()
            };

            for (int i = 0; i < countOfBooks; i++)
            {
                var currentBook = Console.ReadLine().Split(' ');

                var book = new Book()
                {
                    Title = currentBook[0],
                    Author = currentBook[1],
                    Publisher = currentBook[2],
                    ReleaseDate = DateTime.ParseExact(currentBook[3],
                    "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = currentBook[4],
                    Price = decimal.Parse(currentBook[5])
                };

                library.Books.Add(book);
            }

            var dateForQueryAsString = Console.ReadLine();

            DateTime dateForQuery = DateTime.ParseExact(dateForQueryAsString, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            PrintBooksByAuthorAndTotalPrice(library);
            PrintBooksAfterGivenDate(library, dateForQuery);
        }

        public static void PrintBooksByAuthorAndTotalPrice(Library library)
        {

            foreach (var book in library.Books
                     .GroupBy(b => b.Author)
                     .OrderByDescending(x => x.Sum(p => p.Price))
                     .ThenBy(k => k.Key))
            {
                Console.WriteLine($"{book.Key} -> {book.Sum(p => p.Price):f2}");
            }
        }

        public static void PrintBooksAfterGivenDate(Library library, DateTime dateForQuery)
        {
            foreach (var book in library.Books
                    .Where(b => b.ReleaseDate > dateForQuery)
                    .OrderBy(d => d.ReleaseDate)
                    .ThenBy(t => t.Title))
            {
                var formattedDate = book.ReleaseDate.ToString("dd.MM.yyyy");

                Console.WriteLine($"{book.Title} -> {book.ReleaseDate.ToString("dd.MM.yyyy")}");
            }
        }
    }
}
