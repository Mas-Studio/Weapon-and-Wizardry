using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WeaponAndWizardry.Models;

namespace WeaponAndWizardry.Code
{
    public class UsersHandler
    {
        private WwdatabaseContext db = new WwdatabaseContext();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User Load(string id)
        {
            if (id == null)
            {
                return null;
            }

            User user = db.Users.Find(id);

            if (user == null)
            {
                return null;
            }
            return user;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Create(User user)
        {
            try {
                db.Users.Add(user);
                db.SaveChanges();
                return true;
            } catch(Exception ex) {

                Console.WriteLine(ex.Message);
                return false;
            }

            return false;
        }
        
    }
}
