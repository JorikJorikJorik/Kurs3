using KursWebApplication.Data_Access;
using KursWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KursWebApplication.Business_logic
{
    public class BusLogic
    {
        BusDataAccess dataAccess = new BusDataAccess();

        public List<MyDBModels.Bus> logicMethodForGetListData()
        {
            List<MyDBModels.Bus> listData = dataAccess.getListData();
            return listData;
        }

        public MyDBModels.Bus logicMethodForGetData(int id)
        {
            MyDBModels.Bus data = dataAccess.getDataById(id);
            return data;
        }

        public void logicMethodForPostData(Models.BusModel data)
        {
             dataAccess.postBus(data);
        }

        public void logicMethodForDeleteDataint(int id)
        {
            dataAccess.deleteBus(id);
        }

    }
}