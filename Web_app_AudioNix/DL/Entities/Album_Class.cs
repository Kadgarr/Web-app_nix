using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_app_AudioNix.DL
{
    public class Album_Class
    {
       protected internal int ID_Album { get; set; }
       protected internal string name_of_album { get; set; }
       protected internal DateTime date_of_release { get; set; }
       protected internal int id_singer { get; set; }

       protected internal Singer_Class id_singerNavigation { get; set; }
    }
}
