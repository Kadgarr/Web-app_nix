using System;
using System.Collections.Generic;
using System.Text;
using BL.Services.Interfaces;
using BL.DtoEntities;
using AutoMapper;
using System.Linq;
using BL.Mapping;
using DL;

namespace BL.Services.Implementations
{
    public class UserIMP : ISort<UserDTO>, IActionUser
    {
        private readonly IMapper _mapper;
        private UnityOfWork unityOfWork;

        public UserIMP(ApplicationContext db)
        {
            unityOfWork = new UnityOfWork(db);
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            _mapper= mappingConfig.CreateMapper();
        }

        public bool Auntification(string _login, string _password)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> GetAll()
        {
            var list = _mapper.Map<List<UserDTO>>(unityOfWork.UserRep.GetList());

            return list;
        }

        public UserDTO LookProfile(Guid id_User)
        {
            var list = _mapper.Map<List<UserDTO>>(unityOfWork.UserRep.GetList());

            var profile = list.Find(l => l.UserId == id_User);

            return profile;
        }

        public void Registration()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> SortByDesc()
        {
            var list = _mapper.Map<List<UserDTO>>(unityOfWork.UserRep.GetList());

            var sortedlist = list.OrderByDescending(l => l.Login);

            return sortedlist;
        }

        public IEnumerable<UserDTO> SortByInc()
        {
            var list = _mapper.Map<List<UserDTO>>(unityOfWork.UserRep.GetList());

            var sortedlist = list.OrderBy(l => l.Login);

            return sortedlist;
        }
    }
}
