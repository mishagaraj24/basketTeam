using basket.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace basKet.Convertors
{
    public static class Convertor
    {
        public static basket.DataAccess.Models.User ConvertToDal( basKet.Controllers.User from){

            basket.DataAccess.Models.User user = new User();

            user.Username = from.Username;
            user.Password = from.Password;
            user.Phone = from.Phone;
            user.Email = from.Email;
            user.PasswordConfirmation = from.PasswordConfirmation;
            return user;
         }

        public static basKet.Controllers.User Convert(basket.DataAccess.Models.User from)
        {

            basKet.Controllers.User user = new basKet.Controllers.User();

            user.Username = from.Username;
            user.Password = from.Password;
            user.Phone = from.Phone;
            user.Email = from.Email;
            return user;
        }
    }
}