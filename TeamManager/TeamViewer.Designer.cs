
namespace TeamManager
{
    partial class TeamViewer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelFormControl = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pcBoxBack = new System.Windows.Forms.PictureBox();
            this.panelGameArea = new System.Windows.Forms.Panel();
            this.labelTactic = new System.Windows.Forms.Label();
            this.pcBoxCountryFlag = new Guna.UI2.WinForms.Guna2PictureBox();
            this.contextMenuStripTeamViewer = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showPlayerPositionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFormControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxCountryFlag)).BeginInit();
            this.contextMenuStripTeamViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormControl
            // 
            this.panelFormControl.Controls.Add(this.pcBoxBack);
            this.panelFormControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormControl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(194)))), ((int)(((byte)(52)))));
            this.panelFormControl.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(194)))), ((int)(((byte)(52)))));
            this.panelFormControl.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(23)))), ((int)(((byte)(0)))));
            this.panelFormControl.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(23)))), ((int)(((byte)(0)))));
            this.panelFormControl.Location = new System.Drawing.Point(0, 0);
            this.panelFormControl.Name = "panelFormControl";
            this.panelFormControl.ShadowDecoration.Parent = this.panelFormControl;
            this.panelFormControl.Size = new System.Drawing.Size(554, 50);
            this.panelFormControl.TabIndex = 0;
            this.panelFormControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFormControl_MouseDown);
            this.panelFormControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelFormControl_MouseMove);
            this.panelFormControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelFormControl_MouseUp);
            // 
            // pcBoxBack
            // 
            this.pcBoxBack.BackColor = System.Drawing.Color.Transparent;
            this.pcBoxBack.Image = global::TeamManager.Properties.Resources.back_60px;
            this.pcBoxBack.Location = new System.Drawing.Point(7, 4);
            this.pcBoxBack.Margin = new System.Windows.Forms.Padding(2);
            this.pcBoxBack.Name = "pcBoxBack";
            this.pcBoxBack.Size = new System.Drawing.Size(45, 42);
            this.pcBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxBack.TabIndex = 2;
            this.pcBoxBack.TabStop = false;
            this.pcBoxBack.Click += new System.EventHandler(this.pcBoxBack_Click);
            this.pcBoxBack.MouseEnter += new System.EventHandler(this.pcBoxBack_MouseEnter);
            this.pcBoxBack.MouseLeave += new System.EventHandler(this.pcBoxBack_MouseLeave);
            // 
            // panelGameArea
            // 
            this.panelGameArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGameArea.BackColor = System.Drawing.Color.White;
            this.panelGameArea.BackgroundImage = global::TeamManager.Properties.Resources.soccer_area_image;
            this.panelGameArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGameArea.Location = new System.Drawing.Point(0, 149);
            this.panelGameArea.Name = "panelGameArea";
            this.panelGameArea.Size = new System.Drawing.Size(554, 665);
            this.panelGameArea.TabIndex = 1;
            // 
            // labelTactic
            // 
            this.labelTactic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTactic.AutoSize = true;
            this.labelTactic.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTactic.ForeColor = System.Drawing.Color.Black;
            this.labelTactic.Location = new System.Drawing.Point(401, 86);
            this.labelTactic.Name = "labelTactic";
            this.labelTactic.Size = new System.Drawing.Size(92, 40);
            this.labelTactic.TabIndex = 3;
            this.labelTactic.Text = "Tactic";
            // 
            // pcBoxCountryFlag
            // 
            this.pcBoxCountryFlag.BackColor = System.Drawing.Color.Transparent;
            this.pcBoxCountryFlag.BorderRadius = 15;
            this.pcBoxCountryFlag.Image = global::TeamManager.Properties.Resources.azerbaijan_flag;
            this.pcBoxCountryFlag.Location = new System.Drawing.Point(12, 56);
            this.pcBoxCountryFlag.Name = "pcBoxCountryFlag";
            this.pcBoxCountryFlag.ShadowDecoration.Parent = this.pcBoxCountryFlag;
            this.pcBoxCountryFlag.Size = new System.Drawing.Size(133, 87);
            this.pcBoxCountryFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxCountryFlag.TabIndex = 4;
            this.pcBoxCountryFlag.TabStop = false;
            this.pcBoxCountryFlag.UseTransparentBackground = true;
            // 
            // contextMenuStripTeamViewer
            // 
            this.contextMenuStripTeamViewer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripTeamViewer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPlayerPositionsToolStripMenuItem});
            this.contextMenuStripTeamViewer.Name = "contextMenuStripTeamViewer";
            this.contextMenuStripTeamViewer.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.contextMenuStripTeamViewer.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.contextMenuStripTeamViewer.RenderStyle.ColorTable = null;
            this.contextMenuStripTeamViewer.RenderStyle.RoundedEdges = true;
            this.contextMenuStripTeamViewer.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.contextMenuStripTeamViewer.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.contextMenuStripTeamViewer.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.contextMenuStripTeamViewer.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.contextMenuStripTeamViewer.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.contextMenuStripTeamViewer.Size = new System.Drawing.Size(221, 28);
            // 
            // showPlayerPositionsToolStripMenuItem
            // 
            this.showPlayerPositionsToolStripMenuItem.Name = "showPlayerPositionsToolStripMenuItem";
            this.showPlayerPositionsToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.showPlayerPositionsToolStripMenuItem.Text = "Show Player Positions";
            this.showPlayerPositionsToolStripMenuItem.Click += new System.EventHandler(this.showPlayerPositionsToolStripMenuItem_Click);
            // 
            // TeamViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(205)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(554, 812);
            this.ContextMenuStrip = this.contextMenuStripTeamViewer;
            this.Controls.Add(this.pcBoxCountryFlag);
            this.Controls.Add(this.labelTactic);
            this.Controls.Add(this.panelGameArea);
            this.Controls.Add(this.panelFormControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeamViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Viewer";
            this.Load += new System.EventHandler(this.TeamViewer_Load);
            this.panelFormControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxCountryFlag)).EndInit();
            this.contextMenuStripTeamViewer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelFormControl;
        private System.Windows.Forms.PictureBox pcBoxBack;
        private System.Windows.Forms.Panel panelGameArea;
        private System.Windows.Forms.Label labelTactic;
        private Guna.UI2.WinForms.Guna2PictureBox pcBoxCountryFlag;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip contextMenuStripTeamViewer;
        private System.Windows.Forms.ToolStripMenuItem showPlayerPositionsToolStripMenuItem;
    }
}