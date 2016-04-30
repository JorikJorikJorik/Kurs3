using KursWebApplication.Data_Access;
using KursWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KursWebApplication.Business_Logic
{
    public class WorkLogic
    {
        WorkDataAccess dataAccess = new WorkDataAccess();

        public List<MyDBModels.WorkList> logicMethodForGetListData()
        {
            List<MyDBModels.WorkList> listData = dataAccess.getListData();
            return listData;
        }

        public MyDBModels.WorkList logicMethodForGetData(int id)
        {
            MyDBModels.WorkList data = dataAccess.getDataById(id);
            return data;
        }

        public void logicMethodForPostData(Models.WorkListModel data)
        {
            dataAccess.postWork(data);
        }

        public void logicMethodForDeleteDataint(int id)
        {
            dataAccess.deleteWork(id);
        }
    }
}