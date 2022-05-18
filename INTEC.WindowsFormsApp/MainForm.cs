using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTEC.WindowsFormsApp
{
    public partial class MainForm : Form
    {
        List<string> Barbers = new List<string>();
        List<string> Hours = new List<string>();
        List<Appoiment> Appoiments = new List<Appoiment>();

        public MainForm()
        {
            InitializeComponent();

            lblMsg.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            fillBarbers();
            fillHours();
        }

        private void fillBarbers()
        {
            Barbers.Add("Diego Nolasco");
            Barbers.Add("Williams Viloria");
            Barbers.Add("Lorenzo Peralta");

            cbBarbers.DataSource = Barbers;
        }

        private void fillHours()
        {
            Hours = Enumerable.Range(08, 15).Select(i=> (DateTime.MinValue.AddHours(i)).ToString("hh.mm tt")).ToList();

            cbHours.DataSource = Hours;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmptyControls();
            DefaultValues();
            gbPanel.Enabled = true;
        }

        private void DefaultValues()
        {
            cbBarbers.SelectedIndex = 0;
            dtpDate.Value = DateTime.Now;
            //cbHours.SelectedText = DateTime.Now.ToString("hh");
        }

        private void EmptyControls()
        {
            txtName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbPanel.Enabled = false;
        }

        private void btnBarberAdd_Click(object sender, EventArgs e)
        {
            var form = new BaberForm();
            //form.ShowDialog();
            form.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAppoiment();
        }

        private void SaveAppoiment()
        {
            var rnd = new Random();

            var appoiment = new Appoiment { 
                Id = Guid.NewGuid(),
                Code = rnd.Next(100000,999999).ToString(),
                ClientName = txtName.Text,
                ClientPhone = txtPhone.Text,
                ClientEmail = txtEmail.Text,
                BarberName = cbBarbers.SelectedValue.ToString(),
                ScheduleDate = dtpDate.Value,
                ScheduleHour = cbHours.SelectedValue.ToString(),
                CreatedDate = DateTime.Now
            };

            var existAppoiments = Appoiments.Count(x => x.ScheduleDate.ToString("dd/mm/yyyy") == dtpDate.Value.ToString("dd/mm/yyyy") && x.ScheduleHour == cbHours.SelectedValue.ToString());
            if (existAppoiments > 0)
            {
                MessageBox.Show("Horario no disponible");
                return;
            }

            //Add Appoiment to List
            Appoiments.Add(appoiment);

            //Remove Hour
            var selectedHour = Hours.FirstOrDefault(x=> x.ToString() == cbHours.SelectedValue.ToString());
            Hours.Remove(selectedHour);
            cbHours.DataSource = null;
            cbHours.DataSource = Hours;

            //Get Appoiments
            GetAppoiments();

            gbPanel.Enabled = false;
            EmptyControls();
        }

        private void GetAppoiments()
        {
            dgvAppoiments.DataSource = null;
            dgvAppoiments.DataSource = Appoiments;

            dgvAppoiments.Columns["Id"].Visible = false;
            dgvAppoiments.Columns["ScheduleDate"].Visible = false;

            dgvAppoiments.Columns["ClientName"].HeaderText = "Client";
            dgvAppoiments.Columns["ClientPhone"].HeaderText = "Phone";
            dgvAppoiments.Columns["ClientEmail"].HeaderText = "Email";
            dgvAppoiments.Columns["BarberName"].HeaderText = "Barber";
            dgvAppoiments.Columns["ScheduleDateCustom"].HeaderText = "Schedule Date";
            dgvAppoiments.Columns["ScheduleHour"].HeaderText = "Hour";
        }
    }

    public class Appoiment
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public string ClientEmail { get; set; }
        public string BarberName { get; set; }
        public DateTime ScheduleDate { get; set; }
        public string ScheduleDateCustom { get {
                return ScheduleDate.ToString("MMM dd, yyyy");
            } }
        public string ScheduleHour { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
