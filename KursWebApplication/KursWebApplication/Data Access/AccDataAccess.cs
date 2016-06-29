using KursWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KursWebApplication.Data_Access
{
    public class AccDataAccess
    {
        public int postDriver(Models.DriverAccountModel postDriver)
        {
            var db = new MyDBModels.DB();
            MyDBModels.Account account = new MyDBModels.Account();
            MyDBModels.Driver driver = new MyDBModels.Driver();

            
            List<MyDBModels.Driver> listData = db.driver.ToList();
            List<int> num = new List<int>();

            for (int i = 0; i < listData.Count; i++)
            {
                num.Add(listData[i].DriverNumber);
            }
            int number = EncryptClass.GenerateUnikalNumber(num);

            account.LoginId = postDriver.AccountModel.Secondname;
            account.PasswordWorker = postDriver.AccountModel.Password;
            account.RoleWorker = postDriver.AccountModel.Role;
            account.NumberWorker = EncryptClass.DESEncrypt(number.ToString());

            db.account.Add(account);
            
            postDriver.DriverModel.DriverNumber = number;

            DriverModel value = postDriver.DriverModel;

            driver.Secondname = value.Secondname;
            driver.Qualification = value.Qualification;
            driver.Experience = value.Experience;
            driver.DriverNumber = value.DriverNumber;
            driver.Salary = value.Salary;
            db.driver.Add(driver);
            db.SaveChanges();

            return number;
        }

        public void postDispatcher(Models.DispatcherAccountModel postDispatcher)
        {
            var db = new MyDBModels.DB();
            MyDBModels.Account account = new MyDBModels.Account();

            account.LoginId =  postDispatcher.AccountModel.Secondname;
            account.PasswordWorker = postDispatcher.AccountModel.Password;
            account.RoleWorker =  postDispatcher.AccountModel.Role;
            account.NumberWorker = postDispatcher.AccountModel.Number;

            db.account.Add(account);
            db.SaveChanges();

        }

        public List<string> postSignIn(Models.AccountModel accountModel)
        {
            var db = new MyDBModels.DB();

            string cryptName = EncryptClass.DESEncrypt(accountModel.Secondname);
            string cryptPassword = EncryptClass.MD5Hash(accountModel.Password);
            List<string> result = new List<string>();

            MyDBModels.Account accountFinal = db.account.Where(b => b.LoginId == cryptName && b.PasswordWorker == cryptPassword).FirstOrDefault();
            if (accountFinal != null)
            {
                result.Add(EncryptClass.DESDecrypt(accountFinal.RoleWorker));
                result.Add(EncryptClass.DESDecrypt(accountFinal.NumberWorker));
            }
            else result.Add("NOT OK");
            return result;
        }
    }
}