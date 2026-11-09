using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmartGridEngine.Models;
using SmartGridEngine.Services;

namespace SmartGridGui
{
    public partial class frmMain : Form
    {
        private readonly GridController controller = new GridController();

        public frmMain()
        {
            InitializeComponent();

            this.Load += frmMain_Load;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            btnAddSource.Click += btnAddSource_Click;
            btnClear.Click += btnClear_Click;
            btnStart.Click += btnStart_Click;
            btnStop.Click += btnStop_Click;
            btnConnect.Click += btnConnect_Click;
            btnDisconnect.Click += btnDisconnect_Click;
            btnEvaluate.Click += btnEvaluate_Click;
            btnExport.Click += btnExport_Click;
            nudDemand.ValueChanged += nudDemand_ValueChanged;

            var fileMenu = (ToolStripMenuItem)menuStrip1.Items[0];
            fileMenu.DropDownItems[0].Click += (s, e) => ExportJson();
            fileMenu.DropDownItems[1].Click += (s, e) => Close();
            var helpMenu = (ToolStripMenuItem)menuStrip1.Items[1];
            helpMenu.DropDownItems[0].Click += (s, e) =>
                MessageBox.Show("Smart Grid & Renewable Energy Monitoring Engine\nWinForms GUI - OOP Group Project", "About");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbType.SelectedIndex = 0;                              // start on "Solar Panel"
            nudDemand.Value = (decimal)controller.TotalLoadDemandKw; // engine default: 300 kW
            UpdateTypeFields();
            RefreshList();
        }

        // ---------- Add Power Source panel ----------

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTypeFields();
        }

        // Only the fields for the selected source type stay enabled
        private void UpdateTypeFields()
        {
            bool solar = cmbType.SelectedIndex == 0;
            bool wind = cmbType.SelectedIndex == 1;
            bool battery = cmbType.SelectedIndex == 2;

            nudPanelEfficiency.Enabled = solar;
            nudSunlight.Enabled = solar;
            nudWindSpeed.Enabled = wind;
            nudBladeLength.Enabled = wind;
            nudMaxCapacity.Enabled = battery;
            nudCharge.Enabled = battery;
        }

        private void btnAddSource_Click(object sender, EventArgs e)
        {
            // Validation first (same pattern as the lab's Submit button)
            string name = txtName.Text.Trim();
            if (name == "")
            {
                MessageBox.Show("Please enter a name first.", "Missing name",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            double capacity = (double)nudCapacity.Value;
            if (capacity <= 0)
            {
                MessageBox.Show("Capacity (kW) must be more than 0.", "Invalid capacity",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PowerSource source;
            if (cmbType.SelectedIndex == 1)          // Wind Turbine
            {
                var wind = new WindTurbine(MakeId("WND"), name, capacity, (double)nudBladeLength.Value);
                if (nudWindSpeed.Value > 0) wind.WindSpeedKms = (double)nudWindSpeed.Value; // 0 = keep engine default
                source = wind;
            }
            else if (cmbType.SelectedIndex == 2)     // Battery Storage
            {
                if (nudMaxCapacity.Value <= 0)
                {
                    MessageBox.Show("Max Capacity (kWh) must be more than 0 for a battery.", "Invalid capacity",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var battery = new BatteryStorageSystem(MakeId("BAT"), name, capacity, (double)nudMaxCapacity.Value);
                if (nudCharge.Value > 0) battery.CurrentCharge = (double)nudCharge.Value; // 0 = keep engine default (75%)
                source = battery;
            }
            else                                     // Solar Panel
            {
                // The panel box is in percent (e.g. 92), the engine stores a fraction (0.92)
                var solar = new SolarPanel(MakeId("SOL"), name, capacity, (double)nudPanelEfficiency.Value / 100.0);
                if (nudSunlight.Value > 0) solar.SunlightLux = (double)nudSunlight.Value; // 0 = keep engine default
                source = solar;
            }

            controller.RegisterSource(source);
            if (chkActive.Checked) source.StartGeneration();

            RefreshList();
            ClearForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtName.Clear();
            nudCapacity.Value = 0;
            nudPanelEfficiency.Value = 0;
            nudSunlight.Value = 0;
            nudWindSpeed.Value = 0;
            nudBladeLength.Value = 0;
            nudMaxCapacity.Value = 0;
            nudCharge.Value = 0;
            chkActive.Checked = false;
            cmbType.SelectedIndex = 0;
            txtName.Focus();
        }

        // IDs in the same style as the group's console demo: SOL-001, WND-001, BAT-001
        private string MakeId(string prefix)
        {
            int count = controller.Sources.Count(s => s.Id.StartsWith(prefix)) + 1;
            return prefix + "-" + count.ToString("000");
        }

        // ---------- List + dashboard ----------

        private void RefreshList()
        {
            lvSources.Items.Clear();
            foreach (var s in controller.Sources)
            {
                var item = new ListViewItem(s.Name);
                item.SubItems.Add(TypeName(s));
                item.SubItems.Add(s.CapacityKw.ToString("F2"));
                item.SubItems.Add(s.CurrentOutputKw.ToString("F2"));
                item.SubItems.Add((s.CalculateEfficiency() * 100).ToString("F2") + "%");
                item.SubItems.Add(s.IsActive ? "Active" : "Stopped");
                item.Tag = s;   // keep the object with its row
                lvSources.Items.Add(item);
            }
            RefreshDashboard();
        }

        private string TypeName(PowerSource s)
        {
            if (s is SolarPanel) return "Solar";
            if (s is WindTurbine) return "Wind";
            return "Battery";
        }

        private void RefreshDashboard()
        {
            lblTotalGen.Text = "Total Generation: " + controller.GetTotalGeneration().ToString("F2") + " kW";
            tssSources.Text = "Sources: " + controller.Sources.Count;
            tssStability.Text = "Stability: " + (controller.EvaluateGridStability() ? "STABLE" : "UNSTABLE");
        }

        private void nudDemand_ValueChanged(object sender, EventArgs e)
        {
            controller.TotalLoadDemandKw = (double)nudDemand.Value;
            RefreshDashboard();
        }

        // ---------- Action buttons (work on the selected row) ----------

        private PowerSource GetSelectedSource()
        {
            if (lvSources.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a source in the list first.", "Nothing selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            return (PowerSource)lvSources.SelectedItems[0].Tag;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var s = GetSelectedSource();
            if (s == null) return;
            s.StartGeneration();
            RefreshList();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            var s = GetSelectedSource();
            if (s == null) return;
            s.StopGeneration();
            RefreshList();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            var s = GetSelectedSource();
            if (s == null) return;
            s.ConnectToGrid();
            RefreshList();
            MessageBox.Show(s.Name + " is now synced with the grid.", "Connect to Grid");
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            var s = GetSelectedSource();
            if (s == null) return;
            s.DisconnectFromGrid();
            RefreshList();
            MessageBox.Show(s.Name + " disconnected from the grid.", "Disconnect");
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            controller.TotalLoadDemandKw = (double)nudDemand.Value;
            bool stable = controller.EvaluateGridStability();
            RefreshDashboard();
            MessageBox.Show(
                "Total generation: " + controller.GetTotalGeneration().ToString("F2") + " kW\n" +
                "Load demand: " + controller.TotalLoadDemandKw.ToString("F2") + " kW\n" +
                "Grid is " + (stable ? "STABLE" : "UNSTABLE"),
                "Grid Stability");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportJson();
        }

        private void ExportJson()
        {
            if (controller.Sources.Count == 0)
            {
                MessageBox.Show("Add at least one source first.", "Nothing to export",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var sb = new StringBuilder();
            sb.AppendLine("[");
            for (int i = 0; i < controller.Sources.Count; i++)
            {
                sb.Append("  " + controller.Sources[i].GenerateJSON());
                sb.AppendLine(i < controller.Sources.Count - 1 ? "," : "");
            }
            sb.AppendLine("]");

            using (var dlg = new SaveFileDialog { Filter = "JSON file|*.json", FileName = "smart-grid.json" })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dlg.FileName, sb.ToString());
                    MessageBox.Show("JSON saved to " + dlg.FileName, "Export JSON");
                }
            }
        }

        // ----- Empty handlers Visual Studio auto-created from double-clicks in the
        // designer. They are wired inside Form1.Designer.cs, so they must stay
        // in Form1.cs or the build fails. Empty is fine - they do nothing.
        private void toolStripStatusLabel1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e) { }
        private void lvSources_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
