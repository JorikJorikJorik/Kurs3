using KursWebApplication.Business_Logic;
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
        DriverLogic logic = new DriverLogic();

        // GET api/values
        public List<MyDBModels.Driver> Get()
        {
            return logic.logicMethodForGetListData();
        }

        // GET api/values/
        public MyDBModels.Driver Get(int id)
        {
            if (id != 0)
            {
                return logic.logicMethodForGetData(id);
            }
            return null;
        }

        // POST api/values
        public void Post(Models.DriverModel newDriver)
        {
            if (newDriver != null)
            {
                logic.logicMethodForPostData(newDriver);
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