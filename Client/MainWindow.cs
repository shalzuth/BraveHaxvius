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

namespace Client
{
    public partial class MainWindow : Form
    {
        DataTable injectDataTable = new DataTable();
        DataTable unitDataTable = new DataTable();

        public MainWindow()
        {
            InitializeComponent();
            InitDatagrid();
            Control.CheckForIllegalCrossThreadCalls = false;
            Logger.LogHook = Hook;
        }
        public void Hook(String s)
        {
            consoleLog.Text += s + "\r\n";
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
                    FacebookToken = fbtokenInput.Text.Replace(" ", "")
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
                summonButton.Enabled = false;
                var unit = Unit.Units.First(u => u.Name == unitDataGrid.Rows[unitDataGrid.CurrentRow.Index].Cells[0].Value.ToString() && u.UnitId == u.BaseUnitId);
                var b = new BraveExvius
                {
                    FacebookUserId = fbidInput.Text.Replace(" ", ""),
                    FacebookToken = fbtokenInput.Text.Replace(" ", "")
                };
                b.Login();
                b.UnitHunter(unit);
                summonButton.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }

        private void DonateButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=shal.zuth@gmail.com&lc=US&currency_code=USD&bn=PP%2dDonationsBF");
        }
    }
}
