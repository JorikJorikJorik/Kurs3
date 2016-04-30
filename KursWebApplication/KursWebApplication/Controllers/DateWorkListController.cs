using KursWebApplication.Business_Logic;
using KursWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace KursWebApplication.Controllers
{
   // [Authorize]
    public class DateWorkListController : ApiController
    {
        WorkLogic logic = new WorkLogic();

        // GET api/values
        public List<MyDBModels.WorkList> Get()
        {
            return logic.logicMethodForGetListData();
        }

        // GET api/values/
        public MyDBModels.WorkList Get(int id)
        {
            if (id != 0)
            {
                return logic.logicMethodForGetData(id);
            }
            return null;
        }

        // POST api/values
        public void Post(Models.WorkListModel newWork)
        {
            if (newWork != null)
            {
                logic.logicMethodForPostData(newWork);
            }
        }

        // DELETE api/values/
        public void Delete(int id)
        {
            if (id != 0)
            {
                logic.logicMethodForDeleteDataint(id);
            }
        }


      //  public MyDBModels.WorkList GetWorkListByData(DateTime dateAction) {
        //    var db = new MyDBModels.DB();
          //  DateTime dateTime1 = dateAction.Date;
          //  DateTime dateTime2 = dateAction.AddDays(1).Date;
          //  int workId = db.dateWorkList.Where(date => date.DateAction < dateTime2 && date.DateAction >= dateTime1).Select(x => x.WorkListId).FirstOrDefault();
          //  return db.workList.Where(dwl => dwl.WorkListID == workId).FirstOrDefault();

           // return db.workList.Join(db.dateWorkList, workId => workId.WorkListID, dateId => dateId.WorkListId, (workId, dateId) => new { DateId = dateId, WorkId = workId }).Where(dw => dw.WorkId.WorkListID == dw.DateId.WorkListId && dw.DateId.DateAction.Date == dateAction).FirstOrDefault();
      //  }

    }
}