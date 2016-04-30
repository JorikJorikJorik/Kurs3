using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using KursWebApplication.Models;
using KursWebApplication.Business_Logic;

namespace KursWebApplication.Controllers
{
    //[Authorize]
    public class WorkListController : ApiController
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
    }
}
