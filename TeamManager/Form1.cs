using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TeamManager.Helpers;

namespace TeamManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void pcBoxClose_MouseEnter(object sender, EventArgs e)
        {
            pcBoxClose.Image = Properties.Resources.red_close_window;
        }

        private void pcBoxClose_MouseLeave(object sender, EventArgs e)
        {
            pcBoxClose.Image = Properties.Resources.close_window;
        }

        private void pcBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private UCPlayerInfo CreateNewUcPlayer(int no)
        {
            var newUcPlayer = new UCPlayerInfo();

            newUcPlayer.Location = new Point(0, no * newUcPlayer.Height);
            return newUcPlayer;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateUcPlayers();
            BindCountriesComboBox();
        }

        private void CreateUcPlayers(int playerCount = 11)
        {
            for (int i = 0; i < playerCount; i++)
            {
                var ucPlayer = CreateNewUcPlayer(i);

                panelPlayers.Controls.Add(ucPlayer);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (!CheckUserInputs())
                return;


            var teamViewer = new TeamViewer();

            teamViewer.CountryName = cmBoxCountries.SelectedItem as string;
            
            this.Hide();
            teamViewer.ShowDialog();
            this.Show();
        }

        private void BindCountriesComboBox()
        {
            cmBoxCountries.DataSource = CountryHelper.GetCountryList();
        }

        private bool CheckUserInputs()
        {
            return true;
        }
    }
}
