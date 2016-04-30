using KursWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KursWebApplication.Data_Access
{
    public class GasDataAccess
    {
        public List<MyDBModels.GasList> getListData()
        {
            var db = new MyDBModels.DB();
            List<MyDBModels.GasList> listData = db.gasList.ToList();
            return listData;
        }

        public MyDBModels.GasList getDataById(int id)
        {
            var db = new MyDBModels.DB();
            MyDBModels.GasList gasModel = db.gasList.Where(b => b.GasListId == id).FirstOrDefault();
            return gasModel;
        }

        public void postGas(Models.GasListModel value)
        {
            var db = new MyDBModels.DB();
            MyDBModels.GasList gasList = new MyDBModels.GasList();
            gasList.BusId = value.BusId;
            gasList.CostGas = value.CostGas;
            gasList.CountLitre = value.CountLitre;
            gasList.TimeGet = value.TimeGet;
            db.gasList.Add(gasList);
            db.SaveChanges();
        }


        public void deleteGas(int id)
        {
            var db = new MyDBModels.DB();
            MyDBModels.GasList gasList = db.gasList.Where(gl => gl.GasListId == id).FirstOrDefault();
            if (gasList != null)
            {
                db.gasList.Remove(gasList);
                db.SaveChanges();
            }
        }
    }
}