using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Request
    {
        public String Name { get; set; }
        public String Url { get; set; }
        public String EncodeKey { get; set; }
        public String RequestID { get; set; }

        public static readonly Request PurchaseSettlement = new Request { Name = "PurchaseSettlement", Url = "yt82BRwk", EncodeKey = "jmh7xID8", RequestID = "JsFd4b7j"};
        public static readonly Request RbMatching = new Request { Name = "RbMatching", Url = "mn5cHaJ0", EncodeKey = "4GSMn0qb", RequestID = "DgG4Cy0F"};
        public static readonly Request RmDungeonStart = new Request { Name = "RmDungeonStart", Url = "NC8Ie07P", EncodeKey = "A7V1zkyc", RequestID = "R5mWbQ3M"};
        public static readonly Request RmEnd = new Request { Name = "RmEnd", Url = "I9p3n48A", EncodeKey = "FX5L3Sfv", RequestID = "fyp10Rrc"};
        public static readonly Request FacebookRewardClaim = new Request { Name = "FacebookRewardClaim", Url = "47R9pLGq", EncodeKey = "Rja82ZUK", RequestID = "47R9pLGq"};
        public static readonly Request FriendDelete = new Request { Name = "FriendDelete", Url = "8R4fQbYh", EncodeKey = "d0VP5ia6", RequestID = "a2d6omAy"};
        public static readonly Request UpdateSwitchInfo = new Request { Name = "UpdateSwitchInfo", Url = "SqoB3a1T", EncodeKey = "4Z5UNaIW", RequestID = "mRPo5n2j"};
        public static readonly Request VariableStoreCheck = new Request { Name = "VariableStoreCheck", Url = "Nhn93ukW", EncodeKey = "Hi0FJU3c", RequestID = "i0woEP4B"};
        public static readonly Request CraftStart = new Request { Name = "CraftStart", Url = "w71MZ0Gg", EncodeKey = "K92H8wkY", RequestID = "Gr9zxXk5"};
        public static readonly Request SearchGetItemInfo = new Request { Name = "SearchGetItemInfo", Url = "e4Gjkf0x", EncodeKey = "vK2V8mZM", RequestID = "0D9mpGUR"};
        public static readonly Request SublimationSkill = new Request { Name = "SublimationSkill", Url = "xG3jBbw5", EncodeKey = "97Uvrdz3", RequestID = "s48Qzvhd"};
        public static readonly Request TownIn = new Request { Name = "TownIn", Url = "isHfQm09", EncodeKey = "JI8zU5rC", RequestID = "8EYGrg76"};
        public static readonly Request MissionBreak = new Request { Name = "MissionBreak", Url = "P4oIeVf0", EncodeKey = "Z2oPiE6p", RequestID = "17LFJD0b"};
        public static readonly Request BeastMix = new Request { Name = "BeastMix", Url = "7vHqNPF0", EncodeKey = "WfNSmy98", RequestID = "C8X1KUpV"};
        public static readonly Request LoginBonus = new Request { Name = "LoginBonus", Url = "iP9ogKy6", EncodeKey = "Vi6vd9zG", RequestID = "vw9RP3i4"};
        public static readonly Request Initialize = new Request { Name = "Initialize", Url = "fSG1eXI9", EncodeKey = "rVG09Xnt", RequestID = "75fYdNxq"};
        public static readonly Request DmgRankEnd = new Request { Name = "DmgRankEnd", Url = "zd5KJ3jn", EncodeKey = "7pGj8hSW", RequestID = "s98cw1WA"};
        public static readonly Request GameSetting = new Request { Name = "GameSetting", Url = "OTX6Fmvu", EncodeKey = "4foXVwWd", RequestID = "OTX6Fmvu"};
        public static readonly Request GetUserInfo = new Request { Name = "GetUserInfo", Url = "u7sHDCg4", EncodeKey = "rcsq2eG7", RequestID = "X07iYtp5"};
        public static readonly Request NoticeUpdate = new Request { Name = "NoticeUpdate", Url = "TqtzK84R", EncodeKey = "9t68YyjT", RequestID = "CQ4jTm2F"};
        public static readonly Request sgExpdAccelerate = new Request { Name = "sgExpdAccelerate", Url = "Ik142Ff6", EncodeKey = "d3D4l8b4", RequestID = "Ik142Ff6"};
        public static readonly Request TownOut = new Request { Name = "TownOut", Url = "0EF3JPjL", EncodeKey = "Kc2PXd9D", RequestID = "sJcMPy04"};
        public static readonly Request BeastBoardPieceOpen = new Request { Name = "BeastBoardPieceOpen", Url = "Y2Zvnad9", EncodeKey = "7uxYTm3k", RequestID = "0gk3Tfbz"};
        public static readonly Request NoticeReadUpdate = new Request { Name = "NoticeReadUpdate", Url = "j6kSWR3q", EncodeKey = "iLdaq6j2", RequestID = "pC3a2JWU"};
        public static readonly Request MissionWaveStart = new Request { Name = "MissionWaveStart", Url = "Mn15zmDZ", EncodeKey = "d2mqJ6pT", RequestID = "BSq28mwY"};
        public static readonly Request MissionContinue = new Request { Name = "MissionContinue", Url = "ZzCXI6E7", EncodeKey = "34n2iv7z", RequestID = "LuCN4tU5"};
        public static readonly Request RoutineGachaUpdate = new Request { Name = "RoutineGachaUpdate", Url = "qS0YW57G", EncodeKey = "Q6ZGJj0h", RequestID = "t60dQP49"};
        public static readonly Request ExchangeShop = new Request { Name = "ExchangeShop", Url = "1bf0HF4w", EncodeKey = "qoRP87Fw", RequestID = "I7fmVX3R"};
        public static readonly Request GiftUpdate = new Request { Name = "GiftUpdate", Url = "noN8I0UK", EncodeKey = "xLEtf78b", RequestID = "9KN5rcwj"};
        public static readonly Request FriendSuggest = new Request { Name = "FriendSuggest", Url = "6TCn0BFh", EncodeKey = "j2P3uqRC", RequestID = "iAs67PhJ"};
        public static readonly Request RoutineWorldUpdate = new Request { Name = "RoutineWorldUpdate", Url = "oR1psQ5B", EncodeKey = "XDIL4E7j", RequestID = "6H1R9WID"};
        public static readonly Request UnitSell = new Request { Name = "UnitSell", Url = "0qmzs2gA", EncodeKey = "DJ43wmds", RequestID = "9itzg1jc"};
        public static readonly Request StrongBoxOpen = new Request { Name = "StrongBoxOpen", Url = "48ktHf13", EncodeKey = "sgc30nRh", RequestID = "PIv7u8jU"};
        public static readonly Request RbStart = new Request { Name = "RbStart", Url = "dR20sWwE", EncodeKey = "P1w8BKLI", RequestID = "eHY7X8Nn"};
        public static readonly Request ClsmStart = new Request { Name = "ClsmStart", Url = "rncR9js8", EncodeKey = "wdSs23yW", RequestID = "4uCSA3ko"};
        public static readonly Request GachaExe = new Request { Name = "GachaExe", Url = "oC30VTFp", EncodeKey = "oaEJ9y1Z", RequestID = "9fVIioy1"};
        public static readonly Request sgExpdQuestStart = new Request { Name = "sgExpdQuestStart", Url = "I8uq68c3", EncodeKey = "60Os29Mg", RequestID = "I8uq68c3"};
        public static readonly Request MissionReStart = new Request { Name = "MissionReStart", Url = "r5vfM1Y3", EncodeKey = "Vw6bP0rN", RequestID = "GfI4LaU3"};
        public static readonly Request CraftExe = new Request { Name = "CraftExe", Url = "UyHLjV60", EncodeKey = "ZbHEB15J", RequestID = "PKDhIN34"};
        public static readonly Request OptionUpdate = new Request { Name = "OptionUpdate", Url = "0Xh2ri5E", EncodeKey = "B9mAa7rp", RequestID = "otgXV79T"};
        public static readonly Request RoutineRaidMenuUpdate = new Request { Name = "RoutineRaidMenuUpdate", Url = "Sv85kcPQ", EncodeKey = "z80swWd9", RequestID = "g0BjrU5D"};
        public static readonly Request Friend = new Request { Name = "Friend", Url = "8drhF2mG", EncodeKey = "6WAkj0IH", RequestID = "j0A5vQd8"};
        public static readonly Request MedalExchange = new Request { Name = "MedalExchange", Url = "0X8Fpjhb", EncodeKey = "dCja1E54", RequestID = "LiM9Had2"};
        public static readonly Request RbBoardPieceOpen = new Request { Name = "RbBoardPieceOpen", Url = "iXKfI4v1", EncodeKey = "g68FW4k1", RequestID = "hqzU9Qc5"};
        public static readonly Request RmRetire = new Request { Name = "RmRetire", Url = "fBn58ApV", EncodeKey = "T4Undsr6", RequestID = "e0R3iDm1"};
        public static readonly Request FriendList = new Request { Name = "FriendList", Url = "p3hwqW5U", EncodeKey = "1iV2oN9r", RequestID = "u7Id4bMg"};
        public static readonly Request MailList = new Request { Name = "MailList", Url = "u3E8hpad", EncodeKey = "7kgsrGQ1", RequestID = "KQHpi0D7"};
        public static readonly Request FriendRefuse = new Request { Name = "FriendRefuse", Url = "Vw0a4I3i", EncodeKey = "RYdX9h2A", RequestID = "1nbWRV9w"};
        public static readonly Request RmRestart = new Request { Name = "RmRestart", Url = "NC8Ie07P", EncodeKey = "R1VjnNx0", RequestID = "yh21MTaG"};
        public static readonly Request MissionEnd = new Request { Name = "MissionEnd", Url = "0ydjM5sU", EncodeKey = "1tg0Lsqj", RequestID = "x5Unqg2d"};
        public static readonly Request UpdateUserInfo = new Request { Name = "UpdateUserInfo", Url = "v3RD1CUB", EncodeKey = "6v5ykfpr", RequestID = "ey8mupb4"};
        public static readonly Request RmStart = new Request { Name = "RmStart", Url = "8BJSL7g0", EncodeKey = "iu67waph", RequestID = "7FyJS3Zn"};
        public static readonly Request FacebookRewardList = new Request { Name = "FacebookRewardList", Url = "8YZsGLED", EncodeKey = "85YBRzZg", RequestID = "8YZsGLED"};
        public static readonly Request MissionUpdate = new Request { Name = "MissionUpdate", Url = "fRDUy3E2", EncodeKey = "Nq9uKGP7", RequestID = "j5JHKq6S"};
        public static readonly Request sgExpdQuestRefresh = new Request { Name = "sgExpdQuestRefresh", Url = "vTgYyHM6", EncodeKey = "vceNlSf3gn", RequestID = "vTgYyHM6lC"};
        public static readonly Request CreateUser = new Request { Name = "CreateUser", Url = "0FK8NJRX", EncodeKey = "73BUnZEr", RequestID = "P6pTz4WA"};
        public static readonly Request ClsmEnd = new Request { Name = "ClsmEnd", Url = "7vHqNPF0", EncodeKey = "6aBHXGv4", RequestID = "3zgbapQ7"};
        public static readonly Request sgMissionUnlock = new Request { Name = "sgMissionUnlock", Url = "LJhqu0x6", EncodeKey = "ZcBV06K4", RequestID = "LJhqu0x6"};
        public static readonly Request DailyQuestUpdate = new Request { Name = "DailyQuestUpdate", Url = "QWDn5epF", EncodeKey = "9QtGVCWg", RequestID = "6QYd5Hym"};
        public static readonly Request FacebookLogout = new Request { Name = "FacebookLogout", Url = "xHTo4BZp", EncodeKey = "wwHxtAy6", RequestID = "xHTo4BZp"};
        public static readonly Request DailyQuestClaimReward = new Request { Name = "DailyQuestClaimReward", Url = "Br9PwJ6A", EncodeKey = "jwYGF3sY", RequestID = "Zy8fYJ5e"};
        public static readonly Request RmEntry = new Request { Name = "RmEntry", Url = "fBn58ApV", EncodeKey = "p2tqP7Ng", RequestID = "wx5sg9ye"};
        public static readonly Request TransferCodeCheck = new Request { Name = "TransferCodeCheck", Url = "C9LoeYJ8", EncodeKey = "c5aNjK9J", RequestID = "CY89mIdz"};
        public static readonly Request CraftEnd = new Request { Name = "CraftEnd", Url = "9G7Vc8Ny", EncodeKey = "yD97t8kB", RequestID = "WIuvh09n"};
        public static readonly Request RoutineEventUpdate = new Request { Name = "RoutineEventUpdate", Url = "WCK5tvr0", EncodeKey = "V0TGwId5", RequestID = "4kA1Ne05"};
        public static readonly Request RmBreak = new Request { Name = "RmBreak", Url = "8BJSL7g0", EncodeKey = "W3YTRI8e", RequestID = "kWrXKC35"};
        public static readonly Request MissionRetire = new Request { Name = "MissionRetire", Url = "gbZ64SQ2", EncodeKey = "oUh1grm8", RequestID = "v51PM7wj"};
        public static readonly Request FriendAgree = new Request { Name = "FriendAgree", Url = "1DYp5Nqm", EncodeKey = "9FjK0zM3", RequestID = "kx13SLUY"};
        public static readonly Request BundlePurchase = new Request { Name = "BundlePurchase", Url = "tPc64qmn", EncodeKey = "NE3Pp4K8", RequestID = "w6Z9a6tD"};
        public static readonly Request ClsmEntry = new Request { Name = "ClsmEntry", Url = "UmLwv56W", EncodeKey = "8bmHF3Cz", RequestID = "5g0vWZFq"};
        public static readonly Request GetBackgroundDownloadInfo = new Request { Name = "GetBackgroundDownloadInfo", Url = "action", EncodeKey = "Z1krd75o", RequestID = "lEHBdOEf"};
        public static readonly Request TransferCodeIssue = new Request { Name = "TransferCodeIssue", Url = "hF0yCKc1", EncodeKey = "T0y6ij47", RequestID = "crzI2bA5"};
        public static readonly Request RoutineHomeUpdate = new Request { Name = "RoutineHomeUpdate", Url = "1YWTzU9h", EncodeKey = "aw0syG7H", RequestID = "Daud71Hn"};
        public static readonly Request ItemCarryEdit = new Request { Name = "ItemCarryEdit", Url = "8BE6tJbf", EncodeKey = "04opy1kf", RequestID = "UM7hA0Zd"};
        public static readonly Request ClsmLottery = new Request { Name = "ClsmLottery", Url = "4uj3NhUQ", EncodeKey = "pU62SkhJ", RequestID = "Un16HuNI"};
        public static readonly Request MissionStart = new Request { Name = "MissionStart", Url = "63VqtzbQ", EncodeKey = "i48eAVL6", RequestID = "29JRaDbd"};
        public static readonly Request ItemBuy = new Request { Name = "ItemBuy", Url = "oQrAys71", EncodeKey = "InN5PUR0", RequestID = "sxK2HG6T"};
        public static readonly Request sgExpdQuestInfo = new Request { Name = "sgExpdQuestInfo", Url = "hW0804Q9", EncodeKey = "4Bn7d973", RequestID = "hW0804Q9"};
        public static readonly Request FacebookAddFriend = new Request { Name = "FacebookAddFriend", Url = "NAW9vJnm", EncodeKey = "532vAYUy", RequestID = "NAW9vJnm"};
        public static readonly Request CraftAdd = new Request { Name = "CraftAdd", Url = "iQ7R4CFB", EncodeKey = "qz0SG1Ay", RequestID = "QkN1Sp64"};
        public static readonly Request PurchaseCurrentState = new Request { Name = "PurchaseCurrentState", Url = "bAR4k7Qd", EncodeKey = "X9k5vFdu", RequestID = "9mM3eXgi"};
        public static readonly Request UnitFavorite = new Request { Name = "UnitFavorite", Url = "sqeRg12M", EncodeKey = "w9mWkGX0", RequestID = "tBDi10Ay"};
        public static readonly Request BundleStatus = new Request { Name = "BundleStatus", Url = "tPc64qmn", EncodeKey = "PrSPuc8c", RequestID = "uLXAMvCT"};
        public static readonly Request FriendFavorite = new Request { Name = "FriendFavorite", Url = "8IYSJ5H1", EncodeKey = "3EBXbj1d", RequestID = "1oE3Fwn4"};
        public static readonly Request RbRanking = new Request { Name = "RbRanking", Url = "3fd8y7W1", EncodeKey = "SR6PoLM3", RequestID = "kcW85SfU"};
        public static readonly Request DailyDungeonSelect = new Request { Name = "DailyDungeonSelect", Url = "9LgmdR0v", EncodeKey = "ioC6zqG1", RequestID = "JyfxY2e0"};
        public static readonly Request PurchaseList = new Request { Name = "PurchaseList", Url = "YqZ6Qc1z", EncodeKey = "X3Csghu0", RequestID = "BT28S96F"};
        public static readonly Request DailyQuestClaimAllReward = new Request { Name = "DailyQuestClaimAllReward", Url = "Br9PwJ6A", EncodeKey = "KHx6JdrT", RequestID = "DCmya9WD"};
        public static readonly Request RbReStart = new Request { Name = "RbReStart", Url = "DQ49vsGL", EncodeKey = "PRzAL3V2", RequestID = "6ZNY3zAm"};
        public static readonly Request ArchiveUpdate = new Request { Name = "ArchiveUpdate", Url = "2bCcKx0D", EncodeKey = "IFLW9H4M", RequestID = "cVTxW0K3"};
        public static readonly Request PurchaseSetting = new Request { Name = "PurchaseSetting", Url = "9hUtW0F8", EncodeKey = "ePFcMX53", RequestID = "QkwU4aD9"};
        public static readonly Request RbEntry = new Request { Name = "RbEntry", Url = "30inL7I6", EncodeKey = "EA5amS29", RequestID = "f8kXGWy0"};
        public static readonly Request DungeonLiberation = new Request { Name = "DungeonLiberation", Url = "0vc6irBY", EncodeKey = "0xDA4Cr9", RequestID = "nQMb2L4h"};
        public static readonly Request UnitMix = new Request { Name = "UnitMix", Url = "6aLHwhJ8", EncodeKey = "4zCuj2hK", RequestID = "UiSC9y8R"};
        public static readonly Request sgExpdMileStoneClaim = new Request { Name = "sgExpdMileStoneClaim", Url = "r4A791RF", EncodeKey = "t04N07LQ", RequestID = "r4A791RF"};
        public static readonly Request sgExpdRecall = new Request { Name = "sgExpdRecall", Url = "0Fb87D0F", EncodeKey = "9J02K0lX", RequestID = "0Fb87D0F"};
        public static readonly Request Transfer = new Request { Name = "Transfer", Url = "v6Jba7pX", EncodeKey = "C6eHo3wU", RequestID = "oE5fmZN9"};
        public static readonly Request PurchaseGiveUp = new Request { Name = "PurchaseGiveUp", Url = "C2w0f3go", EncodeKey = "xoZ62QWy", RequestID = "BFf1nwh6"};
        public static readonly Request GachaInfo = new Request { Name = "GachaInfo", Url = "3nhWq25K", EncodeKey = "VA8QR57X", RequestID = "UNP1GR5n"};
        public static readonly Request PurchaseStart = new Request { Name = "PurchaseStart", Url = "tPc64qmn", EncodeKey = "9Kf4gYvm", RequestID = "qAUzP3R6"};
        public static readonly Request RmDungeonEnd = new Request { Name = "RmDungeonEnd", Url = "CH9fWn8K", EncodeKey = "dEnsQ75t", RequestID = "WaPC2T6i"};
        public static readonly Request sgHomeMarqueeInfo = new Request { Name = "sgHomeMarqueeInfo", Url = "PBSP9qn5", EncodeKey = "d3GDS9X8", RequestID = "PBSP9qn5"};
        public static readonly Request TownUpdate = new Request { Name = "TownUpdate", Url = "0ZJzH2qY", EncodeKey = "37nH21zE", RequestID = "G1hQM8Dr"};
        public static readonly Request GetTitleInfo = new Request { Name = "GetTitleInfo", Url = "BbIeq31M", EncodeKey = "Mw56RNZ2", RequestID = "ocP3A1FI"};
        public static readonly Request RateAppReward = new Request { Name = "RateAppReward", Url = "L0OsxMaT", EncodeKey = "m1pPBwC3", RequestID = "L0OsxMaT"};
        public static readonly Request PurchaseFailed = new Request { Name = "PurchaseFailed", Url = "2TCis0R6", EncodeKey = "sW0vf3ZM", RequestID = "jSe80Gx7"};
        public static readonly Request CampaignAccept = new Request { Name = "CampaignAccept", Url = "n7Hitfg4", EncodeKey = "Xb0G1wcB", RequestID = "G6ye0D1t"};
        public static readonly Request PurchaseCancel = new Request { Name = "PurchaseCancel", Url = "y71uBCER", EncodeKey = "Z1mojg9a", RequestID = "L7K0ezU2"};
        public static readonly Request DmgRankRetire = new Request { Name = "DmgRankRetire", Url = "8wdmR9yG", EncodeKey = "5fkWyeE6", RequestID = "W3Z4VF1X"};
        public static readonly Request ItemSell = new Request { Name = "ItemSell", Url = "hQRf8D6r", EncodeKey = "E8H3UerF", RequestID = "d9Si7TYm"};
        public static readonly Request PurchaseHold = new Request { Name = "PurchaseHold", Url = "dCxtMZ27", EncodeKey = "5Mwfq90Z", RequestID = "79EVRjeM"};
        public static readonly Request MailReceipt = new Request { Name = "MailReceipt", Url = "M2fHBe9d", EncodeKey = "P2YFr7N9", RequestID = "XK7efER9"};
        public static readonly Request UnitClassUp = new Request { Name = "UnitClassUp", Url = "8z4Z0DUY", EncodeKey = "L2sTK0GM", RequestID = "zf49XKg8"};
        public static readonly Request PartyDeckEdit = new Request { Name = "PartyDeckEdit", Url = "6xkK4eDG", EncodeKey = "34qFNPf7", RequestID = "TS5Dx9aZ"};
        public static readonly Request FriendSearch = new Request { Name = "FriendSearch", Url = "6Y1jM3Wp", EncodeKey = "VCL5oj6u", RequestID = "3siZRSU4"};
        public static readonly Request sgExpdEnd = new Request { Name = "sgExpdEnd", Url = "2pe3Xa8bpG", EncodeKey = "cjHumZ2Jkt", RequestID = "2pe3Xa8bpG"};
        public static readonly Request ShopUse = new Request { Name = "ShopUse", Url = "w76ThDMm", EncodeKey = "ZT0Ua4wL", RequestID = "73SD2aMR"};
        public static readonly Request UnitEquip = new Request { Name = "UnitEquip", Url = "nIk9z5pT", EncodeKey = "45VZgFYv", RequestID = "pB3st6Tg"};
        public static readonly Request DmgRankStart = new Request { Name = "DmgRankStart", Url = "j37Vk5xe", EncodeKey = "1d5AP9p6", RequestID = "5P6ULvjg"};
        public static readonly Request RbEnd = new Request { Name = "RbEnd", Url = "e8AHNiT7", EncodeKey = "MVA3Te2i", RequestID = "os4k7C0b"};
        public static readonly Request TrophyReward = new Request { Name = "TrophyReward", Url = "05vJDxg9", EncodeKey = "2o7kErn1", RequestID = "wukWY4t2"};
        public static readonly Request MissionWaveReStart = new Request { Name = "MissionWaveReStart", Url = "8m7KNezI", EncodeKey = "M3bYZoU5", RequestID = "e9RP8Cto"};
        public static readonly Request CraftCancel = new Request { Name = "CraftCancel", Url = "7WdDLIE4", EncodeKey = "68zcUF3E", RequestID = "79xDN1Mw"};
        public static readonly Request CampaignTieup = new Request { Name = "CampaignTieup", Url = "2u30vqfY", EncodeKey = "72d5UTNC", RequestID = "mI0Q2YhW"};
        public static readonly Request SpChallengeRewardGet = new Request { Name = "SpChallengeRewardGet", Url = "9inGHyqC", EncodeKey = "mG25PIUn", RequestID = "2G7ZVs4A"};
        public static readonly Request PlaybackMissionWaveStart = new Request { Name = "PlaybackMissionWaveStart", Url = "scyPYa81", EncodeKey = "NdkX15vE", RequestID = "1BpXP3Fs"};
        public static readonly Request DungeonResourceLoadMstList = new Request { Name = "DungeonResourceLoadMstList", Url = "Sl8UgmP4", EncodeKey = "3PVu6ReZ", RequestID = "jnw49dUq"};
        public static readonly Request MissionSwitchUpdate = new Request { Name = "MissionSwitchUpdate", Url = "1Xz8kJLr", EncodeKey = "bZezA63a", RequestID = "Tvq54dx6"};
        public static readonly Request AllianceDeckEdit = new Request { Name = "AllianceDeckEdit", Url = "7gAGFC4I", EncodeKey = "2E3UinsJ", RequestID = "P76LYXow"};
        public static readonly Request IsNeedValidate = new Request { Name = "IsNeedValidate", Url = "gk3Wtr8A", EncodeKey = "djhiU6x8", RequestID = "er5xMIj6"};
        public static readonly Request SpChallengeEntry = new Request { Name = "SpChallengeEntry", Url = "8DermCsY", EncodeKey = "Uey5jW2G", RequestID = "MTf2j9aK"};
        public static readonly Request ChallengeClear = new Request { Name = "ChallengeClear", Url = "dEvLKchl", EncodeKey = "UD5QCa2s", RequestID = "D9xphQ8X"};
        public static readonly Request GetReinforcementInfo = new Request { Name = "GetReinforcementInfo", Url = "hXMoLwgE", EncodeKey = "87khNMou", RequestID = "AJhnI37s"};
        public static readonly Request PlaybackMissionStart = new Request { Name = "PlaybackMissionStart", Url = "zm2ip59f", EncodeKey = "YC20v1Uj", RequestID = "1YnQM4iB"};
        public static readonly Request AllianceEntry = new Request { Name = "AllianceEntry", Url = "EzfT0wX6", EncodeKey = "zS4tPgi7", RequestID = "HtR8XF4e"};

		public static readonly List<Request> Requests = new List<Request>
		{
           PurchaseSettlement,
           RbMatching,
           RmDungeonStart,
           RmEnd,
           FacebookRewardClaim,
           FriendDelete,
           UpdateSwitchInfo,
           VariableStoreCheck,
           CraftStart,
           SearchGetItemInfo,
           SublimationSkill,
           TownIn,
           MissionBreak,
           BeastMix,
           LoginBonus,
           Initialize,
           DmgRankEnd,
           GameSetting,
           GetUserInfo,
           NoticeUpdate,
           sgExpdAccelerate,
           TownOut,
           BeastBoardPieceOpen,
           NoticeReadUpdate,
           MissionWaveStart,
           MissionContinue,
           RoutineGachaUpdate,
           ExchangeShop,
           GiftUpdate,
           FriendSuggest,
           RoutineWorldUpdate,
           UnitSell,
           StrongBoxOpen,
           RbStart,
           ClsmStart,
           GachaExe,
           sgExpdQuestStart,
           MissionReStart,
           CraftExe,
           OptionUpdate,
           RoutineRaidMenuUpdate,
           Friend,
           MedalExchange,
           RbBoardPieceOpen,
           RmRetire,
           FriendList,
           MailList,
           FriendRefuse,
           RmRestart,
           MissionEnd,
           UpdateUserInfo,
           RmStart,
           FacebookRewardList,
           MissionUpdate,
           sgExpdQuestRefresh,
           CreateUser,
           ClsmEnd,
           sgMissionUnlock,
           DailyQuestUpdate,
           FacebookLogout,
           DailyQuestClaimReward,
           RmEntry,
           TransferCodeCheck,
           CraftEnd,
           RoutineEventUpdate,
           RmBreak,
           MissionRetire,
           FriendAgree,
           BundlePurchase,
           ClsmEntry,
           GetBackgroundDownloadInfo,
           TransferCodeIssue,
           RoutineHomeUpdate,
           ItemCarryEdit,
           ClsmLottery,
           MissionStart,
           ItemBuy,
           sgExpdQuestInfo,
           FacebookAddFriend,
           CraftAdd,
           PurchaseCurrentState,
           UnitFavorite,
           BundleStatus,
           FriendFavorite,
           RbRanking,
           DailyDungeonSelect,
           PurchaseList,
           DailyQuestClaimAllReward,
           RbReStart,
           ArchiveUpdate,
           PurchaseSetting,
           RbEntry,
           DungeonLiberation,
           UnitMix,
           sgExpdMileStoneClaim,
           sgExpdRecall,
           Transfer,
           PurchaseGiveUp,
           GachaInfo,
           PurchaseStart,
           RmDungeonEnd,
           sgHomeMarqueeInfo,
           TownUpdate,
           GetTitleInfo,
           RateAppReward,
           PurchaseFailed,
           CampaignAccept,
           PurchaseCancel,
           DmgRankRetire,
           ItemSell,
           PurchaseHold,
           MailReceipt,
           UnitClassUp,
           PartyDeckEdit,
           FriendSearch,
           sgExpdEnd,
           ShopUse,
           UnitEquip,
           DmgRankStart,
           RbEnd,
           TrophyReward,
           MissionWaveReStart,
           CraftCancel,
           CampaignTieup,
           SpChallengeRewardGet,
           PlaybackMissionWaveStart,
           DungeonResourceLoadMstList,
           MissionSwitchUpdate,
           AllianceDeckEdit,
           IsNeedValidate,
           SpChallengeEntry,
           ChallengeClear,
           GetReinforcementInfo,
           PlaybackMissionStart,
           AllianceEntry,
		};
    }
}