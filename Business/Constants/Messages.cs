using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarDeleted = "Araba silindi";
        public static string CarDailyPriceInvalid = "Günlük fiyat değeri geçersiz";
        public static string CarAdded = "Araba eklendi";
        public static string CarUpdated = "Araba güncellendi";

        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string BrandAdded = "Marka eklendi";
        public static string ColorAdded = "Renk eklendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";

        public static string RentalAdded = "Kiralama işlemi yapıldı";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalRentDateInvalid = "Kiralama tarihi geçersiz";

        public static string CarImageAdded = "Araba resmi eklendi";

        public static string CarImageLimitExceeded = "Resim ekleme limiti doldu";
        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";

        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";


    }
}
