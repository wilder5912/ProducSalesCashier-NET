using store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace store.service
{
    public class UserService
    {
        public user getUser(UserMO userMO)
        {
            user userData = new user();
            userData.firt_name_user = userMO.FirtNameUser;
            userData.last_name_user = userMO.LastNameUser;
            userData.email_user = userMO.EmailUser;
            userData.password_user = userMO.PasswordUser;
            userData.type_user = userMO.TypeUser;
            userData.imagen_user = userMO.ImagenUser;
            userData.token_user = userMO.TokenUser;

            return userData;
        }
    }
}