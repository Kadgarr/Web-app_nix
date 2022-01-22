using System;
using System.Collections.Generic;
using System.Text;
using BL.DtoEntities;
namespace BL.Services.Interfaces
{
    interface IActionSong
    {
        
        IEnumerable<SongDTO> SortByDate();
        IEnumerable<Playlist_of_UserDTO> SortMostPopular();
        SongDTO ViewSong(Guid id_song);
        IEnumerable<SongDTO> SearchSong(string nameSong);
        IEnumerable<Genres_of_MusicDTO> SearchByGenre(Guid id_genre);


    }
}
