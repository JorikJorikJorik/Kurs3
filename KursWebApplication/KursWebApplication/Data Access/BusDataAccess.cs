using KursWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KursWebApplication.Data_Access
{
    public class BusDataAccess
    {
        public List<MyDBModels.Bus> getListData()
        {
            var db = new MyDBModels.DB();
            List<MyDBModels.Bus> listData = db.bus.ToList();
            return listData;
        }

        public MyDBModels.Bus getDataById(int id)
        {
            var db = new MyDBModels.DB();
            MyDBModels.Bus busModel = db.bus.Where(b => b.BusId == id).FirstOrDefault();
            return busModel;
        }

        public void postBus(Models.BusModel newbus)
        {
            var db = new MyDBModels.DB();
            MyDBModels.Bus bus = new MyDBModels.Bus();
            bus.BusCondition = newbus.Condition;
            bus.BusNumber = newbus.BusNomber;
            bus.Model = newbus.Model;
            db.bus.Add(bus);
            db.SaveChanges();
        }


        public void deleteBus(int id)
        {
            var db = new MyDBModels.DB();
            MyDBModels.Bus bus = db.bus.Where(b => b.BusId == id).FirstOrDefault();
            if (bus != null)
            {
                db.bus.Remove(bus);
                db.SaveChanges();
            }
        }
    }
}