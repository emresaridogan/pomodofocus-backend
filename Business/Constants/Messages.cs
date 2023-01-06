using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string UserAdded = "Kullanıcı başarıyla eklendi";
        public static string UserDeleted = "Kullanıcı başarıyla silindi";
        public static string UserUpdated = "Kullanıcı başarıyla güncellendi";

        public static string UserNotFound = " Kullanıcı bulunamadı";
        public static string PasswordError = " Şifre yanlış";
        public static string SuccessfullLogin = " Giriş başarılı";

        public static string UserAlreadyExists = "Bu email adresine ait bir kullanıcı mevcut";
        public static string UserRegistered = "Kullanıcı kaydedildi";
        public static string AccessTokenCreated = "Access token oluşturuldu";
    }
}
