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
    public class SingerIMP : ISort<SingerDTO>, IActionSinger
    {
        private readonly IMapper _mapper;
        UnityOfWork unityOfWork = new UnityOfWork();
        

        public SingerIMP()
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            _mapper= mappingConfig.CreateMapper();
        }
        public IEnumerable<SingerDTO> GetAll()
        {
            var list = _mapper.Map<List<SingerDTO>>(unityOfWork.SingerRep.GetList());

            return list;
        }

        public IEnumerable<SingerDTO> SortByDesc()
        {
            var list = _mapper.Map<List<SingerDTO>>(unityOfWork.SingerRep.GetList());

            var sortedlist = list.OrderByDescending(l => l.Name_of_singer);

            return sortedlist;
        }

        public IEnumerable<SingerDTO> SortByInc()
        {
            var list = _mapper.Map<List<SingerDTO>>(unityOfWork.SingerRep.GetList());

            var sortedlist = list.OrderBy(l => l.Name_of_singer);

            return sortedlist;
        }

        public SingerDTO ViewSinger(Guid id_singer)
        {
            var list = _mapper.Map<List<SingerDTO>>(unityOfWork.SingerRep.GetList());

            var singer = list.Find(l => l.SingerId == id_singer);

            return singer;
        }

        public IEnumerable<SongDTO> SearchBySinger(string nameSinger)
        {
            var list = _mapper.Map<List<SingerDTO>>(unityOfWork.SingerRep.GetList());

            var songs = _mapper.Map<List<SongDTO>>(unityOfWork.SongsRep.GetList());

            var name = list.Find(itm => itm.Name_of_singer == nameSinger);

            var res_list = from lst in list
                           from sng in songs
                           where sng.IdSingerNavigation.SingerId == name.SingerId
                           select sng;
            return res_list;
        }
    }
}
