
namespace TeamManager
{
    partial class UCPlayer
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
            this.btnPlayer = new Guna.UI2.WinForms.Guna2CircleButton();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlayer
            // 
            this.btnPlayer.CheckedState.Parent = this.btnPlayer;
            this.btnPlayer.CustomImages.Parent = this.btnPlayer;
            this.btnPlayer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlayer.ForeColor = System.Drawing.Color.White;
            this.btnPlayer.HoverState.Parent = this.btnPlayer;
            this.btnPlayer.Location = new System.Drawing.Point(19, 12);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPlayer.ShadowDecoration.Parent = this.btnPlayer;
            this.btnPlayer.Size = new System.Drawing.Size(71, 69);
            this.btnPlayer.TabIndex = 1;
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPlayerName.ForeColor = System.Drawing.Color.Black;
            this.labelPlayerName.Location = new System.Drawing.Point(25, 84);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(55, 23);
            this.labelPlayerName.TabIndex = 4;
            this.labelPlayerName.Text = "Name";
            // 
            // UCPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.btnPlayer);
            this.Name = "UCPlayer";
            this.Size = new System.Drawing.Size(104, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnPlayer;
        private System.Windows.Forms.Label labelPlayerName;
    }
}
