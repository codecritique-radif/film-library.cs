using System;
using System.Collections.Generic;

namespace FilmLibrary
{
    class Film
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }

        public Film(string title, string director, int year, string genre)
        {
            Title = title;
            Director = director;
            Year = year;
            Genre = genre;
        }
    }

    class FilmLibrary
    {
        private List<Film> films;

        public FilmLibrary()
        {
            films = new List<Film>();
        }

        public void AddFilm(Film film)
        {
            films.Add(film);
        }

        public void DisplayFilms()
        {
            Console.WriteLine("Film Library:");
            foreach (Film film in films)
            {
                Console.WriteLine($"Title: {film.Title}");
                Console.WriteLine($"Director: {film.Director}");
                Console.WriteLine($"Year: {film.Year}");
                Console.WriteLine($"Genre: {film.Genre}");
                Console.WriteLine("-----------------------------");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FilmLibrary library = new FilmLibrary();

            // Add films to the library
            Film film1 = new Film("Inception", "Christopher Nolan", 2010, "Sci-Fi");
            library.AddFilm(film1);

            Film film2 = new Film("The Shawshank Redemption", "Frank Darabont", 1994, "Drama");
            library.AddFilm(film2);

            Film film3 = new Film("Pulp Fiction", "Quentin Tarantino", 1994, "Crime");
            library.AddFilm(film3);

            // Display films in the library
            library.DisplayFilms();

            Console.ReadLine();
        }
    }
}