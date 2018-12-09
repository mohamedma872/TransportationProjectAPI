using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BL.model
{
    public class NotificationModel
    {
        public long ID { get; set; }
        public string Tittle { get; set; }
        public string Message { get; set; }
        public string AccessToken { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public long TripStatusID { get; set; }
        public string Lang { get; set; }
        public string IEMI { get; set; }
        public bool IOS { get; set; }

    }
}