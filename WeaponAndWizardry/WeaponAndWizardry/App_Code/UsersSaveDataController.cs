//using Newtonsoft.Json.Linq;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Data.Entity.Infrastructure;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using System.Web.Http.Description;
//using WeaponAndWizardry.Models;

///// <summary>
/////  Not using
///// Module: UserSaveData Controllers to get the information from user data model.
/////         also parse string to json. The reason controller pass the value from model
/////         and parse, it is a high risk to direct change on Model files that made by ADO.NET
///// Team: Group7s
///// Description: Controller for User Model. Not using
///// Author: 
/////	 Name: Dongwon(Shawn) Kim    Date: 2017-10-17
///// Modified by:	
/////	 Name: Dongwon(Shawn) Kim   Change:	Add Get SavedData Date: 2017-10-17
///// Based on:  VisualStudio 2017 contorller generator
///// </summary>
//namespace WeaponAndWizardry.App_Code {

//    public class UsersSaveDataController : ApiController {
//        private WwdatabaseEntities db = new WwdatabaseEntities();

//        // GET: api/UsersSaveData
//        public IQueryable<User> GetUsers() {
//            return db.Users;
//        }

//        // GET: api/UsersSaveData/5
//        [ResponseType(typeof(User))]
//        public IHttpActionResult GetUser(string id) {
//            User user = db.Users.Find(id);
//            if (user == null) {
//                return NotFound();
//            }

//            return Ok(user);
//        }

//        // PUT: api/UsersSaveData/5
//        [ResponseType(typeof(void))]
//        public IHttpActionResult PutUser(string id, User user) {
//            if (!ModelState.IsValid) {
//                return BadRequest(ModelState);
//            }

//            if (id != user.Id) {
//                return BadRequest();
//            }

//            db.Entry(user).State = EntityState.Modified;

//            try {
//                db.SaveChanges();
//            } catch (DbUpdateConcurrencyException) {
//                if (!UserExists(id)) {
//                    return NotFound();
//                } else {
//                    throw;
//                }
//            }

//            return StatusCode(HttpStatusCode.NoContent);
//        }

//        // POST: api/UsersSaveData
//        [ResponseType(typeof(User))]
//        public IHttpActionResult PostUser(User user) {
//            if (!ModelState.IsValid) {
//                return BadRequest(ModelState);
//            }

//            db.Users.Add(user);

//            try {
//                db.SaveChanges();
//            } catch (DbUpdateException) {
//                if (UserExists(user.Id)) {
//                    return Conflict();
//                } else {
//                    throw;
//                }
//            }

//            return CreatedAtRoute("DefaultApi", new { id = user.Id }, user);
//        }

//        // DELETE: api/UsersSaveData/5
//        [ResponseType(typeof(User))]
//        public IHttpActionResult DeleteUser(string id) {
//            User user = db.Users.Find(id);
//            if (user == null) {
//                return NotFound();
//            }

//            db.Users.Remove(user);
//            db.SaveChanges();

//            return Ok(user);
//        }

//        protected override void Dispose(bool disposing) {
//            if (disposing) {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        private bool UserExists(string id) {
//            return db.Users.Count(e => e.Id == id) > 0;
//        }
  
//        /// <summary>
//        /// Returns user's savedata as Json.
//        /// 
//        /// </summary>
//        /// <param name="id"></param>
//        /// <returns></returns>
//        public JObject GetSaveData(string id) {
//            User user = db.Users.Find(id);

//            JObject jObject = JObject.Parse(user.Savedata);

//            return jObject;
//        }

//    }// end of the class

//}