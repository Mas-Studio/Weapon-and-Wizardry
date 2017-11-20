using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.ModelBinding;

/// <summary>
/// Module: TestJson
/// Description: This page is for testing json and sound
/// Author: 
///	 Name: Dongwon(Shawn) Kim   Date: 2017-11-06
/// Based on:
///     ADO.NET Entity, Database first
///     https://msdn.microsoft.com/en-ca/library/system.json.jsonobject(v=vs.95).aspx
/// </summary>
namespace WeaponAndWizardry {
    public partial class TestJson : Page {
        
        protected void Page_Load(object sender, EventArgs e) {

            
        }


        /**
         * Gets a customer data by customer id and return in IQueryable<Models.Customers>
         **/
        public IQueryable<Models.User> getUser_By_ID([Control] string userID)
        {

            Models.WwdatabaseContext db = new Models.WwdatabaseContext();
            
            return from p in db.Users
                    where p.Id == userID
                    select p;
        }

        protected void Button1_Click(object sender, EventArgs e) {
            IQueryable<Models.User> queryObj = getUser_By_ID
                                                    ("test00001");

            Label1.Text = String.Empty;

            if (queryObj != null) {
                //get the customer from the iqueryable
                Models.User savedata = queryObj.FirstOrDefault<Models.User>();

                //labels them by customer model.
                Label1.Text = savedata.Savedata;
            }
        }

        /// <summary>
        /// Returns user's savedata as Json.
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JObject GetSaveDataAsJson(string id){

            IQueryable<Models.User> queryObj = getUser_By_ID(id);
            Models.User user = queryObj.FirstOrDefault<Models.User>();

            JObject jObject = JObject.Parse(user.Savedata);

            return jObject;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            JObject jsonObj = GetSaveDataAsJson("test00001");
            Label1.Text = String.Empty;
            Label1.Text += "HP:" + (string)jsonObj["character"]["hp"] + "<br />";
            Label1.Text += "Moral:" + (string)jsonObj["character"]["morality"] + "<br />";
            Label1.Text += "isDead:" + (string)jsonObj["character"]["isdead"] + "<br />";
            Label1.Text += "Str:" + (string)jsonObj["character"]["str"] + "<br />";
            Label1.Text += "dex:" + (string)jsonObj["character"]["dex"] + "<br />";
            Label1.Text += "int:" + (string)jsonObj["character"]["int"] + "<br />";
            Label1.Text += "luk:" + (string)jsonObj["character"]["luk"] + "<br />";
            Label1.Text += "gold:" + (string)jsonObj["character"]["gold"] + "<br />";

            JArray jarray = (JArray)jsonObj["savedatas"];
            
            IList<JObject> saveDatas = jarray.Select(c => (JObject)c).ToList();

            foreach(JObject jo in saveDatas)
            {
                Label1.Text += "<br />";
                Label1.Text += jo["id"] + " ";
                Label1.Text += jo["scenarioid"] + " ";
                Label1.Text += jo["choice"];
            }
        }
    }
}