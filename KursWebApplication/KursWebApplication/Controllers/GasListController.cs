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
    public class GasListController : ApiController
    {
        GasLogic logic = new GasLogic();

        // GET api/values
        public List<MyDBModels.GasList> Get()
        {
            return logic.logicMethodForGetListData();
        }

        // GET api/values/
        public MyDBModels.GasList Get(int id)
        {
            if (id != 0)
            {
                return logic.logicMethodForGetData(id);
            }
            return null;
        }

        // POST api/values
        public void Post(Models.GasListModel newGas)
        {
            if (newGas != null)
            {
                logic.logicMethodForPostData(newGas);
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