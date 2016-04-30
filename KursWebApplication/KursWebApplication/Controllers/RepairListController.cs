using KursWebApplication.Business_Logic;
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
        RepairLogic logic = new RepairLogic();

        // GET api/values
        public List<MyDBModels.RepairList> Get()
        {
            return logic.logicMethodForGetListData();
        }

        // GET api/values/
        public MyDBModels.RepairList Get(int id)
        {
            if (id != 0)
            {
                return logic.logicMethodForGetData(id);
            }
            return null;
        }

        // POST api/values
        public void Post(Models.RepairListModel newRepair)
        {
            if (newRepair != null)
            {
                logic.logicMethodForPostData(newRepair);
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