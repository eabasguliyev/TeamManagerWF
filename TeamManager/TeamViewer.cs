using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using TeamManager.Entities;
using TeamManager.Helpers;

namespace TeamManager
{
    public partial class TeamViewer : Form
    {
        public Tactic Tactic { get; set; }
        private bool _isNumber = true;
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
            Tactic = null;
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
            pcBoxCountryFlag.Load(CountryHelper.GetCountryFlagUrl(Tactic.CountryName));
            labelTactic.Text = Tactic.Name;
            LoadPlayersToArea();
        }

        private void LoadPlayersToArea()
        {
            for (int i = 0; i < Tactic.Players.Count; i++)
            {
                var player = Tactic.Players[i];
                var location = Tactic.PositionsLocation[i];

                var newUcPlayer = new UCPlayer();

                var btn = newUcPlayer.Controls["btnPlayer"] as Guna2CircleButton;
                btn.Text = player.Number.ToString();
                btn.FillColor = player.Color;
                btn.ForeColor = Color.Black;
                btn.MouseDown += PlayerButtonMouseDown;
                btn.MouseMove += PlayerButtonMouseMove;
                btn.MouseUp += PlayerButtonMouseUp;

                newUcPlayer.Controls["labelPlayerName"].Text = player.Fullname;


                newUcPlayer.Location = location;
                this.panelGameArea.Controls.Add(newUcPlayer);
            }
        }

        private void ChangePlayerIdentifier()
        {
            if (!_isNumber)
            {
                for (int i = 0; i < Tactic.Players.Count; i++)
                {
                    if(this.panelGameArea.Controls[i] is UCPlayer ucPlayer)
                    {
                        var player = Tactic.Players[i];
                        ucPlayer.Controls["btnPlayer"].Text = player.Number.ToString();
                    }
                }

                _isNumber = true;
            }
            else
            {
                for (int i = 0; i < Tactic.Players.Count; i++)
                {
                    if (this.panelGameArea.Controls[i] is UCPlayer ucPlayer)
                    {
                        var player = Tactic.Players[i];
                        ucPlayer.Controls["btnPlayer"].Text = player.Position;
                    }
                }

                _isNumber = false;
            }
        }

        private void showPlayerPositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_isNumber)
            {
                ChangePlayerIdentifier();
                showPlayerPositionsToolStripMenuItem.Text = "Show Player Numbers";
            }
            else
            {
                ChangePlayerIdentifier();
                showPlayerPositionsToolStripMenuItem.Text = "Show Player Positions";
            }
        }

        private void PlayerButtonMouseDown(object sender, EventArgs e)
        {
            var btnPlayer = sender as Guna2CircleButton;
            var ucPlayer = btnPlayer.Parent as UCPlayer;

            FormHelper.MouseDown(Cursor.Position, ucPlayer.Location);
        }

        private void PlayerButtonMouseMove(object sender, EventArgs e)
        {
            var btnPlayer = sender as Guna2CircleButton;
            var ucPlayer = btnPlayer.Parent as UCPlayer;


            var newLocation = FormHelper.MouseMove();

            if (newLocation != Point.Empty)
                ucPlayer.Location = newLocation;
        }

        private void PlayerButtonMouseUp(object sender, EventArgs e)
        {
            FormHelper.MouseUp();
        }
    }
}
