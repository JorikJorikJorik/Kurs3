using KursWebApplication.Data_Access;
using KursWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KursWebApplication.Business_Logic
{
    public class GasLogic
    {
        GasDataAccess dataAccess = new GasDataAccess();

        public List<MyDBModels.GasList> logicMethodForGetListData()
        {
            List<MyDBModels.GasList> listData = dataAccess.getListData();
            return listData;
        }

        public MyDBModels.GasList logicMethodForGetData(int id)
        {
            MyDBModels.GasList data = dataAccess.getDataById(id);
            return data;
        }

        public void logicMethodForPostData(Models.GasListModel data)
        {
            dataAccess.postGas(data);
        }

        public void logicMethodForDeleteDataint(int id)
        {
            dataAccess.deleteGas(id);
        }
    }
}