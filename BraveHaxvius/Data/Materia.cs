using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Materia
    {
        public String Name { get; set; }
        public String MateriaId { get; set; }
        public String Description { get; set; }
        public String CountId { get; set; }
        public String EquipmentActiveAbility { get; set; }
        public String EquipmentPassiveAbility { get; set; }
        public String ItemStack { get; set; }
        public String ItemBuyPrice { get; set; }
        public String ItemSellPrice { get; set; }
        public String ItemIdClone { get; set; }
        public String BitNumber { get; set; }

        public static readonly Materia Libra = new Materia { Name = "Libra", MateriaId = "504010010", Description = "ライブラ", CountId = "1150010", EquipmentActiveAbility = "10010", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000002", BitNumber = "1"};
        public static readonly Materia Cure = new Materia { Name = "Cure", MateriaId = "504010020", Description = "ケアル", CountId = "1150020", EquipmentActiveAbility = "10020", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000004", BitNumber = "2"};
        public static readonly Materia Blindna = new Materia { Name = "Blindna", MateriaId = "504010030", Description = "ブラナ", CountId = "1150110", EquipmentActiveAbility = "10030", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000003", BitNumber = "3"};
        public static readonly Materia Vox = new Materia { Name = "Vox", MateriaId = "504010040", Description = "ボキャル", CountId = "1150120", EquipmentActiveAbility = "10040", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000003", BitNumber = "4"};
        public static readonly Materia Poisona = new Materia { Name = "Poisona", MateriaId = "504010050", Description = "ポイゾナ", CountId = "1150130", EquipmentActiveAbility = "10050", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000003", BitNumber = "5"};
        public static readonly Materia Banish = new Materia { Name = "Banish", MateriaId = "504010060", Description = "バニシュ", CountId = "1155010", EquipmentActiveAbility = "10060", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000005", BitNumber = "6"};
        public static readonly Materia Paralyna = new Materia { Name = "Paralyna", MateriaId = "504010080", Description = "パラナ", CountId = "1150140", EquipmentActiveAbility = "10080", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000003", BitNumber = "8"};
        public static readonly Materia Stona = new Materia { Name = "Stona", MateriaId = "504010090", Description = "ストナ", CountId = "1150150", EquipmentActiveAbility = "10090", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000003", BitNumber = "9"};
        public static readonly Materia Esuna = new Materia { Name = "Esuna", MateriaId = "504010110", Description = "エスナ", CountId = "1150170", EquipmentActiveAbility = "10110", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000003", BitNumber = "11"};
        public static readonly Materia Regen = new Materia { Name = "Regen", MateriaId = "504010120", Description = "リジェネ", CountId = "1150190", EquipmentActiveAbility = "10120", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000004", BitNumber = "12"};
        public static readonly Materia Cleanse = new Materia { Name = "Cleanse", MateriaId = "504010140", Description = "リブート", CountId = "1150160", EquipmentActiveAbility = "10140", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000003", BitNumber = "14"};
        public static readonly Materia Holy = new Materia { Name = "Holy", MateriaId = "504010210", Description = "ホーリー", CountId = "1155510", EquipmentActiveAbility = "10210", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000005", BitNumber = "21"};
        public static readonly Materia Fire = new Materia { Name = "Fire", MateriaId = "504020010", Description = "ファイア", CountId = "1250010", EquipmentActiveAbility = "20010", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000021", BitNumber = "23"};
        public static readonly Materia Blizzard = new Materia { Name = "Blizzard", MateriaId = "504020020", Description = "ブリザド", CountId = "1250110", EquipmentActiveAbility = "20020", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000022", BitNumber = "24"};
        public static readonly Materia Thunder = new Materia { Name = "Thunder", MateriaId = "504020030", Description = "サンダー", CountId = "1250210", EquipmentActiveAbility = "20030", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000020", BitNumber = "25"};
        public static readonly Materia Water = new Materia { Name = "Water", MateriaId = "504020040", Description = "ウォータ", CountId = "1250310", EquipmentActiveAbility = "20040", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000023", BitNumber = "26"};
        public static readonly Materia Aero = new Materia { Name = "Aero", MateriaId = "504020050", Description = "エアロ", CountId = "1250410", EquipmentActiveAbility = "20050", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000025", BitNumber = "27"};
        public static readonly Materia Stone = new Materia { Name = "Stone", MateriaId = "504020060", Description = "ストーン", CountId = "1250510", EquipmentActiveAbility = "20060", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000028", BitNumber = "28"};
        public static readonly Materia Bio = new Materia { Name = "Bio", MateriaId = "504020070", Description = "バイオ", CountId = "1250610", EquipmentActiveAbility = "20070", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000024", BitNumber = "29"};
        public static readonly Materia Fira = new Materia { Name = "Fira", MateriaId = "504020080", Description = "ファイラ", CountId = "1250020", EquipmentActiveAbility = "20080", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000021", BitNumber = "30"};
        public static readonly Materia Blizzara = new Materia { Name = "Blizzara", MateriaId = "504020090", Description = "ブリザラ", CountId = "1250120", EquipmentActiveAbility = "20090", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000022", BitNumber = "31"};
        public static readonly Materia Thundara = new Materia { Name = "Thundara", MateriaId = "504020100", Description = "サンダラ", CountId = "1250220", EquipmentActiveAbility = "20100", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000020", BitNumber = "32"};
        public static readonly Materia Watera = new Materia { Name = "Watera", MateriaId = "504020110", Description = "ウォタラ", CountId = "1250320", EquipmentActiveAbility = "20110", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000023", BitNumber = "33"};
        public static readonly Materia Aerora = new Materia { Name = "Aerora", MateriaId = "504020120", Description = "エアロラ", CountId = "1250420", EquipmentActiveAbility = "20120", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000025", BitNumber = "34"};
        public static readonly Materia Stonra = new Materia { Name = "Stonra", MateriaId = "504020130", Description = "ストンラ", CountId = "1250520", EquipmentActiveAbility = "20130", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000028", BitNumber = "35"};
        public static readonly Materia Gravity = new Materia { Name = "Gravity", MateriaId = "504020150", Description = "グラビデ", CountId = "1251010", EquipmentActiveAbility = "20150", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000026", BitNumber = "37"};
        public static readonly Materia Drain = new Materia { Name = "Drain", MateriaId = "504020160", Description = "ドレイン", CountId = "1252010", EquipmentActiveAbility = "20160", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000015", BitNumber = "38"};
        public static readonly Materia Biora = new Materia { Name = "Biora", MateriaId = "504020180", Description = "バイオラ", CountId = "1250620", EquipmentActiveAbility = "20180", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000024", BitNumber = "40"};
        public static readonly Materia Firaga = new Materia { Name = "Firaga", MateriaId = "504020200", Description = "ファイガ", CountId = "1250030", EquipmentActiveAbility = "20200", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000021", BitNumber = "42"};
        public static readonly Materia Blizzaga = new Materia { Name = "Blizzaga", MateriaId = "504020210", Description = "ブリザガ", CountId = "1250130", EquipmentActiveAbility = "20210", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000022", BitNumber = "43"};
        public static readonly Materia Thundaga = new Materia { Name = "Thundaga", MateriaId = "504020220", Description = "サンダガ", CountId = "1250230", EquipmentActiveAbility = "20220", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000020", BitNumber = "44"};
        public static readonly Materia Flare = new Materia { Name = "Flare", MateriaId = "504020350", Description = "フレア", CountId = "1255020", EquipmentActiveAbility = "20350", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000030", BitNumber = "57"};
        public static readonly Materia Ultima = new Materia { Name = "Ultima", MateriaId = "504020440", Description = "アルテマ", CountId = "1255110", EquipmentActiveAbility = "20440", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000037", BitNumber = "66"};
        public static readonly Materia Sleep = new Materia { Name = "Sleep", MateriaId = "504030010", Description = "スリプル", CountId = "1358010", EquipmentActiveAbility = "30010", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000009", BitNumber = "67"};
        public static readonly Materia Blind = new Materia { Name = "Blind", MateriaId = "504030020", Description = "ブライン", CountId = "1358020", EquipmentActiveAbility = "30020", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000009", BitNumber = "68"};
        public static readonly Materia Barfire = new Materia { Name = "Barfire", MateriaId = "504030030", Description = "バファイ", CountId = "1351010", EquipmentActiveAbility = "30030", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000006", BitNumber = "69"};
        public static readonly Materia Barblizzard = new Materia { Name = "Barblizzard", MateriaId = "504030040", Description = "バブリザ", CountId = "1351110", EquipmentActiveAbility = "30040", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000010", BitNumber = "70"};
        public static readonly Materia Barthunder = new Materia { Name = "Barthunder", MateriaId = "504030050", Description = "バサンダ", CountId = "1351210", EquipmentActiveAbility = "30050", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000008", BitNumber = "71"};
        public static readonly Materia Barwater = new Materia { Name = "Barwater", MateriaId = "504030060", Description = "バウォタ", CountId = "1351310", EquipmentActiveAbility = "30060", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000013", BitNumber = "72"};
        public static readonly Materia Baraero = new Materia { Name = "Baraero", MateriaId = "504030070", Description = "バエアロ", CountId = "1351410", EquipmentActiveAbility = "30070", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000007", BitNumber = "73"};
        public static readonly Materia Barstone = new Materia { Name = "Barstone", MateriaId = "504030080", Description = "バストン", CountId = "1351510", EquipmentActiveAbility = "30080", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000012", BitNumber = "74"};
        public static readonly Materia Silence = new Materia { Name = "Silence", MateriaId = "504030100", Description = "サイレス", CountId = "1358030", EquipmentActiveAbility = "30100", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000009", BitNumber = "76"};
        public static readonly Materia Barfira = new Materia { Name = "Barfira", MateriaId = "504030110", Description = "バファイラ", CountId = "1351020", EquipmentActiveAbility = "30110", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000006", BitNumber = "77"};
        public static readonly Materia Barblizzara = new Materia { Name = "Barblizzara", MateriaId = "504030120", Description = "バブリザラ", CountId = "1351120", EquipmentActiveAbility = "30120", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000010", BitNumber = "78"};
        public static readonly Materia Barthundara = new Materia { Name = "Barthundara", MateriaId = "504030130", Description = "バサンダラ", CountId = "1351220", EquipmentActiveAbility = "30130", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000008", BitNumber = "79"};
        public static readonly Materia Shell = new Materia { Name = "Shell", MateriaId = "504030140", Description = "シェル", CountId = "1350310", EquipmentActiveAbility = "30140", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000077", BitNumber = "80"};
        public static readonly Materia Deprotect = new Materia { Name = "Deprotect", MateriaId = "504030150", Description = "デプロテ", CountId = "1355110", EquipmentActiveAbility = "30150", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000039", BitNumber = "81"};
        public static readonly Materia Deshell = new Materia { Name = "Deshell", MateriaId = "504030160", Description = "デシェル", CountId = "1355310", EquipmentActiveAbility = "30160", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000039", BitNumber = "82"};
        public static readonly Materia Barwatera = new Materia { Name = "Barwatera", MateriaId = "504030170", Description = "バウォタラ", CountId = "1351320", EquipmentActiveAbility = "30170", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000013", BitNumber = "83"};
        public static readonly Materia Baraerora = new Materia { Name = "Baraerora", MateriaId = "504030180", Description = "バエアロラ", CountId = "1351420", EquipmentActiveAbility = "30180", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000007", BitNumber = "84"};
        public static readonly Materia Barstonra = new Materia { Name = "Barstonra", MateriaId = "504030190", Description = "バストンラ", CountId = "1351520", EquipmentActiveAbility = "30190", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000012", BitNumber = "85"};
        public static readonly Materia HP_504100010 = new Materia { Name = "HP +10%", MateriaId = "504100010", Description = "HP+10%", CountId = "2111010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100010", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000077", BitNumber = "145"};
        public static readonly Materia MP_504100040 = new Materia { Name = "MP +10%", MateriaId = "504100040", Description = "MP+10%", CountId = "2112010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100040", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000077", BitNumber = "148"};
        public static readonly Materia MP_504100050 = new Materia { Name = "MP +20%", MateriaId = "504100050", Description = "MP+20%", CountId = "2112030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100050", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000077", BitNumber = "149"};
        public static readonly Materia ATK_504100070 = new Materia { Name = "ATK +10%", MateriaId = "504100070", Description = "攻撃+10%", CountId = "2113010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100070", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000077", BitNumber = "151"};
        public static readonly Materia ATK_504100080 = new Materia { Name = "ATK +20%", MateriaId = "504100080", Description = "攻撃+20%", CountId = "998", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100080", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000077", BitNumber = "152"};
        public static readonly Materia MAG_504100120 = new Materia { Name = "MAG +30%", MateriaId = "504100120", Description = "魔力+30%", CountId = "2115050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100120", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "156"};
        public static readonly Materia AutoLimit = new Materia { Name = "Auto-Limit", MateriaId = "504100750", Description = "オートリミット", CountId = "2173010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100750", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000091", BitNumber = "219"};
        public static readonly Materia EquipSSword = new Materia { Name = "Equip S Sword", MateriaId = "504100760", Description = "短剣装備", CountId = "2155010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100760", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000096", BitNumber = "220"};
        public static readonly Materia EquipLSword = new Materia { Name = "Equip L Sword", MateriaId = "504100780", Description = "大剣装備", CountId = "2155030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100780", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000096", BitNumber = "222"};
        public static readonly Materia EquipStaff = new Materia { Name = "Equip Staff", MateriaId = "504100800", Description = "杖装備", CountId = "2155050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100800", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000096", BitNumber = "224"};
        public static readonly Materia EquipHArmor = new Materia { Name = "Equip H Armor", MateriaId = "504100940", Description = "重鎧装備", CountId = "2155570", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100940", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000096", BitNumber = "238"};
        public static readonly Materia StoneKiller = new Materia { Name = "Stone Killer", MateriaId = "504101010", Description = "ストーンキラー", CountId = "2152020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101010", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "245"};
        public static readonly Materia MachineKiller = new Materia { Name = "Machine Killer", MateriaId = "504101030", Description = "マシーンキラー", CountId = "2152040", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101030", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "247"};
        public static readonly Materia DragonKiller_504101050 = new Materia { Name = "Dragon Killer", MateriaId = "504101050", Description = "ドラゴンキラー", CountId = "2152060", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101050", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "249"};
        public static readonly Materia AquanKiller = new Materia { Name = "Aquan Killer", MateriaId = "504101110", Description = "アクアンキラー", CountId = "2152120", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101110", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "255"};
        public static readonly Materia Cover = new Materia { Name = "Cover", MateriaId = "504101170", Description = "かばう", CountId = "2178010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101170", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000069", BitNumber = "261"};
        public static readonly Materia Counter = new Materia { Name = "Counter", MateriaId = "504101200", Description = "カウンター", CountId = "2175010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101200", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000068", BitNumber = "264"};
        public static readonly Materia Evade = new Materia { Name = "Evade", MateriaId = "504101230", Description = "しらはどり", CountId = "2177010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101230", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000075", BitNumber = "267"};
        public static readonly Materia Camouflage = new Materia { Name = "Camouflage", MateriaId = "504101350", Description = "カモフラージュ", CountId = "2176010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101350", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000084", BitNumber = "279"};
        public static readonly Materia Doublehand = new Materia { Name = "Doublehand", MateriaId = "504101360", Description = "りょうてもち", CountId = "2171010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101360", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "280"};
        public static readonly Materia DualWield_504101370 = new Materia { Name = "Dual Wield", MateriaId = "504101370", Description = "にとうりゅう", CountId = "2171020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101370", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000072", BitNumber = "281"};
        public static readonly Materia Steal = new Materia { Name = "Steal", MateriaId = "504200010", Description = "ぬすむ", CountId = "2290010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200010", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000082", BitNumber = "294"};
        public static readonly Materia Pilfer = new Materia { Name = "Pilfer", MateriaId = "504200030", Description = "くすねる", CountId = "2290020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200030", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000082", BitNumber = "296"};
        public static readonly Materia Drink = new Materia { Name = "Drink", MateriaId = "504200090", Description = "のむ", CountId = "2290210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200090", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000058", BitNumber = "302"};
        public static readonly Materia Brace = new Materia { Name = "Brace", MateriaId = "504200120", Description = "がまん", CountId = "2290310", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200120", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000077", BitNumber = "305"};
        public static readonly Materia Throw = new Materia { Name = "Throw", MateriaId = "504200180", Description = "なげる", CountId = "2290220", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200180", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000047", BitNumber = "311"};
        public static readonly Materia Store = new Materia { Name = "Store", MateriaId = "504200210", Description = "ためる", CountId = "2290320", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200210", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000087", BitNumber = "314"};
        public static readonly Materia RagingFist = new Materia { Name = "Raging Fist", MateriaId = "504200230", Description = "爆裂拳", CountId = "2212110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200230", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000051", BitNumber = "316"};
        public static readonly Materia Escape = new Materia { Name = "Escape", MateriaId = "504200250", Description = "とんずら", CountId = "2290110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200250", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000057", BitNumber = "318"};
        public static readonly Materia Barrage = new Materia { Name = "Barrage", MateriaId = "504200310", Description = "みだれうち", CountId = "2212210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200310", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000053", BitNumber = "324"};
        public static readonly Materia MirrorofEquity = new Materia { Name = "Mirror of Equity", MateriaId = "504200320", Description = "明鏡", CountId = "2212010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200320", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000053", BitNumber = "325"};
        public static readonly Materia Aim = new Materia { Name = "Aim", MateriaId = "504200390", Description = "ねらう", CountId = "2212020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200390", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000040", BitNumber = "332"};
        public static readonly Materia Bladeblitz = new Materia { Name = "Bladeblitz", MateriaId = "504200440", Description = "ぜんぎり", CountId = "2212310", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200440", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000053", BitNumber = "337"};
        public static readonly Materia FireBlade = new Materia { Name = "Fire Blade", MateriaId = "504200510", Description = "ファイア剣", CountId = "2240010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200510", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000021", BitNumber = "344"};
        public static readonly Materia BlizzardBlade = new Materia { Name = "Blizzard Blade", MateriaId = "504200520", Description = "ブリザド剣", CountId = "2240110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200520", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000022", BitNumber = "345"};
        public static readonly Materia SilenceBlade = new Materia { Name = "Silence Blade", MateriaId = "504200550", Description = "サイレス剣", CountId = "2241020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200550", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000009", BitNumber = "348"};
        public static readonly Materia WaterBlade = new Materia { Name = "Water Blade", MateriaId = "504200560", Description = "ウォータ剣", CountId = "2240310", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200560", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000023", BitNumber = "349"};
        public static readonly Materia StoneBlade = new Materia { Name = "Stone Blade", MateriaId = "504200580", Description = "ストーン剣", CountId = "2240510", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200580", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000028", BitNumber = "351"};
        public static readonly Materia BlindBlade = new Materia { Name = "Blind Blade", MateriaId = "504200590", Description = "ブライン剣", CountId = "2241030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200590", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000009", BitNumber = "352"};
        public static readonly Materia BioBlade = new Materia { Name = "Bio Blade", MateriaId = "504200600", Description = "バイオ剣", CountId = "2240610", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200600", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000024", BitNumber = "353"};
        public static readonly Materia DrainBlade = new Materia { Name = "Drain Blade", MateriaId = "504200670", Description = "ドレイン剣", CountId = "2242010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200670", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000015", BitNumber = "360"};
        public static readonly Materia ThundagaBlade = new Materia { Name = "Thundaga Blade", MateriaId = "504200720", Description = "サンダガ剣", CountId = "2240230", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200720", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000020", BitNumber = "365"};
        public static readonly Materia BiogaBlade = new Materia { Name = "Bioga Blade", MateriaId = "504200760", Description = "バイオガ剣", CountId = "2240630", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200760", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000024", BitNumber = "369"};
        public static readonly Materia MagicInfuse = new Materia { Name = "Magic Infuse", MateriaId = "504200800", Description = "まれんけい", CountId = "2212640", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200800", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000026", BitNumber = "373"};
        public static readonly Materia Lullaby = new Materia { Name = "Lullaby", MateriaId = "504200810", Description = "こもりうた", CountId = "2280010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200810", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000100", BitNumber = "374"};
        public static readonly Materia Paean = new Materia { Name = "Paean", MateriaId = "504200850", Description = "いやしのうた", CountId = "2280020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200850", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000100", BitNumber = "378"};
        public static readonly Materia MentalBreak = new Materia { Name = "Mental Break", MateriaId = "504201160", Description = "メンタルブレイク", CountId = "2219310", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201160", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000054", BitNumber = "409"};
        public static readonly Materia SilenceDance = new Materia { Name = "Silence Dance", MateriaId = "504201190", Description = "ちんもくダンス", CountId = "2285010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201190", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000050", BitNumber = "412"};
        public static readonly Materia FireBeam = new Materia { Name = "Fire Beam", MateriaId = "504201260", Description = "ファイアビーム", CountId = "2212610", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201260", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000021", BitNumber = "419"};
        public static readonly Materia BlizzardBeam = new Materia { Name = "Blizzard Beam", MateriaId = "504201280", Description = "ブリザービーム", CountId = "2212620", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201280", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000022", BitNumber = "421"};
        public static readonly Materia BioBlaster = new Materia { Name = "Bio Blaster", MateriaId = "504201320", Description = "バイオブラスター", CountId = "2212630", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201320", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000024", BitNumber = "425"};
        public static readonly Materia PowerShot = new Materia { Name = "Power Shot", MateriaId = "504201340", Description = "パワーショット", CountId = "2212030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201340", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000040", BitNumber = "427"};
        public static readonly Materia Sunbeam = new Materia { Name = "Sunbeam", MateriaId = "504201430", Description = "サンビーム", CountId = "2212550", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201430", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000052", BitNumber = "436"};
        public static readonly Materia Meteor = new Materia { Name = "Meteor", MateriaId = "504020430", Description = "メテオ", CountId = "1255030", EquipmentActiveAbility = "20430", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000029", BitNumber = "65"};
        public static readonly Materia Comet = new Materia { Name = "Comet", MateriaId = "504020170", Description = "コメット", CountId = "1255010", EquipmentActiveAbility = "20170", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000029", BitNumber = "39"};
        public static readonly Materia Protect = new Materia { Name = "Protect", MateriaId = "504030090", Description = "プロテス", CountId = "1350110", EquipmentActiveAbility = "30090", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000077", BitNumber = "439"};
        public static readonly Materia SPR_504100160 = new Materia { Name = "SPR +10%", MateriaId = "504100160", Description = "精神+10%", CountId = "2116010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100160", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000077", BitNumber = "437"};
        public static readonly Materia BugKiller = new Materia { Name = "Bug Killer", MateriaId = "504101020", Description = "ムシキラー", CountId = "2152030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101020", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "438"};
        public static readonly Materia Cura = new Materia { Name = "Cura", MateriaId = "504010070", Description = "ケアルラ", CountId = "1150030", EquipmentActiveAbility = "10070", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000004", BitNumber = "7"};
        public static readonly Materia DEF_504100130 = new Materia { Name = "DEF +10%", MateriaId = "504100130", Description = "防御+10%", CountId = "2114010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100130", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000077", BitNumber = "157"};
        public static readonly Materia EquipBow = new Materia { Name = "Equip Bow", MateriaId = "504100820", Description = "弓装備", CountId = "2155070", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100820", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000096", BitNumber = "440"};
        public static readonly Materia ReflectTest = new Materia { Name = "Reflect Test"};
        public static readonly Materia Bravery = new Materia { Name = "Bravery", MateriaId = "504030210", Description = "ブレイブ", CountId = "1350010", EquipmentActiveAbility = "30210", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000077", BitNumber = "442"};
        public static readonly Materia ATK_504100090 = new Materia { Name = "ATK +30%", MateriaId = "504100090", Description = "攻撃+30%", CountId = "2113050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100090", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "443"};
        public static readonly Materia MAG_504100100 = new Materia { Name = "MAG +10%", MateriaId = "504100100", Description = "魔力+10%", CountId = "2115010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100100", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000077", BitNumber = "444"};
        public static readonly Materia MP_504100060 = new Materia { Name = "MP +30%", MateriaId = "504100060", Description = "MP+30%", CountId = "2112050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100060", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "445"};
        public static readonly Materia HolyBlade = new Materia { Name = "Holy Blade", MateriaId = "504200770", Description = "ホーリー剣", CountId = "2245010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200770", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000005", BitNumber = "446"};
        public static readonly Materia KatanaMastery = new Materia { Name = "Katana Mastery", MateriaId = "504201670", Description = "刀の極意", CountId = "2151310", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201670", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000053", BitNumber = "447"};
        public static readonly Materia LightsBlessing = new Materia { Name = "Light's Blessing", MateriaId = "504201680", Description = "光の加護", CountId = "2174010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201680", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000091", BitNumber = "448"};
        public static readonly Materia Dispel = new Materia { Name = "Dispel", MateriaId = "504010130", Description = "デスペル", CountId = "1150180", EquipmentActiveAbility = "10130", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000003", BitNumber = "454"};
        public static readonly Materia Faith = new Materia { Name = "Faith", MateriaId = "504030220", Description = "フェイス", CountId = "1350210", EquipmentActiveAbility = "30220", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000077", BitNumber = "455"};
        public static readonly Materia HP_504100030 = new Materia { Name = "HP +30%", MateriaId = "504100030", Description = "HP+30%", CountId = "2111050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100030", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "452"};
        public static readonly Materia EquipAxe = new Materia { Name = "Equip Axe", MateriaId = "504100830", Description = "斧装備", CountId = "2155080", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100830", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000096", BitNumber = "453"};
        public static readonly Materia EquipHat = new Materia { Name = "Equip Hat", MateriaId = "504100960", Description = "帽子装備", CountId = "2155530", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100960", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000096", BitNumber = "456"};
        public static readonly Materia SpiritSlayer = new Materia { Name = "Spirit Slayer", MateriaId = "504101100", Description = "スピリットキラー", CountId = "2152110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101100", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "457"};
        public static readonly Materia HP_504101500 = new Materia { Name = "HP +15%", MateriaId = "504101500", Description = "HP+15%", CountId = "2111020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101500", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000077", BitNumber = "449"};
        public static readonly Materia SleepBlade = new Materia { Name = "Sleep Blade", MateriaId = "504200540", Description = "スリプル剣", CountId = "2241010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200540", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000009", BitNumber = "458"};
        public static readonly Materia AeroBlade = new Materia { Name = "Aero Blade", MateriaId = "504200570", Description = "エアロ剣", CountId = "2240410", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200570", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000025", BitNumber = "459"};
        public static readonly Materia StonraBlade = new Materia { Name = "Stonra Blade", MateriaId = "504200660", Description = "ストンラ剣", CountId = "2240520", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200660", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000028", BitNumber = "450"};
        public static readonly Materia MelodyofLife = new Materia { Name = "Melody of Life", MateriaId = "504201750", Description = "生命のメロディ", CountId = "2153930", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201750", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000018", BitNumber = "451"};
        public static readonly Materia SealofDestruction_504201950 = new Materia { Name = "Seal of Destruction", MateriaId = "504201950", Description = "破壊の刻印", CountId = "2131150", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201950", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "460"};
        public static readonly Materia SealofProtection = new Materia { Name = "Seal of Protection", MateriaId = "504201960", Description = "守護の刻印", CountId = "2131180", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201960", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "461"};
        public static readonly Materia GoddesssProtection = new Materia { Name = "Goddess's Protection", MateriaId = "504201970", Description = "聖女神の守護", CountId = "2154991", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201970", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000097", BitNumber = "462"};
        public static readonly Materia EquipHShield = new Materia { Name = "Equip H Shield", MateriaId = "504100990", Description = "重盾装備", CountId = "2155520", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100990", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000096", BitNumber = "463"};
        public static readonly Materia Dualcast = new Materia { Name = "Dualcast", MateriaId = "504200150", Description = "れんぞくま", CountId = "2295010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200150", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000026", BitNumber = "464"};
        public static readonly Materia Curada = new Materia { Name = "Curada", MateriaId = "504010150", Description = "ケアルダ", CountId = "1150040", EquipmentActiveAbility = "10150", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000004", BitNumber = "465"};
        public static readonly Materia EVOMAG = new Materia { Name = "EVO MAG +10%", MateriaId = "504100190", Description = "召喚魔法+10%", CountId = "2117010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100190", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000077", BitNumber = "466"};
        public static readonly Materia PlantKiller = new Materia { Name = "Plant Killer", MateriaId = "504101000", Description = "プラントキラー", CountId = "2152010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101000", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "467"};
        public static readonly Materia WateraBlade = new Materia { Name = "Watera Blade", MateriaId = "504200640", Description = "ウォタラ剣", CountId = "2240320", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200640", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000023", BitNumber = "468"};
        public static readonly Materia SecondWind = new Materia { Name = "Second Wind", MateriaId = "504202350", Description = "エール", CountId = "8000010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202350", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000063", BitNumber = "469"};
        public static readonly Materia CrushArmor = new Materia { Name = "Crush Armor", MateriaId = "504202360", Description = "強甲破点突き", CountId = "8000020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202360", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000054", BitNumber = "470"};
        public static readonly Materia Medicate = new Materia { Name = "Medicate", MateriaId = "504202370", Description = "手当て", CountId = "8000030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202370", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000003", BitNumber = "471"};
        public static readonly Materia StoneThrow = new Materia { Name = "Stone Throw", MateriaId = "504202380", Description = "投石", CountId = "2211010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202380", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000047", BitNumber = "472"};
        public static readonly Materia EquipSpear = new Materia { Name = "Equip Spear", MateriaId = "504100850", Description = "槍装備", CountId = "2155100", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100850", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000096", BitNumber = "473"};
        public static readonly Materia Thunderfall = new Materia { Name = "Thunderfall", MateriaId = "504202470", Description = "天鳴万雷", CountId = "8000040", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202470", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000020", BitNumber = "474"};
        public static readonly Materia HereWeGo = new Materia { Name = "Here We Go", MateriaId = "504202480", Description = "テンションあげあげ", CountId = "8000050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202480", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000063", BitNumber = "475"};
        public static readonly Materia Attacker = new Materia { Name = "Attacker", MateriaId = "504202490", Description = "アタッカー", CountId = "8000060", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202490", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "476"};
        public static readonly Materia Defender = new Materia { Name = "Defender", MateriaId = "504202500", Description = "ディフェンダー", CountId = "8000070", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202500", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "477"};
        public static readonly Materia StickyFingers = new Materia { Name = "Sticky Fingers", MateriaId = "504202760", Description = "キャッチ", CountId = "2132120", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202760", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "478"};
        public static readonly Materia CoinSteal = new Materia { Name = "Coin Steal", MateriaId = "504202770", Description = "コインを盗む", CountId = "2290040", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202770", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000082", BitNumber = "479"};
        public static readonly Materia LungeCombo = new Materia { Name = "Lunge Combo", MateriaId = "504202780", Description = "突貫コンボ", CountId = "2132060", EquipmentActiveAbility = "", EquipmentPassiveAbility = "202780", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "480"};
        public static readonly Materia BurstShot = new Materia { Name = "Burst Shot", MateriaId = "1500000000", Description = "Burst Shot", CountId = "90000", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201380", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "5000", ItemIdClone = "700000040", BitNumber = "90000"};
        public static readonly Materia AutoProtect = new Materia { Name = "Auto-Protect", MateriaId = "504100710", Description = "オートプロテス", CountId = "2174110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100710", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000091", BitNumber = "481"};
        public static readonly Materia EquipRod = new Materia { Name = "Equip Rod", MateriaId = "504100810", Description = "ロッド装備", CountId = "2155060", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100810", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000096", BitNumber = "482"};
        public static readonly Materia BioraBlade = new Materia { Name = "Biora Blade", MateriaId = "504200680", Description = "バイオラ剣", CountId = "2240620", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200680", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000024", BitNumber = "483"};
        public static readonly Materia Acceptance = new Materia { Name = "Acceptance", MateriaId = "504203150", Description = "受け取る力", CountId = "2132150", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203150", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "484"};
        public static readonly Materia Knowledge = new Materia { Name = "Knowledge", MateriaId = "504203160", Description = "知の力", CountId = "2135310", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203160", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "485"};
        public static readonly Materia Ignorance = new Materia { Name = "Ignorance", MateriaId = "504203170", Description = "無知なる力", CountId = "2173020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203170", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000091", BitNumber = "486"};
        public static readonly Materia Discernment = new Materia { Name = "Discernment", MateriaId = "504203180", Description = "認識する力", CountId = "2154992", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203180", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000014", BitNumber = "487"};
        public static readonly Materia SpeedPlus = new Materia { Name = "Speed Plus", MateriaId = "504203190", Description = "スピードアップ", CountId = "2177020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203190", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000097", BitNumber = "488"};
        public static readonly Materia Twinspell = new Materia { Name = "Twinspell", MateriaId = "504203200", Description = "ツインマジック", CountId = "2132020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203200", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "489"};
        public static readonly Materia InsulttoInjury = new Materia { Name = "Insult to Injury", MateriaId = "504203210", Description = "スタンフィニッシュ", CountId = "8000080", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203210", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000054", BitNumber = "490"};
        public static readonly Materia CutCards = new Materia { Name = "Cut Cards", MateriaId = "504203220", Description = "デッキオープン", CountId = "8000090", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203220", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000083", BitNumber = "491"};
        public static readonly Materia Mentality = new Materia { Name = "Mentality", MateriaId = "504203370", Description = "メンタリティ", CountId = "2132160", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203370", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "492"};
        public static readonly Materia LettersandArms = new Materia { Name = "Letters and Arms", MateriaId = "504203380", Description = "文武両道", CountId = "2151510", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203380", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "493"};
        public static readonly Materia ManasProtection = new Materia { Name = "Mana's Protection", MateriaId = "504203810", Description = "マナの加護", CountId = "2132010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203810", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "494"};
        public static readonly Materia ManasBlessing = new Materia { Name = "Mana's Blessing", MateriaId = "504203820", Description = "マナの祝福", CountId = "2131010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203820", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "495"};
        public static readonly Materia DeepThoughts = new Materia { Name = "Deep Thoughts", MateriaId = "504203830", Description = "一途な想い", CountId = "2132190", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203830", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "496"};
        public static readonly Materia FairyWisdom = new Materia { Name = "Fairy Wisdom", MateriaId = "504203840", Description = "妖精族の知恵", CountId = "2132030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203840", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "497"};
        public static readonly Materia Mana = new Materia { Name = "Mana", MateriaId = "504203800", Description = "マナ", CountId = "8000110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203800", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000063", BitNumber = "498"};
        public static readonly Materia FullMoonSlash = new Materia { Name = "Full Moon Slash", MateriaId = "504203460", Description = "満月斬り", CountId = "8000100", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203460", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000054", BitNumber = "499"};
        public static readonly Materia AutoShell = new Materia { Name = "Auto-Shell", MateriaId = "504100720", Description = "オートシェル", CountId = "2174210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100720", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000091", BitNumber = "500"};
        public static readonly Materia OsmoseBlade = new Materia { Name = "Osmose Blade", MateriaId = "504200690", Description = "アスピル剣", CountId = "2242110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200690", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000015", BitNumber = "501"};
        public static readonly Materia SyldrasProtection = new Materia { Name = "Syldra's Protection", MateriaId = "504204030", Description = "海竜の加護", CountId = "2152510", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204030", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000079", BitNumber = "502"};
        public static readonly Materia Wisdom = new Materia { Name = "Wisdom", MateriaId = "504204250", Description = "賢き力", CountId = "2131520", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204250", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "503"};
        public static readonly Materia Action = new Materia { Name = "Action", MateriaId = "504204260", Description = "行動する力", CountId = "2179210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204260", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000081", BitNumber = "504"};
        public static readonly Materia Innocence = new Materia { Name = "Innocence", MateriaId = "504204270", Description = "純真なる力", CountId = "2133310", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204270", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "505"};
        public static readonly Materia Tranquility = new Materia { Name = "Tranquility", MateriaId = "504204280", Description = "冷静なる力", CountId = "2131410", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204280", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "506"};
        public static readonly Materia GateofDestiny = new Materia { Name = "Gate of Destiny", MateriaId = "504204290", Description = "エナジーボム", CountId = "8000120", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204290", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000026", BitNumber = "507"};
        public static readonly Materia WhiteKnight = new Materia { Name = "White Knight", MateriaId = "504204300", Description = "セーフティガード", CountId = "8000130", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204300", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000091", BitNumber = "508"};
        public static readonly Materia TemperedShield = new Materia { Name = "Tempered Shield", MateriaId = "504204310", Description = "硬化シールド", CountId = "2131020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204310", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "509"};
        public static readonly Materia ImperialHelm = new Materia { Name = "Imperial Helm", MateriaId = "504204320", Description = "皇国軍ヘルメット", CountId = "2131160", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204320", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "510"};
        public static readonly Materia MP_504203240 = new Materia { Name = "MP + 15%", MateriaId = "504203240", Description = "MP+15%", CountId = "2112020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203240", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000077", BitNumber = "511"};
        public static readonly Materia ATK_504101600 = new Materia { Name = "ATK +15%", MateriaId = "504101600", Description = "攻撃+15%", CountId = "2113020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101600", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000077", BitNumber = "512"};
        public static readonly Materia DarkBond = new Materia { Name = "Dark Bond", MateriaId = "504204590", Description = "ヘスの血脈", CountId = "2151530", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204590", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "513"};
        public static readonly Materia WaterGodsProtection = new Materia { Name = "Water God's Protection", MateriaId = "504204600", Description = "水神の加護", CountId = "2132170", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204600", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "514"};
        public static readonly Materia Breaker = new Materia { Name = "Breaker", MateriaId = "504207510", Description = "ブレイカー", CountId = "8000200", EquipmentActiveAbility = "", EquipmentPassiveAbility = "207510", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000054", BitNumber = "562"};
        public static readonly Materia DemonicLife = new Materia { Name = "Demonic Life", MateriaId = "504207680", Description = "魔神の燃命", CountId = "2139020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "207680", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "563"};
        public static readonly Materia DestroyersAuthority = new Materia { Name = "Destroyer's Authority", MateriaId = "504207690", Description = "破神の威光", CountId = "2131110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "207690", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "564"};
        public static readonly Materia GuardiansAuthority = new Materia { Name = "Guardian's Authority", MateriaId = "504207700", Description = "守神の威光", CountId = "2131170", EquipmentActiveAbility = "", EquipmentPassiveAbility = "207700", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "565"};
        public static readonly Materia PowerofCreation = new Materia { Name = "Power of Creation", MateriaId = "504207710", Description = "創造神の力", CountId = "2133510", EquipmentActiveAbility = "", EquipmentPassiveAbility = "207710", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "566"};
        public static readonly Materia DarkResistance = new Materia { Name = "Dark Resistance +15%", MateriaId = "504207720", Description = "闇属性耐性+15%", CountId = "2153820", EquipmentActiveAbility = "", EquipmentPassiveAbility = "207720", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000098", BitNumber = "567"};
        public static readonly Materia ChillingAura = new Materia { Name = "Chilling Aura", MateriaId = "1500000001", Description = "Chilling Aura", CountId = "90001", EquipmentActiveAbility = "", EquipmentPassiveAbility = "900010", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "5000", ItemIdClone = "1500000001", BitNumber = "90001"};
        public static readonly Materia SpookyAura = new Materia { Name = "Spooky Aura", MateriaId = "1500000002", Description = "Spooky Aura", CountId = "90002", EquipmentActiveAbility = "", EquipmentPassiveAbility = "900011", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "5000", ItemIdClone = "1500000002", BitNumber = "90002"};
        public static readonly Materia SealofDestruction_1500000003 = new Materia { Name = "Seal of Destruction", MateriaId = "1500000003", Description = "Tablet of Ruin", CountId = "90003", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910025", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "90003"};
        public static readonly Materia MAG_504101700 = new Materia { Name = "MAG +15%", MateriaId = "504101700", Description = "魔力+15%", CountId = "2115020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101700", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000077", BitNumber = "520"};
        public static readonly Materia Death = new Materia { Name = "Death", MateriaId = "504020280", Description = "デス", CountId = "1259010", EquipmentActiveAbility = "20280", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000038", BitNumber = "515"};
        public static readonly Materia EquipClothes = new Materia { Name = "Equip Clothes", MateriaId = "504100920", Description = "服装備", CountId = "2155550", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100920", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000096", BitNumber = "516"};
        public static readonly Materia ManEater_504101040 = new Materia { Name = "Man-Eater", MateriaId = "504101040", Description = "マンイーター", CountId = "2152050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101040", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "517"};
        public static readonly Materia BirdKiller = new Materia { Name = "Bird Killer", MateriaId = "504101090", Description = "バードキラー", CountId = "2152100", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101090", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "518"};
        public static readonly Materia AutoPotion = new Materia { Name = "Auto-Potion", MateriaId = "504101120", Description = "オートポーション", CountId = "2179010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101120", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000091", BitNumber = "519"};
        public static readonly Materia PowerBreak = new Materia { Name = "Power Break", MateriaId = "504201130", Description = "パワーブレイク", CountId = "2219010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201130", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000054", BitNumber = "521"};
        public static readonly Materia MagicBreak = new Materia { Name = "Magic Break", MateriaId = "504201140", Description = "マジックブレイク", CountId = "2219210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201140", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000054", BitNumber = "522"};
        public static readonly Materia MiracleStep = new Materia { Name = "Miracle Step", MateriaId = "504204900", Description = "ミラクルステップ", CountId = "2177040", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204900", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "523"};
        public static readonly Materia CrushHelm = new Materia { Name = "Crush Helm", MateriaId = "504204910", Description = "星天爆撃打", CountId = "8000140", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204910", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000054", BitNumber = "524"};
        public static readonly Materia HealingWaltzII = new Materia { Name = "Healing Waltz II", MateriaId = "504204920", Description = "ヒーリングワルツII", CountId = "8000150", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204920", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000050", BitNumber = "525"};
        public static readonly Materia Poach = new Materia { Name = "Poach", MateriaId = "504204930", Description = "密猟", CountId = "2152210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204930", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000079", BitNumber = "526"};
        public static readonly Materia FirstStrike = new Materia { Name = "First Strike", MateriaId = "504204940", Description = "ハメドる", CountId = "2177030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204940", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000068", BitNumber = "527"};
        public static readonly Materia Lifefont = new Materia { Name = "Lifefont", MateriaId = "504204950", Description = "HP回復移動", CountId = "2179110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "204950", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000073", BitNumber = "528"};
        public static readonly Materia QuickAssault = new Materia { Name = "Quick Assault", MateriaId = "504205130", Description = "クイックアサルト", CountId = "2177050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205130", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "529"};
        public static readonly Materia DarkKnightsSoul = new Materia { Name = "Dark Knight's Soul", MateriaId = "504205260", Description = "ダークナイトソウル", CountId = "2151320", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205260", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "530"};
        public static readonly Materia HillDigger = new Materia { Name = "Hill Digger", MateriaId = "504205350", Description = "山そだち", CountId = "2131720", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205350", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "531"};
        public static readonly Materia Successor = new Materia { Name = "Successor", MateriaId = "504205430", Description = "後継者", CountId = "2131420", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205430", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "532"};
        public static readonly Materia Magician = new Materia { Name = "Magician", MateriaId = "504205440", Description = "マジシャン", CountId = "2135110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205440", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "533"};
        public static readonly Materia Fighter = new Materia { Name = "Fighter", MateriaId = "504205450", Description = "ファイター", CountId = "2133110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205450", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "534"};
        public static readonly Materia SeethingCauldron = new Materia { Name = "Seething Cauldron", MateriaId = "504205460", Description = "あふれる魔力", CountId = "2132100", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205460", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "535"};
        public static readonly Materia SwellingPower = new Materia { Name = "Swelling Power", MateriaId = "504205470", Description = "みなぎる力", CountId = "2131130", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205470", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "536"};
        public static readonly Materia BushidoFreedom = new Materia { Name = "Bushido - Freedom", MateriaId = "504205490", Description = "奥義・天下御免", CountId = "2219510", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205490", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000019", BitNumber = "537"};
        public static readonly Materia NA_504205650 = new Materia { Name = "NA", MateriaId = "504205650", Description = "覇者の闘気", CountId = "2171990", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205650", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000091", BitNumber = "538"};
        public static readonly Materia NA_504205980 = new Materia { Name = "NA", MateriaId = "504205980", Description = "しゃくねつ", CountId = "2212710", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205980", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000021", BitNumber = "539"};
        public static readonly Materia NA_504205880 = new Materia { Name = "NA", MateriaId = "504205880", Description = "つねにだいぼうぎょ", CountId = "2134710", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205880", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "540"};
        public static readonly Materia NA_504206070 = new Materia { Name = "NA", MateriaId = "504206070", Description = "ぼうえいほんのう", CountId = "2133710", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206070", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "541"};
        public static readonly Materia ThunderBlade = new Materia { Name = "Thunder Blade", MateriaId = "504200530", Description = "サンダー剣", CountId = "2240210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200530", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000020", BitNumber = "346"};
        public static readonly Materia ArmorBreak = new Materia { Name = "Armor Break", MateriaId = "504201150", Description = "アーマーブレイク", CountId = "2219110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "201150", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000054", BitNumber = "542"};
        public static readonly Materia NA_504205710 = new Materia { Name = "NA", MateriaId = "504205710", Description = "メタル斬り", CountId = "2211020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205710", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000054", BitNumber = "543"};
        public static readonly Materia NA_504205990 = new Materia { Name = "NA", MateriaId = "504205990", Description = "ハッスルダンス", CountId = "2285020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205990", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000050", BitNumber = "544"};
        public static readonly Materia NA_504205660 = new Materia { Name = "NA", MateriaId = "504205660", Description = "やみのはどう", CountId = "8000160", EquipmentActiveAbility = "", EquipmentPassiveAbility = "205660", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000039", BitNumber = "545"};
        public static readonly Materia UndeadKiller = new Materia { Name = "Undead Killer", MateriaId = "504101060", Description = "アンデッドキラー", CountId = "2152070", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101060", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "546"};
        public static readonly Materia NA_504206080 = new Materia { Name = "NA", MateriaId = "504206080", Description = "属性ダメージ減", CountId = "8000170", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206080", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000018", BitNumber = "547"};
        public static readonly Materia EmperorsMajesty = new Materia { Name = "Emperor's Majesty", MateriaId = "504206270", Description = "皇帝の威厳", CountId = "2131515", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206270", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "548"};
        public static readonly Materia HereticAbyss = new Materia { Name = "Heretic Abyss", MateriaId = "504206320", Description = "魔道の深淵", CountId = "2132140", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206320", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "549"};
        public static readonly Materia Resuscitate = new Materia { Name = "Resuscitate", MateriaId = "504206390", Description = "起死回生", CountId = "2139010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206390", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "550"};
        public static readonly Materia Love = new Materia { Name = "Love", MateriaId = "504206630", Description = "愛", CountId = "2131710", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206630", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "551"};
        public static readonly Materia Resolve = new Materia { Name = "Resolve", MateriaId = "504206680", Description = "決断する力", CountId = "2172020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206680", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000091", BitNumber = "552"};
        public static readonly Materia Persistence = new Materia { Name = "Persistence", MateriaId = "504206750", Description = "執着する力", CountId = "2134310", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206750", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "553"};
        public static readonly Materia SiphonDelta = new Materia { Name = "Siphon Delta", MateriaId = "504206650", Description = "アスピルフィールド", CountId = "8000180", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206650", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000015", BitNumber = "554"};
        public static readonly Materia Multitask = new Materia { Name = "Multitask", MateriaId = "504206740", Description = "リロード射撃", CountId = "8000190", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206740", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000040", BitNumber = "555"};
        public static readonly Materia AzureHelm = new Materia { Name = "Azure Helm", MateriaId = "504206840", Description = "蒼龍風の兜", CountId = "2132130", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206840", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "556"};
        public static readonly Materia AzureArmor = new Materia { Name = "Azure Armor", MateriaId = "504206850", Description = "蒼龍風の鎧", CountId = "2132040", EquipmentActiveAbility = "", EquipmentPassiveAbility = "206850", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "557"};
        public static readonly Materia AutoRefresh = new Materia { Name = "Auto-Refresh", MateriaId = "504100740", Description = "オートリフレシュ", CountId = "2172010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100740", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000091", BitNumber = "558"};
        public static readonly Materia EquipLShield = new Materia { Name = "Equip L Shield", MateriaId = "504100980", Description = "軽盾装備", CountId = "2155510", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100980", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000096", BitNumber = "559"};
        public static readonly Materia MageCannon = new Materia { Name = "Mage Cannon", MateriaId = "504207380", Description = "魔導砲", CountId = "2212510", EquipmentActiveAbility = "", EquipmentPassiveAbility = "207380", ItemStack = "99", ItemBuyPrice = "1500", ItemSellPrice = "1500", ItemIdClone = "700000019", BitNumber = "560"};
        public static readonly Materia LargeSwordMastery = new Materia { Name = "Large Sword Mastery", MateriaId = "504207410", Description = "大剣の極意", CountId = "2151330", EquipmentActiveAbility = "", EquipmentPassiveAbility = "207410", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000095", BitNumber = "561"};
        public static readonly Materia DivineSeal = new Materia { Name = "Divine Seal", MateriaId = "504207770", Description = "ディヴァインシール", CountId = "8000210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "207770", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "568"};
        public static readonly Materia ProtectionoftheTwelve = new Materia { Name = "Protection of the Twelve", MateriaId = "504208090", Description = "十二神の冥加", CountId = "8000220", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208090", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000068", BitNumber = "569"};
        public static readonly Materia ShardofGenius = new Materia { Name = "Shard of Genius", MateriaId = "504208100", Description = "叡知の結晶", CountId = "2151610", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208100", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "570"};
        public static readonly Materia FollowersOath = new Materia { Name = "Follower's Oath", MateriaId = "504208110", Description = "盟主への誓い", CountId = "2131140", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208110", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000077", BitNumber = "571"};
        public static readonly Materia HydaelynGuard = new Materia { Name = "Hydaelyn Guard", MateriaId = "504208120", Description = "ハイデリンの加護", CountId = "2153910", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208120", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000018", BitNumber = "572"};
        public static readonly Materia BeastKiller = new Materia { Name = "Beast Killer", MateriaId = "504101080", Description = "ビーストキラー", CountId = "2152090", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101080", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "573"};
        public static readonly Materia Returner = new Materia { Name = "Returner", MateriaId = "504208480", Description = "リターナー", CountId = "2132050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208480", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "576"};
        public static readonly Materia WarriorMage = new Materia { Name = "Warrior Mage", MateriaId = "504208490", Description = "魔導戦士", CountId = "2132090", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208490", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "577"};
        public static readonly Materia ToxicRain = new Materia { Name = "Toxic Rain", MateriaId = "504208500", Description = "暴風酸性雨", CountId = "2212560", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208580", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000009", BitNumber = "578"};
        public static readonly Materia RodMastery = new Materia { Name = "Rod Mastery", MateriaId = "504208510", Description = "ロッドの極意", CountId = "2151520", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208590", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000095", BitNumber = "579"};
        public static readonly Materia RageMeteor = new Materia { Name = "Rage - Meteor", MateriaId = "504208570", Description = "あばれる【メテオ】", CountId = "2212320", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208570", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000019", BitNumber = "580"};
        public static readonly Materia LightResistance_504208900 = new Materia { Name = "Light Resistance +15%", MateriaId = "504208900", Description = "光属性耐性+15%", CountId = "2153720", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208900", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000099", BitNumber = "581"};
        public static readonly Materia HealersWisdom = new Materia { Name = "Healer's Wisdom", MateriaId = "504208740", Description = "癒し手の心得", CountId = "2136710", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208740", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "582"};
        public static readonly Materia DEF_504208970 = new Materia { Name = "DEF +15%", MateriaId = "504208970", Description = "防御+15%", CountId = "2114020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208970", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000077", BitNumber = "583"};
        public static readonly Materia SPR_504208980 = new Materia { Name = "SPR +15%", MateriaId = "504208980", Description = "精神+15%", CountId = "2116020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208980", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000077", BitNumber = "584"};
        public static readonly Materia NullParalysis = new Materia { Name = "Null Paralysis", MateriaId = "504208990", Description = "麻痺無効", CountId = "2154050", EquipmentActiveAbility = "", EquipmentPassiveAbility = "208990", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000014", BitNumber = "585"};
        public static readonly Materia DemonKiller = new Materia { Name = "Demon Killer", MateriaId = "504101070", Description = "デーモンキラー", CountId = "2152080", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101070", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000079", BitNumber = "586"};
        public static readonly Materia UseGrapplingWeapons = new Materia { Name = "Use Grappling Weapons", MateriaId = "504100910", Description = "格闘装備", CountId = "2155160", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100910", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000096", BitNumber = "587"};
        public static readonly Materia WarriorLore = new Materia { Name = "Warrior Lore", MateriaId = "504209480", Description = "戦士の心得", CountId = "2131120", EquipmentActiveAbility = "", EquipmentPassiveAbility = "209480", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "588"};
        public static readonly Materia MagesMonograph = new Materia { Name = "Mage's Monograph", MateriaId = "504209490", Description = "魔道士の心得", CountId = "2131190", EquipmentActiveAbility = "", EquipmentPassiveAbility = "209490", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "589"};
        public static readonly Materia Imperil = new Materia { Name = "Imperil", MateriaId = "504030200", Description = "ウィーク", CountId = "1359010", EquipmentActiveAbility = "30200", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000039", BitNumber = "590"};
        public static readonly Materia PatrioticRecall = new Materia { Name = "Patriotic Recall", MateriaId = "504209350", Description = "祖国への想い", CountId = "2131730", EquipmentActiveAbility = "", EquipmentPassiveAbility = "209350", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "591"};
        public static readonly Materia Curaga = new Materia { Name = "Curaga", MateriaId = "504010160", Description = "ケアルガ", CountId = "1150050", EquipmentActiveAbility = "10160", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000004", BitNumber = "592"};
        public static readonly Materia DEF_504100140 = new Materia { Name = "DEF +20%", MateriaId = "504100140", Description = "防御+20%", CountId = "2114030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100140", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000077", BitNumber = "593"};
        public static readonly Materia ManufactedNethicite = new Materia { Name = "Manufacted Nethicite", MateriaId = "504209500", Description = "人造破魔石", CountId = "2295020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "209500", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000015", BitNumber = "594"};
        public static readonly Materia EarthResistance = new Materia { Name = "Earth Resistance +15%", MateriaId = "504209550", Description = "土属性耐性+15%", CountId = "2153620", EquipmentActiveAbility = "", EquipmentPassiveAbility = "209550", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000012", BitNumber = "595"};
        public static readonly Materia NA_504900120 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900130 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900140 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900150 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900160 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900170 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900180 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900190 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900200 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900210 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900220 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900230 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900240 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900250 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900260 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900270 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900280 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900290 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900300 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900310 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900320 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900330 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900340 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900350 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900360 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900370 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900380 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900390 = new Materia { Name = "NA"};
        public static readonly Materia Firaja = new Materia { Name = "Firaja"};
        public static readonly Materia Blizzaja = new Materia { Name = "Blizzaja"};
        public static readonly Materia Thundaja = new Materia { Name = "Thundaja"};
        public static readonly Materia Waterja = new Materia { Name = "Waterja"};
        public static readonly Materia Aeroja = new Materia { Name = "Aeroja"};
        public static readonly Materia Stonja = new Materia { Name = "Stonja"};
        public static readonly Materia MirrorCounter = new Materia { Name = "Mirror Counter"};
        public static readonly Materia LasswellLvl = new Materia { Name = "Lasswell Lvl 100"};
        public static readonly Materia NA_504900480 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900490 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900500 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900510 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900520 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900530 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900540 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900550 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900560 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900570 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900580 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900590 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900600 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900610 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900620 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900630 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900640 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900650 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900660 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900670 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900680 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900690 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900700 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900710 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900720 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900730 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900740 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900750 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900760 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900770 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900780 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900790 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900800 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900810 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900820 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900830 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900840 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900850 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900860 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900870 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900880 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900890 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900900 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900910 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900920 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900930 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900940 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900950 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900960 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900970 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900980 = new Materia { Name = "NA"};
        public static readonly Materia NA_504900990 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901000 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901010 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901020 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901030 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901040 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901050 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901060 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901070 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901080 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901090 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901100 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901110 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901120 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901130 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901140 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901150 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901160 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901170 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901180 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901190 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901200 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901210 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901220 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901230 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901240 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901250 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901260 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901270 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901280 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901290 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901300 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901310 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901320 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901330 = new Materia { Name = "NA"};
        public static readonly Materia Dark = new Materia { Name = "Dark"};
        public static readonly Materia Darkra_504901350 = new Materia { Name = "Darkra"};
        public static readonly Materia Darkga = new Materia { Name = "Darkga"};
        public static readonly Materia NA_504901370 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901380 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901390 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901400 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901410 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901420 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901430 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901440 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901450 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901460 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901470 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901480 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901490 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901500 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901510 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901520 = new Materia { Name = "NA"};
        public static readonly Materia Tornado = new Materia { Name = "Tornado"};
        public static readonly Materia NA_504901540 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901550 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901560 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901570 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901580 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901590 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901600 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901610 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901620 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901630 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901640 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901650 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901660 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901670 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901680 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901690 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901700 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901710 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901720 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901730 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901740 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901750 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901760 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901770 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901780 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901790 = new Materia { Name = "NA"};
        public static readonly Materia Jump = new Materia { Name = "Jump"};
        public static readonly Materia Kick = new Materia { Name = "Kick"};
        public static readonly Materia NA_504901820 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901830 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901840 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901850 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901860 = new Materia { Name = "NA"};
        public static readonly Materia NA_504901870 = new Materia { Name = "NA"};
        public static readonly Materia Burst = new Materia { Name = "Burst"};
        public static readonly Materia Quake = new Materia { Name = "Quake"};
        public static readonly Materia PureHeart = new Materia { Name = "Pure Heart", MateriaId = "1500000004", Description = "Pure Heart", CountId = "90004", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910045", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "90004"};
        public static readonly Materia WinterWard = new Materia { Name = "Winter Ward", MateriaId = "1500000005", Description = "Winter Guardian", CountId = "90005", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910057", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "1500000005", BitNumber = "90005"};
        public static readonly Materia Deliverance = new Materia { Name = "Deliverance", MateriaId = "1500000007", Description = "Deliverance", CountId = "90006", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910066", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90006"};
        public static readonly Materia FirewallPower = new Materia { Name = "Firewall: Power↑", MateriaId = "1500000008", Description = "Firewall power", CountId = "90007", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910067", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90007"};
        public static readonly Materia SymphonicFlair = new Materia { Name = "Symphonic Flair", MateriaId = "504212570", Description = "Symphonic Flair", CountId = "90008", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910096", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "504212570", BitNumber = "90008"};
        public static readonly Materia LightspeedJab = new Materia { Name = "Lightspeed Jab", MateriaId = "1500000009", Description = "Lightspeed Jab", CountId = "90009", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101470,910133", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90009"};
        public static readonly Materia Cheerleader = new Materia { Name = "Cheerleader", MateriaId = "1500000010", Description = "Cheerleader", CountId = "90010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200450,910134", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "700000077", BitNumber = "90010"};
        public static readonly Materia ElvenPride = new Materia { Name = "Elven Pride", MateriaId = "504209690", Description = "エルフの誇り", CountId = "2132180", EquipmentActiveAbility = "", EquipmentPassiveAbility = "209690", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "596"};
        public static readonly Materia PoisonResistance = new Materia { Name = "Poison Resistance", MateriaId = "504209940", Description = "毒無効", CountId = "2154010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "209940", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000014", BitNumber = "597"};
        public static readonly Materia ProudFencer = new Materia { Name = "Proud Fencer", MateriaId = "504210110", Description = "誇り高き剣豪", CountId = "2131530", EquipmentActiveAbility = "", EquipmentPassiveAbility = "210110", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "598"};
        public static readonly Materia HeavensGuidance = new Materia { Name = "Heaven's Guidance", MateriaId = "504210490", Description = "星天の導き", CountId = "2295030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "210490", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000043", BitNumber = "599"};
        public static readonly Materia March = new Materia { Name = "March", MateriaId = "504210640", Description = "進軍", CountId = "2132070", EquipmentActiveAbility = "", EquipmentPassiveAbility = "210640", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "600"};
        public static readonly Materia Vigilance = new Materia { Name = "Vigilance", MateriaId = "504210650", Description = "警戒", CountId = "2132080", EquipmentActiveAbility = "", EquipmentPassiveAbility = "210650", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "601"};
        public static readonly Materia SPR_504100170 = new Materia { Name = "SPR +20%", MateriaId = "504100170", Description = "精神+20%", CountId = "2116030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100170", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000077", BitNumber = "602"};
        public static readonly Materia WindResistance = new Materia { Name = "Wind Resistance +15%", MateriaId = "504210660", Description = "風属性耐性+15%", CountId = "2153520", EquipmentActiveAbility = "", EquipmentPassiveAbility = "210680", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000007", BitNumber = "603"};
        public static readonly Materia FalseSaint = new Materia { Name = "False Saint", MateriaId = "504210670", Description = "偽りの聖者", CountId = "2132110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "210690", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "604"};
        public static readonly Materia SwornSixsPrideDark = new Materia { Name = "Sworn Six's Pride - Dark", MateriaId = "504210720", Description = "六盟傑の誇り・闇", CountId = "2151340", EquipmentActiveAbility = "", EquipmentPassiveAbility = "210720", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "605"};
        public static readonly Materia SwornSixsPrideFire = new Materia { Name = "Sworn Six's Pride - Fire", MateriaId = "504210800", Description = "六盟傑の誇り・火", CountId = "2151350", EquipmentActiveAbility = "", EquipmentPassiveAbility = "210800", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "606"};
        public static readonly Materia SwornSixsPrideEarth = new Materia { Name = "Sworn Six's Pride - Earth", MateriaId = "504210890", Description = "六盟傑の誇り・土", CountId = "2151430", EquipmentActiveAbility = "", EquipmentPassiveAbility = "210890", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "607"};
        public static readonly Materia ConfusionResistance = new Materia { Name = "Confusion Resistance", MateriaId = "504211100", Description = "混乱無効", CountId = "2154060", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211100", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000014", BitNumber = "608"};
        public static readonly Materia MogSearch = new Materia { Name = "Mog Search", MateriaId = "504211120", Description = "モグサーチ", CountId = "2299010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211120", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "700000002", BitNumber = "609"};
        public static readonly Materia MogSong = new Materia { Name = "Mog Song", MateriaId = "504211130", Description = "モグソング", CountId = "2280001", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211130", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000100", BitNumber = "610"};
        public static readonly Materia MogStep = new Materia { Name = "Mog Step", MateriaId = "504211140", Description = "モグステップ", CountId = "2285001", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211140", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000050", BitNumber = "611"};
        public static readonly Materia MogResist = new Materia { Name = "Mog Resist", MateriaId = "504211150", Description = "モグレジスト", CountId = "2154901", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211150", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000014", BitNumber = "612"};
        public static readonly Materia MogRise = new Materia { Name = "Mog Rise", MateriaId = "504211160", Description = "モグライズ", CountId = "2131510", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211160", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "613"};
        public static readonly Materia MartialArtsMastery = new Materia { Name = "Martial Arts Mastery", MateriaId = "504211340", Description = "格闘の極意", CountId = "2151360", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211340", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000095", BitNumber = "614"};
        public static readonly Materia WorldDestroyer = new Materia { Name = "World Destroyer", MateriaId = "504211350", Description = "世界崩壊", CountId = "2219410", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211350", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000019", BitNumber = "615"};
        public static readonly Materia MogWisdom = new Materia { Name = "Mog Wisdom", MateriaId = "504211290", Description = "モグの心得", CountId = "2173030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211290", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000078", BitNumber = "616"};
        public static readonly Materia HeartofFire = new Materia { Name = "Heart of Fire", MateriaId = "504211680", Description = "火のこころ", CountId = "2131200", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211680", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000006", BitNumber = "617"};
        public static readonly Materia HeartofWater = new Materia { Name = "Heart of Water", MateriaId = "504211690", Description = "水のこころ", CountId = "2131210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211690", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000013", BitNumber = "618"};
        public static readonly Materia HeartofWind = new Materia { Name = "Heart of Wind", MateriaId = "504211700", Description = "風のこころ", CountId = "2131220", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211700", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000007", BitNumber = "619"};
        public static readonly Materia HeartofEarth = new Materia { Name = "Heart of Earth", MateriaId = "504211710", Description = "土のこころ", CountId = "2131230", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211710", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000012", BitNumber = "620"};
        public static readonly Materia SwornSixsPrideLight = new Materia { Name = "Sworn Six's Pride - Light", MateriaId = "504212360", Description = "六盟傑の誇り・光", CountId = "2131540", EquipmentActiveAbility = "", EquipmentPassiveAbility = "212360", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "621"};
        public static readonly Materia SwornSixsPrideWind = new Materia { Name = "Sworn Six's Pride - Wind", MateriaId = "504212370", Description = "六盟傑の誇り・風", CountId = "2151620", EquipmentActiveAbility = "", EquipmentPassiveAbility = "212370", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "622"};
        public static readonly Materia SwornSixsPrideWater = new Materia { Name = "Sworn Six's Pride - Water", MateriaId = "504212380", Description = "六盟傑の誇り・水", CountId = "2151630", EquipmentActiveAbility = "", EquipmentPassiveAbility = "212380", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "623"};
        public static readonly Materia SleepResistance = new Materia { Name = "Sleep Resistance", MateriaId = "504212340", Description = "睡眠無効", CountId = "2154070", EquipmentActiveAbility = "", EquipmentPassiveAbility = "212340", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000014", BitNumber = "624"};
        public static readonly Materia WaterResistance = new Materia { Name = "Water Resistance +15%", MateriaId = "504212350", Description = "水属性耐性+15%", CountId = "2153530", EquipmentActiveAbility = "", EquipmentPassiveAbility = "212350", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000013", BitNumber = "625"};
        public static readonly Materia Relax = new Materia { Name = "Relax", MateriaId = "504213210", Description = "休息", CountId = "2172030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213210", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000091", BitNumber = "626"};
        public static readonly Materia EvasivenessSmall = new Materia { Name = "Evasiveness - Small", MateriaId = "504213220", Description = "回避性能【小】", CountId = "2177060", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213220", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000097", BitNumber = "627"};
        public static readonly Materia GreatEarplugs = new Materia { Name = "Great Earplugs", MateriaId = "504213230", Description = "高級耳栓", CountId = "2116040", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213230", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000014", BitNumber = "628"};
        public static readonly Materia GuardoftheFuture = new Materia { Name = "Guard of the Future", MateriaId = "504213420", Description = "未来を守る力", CountId = "2113060", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213420", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "629"};
        public static readonly Materia ThirstforSurvival = new Materia { Name = "Thirst for Survival", MateriaId = "504213530", Description = "生存への渇望", CountId = "2131550", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213530", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "630"};
        public static readonly Materia ThunderResistance = new Materia { Name = "Thunder Resistance +15%", MateriaId = "504213700", Description = "雷属性耐性+15%", CountId = "2153540", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213700", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000008", BitNumber = "631"};
        public static readonly Materia DarknesssFoe = new Materia { Name = "Darkness's Foe", MateriaId = "504213710", Description = "闇に抗う力", CountId = "2131240", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213710", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000098", BitNumber = "632"};
        public static readonly Materia LightsFoe = new Materia { Name = "Light's Foe", MateriaId = "504213720", Description = "光に抗う力", CountId = "2131250", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213720", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000099", BitNumber = "633"};
        public static readonly Materia MPStroll = new Materia { Name = "MP Stroll", MateriaId = "504213730", Description = "歩くとMP回復", CountId = "2179120", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101420", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000090", BitNumber = "634"};
        public static readonly Materia GeneralOffensive = new Materia { Name = "General Offensive", MateriaId = "504213740", Description = "総攻撃", CountId = "2133810", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213740", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "635"};
        public static readonly Materia MAG_504100110 = new Materia { Name = "MAG +20%", MateriaId = "504100110", Description = "魔力+20%", CountId = "2115030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100110", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000077", BitNumber = "636"};
        public static readonly Materia EquipInstrument = new Materia { Name = "Equip Instrument", MateriaId = "504100860", Description = "楽器装備", CountId = "2155110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100860", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000096", BitNumber = "637"};
        public static readonly Materia Darkra_504020460 = new Materia { Name = "Darkra", MateriaId = "504020460", Description = "ダーラ", CountId = "1250820", EquipmentActiveAbility = "20460", EquipmentPassiveAbility = "", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000026", BitNumber = "638"};
        public static readonly Materia FiraBlade = new Materia { Name = "Fira Blade", MateriaId = "504200610", Description = "ファイラ剣", CountId = "2240020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200610", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000021", BitNumber = "639"};
        public static readonly Materia AwesomeSwordsman = new Materia { Name = "Awesome Swordsman", MateriaId = "504213800", Description = "凛々しき剣士", CountId = "2151710", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213800", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000072", BitNumber = "640"};
        public static readonly Materia PureWhiteBlessing = new Materia { Name = "Pure White Blessing", MateriaId = "504214350", Description = "純白の祝福", CountId = "2171980", EquipmentActiveAbility = "", EquipmentPassiveAbility = "214350", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000091", BitNumber = "641"};
        public static readonly Materia HighSpirits = new Materia { Name = "High Spirits", MateriaId = "504214360", Description = "気炎万丈", CountId = "2133820", EquipmentActiveAbility = "", EquipmentPassiveAbility = "214360", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "642"};
        public static readonly Materia NA_504214720 = new Materia { Name = "N/A", MateriaId = "504214720", Description = "アルタメノスの光", CountId = "2151720", EquipmentActiveAbility = "", EquipmentPassiveAbility = "214720", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000095", BitNumber = "643"};
        public static readonly Materia DragonKiller_504211360 = new Materia { Name = "Dragon Killer+", MateriaId = "504211360", Description = "ドラゴンキラー改", CountId = "2152310", EquipmentActiveAbility = "", EquipmentPassiveAbility = "211360", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000079", BitNumber = "645"};
        public static readonly Materia MagesResolution = new Materia { Name = "Mage's Resolution", MateriaId = "504214930", Description = "魔道士の覚悟", CountId = "2151730", EquipmentActiveAbility = "", EquipmentPassiveAbility = "214930", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000095", BitNumber = "646"};
        public static readonly Materia BusterForm = new Materia { Name = "Buster Form", MateriaId = "504214990", Description = "バスターフォーム", CountId = "2171030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "214990", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000076", BitNumber = "647"};
        public static readonly Materia IceResistance_504215180 = new Materia { Name = "Ice Resistance +15%", MateriaId = "504215180", Description = "氷属性耐性+15%", CountId = "2153550", EquipmentActiveAbility = "", EquipmentPassiveAbility = "215180", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000010", BitNumber = "648"};
        public static readonly Materia Powerful = new Materia { Name = "Powerful", MateriaId = "504215190", Description = "パワフル", CountId = "2132200", EquipmentActiveAbility = "", EquipmentPassiveAbility = "215190", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "649"};
        public static readonly Materia Toughness = new Materia { Name = "Toughness", MateriaId = "504215200", Description = "タフネス", CountId = "2131740", EquipmentActiveAbility = "", EquipmentPassiveAbility = "215200", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "650"};
        public static readonly Materia ProofofTalent = new Materia { Name = "Proof of Talent", MateriaId = "504215360", Description = "才媛の証明", CountId = "2135320", EquipmentActiveAbility = "", EquipmentPassiveAbility = "215360", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000068", BitNumber = "651"};
        public static readonly Materia BlindResistance = new Materia { Name = "Blind Resistance", MateriaId = "504215440", Description = "暗闇無効", CountId = "2154080", EquipmentActiveAbility = "", EquipmentPassiveAbility = "215440", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000014", BitNumber = "652"};
        public static readonly Materia Encore = new Materia { Name = "Encore", MateriaId = "1500000011", Description = "Encore", CountId = "90011", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910142,101700,100010", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "504212570", BitNumber = "90011"};
        public static readonly Materia EchidnasKiss = new Materia { Name = "Echidna's Kiss", MateriaId = "1500000012", Description = "Echidna Kiss ", CountId = "90012", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100120", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "1500000012", BitNumber = "90012"};
        public static readonly Materia Renewal = new Materia { Name = "Renewal", MateriaId = "1500000014", Description = "Renewal", CountId = "90014", EquipmentActiveAbility = "", EquipmentPassiveAbility = "100740", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000091", BitNumber = "90014"};
        public static readonly Materia SpiritofFreedom = new Materia { Name = "Spirit of Freedom", MateriaId = "504216990", Description = "不羈への気焔", CountId = "2133330", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216990", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "665"};
        public static readonly Materia SagesPrajna = new Materia { Name = "Sage's Prajna", MateriaId = "504217040", Description = "賢人の智慧", CountId = "2131750", EquipmentActiveAbility = "", EquipmentPassiveAbility = "217040", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "666"};
        public static readonly Materia Adventurer = new Materia { Name = "Adventurer", MateriaId = "1500000013", Description = "Adventurer", CountId = "90013", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910230", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "1500000013", BitNumber = "90013"};
        public static readonly Materia AdventurerII = new Materia { Name = "Adventurer II", MateriaId = "1500000015", Description = "Adventurer +1", CountId = "90015", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910231", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "1500000013", BitNumber = "90015"};
        public static readonly Materia AdventurerIII = new Materia { Name = "Adventurer III", MateriaId = "1500000016", Description = "Adventurer +2", CountId = "90016", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910232", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "1500000013", BitNumber = "90016"};
        public static readonly Materia AdventurerIV = new Materia { Name = "Adventurer IV", MateriaId = "1500000017", Description = "Adventurer +3", CountId = "90017", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910233", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "1500000013", BitNumber = "90017"};
        public static readonly Materia AdventurerV = new Materia { Name = "Adventurer V", MateriaId = "1500000018", Description = "Adventurer +4", CountId = "90018", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910234", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "1500000013", BitNumber = "90018"};
        public static readonly Materia AeroraBlade = new Materia { Name = "Aerora Blade", MateriaId = "504200650", Description = "エアロラ剣", CountId = "2240420", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200650", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000025", BitNumber = "688"};
        public static readonly Materia DreamMaidensOracle = new Materia { Name = "Dream Maiden's Oracle", MateriaId = "504215930", Description = "夢巫女の託宣", CountId = "2151440", EquipmentActiveAbility = "", EquipmentPassiveAbility = "215930", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000095", BitNumber = "653"};
        public static readonly Materia CrazyDay = new Materia { Name = "Crazy Day", MateriaId = "504216050", Description = "ルナティックサバト", CountId = "2212570", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216050", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000019", BitNumber = "654"};
        public static readonly Materia CaneMastery = new Materia { Name = "Cane Mastery", MateriaId = "504216060", Description = "杖の極意", CountId = "2151370", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216060", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000095", BitNumber = "655"};
        public static readonly Materia BlizzaraBlade = new Materia { Name = "Blizzara Blade", MateriaId = "504200620", Description = "ブリザラ剣", CountId = "2240120", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200620", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000022", BitNumber = "656"};
        public static readonly Materia HPStroll = new Materia { Name = "HP Stroll", MateriaId = "504101410", Description = "歩くとHP回復", CountId = "2179130", EquipmentActiveAbility = "", EquipmentPassiveAbility = "101410", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000073", BitNumber = "657"};
        public static readonly Materia LoyalWarrior = new Materia { Name = "Loyal Warrior", MateriaId = "504216360", Description = "忠義の武人", CountId = "2133320", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216360", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "658"};
        public static readonly Materia ColdDefense = new Materia { Name = "Cold Defense", MateriaId = "504216370", Description = "コールドディフェンド", CountId = "2131260", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216370", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000010", BitNumber = "659"};
        public static readonly Materia ThunderDefense = new Materia { Name = "Thunder Defense", MateriaId = "504216380", Description = "サンダーディフェンド", CountId = "2131270", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216380", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000008", BitNumber = "660"};
        public static readonly Materia FireResistance = new Materia { Name = "Fire Resistance +15%", MateriaId = "504216400", Description = "火属性耐性+15%", CountId = "2153560", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216400", ItemStack = "99", ItemBuyPrice = "3000", ItemSellPrice = "300", ItemIdClone = "700000006", BitNumber = "661"};
        public static readonly Materia DragoonsPride = new Materia { Name = "Dragoon's Pride", MateriaId = "504216520", Description = "竜騎士の誇り", CountId = "2151380", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216520", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000095", BitNumber = "662"};
        public static readonly Materia BarrierMaster = new Materia { Name = "Barrier Master", MateriaId = "504216730", Description = "魔壁の操者", CountId = "2134330", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216730", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "663"};
        public static readonly Materia NullDisease = new Materia { Name = "Null Disease", MateriaId = "504216900", Description = "病気無効", CountId = "2154090", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216900", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000014", BitNumber = "664"};
        public static readonly Materia BlackImpulse = new Materia { Name = "Black Impulse", MateriaId = "504217350", Description = "黒き衝動", CountId = "2135330", EquipmentActiveAbility = "", EquipmentPassiveAbility = "217350", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "667"};
        public static readonly Materia FrozenHurricane = new Materia { Name = "Frozen Hurricane", MateriaId = "504217610", Description = "フローズンハリケーン", CountId = "2219420", EquipmentActiveAbility = "", EquipmentPassiveAbility = "217610", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000022", BitNumber = "668"};
        public static readonly Materia Spirit = new Materia { Name = "Spirit", MateriaId = "504217630", Description = "スピリット", CountId = "2132210", EquipmentActiveAbility = "", EquipmentPassiveAbility = "217630", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "669"};
        public static readonly Materia Girder = new Materia { Name = "Girder", MateriaId = "504217640", Description = "ガーダー", CountId = "2131760", EquipmentActiveAbility = "", EquipmentPassiveAbility = "217640", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "670"};
        public static readonly Materia ThundaraBlade = new Materia { Name = "Thundara Blade", MateriaId = "504200630", Description = "サンダラ剣", CountId = "2240130", EquipmentActiveAbility = "", EquipmentPassiveAbility = "200630", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "800", ItemIdClone = "700000020", BitNumber = "671"};
        public static readonly Materia SecretHat = new Materia { Name = "Secret Hat", MateriaId = "504217650", Description = "帽子の秘義", CountId = "2151390", EquipmentActiveAbility = "", EquipmentPassiveAbility = "217650", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000095", BitNumber = "672"};
        public static readonly Materia LightResistance_504216040 = new Materia { Name = "Light Resistance +20%", MateriaId = "504216040", Description = "光属性耐性+20%", CountId = "2153730", EquipmentActiveAbility = "", EquipmentPassiveAbility = "216040", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000099", BitNumber = "674"};
        public static readonly Materia PetrificationResistance = new Materia { Name = "Petrification Resistance", MateriaId = "504215170", Description = "石化無効", CountId = "2154100", EquipmentActiveAbility = "", EquipmentPassiveAbility = "215170", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000014", BitNumber = "675"};
        public static readonly Materia Broadminded = new Materia { Name = "Broadminded", MateriaId = "504217950", Description = "豪放磊落", CountId = "2133340", EquipmentActiveAbility = "", EquipmentPassiveAbility = "217950", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "676"};
        public static readonly Materia FreezingSpirit = new Materia { Name = "Freezing Spirit", MateriaId = "504218380", Description = "蒼紅の魂", CountId = "2131770", EquipmentActiveAbility = "", EquipmentPassiveAbility = "218380", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "677"};
        public static readonly Materia StrategistsIngenuity = new Materia { Name = "Strategist's Ingenuity", MateriaId = "504218390", Description = "軍師の知略", CountId = "2135340", EquipmentActiveAbility = "", EquipmentPassiveAbility = "218390", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "678"};
        public static readonly Materia MechanicalHeart = new Materia { Name = "Mechanical Heart", MateriaId = "504218860", Description = "機械仕掛けの心", CountId = "2131780", EquipmentActiveAbility = "", EquipmentPassiveAbility = "218860", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "679"};
        public static readonly Materia VengefulWrath = new Materia { Name = "Vengeful Wrath", MateriaId = "504218870", Description = "憎悪", CountId = "2131790", EquipmentActiveAbility = "", EquipmentPassiveAbility = "218870", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "680"};
        public static readonly Materia YevonsWisdom = new Materia { Name = "Yevon's Wisdom", MateriaId = "504219080", Description = "エボンの教え", CountId = "2117020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219080", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000077", BitNumber = "681"};
        public static readonly Materia PowerofPurification = new Materia { Name = "Power of Purification", MateriaId = "504219220", Description = "浄化の力", CountId = "2152130", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219220", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "682"};
        public static readonly Materia ArtofPurification = new Materia { Name = "Art of Purification", MateriaId = "504219230", Description = "浄化の術", CountId = "2152140", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219230", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000077", BitNumber = "683"};
        public static readonly Materia IceResistance_504219240 = new Materia { Name = "Ice Resistance +20%", MateriaId = "504219240", Description = "氷属性耐性+20%", CountId = "2153740", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219240", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000010", BitNumber = "684"};
        public static readonly Materia CradleofHorns = new Materia { Name = "Cradle of Horns", MateriaId = "504219250", Description = "ホーンクレイドル", CountId = "2290000", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219250", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000063", BitNumber = "685"};
        public static readonly Materia SecretLShield = new Materia { Name = "Secret L Shield", MateriaId = "504219260", Description = "軽盾の秘義", CountId = "2151400", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219260", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000095", BitNumber = "686"};
        public static readonly Materia DualWield_504219270 = new Materia { Name = "Dual Wield+", MateriaId = "504219270", Description = "にとうりゅう改", CountId = "2156010", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219270", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000072", BitNumber = "687"};
        public static readonly Materia UncollapsingWill = new Materia { Name = "Uncollapsing Will", MateriaId = "504219820", Description = "潰えぬ闘志", CountId = "2151410", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219820", ItemStack = "99", ItemBuyPrice = "50000", ItemSellPrice = "5000", ItemIdClone = "700000095", BitNumber = "689"};
        public static readonly Materia Hammersmith = new Materia { Name = "Hammersmith", MateriaId = "504219880", Description = "ハンマースミス", CountId = "2151351", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219880", ItemStack = "99", ItemBuyPrice = "15000", ItemSellPrice = "1500", ItemIdClone = "700000095", BitNumber = "690"};
        public static readonly Materia SilenceResistance = new Materia { Name = "Silence Resistance", MateriaId = "504213200", Description = "沈黙無効", CountId = "2154110", EquipmentActiveAbility = "", EquipmentPassiveAbility = "213200", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "700000014", BitNumber = "691"};
        public static readonly Materia SageofMysidia = new Materia { Name = "Sage of Mysidia", MateriaId = "504219890", Description = "ミシディアの賢者", CountId = "2132220", EquipmentActiveAbility = "", EquipmentPassiveAbility = "219890", ItemStack = "99", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "700000077", BitNumber = "692"};
        public static readonly Materia ManEater_504219910 = new Materia { Name = "Man-Eater+", MateriaId = "504219910", Description = "マンイーター改", CountId = "2152320", EquipmentActiveAbility = "", EquipmentPassiveAbility = "203260", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000079", BitNumber = "693"};
        public static readonly Materia Resentment = new Materia { Name = "Resentment", MateriaId = "1500000020", Description = "Resentment", CountId = "90020", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910311", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "90020"};
        public static readonly Materia Regenerator = new Materia { Name = "Regenerator", MateriaId = "1500000021", Description = "Regenerator", CountId = "90021", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910313", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000019", BitNumber = "90021"};
        public static readonly Materia ReactiveDefense = new Materia { Name = "Reactive Defense", MateriaId = "1500000022", Description = "Vigilance", CountId = "90022", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910314", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000019", BitNumber = "90022"};
        public static readonly Materia MalborosWhisper = new Materia { Name = "Malboro's Whisper", MateriaId = "1500000019", Description = "Malboro Whisper", CountId = "90019", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910338", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "90019"};
        public static readonly Materia RhythmicFlair = new Materia { Name = "Rhythmic Flair", MateriaId = "1500000025", Description = "Rhythmic Flair", CountId = "90025", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910387", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "504212570", BitNumber = "90025"};
        public static readonly Materia Casanova = new Materia { Name = "Casanova", MateriaId = "1500000023", Description = "Casanova", CountId = "90023", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910388,101500", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "90023"};
        public static readonly Materia WaterMaidenBlessing = new Materia { Name = "Water Maiden Blessing", MateriaId = "1500000024", Description = "Water Maiden Blessing", CountId = "90024", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910389,208980", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "700000077", BitNumber = "90024"};
        public static readonly Materia CodexofSwordMaster = new Materia { Name = "Codex of Sword Master", MateriaId = "1500000030", Description = "Codex of Sword Master", CountId = "90030", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910336", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "1500000030", BitNumber = "90030"};
        public static readonly Materia FullMoon = new Materia { Name = "Full Moon", MateriaId = "1500000026", Description = "Full Moon", CountId = "90026", EquipmentActiveAbility = "", EquipmentPassiveAbility = "910391", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "1100000096", BitNumber = "90026"};
        public static readonly Materia BlightedDespot = new Materia { Name = "Blighted Despot"};
        public static readonly Materia DrownedKing = new Materia { Name = "Drowned King"};
        public static readonly Materia LunariansHate = new Materia { Name = "Lunarian's Hate"};
        public static readonly Materia ValvalisSpirit = new Materia { Name = "Valvalis' Spirit"};

		public static readonly List<Materia> Materias = new List<Materia>
		{
           Libra,
           Cure,
           Blindna,
           Vox,
           Poisona,
           Banish,
           Paralyna,
           Stona,
           Esuna,
           Regen,
           Cleanse,
           Holy,
           Fire,
           Blizzard,
           Thunder,
           Water,
           Aero,
           Stone,
           Bio,
           Fira,
           Blizzara,
           Thundara,
           Watera,
           Aerora,
           Stonra,
           Gravity,
           Drain,
           Biora,
           Firaga,
           Blizzaga,
           Thundaga,
           Flare,
           Ultima,
           Sleep,
           Blind,
           Barfire,
           Barblizzard,
           Barthunder,
           Barwater,
           Baraero,
           Barstone,
           Silence,
           Barfira,
           Barblizzara,
           Barthundara,
           Shell,
           Deprotect,
           Deshell,
           Barwatera,
           Baraerora,
           Barstonra,
           HP_504100010,
           MP_504100040,
           MP_504100050,
           ATK_504100070,
           ATK_504100080,
           MAG_504100120,
           AutoLimit,
           EquipSSword,
           EquipLSword,
           EquipStaff,
           EquipHArmor,
           StoneKiller,
           MachineKiller,
           DragonKiller_504101050,
           AquanKiller,
           Cover,
           Counter,
           Evade,
           Camouflage,
           Doublehand,
           DualWield_504101370,
           Steal,
           Pilfer,
           Drink,
           Brace,
           Throw,
           Store,
           RagingFist,
           Escape,
           Barrage,
           MirrorofEquity,
           Aim,
           Bladeblitz,
           FireBlade,
           BlizzardBlade,
           SilenceBlade,
           WaterBlade,
           StoneBlade,
           BlindBlade,
           BioBlade,
           DrainBlade,
           ThundagaBlade,
           BiogaBlade,
           MagicInfuse,
           Lullaby,
           Paean,
           MentalBreak,
           SilenceDance,
           FireBeam,
           BlizzardBeam,
           BioBlaster,
           PowerShot,
           Sunbeam,
           Meteor,
           Comet,
           Protect,
           SPR_504100160,
           BugKiller,
           Cura,
           DEF_504100130,
           EquipBow,
           ReflectTest,
           Bravery,
           ATK_504100090,
           MAG_504100100,
           MP_504100060,
           HolyBlade,
           KatanaMastery,
           LightsBlessing,
           Dispel,
           Faith,
           HP_504100030,
           EquipAxe,
           EquipHat,
           SpiritSlayer,
           HP_504101500,
           SleepBlade,
           AeroBlade,
           StonraBlade,
           MelodyofLife,
           SealofDestruction_504201950,
           SealofProtection,
           GoddesssProtection,
           EquipHShield,
           Dualcast,
           Curada,
           EVOMAG,
           PlantKiller,
           WateraBlade,
           SecondWind,
           CrushArmor,
           Medicate,
           StoneThrow,
           EquipSpear,
           Thunderfall,
           HereWeGo,
           Attacker,
           Defender,
           StickyFingers,
           CoinSteal,
           LungeCombo,
           BurstShot,
           AutoProtect,
           EquipRod,
           BioraBlade,
           Acceptance,
           Knowledge,
           Ignorance,
           Discernment,
           SpeedPlus,
           Twinspell,
           InsulttoInjury,
           CutCards,
           Mentality,
           LettersandArms,
           ManasProtection,
           ManasBlessing,
           DeepThoughts,
           FairyWisdom,
           Mana,
           FullMoonSlash,
           AutoShell,
           OsmoseBlade,
           SyldrasProtection,
           Wisdom,
           Action,
           Innocence,
           Tranquility,
           GateofDestiny,
           WhiteKnight,
           TemperedShield,
           ImperialHelm,
           MP_504203240,
           ATK_504101600,
           DarkBond,
           WaterGodsProtection,
           Breaker,
           DemonicLife,
           DestroyersAuthority,
           GuardiansAuthority,
           PowerofCreation,
           DarkResistance,
           ChillingAura,
           SpookyAura,
           SealofDestruction_1500000003,
           MAG_504101700,
           Death,
           EquipClothes,
           ManEater_504101040,
           BirdKiller,
           AutoPotion,
           PowerBreak,
           MagicBreak,
           MiracleStep,
           CrushHelm,
           HealingWaltzII,
           Poach,
           FirstStrike,
           Lifefont,
           QuickAssault,
           DarkKnightsSoul,
           HillDigger,
           Successor,
           Magician,
           Fighter,
           SeethingCauldron,
           SwellingPower,
           BushidoFreedom,
           NA_504205650,
           NA_504205980,
           NA_504205880,
           NA_504206070,
           ThunderBlade,
           ArmorBreak,
           NA_504205710,
           NA_504205990,
           NA_504205660,
           UndeadKiller,
           NA_504206080,
           EmperorsMajesty,
           HereticAbyss,
           Resuscitate,
           Love,
           Resolve,
           Persistence,
           SiphonDelta,
           Multitask,
           AzureHelm,
           AzureArmor,
           AutoRefresh,
           EquipLShield,
           MageCannon,
           LargeSwordMastery,
           DivineSeal,
           ProtectionoftheTwelve,
           ShardofGenius,
           FollowersOath,
           HydaelynGuard,
           BeastKiller,
           Returner,
           WarriorMage,
           ToxicRain,
           RodMastery,
           RageMeteor,
           LightResistance_504208900,
           HealersWisdom,
           DEF_504208970,
           SPR_504208980,
           NullParalysis,
           DemonKiller,
           UseGrapplingWeapons,
           WarriorLore,
           MagesMonograph,
           Imperil,
           PatrioticRecall,
           Curaga,
           DEF_504100140,
           ManufactedNethicite,
           EarthResistance,
           NA_504900120,
           NA_504900130,
           NA_504900140,
           NA_504900150,
           NA_504900160,
           NA_504900170,
           NA_504900180,
           NA_504900190,
           NA_504900200,
           NA_504900210,
           NA_504900220,
           NA_504900230,
           NA_504900240,
           NA_504900250,
           NA_504900260,
           NA_504900270,
           NA_504900280,
           NA_504900290,
           NA_504900300,
           NA_504900310,
           NA_504900320,
           NA_504900330,
           NA_504900340,
           NA_504900350,
           NA_504900360,
           NA_504900370,
           NA_504900380,
           NA_504900390,
           Firaja,
           Blizzaja,
           Thundaja,
           Waterja,
           Aeroja,
           Stonja,
           MirrorCounter,
           LasswellLvl,
           NA_504900480,
           NA_504900490,
           NA_504900500,
           NA_504900510,
           NA_504900520,
           NA_504900530,
           NA_504900540,
           NA_504900550,
           NA_504900560,
           NA_504900570,
           NA_504900580,
           NA_504900590,
           NA_504900600,
           NA_504900610,
           NA_504900620,
           NA_504900630,
           NA_504900640,
           NA_504900650,
           NA_504900660,
           NA_504900670,
           NA_504900680,
           NA_504900690,
           NA_504900700,
           NA_504900710,
           NA_504900720,
           NA_504900730,
           NA_504900740,
           NA_504900750,
           NA_504900760,
           NA_504900770,
           NA_504900780,
           NA_504900790,
           NA_504900800,
           NA_504900810,
           NA_504900820,
           NA_504900830,
           NA_504900840,
           NA_504900850,
           NA_504900860,
           NA_504900870,
           NA_504900880,
           NA_504900890,
           NA_504900900,
           NA_504900910,
           NA_504900920,
           NA_504900930,
           NA_504900940,
           NA_504900950,
           NA_504900960,
           NA_504900970,
           NA_504900980,
           NA_504900990,
           NA_504901000,
           NA_504901010,
           NA_504901020,
           NA_504901030,
           NA_504901040,
           NA_504901050,
           NA_504901060,
           NA_504901070,
           NA_504901080,
           NA_504901090,
           NA_504901100,
           NA_504901110,
           NA_504901120,
           NA_504901130,
           NA_504901140,
           NA_504901150,
           NA_504901160,
           NA_504901170,
           NA_504901180,
           NA_504901190,
           NA_504901200,
           NA_504901210,
           NA_504901220,
           NA_504901230,
           NA_504901240,
           NA_504901250,
           NA_504901260,
           NA_504901270,
           NA_504901280,
           NA_504901290,
           NA_504901300,
           NA_504901310,
           NA_504901320,
           NA_504901330,
           Dark,
           Darkra_504901350,
           Darkga,
           NA_504901370,
           NA_504901380,
           NA_504901390,
           NA_504901400,
           NA_504901410,
           NA_504901420,
           NA_504901430,
           NA_504901440,
           NA_504901450,
           NA_504901460,
           NA_504901470,
           NA_504901480,
           NA_504901490,
           NA_504901500,
           NA_504901510,
           NA_504901520,
           Tornado,
           NA_504901540,
           NA_504901550,
           NA_504901560,
           NA_504901570,
           NA_504901580,
           NA_504901590,
           NA_504901600,
           NA_504901610,
           NA_504901620,
           NA_504901630,
           NA_504901640,
           NA_504901650,
           NA_504901660,
           NA_504901670,
           NA_504901680,
           NA_504901690,
           NA_504901700,
           NA_504901710,
           NA_504901720,
           NA_504901730,
           NA_504901740,
           NA_504901750,
           NA_504901760,
           NA_504901770,
           NA_504901780,
           NA_504901790,
           Jump,
           Kick,
           NA_504901820,
           NA_504901830,
           NA_504901840,
           NA_504901850,
           NA_504901860,
           NA_504901870,
           Burst,
           Quake,
           PureHeart,
           WinterWard,
           Deliverance,
           FirewallPower,
           SymphonicFlair,
           LightspeedJab,
           Cheerleader,
           ElvenPride,
           PoisonResistance,
           ProudFencer,
           HeavensGuidance,
           March,
           Vigilance,
           SPR_504100170,
           WindResistance,
           FalseSaint,
           SwornSixsPrideDark,
           SwornSixsPrideFire,
           SwornSixsPrideEarth,
           ConfusionResistance,
           MogSearch,
           MogSong,
           MogStep,
           MogResist,
           MogRise,
           MartialArtsMastery,
           WorldDestroyer,
           MogWisdom,
           HeartofFire,
           HeartofWater,
           HeartofWind,
           HeartofEarth,
           SwornSixsPrideLight,
           SwornSixsPrideWind,
           SwornSixsPrideWater,
           SleepResistance,
           WaterResistance,
           Relax,
           EvasivenessSmall,
           GreatEarplugs,
           GuardoftheFuture,
           ThirstforSurvival,
           ThunderResistance,
           DarknesssFoe,
           LightsFoe,
           MPStroll,
           GeneralOffensive,
           MAG_504100110,
           EquipInstrument,
           Darkra_504020460,
           FiraBlade,
           AwesomeSwordsman,
           PureWhiteBlessing,
           HighSpirits,
           NA_504214720,
           DragonKiller_504211360,
           MagesResolution,
           BusterForm,
           IceResistance_504215180,
           Powerful,
           Toughness,
           ProofofTalent,
           BlindResistance,
           Encore,
           EchidnasKiss,
           Renewal,
           SpiritofFreedom,
           SagesPrajna,
           Adventurer,
           AdventurerII,
           AdventurerIII,
           AdventurerIV,
           AdventurerV,
           AeroraBlade,
           DreamMaidensOracle,
           CrazyDay,
           CaneMastery,
           BlizzaraBlade,
           HPStroll,
           LoyalWarrior,
           ColdDefense,
           ThunderDefense,
           FireResistance,
           DragoonsPride,
           BarrierMaster,
           NullDisease,
           BlackImpulse,
           FrozenHurricane,
           Spirit,
           Girder,
           ThundaraBlade,
           SecretHat,
           LightResistance_504216040,
           PetrificationResistance,
           Broadminded,
           FreezingSpirit,
           StrategistsIngenuity,
           MechanicalHeart,
           VengefulWrath,
           YevonsWisdom,
           PowerofPurification,
           ArtofPurification,
           IceResistance_504219240,
           CradleofHorns,
           SecretLShield,
           DualWield_504219270,
           UncollapsingWill,
           Hammersmith,
           SilenceResistance,
           SageofMysidia,
           ManEater_504219910,
           Resentment,
           Regenerator,
           ReactiveDefense,
           MalborosWhisper,
           RhythmicFlair,
           Casanova,
           WaterMaidenBlessing,
           CodexofSwordMaster,
           FullMoon,
           BlightedDespot,
           DrownedKing,
           LunariansHate,
           ValvalisSpirit,
		};
    }
}