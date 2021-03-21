using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace TeamManager
{
    public partial class UCPlayerInfo : UserControl
    {
        public UCPlayerInfo()
        {
            InitializeComponent();
        }

        private void txtBoxPlayerNumber_TextChanged(object sender, System.EventArgs e)
        {
            var txtBox = sender as Guna2TextBox;

            ChangeTxtBoxForeColor(txtBox);

            var charCount = txtBox.Text.Length;


            if (txtBox.Text.Length == 1 && txtBox.Text[0] == '0')
            {
                txtBox.Text = String.Empty;
            }
            else if (charCount > 0 && !Regex.IsMatch(txtBox.Text, "^[0-9]"))
                txtBox.Text = txtBox.Text.Remove(charCount - 1);
        }

        private void ChangeTxtBoxForeColor(Guna2TextBox txtBox)
        {
            if (txtBox.ForeColor == Color.FromArgb(125, 137, 149))
                txtBox.ForeColor = Color.Black;
        }

        private void txtBoxPlayerName_TextChanged(object sender, System.EventArgs e)
        {
            var txtBox = sender as Guna2TextBox;

            ChangeTxtBoxForeColor(txtBox);
        }

        private void txtBoxPlayerNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
