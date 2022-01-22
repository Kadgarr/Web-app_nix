using System;
using DL.Entities;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static AutoResetEvent waitHandler = new AutoResetEvent(true);
        static void Main(string[] args)
        {
            Genre genre = new Genre();
            genre.GenreId = Guid.NewGuid();
            genre.Name_of_Genre = "Genre2";
            Genre genre2 = new Genre();
            genre2.GenreId = Guid.NewGuid();
            genre2.Name_of_Genre = "Genre1";
            Genre genre3 = new Genre();
            genre3.GenreId = genre.GenreId;
            genre3.Name_of_Genre = "Genre2";
            Genre genre4 = new Genre();
            genre4.GenreId = Guid.NewGuid();
            genre4.Name_of_Genre = "Genre3";
            Genre genre5 = new Genre();
            genre5.GenreId = genre.GenreId;
            genre5.Name_of_Genre = "Genre2";
            Genre genre6 = new Genre();
            genre6.GenreId = genre4.GenreId;
            genre6.Name_of_Genre = "Genre3";

            //string str=JsonSerializer.Serialize<Genre>( genre);
            //Console.WriteLine("Объект был записан");
            //File.WriteAllText("genre.json", str);

            //string str1 = File.ReadAllText("genre.json");

            //Genre genre_1 = JsonSerializer.Deserialize<Genre>(str1);

            //Console.WriteLine(genre_1.GenreId+" "+genre_1.Name_of_Genre);

            //Thread myThread = new Thread(WriteFile);
            //Thread myThread_1 = new Thread(ReadFile);
            //myThread.Name = "Поток write";
            //myThread_1.Name = "Поток read";

            //myThread_1.Start();
            //myThread.Start();

            List<Genre> list = new List<Genre>();

            list.Add(genre);
            list.Add(genre2);
            list.Add(genre3);
            list.Add(genre4);
            list.Add(genre5);
            list.Add(genre6);

            foreach (var lst in list)
            {
                Console.WriteLine(lst.Name_of_Genre+ " "+lst.GenreId);
            }

            var list2 = list.GroupBy(x => x.GenreId).OrderByDescending(x => x.Count());

        
            foreach (var lst in list2)
            {
                Console.WriteLine(lst.Key);
                foreach(var l in lst)
                {
                    Console.WriteLine(l.Name_of_Genre+" "+l.GenreId);
                    list.Add(l);
                }
            }
            var finalList = new List<Genre>();
            foreach (var lst in list2)
            { 
                
                    finalList.Add(list.FirstOrDefault(x=>x.GenreId==lst.Key));
                   
                
            }
                Console.WriteLine("finallist-"+finalList.Count);
            foreach (var lst in finalList)
            {
                Console.WriteLine(lst.Name_of_Genre+" "+lst.GenreId) ;
            }
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
