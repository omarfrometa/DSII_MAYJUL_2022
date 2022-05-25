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
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();

            GetMedicalHistory();
        }

        private void GetMedicalHistory()
        {
            var list = new List<string>
            {
                "Es buena su salud en general",
                "Visita periodicamente al dentista",
                "Siente debilidad en sus encias",
                "Siente algunos dientes flojos",
                "Problemas con la anestesia",
                "Diabetico",
                "Presion Alta"
            };

            for (int i = 0; i < list.Count; i++)
            {
                medicalHistory.Items.Add(list[i]);
            }
        }
    }
}
