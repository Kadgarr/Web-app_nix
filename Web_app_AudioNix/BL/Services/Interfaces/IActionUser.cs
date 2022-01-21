using System;
using System.Collections.Generic;
using System.Text;
using BL.DtoEntities;
namespace BL.Services.Interfaces
{
    interface IActionUser
    {
         void Registration();
         bool Auntification(string _login, string _password);
         UserDTO LookProfile(Guid id_User);
        
    }
}
