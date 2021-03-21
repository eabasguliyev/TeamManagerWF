using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamManager.Helpers;

namespace TeamManager
{
    public partial class TeamViewer : Form
    {
        public string CountryName { get; set; }
        public TeamViewer()
        {
            InitializeComponent();
        }

        private void pcBoxBack_MouseEnter(object sender, EventArgs e)
        {
            pcBoxBack.Image = Properties.Resources.green_back_60px;
        }

        private void pcBoxBack_MouseLeave(object sender, EventArgs e)
        {
            pcBoxBack.Image = Properties.Resources.back_60px;
        }

        private void pcBoxBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void panelFormControl_MouseDown(object sender, MouseEventArgs e)
        {
            FormHelper.MouseDown(Cursor.Position, this.Location);
        }

        private void panelFormControl_MouseMove(object sender, MouseEventArgs e)
        {
            var newLocation = FormHelper.MouseMove();

            if (newLocation != Point.Empty)
                this.Location = newLocation;
        }

        private void panelFormControl_MouseUp(object sender, MouseEventArgs e)
        {
            FormHelper.MouseUp();
        }

        private void TeamViewer_Load(object sender, EventArgs e)
        {
            pcBoxCountryFlag.Load(CountryHelper.GetCountryFlagUrl(CountryName));
        }
    }
}
