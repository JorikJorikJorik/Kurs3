

using KursWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace KursWebApplication.Controllers
{
    //  [Authorize]
    public class BusValuesController : ApiController
    {
        // GET api/values
        public List<MyDBModels.Bus> Get()
        {
            var db = new MyDBModels.DB();
            return db.bus.ToList();
        }

        // GET api/values/
        public MyDBModels.Bus Get(int id)
        {
            var db = new MyDBModels.DB();
            return db.bus.Where(b => b.BusId == id).FirstOrDefault();
        }

        // POST api/values
        public void Post(Models.BusModel newbus)
        {
            var db = new MyDBModels.DB();
            MyDBModels.Bus bus = new MyDBModels.Bus();
            bus.BusCondition = newbus.Condition;
            bus.BusNumber = newbus.BusNomber;
            bus.Model = newbus.Model;
            db.bus.Add(bus);
            db.SaveChanges();
        }

        // DELETE api/values/
        public void Delete(int id)
        {
            var db = new MyDBModels.DB();
            MyDBModels.Bus bus = db.bus.Where(b => b.BusId == id).FirstOrDefault();
            if (bus != null)
            {
                db.bus.Remove(bus);
                db.SaveChanges();
            }
        }
    }
}