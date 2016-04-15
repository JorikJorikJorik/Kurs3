

using KursWebApplication.Business_logic;
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
        BusLogic logic = new BusLogic();

        // GET api/values
        public List<MyDBModels.Bus> Get()
        {
            return logic.logicMethodForGetListData();
        }

        // GET api/values/
        public MyDBModels.Bus Get(int id)
        {
            if (id != 0)
            {
                return logic.logicMethodForGetData(id);
            }
            return null;
        }

        // POST api/values
        public void Post(Models.BusModel newbus)
        {
            if (newbus != null)
            { 
                logic.logicMethodForPostData(newbus);
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