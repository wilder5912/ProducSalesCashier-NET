using store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 
using store.service;
 
using System.Web.Mvc;

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

        public UserMO getUserMOInformation(user userI)
        {
            UserMO userMO = new UserMO();
            userMO.userId = userI.user_id;
            userMO.FirtNameUser = userI.firt_name_user ;
            userMO.LastNameUser = userI.last_name_user ;
            userMO.EmailUser = userI.email_user;
            userMO.PasswordUser = userI.password_user;
            userMO.TypeUser = userI.type_user ;
            userMO.ImagenUser = userI.imagen_user;
            userMO.TokenUser = userI.token_user;

            return userMO;
        }

        public bool  addUser(UserMO userMO) {
            try
            {
                using (var db = new storeEntities())
                {
                    db.user.Add(this.getUser(userMO));
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
        public UserMO getUserInformation(UserMO userMO)
        {
            UserMO userInst = null;
            try
            {  
                using (var db = new storeEntities())
                {
                     userInst = this.getUserMOInformation(db.getUser1(userMO.EmailUser,userMO.PasswordUser).SingleOrDefault());
                    return userInst;
                }
            }
            catch (Exception)
            {
                return userInst;
            }
           
  
        }
        public UserMO getCurrentUserMO(int idUser) {

            try
            {
                using (var db = new storeEntities())
                {
                   return getUserMOInformation( db.user.Where(infoUser => infoUser.user_id == idUser).SingleOrDefault());

                }
            }
            catch (Exception)
            {
                
                return null;
            }

            
        }



    }
}