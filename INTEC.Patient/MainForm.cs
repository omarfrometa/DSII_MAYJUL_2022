using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTEC.Patient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //this.IsMdiContainer = true;

            lblMsg.Text = $"Autenticado como {System.Security.Principal.WindowsIdentity.GetCurrent().Name}";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userForm = new UserForm();
            userForm.MdiParent = this;
            userForm.Show();
        }

        private void tiposDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oForm = new UserTypeForm();
            oForm.MdiParent = this;
            oForm.Show();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void iconosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void nuevoPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oForm = new PatientForm();
            oForm.MdiParent = this;
            oForm.Show();
        }
    }
}
