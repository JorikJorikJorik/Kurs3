using KursWebApplication.Data_Access;
using KursWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KursWebApplication.Business_Logic
{
    public class RepairLogic
    {
        RepairDataAccess dataAccess = new RepairDataAccess();

        public List<MyDBModels.RepairList> logicMethodForGetListData()
        {
            List<MyDBModels.RepairList> listData = dataAccess.getListData();
            return listData;
        }

        public MyDBModels.RepairList logicMethodForGetData(int id)
        {
            MyDBModels.RepairList data = dataAccess.getDataById(id);
            return data;
        }

        public void logicMethodForPostData(Models.RepairListModel data)
        {
            dataAccess.postRepair(data);
        }

        public void logicMethodForDeleteDataint(int id)
        {
            dataAccess.deleteRepair(id);
        }
    }
}