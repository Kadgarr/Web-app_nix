using System;
using System.Collections.Generic;
using System.Text;
using BL.Services.Interfaces;
using BL.DtoEntities;
using AutoMapper;
using System.Linq;
using BL.Mapping;
using DL;
using System.Threading.Tasks;
using DL.Entities;

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
            _mapper = mappingConfig.CreateMapper();
        }

       
        public bool Auntification(string _login, string _password)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserDTO>> GetAll()
        {
            var list = _mapper.Map<List<UserDTO>>(await unityOfWork.UserRep.GetListAsync());

            return list;
        }

        public UserDTO LookProfile(Guid id_User)
        {
            var list = _mapper.Map<List<UserDTO>>(unityOfWork.UserRep.GetListAsync());

            var profile = list.Find(l => l.UserId == id_User);

            return profile;
        }

        public void Registration()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserDTO>> SortByDesc()
        {
            var list = _mapper.Map<List<UserDTO>>(await unityOfWork.UserRep.GetListAsync());

            var sortedlist = list.OrderByDescending(l => l.Login);

            return sortedlist;
        }

        public async Task<IEnumerable<UserDTO>> SortByInc()
        {
            var list = _mapper.Map<List<UserDTO>>(await unityOfWork.UserRep.GetListAsync());

            var sortedlist = list.OrderBy(l => l.Login);

            return sortedlist;
        }



        public async Task AddUser(string login, string password, string email, string picture)
        {
            var userDTO = new UserDTO { UserId = new Guid(), Login = login, Date_of_registration= new DateTime().Date, Email=email, Password=password, Picture=picture   };
            var user = _mapper.Map<User>(userDTO);
            unityOfWork.UserRep.Add(user);
        }

        //public async Task EditUser(UserDTO genreDTO)
        //{
        //    var genre = _mapper.Map<User>(genreDTO);

        //    await unityOfWork.UserRep.ChangeAsync(genre);
        //}

        //public async Task RemoveUser(UserDTO genreDTO)
        //{
        //    var genre = _mapper.Map<User>(genreDTO);

        //    await unityOfWork.UserRep.DeleteAsync(genre.GenreId);
        //}

        //public async Task<UserDTO> GetItemAsync(Guid id)
        //{
        //    return _mapper.Map<UserDTO>(await unityOfWork.UserRep.GetItemAsync(id));
        //}
    }
}
