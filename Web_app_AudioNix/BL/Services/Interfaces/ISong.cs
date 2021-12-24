using System;
using System.Collections.Generic;
using System.Text;
using DL.Entities;
namespace BL.Services.Interfaces
{
    interface ISong
    {
        IEnumerable<Song> SortByInc();
        IEnumerable<Song> SortByDesc();
        IEnumerable<Song> SortByDate();
        IEnumerable<Song> SortMostPopular();
        void ViewSong(Guid id_song);
        void Download();
        IEnumerable<Song> SearchSong(string nameSong);
        void Listening();

    }
}
