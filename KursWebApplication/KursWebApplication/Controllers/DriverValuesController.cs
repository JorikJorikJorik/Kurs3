using KursWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace KursWebApplication.Controllers
{
    //[Authorize]
    public class DriverValuesController : ApiController
    {
        // GET api/values
        public List<MyDBModels.Driver> Get()
        {
            var db = new MyDBModels.DB();
            return db.driver.ToList();
        }

        // GET api/values/
        public MyDBModels.Driver Get(int id)
        {
            var db = new MyDBModels.DB();
            return db.driver.Where(d => d.DriverId == id).FirstOrDefault();
        }

        // POST api/values
        public void Post(Models.DriverModel value)
        {
            var db = new MyDBModels.DB();
            MyDBModels.Driver driver = new MyDBModels.Driver();
            driver.Secondname = value.Secondname;
            driver.Qualification = value.Qualification;
            driver.Experience = value.Experience;
            driver.Salary = value.Salary;
            db.driver.Add(driver);
            db.SaveChanges();
        }

        // DELETE api/values/
        public void Delete(int id)
        {
            var db = new MyDBModels.DB();
            MyDBModels.Driver driver = db.driver.Where(d => d.DriverId == id).FirstOrDefault();
            if (driver != null) {
                db.driver.Remove(driver);
                db.SaveChanges();
            }
        }
    }
}