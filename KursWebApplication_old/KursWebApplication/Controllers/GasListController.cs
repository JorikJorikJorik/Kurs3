using KursWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace KursWebApplication.Controllers
{
    //[Authorize]
    public class GasListController : ApiController
    {
        // GET api/values
        public List<MyDBModels.GasList> Get()
        {
            var db = new MyDBModels.DB();
            return db.gasList.ToList();
        }

        // GET api/values/
        public MyDBModels.GasList Get(int id)
        {
            var db = new MyDBModels.DB();
            return db.gasList.Where(gl => gl.GasListId == id).FirstOrDefault();
        }

        // POST api/values
        public void Post(Models.GasListModel value)
        {
            var db = new MyDBModels.DB();
            MyDBModels.GasList gasList = new MyDBModels.GasList();
            gasList.BusId = value. BusId;
            gasList.CostGas = value.CostGas;
            gasList.CountLitre = value.CountLitre;
            gasList.TimeGet = value.TimeGet;
            db.gasList.Add(gasList);
            db.SaveChanges();
        }

        // DELETE api/values/
        public void Delete(int id)
        {
            var db = new MyDBModels.DB();
            MyDBModels.GasList gasList = db.gasList.Where(gl => gl.GasListId == id).FirstOrDefault();
            if (gasList != null)
            {
                db.gasList.Remove(gasList);
                db.SaveChanges();
            }
        }
    }
}