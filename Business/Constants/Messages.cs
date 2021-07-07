using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarDeleted = "Araç silindi";
        public static string CarUpdated = "Araç güncellendi";
        public static string CarNameInvalid = "Araç Eklenemedi, lütfen kurallara uygun araç ekleyiniz.";
        public static string CarsListed = "Araçlar listelendi";

        public static string Added = "Ekleme işlemi başarılı";
        public static string Deleted = "Silme işlemi başarılı";
        public static string Updated = "Güncelleme işlemi başarılı";

        public static string colorNameInvalid = "Renk geçersiz";
        public static string ColorsListed = "Renkler listelendi";

        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string BrandsListed = "Markalar listelendi";

        public static string MaintenanceTime = "Sistem şuan da bakımda";

        public static string UsersListed = "Kullanıcılar listelendi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string RentalsListed = "Kiralık araçlar listelendi";
        public static string ReturnDateError = "Araba teslim edilememiştir";

        public static string ImagesListed = "Resimler listelendi";
        public static string ImageFound = "Resim bulundu";
        public static string carImageLimit = "En fazla 5 adet resim yükleyebilirsiniz";

        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kullanıcı kayıt edildi.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Hatalı şifre";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Kullanıcı mevcut.";
        public static string AccessTokenCreated = "Token Oluşturuldu.";
    }
}
