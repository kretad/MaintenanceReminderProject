using MaintenanceReminderProject.Models;
using System;
using System.Linq;

namespace MaintenanceReminderProject.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MaintenanceContext context)
        {
            context.Database.EnsureCreated();

            var records = new Record[]
            {
            new Record{ItemName="Replace AC Filter", ItemCategory="Home", OtherItemCategory="",DateLastMaintained=DateTime.Now,Time=1,TimeUnit="Year", DateOfNextMaintenance=DateTime.Now.AddYears(1)},
            new Record{ItemName="Oil Change", ItemCategory="Vehicle", OtherItemCategory="",DateLastMaintained=DateTime.Now,Time=1,TimeUnit="Year", DateOfNextMaintenance=DateTime.Now.AddYears(1)},
            new Record{ItemName="Mow Lawn", ItemCategory="Other", OtherItemCategory="Garden",DateLastMaintained=DateTime.Now,Time=1,TimeUnit="Year", DateOfNextMaintenance=DateTime.Now.AddYears(1)},
            new Record{ItemName="Replace Water Heater", ItemCategory="Home", OtherItemCategory="",DateLastMaintained=DateTime.Now,Time=1,TimeUnit="Year", DateOfNextMaintenance=DateTime.Now.AddYears(1)},
            new Record{ItemName="Rotate Tires", ItemCategory="Vehicle", OtherItemCategory="",DateLastMaintained=DateTime.Now,Time=1,TimeUnit="Year", DateOfNextMaintenance=DateTime.Now.AddYears(1)},
            new Record{ItemName="Replace Plant Food", ItemCategory="Other", OtherItemCategory="Garden",DateLastMaintained=DateTime.Now,Time=1,TimeUnit="Year", DateOfNextMaintenance=DateTime.Now.AddYears(1)},
            new Record{ItemName="Replace Refrigerator Filter", ItemCategory="Home", OtherItemCategory="",DateLastMaintained=DateTime.Now,Time=1,TimeUnit="Year", DateOfNextMaintenance=DateTime.Now.AddYears(1)} };

            foreach (Record e in records)
            {
                context.Records.Add(e);
            }
            context.SaveChanges();
        }
    }
}
