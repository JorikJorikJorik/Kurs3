using KursWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace KursWebApplication.Controllers
{
   // [Authorize]
    public class DateWorkListCOntroller : ApiController
    {
        // GET api/values
        public List<MyDBModels.DateWorkList> Get()
        {
            var db = new MyDBModels.DB();
            return db.dateWorkList.ToList();
        }

        // GET api/values/
        public MyDBModels.DateWorkList Get(int id)
        {
            var db = new MyDBModels.DB();
            return db.dateWorkList.Where(dwl => dwl.DateId == id).FirstOrDefault();
        }

        // POST api/values
        public void Post(Models.DateWorkListModel value)
        {
            var db = new MyDBModels.DB();
            MyDBModels.DateWorkList dateWorkList = new MyDBModels.DateWorkList();
            dateWorkList.DateAction = value.DateAction;
            dateWorkList.WorkListId = value.WorkListId;
            db.dateWorkList.Add(dateWorkList);
            db.SaveChanges();
        }

        // DELETE api/values/
        public void Delete(int id)
        {
            var db = new MyDBModels.DB();
            MyDBModels.DateWorkList dateWorkList = db.dateWorkList.Where(dwl => dwl.DateId == id).FirstOrDefault();
            if (dateWorkList != null)
            {
                db.dateWorkList.Remove(dateWorkList);
                db.SaveChanges();
            }
        }

    }
}