using KursWebApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace KursWebApplication.Controllers
{
    //[Authorize]
    public class RepairListController : ApiController
    {
        // GET api/values
        public List<MyDBModels.RepairList> Get()
        {
            var db = new MyDBModels.DB();
            return db.repairList.ToList();
        }

        // GET api/values/
        public MyDBModels.RepairList Get(int id)
        {
            var db = new MyDBModels.DB();
            return db.repairList.Where(rl => rl.ListServiceId == id).FirstOrDefault();
        }

        // POST api/values
        public void Post(Models.RepairListModel value)
        {
            var db = new MyDBModels.DB();
            MyDBModels.RepairList repairList = new MyDBModels.RepairList();
            repairList.BusId = value.BusId;
            repairList.BusCondition = value.BusCondition;
            repairList.TimeGet = value.TimeGet;
            db.repairList.Add(repairList);
            db.SaveChanges();
        }

        // DELETE api/values/
        public void Delete(int id)
        {
            var db = new MyDBModels.DB();
            MyDBModels.RepairList repairList = db.repairList.Where(rl => rl.ListServiceId == id).FirstOrDefault();
            if (repairList != null)
            {
                db.repairList.Remove(repairList);
                db.SaveChanges();
            }
        }

    }
}