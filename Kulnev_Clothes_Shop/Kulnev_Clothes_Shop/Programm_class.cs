using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kulnev_Clothes_Shop
{
    internal class Programm_class
    {
        public static string connection = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Kulnev_demo;Data Source=MEPHI3-MSSQL";
        public static int user_id = 0;
        public static int role = 0;
        public static string folder = "D:\\4 курс\\demoekz\\Kulnev_Clothes_Shop\\Kulnev_Clothes_Shop\\photo\\";
        public static bool crtbtn = false;// для доступа в корзину. Здесь проверка на наличие продукта в корзине
    }
}
