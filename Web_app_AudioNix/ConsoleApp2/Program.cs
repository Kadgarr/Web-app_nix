using System;
using DL.Entities;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static AutoResetEvent waitHandler = new AutoResetEvent(true);
        static void Main(string[] args)
        {
            //Genre genre = new Genre();
            //genre.GenreId = Guid.NewGuid();
            //genre.Name_of_Genre = "Genre1";

            //string str=JsonSerializer.Serialize<Genre>( genre);
            //Console.WriteLine("Объект был записан");
            //File.WriteAllText("genre.json", str);

            //string str1 = File.ReadAllText("genre.json");

            //Genre genre_1 = JsonSerializer.Deserialize<Genre>(str1);

            //Console.WriteLine(genre_1.GenreId+" "+genre_1.Name_of_Genre);
            
            Thread myThread = new Thread(WriteFile);
            Thread myThread_1 = new Thread(ReadFile);
            myThread.Name = "Поток write";
            myThread_1.Name = "Поток read";

            myThread_1.Start();
            myThread.Start();
            
            Console.ReadKey();
        }
        public static void WriteFile()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name}");

           Genre genre = new Genre();
            genre.GenreId = Guid.NewGuid();
            genre.Name_of_Genre = "Genre1";

            string str = JsonSerializer.Serialize<Genre>(genre);
            Console.WriteLine("Объект был записан");

            File.WriteAllText("genre.json", str);

            waitHandler.Set();
        }

        public static void ReadFile()
        {
            waitHandler.WaitOne();

            Console.WriteLine($"{Thread.CurrentThread.Name}");

            string str1 = File.ReadAllText("genre.json");

            Genre genre_1 = JsonSerializer.Deserialize<Genre>(str1);

            Console.WriteLine(genre_1.GenreId + " " + genre_1.Name_of_Genre);
        }
    }
}
