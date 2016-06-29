using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KursWebApplication.Models
{
    public class MyDBModels
    {
        public class DB : DbContext
        {
            public DB() : base(nameOrConnectionString: "PgSql") { }
            public DbSet<Driver> driver { get; set; }
            public DbSet<Bus> bus { get; set; }
            public DbSet<WorkList> workList { get; set; }
            public DbSet<DateWorkList> dateWorkList { get; set; }
            public DbSet<RepairList> repairList { get; set; }
            public DbSet<GasList> gasList { get; set; }
            public DbSet<Account> account { get; set; }
        }

        [Table("driver", Schema = "public")]
        public class Driver
        {
            [Key] 
            [Column("driver_id")]
            public int DriverId { get; set; }
            [Column("driver_number")]
            public int DriverNumber { get; set; }
            [Column("secondname")]
            public string Secondname { get; set; }
            [Column("experience")]
            public int Experience { get; set; }
            [Column("salary")]
            public int Salary { get; set; }
            [Column("qualification")]
            public string Qualification { get; set; }
          
           

        }


        [Table("bus", Schema = "public")]
        public class Bus
        {
            [Key]
            [Column("bus_id")]
            public int BusId { get; set; }
            [Column("bus_number")]
            public int BusNumber { get; set; }
            [Column("model")]
            public string Model { get; set; }
            [Column("bus_condition")]
            public string BusCondition { get; set; }


        }

        [Table("work_list", Schema = "public")]
        public class WorkList
        {
            [Key]
            [Column("work_list_id")]
            public int WorkListId { get; set; }
            [Column("driver_id")]
            public int DriverId { get; set; }
            [Column("bus_id")]
            public int BusId { get; set; }
            [Column("second_name_dispatcher")]
            public string SecondNameDispatcher { get; set; }
            [Column("date_action")]
            public DateTime DateAction { get; set; }

        }

        [Table("date_work_list", Schema = "public")]
        public class DateWorkList
        {
            [Key]
            [Column("date_id")]
            public int DateId { get; set; }
            [Column("date_action")]
            public DateTime DateAction { get; set; }
            [Column("work_list_id")]
            public int WorkListId { get; set; }
           

        }

        [Table("service_station", Schema = "public")]
        public class RepairList
        {
            [Key]
            [Column("list_service_id")]
            public int ServiceListId { get; set; }
            [Column("bus_id")]
            public int BusId { get; set; }
            [Column("time_get")]
            public DateTime TimeGet { get; set; }
            [Column("bus_condition")]
            public string BusCondition { get; set; }
          

        }

        [Table("gas_station", Schema = "public")]
        public class GasList
        {
            [Key]
            [Column("gas_list_id")]
            public int GasListId { get; set; }
            [Column("bus_id")]
            public int BusId { get; set; }
            [Column("count_litre")]
            public int CountLitre { get; set; }
            [Column("type_gas")]
            public string TypeGas { get; set; }
            [Column("cost_gas")]
            public int CostGas { get; set; }
            [Column("time_get")]
            public DateTime TimeGet { get; set; }

        }

        [Table("login", Schema = "public")]
        public class Account
        {
            [Key]
            [Column("login_id")]
            public string LoginId { get; set; }
            [Column("password_worker")]
            public string PasswordWorker { get; set; }
            [Column("role_worker")]
            public string RoleWorker { get; set; }
            [Column("number_worker")]
            public string NumberWorker { get; set; }
        }

    }


}