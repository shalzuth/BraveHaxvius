using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class ImportantItem
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public String CountId { get; set; }
        public String ItemStack { get; set; }
        public String ItemIdClone { get; set; }

        public static readonly ImportantItem Crest = new ImportantItem { Name = "Crest"};
        public static readonly ImportantItem EXPKey = new ImportantItem { Name = "EXP Key"};
        public static readonly ImportantItem JeweledKey = new ImportantItem { Name = "Jeweled Key"};
        public static readonly ImportantItem RareSummonTicket = new ImportantItem { Name = "Rare Summon Ticket"};
        public static readonly ImportantItem ArenaSummonTicket = new ImportantItem { Name = "Arena Summon Ticket"};
        public static readonly ImportantItem GuaranteedTicket = new ImportantItem { Name = "4★+ Guaranteed Ticket"};
        public static readonly ImportantItem NRGRestore_100 = new ImportantItem { Name = "NRG Restore 10"};
        public static readonly ImportantItem NRGRestore_110 = new ImportantItem { Name = "NRG Restore 30"};
        public static readonly ImportantItem NRGRestore_120 = new ImportantItem { Name = "NRG Restore 50"};
        public static readonly ImportantItem EXSummonTicket = new ImportantItem { Name = "EX Summon Ticket"};
        public static readonly ImportantItem GuaranteedEXTicket_170 = new ImportantItem { Name = "4★+ Guaranteed EX Ticket"};
        public static readonly ImportantItem GuaranteedEXTicket_180 = new ImportantItem { Name = "5★+ Guaranteed EX Ticket"};
        public static readonly ImportantItem SpecialPass = new ImportantItem { Name = "Special Pass"};
        public static readonly ImportantItem ArenaRestore = new ImportantItem { Name = "Arena Restore"};
        public static readonly ImportantItem RaidRestore = new ImportantItem { Name = "Raid Restore"};
        public static readonly ImportantItem ExpansionVoucher = new ImportantItem { Name = "Expansion Voucher"};
        public static readonly ImportantItem AncientCoin = new ImportantItem { Name = "Ancient Coin"};
        public static readonly ImportantItem AdvanceToken = new ImportantItem { Name = "Advance Token"};

		public static readonly List<ImportantItem> ImportantItems = new List<ImportantItem>
		{
           Crest,
           EXPKey,
           JeweledKey,
           RareSummonTicket,
           ArenaSummonTicket,
           GuaranteedTicket,
           NRGRestore_100,
           NRGRestore_110,
           NRGRestore_120,
           EXSummonTicket,
           GuaranteedEXTicket_170,
           GuaranteedEXTicket_180,
           SpecialPass,
           ArenaRestore,
           RaidRestore,
           ExpansionVoucher,
           AncientCoin,
           AdvanceToken,
		};
    }
}