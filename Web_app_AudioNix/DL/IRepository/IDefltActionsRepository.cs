using System;
using System.Collections.Generic;
using System.Text;

namespace DL.IRepository
{
    interface IRepository<T> where T:class
    {
        public void Download();
        public void View();
        public void AddSongToPlaylist();
        public void DeleteSongFromPlaylist();
        public void Registration();
        public void Auntification();
        public void LookProfile();

    }
}
