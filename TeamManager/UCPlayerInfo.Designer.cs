
namespace TeamManager
{
    partial class UCPlayerInfo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlayerPosition = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtBoxPlayerNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxPlayerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.SuspendLayout();
            // 
            // btnPlayerPosition
            // 
            this.btnPlayerPosition.CheckedState.Parent = this.btnPlayerPosition;
            this.btnPlayerPosition.CustomImages.Parent = this.btnPlayerPosition;
            this.btnPlayerPosition.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlayerPosition.ForeColor = System.Drawing.Color.Black;
            this.btnPlayerPosition.HoverState.Parent = this.btnPlayerPosition;
            this.btnPlayerPosition.Location = new System.Drawing.Point(87, 12);
            this.btnPlayerPosition.Name = "btnPlayerPosition";
            this.btnPlayerPosition.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPlayerPosition.ShadowDecoration.Parent = this.btnPlayerPosition;
            this.btnPlayerPosition.Size = new System.Drawing.Size(80, 77);
            this.btnPlayerPosition.TabIndex = 0;
            // 
            // txtBoxPlayerNumber
            // 
            this.txtBoxPlayerNumber.AutoRoundedCorners = true;
            this.txtBoxPlayerNumber.BorderRadius = 17;
            this.txtBoxPlayerNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxPlayerNumber.DefaultText = "";
            this.txtBoxPlayerNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxPlayerNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxPlayerNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPlayerNumber.DisabledState.Parent = this.txtBoxPlayerNumber;
            this.txtBoxPlayerNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPlayerNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPlayerNumber.FocusedState.Parent = this.txtBoxPlayerNumber;
            this.txtBoxPlayerNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxPlayerNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPlayerNumber.HoverState.Parent = this.txtBoxPlayerNumber;
            this.txtBoxPlayerNumber.Location = new System.Drawing.Point(359, 36);
            this.txtBoxPlayerNumber.MaxLength = 2;
            this.txtBoxPlayerNumber.Name = "txtBoxPlayerNumber";
            this.txtBoxPlayerNumber.PasswordChar = '\0';
            this.txtBoxPlayerNumber.PlaceholderText = "Player number";
            this.txtBoxPlayerNumber.SelectedText = "";
            this.txtBoxPlayerNumber.ShadowDecoration.Parent = this.txtBoxPlayerNumber;
            this.txtBoxPlayerNumber.Size = new System.Drawing.Size(230, 36);
            this.txtBoxPlayerNumber.TabIndex = 1;
            this.txtBoxPlayerNumber.TextChanged += new System.EventHandler(this.txtBoxPlayerNumber_TextChanged);
            this.txtBoxPlayerNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPlayerNumber_KeyPress);
            // 
            // txtBoxPlayerName
            // 
            this.txtBoxPlayerName.AutoRoundedCorners = true;
            this.txtBoxPlayerName.BorderRadius = 17;
            this.txtBoxPlayerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxPlayerName.DefaultText = "";
            this.txtBoxPlayerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxPlayerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxPlayerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPlayerName.DisabledState.Parent = this.txtBoxPlayerName;
            this.txtBoxPlayerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPlayerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPlayerName.FocusedState.Parent = this.txtBoxPlayerName;
            this.txtBoxPlayerName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxPlayerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPlayerName.HoverState.Parent = this.txtBoxPlayerName;
            this.txtBoxPlayerName.Location = new System.Drawing.Point(751, 36);
            this.txtBoxPlayerName.MaxLength = 30;
            this.txtBoxPlayerName.Name = "txtBoxPlayerName";
            this.txtBoxPlayerName.PasswordChar = '\0';
            this.txtBoxPlayerName.PlaceholderText = "Player name";
            this.txtBoxPlayerName.SelectedText = "";
            this.txtBoxPlayerName.ShadowDecoration.Parent = this.txtBoxPlayerName;
            this.txtBoxPlayerName.Size = new System.Drawing.Size(259, 36);
            this.txtBoxPlayerName.TabIndex = 2;
            this.txtBoxPlayerName.TextChanged += new System.EventHandler(this.txtBoxPlayerName_TextChanged);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(256, 0);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(19, 107);
            this.guna2VSeparator1.TabIndex = 8;
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.Location = new System.Drawing.Point(678, 0);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(19, 107);
            this.guna2VSeparator2.TabIndex = 9;
            // 
            // UCPlayerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.guna2VSeparator2);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.txtBoxPlayerName);
            this.Controls.Add(this.txtBoxPlayerNumber);
            this.Controls.Add(this.btnPlayerPosition);
            this.Name = "UCPlayerInfo";
            this.Size = new System.Drawing.Size(1074, 107);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnPlayerPosition;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxPlayerNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxPlayerName;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
    }
}
