using Azure.Core;
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
        public static string CarDelete = "Arac silindi";

        public static string BrandsListed = "Markalar Listelendi";
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdate = "Marka Güncellendi";

        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdate = "Renk Güncellendi";
        public static string ColorListed = "Tum renkler getirildi";
        public static string ColorId = "Rengin id numarasi getirildi";

        public static string CustomersListed = "Musteriler Listelendi";
        public static string CustomerAdded = "Musteri Eklendi";
        public static string CustomerDeleted = "Musteri Silindi";
        public static string CustomerUpdate = "Musteri Güncellendi";

        public static string UserAdded = "Kullanici Eklendi";
        public static string UserDeleted = "Kullanici Silindi";
        public static string UserrUpdate = "Kullanici Güncellendi";

        public static string RentalAdded = "Kiralama Eklendi";
        public static string RentalDeleted = "Kirlama Silindi";
        public static string RentalUpdate = "Kiralama Güncellendi";
        public static string RentalListed = "Kiralama renkler getirildi";
    }
}
