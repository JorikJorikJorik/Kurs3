using KursWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KursWebApplication.Data_Access
{
    public class RepairDataAccess
    {
        public List<MyDBModels.RepairList> getListData()
        {
            var db = new MyDBModels.DB();
            List<MyDBModels.RepairList> listData = db.repairList.ToList();
            return listData;
        }

        public MyDBModels.RepairList getDataById(int id)
        {
            var db = new MyDBModels.DB();
            MyDBModels.RepairList repairModel = db.repairList.Where(b => b.ListServiceId == id).FirstOrDefault();
            return repairModel;
        }

        public void postRepair(Models.RepairListModel value)
        {
            var db = new MyDBModels.DB();
            MyDBModels.RepairList repairList = new MyDBModels.RepairList();
            repairList.BusId = value.BusId;
            repairList.BusCondition = value.BusCondition;
            repairList.TimeGet = value.TimeGet;
            db.repairList.Add(repairList);
            db.SaveChanges();
        }


        public void deleteRepair(int id)
        {
            var db = new MyDBModels.DB();
            MyDBModels.RepairList repairList = db.repairList.Where(rl => rl.ListServiceId == id).FirstOrDefault();
            if (repairList != null)
            {
                db.repairList.Remove(repairList);
                db.SaveChanges();
            }
        }
    }
}