using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_app_AudioNix.DL;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            User_Class user = new User_Class { /*ID_User = 1,*/ email="asfsfsdf",login="sdfsdfsdfsdf",password="123456"};
            
            var results = new List<ValidationResult>();
            var context = new ValidationContext(user);
            if (!Validator.TryValidateObject(user, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }

            
            Console.ReadKey();
        }
    }
}
