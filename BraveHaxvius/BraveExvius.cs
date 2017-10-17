using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BraveHaxvius.Data;

namespace BraveHaxvius
{
    public class BraveExvius
    {
        public String AppVersion { get; set; } = "1028";
        public String RscVersion { get; set; } = "0";
        public String MstVersion { get; set; } = "992";
        public String Device { get; set; } = "iPhone9,3";
        //public String Device { get; set; } = "XT890";
        //public String Device { get; set; } = "SM-E7000";
        public String OperatingSystem { get; set; } = "ios10.2.1";
        //public String OperatingSystem { get; set; } = "android4.4.2";
        public String Locale { get; set; } = "US";
        public String BuildVersion { get { return Locale == "JP" ? "ver.2.9.3" : "ver.2.3.1"; } }
        public String UserName { get; set; }
        public String UserId { get; set; }
        public String Password { get; set; }
        public String FriendCode { get; set; }
        public String ModelChangeCnt { get; set; }
        public String GumiId { get; set; }
        public String GumiToken { get; set; }
        public String DeviceId { get; set; }
        public String ContactId { get; set; }
        public String AdvertisingId { get; set; }
        public String FacebookUserId { get; set; }
        public String FacebookToken { get; set; }
        public String TransferCode { get; set; }
        public String TransferPin { get; set; }
        public String UserAgent { get { return Device + "_" + OperatingSystem; } }
        public String PurchaseSignature { get { return Device.Contains("iPhone") ? "1" : OperatingSystem.Contains("amazon") ? "101" : "2"; } }
        public String LastSignalKey { get; set; }

        public Networking Network { get; set; }

        public String ProxyIpAddr { get; set; } = "shalzuthproxy";
        public Int32 ProxyPort { get; set; } = 0;
        public BraveExvius()
        {
            Network = new Networking { client = this };
        }
        public JProperty UserInfo
        {
            get
            {
                var userInfo = new JObject();
                if (!String.IsNullOrEmpty(UserId))
                    userInfo.Add(new JProperty(Variable.UserId, UserId));
                if (!String.IsNullOrEmpty(UserName))
                    userInfo.Add(new JProperty(Variable.UserName, UserName));
                if (!String.IsNullOrEmpty(TransferPin))
                {
                    userInfo.Add(new JProperty(Variable.TransferCode, TransferCode));
                    userInfo.Add(new JProperty(Variable.TransferPin, TransferPin));
                }
                if (!String.IsNullOrEmpty(Password))
                    userInfo.Add(new JProperty(Variable.Password, Password));
                if (!String.IsNullOrEmpty(ModelChangeCnt))
                    userInfo.Add(new JProperty(Variable.ModelChangeCnt, ModelChangeCnt));
                userInfo.Add(new JProperty(Variable.OperatingSystem, OperatingSystem));
                userInfo.Add(new JProperty(Variable.PurchaseSignature, PurchaseSignature));
                if (!String.IsNullOrEmpty(ContactId))
                    userInfo.Add(new JProperty(Variable.ContactId, ContactId));
                userInfo.Add(new JProperty(Variable.BuildVersion, BuildVersion));
                userInfo.Add(new JProperty(Variable.Time, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
                if (!String.IsNullOrEmpty(FriendCode))
                    userInfo.Add(new JProperty(Variable.FriendId, FriendCode));
                if (Locale == "US")
                {
                    userInfo.Add(new JProperty(Variable.AppVersion, AppVersion));
                    if (!String.IsNullOrEmpty(GumiId))
                        userInfo.Add(new JProperty(Variable.GumiId, GumiId));
                    if (!String.IsNullOrEmpty(GumiToken))
                        userInfo.Add(new JProperty(Variable.GumiToken, GumiToken));
                    userInfo.Add(new JProperty(Variable.CountryCode, Locale));
                    if (!String.IsNullOrEmpty(DeviceId))
                        userInfo.Add(new JProperty(Variable.DeviceId, DeviceId));
                    if (!String.IsNullOrEmpty(AdvertisingId))
                        userInfo.Add(new JProperty(Variable.AdvertisingId, AdvertisingId));
                    userInfo.Add(new JProperty(Variable.MacroToolRunningStatus, "0"));
                    userInfo.Add(new JProperty(Variable.Ymd, DateTime.Now.ToString("yyyyMMdd")));
                }
                if (!String.IsNullOrEmpty(FacebookUserId))
                {
                    userInfo.Add(new JProperty(Variable.FacebookUserId, FacebookUserId));
                    userInfo.Add(new JProperty(Variable.FacebookToken, FacebookToken));
                }
                return new JProperty(GameObject.UserInfo, new JArray(userInfo));
            }
        }
        public List<Unit> Units { get; set; } = new List<Unit>();
        public List<News> News { get; set; } = new List<News>();
        public List<Mail> Mail { get; set; } = new List<Mail>();
        public List<Mission> Missions { get; set; } = Mission.Missions;
        public List<Expedition> Expeditions { get; set; } = new List<Expedition>();
        public List<String> GachaId { get; set; } = new List<String>();
        public List<String> GachaDetailId { get; set; } = new List<String>();
        public JObject GetUserInfo;
        public void Login()
        {
            if (Locale != "JP" && FacebookUserId.Contains("@"))
            {
                var fb = new Facebook();
                if (FacebookToken.Contains(" : "))
                {
                    var twoFactor = FacebookToken.Substring(FacebookToken.IndexOf(" : ") + 3);
                    FacebookToken = FacebookToken.Substring(0, FacebookToken.IndexOf(" : "));
                    fb.Login(FacebookUserId, FacebookToken);
                    fb.FinishTwoFactorAuth(twoFactor);
                }
                else
                    fb.Login(FacebookUserId, FacebookToken);
                fb.AllowFFBE();

                FacebookUserId = fb.Id;
                FacebookToken = fb.AccessToken;
            }
            //DeviceId = Guid.NewGuid().ToString().ToUpper();
            //b.ContactId = Crypto.Encrypt(b.DeviceId, "Zy3MDURw");
            //AdvertisingId = Guid.NewGuid().ToString().ToUpper();
            Initialize();
            UpdateGetUserInfo();
            if (Locale != "JP")
            {
                UpdateUnits();
                UpdateNews();
                UpdateExpeditions();
            }
            UpdateMail();
            UpdateGachaList();
        }
        public void LoginFacebook(String fbId, String fbToken)
        {
            FacebookUserId = fbId;
            FacebookToken = fbToken;
            Login();
        }
        public void LoginUnlinkedAccount(String userId, String pw, String gumiId, String gumiToken)
        {
            UserId = userId;
            UserName = "Rain";
            Password = pw;
            GumiId = gumiId;
            GumiToken = gumiToken;
            ModelChangeCnt = "0";
            Login();
        }
        public void LoginJapan(String transferCode, String transferPin)
        {
            Locale = "JP";
            AppVersion = "1029";
            RscVersion = "596";
            MstVersion = "1764";
            TransferCode = transferCode;
            TransferPin = transferPin;
            var TransferCodeCheck = Network.SendPacket(Request.TransferCodeCheck);
            var userInfo = TransferCodeCheck[GameObject.UserInfo][0];
            TransferCode = "";
            TransferPin = "";
            UserId = userInfo[Variable.UserId].ToString();
            UserName = userInfo[Variable.UserName].ToString();
            ContactId = userInfo[Variable.ContactId].ToString();
            ModelChangeCnt = (int.Parse(userInfo[Variable.ModelChangeCnt].ToString()) - 1).ToString();
            OperatingSystem = userInfo[Variable.OperatingSystem].ToString();
            Login();
        }
        public void LinkToFb(String fbid, String fbtoken, String userId, String pw, String gumiId, String gumiToken)
        {
            LoginUnlinkedAccount(userId, pw, gumiId, gumiToken);
            FacebookUserId = fbid;
            FacebookToken = fbtoken;
            TransferCode = "1";
            var Initialize2 = Network.SendPacket(Request.Initialize);
            TransferCode = "";
            var Initialize3 = Network.SendPacket(Request.Initialize);
        }
        public Boolean CompletedSwitch(String switchId)
        {
            var uniqueSwitch = Switch.Switchs.First(s => s.SwitchId == switchId);
            if (GetUserInfo == null)
                return true;
            var switches = GetUserInfo[GameObject.UserSwitchInfo_8J1R5PXG];
            var switchBits = switches.First(s => s[Variable.SwitchType].ToString() == uniqueSwitch.SwitchType)[Variable.RequiredSwitchId].ToString();
            var letterNum = int.Parse(uniqueSwitch.SwitchBit) / 4;
            var bitNum = int.Parse(uniqueSwitch.SwitchBit) % 4;
            if (letterNum + 1 > switchBits.Length)
                return false;
            var letter = switchBits.Substring(letterNum, 1);
            var num = int.Parse(letter, System.Globalization.NumberStyles.HexNumber);
            var set = (num & (0x8 >> bitNum)) > 0;
            return set;
        }
        public void UpdateGachaList()
        {
            var gachaList = GetUserInfo[GameObject.GachaMst];
            foreach (var gacha in gachaList)
                GachaId.Add(gacha[Variable.GachaId] + " : " + gacha[Variable.Description] + " , " + gacha[Variable.InternalDescription]);
        }
        public void UpdateGachaDetailList(String gachaId)
        {
            var gachaDetailList = GetUserInfo[GameObject.GachaDetailMst];
            GachaDetailId.Clear();
            foreach (var gachaDetail in gachaDetailList)
                if (gachaDetail[Variable.GachaId].ToString() == gachaId)
                    GachaDetailId.Add(gachaDetail[Variable.GachaSubId] + " : " + gachaDetail[Variable.Description]);
        }
        public void ShopUse(String slotId, String itemId)
        {
            var UnfavoriteAll = Network.SendPacket(Request.ShopUse,
                new JProperty("L5Nj3cKE",
                    new JArray(
                        new JObject(
                            new JProperty("gdR2tJI9", slotId),
                            new JProperty(Variable.ItemCount, itemId),
                            new JProperty("Vt2I4RjX", "20:" + Item.SummonTicket.ItemId + ":1")))));
        }
        public void UnfavoriteAll()
        {
            var favoriteList = GetUserInfo[GameObject.UserUnitFavorite_1k3IefTc][0][Variable.UniqueUnitId].ToString();
            var UnfavoriteAll = Network.SendPacket(Request.UnitFavorite,
                new JProperty(GameObject.OpeUnitFavorite,
                    new JArray(
                        new JObject(
                            new JProperty("9Eb7m1NR", ""),
                            new JProperty("mGuM1Z9e", favoriteList)))));
        }
        public void SellUnits()
        {
            UnfavoriteAll();
            var distinctUnits = Units.Select(u => u.Name).Distinct();
            var du2 = distinctUnits.Select(u => Units.First(uu => uu.Name == u).UniqueUnitId);
            var favorites = GetUserInfo[GameObject.UserUnitFavorite_1k3IefTc][0][Variable.UniqueUnitId].ToString();
            var unitSellList = new List<String>();
            var totalSell = 0;
            foreach (var unit in Units)
            {
                if (unit.Name.Contains(" Pot") || unit.Name.Contains("tuar"))
                    continue;
                if (unit.Name.Contains("Trust") || unit.Name.Contains("Snapper") || unit.Level != "1" || unit.Rarity == "1" || unit.Rarity == "2" || unit.Rarity == "5" || unit.Rarity == "6")
                    continue;
                //if (favorites.Contains(unit.UniqueUnitId))
                //    continue;
                if (du2.Contains(unit.UniqueUnitId))
                    continue;
                var sellCost = 800;
                if (int.Parse(unit.Rarity) == 4)
                    sellCost = 1500;
                totalSell += sellCost;
                unitSellList.Add(unit.UniqueUnitId);
                Logger.Out("selling : " + unit.Name);
                if (totalSell > 90000)
                {
                    var partialsell = Network.SendPacket(Request.UnitSell,
                        new JProperty(GameObject.UnitSell,
                            new JArray(
                                new JObject(
                                    new JProperty(Variable.UnitSellPrice, totalSell),
                                    new JProperty(Variable.UnitSellIds, string.Join(",", unitSellList))))));
                    totalSell = 0;
                    unitSellList.Clear();
                }
            }
            if (unitSellList.Count() > 0)
                Network.SendPacket(Request.UnitSell,
                    new JProperty(GameObject.UnitSell,
                        new JArray(
                            new JObject(
                                new JProperty(Variable.UnitSellPrice, totalSell),
                                new JProperty(Variable.UnitSellIds, string.Join(",", unitSellList))))));
        }
        public void Sell<T>(String sellList, List<T> itemList, String varname, int type)
        {
            var items = GetUserInfo[sellList][0][Variable.ItemList].ToString().Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int sellcount = 0;
            var itemSellString = new List<String>();
            int giltotal = 0;
            foreach (var equip in items)
            {
                itemSellString.Add(type + ":" + equip);
                var id = equip.Split(new char[1] { ':' })[0];
                var count = equip.Split(new char[1] { ':' })[1];
                var item = itemList.First(e => e.GetType().GetProperty(varname).GetValue(e)?.ToString() == id);
                giltotal += int.Parse(item.GetType().GetProperty("ItemSellPrice").GetValue(item).ToString()) * int.Parse(count);
                if (sellcount++ == 90)
                {
                    Network.SendPacket(Request.ItemSell, new JProperty(Variable.ItemSell, new JArray(new JObject(
                        new JProperty(Variable.StoreItemSellId, String.Join(",", itemSellString)),
                        new JProperty(Variable.StoreItemSellPrice, giltotal.ToString())))));
                    itemSellString.Clear();
                    giltotal = 0;
                    sellcount = 0;
                }
            }
            if (sellcount > 0)
            {
                Network.SendPacket(Request.ItemSell, new JProperty(Variable.ItemSell, new JArray(new JObject(
                           new JProperty(Variable.StoreItemSellId, String.Join(",", itemSellString)),
                           new JProperty(Variable.StoreItemSellPrice, giltotal.ToString())))));
            }
        }
        public void FuckAccount()
        {
            var currentEquips = GetUserInfo[GameObject.UnitEquip_TJ9eL80N];
            var unequipAllEquipment = String.Join(",", currentEquips.Select(e => e[Variable.UniqueUnitId] + ":1-0@2-0@3-0@4-0@5-0@6-0"));
            //var currentMaterias = GetUserInfo[GameObject.uniteq];
            var unequipAllMateria = String.Join(",", currentEquips.Select(e => e[Variable.UniqueUnitId] + ":1-0"));
            Network.SendPacket(Request.UnitEquip,
                new JProperty(GameObject.UnitEquip_Er92Kdhm, new JArray(new JObject(
                    new JProperty(Variable.Equipment, unequipAllEquipment),//1-0@2-0@3-0@4-0@5-409005000@6-409005000"),
                    new JProperty(Variable.Materia, unequipAllMateria),
                    new JProperty("xBi3L6yR", "1")))));
            Thread.Sleep(3000);
            Sell(GameObject.UserItemInfo_4rC0aLkA, Item.Items, "ItemId", 20);
            Thread.Sleep(3000);
            Sell(GameObject.UserEquipItemInfo_w83oV9uP, Equipment.Equipments, "EquipId", 21);
            Thread.Sleep(3000);
            Sell(GameObject.UserMateriaInfo_aS39Eshy, Materia.Materias, "MateriaId", 22);
            Thread.Sleep(3000);
            var rain = Units.First(u => u.Name == Unit.Rain_100000102.Name);
            Enumerable.Range(0, 5).ToList().ForEach(i => { SetParty(rain.UniqueUnitId, i); Thread.Sleep(3000); });
            UnfavoriteAll();
            var unitSellList = new List<String>();
            var totalSell = 0;
            foreach (var unit in Units)
            {
                if (unit.Name.Contains(" Pot") || unit.Name.Contains("tuar") || unit.Name.Contains("Trust") || unit.Name.Contains("Snapper"))
                    continue;
                if (unit.Level != "1")
                    continue;
                var sellCost = 200;
                if (int.Parse(unit.Rarity) == 2)
                    sellCost = 500;
                else if (int.Parse(unit.Rarity) == 3)
                    sellCost = 800;
                else if (int.Parse(unit.Rarity) == 4)
                    sellCost = 1500;
                else if (int.Parse(unit.Rarity) == 5)
                    sellCost = 3000;
                totalSell += sellCost;
                unitSellList.Add(unit.UniqueUnitId);
                Logger.Out("selling : " + unit.Name);
                if (totalSell > 90000)
                {
                    var partialsell = Network.SendPacket(Request.UnitSell,
                        new JProperty(GameObject.UnitSell,
                            new JArray(
                                new JObject(
                                    new JProperty(Variable.UnitSellPrice, totalSell),
                                    new JProperty(Variable.UnitSellIds, string.Join(",", unitSellList))))));
                    Thread.Sleep(3000);
                    totalSell = 0;
                    unitSellList.Clear();
                }
            }
            if (unitSellList.Count() > 0)
                Network.SendPacket(Request.UnitSell,
                    new JProperty(GameObject.UnitSell,
                        new JArray(
                            new JObject(
                                new JProperty(Variable.UnitSellPrice, totalSell),
                                new JProperty(Variable.UnitSellIds, string.Join(",", unitSellList))))));
        }
        public void UnitHunter(Unit unit, Func<int, int> status = null)
        {
            var Gachas = GetUserInfo[GameObject.GachaScheduleMst];
            var Gacha10_1 = Gachas.First(g => g[Variable.Description].ToString().Contains("10+1"));
            var sell3Star = !GetUserInfo[GameObject.UserOptionInfo].First()[Variable.OptionValue].ToString().Contains("3");
            var sell4Star = !GetUserInfo[GameObject.UserOptionInfo].First()[Variable.OptionValue].ToString().Contains("4");
            var newUnits = new List<Unit>();
            int iteration = 0;
            while (newUnits.Count(u => u.UnitId == unit.BaseUnitId) == 0)
            {
                newUnits.Clear();
                DoMission(Mission.AirshipDeck, false, "20:" + Item.SummonTicket.ItemId + ":9");
                for (int j = 0; j < 9; j++)
                {
                    status?.Invoke(iteration++);
                    newUnits.AddRange(Summon(Gacha10_1[Variable.GachaId].ToString(), Gacha10_1[Variable.Options].ToString(), "1", "0"));
                    Thread.Sleep(5000);
                    if (newUnits.Count(u => u.UnitId == unit.BaseUnitId) > 0)
                        break;
                }
                var unitSellList = new List<String>();
                var totalSell = 0;
                if (!sell3Star)
                    continue;
                newUnits.ForEach(u =>
                {
                    var sellCost = 800;
                    if (u.Rarity == "4")
                    {
                        sellCost = 1500;
                        if (!sell4Star)
                            return;
                    }
                    if (u.Rarity == "5")
                        return;
                    totalSell += sellCost;
                    unitSellList.Add(u.UniqueUnitId);
                });
                Network.SendPacket(Request.UnitSell,
                    new JProperty(GameObject.UnitSell,
                        new JArray(
                            new JObject(
                                new JProperty(Variable.UnitSellPrice, totalSell),
                                new JProperty(Variable.UnitSellIds, string.Join(",", unitSellList))))));
                Thread.Sleep(3000);
            }
        }
        public void FuseUnits()
        {
            UpdateUnits();

            var favorites = GetUserInfo[GameObject.UserUnitFavorite_1k3IefTc][0][Variable.UniqueUnitId].ToString();
            var expeditionUnits = String.Join(",", GetUserInfo[GameObject.sgExpdQuestInfo].Select(n => n["7mA422N6"].ToString()).ToList());
            foreach (var unit in Units)
            {
                if (unit.Name.Contains(" Pot") || unit.Name.Contains("tuar"))
                    continue;
                if (!favorites.Contains(unit.UniqueUnitId))
                    continue;
                if (expeditionUnits.Contains(unit.UniqueUnitId))
                    continue;
                if (int.Parse(unit.Level) == 0)
                    continue;
                if (Single.Parse(unit.Tmr) >= 100.0f)
                    continue;
                var fuseExperience = 1500;
                if (int.Parse(unit.Rarity) == 4)
                    fuseExperience = 2500;
                var unitsToFuse = Units.FindAll(u => u.BaseUnitId == unit.BaseUnitId && u.UniqueUnitId != unit.UniqueUnitId && !favorites.Contains(u.UniqueUnitId) && u.Level != "0");
                var remainingTmr = 104.9f - Single.Parse(unit.Tmr);
                var remainingUnits = (UInt16)Math.Min(remainingTmr / 5.0f, 5.0f);
                var unitShortList = unitsToFuse.Take(remainingUnits).ToList();
                unitsToFuse = unitsToFuse.Skip(remainingUnits).ToList();
                if (unitShortList.Count() > 0)
                    Logger.Out("fusing : " + unit.Name + " x" + unitShortList.Count);
                while (unitShortList.Count() == 5)
                {
                    var fuseList = new List<String>();
                    foreach (var fuseUnit in unitShortList)
                        fuseList.Add(fuseUnit.UniqueUnitId);
                    var UnitMix = Network.SendPacket(Request.UnitMix,
                        new JProperty(GameObject.UnitMix,
                            new JArray(
                                new JObject(
                                    new JProperty(Variable.UniqueUnitId, unit.UniqueUnitId),
                                    new JProperty(Variable.UnitList, string.Join(",", fuseList)),
                                    new JProperty(Variable.Gil, (30 + 30 * int.Parse(unit.Level) * unitShortList.Count()).ToString()),
                                    new JProperty(Variable.Experience, (fuseExperience * unitShortList.Count()).ToString()),
                                    new JProperty("UDMIFB72", "0")))));
                    Thread.Sleep(3000);
                    Units.FindAll(u => fuseList.Contains(u.UniqueUnitId)).ForEach(u => u.Level = "0");
                    unit.Tmr = (Single.Parse(unit.Tmr) + 5 * unitShortList.Count()).ToString();
                    remainingTmr = 104.9f - Single.Parse(unit.Tmr);
                    remainingUnits = (UInt16)Math.Min(remainingTmr / 5.0f, 5.0f);
                    unitShortList = unitsToFuse.Take(remainingUnits).ToList();
                    unitsToFuse = unitsToFuse.Skip(remainingUnits).ToList();
                }
            }
            UpdateUnits();
        }
        public void UpdateUnits()
        {
            Units.Clear();
            var unitList = GetUserInfo[GameObject.UserUnitInfo_B71MekS8];
            foreach (var unitToken in unitList)
            {
                var unitId = unitToken[Variable.UnitId].ToString();
                var unitInfo = Unit.Units.First(u => u.UnitId == unitId);
                var unit = new Unit
                {
                    Name = unitInfo.Name,
                    UnitId = unitId,
                    BaseUnitId = unitInfo.BaseUnitId,
                    UniqueUnitId = unitToken[Variable.UniqueUnitId].ToString(),
                    Tmr = (Single.Parse(unitToken[Variable.UnitTmr].ToString()) / 10.0f).ToString(),
                    Rarity = UInt16.Parse(unitId.Substring(unitId.Length - 1)).ToString(),
                    Level = unitToken[Variable.Level].ToString(),
                    UnitHp = unitToken[Variable.UnitHp].ToString(),
                    UnitMaxLevel = unitInfo.UnitMaxLevel
                };
                Units.Add(unit);
            }
        }
        public void UpdateNews()
        {
            News.Clear();
            var newsList = GetUserInfo[GameObject.NoticeMstNew].Select(n => new News
            {
                Id = n[Variable.NoticeId].ToString(),
                Type = n[Variable.NoticeType].ToString(),
                Translation = ((JObject)JsonConvert.DeserializeObject(n[Variable.TranslationJson].ToString()))["en"].ToString(),
                Link = n[Variable.Link].ToString().Replace("/[@@]", "en")
            }).ToList();
            News.AddRange(newsList);
        }
        public void UpdateExpeditions()
        {
            Expeditions.Clear();
            var expeditions = GetUserInfo[GameObject.sgExpdQuestInfo].Select(n => new Expedition
            {
                Id = n[Variable.ExpeditionId].ToString()
            }).ToList();
            Expeditions.AddRange(expeditions);
        }
        public void UpdateMail()
        {
            Mail.Clear();
            var MailList = Network.SendPacket(Request.MailList);
            if (MailList == null || MailList[GameObject.UserMailInfo] != null)
                return;
            var mailList = Network.SendPacket(Request.MailList)[GameObject.UserMailInfo].Select(m => new Mail
            {
                Id = m[Variable.MailId].ToString(),
                Title = m[Variable.MailTitle].ToString().StartsWith("{") ?
                     ((JObject)JsonConvert.DeserializeObject(m[Variable.MailTitle].ToString()))["en"].ToString() : Text.Texts[m[Variable.MailTitle].ToString()],
                Message = m[Variable.MailTitle].ToString().StartsWith("{") ?
                    ((JObject)JsonConvert.DeserializeObject(m[Variable.Message].ToString()))["en"].ToString() :
                        Text.Texts.ContainsKey(m[Variable.Message].ToString()) ? Text.Texts[m[Variable.Message].ToString()] : m[Variable.Message].ToString(),
                Type = m[Variable.MailType].ToString(),
                Items = m[Variable.MailItems].ToString(),
                Status = m[Variable.MailStatus].ToString() == "0" ? "O" : "X",
            }).ToList();
            Mail.AddRange(mailList);
        }
        public List<Unit> Summon(String GachaId, String GachaDetailId, String Repeat, String TicketType)
        {
            var GachaSummon = Network.SendPacket(Request.GachaExe,
                new JProperty(GameObject.GachaExe,
                    new JArray(
                        new JObject(
                            new JProperty(Variable.GachaId, GachaId),
                            new JProperty(Variable.GachaSubId, GachaDetailId),
                            new JProperty(Variable.GachaRepeat, Repeat),
                            new JProperty(Variable.GachaCost_zJ1A6HXm, TicketType)))));
            var unitList = GachaSummon[GameObject.GachaExe][0][Variable.GachaUnitList].ToString().Split(new char[1] { ',' });
            var newUnits = new List<Unit>();

            if (Locale != "JP")
            {
                foreach (var unitToken in unitList)
                {
                    var parts = unitToken.Split(new char[1] { ':' });
                    if (parts[0] == "23")
                    {
                        Logger.Out(unitToken);
                        continue;
                    }
                    if (parts[0] == "20")
                    {
                        Logger.Out(Item.Items.First(i => i.ItemId == parts[1]).Name);
                        continue;
                    }
                    var unitId = parts[1];
                    var unit = new Unit
                    {
                        Name = Unit.Units.First(u => u.UnitId == unitId).Name,
                        UniqueUnitId = parts[2],
                        UnitId = unitId,
                        Rarity = UInt16.Parse(unitId.Substring(unitId.Length - 1)).ToString(),
                        Tmr = "0",
                        Level = "1"
                    };
                    newUnits.Add(unit);
                    Units.Add(unit);
                }
                newUnits = newUnits.OrderByDescending(u => u.Rarity).ToList();
                var distinct = newUnits.Select(a => a.Name).Distinct();
                foreach (var d in distinct)
                    Logger.Out(d + " : " + newUnits.Count(a => a.Name == d));
            }
            
            return newUnits;
        }
        public void GetMail()
        {
            var MailList = Network.SendPacket(Request.MailList);
            var MailReceipt = Network.SendPacket(Request.MailReceipt,
                new JProperty(Variable.MailReceipt,
                    new JArray(
                        new JObject(
                            new JProperty("gSEN0jb7", "2")))));
        }
        public void TownRequest(String townId, Boolean leave)
        {
            var req = Request.TownIn;
            if (leave)
                req = Request.TownOut;
            var resp = Network.SendPacket(req,
                new JProperty(Variable.TownInfo,
                    new JArray(
                        new JObject(
                            new JProperty(Variable.TownId, townId)))));
        }
        
        public JObject DoMission(Mission mission, Boolean useFriend = false, String itemHax = null, String equipHax = null, String materiaHax = null, UInt16 SleepTime = 0)
        {
            JToken reinforcement = null;
            if (useFriend)
            {
                var FriendList = Network.SendPacket(Request.FriendList);
                var friends = FriendList[GameObject.FriendUnitInfo_2vuhy0Ex].ToString().Split(new char[1] { ',' }).ToList().Select(s => s.Split(new char[1] { ':' })[0]).ToList();
                var unavailableFriends = FriendList[GameObject.OpeFriendInfo][0][Variable.FriendIdOnCooldown].ToString().Split(new char[1] { ',' }).ToList();
                friends.RemoveAll(f => unavailableFriends.Contains(f));
                var friendUnits = FriendList[GameObject.FriendUnitInfo_2vuhy0Ex].ToList();//.FindAll(f => friends.Contains(f[Variable.FriendId].ToString()));
                reinforcement = friendUnits.FirstOrDefault();// f => f[Variable.LastAccessBase].ToString().Contains(Unit.Maxwell.UnitId) || f[Variable.LastAccessBase].ToString().Contains(Unit.Vargas.UnitId));
            }

            var MissionStart = new JObject(new JProperty(Variable.MissionId, mission.MissionId));
            if (reinforcement != null)
                MissionStart.Add(Variable.ReinforcementFriendId, reinforcement?[Variable.FriendId].ToString());
            MissionStart.Add(Variable.FriendPoints, reinforcement == null ? "0" : "10");
            if (reinforcement != null)
                MissionStart.Add(Variable.ReinforcementUnitId, reinforcement?[Variable.UnitId].ToString());
            MissionStart.Add(Variable.BonusUnit, "0");

            var request = Request.MissionStart;
            if (mission.MissionType == "1")
                request = Request.MissionWaveStart;
            var MissionInfo = Network.SendPacket(request, new JProperty(Variable.Mission, new JArray(MissionStart)));
            //var missioninfodecode = DecodePacket(MissionInfo);
            Thread.Sleep(SleepTime);

            var MonsterMst = MissionInfo[GameObject.MonsterMst];
            var EncounteredMonsters = String.Join(",", MonsterMst.Select(b => b[Variable.MonsterId].ToString()).Distinct());
            var BattleGroupMst = MissionInfo[GameObject.BattleGroupMst];
            var UniqueMonstersKilled = BattleGroupMst.Select(b => b[Variable.MonsterPartId].ToString()).Distinct();
            var MonsterKilledCount = new List<String>();
            foreach (var monsterKilled in UniqueMonstersKilled)
                MonsterKilledCount.Add(monsterKilled + ":" + BattleGroupMst.Count(b => b[Variable.MonsterPartId].ToString() == monsterKilled.ToString()));
            var MonstersKilledCount = String.Join(",", MonsterKilledCount);
            var MonsterPart = new List<String>();
            foreach (var killed in UniqueMonstersKilled)
                MonsterPart.Add(killed + ":1");
            var MonsterParts = String.Join(",", MonsterPart);

            var WaveBattleInfo = MissionInfo[GameObject.WaveBattleInfo];
            var EncountInfo = MissionInfo[GameObject.EncountInfo];
            var ScenarioBattleInfo = MissionInfo[GameObject.ScenarioBattleInfo];
            var BattleInfo = new List<JToken> { WaveBattleInfo, EncountInfo, ScenarioBattleInfo };
            var itemCount = new Dictionary<String, UInt16>();
            var itemStolenCount = new Dictionary<String, UInt16>();
            var possibleDropTypes = new List<String> { Variable.MonsterDrops, Variable.MonsterSpecialDrops };
            var unitDrops = new List<String>();

            var MonsterPartsMst = MissionInfo[GameObject.MonsterPartsMst];
            var MonstersKilled = MonsterPartsMst.Select(b => b[Variable.MonsterPartId].ToString());
            var Experience = 0;
            var Gil = 0;
            var StolenGil = 0;
            float TotalDamage = 0;
            foreach (var battle in BattleInfo)
            {
                if (battle == null)
                    continue;
                foreach (var enemy in battle)
                {
                    foreach (var dropType in possibleDropTypes)
                    {
                        if (enemy[dropType] != null && enemy[dropType].ToString().Length > 0)
                        {
                            var parts = enemy[dropType].ToString().Split(new char[1] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                            var id = parts[1];
                            var count = UInt16.Parse(parts[2]);
                            if (itemCount.ContainsKey(id))
                                itemCount[id] += count;
                            else
                                itemCount.Add(id, count);
                        }
                    }
                    if (enemy[Variable.MonsterUnitDrops] != null && enemy[Variable.MonsterUnitDrops].ToString().Length > 0)
                    {
                        unitDrops.Add(enemy[Variable.MonsterUnitDrops].ToString());
                    }
                    var monsterPart = MonsterPartsMst.First(m => m[Variable.MonsterPartId].ToString() == enemy[Variable.MonsterPartId].ToString());
                    if (monsterPart[Variable.MonsterSteal] != null && monsterPart[Variable.MonsterSteal].ToString().Length > 0)
                    {
                        var items = monsterPart[Variable.MonsterSteal].ToString().Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var item in items)
                        {
                            var parts = item.Split(new char[1] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                            var id = parts[1];
                            var count = UInt16.Parse(parts[2]);
                            if (itemStolenCount.ContainsKey(id))
                                itemStolenCount[id] += count;
                            else
                                itemStolenCount.Add(id, count);

                        }
                    }
                    Experience += Int32.Parse(monsterPart[Variable.Experience].ToString());
                    Gil += Int32.Parse(monsterPart[Variable.Gil].ToString());
                    TotalDamage += Int32.Parse(monsterPart[Variable.MonsterHp].ToString());
                    StolenGil += Int32.Parse(monsterPart[Variable.MonsterStealGil].ToString());
                }
            }
            var UnitsDropped = String.Join(",", unitDrops);
            var ItemsDropped = String.Join(",", itemCount.Select(k => "20:" + k.Key + ":" + k.Value));
            var ItemsStolen = String.Join(",", itemStolenCount.Select(k => "20:" + k.Key + ":" + k.Value));
            TotalDamage = new Random().Next((int)(TotalDamage * 1.05f), (int)(TotalDamage * 1.45f));

            var FieldTreasureMst = MissionInfo[GameObject.FieldTreasureMst];
            var itemsTreasure = new List<String>();
            var equipmentTreasure = new List<String>();
            var recipeTreasure = new List<String>();
            var newSwitches = new List<String>();
            if (FieldTreasureMst != null)
            {
                foreach (var fieldTreasure in FieldTreasureMst)
                {
                    var switchId = fieldTreasure[Variable.GrantedSwitchId].ToString();
                    if (CompletedSwitch(switchId))
                        continue;
                    var item = fieldTreasure[Variable.FieldTreasureItem].ToString();
                    item = item.Substring(0, item.LastIndexOf(":") + 1) + switchId;
                    newSwitches.Add(switchId);
                    if (item.StartsWith("20"))
                        itemsTreasure.Add(item);
                    else if (item.StartsWith("21"))
                        equipmentTreasure.Add(item);
                    else if (item.StartsWith("60"))
                        recipeTreasure.Add(item);
                    else
                        Logger.Out("need to add important item treasure");
                }
            }
            var ItemsTreasure = String.Join(",", itemsTreasure);
            var EquipmentTreasure = String.Join(",", equipmentTreasure);
            var RecipeTreasure = String.Join(",", recipeTreasure);
            var NewSwitches = String.Join(",", newSwitches);

            int encounterIdOrder = 1;
            var EncounterIds = String.Join(",", BattleGroupMst.Select(b => "0" + ":" + b[Variable.MissionWaveId].ToString() + ":1").Distinct());
            if (mission.MissionType == "1")
                EncounterIds = String.Join(",", BattleGroupMst.Select(b => b[Variable.MissionWaveId].ToString()).Distinct().Select(b => encounterIdOrder++ + ":" + b + ":1"));
            var ItemsFound = "";
            if (MissionInfo[GameObject.HarvestDetailInfo] != null)
                ItemsFound = String.Join(",", MissionInfo[GameObject.HarvestDetailInfo]?.Select(h => h[Variable.HarvestItem].ToString().Substring(0, h[Variable.HarvestItem].ToString().LastIndexOf(":"))));
            var EncounterId = String.Join(",", BattleGroupMst.Select(b => "0:" + b[Variable.MissionWaveId].ToString() + ":0").Distinct());
            if (mission.MissionType == "1")
                EncounterId = "";

            Logger.Out("XP : " + Experience);
            Logger.Out("Gil : " + Gil);
            foreach (var item in itemCount)
                Logger.Out("Enemy dropped item : " + Item.Items.FindAll(i => i.ItemId != null).First(i => item.Key.Contains(i.ItemId)).Name + " : " + item.Value);
            foreach (var item in itemStolenCount)
                Logger.Out("Enemy stolen item : " + Item.Items.FindAll(i => i.ItemId != null).First(i => item.Key.Contains(i.ItemId)).Name + " : " + item.Value);
            foreach (var item in itemsTreasure)
                Logger.Out("Treasure item : " + Item.Items.FindAll(i => i.ItemId != null).First(i => item.Contains(i.ItemId)).Name);
            var ih = ItemsFound.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in ih)
                Logger.Out("Stage dropped item : " + Item.Items.FindAll(i => i.ItemId != null).First(i => item.Contains(i.ItemId)).Name);
            foreach (var unit in unitDrops)
                Logger.Out("Enemy dropped unit : " + Unit.Units.FindAll(i => i.UnitId != null).First(i => unit.Contains(i.UnitId)).Name);
            foreach (var eq in equipmentTreasure)
                Logger.Out("Treasure equipment : " + Equipment.Equipments.FindAll(i => i.EquipId != null).First(i => eq.Contains(i.EquipId)).Name);
            foreach (var r in recipeTreasure)
                Logger.Out("Treasure equipment : " + Recipe.Recipes.FindAll(i => i.RecipeBookId != null).First(i => r.Contains(i.RecipeBookId)).Name);

            var MissionComplete = new JObject(new JProperty(Variable.MissionId, mission.MissionId));
            if (newSwitches.Count > 0)
                MissionComplete.Add(Variable.GrantedSwitchId, NewSwitches);
            if (reinforcement != null)
                MissionComplete.Add(Variable.FriendId, reinforcement?[Variable.FriendId].ToString());

            var limitParty = int.Parse(GetUserInfo[GameObject.UserActualInfo].First()[Variable.CurrentParty].ToString());
            var limitParty2 = GetUserInfo[GameObject.UserPartyDeckInfo_5Eb0Rig6][limitParty];
            var limitPartyUnits = limitParty2[Variable.PartyUnits].ToString().Split(new char[1] { ',' });
            var limitPartyFinishedUnits = limitPartyUnits.Select(u => Units.FirstOrDefault(unit => unit.UniqueUnitId == u.Split(new char[1] { ':' }).Last())).ToList();

            var MissionResult = new JObject(
                new JProperty(Variable.UnitExperience, Experience.ToString()),
                new JProperty("ZGSr7T06", "0"),
                new JProperty(Variable.BonusGil, Gil.ToString()),
                new JProperty(Variable.StolenGil, StolenGil.ToString()),
                new JProperty("8CfoLQv5", "0"),
                new JProperty("wQhu9G7n", "0"));
            if (!String.IsNullOrEmpty(ItemsDropped))
                MissionResult.Add(Variable.ItemsDropped, ItemsDropped);
            if (!String.IsNullOrEmpty(ItemsStolen))
                MissionResult.Add(Variable.ItemsStolen, ItemsStolen);
            if (!String.IsNullOrEmpty(ItemsTreasure))
                MissionResult.Add(Variable.ItemsTreasure, ItemsTreasure);
            if (!String.IsNullOrEmpty(ItemsFound))
                MissionResult.Add(Variable.ItemsFound, ItemsFound);
            if (!String.IsNullOrEmpty(EquipmentTreasure))
                MissionResult.Add(Variable.EquipmentTreasure, EquipmentTreasure);
            if (!String.IsNullOrEmpty(RecipeTreasure))
                MissionResult.Add("R1kg3EBA", RecipeTreasure);
            if (!String.IsNullOrEmpty(UnitsDropped))
                MissionResult.Add(Variable.UnitsDropped, UnitsDropped);
            if (!String.IsNullOrEmpty(itemHax))
                MissionResult.Add(Variable.ItemsTrusted, itemHax);
            if (!String.IsNullOrEmpty(equipHax))
                MissionResult.Add(Variable.EquipmentTrusted, equipHax);
            if (!String.IsNullOrEmpty(materiaHax))
                MissionResult.Add(Variable.MateriaTrusted, materiaHax);
            MissionResult.Add("7a1Ugx4e", "0");
            MissionResult.Add("t4v2o0zM", "0");
            MissionResult.Add("PB3vLE2r", "0");
            MissionResult.Add("aK4k1PvY", "0");
            MissionResult.Add("NCFk6Zv1", "0");
            MissionResult.Add("A90DrNfp", limitPartyFinishedUnits[0].UniqueUnitId + ":71400," + limitPartyFinishedUnits[1].UniqueUnitId + ":71400," + limitPartyFinishedUnits[2].UniqueUnitId + ":71400," + limitPartyFinishedUnits[3].UniqueUnitId + ":71400," + limitPartyFinishedUnits[4].UniqueUnitId + ":71400");
            if (EncounterId != "")
                MissionResult.Add(Variable.EncounterId, EncounterId);
            MissionResult.Add(Variable.EncounteredMonsters, EncounteredMonsters);
            MissionResult.Add(Variable.MonstersKilledCount, MonstersKilledCount);
            MissionResult.Add(Variable.MonsterParts, MonsterParts);

            var MissionStatistics = new JArray
            {
                new JObject(new JProperty(Variable.ArchiveName, "MAX_DAMAGE_TURN"),
                                             new JProperty(Variable.ArchiveValue, ((Int32)TotalDamage / 4).ToString())),
                new JObject(new JProperty(Variable.ArchiveName, "TOTAL_DAMAGE"),
                                             new JProperty(Variable.ArchiveValue, ((Int32)TotalDamage).ToString())),
                new JObject(new JProperty(Variable.ArchiveName, "TOTAL_LB_CRISTAL"),
                                             new JProperty(Variable.ArchiveValue, "12")),
                new JObject(new JProperty(Variable.ArchiveName, "MAX_CHAIN_TURN"),
                                             new JProperty(Variable.ArchiveValue, "0")),
                new JObject(new JProperty(Variable.ArchiveName, "MAX_SPARK_CHAIN_TURN"),
                                             new JProperty(Variable.ArchiveValue, "0")),
                new JObject(new JProperty(Variable.ArchiveName, "MAX_ELEMENT_CHAIN_TURN"),
                                             new JProperty(Variable.ArchiveValue, "0")),
                new JObject(new JProperty(Variable.ArchiveName, "MAX_DAMAGE_HIT"),
                                             new JProperty(Variable.ArchiveValue, ((Int32)TotalDamage / 4).ToString())),
                new JObject(new JProperty(Variable.ArchiveName, "MAX_ELEMENT_CHAIN_TURN"),
                                             new JProperty(Variable.ArchiveValue, "0")),
                new JObject(new JProperty(Variable.ArchiveName, "TOTAL_MISSION_BATTLE_WIN"),
                                             new JProperty(Variable.ArchiveValue, EncounterIds.Split(new char[1] { ',' }).Count().ToString())),
                new JObject(new JProperty(Variable.ArchiveName, "TOTAL_LB_USE"),
                                             new JProperty(Variable.ArchiveValue, "357000")),
                new JObject(new JProperty(Variable.ArchiveName, "TOTAL_STEPS"),
                                             new JProperty(Variable.ArchiveValue, "530")),
                new JObject(new JProperty(Variable.ArchiveName, "MAX_LB_CRISTAL"),
                                             new JProperty(Variable.ArchiveValue, "10"))
            };

            var MissionChallenge = new JObject();
            var challenges = Challenge.Challenges.FindAll(c => c.MissionId == mission.MissionId);
            foreach (var challenge in challenges)
            {
                //68 complete
                //33 no deaths
                //38 no continues
                //1 no items
                //6 no magic
                //12 no recovery magic
                //14 no magic of type
                //17 no lb
                //75::x number of turns
                //77::x boss number of turns
                //40::x no more than items
                //29 no espers
                //69 exclude rain/lasswell 2001
                //20 no abilities
                if (challenge.ChallengeRequirement.StartsWith("34:"))
                {
                    var partyOfAtleast = challenge.ChallengeRequirement.Split(new char[1] { ':' })[1]; // +1
                }
                else if (challenge.ChallengeRequirement.StartsWith("35:"))
                {
                    var partyOfLessThan = challenge.ChallengeRequirement.Split(new char[1] { ':' })[1];
                }
                else if (challenge.ChallengeRequirement.StartsWith("36:"))
                {
                    var requiresUnit = challenge.ChallengeRequirement.Split(new char[1] { ':' })[1];
                }
                else if (challenge.ChallengeRequirement.StartsWith("18:") || challenge.ChallengeRequirement.StartsWith("16:") || challenge.ChallengeRequirement.StartsWith("49:"))
                {
                    //var KillBossWithLbObj = BattleGroupMst.OrderByDescending(b => b[Variable.MissionWaveId].ToString()).First();
                    //var KillBossWithLb = KillBossWithLbObj[Variable.MissionWaveId].ToString() + "@" + KillBossWithLbObj[Variable.MonsterPartId].ToString() + ":1@5:" + "100000102";
                    //MissionChallenge.Add(Variable.LimitBreaks, "100000102:6");
                    // MissionChallenge.Add(Variable.KnockOuts, "");
                }
                else if (challenge.ChallengeRequirement.StartsWith("15:")) // magic
                {
                    //var KillBossWithLbObj = BattleGroupMst.OrderByDescending(b => b[Variable.MissionWaveId].ToString()).First();
                    //var KillBossWithLb = KillBossWithLbObj[Variable.MissionWaveId].ToString() + "@" + KillBossWithLbObj[Variable.MonsterPartId].ToString() + ":1@5:" + "100000102";
                }
                else if (challenge.ChallengeRequirement.StartsWith("32:") || challenge.ChallengeRequirement.StartsWith("28")) // esper
                {
                    //MissionChallenge.Add(Variable.Espers, "100000102:6");
                    //MissionChallenge.Add(Variable.KnockOuts, "100000102:6");
                    //var KillBossWithLbObj = BattleGroupMst.OrderByDescending(b => b[Variable.MissionWaveId].ToString()).First();
                    //var KillBossWithLb = KillBossWithLbObj[Variable.MissionWaveId].ToString() + "@" + KillBossWithLbObj[Variable.MonsterPartId].ToString() + ":1@5:" + "100000102";
                }
                else if (challenge.ChallengeRequirement.StartsWith("30:"))
                {
                    var esper = challenge.ChallengeRequirement.Split(new char[1] { ':' })[1];
                }
                else if (challenge.ChallengeRequirement.StartsWith("45:"))
                {
                    var espers = challenge.ChallengeRequirement.Split(new char[1] { ':' })[1]; // +1
                }
                else if (challenge.ChallengeRequirement.StartsWith("26:"))
                {
                    var damageType = challenge.ChallengeRequirement.Split(new char[1] { ':' })[1];
                }
                else if (challenge.ChallengeRequirement.StartsWith("7:"))
                {
                    var cast = challenge.ChallengeRequirement.Split(new char[1] { ':' })[1];
                }
                else if (challenge.ChallengeRequirement.StartsWith("21:"))
                {
                    var ability = challenge.ChallengeRequirement.Split(new char[1] { ':' })[1];
                }
                else if (challenge.ChallengeRequirement.StartsWith("2:"))
                {
                    var item = challenge.ChallengeRequirement.Split(new char[1] { ':' })[1];
                }
                else if (challenge.ChallengeRequirement.StartsWith("0"))
                {
                    // any item
                }
                else if (challenge.ChallengeRequirement.StartsWith("5"))
                {
                    // magic
                }
                else if (challenge.ChallengeRequirement.StartsWith("41:"))
                {
                    var magics = challenge.ChallengeRequirement.Split(new char[1] { ':' })[1]; // +1
                }
                else if (challenge.ChallengeRequirement.StartsWith("59:"))
                {
                    var type = challenge.ChallengeRequirement.Split(new char[1] { ':' })[1];
                    var magics = challenge.ChallengeRequirement.Split(new char[1] { ':' })[2]; // +1
                }
                else if (challenge.ChallengeRequirement.StartsWith("47:"))
                {
                    var type = challenge.ChallengeRequirement.Split(new char[1] { ':' })[1];
                    var magics = challenge.ChallengeRequirement.Split(new char[1] { ':' })[2]; // +1
                }
                else if (challenge.ChallengeRequirement.StartsWith("13:"))
                {
                    var magicType = challenge.ChallengeRequirement.Split(new char[1] { ':' })[1]; //2 bm, 1 wm
                }
                else if (challenge.ChallengeRequirement.StartsWith("76:"))
                {
                    var atleastTurns = challenge.ChallengeRequirement.Split(new char[1] { ':' })[2]; // +1
                }
            }
            MissionChallenge.Add(Variable.DeadCount, "0");
            MissionChallenge.Add(Variable.BattleClear, EncounterIds);

            var inputList = new List<JProperty>
            {
                new JProperty(Variable.Mission, new JArray(MissionComplete)),
                new JProperty(GameObject.MissionResult, new JArray(MissionResult)),
                new JProperty(GameObject.UserArchiveInfo, MissionStatistics),
                new JProperty(Variable.MissionEndChallenge, new JArray(new JObject(MissionChallenge))),
                new JProperty(new JProperty(Variable.MissionEndContinue, new JArray(new JObject(new JProperty(Variable.Count, "0")))))
            };
            if (GetUserInfo != null)
                inputList.Add(new JProperty(GameObject.UserCarryItemInfo, new JArray(new JObject(new JProperty(Variable.Items_jsvoa0I2, GetUserInfo[GameObject.UserCarryItemInfo][0][Variable.Items_jsvoa0I2].ToString())))));
            
            var MissionEnd = Network.SendPacket(Request.MissionEnd, inputList);
            return MissionEnd;
        }
        public void LevelUnit(Unit unit)
        {
            var maxRarity = Unit.Units.First(u => u.UnitId == unit.UnitId).Rarity;
            if (unit.Rarity == maxRarity && unit.Level == unit.UnitMaxLevel)
                return;
            SetParty(unit.UniqueUnitId, 4);
            Thread.Sleep(3000);
            var materia = String.Join("@", Enumerable.Range(1, int.Parse(Unit.Units.First(u => u.UnitId == unit.UnitId).MateriaSlots) + 1).Select(m => m + "-" + Materia.Action.MateriaId));
            SetEquipment(unit.UniqueUnitId, "1-0@2-0@3-0@4-0@5-" + Equipment.GrowthEgg.EquipId + "@6-" + Equipment.GrowthEgg.EquipId, materia);
            Thread.Sleep(3000);
            while (true)
            {
                var first = true;
                do
                {
                    var itemHax = "";
                    if (first)
                    {
                        var classup = ClassUp.ClassUps.FirstOrDefault(c => c.UnitId == unit.UnitId);
                        itemHax = classup?.Items;
                        first = false;
                    }
                    var missionResults = DoMission(Mission.TheFarplane_2000201, false, itemHax, null, null, 3000);
                    unit.Level = missionResults[GameObject.UserUnitInfo_8gSkPD6b][0][Variable.Level].ToString();
                    Thread.Sleep(3000);
                } while (unit.Level != unit.UnitMaxLevel);
                if (unit.Rarity == maxRarity)
                    break;
                var unitClassUp = Network.SendPacket(Request.UnitClassUp,
                    new JProperty(GameObject.UnitClassUp,
                        new JArray(
                            new JObject(
                                new JProperty(Variable.UniqueUnitId, unit.UniqueUnitId)))));
                Thread.Sleep(3000);
                unit.Rarity = (int.Parse(unit.Rarity) + 1).ToString();
                unit.Level = "1";
                unit.UniqueUnitId = unitClassUp[GameObject.UnitClassUp].First()["5u7VYNEX"].ToString();
                unit.UnitId = unitClassUp[GameObject.UserUnitInfo_8gSkPD6b][0][Variable.UnitId].ToString();
                materia = String.Join("@", Enumerable.Range(1, int.Parse(Unit.Units.First(u => u.UnitId == unit.UnitId).MateriaSlots) + 1).Select(m => m + "-" + Materia.Action.MateriaId));
                SetEquipment(unit.UniqueUnitId, "1-0@2-0@3-0@4-0@5-" + Equipment.GrowthEgg.EquipId + "@6-" + Equipment.GrowthEgg.EquipId, materia);
                Thread.Sleep(3000);
            }
            var oldUnit = GetUserInfo[GameObject.UnitEquip_TJ9eL80N].FirstOrDefault(e => e[Variable.UniqueUnitId].ToString() == unit.UniqueUnitId);
            var oldEquipment = oldUnit?[Variable.Equipment].ToString();
            var oldMateria = oldUnit?[Variable.Materia].ToString();
            SetEquipment(unit.UniqueUnitId, oldEquipment, oldMateria);
        }
        public void LevelParty(Func<string, int> update)
        {
            var growtheggs = "21:" + Equipment.GrowthEgg.EquipId + ":10";
            var actions = "22:" + Materia.Action.MateriaId + ":20";
            DoMission(Mission.AirshipDeck, false, null, growtheggs, actions);
            var currentPary = int.Parse(GetUserInfo[GameObject.UserActualInfo].First()[Variable.CurrentParty].ToString());
            var party = GetUserInfo[GameObject.UserPartyDeckInfo_5Eb0Rig6][currentPary];
            var partyUnits = party[Variable.PartyUnits].ToString().Split(new char[1] { ',' });
            var units = partyUnits.Select(u => Units.FirstOrDefault(unit => unit.UniqueUnitId == u.Split(new char[1] { ':' }).Last())).ToList();
            var growthEggEquip = String.Join(",", units.Select(u => u.UniqueUnitId + ":1-0@2-0@3-0@4-0@5-" + Equipment.GrowthEgg.EquipId + "@6-" + Equipment.GrowthEgg.EquipId));
            var actionEquip = String.Join(",", units.Select(u => u.UniqueUnitId + ":" +  String.Join("@", Enumerable.Range(1, int.Parse(Unit.Units.First(u2 => u2.UnitId == u.UnitId).MateriaSlots)).Select(m => m + "-" + Materia.Action.MateriaId))));
            Network.SendPacket(Request.UnitEquip,
                new JProperty(GameObject.UnitEquip_Er92Kdhm, new JArray(new JObject(
                    new JProperty(Variable.Equipment, growthEggEquip),
                    new JProperty(Variable.Materia, actionEquip)))));
            Thread.Sleep(3000);
            Dictionary<Item, int> awakenItems = new Dictionary<Item, int>();
            units.ForEach(unit =>
            {
                var classup = ClassUp.ClassUps.FirstOrDefault(c => c.UnitId == unit.UnitId);
                if (classup != default(ClassUp))
                {
                    var itemList = ClassUp.ClassUps.First(c => c.UnitId == unit.UnitId).Items.Split(new char[1] { ',' }).Select(i => new KeyValuePair<Item, int>(Item.Items.First(item => item.ItemId == i.Split(new char[1] { ':' })[1]), int.Parse(i.Split(new char[1] { ':' }).Last()))).ToList();
                    itemList.ForEach(item =>
                    {
                        if (awakenItems.ContainsKey(item.Key))
                            awakenItems[item.Key] += item.Value;
                        else
                            awakenItems.Add(item.Key, item.Value);
                    });
                }
            });
            var needsLeveling = !units.All(u => u.Level == u.UnitMaxLevel && u.Rarity == Unit.Units.FindAll(u2 => u.BaseUnitId == u2.BaseUnitId).Max(u2 => int.Parse(u2.Rarity)).ToString());
            while (needsLeveling)
            {
                update(String.Join("\r\n", units.Select(u => u.Name + " " + u.Rarity + "*" + " level " + u.Level)));
                var itemHax = String.Join(",", awakenItems.Select(i => "20:" + i.Key.ItemId + ":" + i.Value));
                var missionResults = DoMission(Mission.TheFarplane_2000201, false, itemHax, null, null, 3000);
                awakenItems.Clear();
                units.ForEach(unit =>
                {
                    unit.Level = missionResults[GameObject.UserUnitInfo_8gSkPD6b].First(r => r[Variable.UniqueUnitId].ToString() == unit.UniqueUnitId)[Variable.Level].ToString();
                    if (unit.Level == unit.UnitMaxLevel && unit.Rarity != Unit.Units.FindAll(u2 => unit.BaseUnitId == u2.BaseUnitId).Max(u2 => int.Parse(u2.Rarity)).ToString())
                    {
                        var unitClassUp = Network.SendPacket(Request.UnitClassUp,
                            new JProperty(GameObject.UnitClassUp,
                                new JArray(
                                    new JObject(
                                        new JProperty(Variable.UniqueUnitId, unit.UniqueUnitId)))));
                        Thread.Sleep(3000);
                        var oldBaseUnit = Unit.Units.First(u2 => u2.UnitId == unit.UnitId);
                        unit.UnitId = unitClassUp[GameObject.UserUnitInfo_8gSkPD6b][0][Variable.UnitId].ToString();
                        var newBaseUnit = Unit.Units.First(u2 => u2.UnitId == unit.UnitId);
                        unit.Rarity = newBaseUnit.Rarity;
                        unit.Level = "1";
                        unit.UnitMaxLevel = newBaseUnit.UnitMaxLevel;
                        unit.UniqueUnitId = unitClassUp[GameObject.UnitClassUp].First()["5u7VYNEX"].ToString();
                        var oldActionEquip = String.Join("@", Enumerable.Range(0, int.Parse(oldBaseUnit.MateriaSlots)).Select(m => m + "-" + Materia.Action.MateriaId));
                        var newActionEquip = String.Join("@", Enumerable.Range(0, int.Parse(newBaseUnit.MateriaSlots)).Select(m => m + "-" + Materia.Action.MateriaId));
                        if (newActionEquip != oldActionEquip)
                        {
                            SetEquipment(unit.UniqueUnitId, "1-0@2-0@3-0@4-0@5-" + Equipment.GrowthEgg.EquipId + "@6-" + Equipment.GrowthEgg.EquipId, newActionEquip);
                            Thread.Sleep(3000);
                        }

                        var classup = ClassUp.ClassUps.FirstOrDefault(c => c.UnitId == unit.UnitId);
                        if (classup != default(ClassUp))
                        {
                            var itemList = ClassUp.ClassUps.First(c => c.UnitId == unit.UnitId).Items.Split(new char[1] { ',' }).Select(i => new KeyValuePair<Item, int>(Item.Items.First(item => item.ItemId == i.Split(new char[1] { ':' })[1]), int.Parse(i.Split(new char[1] { ':' }).Last()))).ToList();
                            itemList.ForEach(item =>
                            {
                                if (awakenItems.ContainsKey(item.Key))
                                    awakenItems[item.Key] += item.Value;
                                else
                                    awakenItems.Add(item.Key, item.Value);
                            });
                        }
                    }
                });
                needsLeveling = !units.All(u => u.Level == u.UnitMaxLevel && u.Rarity == Unit.Units.FindAll(u2 => u.BaseUnitId == u2.BaseUnitId).Max(u2 => int.Parse(u2.Rarity)).ToString());
                Thread.Sleep(3000);
            }
            growthEggEquip = String.Join(",", units.Select(u => u.UniqueUnitId + ":1-0@2-0@3-0@4-0@5-0@6-0"));
            actionEquip = String.Join(",", units.Select(u => u.UniqueUnitId + ":" + String.Join("@", Enumerable.Range(1, int.Parse(Unit.Units.First(u2 => u2.UnitId == u.UnitId).MateriaSlots)).Select(m => m + "-0"))));
            Network.SendPacket(Request.UnitEquip,
                new JProperty(GameObject.UnitEquip_Er92Kdhm, new JArray(new JObject(
                    new JProperty(Variable.Equipment, growthEggEquip),
                    new JProperty(Variable.Materia, actionEquip)))));
            Thread.Sleep(3000);
            Network.SendPacket(Request.ItemSell, new JProperty(Variable.ItemSell, new JArray(new JObject(
                new JProperty(Variable.StoreItemSellId, "21:" + Equipment.GrowthEgg.EquipId + ":10,22:" + Materia.Action.MateriaId + ":20"),
                new JProperty(Variable.StoreItemSellPrice, (int.Parse(Equipment.GrowthEgg.ItemSellPrice) * 10 + int.Parse(Materia.Action.ItemSellPrice) * 20).ToString())))));
            Thread.Sleep(3000);
        }
        public JObject SetParty(String unitId, Int32 partyId)
        {
            var partyDeckInfo = GetUserInfo[GameObject.UserPartyDeckInfo_5Eb0Rig6][partyId];
            partyDeckInfo[Variable.PartyUnits] = "0:1:" + unitId;
            var PartyDeckEdit = Network.SendPacket(Request.PartyDeckEdit,
                    new JProperty(Variable.PartySelect, new JArray(new JObject(
                            new JProperty(Variable.PartyId, partyId.ToString()),
                            new JProperty(Variable.CurrentParty, partyId.ToString()),
                            new JProperty(Variable.CompanionParty, GetUserInfo[GameObject.UserActualInfo][0][Variable.CompanionParty].ToString()),
                            new JProperty(Variable.ColosseumParty, GetUserInfo[GameObject.UserActualInfo][0][Variable.ColosseumParty].ToString()),
                            new JProperty(Variable.ArenaParty, GetUserInfo[GameObject.UserActualInfo][0][Variable.ArenaParty].ToString())))),
                    new JProperty(GameObject.UserPartyDeckInfo_5Eb0Rig6, GetUserInfo[GameObject.UserPartyDeckInfo_5Eb0Rig6]),
                    new JProperty(GameObject.UserBeastDeckInfo_49rQB3fP, GetUserInfo[GameObject.UserBeastDeckInfo_49rQB3fP]));
            return PartyDeckEdit;
        }
        public void SetEquipment(String unitId, String equipment, String materia)
        {
            Network.SendPacket(Request.UnitEquip,
                new JProperty(GameObject.UnitEquip_Er92Kdhm, new JArray(new JObject(
                    new JProperty(Variable.Equipment, unitId + ":" + equipment),//1-0@2-0@3-0@4-0@5-409005000@6-409005000"),
                    new JProperty(Variable.Materia, unitId + ":" + materia)))));//1-504204260@2-504204260@3-0@4-0")))));
        }
        public void UpdateSwitch(String switches)
        {
            var UpdateSwitchInfo = Network.SendPacket(Request.UpdateSwitchInfo, new JProperty("0jqUZuT1", new JArray(new JObject(new JProperty(Variable.GrantedSwitchId, switches)))));
        }
        public void Initialize()
        {
            var Initialize = Network.SendPacket(Request.Initialize);
            if (Initialize[GameObject.VersionInfo] != null)
            {
                if (Initialize[GameObject.VersionInfo].Count(f => f[Variable.KeyName].ToString().Contains("F_APP_VERSION")) > 0)
                {
                    AppVersion = (Initialize[GameObject.VersionInfo].First(f => f[Variable.KeyName].ToString().Contains("F_APP_VERSION")))[Variable.Value].ToString();
                    Initialize = Network.SendPacket(Request.Initialize);
                }
                if (Initialize[GameObject.VersionInfo].Count(f => f[Variable.KeyName].ToString() == "F_MST_VERSION") > 0)
                {
                    MstVersion = (Initialize[GameObject.VersionInfo].First(f => f[Variable.KeyName].ToString() == "F_MST_VERSION"))[Variable.Value].ToString();
                    Initialize = Network.SendPacket(Request.Initialize);
                }
                if (Locale == "JP" && Initialize[GameObject.VersionInfo].Count(f => f[Variable.KeyName].ToString() == "F_RSC_VERSION") > 0)
                {
                    RscVersion = (Initialize[GameObject.VersionInfo].First(f => f[Variable.KeyName].ToString() == "F_RSC_VERSION"))[Variable.Value].ToString();
                    Initialize = Network.SendPacket(Request.Initialize);
                }
            }
            if (String.IsNullOrEmpty(Initialize[GameObject.UserInfo][0][Variable.UserId].ToString()))
                Initialize = Network.SendPacket(Request.CreateUser);
            var userInfo = Initialize[GameObject.UserInfo][0];
            UserId = userInfo[Variable.UserId].ToString();
            UserName = userInfo[Variable.UserName].ToString();
            FriendCode = userInfo[Variable.FriendId].ToString();
            Password = userInfo[Variable.Password].ToString();
            if (Locale != "JP")
            {
                GumiId = userInfo[Variable.GumiId].ToString();
                GumiToken = userInfo[Variable.GumiToken].ToString();
            }
            ModelChangeCnt = userInfo[Variable.ModelChangeCnt].ToString();
        }
        public JObject UpdateGetUserInfo()
        {
            GetUserInfo = Network.SendPacket(Request.GetUserInfo);
            return GetUserInfo;
        }
        public void UpdateUserName(String name, String msg)
        {
            var update = Network.SendPacket(Request.UpdateUserInfo, new JProperty("MZzST52W", new JArray(new JObject(
                new JProperty(Variable.UserName, name),
                new JProperty(Variable.Gift, "10"),
                new JProperty(Variable.Message, msg)))));
        }
        public void CreateNewAccount()
        {
            GumiId = Guid.NewGuid().ToString();
            GumiToken = Guid.NewGuid().ToString();
            DeviceId = Guid.NewGuid().ToString().ToUpper();
            ContactId = Crypto.Encrypt(DeviceId, "Zy3MDURw");
            AdvertisingId = Guid.NewGuid().ToString().ToUpper();
            UserName = "Rain";
            Initialize();
            UpdateGetUserInfo();
        }
        public void ReRoll()
        {
            CreateNewAccount();
            DoMission(Mission.AirshipDeck);
            Thread.Sleep(30000);
            DoMission(Mission.EarthShrineEntrance);
            Thread.Sleep(30000);
            DoMission(Mission.EarthShrineExit);
            Thread.Sleep(30000);
            UpdateSwitch("10000115");
            UpdateSwitch("10002002");
            UpdateSwitch("10000111,80011002");
            Summon("3", "3001", "2", "0");
            UpdateSwitch("10000209,10003001");
            Network.SendPacket(Request.LoginBonus);
            UpdateSwitch("10000116,10000155");
            GetMail();
            Summon("13", "2015", "1", "1");
            Thread.Sleep(3000);
            Summon("13", "2015", "1", "1");
            Thread.Sleep(3000);
            Summon("13", "2015", "1", "1");
            Thread.Sleep(3000);
            Summon("13", "2015", "1", "1");
            Thread.Sleep(3000);
            Summon("13", "2015", "1", "1");

            var distinct = Unit.Units.Select(a => a.Name).Distinct();
            var unitRarity = new List<Unit>();
            foreach (var d in distinct)
                unitRarity.Add(new Unit { Name = d, Rarity = Unit.Units.FindAll(u => u.Name == d).OrderBy(u => u.Rarity).First().Rarity });
            distinct = unitRarity.OrderByDescending(u => u.Rarity).ToList().Select(a => a.Name);
            if (!File.Exists("accounts.csv"))
            {
                var fileHeader = "id,pw,gid,gt,did,aid,cid,5s,5list";
                foreach (var d in distinct)
                    fileHeader += d + ",";
                fileHeader += "\r\n";
                File.WriteAllText("accounts.csv", fileHeader);
            }
            var accountinfo = UserId + "," + Password + "," + GumiId + "," + GumiToken + "," + DeviceId + "," + AdvertisingId + "," + ContactId + ",";
            accountinfo += Units.Count(a => a.Rarity == "5") + ",";
            accountinfo += String.Join("", Units.FindAll(a => a.Rarity == "5").Select(a => a.Name)) + ",";
            foreach (var d in distinct)
                accountinfo += Units.Count(a => a.Name == d) + ",";
            accountinfo += "\r\n";
            File.AppendAllText("accounts.csv", accountinfo);
        }
        public void ClearArena()
        {
            var orbs = UInt16.Parse(GetUserInfo[GameObject.UserTeamInfo][0][Variable.ColosseumOrb].ToString());
            while (orbs > 0)
            {
                var RbEntry = Network.SendPacket(Request.RbEntry);
                Network.SendPacket(Request.RbMatching,
                    new JProperty(GameObject.OpeRbInfo, RbEntry[GameObject.OpeRbInfo]),
                    new JProperty(GameObject.UserRbMatchingInfo, new JArray(new JObject(
                            new JProperty(Variable.RbEnemyId, RbEntry[GameObject.RbMatchingListInfo][0][Variable.ArenaOpponents].ToString().Substring(0, 9))))));
                var RbStart = Network.SendPacket(Request.RbStart,
                    new JProperty(GameObject.OpeRbInfo, RbEntry[GameObject.OpeRbInfo]),
                    new JProperty(GameObject.UserRbMatchingInfo, new JArray(new JObject(
                            new JProperty(Variable.RbEnemyId, RbEntry[GameObject.RbMatchingListInfo][0][Variable.ArenaOpponents].ToString().Substring(0, 9))))));
                var userPartyDeckInfo = GetUserInfo[GameObject.UserPartyDeckInfo_5Eb0Rig6].First(p => p[Variable.PartyId].ToString() == GetUserInfo[GameObject.UserActualInfo][0][Variable.PartyId].ToString());
                var partyUnits = userPartyDeckInfo[Variable.PartyUnits].ToString().Split(new char[1] { ',' }).Select(s => s.Substring(4));
                List<String> playerDmg = new List<String>();
                Int32 totalDmg = 0;
                foreach (var partyUnit in partyUnits)
                {
                    var unit = Units.First(u => u.UniqueUnitId == partyUnit);
                    var dmg = new Random().Next(9000, 14000);
                    playerDmg.Add(unit.UnitId + ":" + unit.UniqueUnitId + ":" + unit.UnitHp + ":0");
                    totalDmg += dmg;
                }
                var enemyUnits = RbStart[GameObject.UserRbVsInfo][0][Variable.RbEnemyUnitList].ToString().Split(new char[1] { ';' });
                List<String> enemyDmg = new List<String>();
                foreach (var enemyUnit in enemyUnits)
                {
                    var unitInfo = enemyUnit.Split(new char[1] { ':' });
                    enemyDmg.Add(unitInfo[1] + ":" + unitInfo[0] + ":0:1");
                }
                var RbEnd = Network.SendPacket(Request.RbEnd,
                    new JProperty(GameObject.OpeRbInfo, RbEntry[GameObject.OpeRbInfo]),
                    new JProperty(GameObject.RbResult, new JArray(new JObject(
                            new JProperty(Variable.ArenaPlayerDmg, String.Join(",", playerDmg.ToArray())),
                            new JProperty(Variable.ArenaEnemyDmg, String.Join(",", enemyDmg.ToArray())),
                            new JProperty(Variable.ArenaPlayerTotalDmg, totalDmg.ToString()),
                            new JProperty(Variable.ArenaEnemyTotalDmg, "0"),
                            new JProperty(Variable.ArenaResult, "1"),
                            new JProperty(Variable.ArenaTurns, "0"),
                            new JProperty(Variable.ArenaVsFriend, "0")))),
                    new JProperty(GameObject.UserArchiveInfo, new JArray(
                        new JObject(
                            new JProperty(Variable.ArchiveName, "ARENA_TOTAL_DAMAGE"),
                            new JProperty(Variable.Value, totalDmg.ToString())),
                        new JObject(
                            new JProperty(Variable.ArchiveName, "ARENA_TOTAL_LB_CRISTAL"),
                            new JProperty(Variable.Value, new Random().Next(40, 60).ToString())))));
                orbs = UInt16.Parse(RbEnd[GameObject.UserTeamInfo][0][Variable.ColosseumOrb].ToString());
                Thread.Sleep(15000);
            }
        }
        void ClearRaid()
        {
            var orbs = UInt16.Parse(GetUserInfo[GameObject.UserTeamInfo][0][Variable.RaidOrb].ToString());
            while (orbs > 0)
            {
                var RoutineRaidMenuUpdate = Network.SendPacket(Request.RoutineRaidMenuUpdate,
                    new JProperty(Variable.RoutineRaidMenuUpdate, new JArray(new JObject(
                            new JProperty(Variable.DungeonId, Mission.TheMoogleKingsCounterattack.MissionId.Substring(0, Mission.TheMoogleKingsCounterattack.MissionId.Length - 2))))));
                var missionResult = DoMission(Mission.TheMoogleKingsCounterattack, true, null, null, null, 15000);
                orbs = UInt16.Parse(missionResult[GameObject.UserTeamInfo][0][Variable.RaidOrb].ToString());
                Thread.Sleep(15000);
            }
        }
        public void DumpAcc(String userId, String pw, String gumiId, String gumiToken)
        {
            LoginUnlinkedAccount(userId, pw, gumiId, gumiToken);
        }
        public void DumpAcc()
        {
            UpdateUnits();
            var query2 = Units.Select(x => x.Name).GroupBy(x => x, (y, z) => new { Name = y, Count = z.Count() });
            //foreach (var item in query2)
            //    Logger.Out("{0} - {1}", item.Name, item.Count);
            Logger.Out("");
            var equipment = GetUserInfo[GameObject.UserEquipItemInfo_w83oV9uP][0][Variable.ItemList].ToString().Split(new char[1] { ',' });
            foreach (var equip in equipment)
            {
                var eqId = equip.Split(new char[1] { ':' })[0];
                var count = equip.Split(new char[1] { ':' })[1];
            //    Logger.Out("{0} - {1}", Equipment.Equipments.First(e => e.EquipId == eqId).Name, count);
            }
            Logger.Out("");
            var materia = GetUserInfo[GameObject.UserMateriaInfo_aS39Eshy][0][Variable.ItemList].ToString().Split(new char[1] { ',' });
            foreach (var ability in materia)
            {
                if (!ability.Contains(":"))
                    continue;
                var matIt = ability.Split(new char[1] { ':' })[0];
                var count = ability.Split(new char[1] { ':' })[1];
             //   Logger.Out("{0} - {1}", Materia.Materias.First(m => m.MateriaId == matIt).Name, count);
            }
        }
    }
}
