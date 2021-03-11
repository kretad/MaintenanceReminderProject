using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MaintenanceReminderProject.Models
{
    public class Record
    {
        public int RecordID { get; set; }

        [DisplayName("Item Name")]
        public string ItemName { get; set; }

        [DisplayName("Item Category")]
        public string ItemCategory { get; set; }

        [DisplayName("Other Item Category")]
        public string OtherItemCategory { get; set; }

        [DisplayName("Date Last Maintained")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DateLastMaintained { get; set; }

        [DisplayName("Time Until Next Maintenance")]
        public int Time { get; set; }

        [DisplayName("Time Unit")]
        public string TimeUnit { get; set; }

        [DisplayName("Date of Next Maintenance")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DateOfNextMaintenance { get; set; }
        
    }
}
