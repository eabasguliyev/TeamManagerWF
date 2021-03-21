
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
            this.btnPlayerAbbreviation = new Guna.UI2.WinForms.Guna2CircleButton();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlayerAbbreviation
            // 
            this.btnPlayerAbbreviation.CheckedState.Parent = this.btnPlayerAbbreviation;
            this.btnPlayerAbbreviation.CustomImages.Parent = this.btnPlayerAbbreviation;
            this.btnPlayerAbbreviation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlayerAbbreviation.ForeColor = System.Drawing.Color.White;
            this.btnPlayerAbbreviation.HoverState.Parent = this.btnPlayerAbbreviation;
            this.btnPlayerAbbreviation.Location = new System.Drawing.Point(30, 6);
            this.btnPlayerAbbreviation.Name = "btnPlayerAbbreviation";
            this.btnPlayerAbbreviation.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPlayerAbbreviation.ShadowDecoration.Parent = this.btnPlayerAbbreviation;
            this.btnPlayerAbbreviation.Size = new System.Drawing.Size(71, 69);
            this.btnPlayerAbbreviation.TabIndex = 1;
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPlayerName.ForeColor = System.Drawing.Color.Black;
            this.labelPlayerName.Location = new System.Drawing.Point(15, 91);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(55, 23);
            this.labelPlayerName.TabIndex = 4;
            this.labelPlayerName.Text = "Name";
            // 
            // UCPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.btnPlayerAbbreviation);
            this.Name = "UCPlayer";
            this.Size = new System.Drawing.Size(129, 127);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnPlayerAbbreviation;
        private System.Windows.Forms.Label labelPlayerName;
    }
}
