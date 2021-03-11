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
            new Record{ItemName="TestItem1", ItemCategory="Home", OtherItemCategory="",DateLastMaintained=DateTime.Parse("2021-09-01"),Time=1,TimeUnit="Years", DateOfNextMaintenance=DateTime.Parse("2022-09-01")},
            new Record{ItemName="TestItem2", ItemCategory="Vehicle", OtherItemCategory="",DateLastMaintained=DateTime.Parse("2021-09-01"),Time=1,TimeUnit="Years", DateOfNextMaintenance=DateTime.Parse("2022-09-01")},
            new Record{ItemName="TestItem3", ItemCategory="Other", OtherItemCategory="Test Other Item Category",DateLastMaintained=DateTime.Parse("2021-09-01"),Time=1,TimeUnit="Years", DateOfNextMaintenance=DateTime.Parse("2022-09-01")},
            new Record{ItemName="TestItem4", ItemCategory="Home", OtherItemCategory="",DateLastMaintained=DateTime.Parse("2021-09-01"),Time=1,TimeUnit="Years", DateOfNextMaintenance=DateTime.Parse("2022-09-01")},
            new Record{ItemName="TestItem5", ItemCategory="Vehicle", OtherItemCategory="",DateLastMaintained=DateTime.Parse("2021-09-01"),Time=1,TimeUnit="Years", DateOfNextMaintenance=DateTime.Parse("2022-09-01")},
            new Record{ItemName="TestItem6", ItemCategory="Other", OtherItemCategory="Test Other Item Category",DateLastMaintained=DateTime.Parse("2021-09-01"),Time=1,TimeUnit="Years", DateOfNextMaintenance=DateTime.Parse("2022-09-01")},
            new Record{ItemName="TestItem7", ItemCategory="Home", OtherItemCategory="",DateLastMaintained=DateTime.Parse("2021-09-01"),Time=1,TimeUnit="Years", DateOfNextMaintenance=DateTime.Parse("2022-09-01")} };

            foreach (Record e in records)
            {
                context.Records.Add(e);
            }
            context.SaveChanges();
        }
    }
}
