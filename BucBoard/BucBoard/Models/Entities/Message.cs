﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BucBoard.Models.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Reciever { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public DateTime Date { get; set; }
    }
}
