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

        public MyDBModels.WorkList GetByData(DateTime dateAction) {
            var db = new MyDBModels.DB();
            DateTime dateTime1 = dateAction.Date;
            DateTime dateTime2 = dateAction.AddDays(1).Date;
            int workId = db.dateWorkList.Where(date => date.DateAction < dateTime2 && date.DateAction >= dateTime1).Select(x => x.WorkListId).FirstOrDefault();
            return db.workList.Where(dwl => dwl.WorkListID == workId).FirstOrDefault();


           // return db.workList.Join(db.dateWorkList, workId => workId.WorkListID, dateId => dateId.WorkListId, (workId, dateId) => new { DateId = dateId, WorkId = workId }).Where(dw => dw.WorkId.WorkListID == dw.DateId.WorkListId && dw.DateId.DateAction.Date == dateAction).FirstOrDefault();
        }

    }
}