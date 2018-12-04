using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BucBoard.Models.Entities
{
    public class Event
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Event name is required")]
        public string EventName { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public EventType Type { get; set; }
        public Boolean IsAvailable { get; set; }

        public int CalendarId { get; set; }
        public Calendar Calendar { get; set; }

    }

    public enum EventType
    {
        Class,
        LunchBreak,
        Meeting,
        BeRightBack,
        Away,
        InOffice
    }
}
