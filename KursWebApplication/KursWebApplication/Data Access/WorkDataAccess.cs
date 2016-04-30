using KursWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KursWebApplication.Data_Access
{
    public class WorkDataAccess
    {
        public List<MyDBModels.WorkList> getListData()
        {
            var db = new MyDBModels.DB();
            List<MyDBModels.WorkList> listData = db.workList.ToList();
            return listData;
        }

        public MyDBModels.WorkList getDataById(int id)
        {
            var db = new MyDBModels.DB();
            MyDBModels.WorkList workModel = db.workList.Where(b => b.WorkListID == id).FirstOrDefault();
            return workModel;
        }

        public void postWork(Models.WorkListModel value)
        {
            var db = new MyDBModels.DB();
            MyDBModels.WorkList workList = new MyDBModels.WorkList();
            workList.DriverId = value.DriverId;
            workList.BusId = value.BusId;
            workList.SecondNameDispatcher = value.SecondNameDispatcher;
            workList.StateHealth = value.StateHealth;
            db.workList.Add(workList);
            db.SaveChanges();
        }


        public void deleteWork(int id)
        {
            var db = new MyDBModels.DB();
            MyDBModels.WorkList workList = db.workList.Where(wl => wl.WorkListID == id).FirstOrDefault();
            if (workList != null)
            {
                db.workList.Remove(workList);
                db.SaveChanges();
            }
        }
    }
}