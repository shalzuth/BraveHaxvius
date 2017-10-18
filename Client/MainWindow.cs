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
using System.Windows.Controls;

namespace Client
{
    public partial class MainWindow : Form
    {
        DataTable injectDataTable = new DataTable();
        DataTable unitDataTable = new DataTable();
        Newtonsoft.Json.Linq.JToken Gachas;
        BraveExvius JP = new BraveExvius();

        public MainWindow()
        {
            InitializeComponent();
            InitDatagrid();
            InitMissions();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            Logger.LogHook = Hook;
        }
        public void Hook(String s)
        {
            consoleLog.Focus();
            consoleLog.AppendText(s+ "\r\n");
        }
        private void InitDatagrid()
        {
            injectDataTable.Columns.Add("Count");
            injectDataTable.Columns.Add("Type");
            injectDataTable.Columns.Add("Name");
            injectDataTable.Columns.Add("ID");
            Item.Items.FindAll(i => i.Description != null).ForEach(i => injectDataTable.Rows.Add(0, "item", i.Name, i.ItemId));
            Equipment.Equipments.FindAll(i => i.Description != null).ForEach(i => injectDataTable.Rows.Add(0, "equip", i.Name, i.EquipId));
            Materia.Materias.FindAll(i => i.Description != null).ForEach(i => injectDataTable.Rows.Add(0, "materia", i.Name, i.MateriaId));
            injectDataGrid.DataSource = injectDataTable;
            
            unitDataTable.Columns.Add("Name");
            Unit.Units.FindAll(u => u.Description != null && u.IsSummonable == "1" && u.UnitId == u.BaseUnitId).ForEach(u => unitDataTable.Rows.Add(u.Name));
            unitDataGrid.DataSource = unitDataTable;
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
        private void InitMissions()
        {
            List<Mission> list = new List<Mission>();
            Mission.Missions.FindAll(i => i.Description != null).ForEach(i => list.Add(i));
            
            MissionSelect.DataSource = list;
            MissionSelect.DisplayMember = "Name";
            MissionSelect.ValueMember = "MissionId";
        }
        private void InjectSearchInput_TextChanged(object sender, EventArgs e)
        {
            injectDataTable.DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", injectSearchInput.Text);
        }
        private void UnitSearchInput_TextChanged(object sender, EventArgs e)
        {
            unitDataTable.DefaultView.RowFilter = string.Format("name LIKE '%{0}%'", unitSearchInput.Text);
        }
        private void InjectButton_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                injectButton.Enabled = false;
                var itemHax = String.Join(",", injectDataTable.Rows.Cast<DataRow>().ToList().FindAll(i => i.ItemArray[1].ToString() == "item" && i.ItemArray[0].ToString() != "0").Select(i => "20:" + i.ItemArray[3] + ":" + i.ItemArray[0]));
                var equipmentHax = String.Join(",", injectDataTable.Rows.Cast<DataRow>().ToList().FindAll(i => i.ItemArray[1].ToString() == "equip" && i.ItemArray[0].ToString() != "0").Select(i => "21:" + i.ItemArray[3] + ":" + i.ItemArray[0]));
                var materiaHax = String.Join(",", injectDataTable.Rows.Cast<DataRow>().ToList().FindAll(i => i.ItemArray[1].ToString() == "materia" && i.ItemArray[0].ToString() != "0").Select(i => "22:" + i.ItemArray[3] + ":" + i.ItemArray[0]));
                var b = new BraveExvius
                {
                    FacebookUserId = fbidInput.Text.Replace(" ", ""),
                    FacebookToken = fbtokenInput.Text.Replace(" ", ""),
                    ProxyIpAddr = !String.IsNullOrEmpty(ProxyIP.Text.Replace(" ", "")) ? ProxyIP.Text.Replace(" ", "") : "shalzuthproxy",
                    ProxyPort = !String.IsNullOrEmpty(ProxyIP.Text.Replace(" ", "")) ? Int32.Parse(ProxyIP.Text.Replace(" ", "")) : 0
                };
                b.Login();
                b.DoMission(Mission.AirshipDeck, false, itemHax, equipmentHax, materiaHax);
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
                var unit = Unit.Units.First(u => u.Name == unitDataGrid.Rows[unitDataGrid.CurrentRow.Index].Cells[0].Value.ToString() && u.UnitId == u.BaseUnitId);
                var b = new BraveExvius
                {
                    FacebookUserId = fbidInput.Text.Replace(" ", ""),
                    FacebookToken = fbtokenInput.Text.Replace(" ", ""),
                    ProxyIpAddr = !String.IsNullOrEmpty(ProxyIP.Text.Replace(" ", "")) ? ProxyIP.Text.Replace(" ", "") : "shalzuthproxy",
                    ProxyPort = !String.IsNullOrEmpty(ProxyIP.Text.Replace(" ", "")) ? Int32.Parse(ProxyIP.Text.Replace(" ", "")) : 0
                };
                b.Login();
                b.UnitHunter(unit, iteration);
                summonButton.Text = "summon highlighted";
                summonButton.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
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
                var b = new BraveExvius
                {
                    FacebookUserId = fbidInput.Text.Replace(" ", ""),
                    FacebookToken = fbtokenInput.Text.Replace(" ", ""),
                    ProxyIpAddr = !String.IsNullOrEmpty(ProxyIP.Text.Replace(" ", "")) ? ProxyIP.Text.Replace(" ", "") : "shalzuthproxy",
                    ProxyPort = !String.IsNullOrEmpty(ProxyIP.Text.Replace(" ", "")) ? Int32.Parse(ProxyIP.Text.Replace(" ", "")) : 0
                };
                b.Login();
                b.LevelParty(update);
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
                var b = new BraveExvius
                {
                    FacebookUserId = fbidInput.Text.Replace(" ", ""),
                    FacebookToken = fbtokenInput.Text.Replace(" ", ""),
                    ProxyIpAddr = !String.IsNullOrEmpty(ProxyIP.Text.Replace(" ", "")) ? ProxyIP.Text.Replace(" ", "") : "shalzuthproxy",
                    ProxyPort = !String.IsNullOrEmpty(ProxyIP.Text.Replace(" ", "")) ? Int32.Parse(ProxyIP.Text.Replace(" ", "")) : 0
                };
                b.Login();
                fbidInput.Text = b.FacebookUserId;
                fbtokenInput.Text = b.FacebookUserId;
                while (true)
                {
                    var result = b.DoMission(Mission.PortCityLodin, false, null, null, null, false, false, false, false, false, null, 15000);
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
                JP = new BraveExvius
                {
                    TransferCode = fbidInput.Text.Replace(" ", ""),
                    TransferPin = fbtokenInput.Text.Replace(" ", ""),
                    ProxyIpAddr = !String.IsNullOrEmpty(ProxyIP.Text.Replace(" ", "")) ? ProxyIP.Text.Replace(" ", "") : "shalzuthproxy",
                    ProxyPort = !String.IsNullOrEmpty(ProxyIP.Text.Replace(" ", "")) ? Int32.Parse(ProxyIP.Text.Replace(" ", "")) : 0
                };
                JP.LoginJapan(JP.TransferCode, JP.TransferPin);
                InitGacha(JP);
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
                JP.Summon(Gacha[Variable.GachaId].ToString(), GachaSubId, "1", GachaTicket);

                GachaSummon.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }

        private void SereDonate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=serenitygrant@gmail.com&lc=US&currency_code=USD&bn=PP%2dDonationsBF");
        }

        private void StartMission_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                StartMission.Enabled = false;
                var b = new BraveExvius
                {
                    FacebookUserId = fbidInput.Text.Replace(" ", ""),
                    FacebookToken = fbtokenInput.Text.Replace(" ", ""),
                    Device = RBiOS.Checked ? "iPhone9,3" : "XT890",
                    OperatingSystem = RBiOS.Checked ? "ios10.2.1" : RBAndroid.Checked ? "android4.4.2" : "amazon",
                    ProxyIpAddr = !String.IsNullOrEmpty(ProxyIP.Text.Replace(" ", "")) ? ProxyIP.Text.Replace(" ", "") : "shalzuthproxy",
                    ProxyPort = !String.IsNullOrEmpty(ProxyPort.Text.Replace(" ", "")) ? Int32.Parse(ProxyPort.Text.Replace(" ", "")) : 0
                };
                b.Login();
                var mission = Mission.Missions.First(i => i.MissionId == MissionSelect.SelectedValue.ToString());
                b.DoMission(mission, CBFriends.Checked, null, null, null, CBTrophies.Checked, CBChallenge.Checked, CBLoot.Checked, CBUnits.Checked, CBExplore.Checked, LBLevel.Text, 3000);
                var count = 1;
                while (!String.IsNullOrEmpty(RepeatMission.Text.Replace(" ", "")) && count < Int32.Parse(RepeatMission.Text.Replace(" ", "")))
                {
                    b.DoMission(mission, CBFriends.Checked, null, null, null, CBTrophies.Checked, CBChallenge.Checked, CBLoot.Checked, CBUnits.Checked, CBExplore.Checked, LBLevel.Text, 3000);
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
    }
}
