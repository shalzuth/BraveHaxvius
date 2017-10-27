using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BraveHaxvius;
using BraveHaxvius.Data;
using Client.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Client
{
    public partial class MainWindow : Form
    {
        BraveExvius client = new BraveExvius();
        DataTable injectDataTable = new DataTable();
        JToken Gachas;

        public MainWindow()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            InitStaticItems();
            client.FacebookUserId = fbidInput.Text;
            client.FacebookToken = fbtokenInput.Text;
            client.ProxyIpAddr = ProxyIP.Text;
            if (!String.IsNullOrWhiteSpace(ProxyIP.Text))
                client.ProxyPort = int.Parse(ProxyPort.Text);
            Logger.LogHook = Hook;
        }
        public void Hook(String s)
        {
            consoleLog.Focus();
            consoleLog.AppendText(s+ "\r\n");
        }
        private void InitStaticItems()
        {
            injectDataTable.Columns.Add("Count");
            injectDataTable.Columns.Add("Type");
            injectDataTable.Columns.Add("Name");
            injectDataTable.Columns.Add("ID");
            Item.Items.FindAll(i => i.Description != null).ForEach(i => injectDataTable.Rows.Add(0, "item", i.Name, i.ItemId));
            Equipment.Equipments.FindAll(i => i.Description != null).ForEach(i => injectDataTable.Rows.Add(0, "equip", i.Name, i.EquipId));
            Materia.Materias.FindAll(i => i.Description != null).ForEach(i => injectDataTable.Rows.Add(0, "materia", i.Name, i.MateriaId));
            injectDataGrid.DataSource = injectDataTable;
            
            Unit.Units.FindAll(u => u.Description != null && u.IsSummonable == "1" && u.UnitId == u.BaseUnitId);
            List<Mission> list = new List<Mission>();
            Mission.Missions.FindAll(i => i.Description != null).ForEach(i => list.Add(i));

            unitSelect.DataSource = Unit.Units.FindAll(u => u.Description != null && u.IsSummonable == "1" && u.UnitId == u.BaseUnitId);
            unitSelect.DisplayMember = "Name";
            
            missionSelect.DataSource = Mission.Missions.FindAll(i => i.Description != null);
            missionSelect.DisplayMember = "Name";
        }
        private void InitGacha(BraveExvius b)
        {
            Gachas = b.GetUserInfo[GameObject.GachaScheduleMst];

            foreach (var gacha in b.GachaId)
                JPGacha.Items.Add(gacha);

            JPGacha.SelectedIndex = 0;

            foreach (var ticket in Ticket.Tickets)
                JPGachaTicket.Items.Add(ticket.Name);

            JPGachaTicket.SelectedIndex = 0;
        }
        private void InjectSearchInput_TextChanged(object sender, EventArgs e)
        {
            injectDataTable.DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", injectSearchInput.Text);
        }
        private void InjectButton_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                injectButton.Enabled = false;
                var itemHax = String.Join(",", injectDataTable.Rows.Cast<DataRow>().ToList().FindAll(i => i.ItemArray[1].ToString() == "item" && i.ItemArray[0].ToString() != "0").Select(i => "20:" + i.ItemArray[3] + ":" + i.ItemArray[0]));
                var equipmentHax = String.Join(",", injectDataTable.Rows.Cast<DataRow>().ToList().FindAll(i => i.ItemArray[1].ToString() == "equip" && i.ItemArray[0].ToString() != "0").Select(i => "21:" + i.ItemArray[3] + ":" + i.ItemArray[0]));
                var materiaHax = String.Join(",", injectDataTable.Rows.Cast<DataRow>().ToList().FindAll(i => i.ItemArray[1].ToString() == "materia" && i.ItemArray[0].ToString() != "0").Select(i => "22:" + i.ItemArray[3] + ":" + i.ItemArray[0]));
                client.Login();
                client.DoMission(Mission.AirshipDeck, false, itemHax, equipmentHax, materiaHax);
                injectButton.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }
        private void SummonButton_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                Func<int, int> iteration = i =>
                {
                    summonButton.Text = (i + 1).ToString() + "...";
                    return 1;
                };
                summonButton.Enabled = false;
                var unit = unitSelect.SelectedItem as Unit;
                client.Login();
                client.UnitHunter(unit, sell3Star.Checked, sell4Star.Checked, sell5Star.Checked, iteration);
                summonButton.Text = "summon";
                summonButton.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }
        private void GitHubButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/shalzuth/BraveHaxvius");
        }
        private void DonateButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=shal.zuth@gmail.com&lc=US&currency_code=USD&bn=PP%2dDonationsBF");
        }
        private void LevelPartyButton_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                Func<string, int> update = i =>
                {
                    levelStatus.Text = i;
                    return 1;
                };
                levelPartyButton.Enabled = false;
                client.Login();
                client.LevelPartyNew(update);
                levelPartyButton.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }
        private void RankUpButton_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                Func<string, int> update = i =>
                {
                    levelStatus.Text = i;
                    return 1;
                };
                rankUpButton.Enabled = false;
                client.Login();
                while (true)
                {
                    var result = client.DoMission(Mission.PortCityLodin, false, null, null, null, false, false, false, false, false, null, 15000);
                    var level = result[GameObject.UserTeamInfo].First()[Variable.Level].ToString();
                    var experience = result[GameObject.UserTeamInfo].First()[Variable.Experience].ToString();
                    levelStatus.Text = "Rank " + level + " : experience = " + experience;
                    if (level == "150")
                        break;
                    Thread.Sleep(3000);
                }
                rankUpButton.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }

        private void JPLogin_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                JPLogin.Enabled = false;
                client.LoginJapan();
                InitGacha(client);
                JPLogin.Enabled = true;
                GachaSummon.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }

        private void GachaSummon_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                GachaSummon.Enabled = false;
                
                var GachaId = JPGacha.Text.Split(':').Select(p => p.Trim()).ToList().First();
                var Gacha = Gachas.First(g => g[Variable.GachaId].ToString() == GachaId);
                var GachaTicket = Ticket.Tickets.First(x => x.Name == JPGachaTicket.Text).Id;
                var GachaSubId = Gacha[Variable.Options].ToString().Split(',').Last();
                client.Summon(Gacha[Variable.GachaId].ToString(), GachaSubId, "1", GachaTicket);

                GachaSummon.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }

        private void StartMission_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                StartMission.Enabled = false;
                client.Device = RBiOS.Checked ? "iPhone9,3" : "XT890";
                client.OperatingSystem = RBiOS.Checked ? "ios10.2.1" : RBAndroid.Checked ? "android4.4.2" : "amazon";
                client.Login();
                var mission = missionSelect.SelectedItem as Mission;
                client.DoMission(mission, CBFriends.Checked, null, null, null, CBTrophies.Checked, CBChallenge.Checked, CBLoot.Checked, CBUnits.Checked, CBExplore.Checked, LBLevel.Text, 3000);
                var count = 1;
                while (!String.IsNullOrEmpty(RepeatMission.Text.Replace(" ", "")) && count < Int32.Parse(RepeatMission.Text.Replace(" ", "")))
                {
                    client.DoMission(mission, CBFriends.Checked, null, null, null, CBTrophies.Checked, CBChallenge.Checked, CBLoot.Checked, CBUnits.Checked, CBExplore.Checked, LBLevel.Text, 3000);
                    count++;
                    Thread.Sleep(3000);
                }
                StartMission.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }

        private void RBOS_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void FbidInput_TextChanged(object sender, EventArgs e)
        {
            fbidInput.Text = fbidInput.Text.Replace(" ", "");
            client.FacebookUserId = fbidInput.Text;
            Settings.Default.fbidInput = fbidInput.Text;
            Settings.Default.Save();
        }

        private void fbtokenInput_TextChanged(object sender, EventArgs e)
        {
            fbtokenInput.Text = fbtokenInput.Text.Replace(" ", "");
            client.FacebookToken = fbtokenInput.Text;
            Settings.Default.fbtokenInput = fbtokenInput.Text;
            Settings.Default.Save();
        }

        private void ProxyIP_TextChanged(object sender, EventArgs e)
        {
            client.ProxyIpAddr = ProxyIP.Text;
            Settings.Default.ProxyIP = ProxyIP.Text;
            Settings.Default.Save();
        }

        private void ProxyPort_TextChanged(object sender, EventArgs e)
        {
            client.ProxyPort = int.Parse(ProxyPort.Text);
            Settings.Default.ProxyPort = ProxyPort.Text;
            Settings.Default.Save();
        }
        private void CBTrophies_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb.Checked)
            {
                LBLevel.Text = "";
                LBLevel.Enabled = false;
                CBChallenge.Checked = false;
                CBChallenge.Enabled = false;
            }
            else
            {
                LBLevel.Enabled = true;
            }
        }
        private void arenaButton_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                Func<string, int> update = i =>
                {
                    levelStatus.Text = i;
                    return 1;
                };
                arenaButton.Enabled = false;
                client.Login();
                client.ClearArena();
                arenaButton.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }

        public class Sell
        {
            public String ItemName;
            public String id;
            public String type;
            public int count;
            public int price;
            public override string ToString()
            {
                return ItemName + " : " + count;
            }
        }
        private void sellButton_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                if (sellButton.Text == "login")
                {
                    sellButton.Enabled = false;
                    client.Login();
                    var items = client.GetUserInfo[GameObject.UserItemInfo_4rC0aLkA].First()[Variable.ItemList].ToString().Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    var equips = client.GetUserInfo[GameObject.UserEquipItemInfo_w83oV9uP].First()[Variable.ItemList].ToString().Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    var materias = client.GetUserInfo[GameObject.UserMateriaInfo_aS39Eshy].First()[Variable.ItemList].ToString().Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    List<Sell> sellable = new List<Sell>();
                    foreach (var itemInfo in items)
                    {
                        var id = itemInfo.Split(new char[1] { ':' })[0];
                        var count = itemInfo.Split(new char[1] { ':' })[1];
                        var item = Item.Items.First(i => i.ItemId == id);
                        sellable.Add(new Sell { ItemName = item.Name, count = int.Parse(count), id = id, price = int.Parse(item.ItemSellPrice), type = "20:" });//, ItemNameAndCount = item.Name + " : " + count });
                    }
                    foreach (var itemInfo in equips)
                    {
                        var id = itemInfo.Split(new char[1] { ':' })[0];
                        var count = itemInfo.Split(new char[1] { ':' })[1];
                        var item = Equipment.Equipments.First(i => i.EquipId == id);
                        sellable.Add(new Sell { ItemName = item.Name, count = int.Parse(count), id = id, price = int.Parse(item.ItemSellPrice), type = "21:" });//, ItemNameAndCount = item.Name + " : " + count });
                    }
                    foreach (var itemInfo in materias)
                    {
                        var id = itemInfo.Split(new char[1] { ':' })[0];
                        var count = itemInfo.Split(new char[1] { ':' })[1];
                        var item = Materia.Materias.First(i => i.MateriaId == id);
                        sellable.Add(new Sell { ItemName = item.Name, count = int.Parse(count), id = id, price = int.Parse(item.ItemSellPrice), type = "22:" });//, ItemNameAndCount = item.Name + " : " + count });
                    }
                    sellable = sellable.OrderByDescending(s => s.count).ToList();
                    sellButton.Text = "sell";
                    sellItemSelect.DataSource = sellable;
                    sellButton.Enabled = true;
                }
                else if (sellButton.Text == "sell")
                {
                    sellButton.Enabled = false;
                    var item = (sellItemSelect.SelectedItem as Sell);
                    while ((UInt64)item.count * (UInt64)item.price > 999999999)
                    {
                        var maxSell = 999999999 / item.price;
                        client.Network.SendPacket(Request.ItemSell, new JProperty(Variable.ItemSell, new JArray(new JObject(
                            new JProperty(Variable.StoreItemSellId, item.type + item.id + ":" + maxSell),
                            new JProperty(Variable.StoreItemSellPrice, ((UInt64)item.price * (UInt64)maxSell).ToString())))));
                        item.count -= maxSell;
                        Thread.Sleep(3000);
                    }
                    client.Network.SendPacket(Request.ItemSell, new JProperty(Variable.ItemSell, new JArray(new JObject(
                        new JProperty(Variable.StoreItemSellId, item.type + item.id + ":" + item.count),
                        new JProperty(Variable.StoreItemSellPrice, (item.price * item.count).ToString())))));
                    sellButton.Enabled = true;
                }
            });
            t.IsBackground = true;
            t.Start();
        }
    }
}
