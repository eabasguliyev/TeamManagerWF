using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using TeamManager.Entities;
using TeamManager.Helpers;

namespace TeamManager
{
    public partial class Form1 : Form
    {
        private FootballTactic _footballTactic;
        private Tactic _selectedTactic;
        public Form1()
        {
            InitializeComponent();

            _footballTactic = new FootballTactic();
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
            pcBoxClose.Image = Properties.Resources.red_close_window_50px;
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
            //CreateUcPlayers(_footballTactic[0]);
            BindCountriesComboBox();
            BindTacticsComboBox();
        }

        private void CreateUcPlayers(Tactic tactic, int playerCount = 11)
        {
            this.panelPlayers.Controls.Clear();
            var tacticName = tactic.Name;
            var tacticNumbers = ParseTacticName(tacticName);
            var j = 0;
            
            var sum = GetSum(tacticNumbers, j);

            for (int i = 0; i < playerCount; i++)
            {
                Color color = Color.Green;

                if (i < sum)
                {
                    color = Color.FromName(tactic.PositionColors[j]);
                }
                else if (playerCount - 1 != i)
                {
                    j++;
                    sum = GetSum(tacticNumbers, j);
                    i--;
                    continue;
                }

                var ucPlayer = CreateNewUcPlayer(i);

                var btn = ucPlayer.Controls["btnPlayerPosition"] as Guna2CircleButton;

                btn.Text = tactic.Positions[i];
                btn.FillColor = color;
                panelPlayers.Controls.Add(ucPlayer);
            }
        }

        private int GetSum(List<int> numbers, int index)
        {
            if (index >= numbers.Count)
                return 0;

            var sum = numbers[0];

            for (int i = 1; i < index + 1; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        private List<int> ParseTacticName(string tacticName)
        {
            var tactic = tacticName.Split('-');//new List<int>();

            var tacticNumbers= new List<int>();


            foreach (var item in tactic)
            {
                tacticNumbers.Add(Convert.ToInt32(item));
            }

            tacticNumbers.Reverse();

            return tacticNumbers;
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (!CheckUserInputs())
            {
                MessageBox.Show("You must be fill all player inputs!", 
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CheckPlayerNumbers())
            {
                MessageBox.Show("Player numbers must be unique!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _selectedTactic.Players.Clear();
            

            AddPlayersToSelectedTactic();
            
            var teamViewer = new TeamViewer();

            _selectedTactic.CountryName = cmBoxCountries.SelectedItem as string;

            teamViewer.Tactic = _selectedTactic;
            teamViewer.Size = new Size(554, 812);


            this.Hide();
            teamViewer.ShowDialog();
            this.Show();

            btnSave.Enabled = true;
        }

        private void AddPlayersToSelectedTactic()
        {
            for (int i = 0; i < 11; i++)
            {
                var ucPlayerInfo = this.panelPlayers.Controls[i] as UCPlayerInfo;

                var newPlayer = new Player();

                var btn = ucPlayerInfo.Controls["btnPlayerPosition"] as Guna2CircleButton;

                newPlayer.Position = btn.Text;
                newPlayer.Color = btn.FillColor;

                var numberTextBox = ucPlayerInfo.Controls["txtBoxPlayerNumber"] as Guna2TextBox;
                newPlayer.Number = Convert.ToInt32(numberTextBox.Text);
                var nameTextBox = ucPlayerInfo.Controls["txtBoxPlayerName"] as Guna2TextBox;
                newPlayer.Fullname = nameTextBox.Text;

                _selectedTactic.Players.Add(newPlayer);
            }
        }

        private void BindCountriesComboBox()
        {
            cmBoxCountries.DataSource = CountryHelper.GetCountryList();
        }

        private void BindTacticsComboBox()
        {
            cmBoxTactics.DisplayMember = "Name";
            cmBoxTactics.DataSource = _footballTactic.Tactics;
        }

        private bool CheckUserInputs()
        {
            var status = true;

            foreach (Control playerInfo in this.panelPlayers.Controls)
            {
                var txtBoxPlayerNumber = playerInfo.Controls["txtBoxPlayerNumber"] as Guna2TextBox;
                var txtBoxPlayerName = playerInfo.Controls["txtBoxPlayerName"] as Guna2TextBox;

                if (String.IsNullOrWhiteSpace(txtBoxPlayerNumber.Text))
                    status = false;

                if (String.IsNullOrWhiteSpace(txtBoxPlayerName.Text))
                    status = false;

                if (status == false)
                    break;
            }


            return status;
        }

        private bool CheckPlayerNumbers()
        {
            var status = true;

            for (int i = 0; i < this.panelPlayers.Controls.Count; i++)
            {
                var txtBoxPlayerNumber = this.panelPlayers.Controls[i].Controls["txtBoxPlayerNumber"] as Guna2TextBox;

                for (int j = i + 1; j < this.panelPlayers.Controls.Count; j++)
                {
                    var txtBoxPlayerNumber2 = this.panelPlayers.Controls[j].Controls["txtBoxPlayerNumber"] as Guna2TextBox;

                    if (txtBoxPlayerNumber.Text == txtBoxPlayerNumber2.Text)
                    {
                        status = false;
                        break;
                    }
                }

                if (status == false)
                    break;
            }

            return status;
        }

        private void cmBoxTactics_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedTactic = cmBoxTactics.SelectedItem as Tactic;

            var tacticIndex = _footballTactic.FindIndex(_selectedTactic?.Name);

            CreateUcPlayers(_footballTactic[tacticIndex]);

            btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckUserInputs())
            {
                MessageBox.Show("You must be fill all player inputs!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CheckPlayerNumbers())
            {
                MessageBox.Show("Player numbers must be unique!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var save = new SaveFileDialog();

            save.Filter = "Json File (*json) |";
            save.Title = "Type json file name";
            save.InitialDirectory = $@"{Directory.GetCurrentDirectory()}";

            if (save.ShowDialog() == DialogResult.Cancel)
                return;

            var fileName = save.FileName;
            if (!fileName.EndsWith(".json"))
                fileName += ".json";


            FileHelper.WriteToJson(fileName, _selectedTactic);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();

            open.Filter = "Json File (*json) |";
            open.Title = "Select json file";

            open.InitialDirectory = $@"{Directory.GetCurrentDirectory()}";


            if (open.ShowDialog() == DialogResult.Cancel)
                return;

            var fileName = open.FileName;
            if (!fileName.EndsWith(".json"))
                fileName += ".json";

            var tactic = FileHelper.ReadFromJson(fileName);

            try
            {
                LoadData(tactic);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData(Tactic tactic)
        {
            var countryIndex = cmBoxCountries.Items.IndexOf(tactic.CountryName);

            if (countryIndex < 0)
                throw new InvalidOperationException("Json file is corrupted.");

            cmBoxCountries.SelectedIndex = countryIndex;

            var tacticIndex = -1;

            for (int i = 0; i < cmBoxTactics.Items.Count; i++)
            {
                var item = cmBoxTactics.Items[i] as Tactic;

                if (tactic.Name == item.Name)
                {
                    tacticIndex = i;
                    break;
                }
            }


            if (tacticIndex < 0)
                throw new InvalidOperationException("Json file is corrupted.");

            cmBoxTactics.SelectedIndex = tacticIndex;

            for (int i = 0; i < this.panelPlayers.Controls.Count; i++)
            {
                var ucPlayerInfo = this.panelPlayers.Controls[i] as UCPlayerInfo;

                var txtBoxPlayerNumber = ucPlayerInfo.Controls["txtBoxPlayerNumber"] as Guna2TextBox;
                var txtBoxPlayerName = ucPlayerInfo.Controls["txtBoxPlayerName"] as Guna2TextBox;

                txtBoxPlayerNumber.Text = tactic.Players[i].Number.ToString();
                txtBoxPlayerName.Text = tactic.Players[i].Fullname;
            }
        }
    }
}
