using AutoMapper;
using BL.Mapping;
using System;
using BL.DtoEntities;
using DL.Entities;
using static System.Console;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();

            Genre genre_1 = new Genre();


            genre_1.GenreId = Guid.NewGuid();
            genre_1.Name_of_Genre = "Genre_Name1";

            GenreDTO genre_1DTO = mapper.Map<GenreDTO>(genre_1);
            
           
            WriteLine("Genre name: "+ genre_1.Name_of_Genre+";"+ " GenreDTO name: "+ genre_1DTO.Name_of_Genre) ;

            ReadKey();
        }
    }
}
