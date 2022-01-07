using System;
using System.Collections.Generic;
using System.Text;
using BL.DtoEntities;
namespace BL.Services.Interfaces
{
    interface IUser
    {
         void AddSongToPlaylist();
         void DeleteSongFromPlaylist();
         void Registration();
         bool Auntification(string _login, string _password);
         void LookProfile(Guid id_User);
        
    }
}
