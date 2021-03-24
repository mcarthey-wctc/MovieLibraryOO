using System;
using Microsoft.Extensions.DependencyInjection;
using MovieLibraryOO.Data;
using MovieLibraryOO.DataModels;

namespace MovieLibraryOO
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            using (var db = new movielensContext()) {
                System.Console.WriteLine("All genres:");
                foreach (var genre in db.Genres)
                {
                    System.Console.WriteLine($"({genre.Id}) {genre.Name}");
                }

            }
            
            // // DEPENDENCY INJECTION
            // var serviceProvider = new ServiceCollection()
            //     .AddSingleton<IRepository, FileRepository>()
            //     .AddSingleton<IContext, MovieContext>()
            //     .AddSingleton<IMenu, Menu>()
            //     .BuildServiceProvider();

            // // ** still have a dependency here **
            // // var repository = new MyNewRepository();
            // // var context = new MovieContext(repository);
            // // var menu = new Menu(repository, context);

            // var menu = serviceProvider.GetService<IMenu>();
            // var userSelection = menu.GetMainMenuSelection();

            // while (menu.IsValid)
            // {
            //     menu.Process(userSelection);

            //     userSelection = menu.GetMainMenuSelection();
            // }

            Console.WriteLine("\nThanks for using the Movie Library!");
        }
    }
}