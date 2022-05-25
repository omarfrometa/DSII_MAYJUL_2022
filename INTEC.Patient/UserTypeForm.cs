﻿using INTEC.Patient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTEC.Patient
{
    public partial class UserTypeForm : Form
    {
        public bool Addding { get; set; } = true;

        public UserTypeForm()
        {
            InitializeComponent();

            GetRecords();
        }

        private void GetRecords()
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\usertypes.json";

            var usertypes = new List<UserType>();
            if (File.Exists(pathFile))
            { 
                var json = File.ReadAllText(pathFile, Encoding.UTF8);
                usertypes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<UserType>>(json);
            }

            txtId.Text = (usertypes.Count + 1).ToString();

            dgvRecords.DataSource = usertypes;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            gbPanel.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            gbPanel.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNew.Enabled = true;

            SaveRecord();
        }

        private void SaveRecord()
        {
            var json = string.Empty;
            var usertypes = new List<UserType>();
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\usertypes.json";

            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                usertypes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<UserType>>(json);
            }

            var usertype = new UserType();
            if (Addding == true)
            {
                usertype = new UserType
                {
                    Id = int.Parse(txtId.Text),
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    Enabled = chkEnabled.Checked,
                    CreatedDate = DateTime.Now
                };
            }
            else
            {
                var Id = int.Parse(txtId.Text);
                usertype = usertypes.FirstOrDefault(x => x.Id == Id);
                if (usertype != null)
                {
                    usertypes.Remove(usertype);
                    usertype.Name = txtName.Text;
                    usertype.Description = txtDescription.Text;
                    usertype.Enabled = chkEnabled.Checked;
                    usertype.ModifiedDate = DateTime.Now;
                }
            }

            usertypes.Add(usertype);

            json = Newtonsoft.Json.JsonConvert.SerializeObject(usertypes);

            var sw = new StreamWriter(pathFile, false, Encoding.UTF8);
            sw.WriteLine(json);
            sw.Close();

            MessageBox.Show("Registro Almacenado", "Patient Manage", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearFields();

            GetRecords();
        }

        private void ClearFields()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            chkEnabled.Enabled = false;
            txtCreatedDate.Text = string.Empty;
            txtModifiedDate.Text = string.Empty;
        }
    }
}
