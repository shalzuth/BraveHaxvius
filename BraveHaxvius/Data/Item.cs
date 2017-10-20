using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Item
    {
        public String Name { get; set; }
        public String ItemId { get; set; }
        public String Description { get; set; }
        public String EquipmentRarity { get; set; }
        public String CountId { get; set; }
        public String IsPotUnit { get; set; }
        public String KeyName { get; set; }
        public String ItemStack { get; set; }
        public String ItemBuyPrice { get; set; }
        public String ItemSellPrice { get; set; }
        public String ItemIdClone { get; set; }
        public String BitNumber { get; set; }

        public static readonly Item Potion = new Item { Name = "Potion", ItemId = "101000100", Description = "ポーション", EquipmentRarity = "1", CountId = "1", IsPotUnit = "1", KeyName = "6", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "101000100", BitNumber = "1"};
        public static readonly Item HiPotion = new Item { Name = "Hi-Potion", ItemId = "101000200", Description = "ハイポーション", EquipmentRarity = "3", CountId = "2", IsPotUnit = "1", KeyName = "6", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "101000200", BitNumber = "2"};
        public static readonly Item XPotion = new Item { Name = "X-Potion", ItemId = "101000300", Description = "エクスポーション", EquipmentRarity = "5", CountId = "3", IsPotUnit = "1", KeyName = "6", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "101000300", BitNumber = "3"};
        public static readonly Item Ether = new Item { Name = "Ether", ItemId = "101001100", Description = "エーテル", EquipmentRarity = "3", CountId = "4", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "101001100", BitNumber = "4"};
        public static readonly Item TurboEther = new Item { Name = "Turbo Ether", ItemId = "101001200", Description = "エーテルターボ", EquipmentRarity = "5", CountId = "5", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "101001200", BitNumber = "5"};
        public static readonly Item Elixir = new Item { Name = "Elixir", ItemId = "101002100", Description = "エリクサー", EquipmentRarity = "8", CountId = "6", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "101002100", BitNumber = "6"};
        public static readonly Item PhoenixDown = new Item { Name = "Phoenix Down", ItemId = "101003100", Description = "フェニックスの尾", EquipmentRarity = "4", CountId = "7", IsPotUnit = "1", KeyName = "6", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "101003100", BitNumber = "7"};
        public static readonly Item Antidote = new Item { Name = "Antidote", ItemId = "102000100", Description = "毒消し", EquipmentRarity = "1", CountId = "8", IsPotUnit = "2", KeyName = "2", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "102000100", BitNumber = "8"};
        public static readonly Item EyeDrops = new Item { Name = "Eye Drops", ItemId = "102001100", Description = "目薬", EquipmentRarity = "1", CountId = "9", IsPotUnit = "2", KeyName = "2", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "102001100", BitNumber = "9"};
        public static readonly Item SmellingSalts = new Item { Name = "Smelling Salts", ItemId = "102002100", Description = "気付け薬", EquipmentRarity = "2", CountId = "10", IsPotUnit = "2", KeyName = "2", ItemStack = "99", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "102002100", BitNumber = "10"};
        public static readonly Item EchoHerbs = new Item { Name = "Echo Herbs", ItemId = "102003100", Description = "やまびこ草", EquipmentRarity = "2", CountId = "11", IsPotUnit = "2", KeyName = "2", ItemStack = "99", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "102003100", BitNumber = "11"};
        public static readonly Item UnicornHorn = new Item { Name = "Unicorn Horn", ItemId = "102004100", Description = "ユニコーンの角", EquipmentRarity = "3", CountId = "12", IsPotUnit = "2", KeyName = "2", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "102004100", BitNumber = "12"};
        public static readonly Item Vaccine = new Item { Name = "Vaccine", ItemId = "102005100", Description = "ワクチン", EquipmentRarity = "5", CountId = "13", IsPotUnit = "2", KeyName = "2", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "102005100", BitNumber = "13"};
        public static readonly Item GoldNeedle = new Item { Name = "Gold Needle", ItemId = "102006100", Description = "金の針", EquipmentRarity = "3", CountId = "14", IsPotUnit = "2", KeyName = "2", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "102006100", BitNumber = "14"};
        public static readonly Item Remedy = new Item { Name = "Remedy", ItemId = "102007100", Description = "万能薬", EquipmentRarity = "4", CountId = "15", IsPotUnit = "2", KeyName = "2", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "102007100", BitNumber = "15"};
        public static readonly Item Hyper = new Item { Name = "Hyper", ItemId = "102008100", Description = "興奮剤", EquipmentRarity = "4", CountId = "16", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "102008100", BitNumber = "16"};
        public static readonly Item LightCurtain = new Item { Name = "Light Curtain", ItemId = "103000100", Description = "光のカーテン", EquipmentRarity = "6", CountId = "17", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "103000100", BitNumber = "17"};
        public static readonly Item LunarCurtain = new Item { Name = "Lunar Curtain", ItemId = "103001100", Description = "月のカーテン", EquipmentRarity = "6", CountId = "18", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "103001100", BitNumber = "18"};
        public static readonly Item HealingSpring = new Item { Name = "Healing Spring", ItemId = "103002100", Description = "回復の泉", EquipmentRarity = "4", CountId = "19", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "103002100", BitNumber = "19"};
        public static readonly Item SmokeBomb = new Item { Name = "Smoke Bomb", ItemId = "103003100", Description = "煙玉", EquipmentRarity = "1", CountId = "20", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "103003100", BitNumber = "20"};
        public static readonly Item BodyBoost = new Item { Name = "Body Boost", ItemId = "103006100", Description = "力の薬", EquipmentRarity = "3", CountId = "21", IsPotUnit = "3", KeyName = "3", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "103006100", BitNumber = "23"};
        public static readonly Item ManaBoost = new Item { Name = "Mana Boost", ItemId = "103007100", Description = "魔力の薬", EquipmentRarity = "3", CountId = "22", IsPotUnit = "3", KeyName = "3", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "103007100", BitNumber = "24"};
        public static readonly Item ProtectDrink = new Item { Name = "Protect Drink", ItemId = "103008100", Description = "プロテスドリンク", EquipmentRarity = "4", CountId = "23", IsPotUnit = "3", KeyName = "3", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "103008100", BitNumber = "25"};
        public static readonly Item ShellDrink = new Item { Name = "Shell Drink", ItemId = "103009100", Description = "シェルドリンク", EquipmentRarity = "4", CountId = "24", IsPotUnit = "3", KeyName = "3", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "103009100", BitNumber = "26"};
        public static readonly Item BacchussWine = new Item { Name = "Bacchus's Wine", ItemId = "103010100", Description = "バッカスの酒", EquipmentRarity = "3", CountId = "25", IsPotUnit = "3", KeyName = "3", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "103010100", BitNumber = "27"};
        public static readonly Item HeroDrink = new Item { Name = "Hero Drink", ItemId = "103100100", Description = "英雄の薬", EquipmentRarity = "7", CountId = "26", IsPotUnit = "3", KeyName = "3", ItemStack = "99", ItemBuyPrice = "7000", ItemSellPrice = "700", ItemIdClone = "103100100", BitNumber = "21"};
        public static readonly Item GiantsDrink = new Item { Name = "Giant's Drink", ItemId = "103101100", Description = "巨人の薬", EquipmentRarity = "7", CountId = "27", IsPotUnit = "3", KeyName = "3", ItemStack = "99", ItemBuyPrice = "7000", ItemSellPrice = "700", ItemIdClone = "103101100", BitNumber = "22"};
        public static readonly Item BombFragment = new Item { Name = "Bomb Fragment", ItemId = "104000100", Description = "ボムのかけら", EquipmentRarity = "1", CountId = "28", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "104000100", BitNumber = "28"};
        public static readonly Item BombArm = new Item { Name = "Bomb Arm", ItemId = "104000200", Description = "ボムの右腕", EquipmentRarity = "3", CountId = "29", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "104000200", BitNumber = "29"};
        public static readonly Item AntarcticWind = new Item { Name = "Antarctic Wind", ItemId = "104001100", Description = "南極の風", EquipmentRarity = "1", CountId = "30", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "104001100", BitNumber = "30"};
        public static readonly Item ArcticWind = new Item { Name = "Arctic Wind", ItemId = "104001200", Description = "北極の風", EquipmentRarity = "3", CountId = "31", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "104001200", BitNumber = "31"};
        public static readonly Item ZeussWrath = new Item { Name = "Zeus's Wrath", ItemId = "104002100", Description = "ゼウスの怒り", EquipmentRarity = "1", CountId = "32", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "104002100", BitNumber = "32"};
        public static readonly Item HeavenlyWrath = new Item { Name = "Heavenly Wrath", ItemId = "104002200", Description = "神々の怒り", EquipmentRarity = "3", CountId = "33", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "104002200", BitNumber = "33"};
        public static readonly Item FishScale = new Item { Name = "Fish Scale", ItemId = "104003100", Description = "魚のウロコ", EquipmentRarity = "1", CountId = "34", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "104003100", BitNumber = "34"};
        public static readonly Item DragonScale_104003200 = new Item { Name = "Dragon Scale", ItemId = "104003200", Description = "龍のウロコ", EquipmentRarity = "3", CountId = "35", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "104003200", BitNumber = "35"};
        public static readonly Item GiantFeather = new Item { Name = "Giant Feather", ItemId = "104004100", Description = "巨鳥の羽", EquipmentRarity = "1", CountId = "36", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "104004100", BitNumber = "36"};
        public static readonly Item WyvernFeather = new Item { Name = "Wyvern Feather", ItemId = "104004200", Description = "ワイバーンの羽", EquipmentRarity = "3", CountId = "37", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "104004200", BitNumber = "37"};
        public static readonly Item EarthDrum = new Item { Name = "Earth Drum", ItemId = "104005100", Description = "大地のドラム", EquipmentRarity = "1", CountId = "38", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "104005100", BitNumber = "38"};
        public static readonly Item GaiasCry = new Item { Name = "Gaia's Cry", ItemId = "104005200", Description = "大地のうなり", EquipmentRarity = "3", CountId = "39", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "104005200", BitNumber = "39"};
        public static readonly Item RedFang = new Item { Name = "Red Fang", ItemId = "104006100", Description = "赤い牙", EquipmentRarity = "5", CountId = "40", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "104006100", BitNumber = "40"};
        public static readonly Item WhiteFang = new Item { Name = "White Fang", ItemId = "104007100", Description = "白い牙", EquipmentRarity = "5", CountId = "41", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "104007100", BitNumber = "41"};
        public static readonly Item BlueFang = new Item { Name = "Blue Fang", ItemId = "104008100", Description = "青い牙", EquipmentRarity = "5", CountId = "42", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "104008100", BitNumber = "42"};
        public static readonly Item HolyTorch = new Item { Name = "Holy Torch", ItemId = "104009100", Description = "聖なるトーチ", EquipmentRarity = "5", CountId = "43", IsPotUnit = "3", KeyName = "1", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "104009100", BitNumber = "43"};
        public static readonly Item Grenade = new Item { Name = "Grenade", ItemId = "105000100", Description = "手榴弾", EquipmentRarity = "2", CountId = "44", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "105000100", BitNumber = "44"};
        public static readonly Item FragGrenade = new Item { Name = "Frag Grenade", ItemId = "105001100", Description = "徹甲手榴弾", EquipmentRarity = "4", CountId = "45", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "105001100", BitNumber = "45"};
        public static readonly Item Shuriken = new Item { Name = "Shuriken", ItemId = "105002100", Description = "手裏剣", EquipmentRarity = "3", CountId = "46", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "105002100", BitNumber = "46"};
        public static readonly Item FumaShuriken = new Item { Name = "Fuma Shuriken", ItemId = "105003100", Description = "風魔手裏剣", EquipmentRarity = "4", CountId = "47", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "105003100", BitNumber = "47"};
        public static readonly Item Pinwheel = new Item { Name = "Pinwheel", ItemId = "105004100", Description = "風車", EquipmentRarity = "5", CountId = "48", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "105004100", BitNumber = "48"};
        public static readonly Item Tent = new Item { Name = "Tent", ItemId = "106000100", Description = "テント", EquipmentRarity = "3", CountId = "49", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106000100", BitNumber = "49"};
        public static readonly Item MagicKey = new Item { Name = "Magic Key", ItemId = "106100100", Description = "魔法の鍵", EquipmentRarity = "8", CountId = "50", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "106100100", BitNumber = "50"};
        public static readonly Item StarQuartz = new Item { Name = "Star Quartz", ItemId = "106200100", Description = "スタークォーツ", EquipmentRarity = "8", CountId = "51", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000010", BitNumber = "165"};
        public static readonly Item MagiciteShard = new Item { Name = "Magicite Shard", ItemId = "107000100", Description = "魔石のカケラ", EquipmentRarity = "1", CountId = "52", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "107000100", BitNumber = "51"};
        public static readonly Item Magicite = new Item { Name = "Magicite", ItemId = "107000200", Description = "魔石", EquipmentRarity = "2", CountId = "53", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "107000200", BitNumber = "52"};
        public static readonly Item RedMagicite = new Item { Name = "Red Magicite", ItemId = "107001100", Description = "赤の魔石", EquipmentRarity = "3", CountId = "54", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "107001100", BitNumber = "53"};
        public static readonly Item BlueMagicite = new Item { Name = "Blue Magicite", ItemId = "107001200", Description = "青の魔石", EquipmentRarity = "3", CountId = "55", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "107001200", BitNumber = "54"};
        public static readonly Item GreenMagicite = new Item { Name = "Green Magicite", ItemId = "107001300", Description = "緑の魔石", EquipmentRarity = "3", CountId = "56", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "107001300", BitNumber = "55"};
        public static readonly Item WhiteMagicite = new Item { Name = "White Magicite", ItemId = "107001400", Description = "白の魔石", EquipmentRarity = "4", CountId = "57", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "107001400", BitNumber = "56"};
        public static readonly Item BlackMagicite = new Item { Name = "Black Magicite", ItemId = "107001500", Description = "黒の魔石", EquipmentRarity = "4", CountId = "58", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "107001500", BitNumber = "57"};
        public static readonly Item RedMegacite = new Item { Name = "Red Megacite", ItemId = "107001600", Description = "赤の大魔石", EquipmentRarity = "5", CountId = "59", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "107001600", BitNumber = "58"};
        public static readonly Item BlueMegacite = new Item { Name = "Blue Megacite", ItemId = "107001700", Description = "青の大魔石", EquipmentRarity = "5", CountId = "60", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "107001700", BitNumber = "59"};
        public static readonly Item GreenMegacite = new Item { Name = "Green Megacite", ItemId = "107001800", Description = "緑の大魔石", EquipmentRarity = "5", CountId = "61", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "107001800", BitNumber = "60"};
        public static readonly Item WhiteMegacite = new Item { Name = "White Megacite", ItemId = "107001900", Description = "白の大魔石", EquipmentRarity = "6", CountId = "62", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "107001900", BitNumber = "61"};
        public static readonly Item BlackMegacite = new Item { Name = "Black Megacite", ItemId = "107002000", Description = "黒の大魔石", EquipmentRarity = "6", CountId = "63", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "107002000", BitNumber = "62"};
        public static readonly Item EarthKey_109201000 = new Item { Name = "Earth Key #1", ItemId = "109201000", Description = "大地の鍵1", EquipmentRarity = "7", CountId = "64", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201000", BitNumber = "63"};
        public static readonly Item EarthKey_109201010 = new Item { Name = "Earth Key #2", ItemId = "109201010", Description = "大地の鍵2", EquipmentRarity = "7", CountId = "65", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201010", BitNumber = "64"};
        public static readonly Item EarthKey_109201020 = new Item { Name = "Earth Key #3", ItemId = "109201020", Description = "大地の鍵3", EquipmentRarity = "7", CountId = "66", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201020", BitNumber = "65"};
        public static readonly Item EarthKey_109201030 = new Item { Name = "Earth Key #4", ItemId = "109201030", Description = "大地の鍵4", EquipmentRarity = "7", CountId = "67", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201030", BitNumber = "66"};
        public static readonly Item EarthKey_109201040 = new Item { Name = "Earth Key #5", ItemId = "109201040", Description = "大地の鍵5", EquipmentRarity = "7", CountId = "68", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201040", BitNumber = "67"};
        public static readonly Item EarthKey_109201050 = new Item { Name = "Earth Key #6", ItemId = "109201050", Description = "大地の鍵6", EquipmentRarity = "7", CountId = "69", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201050", BitNumber = "68"};
        public static readonly Item EarthKey_109201060 = new Item { Name = "Earth Key #7", ItemId = "109201060", Description = "大地の鍵7", EquipmentRarity = "7", CountId = "70", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201060", BitNumber = "69"};
        public static readonly Item EarthKey_109201070 = new Item { Name = "Earth Key #8", ItemId = "109201070", Description = "大地の鍵8", EquipmentRarity = "7", CountId = "71", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201070", BitNumber = "70"};
        public static readonly Item EarthKey_109201080 = new Item { Name = "Earth Key #9", ItemId = "109201080", Description = "大地の鍵9", EquipmentRarity = "7", CountId = "72", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201080", BitNumber = "71"};
        public static readonly Item EarthKey_109201090 = new Item { Name = "Earth Key #10", ItemId = "109201090", Description = "大地の鍵10", EquipmentRarity = "7", CountId = "73", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201090", BitNumber = "72"};
        public static readonly Item EarthKey_109201100 = new Item { Name = "Earth Key #11", ItemId = "109201100", Description = "大地の鍵11", EquipmentRarity = "7", CountId = "74", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201100", BitNumber = "73"};
        public static readonly Item EarthKey_109201110 = new Item { Name = "Earth Key #12", ItemId = "109201110", Description = "大地の鍵12", EquipmentRarity = "7", CountId = "75", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201110", BitNumber = "74"};
        public static readonly Item EarthKey_109201120 = new Item { Name = "Earth Key #13", ItemId = "109201120", Description = "大地の鍵13", EquipmentRarity = "7", CountId = "76", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201120", BitNumber = "75"};
        public static readonly Item EarthKey_109201130 = new Item { Name = "Earth Key #14", ItemId = "109201130", Description = "大地の鍵14", EquipmentRarity = "7", CountId = "77", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201130", BitNumber = "76"};
        public static readonly Item EarthKey_109201140 = new Item { Name = "Earth Key #15", ItemId = "109201140", Description = "大地の鍵15", EquipmentRarity = "7", CountId = "78", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201140", BitNumber = "77"};
        public static readonly Item EarthKey_109201150 = new Item { Name = "Earth Key #16", ItemId = "109201150", Description = "大地の鍵16", EquipmentRarity = "7", CountId = "79", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201150", BitNumber = "78"};
        public static readonly Item EarthKey_109201160 = new Item { Name = "Earth Key #17", ItemId = "109201160", Description = "大地の鍵17", EquipmentRarity = "7", CountId = "80", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201160", BitNumber = "79"};
        public static readonly Item EarthKey_109201170 = new Item { Name = "Earth Key #18", ItemId = "109201170", Description = "大地の鍵18", EquipmentRarity = "7", CountId = "81", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201170", BitNumber = "80"};
        public static readonly Item EarthKey_109201180 = new Item { Name = "Earth Key #19", ItemId = "109201180", Description = "大地の鍵19", EquipmentRarity = "7", CountId = "82", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201180", BitNumber = "81"};
        public static readonly Item EarthKey_109201190 = new Item { Name = "Earth Key #20", ItemId = "109201190", Description = "大地の鍵20", EquipmentRarity = "7", CountId = "83", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201190", BitNumber = "82"};
        public static readonly Item EarthKey_109201200 = new Item { Name = "Earth Key #21", ItemId = "109201200", Description = "大地の鍵21", EquipmentRarity = "7", CountId = "84", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201200", BitNumber = "83"};
        public static readonly Item EarthKey_109201210 = new Item { Name = "Earth Key #22", ItemId = "109201210", Description = "大地の鍵22", EquipmentRarity = "7", CountId = "85", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201210", BitNumber = "84"};
        public static readonly Item EarthKey_109201220 = new Item { Name = "Earth Key #23", ItemId = "109201220", Description = "大地の鍵23", EquipmentRarity = "7", CountId = "86", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201220", BitNumber = "85"};
        public static readonly Item EarthKey_109201230 = new Item { Name = "Earth Key #24", ItemId = "109201230", Description = "大地の鍵24", EquipmentRarity = "7", CountId = "87", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201230", BitNumber = "86"};
        public static readonly Item EarthKey_109201240 = new Item { Name = "Earth Key #25", ItemId = "109201240", Description = "大地の鍵25", EquipmentRarity = "7", CountId = "88", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201240", BitNumber = "87"};
        public static readonly Item FireCryst = new Item { Name = "Fire Cryst", ItemId = "201000100", Description = "火の結晶", EquipmentRarity = "1", CountId = "89", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "201000100", BitNumber = "88"};
        public static readonly Item IceCryst = new Item { Name = "Ice Cryst", ItemId = "201000200", Description = "氷の結晶", EquipmentRarity = "1", CountId = "90", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "201000200", BitNumber = "89"};
        public static readonly Item LightningCryst = new Item { Name = "Lightning Cryst", ItemId = "201000300", Description = "雷の結晶", EquipmentRarity = "1", CountId = "91", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "201000300", BitNumber = "90"};
        public static readonly Item WaterCryst = new Item { Name = "Water Cryst", ItemId = "201000400", Description = "水の結晶", EquipmentRarity = "1", CountId = "92", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "201000400", BitNumber = "91"};
        public static readonly Item EarthCryst = new Item { Name = "Earth Cryst", ItemId = "201000500", Description = "土の結晶", EquipmentRarity = "1", CountId = "93", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "201000500", BitNumber = "92"};
        public static readonly Item WindCryst = new Item { Name = "Wind Cryst", ItemId = "201000600", Description = "風の結晶", EquipmentRarity = "1", CountId = "94", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "201000600", BitNumber = "93"};
        public static readonly Item LightCryst = new Item { Name = "Light Cryst", ItemId = "201000700", Description = "光の結晶", EquipmentRarity = "2", CountId = "95", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "201000700", BitNumber = "94"};
        public static readonly Item DarkCryst = new Item { Name = "Dark Cryst", ItemId = "201000800", Description = "闇の結晶", EquipmentRarity = "2", CountId = "96", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "201000800", BitNumber = "95"};
        public static readonly Item FireMegacryst = new Item { Name = "Fire Megacryst", ItemId = "201000900", Description = "火の大結晶", EquipmentRarity = "3", CountId = "97", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "201000900", BitNumber = "96"};
        public static readonly Item IceMegacryst = new Item { Name = "Ice Megacryst", ItemId = "201001000", Description = "氷の大結晶", EquipmentRarity = "3", CountId = "98", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "201001000", BitNumber = "97"};
        public static readonly Item LightningMegacryst = new Item { Name = "Lightning Megacryst", ItemId = "201001100", Description = "雷の大結晶", EquipmentRarity = "3", CountId = "99", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "201001100", BitNumber = "98"};
        public static readonly Item WaterMegacryst = new Item { Name = "Water Megacryst", ItemId = "201001200", Description = "水の大結晶", EquipmentRarity = "3", CountId = "100", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "201001200", BitNumber = "99"};
        public static readonly Item EarthMegacryst = new Item { Name = "Earth Megacryst", ItemId = "201001300", Description = "土の大結晶", EquipmentRarity = "3", CountId = "101", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "201001300", BitNumber = "100"};
        public static readonly Item WindMegacryst = new Item { Name = "Wind Megacryst", ItemId = "201001400", Description = "風の大結晶", EquipmentRarity = "3", CountId = "102", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "201001400", BitNumber = "101"};
        public static readonly Item LightMegacryst = new Item { Name = "Light Megacryst", ItemId = "201001500", Description = "光の大結晶", EquipmentRarity = "4", CountId = "103", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "201001500", BitNumber = "102"};
        public static readonly Item DarkMegacryst = new Item { Name = "Dark Megacryst", ItemId = "201001600", Description = "闇の大結晶", EquipmentRarity = "4", CountId = "104", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "201001600", BitNumber = "103"};
        public static readonly Item LifeOrb = new Item { Name = "Life Orb", ItemId = "202000100", Description = "生命の珠", EquipmentRarity = "1", CountId = "105", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202000100", BitNumber = "104"};
        public static readonly Item FarplaneSoul = new Item { Name = "Farplane Soul", ItemId = "202000200", Description = "異界の魂", EquipmentRarity = "1", CountId = "106", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202000200", BitNumber = "105"};
        public static readonly Item GaiasTear = new Item { Name = "Gaia's Tear", ItemId = "202000300", Description = "大地の涙", EquipmentRarity = "1", CountId = "107", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202000300", BitNumber = "106"};
        public static readonly Item ThickenedHide = new Item { Name = "Thickened Hide", ItemId = "202000400", Description = "丈夫な皮", EquipmentRarity = "1", CountId = "108", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202000400", BitNumber = "107"};
        public static readonly Item RaptorFeather = new Item { Name = "Raptor Feather", ItemId = "202000500", Description = "凶鳥の羽", EquipmentRarity = "1", CountId = "109", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202000500", BitNumber = "108"};
        public static readonly Item ChromaticOoze = new Item { Name = "Chromatic Ooze", ItemId = "202000600", Description = "彩りゼリー", EquipmentRarity = "1", CountId = "110", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202000600", BitNumber = "109"};
        public static readonly Item DemonTail = new Item { Name = "Demon Tail", ItemId = "202000700", Description = "悪魔のしっぽ", EquipmentRarity = "1", CountId = "111", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202000700", BitNumber = "110"};
        public static readonly Item BrokenBlade = new Item { Name = "Broken Blade", ItemId = "202000800", Description = "折れた刃", EquipmentRarity = "1", CountId = "112", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202000800", BitNumber = "111"};
        public static readonly Item DigitalCircuit = new Item { Name = "Digital Circuit", ItemId = "202000900", Description = "デジタル回路", EquipmentRarity = "1", CountId = "113", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202000900", BitNumber = "112"};
        public static readonly Item DragonFang = new Item { Name = "Dragon Fang", ItemId = "202001000", Description = "竜の牙", EquipmentRarity = "1", CountId = "114", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202001000", BitNumber = "113"};
        public static readonly Item Glowseeds = new Item { Name = "Glowseeds", ItemId = "202001100", Description = "光る種", EquipmentRarity = "1", CountId = "115", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202001100", BitNumber = "114"};
        public static readonly Item Spellsilk = new Item { Name = "Spellsilk", ItemId = "202001200", Description = "魔虫の糸", EquipmentRarity = "1", CountId = "116", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202001200", BitNumber = "115"};
        public static readonly Item QualityStone = new Item { Name = "Quality Stone", ItemId = "202001300", Description = "良質の石材", EquipmentRarity = "1", CountId = "117", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202001300", BitNumber = "116"};
        public static readonly Item GummyOil = new Item { Name = "Gummy Oil", ItemId = "202001400", Description = "べとつく油", EquipmentRarity = "1", CountId = "118", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202001400", BitNumber = "117"};
        public static readonly Item GreenFluid = new Item { Name = "Green Fluid", ItemId = "202001500", Description = "緑色の液体", EquipmentRarity = "1", CountId = "119", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202001500", BitNumber = "118"};
        public static readonly Item OtherworldlyBone = new Item { Name = "Otherworldly Bone", ItemId = "202001600", Description = "魔獣の骨", EquipmentRarity = "2", CountId = "120", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202001600", BitNumber = "119"};
        public static readonly Item AbominableWing = new Item { Name = "Abominable Wing", ItemId = "202001700", Description = "怪魔の翼", EquipmentRarity = "2", CountId = "121", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202001700", BitNumber = "120"};
        public static readonly Item ToughScale = new Item { Name = "Tough Scale", ItemId = "202001800", Description = "硬い鱗", EquipmentRarity = "2", CountId = "122", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202001800", BitNumber = "121"};
        public static readonly Item CursedTusk = new Item { Name = "Cursed Tusk", ItemId = "202001900", Description = "忌まわしき牙", EquipmentRarity = "2", CountId = "123", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202001900", BitNumber = "122"};
        public static readonly Item WizardStone = new Item { Name = "Wizard Stone", ItemId = "202002000", Description = "魔導石", EquipmentRarity = "2", CountId = "124", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202002000", BitNumber = "123"};
        public static readonly Item PolymerEmulsion = new Item { Name = "Polymer Emulsion", ItemId = "202002100", Description = "高分子体", EquipmentRarity = "2", CountId = "125", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202002100", BitNumber = "124"};
        public static readonly Item DragonScale_202002200 = new Item { Name = "Dragon Scale", ItemId = "202002200", Description = "竜の鱗", EquipmentRarity = "2", CountId = "126", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202002200", BitNumber = "125"};
        public static readonly Item ElementalTear = new Item { Name = "Elemental Tear", ItemId = "202002300", Description = "精霊の涙", EquipmentRarity = "2", CountId = "127", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202002300", BitNumber = "126"};
        public static readonly Item RockbeetleHusk = new Item { Name = "Rockbeetle Husk", ItemId = "202002400", Description = "硬虫の甲殻", EquipmentRarity = "2", CountId = "128", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202002400", BitNumber = "127"};
        public static readonly Item SparklingStone = new Item { Name = "Sparkling Stone", ItemId = "202002500", Description = "輝石", EquipmentRarity = "2", CountId = "129", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202002500", BitNumber = "128"};
        public static readonly Item Screamroot = new Item { Name = "Screamroot", ItemId = "202002600", Description = "さけびの根", EquipmentRarity = "2", CountId = "130", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202002600", BitNumber = "129"};
        public static readonly Item CorpseFly = new Item { Name = "Corpse Fly", ItemId = "202002700", Description = "死虫", EquipmentRarity = "2", CountId = "131", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202002700", BitNumber = "130"};
        public static readonly Item CopperOre = new Item { Name = "Copper Ore", ItemId = "203000100", Description = "銅鉱", EquipmentRarity = "1", CountId = "132", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "203000100", BitNumber = "131"};
        public static readonly Item IronOre = new Item { Name = "Iron Ore", ItemId = "203000200", Description = "鉄鉱", EquipmentRarity = "2", CountId = "133", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "203000200", BitNumber = "132"};
        public static readonly Item SilverOre = new Item { Name = "Silver Ore", ItemId = "203000300", Description = "銀鉱", EquipmentRarity = "3", CountId = "134", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "203000300", BitNumber = "133"};
        public static readonly Item MythrilOre = new Item { Name = "Mythril Ore", ItemId = "203000400", Description = "ミスリル鉱", EquipmentRarity = "4", CountId = "135", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "203000400", BitNumber = "134"};
        public static readonly Item Lumber = new Item { Name = "Lumber", ItemId = "204000100", Description = "木材", EquipmentRarity = "1", CountId = "136", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "204000100", BitNumber = "135"};
        public static readonly Item Alcryst = new Item { Name = "Alcryst", ItemId = "280000100", Description = "錬晶石", EquipmentRarity = "2", CountId = "137", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "280000100", BitNumber = "136"};
        public static readonly Item FineAlcryst = new Item { Name = "Fine Alcryst", ItemId = "280000200", Description = "錬晶輝石", EquipmentRarity = "5", CountId = "138", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "280000200", BitNumber = "137"};
        public static readonly Item BeastMeat = new Item { Name = "Beast Meat", ItemId = "290010000", Description = "戦獣の肉", EquipmentRarity = "2", CountId = "139", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "290010000", BitNumber = "138"};
        public static readonly Item PearlofWisdom = new Item { Name = "Pearl of Wisdom", ItemId = "290010100", Description = "知識の珠", EquipmentRarity = "2", CountId = "140", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "290010100", BitNumber = "139"};
        public static readonly Item AllurePowder = new Item { Name = "Allure Powder", ItemId = "290010200", Description = "魅惑の砂", EquipmentRarity = "2", CountId = "141", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "290010200", BitNumber = "140"};
        public static readonly Item Litrock = new Item { Name = "Litrock", ItemId = "290020000", Description = "光の石塊", EquipmentRarity = "3", CountId = "142", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290020000", BitNumber = "141"};
        public static readonly Item SeedofLife = new Item { Name = "Seed of Life", ItemId = "290020100", Description = "生命の種", EquipmentRarity = "3", CountId = "143", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290020100", BitNumber = "142"};
        public static readonly Item CrimsonTear = new Item { Name = "Crimson Tear", ItemId = "290020200", Description = "真紅の涙", EquipmentRarity = "3", CountId = "144", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290020200", BitNumber = "143"};
        public static readonly Item MysticOre = new Item { Name = "Mystic Ore", ItemId = "290020300", Description = "魔原石", EquipmentRarity = "3", CountId = "145", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290020300", BitNumber = "144"};
        public static readonly Item AquaPearl = new Item { Name = "Aqua Pearl", ItemId = "290020400", Description = "蒼い宝珠", EquipmentRarity = "3", CountId = "146", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290020400", BitNumber = "145"};
        public static readonly Item LuminousHorn = new Item { Name = "Luminous Horn", ItemId = "290020500", Description = "燐光の角", EquipmentRarity = "3", CountId = "147", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290020500", BitNumber = "146"};
        public static readonly Item QualityParts = new Item { Name = "Quality Parts", ItemId = "290020600", Description = "高質機素", EquipmentRarity = "3", CountId = "148", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290020600", BitNumber = "147"};
        public static readonly Item RainbowNeedle = new Item { Name = "Rainbow Needle", ItemId = "290020700", Description = "虹色の針", EquipmentRarity = "3", CountId = "149", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290020700", BitNumber = "148"};
        public static readonly Item GoldenEgg = new Item { Name = "Golden Egg", ItemId = "290020800", Description = "金の卵", EquipmentRarity = "3", CountId = "150", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290020800", BitNumber = "149"};
        public static readonly Item BookofRuin = new Item { Name = "Book of Ruin", ItemId = "290020900", Description = "破滅の書", EquipmentRarity = "3", CountId = "151", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290020900", BitNumber = "150"};
        public static readonly Item EarthsCore = new Item { Name = "Earth's Core", ItemId = "290030000", Description = "大地の凝晶", EquipmentRarity = "4", CountId = "152", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290030000", BitNumber = "151"};
        public static readonly Item HeavensAsh = new Item { Name = "Heaven's Ash", ItemId = "290030100", Description = "天空の灰", EquipmentRarity = "4", CountId = "153", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290030100", BitNumber = "152"};
        public static readonly Item DeepseaBloom = new Item { Name = "Deepsea Bloom", ItemId = "290030200", Description = "深海の魔花", EquipmentRarity = "4", CountId = "154", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290030200", BitNumber = "153"};
        public static readonly Item ScriptureofTime = new Item { Name = "Scripture of Time", ItemId = "290030300", Description = "時空の教典", EquipmentRarity = "4", CountId = "155", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290030300", BitNumber = "154"};
        public static readonly Item FarplaneDew = new Item { Name = "Farplane Dew", ItemId = "290030400", Description = "異界の雫", EquipmentRarity = "4", CountId = "156", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290030400", BitNumber = "155"};
        public static readonly Item Spiritsand = new Item { Name = "Spiritsand", ItemId = "290040000", Description = "精霊の光粉", EquipmentRarity = "5", CountId = "157", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "290040000", BitNumber = "156"};
        public static readonly Item GodsReliquary = new Item { Name = "God's Reliquary", ItemId = "290040100", Description = "神々の遺物", EquipmentRarity = "5", CountId = "158", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "290040100", BitNumber = "157"};
        public static readonly Item DragonHeart = new Item { Name = "Dragon Heart", ItemId = "290040200", Description = "大竜の心臓", EquipmentRarity = "5", CountId = "159", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "290040200", BitNumber = "158"};
        public static readonly Item EspersTear = new Item { Name = "Esper's Tear", ItemId = "290040300", Description = "幻獣の涙", EquipmentRarity = "5", CountId = "160", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "290040300", BitNumber = "159"};
        public static readonly Item TalmoniteofLife = new Item { Name = "Talmonite of Life", ItemId = "290040400", Description = "生命の魔素", EquipmentRarity = "5", CountId = "161", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "290040400", BitNumber = "160"};
        public static readonly Item EsperShard = new Item { Name = "Esper Shard", ItemId = "290050100", Description = "幻結晶の欠片", EquipmentRarity = "1", CountId = "162", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "290050100", BitNumber = "161"};
        public static readonly Item EsperCryst = new Item { Name = "Esper Cryst", ItemId = "290050200", Description = "幻結晶", EquipmentRarity = "3", CountId = "163", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290050200", BitNumber = "162"};
        public static readonly Item SacredCrystal = new Item { Name = "Sacred Crystal", ItemId = "290050300", Description = "神結晶", EquipmentRarity = "4", CountId = "164", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290050300", BitNumber = "163"};
        public static readonly Item HolyCrystal = new Item { Name = "Holy Crystal", ItemId = "290050400", Description = "神魔結晶", EquipmentRarity = "6", CountId = "165", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "290050400", BitNumber = "164"};
        public static readonly Item YellowMagicite = new Item { Name = "Yellow Magicite", ItemId = "107002100", Description = "黄の魔石", EquipmentRarity = "3", CountId = "166", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "107002100", BitNumber = "166"};
        public static readonly Item OrangeMagicite = new Item { Name = "Orange Magicite", ItemId = "107002200", Description = "橙の魔石", EquipmentRarity = "3", CountId = "167", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "107002200", BitNumber = "167"};
        public static readonly Item VioletMagicite = new Item { Name = "Violet Magicite", ItemId = "107002300", Description = "紫の魔石", EquipmentRarity = "3", CountId = "168", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "107002300", BitNumber = "168"};
        public static readonly Item YellowMegacite = new Item { Name = "Yellow Megacite", ItemId = "107002400", Description = "黄の大魔石", EquipmentRarity = "5", CountId = "169", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "107002400", BitNumber = "169"};
        public static readonly Item OrangeMegacite = new Item { Name = "Orange Megacite", ItemId = "107002500", Description = "橙の大魔石", EquipmentRarity = "5", CountId = "170", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "107002500", BitNumber = "170"};
        public static readonly Item VioletMegacite = new Item { Name = "Violet Megacite", ItemId = "107002600", Description = "紫の大魔石", EquipmentRarity = "5", CountId = "171", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "107002600", BitNumber = "171"};
        public static readonly Item GalleanTins = new Item { Name = "Gallean Tins", ItemId = "108000100", Description = "ガレア錫貨", EquipmentRarity = "5", CountId = "172", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "108000100", BitNumber = "172"};
        public static readonly Item PlayMoney = new Item { Name = "Play Money", ItemId = "108000401", Description = "おもちゃの金貨", EquipmentRarity = "5", CountId = "173", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "108000401", BitNumber = "173"};
        public static readonly Item GaleKey_109202000 = new Item { Name = "Gale Key 1", ItemId = "109202000", Description = "疾風の鍵1", EquipmentRarity = "7", CountId = "176", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109202000", BitNumber = "176"};
        public static readonly Item GaleKey_109202010 = new Item { Name = "Gale Key 2", ItemId = "109202010", Description = "疾風の鍵2", EquipmentRarity = "7", CountId = "177", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109202010", BitNumber = "177"};
        public static readonly Item GaleKey_109202020 = new Item { Name = "Gale Key 3", ItemId = "109202020", Description = "疾風の鍵3", EquipmentRarity = "7", CountId = "178", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109202020", BitNumber = "178"};
        public static readonly Item GaleKey_109202030 = new Item { Name = "Gale Key 4", ItemId = "109202030", Description = "疾風の鍵4", EquipmentRarity = "7", CountId = "179", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109202030", BitNumber = "179"};
        public static readonly Item GaleKey_109202040 = new Item { Name = "Gale Key 5", ItemId = "109202040", Description = "疾風の鍵5", EquipmentRarity = "7", CountId = "180", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109202040", BitNumber = "180"};
        public static readonly Item GaleKey_109202050 = new Item { Name = "Gale Key 6", ItemId = "109202050", Description = "疾風の鍵6", EquipmentRarity = "7", CountId = "181", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109202050", BitNumber = "181"};
        public static readonly Item GaleKey_109202060 = new Item { Name = "Gale Key 7", ItemId = "109202060", Description = "疾風の鍵7", EquipmentRarity = "7", CountId = "182", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109202060", BitNumber = "182"};
        public static readonly Item GaleKey_109202070 = new Item { Name = "Gale Key 8", ItemId = "109202070", Description = "疾風の鍵8", EquipmentRarity = "7", CountId = "183", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109202070", BitNumber = "183"};
        public static readonly Item GaleKey_109202080 = new Item { Name = "Gale Key 9", ItemId = "109202080", Description = "疾風の鍵9", EquipmentRarity = "7", CountId = "184", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109202080", BitNumber = "184"};
        public static readonly Item GaleKey_109202090 = new Item { Name = "Gale Key 10", ItemId = "109202090", Description = "疾風の鍵10", EquipmentRarity = "7", CountId = "185", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109202090", BitNumber = "185"};
        public static readonly Item HardPebble = new Item { Name = "Hard Pebble", ItemId = "205000100", Description = "不砕の細石", EquipmentRarity = "3", CountId = "174", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "205000100", BitNumber = "174"};
        public static readonly Item PureStone = new Item { Name = "Pure Stone", ItemId = "205000200", Description = "至純の石", EquipmentRarity = "4", CountId = "175", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "205000200", BitNumber = "175"};
        public static readonly Item LazarethsNote = new Item { Name = "Lazareth's Note", ItemId = "291000100", Description = "ラザレスの書", EquipmentRarity = "4", CountId = "186", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "291000100", BitNumber = "186"};
        public static readonly Item IrissNote = new Item { Name = "Iris's Note", ItemId = "291000200", Description = "イリスの書", EquipmentRarity = "4", CountId = "187", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "291000200", BitNumber = "187"};
        public static readonly Item IvansNote = new Item { Name = "Ivan's Note", ItemId = "291000300", Description = "イヴァンの書", EquipmentRarity = "4", CountId = "188", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "291000300", BitNumber = "188"};
        public static readonly Item OlgasNote = new Item { Name = "Olga's Note", ItemId = "291000400", Description = "オルガの書", EquipmentRarity = "4", CountId = "189", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "291000400", BitNumber = "189"};
        public static readonly Item FinnithsNote = new Item { Name = "Finnith's Note", ItemId = "291000500", Description = "フィニスの書", EquipmentRarity = "4", CountId = "190", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "291000500", BitNumber = "190"};
        public static readonly Item DrakeHeart = new Item { Name = "Drake Heart", ItemId = "206000100", Description = "魔竜の心臓", EquipmentRarity = "4", CountId = "191", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "206000100", BitNumber = "191"};
        public static readonly Item DrakeOre = new Item { Name = "Drake Ore", ItemId = "206000200", Description = "竜輝鉱", EquipmentRarity = "4", CountId = "192", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "206000200", BitNumber = "192"};
        public static readonly Item DrakeSphere = new Item { Name = "Drake Sphere", ItemId = "206000300", Description = "竜玉", EquipmentRarity = "5", CountId = "193", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "206000300", BitNumber = "193"};
        public static readonly Item DrakeFang = new Item { Name = "Drake Fang", ItemId = "206000400", Description = "魔竜の牙", EquipmentRarity = "4", CountId = "194", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "206000400", BitNumber = "194"};
        public static readonly Item FarplaneMineral = new Item { Name = "Farplane Mineral", ItemId = "206000500", Description = "異界の鉱物", EquipmentRarity = "2", CountId = "195", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "206000500", BitNumber = "195"};
        public static readonly Item DeathStone = new Item { Name = "Death Stone", ItemId = "206000600", Description = "デスストーン", EquipmentRarity = "3", CountId = "196", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "206000600", BitNumber = "196"};
        public static readonly Item DemonHorn = new Item { Name = "Demon Horn", ItemId = "206000700", Description = "悪魔の角", EquipmentRarity = "2", CountId = "197", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "206000700", BitNumber = "197"};
        public static readonly Item DivineCrystal = new Item { Name = "Divine Crystal", ItemId = "290050500", Description = "神魔王結晶", EquipmentRarity = "7", CountId = "199", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "7000", ItemSellPrice = "700", ItemIdClone = "290050500", BitNumber = "199"};
        public static readonly Item FairiesWrit = new Item { Name = "Fairies' Writ", ItemId = "290060000", Description = "妖精王の密書", EquipmentRarity = "6", CountId = "200", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "290060000", BitNumber = "200"};
        public static readonly Item RainbowBloom = new Item { Name = "Rainbow Bloom", ItemId = "290060100", Description = "楽園の幻虹花", EquipmentRarity = "6", CountId = "201", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "290060100", BitNumber = "201"};
        public static readonly Item CalamityGem = new Item { Name = "Calamity Gem", ItemId = "290060200", Description = "災禍の封神珠", EquipmentRarity = "6", CountId = "202", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "290060200", BitNumber = "202"};
        public static readonly Item PrismaticHorn = new Item { Name = "Prismatic Horn", ItemId = "290060300", Description = "神獣の極彩角", EquipmentRarity = "6", CountId = "203", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "290060300", BitNumber = "203"};
        public static readonly Item CalamityWrit = new Item { Name = "Calamity Writ", ItemId = "290060400", Description = "終焉の予言書", EquipmentRarity = "6", CountId = "204", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "290060400", BitNumber = "204"};
        public static readonly Item AuraciteShard = new Item { Name = "Auracite Shard ", ItemId = "106300100", Description = "聖石の欠片", EquipmentRarity = "3", CountId = "205", IsPotUnit = "0", KeyName = "0", ItemStack = "999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106300100", BitNumber = "205"};
        public static readonly Item BugrossOre = new Item { Name = "Bugross Ore", ItemId = "207000100", Description = "バグロス鉱", EquipmentRarity = "5", CountId = "206", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "207000100", BitNumber = "206"};
        public static readonly Item UlricIron = new Item { Name = "Ulric Iron", ItemId = "207000200", Description = "デルタ鉄", EquipmentRarity = "4", CountId = "207", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "207000200", BitNumber = "207"};
        public static readonly Item CoreDust = new Item { Name = "Core Dust", ItemId = "207000300", Description = "地底の砂塵", EquipmentRarity = "4", CountId = "208", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "207000300", BitNumber = "208"};
        public static readonly Item AbyssPearl = new Item { Name = "Abyss Pearl", ItemId = "207000400", Description = "深淵の宝珠", EquipmentRarity = "4", CountId = "209", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "207000400", BitNumber = "209"};
        public static readonly Item PantherFang = new Item { Name = "Panther Fang", ItemId = "207000500", Description = "パンサーの牙", EquipmentRarity = "2", CountId = "210", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "207000500", BitNumber = "210"};
        public static readonly Item DemonWing = new Item { Name = "Demon Wing", ItemId = "207000600", Description = "悪魔の翼", EquipmentRarity = "2", CountId = "211", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "207000600", BitNumber = "211"};
        public static readonly Item AncientStone = new Item { Name = "Ancient Stone", ItemId = "207000700", Description = "古代神殿の石", EquipmentRarity = "3", CountId = "212", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "207000700", BitNumber = "212"};
        public static readonly Item TrochoidGear = new Item { Name = "Trochoid Gear", ItemId = "106300200", Description = "トロコイド歯車", EquipmentRarity = "3", CountId = "213", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106300200", BitNumber = "213"};
        public static readonly Item Uraninite = new Item { Name = "Uraninite", ItemId = "208000100", Description = "閃ウラン鉱", EquipmentRarity = "5", CountId = "214", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "208000100", BitNumber = "214"};
        public static readonly Item IridiumPlug = new Item { Name = "Iridium Plug", ItemId = "208000200", Description = "イリジウムプラグ", EquipmentRarity = "3", CountId = "215", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "208000200", BitNumber = "215"};
        public static readonly Item ParaffinOil = new Item { Name = "Paraffin Oil", ItemId = "208000300", Description = "パラフィンオイル", EquipmentRarity = "3", CountId = "216", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "208000300", BitNumber = "216"};
        public static readonly Item CrystalOscillator = new Item { Name = "Crystal Oscillator", ItemId = "208000400", Description = "水晶発振子", EquipmentRarity = "3", CountId = "217", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "208000400", BitNumber = "217"};
        public static readonly Item Perovskite = new Item { Name = "Perovskite", ItemId = "208000500", Description = "灰チタン石", EquipmentRarity = "4", CountId = "218", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "208000500", BitNumber = "218"};
        public static readonly Item EntrancingTail = new Item { Name = "Entrancing Tail", ItemId = "208000600", Description = "霊獣の鳳尾", EquipmentRarity = "2", CountId = "219", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "208000600", BitNumber = "219"};
        public static readonly Item MenacingWings = new Item { Name = "Menacing Wings", ItemId = "208000700", Description = "飛天の双翼", EquipmentRarity = "2", CountId = "220", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "208000700", BitNumber = "220"};
        public static readonly Item HardRock = new Item { Name = "Hard Rock", ItemId = "290030500", Description = "堅強な岩石", EquipmentRarity = "4", CountId = "221", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290030500", BitNumber = "221"};
        public static readonly Item FurySeed = new Item { Name = "Fury Seed", ItemId = "290030600", Description = "闘気の種", EquipmentRarity = "4", CountId = "222", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290030600", BitNumber = "222"};
        public static readonly Item WickedDrop = new Item { Name = "Wicked Drop", ItemId = "290030700", Description = "魔性の滴り", EquipmentRarity = "4", CountId = "223", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290030700", BitNumber = "223"};
        public static readonly Item BrilliantRay = new Item { Name = "Brilliant Ray", ItemId = "290030800", Description = "知性の光片", EquipmentRarity = "4", CountId = "224", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290030800", BitNumber = "224"};
        public static readonly Item LuckySeedling = new Item { Name = "Lucky Seedling", ItemId = "290030900", Description = "幸運の種子", EquipmentRarity = "4", CountId = "225", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290030900", BitNumber = "225"};
        public static readonly Item BizarreBox = new Item { Name = "Bizarre Box", ItemId = "290031000", Description = "奇想天外の箱", EquipmentRarity = "4", CountId = "226", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290031000", BitNumber = "226"};
        public static readonly Item MassiveStone = new Item { Name = "Massive Stone", ItemId = "1000000000", Description = "MassiveStone", EquipmentRarity = "4", CountId = "9000", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "1000000000", BitNumber = "9000"};
        public static readonly Item DemonHeart = new Item { Name = "Demon Heart", ItemId = "1000000001", Description = "DemonHeart", EquipmentRarity = "5", CountId = "9001", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "1000000001", BitNumber = "9001"};
        public static readonly Item VoidVessel = new Item { Name = "Void Vessel", ItemId = "1000000002", Description = "VoidVessel", EquipmentRarity = "5", CountId = "9002", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "1000000002", BitNumber = "9002"};
        public static readonly Item FineFlour = new Item { Name = "Fine Flour", ItemId = "1209000100", Description = "Flour", EquipmentRarity = "1", CountId = "9003", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "1209000100", BitNumber = "9003"};
        public static readonly Item LotusSeedPaste = new Item { Name = "Lotus Seed Paste", ItemId = "1209000200", Description = "Lotus Seed Paste", EquipmentRarity = "1", CountId = "9004", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "100", ItemSellPrice = "20", ItemIdClone = "1209000200", BitNumber = "9004"};
        public static readonly Item BrownEgg = new Item { Name = "Brown Egg", ItemId = "1209000300", Description = "Egg", EquipmentRarity = "1", CountId = "9005", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "100", ItemSellPrice = "20", ItemIdClone = "1209000300", BitNumber = "9005"};
        public static readonly Item CoarseRockSugar = new Item { Name = "Coarse Rock Sugar", ItemId = "1209000400", Description = "Rock Sugar", EquipmentRarity = "1", CountId = "9006", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "100", ItemSellPrice = "20", ItemIdClone = "1209000400", BitNumber = "9006"};
        public static readonly Item Mogcake = new Item { Name = "Mogcake", ItemId = "1106300100", Description = "Moogcake", EquipmentRarity = "2", CountId = "9010", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "100", ItemSellPrice = "50", ItemIdClone = "1106300100", BitNumber = "9010"};
        public static readonly Item StandardMogcakeBox = new Item { Name = "Standard Mogcake Box", ItemId = "1209000600", Description = "Standard Moogcake Pack", EquipmentRarity = "1", CountId = "9007", IsPotUnit = "5", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "100", ItemSellPrice = "100", ItemIdClone = "1209000600", BitNumber = "9007"};
        public static readonly Item RareMogcakeBox = new Item { Name = "Rare Mogcake Box", ItemId = "1209000700", Description = "Rare Moogcake Pack", EquipmentRarity = "1", CountId = "9008", IsPotUnit = "5", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "100", ItemSellPrice = "100", ItemIdClone = "1209000700", BitNumber = "9008"};
        public static readonly Item PremiumMogcakeBox = new Item { Name = "Premium Mogcake Box", ItemId = "1209000800", Description = "Premium Moogcake Pack", EquipmentRarity = "1", CountId = "9009", IsPotUnit = "5", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "100", ItemSellPrice = "100", ItemIdClone = "1209000800", BitNumber = "9009"};
        public static readonly Item Phantoma = new Item { Name = "Phantoma", ItemId = "106300300", Description = "ファントマ", EquipmentRarity = "3", CountId = "227", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106300300", BitNumber = "227"};
        public static readonly Item Candy = new Item { Name = "Candy", ItemId = "106300400", Description = "まんまるドロップ", EquipmentRarity = "3", CountId = "228", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106300400", BitNumber = "228"};
        public static readonly Item WhitePhantoma = new Item { Name = "White Phantoma", ItemId = "106300500", Description = "ホワイトファントマ", EquipmentRarity = "3", CountId = "229", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106300500", BitNumber = "229"};
        public static readonly Item ScrollofAcumen = new Item { Name = "Scroll of Acumen", ItemId = "1209000804", Description = "Scroll of Acumen", EquipmentRarity = "3", CountId = "9015", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "100", ItemIdClone = "1209000804", BitNumber = "9015"};
        public static readonly Item ScrollofVigor = new Item { Name = "Scroll of Vigor", ItemId = "1209000805", Description = "Scroll of Vigor", EquipmentRarity = "3", CountId = "9016", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "100", ItemIdClone = "1209000805", BitNumber = "9016"};
        public static readonly Item CavernOre = new Item { Name = "Cavern Ore", ItemId = "1209000806", Description = "Cavern Stone", EquipmentRarity = "3", CountId = "9011", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "1209000806", BitNumber = "9011"};
        public static readonly Item YPotion = new Item { Name = "Y-Potion", ItemId = "1000000003", Description = "Y-Potion", EquipmentRarity = "6", CountId = "9017", IsPotUnit = "1", KeyName = "6", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "300", ItemIdClone = "1000000003", BitNumber = "9017"};
        public static readonly Item MegaEther = new Item { Name = "Mega Ether", ItemId = "1000000004", Description = "Mega Ether", EquipmentRarity = "6", CountId = "9018", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "300", ItemIdClone = "1000000004", BitNumber = "9018"};
        public static readonly Item StainlessSteel = new Item { Name = "Stainless Steel", ItemId = "1209000801", Description = "Stainless Steel", EquipmentRarity = "3", CountId = "9012", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "888", ItemSellPrice = "88", ItemIdClone = "1209000801", BitNumber = "9012"};
        public static readonly Item BloodAlcryst = new Item { Name = "Blood Alcryst", ItemId = "1209000802", Description = "Blood Alcryst", EquipmentRarity = "3", CountId = "9013", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "1209000802", BitNumber = "9013"};
        public static readonly Item BloodStone = new Item { Name = "Blood Stone", ItemId = "1209000803", Description = "Blood Stone", EquipmentRarity = "3", CountId = "9014", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "1209000803", BitNumber = "9014"};
        public static readonly Item SurvivorsFlask = new Item { Name = "Survivor's Flask", ItemId = "1209000807", Description = "Divine Water", EquipmentRarity = "2", CountId = "9019", IsPotUnit = "2", KeyName = "2", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "101000100", BitNumber = "9019"};
        public static readonly Item CandyCorn = new Item { Name = "Candy Corn", ItemId = "1106300101", Description = "Candy Corn", EquipmentRarity = "2", CountId = "9020", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "100", ItemSellPrice = "50", ItemIdClone = "1106300101", BitNumber = "9020"};
        public static readonly Item Karma = new Item { Name = "Karma", ItemId = "106300900", Description = "カルマ", EquipmentRarity = "3", CountId = "265", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106300900", BitNumber = "265"};
        public static readonly Item MeteorFragment = new Item { Name = "Meteor Fragment"};
        public static readonly Item MeteorShards = new Item { Name = "Meteor Shards"};
        public static readonly Item MeteorStones = new Item { Name = "Meteor Stones"};
        public static readonly Item MeteorRock = new Item { Name = "Meteor Rock"};
        public static readonly Item MeteorOre = new Item { Name = "Meteor Ore"};
        public static readonly Item _101000400 = new Item { Name = "", ItemId = "101000400", Description = "やくそう", EquipmentRarity = "1", CountId = "243", IsPotUnit = "1", KeyName = "6", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "101000400", BitNumber = "243"};
        public static readonly Item _101000500 = new Item { Name = "", ItemId = "101000500", Description = "いやしそう", EquipmentRarity = "5", CountId = "244", IsPotUnit = "1", KeyName = "6", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "101000500", BitNumber = "244"};
        public static readonly Item _101000600 = new Item { Name = "", ItemId = "101000600", Description = "せかいじゅのしずく", EquipmentRarity = "6", CountId = "247", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "101000600", BitNumber = "247"};
        public static readonly Item _101001300 = new Item { Name = "", ItemId = "101001300", Description = "まほうのせいすい", EquipmentRarity = "3", CountId = "245", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "101001300", BitNumber = "245"};
        public static readonly Item _101001400 = new Item { Name = "", ItemId = "101001400", Description = "けんじゃのせいすい", EquipmentRarity = "5", CountId = "246", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "101001400", BitNumber = "246"};
        public static readonly Item _101003200 = new Item { Name = "", ItemId = "101003200", Description = "せかいじゅのは", EquipmentRarity = "4", CountId = "248", IsPotUnit = "1", KeyName = "6", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "101003200", BitNumber = "248"};
        public static readonly Item FlameringKey_109203000 = new Item { Name = "Flamering Key 1", ItemId = "109203000", Description = "火輪の鍵1", EquipmentRarity = "7", CountId = "231", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109203000", BitNumber = "231"};
        public static readonly Item FlameringKey_109203010 = new Item { Name = "Flamering Key 2", ItemId = "109203010", Description = "火輪の鍵2", EquipmentRarity = "7", CountId = "232", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109203010", BitNumber = "232"};
        public static readonly Item FlameringKey_109203020 = new Item { Name = "Flamering Key 3", ItemId = "109203020", Description = "火輪の鍵3", EquipmentRarity = "7", CountId = "233", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109203020", BitNumber = "233"};
        public static readonly Item FlameringKey_109203030 = new Item { Name = "Flamering Key 4", ItemId = "109203030", Description = "火輪の鍵4", EquipmentRarity = "7", CountId = "234", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109203030", BitNumber = "234"};
        public static readonly Item FlameringKey_109203040 = new Item { Name = "Flamering Key 5", ItemId = "109203040", Description = "火輪の鍵5", EquipmentRarity = "7", CountId = "235", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109203040", BitNumber = "235"};
        public static readonly Item FlameringKey_109203050 = new Item { Name = "Flamering Key 6", ItemId = "109203050", Description = "火輪の鍵6", EquipmentRarity = "7", CountId = "236", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109203050", BitNumber = "236"};
        public static readonly Item FlameringKey_109203060 = new Item { Name = "Flamering Key 7", ItemId = "109203060", Description = "火輪の鍵7", EquipmentRarity = "7", CountId = "237", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109203060", BitNumber = "237"};
        public static readonly Item FlameringKey_109203070 = new Item { Name = "Flamering Key 8", ItemId = "109203070", Description = "火輪の鍵8", EquipmentRarity = "7", CountId = "238", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109203070", BitNumber = "238"};
        public static readonly Item FlameringKey_109203080 = new Item { Name = "Flamering Key 9", ItemId = "109203080", Description = "火輪の鍵9", EquipmentRarity = "7", CountId = "239", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109203080", BitNumber = "239"};
        public static readonly Item FlameringKey_109203090 = new Item { Name = "Flamering Key 10", ItemId = "109203090", Description = "火輪の鍵10", EquipmentRarity = "7", CountId = "240", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109203090", BitNumber = "240"};
        public static readonly Item AuroraKey_109204000 = new Item { Name = "Aurora Key 1", ItemId = "109204000", Description = "極光の鍵1", EquipmentRarity = "7", CountId = "254", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109204000", BitNumber = "254"};
        public static readonly Item AuroraKey_109204010 = new Item { Name = "Aurora Key 2", ItemId = "109204010", Description = "極光の鍵2", EquipmentRarity = "7", CountId = "255", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109204010", BitNumber = "255"};
        public static readonly Item AuroraKey_109204020 = new Item { Name = "Aurora Key 3", ItemId = "109204020", Description = "極光の鍵3", EquipmentRarity = "7", CountId = "256", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109204020", BitNumber = "256"};
        public static readonly Item AuroraKey_109204030 = new Item { Name = "Aurora Key 4", ItemId = "109204030", Description = "極光の鍵4", EquipmentRarity = "7", CountId = "257", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109204030", BitNumber = "257"};
        public static readonly Item AuroraKey_109204040 = new Item { Name = "Aurora Key 5", ItemId = "109204040", Description = "極光の鍵5", EquipmentRarity = "7", CountId = "258", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109204040", BitNumber = "258"};
        public static readonly Item AuroraKey_109204050 = new Item { Name = "Aurora Key 6", ItemId = "109204050", Description = "極光の鍵6", EquipmentRarity = "7", CountId = "259", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109204050", BitNumber = "259"};
        public static readonly Item AuroraKey_109204060 = new Item { Name = "Aurora Key 7", ItemId = "109204060", Description = "極光の鍵7", EquipmentRarity = "7", CountId = "260", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109204060", BitNumber = "260"};
        public static readonly Item AuroraKey_109204070 = new Item { Name = "Aurora Key 8", ItemId = "109204070", Description = "極光の鍵8", EquipmentRarity = "7", CountId = "261", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109204070", BitNumber = "261"};
        public static readonly Item AuroraKey_109204080 = new Item { Name = "Aurora Key 9", ItemId = "109204080", Description = "極光の鍵9", EquipmentRarity = "7", CountId = "262", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109204080", BitNumber = "262"};
        public static readonly Item AuroraKey_109204090 = new Item { Name = "Aurora Key 10", ItemId = "109204090", Description = "極光の鍵10", EquipmentRarity = "7", CountId = "263", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109204090", BitNumber = "263"};
        public static readonly Item BlackKey_109205000 = new Item { Name = "Black Key 1", ItemId = "109205000", Description = "漆黒の鍵1", EquipmentRarity = "7", CountId = "338", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109205000", BitNumber = "338"};
        public static readonly Item BlackKey_109205010 = new Item { Name = "Black Key 2", ItemId = "109205010", Description = "漆黒の鍵2", EquipmentRarity = "7", CountId = "339", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109205010", BitNumber = "339"};
        public static readonly Item BlackKey_109205020 = new Item { Name = "Black Key 3", ItemId = "109205020", Description = "漆黒の鍵3", EquipmentRarity = "7", CountId = "340", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109205020", BitNumber = "340"};
        public static readonly Item BlackKey_109205030 = new Item { Name = "Black Key 4", ItemId = "109205030", Description = "漆黒の鍵4", EquipmentRarity = "7", CountId = "341", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109205030", BitNumber = "341"};
        public static readonly Item BlackKey_109205040 = new Item { Name = "Black Key 5", ItemId = "109205040", Description = "漆黒の鍵5", EquipmentRarity = "7", CountId = "342", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109205040", BitNumber = "342"};
        public static readonly Item BlackKey_109205050 = new Item { Name = "Black Key 6", ItemId = "109205050", Description = "漆黒の鍵6", EquipmentRarity = "7", CountId = "343", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109205050", BitNumber = "343"};
        public static readonly Item BlackKey_109205060 = new Item { Name = "Black Key 7", ItemId = "109205060", Description = "漆黒の鍵7", EquipmentRarity = "7", CountId = "344", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109205060", BitNumber = "344"};
        public static readonly Item BlackKey_109205070 = new Item { Name = "Black Key 8", ItemId = "109205070", Description = "漆黒の鍵8", EquipmentRarity = "7", CountId = "345", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109205070", BitNumber = "345"};
        public static readonly Item BlackKey_109205080 = new Item { Name = "Black Key 9", ItemId = "109205080", Description = "漆黒の鍵9", EquipmentRarity = "7", CountId = "346", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109205080", BitNumber = "346"};
        public static readonly Item BlackKey_109205090 = new Item { Name = "Black Key 10", ItemId = "109205090", Description = "漆黒の鍵10", EquipmentRarity = "7", CountId = "347", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109205090", BitNumber = "347"};
        public static readonly Item RedOrb = new Item { Name = "Red Orb", ItemId = "106300600", Description = "赤の宝玉", EquipmentRarity = "3", CountId = "230", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106300600", BitNumber = "230"};
        public static readonly Item RatTail = new Item { Name = "Rat Tail", ItemId = "106210100", Description = "ねずみのしっぽ", EquipmentRarity = "3", CountId = "241", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "106210100", BitNumber = "241"};
        public static readonly Item Gold = new Item { Name = "Gold", ItemId = "106300700", Description = "ゴールド", EquipmentRarity = "3", CountId = "242", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106300700", BitNumber = "242"};
        public static readonly Item GoldOre = new Item { Name = "Gold Ore", ItemId = "203000500", Description = "金鉱", EquipmentRarity = "5", CountId = "249", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "203000500", BitNumber = "249"};
        public static readonly Item BluePhantoma = new Item { Name = "Blue Phantoma", ItemId = "106300800", Description = "Blue Phantoma", EquipmentRarity = "3", CountId = "250", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106300800", BitNumber = "250"};
        public static readonly Item KoltzStar = new Item { Name = "Koltz Star", ItemId = "202002800", Description = "コルツの星", EquipmentRarity = "8", CountId = "251", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "202002800", BitNumber = "251"};
        public static readonly Item HopeDiamond = new Item { Name = "Hope Diamond", ItemId = "202002900", Description = "ホープダイヤ", EquipmentRarity = "8", CountId = "252", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "202002900", BitNumber = "252"};
        public static readonly Item FlamingBlood = new Item { Name = "Flaming Blood", ItemId = "202003000", Description = "フレイムブラッド", EquipmentRarity = "8", CountId = "253", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "202003000", BitNumber = "253"};
        public static readonly Item ImperialGrenade = new Item { Name = "Imperial Grenade", ItemId = "105005100", Description = "帝国式手榴弾", EquipmentRarity = "4", CountId = "264", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "105005100", BitNumber = "264"};
        public static readonly Item IfritRaidCoin = new Item { Name = "Ifrit Raid Coin", ItemId = "106301000", Description = "焔神イフリートレイドコイン", EquipmentRarity = "3", CountId = "266", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106301000", BitNumber = "266"};
        public static readonly Item HermitsTeachings = new Item { Name = "Hermit's Teachings", ItemId = "291100100", Description = "隠者の教え", EquipmentRarity = "5", CountId = "267", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "291100100", BitNumber = "267"};
        public static readonly Item StarMote = new Item { Name = "Star Mote", ItemId = "291100200", Description = "星の魔片", EquipmentRarity = "5", CountId = "268", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "291100200", BitNumber = "268"};
        public static readonly Item SwordsmanshipNotes = new Item { Name = "Swordsmanship Notes", ItemId = "291100300", Description = "剣士の戦術書", EquipmentRarity = "5", CountId = "269", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "291100300", BitNumber = "269"};
        public static readonly Item DesertMineral = new Item { Name = "Desert Mineral", ItemId = "209000100", Description = "砂漠の鉱石", EquipmentRarity = "1", CountId = "270", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "209000100", BitNumber = "270"};
        public static readonly Item OldJungleTree = new Item { Name = "Old Jungle Tree", ItemId = "209000200", Description = "密林の古木", EquipmentRarity = "2", CountId = "271", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "209000200", BitNumber = "271"};
        public static readonly Item MiraculousThread = new Item { Name = "Miraculous Thread", ItemId = "209000300", Description = "不思議な糸", EquipmentRarity = "3", CountId = "272", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "209000300", BitNumber = "272"};
        public static readonly Item HideoftheGuardian = new Item { Name = "Hide of the Guardian", ItemId = "209000400", Description = "守護獣の皮", EquipmentRarity = "4", CountId = "273", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "209000400", BitNumber = "273"};
        public static readonly Item SeedofIllusions = new Item { Name = "Seed of Illusions", ItemId = "209000500", Description = "幻想の種", EquipmentRarity = "5", CountId = "274", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "209000500", BitNumber = "274"};
        public static readonly Item AncientWritings = new Item { Name = "Ancient Writings", ItemId = "209000600", Description = "古代の書物", EquipmentRarity = "3", CountId = "275", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "209000600", BitNumber = "275"};
        public static readonly Item HighgradeArmorOil = new Item { Name = "High-grade Armor Oil", ItemId = "209000700", Description = "武具用高級油", EquipmentRarity = "4", CountId = "276", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "209000700", BitNumber = "276"};
        public static readonly Item MysteriousDrop = new Item { Name = "Mysterious Drop", ItemId = "209000800", Description = "神秘の雨滴", EquipmentRarity = "5", CountId = "277", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "209000800", BitNumber = "277"};
        public static readonly Item AlterBlade = new Item { Name = "Alter Blade", ItemId = "209000900", Description = "栄枯の刃", EquipmentRarity = "3", CountId = "278", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "209000900", BitNumber = "278"};
        public static readonly Item DreamBlossom = new Item { Name = "Dream Blossom", ItemId = "209001000", Description = "夢の花", EquipmentRarity = "4", CountId = "279", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "209001000", BitNumber = "279"};
        public static readonly Item QualityGoldDust = new Item { Name = "Quality Gold Dust", ItemId = "209001100", Description = "上質な砂金", EquipmentRarity = "5", CountId = "280", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "209001100", BitNumber = "280"};
        public static readonly Item Fish = new Item { Name = "Fish", ItemId = "106301100", Description = "魚", EquipmentRarity = "3", CountId = "281", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106301100", BitNumber = "281"};
        public static readonly Item WhiteAlcryst = new Item { Name = "White Alcryst", ItemId = "270000100", Description = "白の晶石", EquipmentRarity = "2", CountId = "282", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "270000100", BitNumber = "282"};
        public static readonly Item WhiteMilcryst = new Item { Name = "White Milcryst", ItemId = "270000200", Description = "白の中晶石", EquipmentRarity = "3", CountId = "283", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "270000200", BitNumber = "283"};
        public static readonly Item WhiteHeavicryst = new Item { Name = "White Heavicryst", ItemId = "270000300", Description = "白の大晶石", EquipmentRarity = "4", CountId = "284", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "270000300", BitNumber = "284"};
        public static readonly Item WhiteGiancryst = new Item { Name = "White Giancryst", ItemId = "270000400", Description = "白の超晶石", EquipmentRarity = "5", CountId = "285", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "270000400", BitNumber = "285"};
        public static readonly Item WhitePurecryst = new Item { Name = "White Purecryst", ItemId = "270000500", Description = "白の神晶石", EquipmentRarity = "6", CountId = "286", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "270000500", BitNumber = "286"};
        public static readonly Item BlackAlcryst = new Item { Name = "Black Alcryst", ItemId = "270000600", Description = "黒の晶石", EquipmentRarity = "2", CountId = "287", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "270000600", BitNumber = "287"};
        public static readonly Item BlackMilcryst = new Item { Name = "Black Milcryst", ItemId = "270000700", Description = "黒の中晶石", EquipmentRarity = "3", CountId = "288", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "270000700", BitNumber = "288"};
        public static readonly Item BlackHeavicryst = new Item { Name = "Black Heavicryst", ItemId = "270000800", Description = "黒の大晶石", EquipmentRarity = "4", CountId = "289", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "270000800", BitNumber = "289"};
        public static readonly Item BlackGiancryst = new Item { Name = "Black Giancryst", ItemId = "270000900", Description = "黒の超晶石", EquipmentRarity = "5", CountId = "290", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "270000900", BitNumber = "290"};
        public static readonly Item BlackPurecryst = new Item { Name = "Black Purecryst", ItemId = "270001000", Description = "黒の神晶石", EquipmentRarity = "6", CountId = "291", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "270001000", BitNumber = "291"};
        public static readonly Item GreenAlcryst = new Item { Name = "Green Alcryst", ItemId = "270001100", Description = "緑の晶石", EquipmentRarity = "2", CountId = "292", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "270001100", BitNumber = "292"};
        public static readonly Item GreenMilcryst = new Item { Name = "Green Milcryst", ItemId = "270001200", Description = "緑の中晶石", EquipmentRarity = "3", CountId = "293", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "270001200", BitNumber = "293"};
        public static readonly Item GreenHeavicryst = new Item { Name = "Green Heavicryst", ItemId = "270001300", Description = "緑の大晶石", EquipmentRarity = "4", CountId = "294", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "270001300", BitNumber = "294"};
        public static readonly Item GreenGiancryst = new Item { Name = "Green Giancryst", ItemId = "270001400", Description = "緑の超晶石", EquipmentRarity = "5", CountId = "295", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "270001400", BitNumber = "295"};
        public static readonly Item GreenPurecryst = new Item { Name = "Green Purecryst", ItemId = "270001500", Description = "緑の神晶石", EquipmentRarity = "6", CountId = "296", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "270001500", BitNumber = "296"};
        public static readonly Item PowerAlcryst = new Item { Name = "Power Alcryst", ItemId = "270002600", Description = "攻めの晶石", EquipmentRarity = "2", CountId = "307", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "270002600", BitNumber = "307"};
        public static readonly Item PowerMilcryst = new Item { Name = "Power Milcryst", ItemId = "270002700", Description = "攻めの中晶石", EquipmentRarity = "3", CountId = "308", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "270002700", BitNumber = "308"};
        public static readonly Item PowerHeavicryst = new Item { Name = "Power Heavicryst", ItemId = "270002800", Description = "攻めの大晶石", EquipmentRarity = "4", CountId = "309", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "270002800", BitNumber = "309"};
        public static readonly Item PowerGiancryst = new Item { Name = "Power Giancryst", ItemId = "270002900", Description = "攻めの超晶石", EquipmentRarity = "5", CountId = "310", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "270002900", BitNumber = "310"};
        public static readonly Item PowerPurecryst = new Item { Name = "Power Purecryst", ItemId = "270003000", Description = "攻めの神晶石", EquipmentRarity = "6", CountId = "311", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "270003000", BitNumber = "311"};
        public static readonly Item GuardAlcryst = new Item { Name = "Guard Alcryst", ItemId = "270003100", Description = "守りの晶石", EquipmentRarity = "2", CountId = "312", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "270003100", BitNumber = "312"};
        public static readonly Item GuardMilcryst = new Item { Name = "Guard Milcryst", ItemId = "270003200", Description = "守りの中晶石", EquipmentRarity = "3", CountId = "313", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "270003200", BitNumber = "313"};
        public static readonly Item GuardHeavicryst = new Item { Name = "Guard Heavicryst", ItemId = "270003300", Description = "守りの大晶石", EquipmentRarity = "4", CountId = "314", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "270003300", BitNumber = "314"};
        public static readonly Item GuardGiancryst = new Item { Name = "Guard Giancryst", ItemId = "270003400", Description = "守りの超晶石", EquipmentRarity = "5", CountId = "315", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "270003400", BitNumber = "315"};
        public static readonly Item GuardPurecryst = new Item { Name = "Guard Purecryst", ItemId = "270003500", Description = "守りの神晶石", EquipmentRarity = "6", CountId = "316", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "270003500", BitNumber = "316"};
        public static readonly Item HealingAlcryst = new Item { Name = "Healing Alcryst", ItemId = "270003600", Description = "癒しの晶石", EquipmentRarity = "2", CountId = "317", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "270003600", BitNumber = "317"};
        public static readonly Item HealingMilcryst = new Item { Name = "Healing Milcryst", ItemId = "270003700", Description = "癒しの中晶石", EquipmentRarity = "3", CountId = "318", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "270003700", BitNumber = "318"};
        public static readonly Item HealingHeavicryst = new Item { Name = "Healing Heavicryst", ItemId = "270003800", Description = "癒しの大晶石", EquipmentRarity = "4", CountId = "319", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "270003800", BitNumber = "319"};
        public static readonly Item HealingGiancryst = new Item { Name = "Healing Giancryst", ItemId = "270003900", Description = "癒しの超晶石", EquipmentRarity = "5", CountId = "320", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "270003900", BitNumber = "320"};
        public static readonly Item HealingPurecryst = new Item { Name = "Healing Purecryst", ItemId = "270004000", Description = "癒しの神晶石", EquipmentRarity = "6", CountId = "321", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "270004000", BitNumber = "321"};
        public static readonly Item SupportAlcryst = new Item { Name = "Support Alcryst", ItemId = "270004100", Description = "支援の晶石", EquipmentRarity = "2", CountId = "322", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "270004100", BitNumber = "322"};
        public static readonly Item SupportMilcryst = new Item { Name = "Support Milcryst", ItemId = "270004200", Description = "支援の中晶石", EquipmentRarity = "3", CountId = "323", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "270004200", BitNumber = "323"};
        public static readonly Item SupportHeavicryst = new Item { Name = "Support Heavicryst", ItemId = "270004300", Description = "支援の大晶石", EquipmentRarity = "4", CountId = "324", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "270004300", BitNumber = "324"};
        public static readonly Item SupportGiancryst = new Item { Name = "Support Giancryst", ItemId = "270004400", Description = "支援の超晶石", EquipmentRarity = "5", CountId = "325", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "270004400", BitNumber = "325"};
        public static readonly Item SupportPurecryst = new Item { Name = "Support Purecryst", ItemId = "270004500", Description = "支援の神晶石", EquipmentRarity = "6", CountId = "326", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "270004500", BitNumber = "326"};
        public static readonly Item TechAlcryst = new Item { Name = "Tech Alcryst", ItemId = "270004600", Description = "技巧の晶石", EquipmentRarity = "2", CountId = "327", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "270004600", BitNumber = "327"};
        public static readonly Item TechMilcryst = new Item { Name = "Tech Milcryst", ItemId = "270004700", Description = "技巧の中晶石", EquipmentRarity = "3", CountId = "328", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "270004700", BitNumber = "328"};
        public static readonly Item TechHeavicryst = new Item { Name = "Tech Heavicryst", ItemId = "270004800", Description = "技巧の大晶石", EquipmentRarity = "4", CountId = "329", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "270004800", BitNumber = "329"};
        public static readonly Item TechGiancryst = new Item { Name = "Tech Giancryst", ItemId = "270004900", Description = "技巧の超晶石", EquipmentRarity = "5", CountId = "330", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "270004900", BitNumber = "330"};
        public static readonly Item TechPurecryst = new Item { Name = "Tech Purecryst", ItemId = "270005000", Description = "技巧の神晶石", EquipmentRarity = "6", CountId = "331", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "270005000", BitNumber = "331"};
        public static readonly Item StrengthOrb = new Item { Name = "Strength Orb", ItemId = "210000100", Description = "力の珠", EquipmentRarity = "3", CountId = "332", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "210000100", BitNumber = "332"};
        public static readonly Item PetrifyGrenade = new Item { Name = "Petrify Grenade", ItemId = "210000200", Description = "石化手榴弾", EquipmentRarity = "3", CountId = "333", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "210000200", BitNumber = "333"};
        public static readonly Item SleepingPowder = new Item { Name = "Sleeping Powder", ItemId = "210000300", Description = "スリープパウダー", EquipmentRarity = "3", CountId = "334", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "210000300", BitNumber = "334"};
        public static readonly Item UnderdogsSecret = new Item { Name = "Underdog's Secret", ItemId = "210000400", Description = "逆転のカギ", EquipmentRarity = "4", CountId = "335", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "210000400", BitNumber = "335"};
        public static readonly Item BlueButterflyPowder = new Item { Name = "Blue Butterfly Powder", ItemId = "210000500", Description = "青い蝶の鱗粉", EquipmentRarity = "6", CountId = "336", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "210000500", BitNumber = "336"};
        public static readonly Item RedButterflyPowder = new Item { Name = "Red Butterfly Powder", ItemId = "210000600", Description = "赤い蝶の鱗粉", EquipmentRarity = "5", CountId = "337", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "210000600", BitNumber = "337"};
        public static readonly Item Mote = new Item { Name = "Mote", ItemId = "106301200", Description = "魔片", EquipmentRarity = "3", CountId = "348", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106301200", BitNumber = "348"};
        public static readonly Item MusicalNote = new Item { Name = "Musical Note", ItemId = "106301800", Description = "Musical Note", EquipmentRarity = "2", CountId = "9026", IsPotUnit = "0", KeyName = "0", ItemStack = "999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106301800", BitNumber = "9026"};
        public static readonly Item Perfume = new Item { Name = "Perfume", ItemId = "106301900", Description = "Perfume", EquipmentRarity = "3", CountId = "9027", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106301900", BitNumber = "9027"};
        public static readonly Item Lipstick = new Item { Name = "Lipstick", ItemId = "106302000", Description = "Lipstick", EquipmentRarity = "3", CountId = "9028", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106302000", BitNumber = "9028"};
        public static readonly Item NailPolish = new Item { Name = "Nail Polish", ItemId = "106302100", Description = "Nail Polish", EquipmentRarity = "3", CountId = "9029", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106302100", BitNumber = "9029"};
        public static readonly Item FacePowder = new Item { Name = "Face Powder", ItemId = "106302200", Description = "Face Powder", EquipmentRarity = "3", CountId = "9030", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106302200", BitNumber = "9030"};
        public static readonly Item HairSpray_106302300 = new Item { Name = "Hair Spray", ItemId = "106302300", Description = "Hair Spray", EquipmentRarity = "3", CountId = "9031", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106302300", BitNumber = "9031"};
        public static readonly Item Chocolate = new Item { Name = "Chocolate", ItemId = "101001900", Description = "チョコ Chocolate", EquipmentRarity = "3", CountId = "198", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "101001900", BitNumber = "198"};
        public static readonly Item FinasChocolate = new Item { Name = "Fina's Chocolate", ItemId = "101003300", Description = "フィーナのチョコレート", EquipmentRarity = "8", CountId = "413", IsPotUnit = "1", KeyName = "6", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "101003300", BitNumber = "413"};
        public static readonly Item ShadowLordCoin = new Item { Name = "Shadow Lord Coin", ItemId = "106301300", Description = "闇の王レイドコイン", EquipmentRarity = "3", CountId = "363", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106301300", BitNumber = "363"};
        public static readonly Item WhiteOrb = new Item { Name = "White Orb", ItemId = "106301400", Description = "白の宝玉", EquipmentRarity = "3", CountId = "364", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106301400", BitNumber = "364"};
        public static readonly Item KingMogCoin = new Item { Name = "King Mog Coin", ItemId = "106301500", Description = "モーグリ王レイドコイン", EquipmentRarity = "3", CountId = "365", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106301500", BitNumber = "365"};
        public static readonly Item WindFang = new Item { Name = "Wind Fang", ItemId = "106301600", Description = "風の牙", EquipmentRarity = "3", CountId = "372", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106301600", BitNumber = "372"};
        public static readonly Item collab_106301700 = new Item { Name = "collab", ItemId = "106301700", Description = "ネフ・ガルムドレイドコイン", EquipmentRarity = "3", CountId = "373", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106301700", BitNumber = "373"};
        public static readonly Item collab_106301710 = new Item { Name = "collab", ItemId = "106301710", Description = "ネフ・ガルムドの感応結晶", EquipmentRarity = "3", CountId = "374", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106301710", BitNumber = "374"};
        public static readonly Item MemoryCandy = new Item { Name = "Memory Candy", ItemId = "106302400", Description = "思い出の飴玉", EquipmentRarity = "3", CountId = "396", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106302400", BitNumber = "396"};
        public static readonly Item collab_106302500 = new Item { Name = "collab", ItemId = "106302500", Description = "四魔貴族レイドコイン", EquipmentRarity = "3", CountId = "405", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106302500", BitNumber = "405"};
        public static readonly Item Soldier = new Item { Name = "1/35 Soldier", ItemId = "106302700", Description = "1/35神羅兵", EquipmentRarity = "3", CountId = "412", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106302700", BitNumber = "412"};
        public static readonly Item BreathofLife = new Item { Name = "Breath of Life", ItemId = "211000100", Description = "生命の息吹", EquipmentRarity = "1", CountId = "349", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "211000100", BitNumber = "349"};
        public static readonly Item TwilightStone = new Item { Name = "Twilight Stone", ItemId = "211000200", Description = "黄昏の石", EquipmentRarity = "2", CountId = "350", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "211000200", BitNumber = "350"};
        public static readonly Item DuskJewel = new Item { Name = "Dusk Jewel", ItemId = "211000300", Description = "宵闇の宝珠", EquipmentRarity = "5", CountId = "351", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "211000300", BitNumber = "351"};
        public static readonly Item DarkOre = new Item { Name = "Dark Ore", ItemId = "211000400", Description = "黒闇鉱", EquipmentRarity = "5", CountId = "352", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "211000400", BitNumber = "352"};
        public static readonly Item TranquilStone = new Item { Name = "Tranquil Stone", ItemId = "211000500", Description = "安らぎの貴石", EquipmentRarity = "4", CountId = "353", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "211000500", BitNumber = "353"};
        public static readonly Item SilverChunk = new Item { Name = "Silver Chunk", ItemId = "211000600", Description = "銀の細片", EquipmentRarity = "4", CountId = "354", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "211000600", BitNumber = "354"};
        public static readonly Item BlessingNeedle = new Item { Name = "Blessing Needle", ItemId = "211000700", Description = "祝福の針", EquipmentRarity = "4", CountId = "355", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "211000700", BitNumber = "355"};
        public static readonly Item CursedSphere = new Item { Name = "Cursed Sphere", ItemId = "211000800", Description = "呪縛の玉", EquipmentRarity = "3", CountId = "356", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "211000800", BitNumber = "356"};
        public static readonly Item SacredBranch = new Item { Name = "Sacred Branch", ItemId = "211000900", Description = "神木の枝", EquipmentRarity = "3", CountId = "357", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "211000900", BitNumber = "357"};
        public static readonly Item GloryBug = new Item { Name = "Glory Bug", ItemId = "211001000", Description = "栄光の虫", EquipmentRarity = "3", CountId = "358", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "211001000", BitNumber = "358"};
        public static readonly Item AntiqueBone = new Item { Name = "Antique Bone", ItemId = "211001100", Description = "いにしえの骨", EquipmentRarity = "3", CountId = "359", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "211001100", BitNumber = "359"};
        public static readonly Item PinkScale = new Item { Name = "Pink Scale", ItemId = "211001200", Description = "桃色の鱗", EquipmentRarity = "4", CountId = "360", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "211001200", BitNumber = "360"};
        public static readonly Item DawnShell = new Item { Name = "Dawn Shell", ItemId = "211001300", Description = "暁虫の甲殻", EquipmentRarity = "3", CountId = "361", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "211001300", BitNumber = "361"};
        public static readonly Item AchromaticBlossom = new Item { Name = "Achromatic Blossom", ItemId = "211001400", Description = "無色の花", EquipmentRarity = "4", CountId = "362", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "211001400", BitNumber = "362"};
        public static readonly Item WhiteTail = new Item { Name = "White Tail", ItemId = "212000100", Description = "白尾", EquipmentRarity = "3", CountId = "366", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "212000100", BitNumber = "366"};
        public static readonly Item DewBlossom = new Item { Name = "Dew Blossom", ItemId = "212000200", Description = "白露の花", EquipmentRarity = "3", CountId = "367", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "212000200", BitNumber = "367"};
        public static readonly Item WhiteMetal = new Item { Name = "White Metal", ItemId = "212000300", Description = "ホワイトメタル", EquipmentRarity = "4", CountId = "368", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "212000300", BitNumber = "368"};
        public static readonly Item WhiteDrakesFeather = new Item { Name = "White Drake's Feather", ItemId = "212000400", Description = "白翼竜の羽根", EquipmentRarity = "4", CountId = "369", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "212000400", BitNumber = "369"};
        public static readonly Item WhiteTome = new Item { Name = "White Tome", ItemId = "212000500", Description = "白の魔道書", EquipmentRarity = "4", CountId = "370", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "212000500", BitNumber = "370"};
        public static readonly Item WhiteSlate = new Item { Name = "White Slate", ItemId = "212000600", Description = "白の石版", EquipmentRarity = "5", CountId = "371", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "212000600", BitNumber = "371"};
        public static readonly Item BlueBeastsShell = new Item { Name = "Blue Beast's Shell", ItemId = "213000100", Description = "青熊獣の甲殻", EquipmentRarity = "3", CountId = "375", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "213000100", BitNumber = "375"};
        public static readonly Item BlueBeastsBone = new Item { Name = "Blue Beast's Bone", ItemId = "213000200", Description = "青熊獣の骨", EquipmentRarity = "3", CountId = "376", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "213000200", BitNumber = "376"};
        public static readonly Item BlueBeastsClaw = new Item { Name = "Blue Beast's Claw", ItemId = "213000300", Description = "青熊獣の爪", EquipmentRarity = "3", CountId = "377", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "213000300", BitNumber = "377"};
        public static readonly Item BlueBeastPieceI = new Item { Name = "Blue Beast Piece I", ItemId = "213000400", Description = "青熊獣の部位証Ⅰ", EquipmentRarity = "3", CountId = "378", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "213000400", BitNumber = "378"};
        public static readonly Item SeaDrakesScale = new Item { Name = "Sea Drake's Scale", ItemId = "213000500", Description = "海竜の鱗", EquipmentRarity = "4", CountId = "379", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "213000500", BitNumber = "379"};
        public static readonly Item SeaDrakesBone = new Item { Name = "Sea Drake's Bone", ItemId = "213000600", Description = "海竜の骨", EquipmentRarity = "4", CountId = "380", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "213000600", BitNumber = "380"};
        public static readonly Item SeaDrakesClaw = new Item { Name = "Sea Drake's Claw", ItemId = "213000700", Description = "海竜の爪", EquipmentRarity = "4", CountId = "381", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "213000700", BitNumber = "381"};
        public static readonly Item SeaDrakePieceI = new Item { Name = "Sea Drake Piece I", ItemId = "213000800", Description = "海竜の部位証Ⅰ", EquipmentRarity = "4", CountId = "382", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "213000800", BitNumber = "382"};
        public static readonly Item RageDrakesSkin = new Item { Name = "Rage Drake's Skin", ItemId = "213000900", Description = "恐暴竜の皮", EquipmentRarity = "5", CountId = "383", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "213000900", BitNumber = "383"};
        public static readonly Item RageDrakesBone = new Item { Name = "Rage Drake's Bone", ItemId = "213001000", Description = "恐暴竜の骨", EquipmentRarity = "5", CountId = "384", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "213001000", BitNumber = "384"};
        public static readonly Item RageDrakesFang = new Item { Name = "Rage Drake's Fang", ItemId = "213001100", Description = "恐暴竜の牙", EquipmentRarity = "5", CountId = "385", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "213001100", BitNumber = "385"};
        public static readonly Item RageDrakePieceI = new Item { Name = "Rage Drake Piece I", ItemId = "213001200", Description = "恐暴竜の部位証Ⅰ", EquipmentRarity = "5", CountId = "386", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "213001200", BitNumber = "386"};
        public static readonly Item RedBeastsShell = new Item { Name = "Red Beast's Shell", ItemId = "213001300", Description = "赤甲獣の甲殻", EquipmentRarity = "3", CountId = "387", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "213001300", BitNumber = "387"};
        public static readonly Item RedBeastsBone = new Item { Name = "Red Beast's Bone", ItemId = "213001400", Description = "赤甲獣の骨", EquipmentRarity = "3", CountId = "388", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "213001400", BitNumber = "388"};
        public static readonly Item RedBeastsClaw = new Item { Name = "Red Beast's Claw", ItemId = "213001500", Description = "赤甲獣の爪", EquipmentRarity = "3", CountId = "389", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "213001500", BitNumber = "389"};
        public static readonly Item WolfDrakesBone = new Item { Name = "Wolf Drake's Bone", ItemId = "213001600", Description = "命狼竜の骨", EquipmentRarity = "5", CountId = "390", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "213001600", BitNumber = "390"};
        public static readonly Item WolfDrakesClaw = new Item { Name = "Wolf Drake's Claw", ItemId = "213001700", Description = "命狼竜の爪", EquipmentRarity = "5", CountId = "391", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "213001700", BitNumber = "391"};
        public static readonly Item WolfDrakesShell = new Item { Name = "Wolf Drake's Shell", ItemId = "213001800", Description = "命狼竜の甲殻", EquipmentRarity = "5", CountId = "392", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "213001800", BitNumber = "392"};
        public static readonly Item WhiteFeather = new Item { Name = "White Feather", ItemId = "213001900", Description = "白い羽根", EquipmentRarity = "2", CountId = "393", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "213001900", BitNumber = "393"};
        public static readonly Item RedFeather = new Item { Name = "Red Feather", ItemId = "213002000", Description = "赤い羽根", EquipmentRarity = "2", CountId = "394", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "213002000", BitNumber = "394"};
        public static readonly Item QualitySugar = new Item { Name = "Quality Sugar", ItemId = "214000100", Description = "上質な砂糖", EquipmentRarity = "3", CountId = "397", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "214000100", BitNumber = "397"};
        public static readonly Item DeliciousWater = new Item { Name = "Delicious Water", ItemId = "214000200", Description = "おいしい水", EquipmentRarity = "3", CountId = "398", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "214000200", BitNumber = "398"};
        public static readonly Item CrimsonWing_215000100 = new Item { Name = "Crimson Wing", ItemId = "215000100", Description = "紅魔の翼", EquipmentRarity = "3", CountId = "399", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "215000100", BitNumber = "399"};
        public static readonly Item AshScale = new Item { Name = "Ash Scale", ItemId = "215000200", Description = "薄灰の鱗", EquipmentRarity = "3", CountId = "400", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "215000200", BitNumber = "400"};
        public static readonly Item MysteriousMineral = new Item { Name = "Mysterious Mineral", ItemId = "215000300", Description = "神秘の鉱石", EquipmentRarity = "4", CountId = "401", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "215000300", BitNumber = "401"};
        public static readonly Item AncientMedicine = new Item { Name = "Ancient Medicine", ItemId = "215000400", Description = "太古の秘薬", EquipmentRarity = "4", CountId = "402", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "215000400", BitNumber = "402"};
        public static readonly Item BlessedStone = new Item { Name = "Blessed Stone", ItemId = "215000500", Description = "恵みの石", EquipmentRarity = "4", CountId = "403", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "215000500", BitNumber = "403"};
        public static readonly Item RuinGem = new Item { Name = "Ruin Gem", ItemId = "215000600", Description = "亡国の宝石", EquipmentRarity = "5", CountId = "404", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "215000600", BitNumber = "404"};
        public static readonly Item HairSpray_106302600 = new Item { Name = "Hair Spray", ItemId = "106302600", Description = "ヘアスプレー", EquipmentRarity = "3", CountId = "411", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106302600", BitNumber = "411"};
        public static readonly Item RedEgg = new Item { Name = "Red Egg", ItemId = "1209000812", Description = "Red Egg", EquipmentRarity = "1", CountId = "9036", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000812", BitNumber = "9036"};
        public static readonly Item BlueEgg = new Item { Name = "Blue Egg", ItemId = "1209000813", Description = "Blue Egg", EquipmentRarity = "1", CountId = "9037", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000813", BitNumber = "9037"};
        public static readonly Item RainbowEgg = new Item { Name = "Rainbow Egg", ItemId = "1209000814", Description = "Rainbow Egg", EquipmentRarity = "3", CountId = "9038", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000814", BitNumber = "9038"};
        public static readonly Item MetalEgg = new Item { Name = "Metal Egg", ItemId = "1209000815", Description = "Metal Egg", EquipmentRarity = "3", CountId = "9039", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000815", BitNumber = "9039"};
        public static readonly Item CrystalEggofPower = new Item { Name = "Crystal Egg of Power", ItemId = "1209000816", Description = "Cystal Egg of Power", EquipmentRarity = "3", CountId = "9040", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000816", BitNumber = "9040"};
        public static readonly Item CrystalEggofMind = new Item { Name = "Crystal Egg of Mind", ItemId = "1209000817", Description = "Cystal Egg of Mind", EquipmentRarity = "3", CountId = "9041", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000817", BitNumber = "9041"};
        public static readonly Item ShadowBahamutGem = new Item { Name = "Shadow Bahamut Gem", ItemId = "1209000818", Description = "Shadow Bahamut Gem", EquipmentRarity = "3", CountId = "9042", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000818", BitNumber = "9042"};
        public static readonly Item ShadowBahamutScale = new Item { Name = "Shadow Bahamut Scale", ItemId = "1209000819", Description = "Scale of shadow bahamut", EquipmentRarity = "3", CountId = "9043", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000819", BitNumber = "9043"};
        public static readonly Item ShadowBahamutJade = new Item { Name = "Shadow Bahamut Jade", ItemId = "1209000820", Description = "Jade of shadow bahamut", EquipmentRarity = "3", CountId = "9044", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000820", BitNumber = "9044"};
        public static readonly Item ShadowBahamutWing = new Item { Name = "Shadow Bahamut Wing", ItemId = "1209000821", Description = "Wings of shadow bahamut", EquipmentRarity = "3", CountId = "9045", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000821", BitNumber = "9045"};
        public static readonly Item ShadowBahamutHeart = new Item { Name = "Shadow Bahamut Heart", ItemId = "1209000822", Description = "Heart of shadow bahamut", EquipmentRarity = "3", CountId = "9046", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000822", BitNumber = "9046"};
        public static readonly Item ShadowBahamutsOre = new Item { Name = "Shadow Bahamuts Ore", ItemId = "1209000823", Description = "Shadow bahamut’s ore", EquipmentRarity = "3", CountId = "9047", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000823", BitNumber = "9047"};
        public static readonly Item ShadowBahamutFang = new Item { Name = "Shadow Bahamut Fang", ItemId = "1209000824", Description = "Fang of shadow bahamut", EquipmentRarity = "3", CountId = "9048", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000824", BitNumber = "9048"};
        public static readonly Item BahamutRaidCoin = new Item { Name = "Bahamut Raid Coin", ItemId = "1209000825", Description = "Bahamut Raid Coin", EquipmentRarity = "3", CountId = "9049", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000825", BitNumber = "9049"};
        public static readonly Item ShardofKelsus = new Item { Name = "Shard of Kelsus", ItemId = "1209000826", Description = "Shard of Kelsus", EquipmentRarity = "6", CountId = "9050", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000826", BitNumber = "9050"};
        public static readonly Item SealedBox = new Item { Name = "Sealed Box", ItemId = "216000700", Description = "封魔の匣", EquipmentRarity = "3", CountId = "423", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "216000700", BitNumber = "423"};
        public static readonly Item CrimsonWing_216000800 = new Item { Name = "Crimson Wing", ItemId = "216000800", Description = "紅玉虫の翅", EquipmentRarity = "4", CountId = "424", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "216000800", BitNumber = "424"};
        public static readonly Item AzureCorundum = new Item { Name = "Azure Corundum", ItemId = "216000900", Description = "碧空の鋼玉", EquipmentRarity = "5", CountId = "425", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "216000900", BitNumber = "425"};
        public static readonly Item MiasmaChunk = new Item { Name = "Miasma Chunk", ItemId = "216001000", Description = "瘴気の塊体", EquipmentRarity = "3", CountId = "426", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "216001000", BitNumber = "426"};
        public static readonly Item AetherochemicalFiber = new Item { Name = "Aetherochemical Fiber", ItemId = "216001100", Description = "魔科学繊維", EquipmentRarity = "4", CountId = "427", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "216001100", BitNumber = "427"};
        public static readonly Item CorruptWeed = new Item { Name = "Corrupt Weed", ItemId = "216001200", Description = "退廃の夜草", EquipmentRarity = "5", CountId = "428", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "216001200", BitNumber = "428"};
        public static readonly Item TitanCoin = new Item { Name = "Titan Coin", ItemId = "106303000", Description = "岩神タイタンレイドコイン", EquipmentRarity = "3", CountId = "422", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106303000", BitNumber = "422"};
        public static readonly Item Relic = new Item { Name = "Relic", ItemId = "1209000808", Description = "Gold Relic", EquipmentRarity = "1", CountId = "9032", IsPotUnit = "5", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000808", BitNumber = "9032"};
        public static readonly Item RandomMagicite = new Item { Name = "Random Magicite", ItemId = "1209000809", Description = "Random Magicite", EquipmentRarity = "1", CountId = "9033", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000809", BitNumber = "9033"};
        public static readonly Item RandomMegacryst = new Item { Name = "Random Megacryst", ItemId = "1209000810", Description = "Random Material", EquipmentRarity = "1", CountId = "9034", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000810", BitNumber = "9034"};
        public static readonly Item RandomAwakeningMaterial = new Item { Name = "Random Awakening Material", ItemId = "1209000811", Description = "Random Awakening Material", EquipmentRarity = "1", CountId = "9035", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000811", BitNumber = "9035"};
        public static readonly Item MinorScrollofHealing = new Item { Name = "Minor Scroll of Healing", ItemId = "1000000005", Description = "Minor Scroll of Healing", EquipmentRarity = "4", CountId = "9052", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "6000", ItemSellPrice = "450", ItemIdClone = "1000000005", BitNumber = "9052"};
        public static readonly Item GreaterScrollofHealing = new Item { Name = "Greater Scroll of Healing", ItemId = "1000000006", Description = "Greater Scroll of Healing", EquipmentRarity = "5", CountId = "9053", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "600", ItemIdClone = "1000000006", BitNumber = "9053"};
        public static readonly Item MinorScrollofRecovery = new Item { Name = "Minor Scroll of Recovery", ItemId = "1000000007", Description = "Minor Scroll of Recovery", EquipmentRarity = "4", CountId = "9054", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "6000", ItemSellPrice = "450", ItemIdClone = "1000000007", BitNumber = "9054"};
        public static readonly Item GreaterScrollofRecovery = new Item { Name = "Greater Scroll of Recovery", ItemId = "1000000008", Description = "Greater Scroll of Recovery", EquipmentRarity = "5", CountId = "9055", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "600", ItemIdClone = "1000000008", BitNumber = "9055"};
        public static readonly Item ProtagonistHalo = new Item { Name = "Protagonist Halo", ItemId = "1000000009", Description = "Protagonist Halo", EquipmentRarity = "4", CountId = "9056", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "6000", ItemSellPrice = "450", ItemIdClone = "1000000009", BitNumber = "9056"};
        public static readonly Item PotionofDeception = new Item { Name = "Potion of Deception", ItemId = "1000000010", Description = "Potion of Deception", EquipmentRarity = "3", CountId = "9057", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "300", ItemIdClone = "1000000010", BitNumber = "9057"};
        public static readonly Item PotionofCleansing = new Item { Name = "Potion of Cleansing", ItemId = "1000000011", Description = "Potion of Cleansing", EquipmentRarity = "5", CountId = "9058", IsPotUnit = "2", KeyName = "2", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "600", ItemIdClone = "1000000011", BitNumber = "9058"};
        public static readonly Item PotionofElementalResistance = new Item { Name = "Potion of Elemental Resistance", ItemId = "1000000012", Description = "Potion of Elemental Resistance", EquipmentRarity = "3", CountId = "9059", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "300", ItemIdClone = "1000000012", BitNumber = "9059"};
        public static readonly Item MinorPotionofRejuvenation = new Item { Name = "Minor Potion of Rejuvenation", ItemId = "1000000013", Description = "Minor Potion of Rejuvenation", EquipmentRarity = "2", CountId = "9060", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "150", ItemIdClone = "1000000013", BitNumber = "9060"};
        public static readonly Item PotionofRejuvenation = new Item { Name = "Potion of Rejuvenation", ItemId = "1000000014", Description = "Potion of Rejuvenation", EquipmentRarity = "3", CountId = "9061", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "300", ItemIdClone = "1000000014", BitNumber = "9061"};
        public static readonly Item GreaterPotionofRejuvenation = new Item { Name = "Greater Potion of Rejuvenation", ItemId = "1000000015", Description = "Greater Potion of Rejuvenation", EquipmentRarity = "4", CountId = "9062", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "6000", ItemSellPrice = "450", ItemIdClone = "1000000015", BitNumber = "9062"};
        public static readonly Item RandomConsumable = new Item { Name = "Random Consumable", ItemId = "1209000827", Description = "Random Consumable", EquipmentRarity = "1", CountId = "9063", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000827", BitNumber = "9063"};
        public static readonly Item RandomMegacite = new Item { Name = "Random Megacite", ItemId = "1209000828", Description = "Random Megacite", EquipmentRarity = "1", CountId = "9064", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000828", BitNumber = "9064"};
        public static readonly Item RandomMilcryst = new Item { Name = "Random Milcryst", ItemId = "1209000829", Description = "Random Milcryst", EquipmentRarity = "1", CountId = "9065", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000829", BitNumber = "9065"};
        public static readonly Item RandomHeavicryst = new Item { Name = "Random Heavicryst", ItemId = "1209000830", Description = "Random Heavicryst", EquipmentRarity = "1", CountId = "9066", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000830", BitNumber = "9066"};
        public static readonly Item RandomGiancryst = new Item { Name = "Random Giancryst", ItemId = "1209000831", Description = "Random Giancryst", EquipmentRarity = "1", CountId = "9067", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000831", BitNumber = "9067"};
        public static readonly Item CrimsonOre = new Item { Name = "Crimson Ore", ItemId = "1106300102", Description = "Crimson Ore", EquipmentRarity = "3", CountId = "9051", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "1106300102", BitNumber = "9051"};
        public static readonly Item MetalGigantuarCoin_1209000832 = new Item { Name = "Metal Gigantuar Coin", ItemId = "1209000832", Description = "Metal Gigantuar Coin", EquipmentRarity = "8", CountId = "9068", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10000", ItemSellPrice = "100", ItemIdClone = "1209000832", BitNumber = "9068"};
        public static readonly Item SummonTicket = new Item { Name = "10+1 Summon Ticket", ItemId = "1300000005", Description = "10+1 Summon Ticket", EquipmentRarity = "8", CountId = "9069", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1300000005", BitNumber = "9069"};
        public static readonly Item ThankYouCandy = new Item { Name = "Thank You Candy", ItemId = "101003400", Description = "お返しのキャンディ", EquipmentRarity = "8", CountId = "429", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "101003400", BitNumber = "429"};
        public static readonly Item ContestRaidCoin = new Item { Name = "Contest Raid Coin", ItemId = "106302800", Description = "コンテストレイドコイン", EquipmentRarity = "3", CountId = "414", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106302800", BitNumber = "414"};
        public static readonly Item DebasedCoin = new Item { Name = "Debased Coin", ItemId = "106302900", Description = "ふるい小銭", EquipmentRarity = "3", CountId = "421", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106302900", BitNumber = "421"};
        public static readonly Item PlayTicket = new Item { Name = "Play Ticket", ItemId = "106303100", Description = "おしばいのチケット", EquipmentRarity = "3", CountId = "430", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106303100", BitNumber = "430"};
        public static readonly Item EngelsRaidCoin = new Item { Name = "Engels Raid Coin", ItemId = "106303200", Description = "エンゲルスレイドコイン", EquipmentRarity = "3", CountId = "437", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106303200", BitNumber = "437"};
        public static readonly Item AlBhedPrimer = new Item { Name = "Al Bhed Primer", ItemId = "106303300", Description = "アルベド語辞書", EquipmentRarity = "3", CountId = "438", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106303300", BitNumber = "438"};
        public static readonly Item TwilightFeather = new Item { Name = "Twilight Feather", ItemId = "216000100", Description = "黄昏色の羽根", EquipmentRarity = "3", CountId = "415", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "216000100", BitNumber = "415"};
        public static readonly Item PureThread = new Item { Name = "Pure Thread", ItemId = "216000200", Description = "純白の柔糸", EquipmentRarity = "3", CountId = "416", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "216000200", BitNumber = "416"};
        public static readonly Item WornBlueprint = new Item { Name = "Worn Blueprint", ItemId = "216000300", Description = "破れた設計図", EquipmentRarity = "4", CountId = "417", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "216000300", BitNumber = "417"};
        public static readonly Item SteelBone = new Item { Name = "Steel Bone", ItemId = "216000400", Description = "鋼鉄の骨", EquipmentRarity = "4", CountId = "418", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "216000400", BitNumber = "418"};
        public static readonly Item BlackOil = new Item { Name = "Black Oil", ItemId = "216000500", Description = "黒燃液", EquipmentRarity = "4", CountId = "419", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "216000500", BitNumber = "419"};
        public static readonly Item MagicParts = new Item { Name = "Magic Parts", ItemId = "216000600", Description = "魔導パーツ", EquipmentRarity = "5", CountId = "420", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "216000600", BitNumber = "420"};
        public static readonly Item BrokenCircuit = new Item { Name = "Broken Circuit", ItemId = "217000100", Description = "壊れた回路", EquipmentRarity = "3", CountId = "431", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "217000100", BitNumber = "431"};
        public static readonly Item RustedLump = new Item { Name = "Rusted Lump", ItemId = "217000200", Description = "錆びた塊", EquipmentRarity = "3", CountId = "432", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "217000200", BitNumber = "432"};
        public static readonly Item TitaniumAlloy = new Item { Name = "Titanium Alloy", ItemId = "217000300", Description = "チタン合金", EquipmentRarity = "4", CountId = "433", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "217000300", BitNumber = "433"};
        public static readonly Item BlackPearl = new Item { Name = "Black Pearl", ItemId = "217000400", Description = "黒真珠", EquipmentRarity = "4", CountId = "434", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "217000400", BitNumber = "434"};
        public static readonly Item MeteorLight = new Item { Name = "Meteor Light", ItemId = "217000500", Description = "メテオライト", EquipmentRarity = "4", CountId = "435", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "217000500", BitNumber = "435"};
        public static readonly Item BlackBox = new Item { Name = "Black Box", ItemId = "217000600", Description = "ブラックボックス", EquipmentRarity = "5", CountId = "436", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "217000600", BitNumber = "436"};
        public static readonly Item Hairpin = new Item { Name = "Hairpin", ItemId = "1209000833", Description = "髪飾りFF15KG", EquipmentRarity = "3", CountId = "9070", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "1209000833", BitNumber = "395"};
        public static readonly Item MagmaRockFragments = new Item { Name = "Magma Rock Fragments"};
        public static readonly Item MusicalGem = new Item { Name = "Musical Gem", ItemId = "1209000835", Description = "Musical Gem", EquipmentRarity = "3", CountId = "9071", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "1209000835", BitNumber = "9070"};
        public static readonly Item MetalGigantuarCoin_1209000837 = new Item { Name = "Metal Gigantuar Coin", ItemId = "1209000837", Description = "Metal Gigantuar Coin(TW)", EquipmentRarity = "8", CountId = "9073", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10000", ItemSellPrice = "100", ItemIdClone = "1209000832", BitNumber = "9072"};
        public static readonly Item Lantern = new Item { Name = "Lantern", ItemId = "1209000836", Description = "Lantern", EquipmentRarity = "3", CountId = "9072", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "1100000095", BitNumber = "9071"};
        public static readonly Item MetalGigantuarCoin_1209000839 = new Item { Name = "Metal Gigantuar Coin", ItemId = "1209000839", Description = "Metal Gigantuar Coin(New York)", EquipmentRarity = "8", CountId = "9074", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10000", ItemSellPrice = "0", ItemIdClone = "1209000832", BitNumber = "9074"};
        public static readonly Item SkeletonKey = new Item { Name = "Skeleton Key", ItemId = "1209000838", Description = "Skeleton Key", EquipmentRarity = "8", CountId = "9075", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10000", ItemSellPrice = "100", ItemIdClone = "1209000838", BitNumber = "9075"};

		public static readonly List<Item> Items = new List<Item>
		{
           Potion,
           HiPotion,
           XPotion,
           Ether,
           TurboEther,
           Elixir,
           PhoenixDown,
           Antidote,
           EyeDrops,
           SmellingSalts,
           EchoHerbs,
           UnicornHorn,
           Vaccine,
           GoldNeedle,
           Remedy,
           Hyper,
           LightCurtain,
           LunarCurtain,
           HealingSpring,
           SmokeBomb,
           BodyBoost,
           ManaBoost,
           ProtectDrink,
           ShellDrink,
           BacchussWine,
           HeroDrink,
           GiantsDrink,
           BombFragment,
           BombArm,
           AntarcticWind,
           ArcticWind,
           ZeussWrath,
           HeavenlyWrath,
           FishScale,
           DragonScale_104003200,
           GiantFeather,
           WyvernFeather,
           EarthDrum,
           GaiasCry,
           RedFang,
           WhiteFang,
           BlueFang,
           HolyTorch,
           Grenade,
           FragGrenade,
           Shuriken,
           FumaShuriken,
           Pinwheel,
           Tent,
           MagicKey,
           StarQuartz,
           MagiciteShard,
           Magicite,
           RedMagicite,
           BlueMagicite,
           GreenMagicite,
           WhiteMagicite,
           BlackMagicite,
           RedMegacite,
           BlueMegacite,
           GreenMegacite,
           WhiteMegacite,
           BlackMegacite,
           EarthKey_109201000,
           EarthKey_109201010,
           EarthKey_109201020,
           EarthKey_109201030,
           EarthKey_109201040,
           EarthKey_109201050,
           EarthKey_109201060,
           EarthKey_109201070,
           EarthKey_109201080,
           EarthKey_109201090,
           EarthKey_109201100,
           EarthKey_109201110,
           EarthKey_109201120,
           EarthKey_109201130,
           EarthKey_109201140,
           EarthKey_109201150,
           EarthKey_109201160,
           EarthKey_109201170,
           EarthKey_109201180,
           EarthKey_109201190,
           EarthKey_109201200,
           EarthKey_109201210,
           EarthKey_109201220,
           EarthKey_109201230,
           EarthKey_109201240,
           FireCryst,
           IceCryst,
           LightningCryst,
           WaterCryst,
           EarthCryst,
           WindCryst,
           LightCryst,
           DarkCryst,
           FireMegacryst,
           IceMegacryst,
           LightningMegacryst,
           WaterMegacryst,
           EarthMegacryst,
           WindMegacryst,
           LightMegacryst,
           DarkMegacryst,
           LifeOrb,
           FarplaneSoul,
           GaiasTear,
           ThickenedHide,
           RaptorFeather,
           ChromaticOoze,
           DemonTail,
           BrokenBlade,
           DigitalCircuit,
           DragonFang,
           Glowseeds,
           Spellsilk,
           QualityStone,
           GummyOil,
           GreenFluid,
           OtherworldlyBone,
           AbominableWing,
           ToughScale,
           CursedTusk,
           WizardStone,
           PolymerEmulsion,
           DragonScale_202002200,
           ElementalTear,
           RockbeetleHusk,
           SparklingStone,
           Screamroot,
           CorpseFly,
           CopperOre,
           IronOre,
           SilverOre,
           MythrilOre,
           Lumber,
           Alcryst,
           FineAlcryst,
           BeastMeat,
           PearlofWisdom,
           AllurePowder,
           Litrock,
           SeedofLife,
           CrimsonTear,
           MysticOre,
           AquaPearl,
           LuminousHorn,
           QualityParts,
           RainbowNeedle,
           GoldenEgg,
           BookofRuin,
           EarthsCore,
           HeavensAsh,
           DeepseaBloom,
           ScriptureofTime,
           FarplaneDew,
           Spiritsand,
           GodsReliquary,
           DragonHeart,
           EspersTear,
           TalmoniteofLife,
           EsperShard,
           EsperCryst,
           SacredCrystal,
           HolyCrystal,
           YellowMagicite,
           OrangeMagicite,
           VioletMagicite,
           YellowMegacite,
           OrangeMegacite,
           VioletMegacite,
           GalleanTins,
           PlayMoney,
           GaleKey_109202000,
           GaleKey_109202010,
           GaleKey_109202020,
           GaleKey_109202030,
           GaleKey_109202040,
           GaleKey_109202050,
           GaleKey_109202060,
           GaleKey_109202070,
           GaleKey_109202080,
           GaleKey_109202090,
           HardPebble,
           PureStone,
           LazarethsNote,
           IrissNote,
           IvansNote,
           OlgasNote,
           FinnithsNote,
           DrakeHeart,
           DrakeOre,
           DrakeSphere,
           DrakeFang,
           FarplaneMineral,
           DeathStone,
           DemonHorn,
           DivineCrystal,
           FairiesWrit,
           RainbowBloom,
           CalamityGem,
           PrismaticHorn,
           CalamityWrit,
           AuraciteShard,
           BugrossOre,
           UlricIron,
           CoreDust,
           AbyssPearl,
           PantherFang,
           DemonWing,
           AncientStone,
           TrochoidGear,
           Uraninite,
           IridiumPlug,
           ParaffinOil,
           CrystalOscillator,
           Perovskite,
           EntrancingTail,
           MenacingWings,
           HardRock,
           FurySeed,
           WickedDrop,
           BrilliantRay,
           LuckySeedling,
           BizarreBox,
           MassiveStone,
           DemonHeart,
           VoidVessel,
           FineFlour,
           LotusSeedPaste,
           BrownEgg,
           CoarseRockSugar,
           Mogcake,
           StandardMogcakeBox,
           RareMogcakeBox,
           PremiumMogcakeBox,
           Phantoma,
           Candy,
           WhitePhantoma,
           ScrollofAcumen,
           ScrollofVigor,
           CavernOre,
           YPotion,
           MegaEther,
           StainlessSteel,
           BloodAlcryst,
           BloodStone,
           SurvivorsFlask,
           CandyCorn,
           Karma,
           MeteorFragment,
           MeteorShards,
           MeteorStones,
           MeteorRock,
           MeteorOre,
           _101000400,
           _101000500,
           _101000600,
           _101001300,
           _101001400,
           _101003200,
           FlameringKey_109203000,
           FlameringKey_109203010,
           FlameringKey_109203020,
           FlameringKey_109203030,
           FlameringKey_109203040,
           FlameringKey_109203050,
           FlameringKey_109203060,
           FlameringKey_109203070,
           FlameringKey_109203080,
           FlameringKey_109203090,
           AuroraKey_109204000,
           AuroraKey_109204010,
           AuroraKey_109204020,
           AuroraKey_109204030,
           AuroraKey_109204040,
           AuroraKey_109204050,
           AuroraKey_109204060,
           AuroraKey_109204070,
           AuroraKey_109204080,
           AuroraKey_109204090,
           BlackKey_109205000,
           BlackKey_109205010,
           BlackKey_109205020,
           BlackKey_109205030,
           BlackKey_109205040,
           BlackKey_109205050,
           BlackKey_109205060,
           BlackKey_109205070,
           BlackKey_109205080,
           BlackKey_109205090,
           RedOrb,
           RatTail,
           Gold,
           GoldOre,
           BluePhantoma,
           KoltzStar,
           HopeDiamond,
           FlamingBlood,
           ImperialGrenade,
           IfritRaidCoin,
           HermitsTeachings,
           StarMote,
           SwordsmanshipNotes,
           DesertMineral,
           OldJungleTree,
           MiraculousThread,
           HideoftheGuardian,
           SeedofIllusions,
           AncientWritings,
           HighgradeArmorOil,
           MysteriousDrop,
           AlterBlade,
           DreamBlossom,
           QualityGoldDust,
           Fish,
           WhiteAlcryst,
           WhiteMilcryst,
           WhiteHeavicryst,
           WhiteGiancryst,
           WhitePurecryst,
           BlackAlcryst,
           BlackMilcryst,
           BlackHeavicryst,
           BlackGiancryst,
           BlackPurecryst,
           GreenAlcryst,
           GreenMilcryst,
           GreenHeavicryst,
           GreenGiancryst,
           GreenPurecryst,
           PowerAlcryst,
           PowerMilcryst,
           PowerHeavicryst,
           PowerGiancryst,
           PowerPurecryst,
           GuardAlcryst,
           GuardMilcryst,
           GuardHeavicryst,
           GuardGiancryst,
           GuardPurecryst,
           HealingAlcryst,
           HealingMilcryst,
           HealingHeavicryst,
           HealingGiancryst,
           HealingPurecryst,
           SupportAlcryst,
           SupportMilcryst,
           SupportHeavicryst,
           SupportGiancryst,
           SupportPurecryst,
           TechAlcryst,
           TechMilcryst,
           TechHeavicryst,
           TechGiancryst,
           TechPurecryst,
           StrengthOrb,
           PetrifyGrenade,
           SleepingPowder,
           UnderdogsSecret,
           BlueButterflyPowder,
           RedButterflyPowder,
           Mote,
           MusicalNote,
           Perfume,
           Lipstick,
           NailPolish,
           FacePowder,
           HairSpray_106302300,
           Chocolate,
           FinasChocolate,
           ShadowLordCoin,
           WhiteOrb,
           KingMogCoin,
           WindFang,
           collab_106301700,
           collab_106301710,
           MemoryCandy,
           collab_106302500,
           Soldier,
           BreathofLife,
           TwilightStone,
           DuskJewel,
           DarkOre,
           TranquilStone,
           SilverChunk,
           BlessingNeedle,
           CursedSphere,
           SacredBranch,
           GloryBug,
           AntiqueBone,
           PinkScale,
           DawnShell,
           AchromaticBlossom,
           WhiteTail,
           DewBlossom,
           WhiteMetal,
           WhiteDrakesFeather,
           WhiteTome,
           WhiteSlate,
           BlueBeastsShell,
           BlueBeastsBone,
           BlueBeastsClaw,
           BlueBeastPieceI,
           SeaDrakesScale,
           SeaDrakesBone,
           SeaDrakesClaw,
           SeaDrakePieceI,
           RageDrakesSkin,
           RageDrakesBone,
           RageDrakesFang,
           RageDrakePieceI,
           RedBeastsShell,
           RedBeastsBone,
           RedBeastsClaw,
           WolfDrakesBone,
           WolfDrakesClaw,
           WolfDrakesShell,
           WhiteFeather,
           RedFeather,
           QualitySugar,
           DeliciousWater,
           CrimsonWing_215000100,
           AshScale,
           MysteriousMineral,
           AncientMedicine,
           BlessedStone,
           RuinGem,
           HairSpray_106302600,
           RedEgg,
           BlueEgg,
           RainbowEgg,
           MetalEgg,
           CrystalEggofPower,
           CrystalEggofMind,
           ShadowBahamutGem,
           ShadowBahamutScale,
           ShadowBahamutJade,
           ShadowBahamutWing,
           ShadowBahamutHeart,
           ShadowBahamutsOre,
           ShadowBahamutFang,
           BahamutRaidCoin,
           ShardofKelsus,
           SealedBox,
           CrimsonWing_216000800,
           AzureCorundum,
           MiasmaChunk,
           AetherochemicalFiber,
           CorruptWeed,
           TitanCoin,
           Relic,
           RandomMagicite,
           RandomMegacryst,
           RandomAwakeningMaterial,
           MinorScrollofHealing,
           GreaterScrollofHealing,
           MinorScrollofRecovery,
           GreaterScrollofRecovery,
           ProtagonistHalo,
           PotionofDeception,
           PotionofCleansing,
           PotionofElementalResistance,
           MinorPotionofRejuvenation,
           PotionofRejuvenation,
           GreaterPotionofRejuvenation,
           RandomConsumable,
           RandomMegacite,
           RandomMilcryst,
           RandomHeavicryst,
           RandomGiancryst,
           CrimsonOre,
           MetalGigantuarCoin_1209000832,
           SummonTicket,
           ThankYouCandy,
           ContestRaidCoin,
           DebasedCoin,
           PlayTicket,
           EngelsRaidCoin,
           AlBhedPrimer,
           TwilightFeather,
           PureThread,
           WornBlueprint,
           SteelBone,
           BlackOil,
           MagicParts,
           BrokenCircuit,
           RustedLump,
           TitaniumAlloy,
           BlackPearl,
           MeteorLight,
           BlackBox,
           Hairpin,
           MagmaRockFragments,
           MusicalGem,
           MetalGigantuarCoin_1209000837,
           Lantern,
           MetalGigantuarCoin_1209000839,
           SkeletonKey,
		};
    }
}