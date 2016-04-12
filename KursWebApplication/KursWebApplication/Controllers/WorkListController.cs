using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using KursWebApplication.Models;

namespace KursWebApplication.Controllers
{
    //[Authorize]
    public class WorkListController : ApiController
    {
        // GET api/values
        public List<MyDBModels.WorkList> Get()
        {
            var db = new MyDBModels.DB();
            return db.workList.ToList();
        }

        // GET api/values/
        public MyDBModels.WorkList Get(int id)
        {
            var db = new MyDBModels.DB();
            return db.workList.Where(wl => wl.WorkListID == id).FirstOrDefault();
        }

        // POST api/values
        public void Post(Models.WorkListModel value)
        {
            var db = new MyDBModels.DB();
            MyDBModels.WorkList workList = new MyDBModels.WorkList();
            workList.DriverId = value.DriverId;
            workList.BusId = value.BusId;
            workList.SecondNameDispatcher = value.SecondNameDispatcher;
            workList.StateHealth = value.StateHealth;
            db.workList.Add(workList);
            db.SaveChanges();
        }

        // DELETE api/values/
        public void Delete(int id)
        {
            var db = new MyDBModels.DB();
            MyDBModels.WorkList workList = db.workList.Where(wl => wl.WorkListID == id).FirstOrDefault();
            if (workList != null)
            {
                db.workList.Remove(workList);
                db.SaveChanges();
            }
        }
    }
}
