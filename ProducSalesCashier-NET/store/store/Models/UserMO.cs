using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace store.Models
{
    public class UserMO
    {
        public decimal userId { get; set; }
        [Required]
        private string firtNameUser;
        [Required]
        private string lastNameUser;
        [Required]
        private string emailUser;
        [Required]
        private string passwordUser;
        [Required]
        private string typeUser;
        private string imagenUser;
        private string tokenUser;
        private string codeUser;

        [Required]
        public string FirtNameUser
        {
            get
            {
                return firtNameUser;
            }

            set
            {
                firtNameUser = value;
            }
        }

        public string LastNameUser
        {
            get
            {
                return lastNameUser;
            }

            set
            {
                lastNameUser = value;
            }
        }

        public string EmailUser
        {
            get
            {
                return emailUser;
            }

            set
            {
                emailUser = value;
            }
        }

        public string PasswordUser
        {
            get
            {
                return passwordUser;
            }

            set
            {
                passwordUser = value;
            }
        }

        public string TypeUser
        {
            get
            {
                return typeUser;
            }

            set
            {
                typeUser = value;
            }
        }

        public string ImagenUser
        {
            get
            {
                return imagenUser;
            }

            set
            {
                imagenUser = value;
            }
        }

        public string TokenUser
        {
            get
            {
                return tokenUser;
            }

            set
            {
                tokenUser = value;
            }
        }

        public string CodeUser
        {
            get
            {
                return codeUser;
            }

            set
            {
                codeUser = value;
            }
        }

       

     
    }
    //[MetadataType(typeof(UserMO))]
    //public partial class user
    //{

    //}
}