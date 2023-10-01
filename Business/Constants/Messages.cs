using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarNoAdded = "Araba ismi en az 2 karakterden olusmalidir ve gunluk fiyati 0 dan buyuk olmalidir";
        public static string MaintenacneTime = "Site bakimda";
        public static string ProductsListed = "Araclar listelendi";
        public static object CarDetailDto = "Araba detaylari";
        public static string CarUpdate = "Arac Guncellendi";
        internal static string CarDelete = "Arac silindi";
    }
}
