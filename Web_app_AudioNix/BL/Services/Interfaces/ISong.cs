using System;
using System.Collections.Generic;
using System.Text;
using BL.DtoEntities;
namespace BL.Services.Interfaces
{
    interface ISong
    {
        
        IEnumerable<SongDTO> SortByDate();
        IEnumerable<SongDTO> SortMostPopular();
        void ViewSong(Guid id_song);
        void Download();
        IEnumerable<SongDTO> SearchSong(string nameSong);


    }
}
