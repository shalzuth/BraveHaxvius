using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Ticket
    {
        public String Id { get; set; }
        public String SubId { get; set; }
        public String Other { get; set; }
        public String Count { get; set; }
        public String Name { get; set; }

        public static readonly Ticket Rare3 = new Ticket { Id = "1", SubId = "10001", Count = "1", Other = "50", Name = "3*" };
        public static readonly Ticket Rare4 = new Ticket { Id = "2", SubId = "10001", Count = "1", Other = "70", Name = "4*" };
        public static readonly Ticket RareUnknown = new Ticket { Id = "3", SubId = "10001", Count = "1", Other = "80", Name = "??" };
        public static readonly Ticket EX3 = new Ticket { Id = "10", SubId = "10010", Count = "1", Other = "160", Name = "3* EX" };
        public static readonly Ticket EX4 = new Ticket { Id = "11", SubId = "10010", Count = "1", Other = "170", Name = "4* EX" };
        public static readonly Ticket EX5 = new Ticket { Id = "12", SubId = "10010", Count = "1", Other = "180", Name = "5* EX" };

        public static readonly List<Ticket> Tickets = new List<Ticket>
        {
            Rare3,
            Rare4,
            RareUnknown,
            EX3,
            EX4,
            EX5
        };
    }
}
