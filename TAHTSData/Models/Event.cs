using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TAHTSData.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string EventOwner { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime EventEndDate { get; set; }
        public bool EventStatus { get; set; }
        public DateTime EventCreatedDateTime { get; set; }
        public DateTime EventModifiedDateTime { get; set; }
    }
}
