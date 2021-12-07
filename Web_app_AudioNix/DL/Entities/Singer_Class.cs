using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_app_AudioNix.DL
{
    public class Singer_Class
    {
        protected internal int ID_Singer { get; set; }
        protected internal string name_of_singer { get; set; }
        protected internal string image { get; set; }
        protected internal string description { get; set; }

        protected internal List<Song_Class> songs { get; set; }
        protected internal List<Album_Class> albums { get; set; }
    }
}
