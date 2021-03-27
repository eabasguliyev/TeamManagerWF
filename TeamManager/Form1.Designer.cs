
namespace TeamManager
{
    partial class Form1
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
            this.panelFormControl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pcBoxClose = new System.Windows.Forms.PictureBox();
            this.cmBoxCountries = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmBoxTactics = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPlayers = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.buttonCreate = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoad = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.panelFormControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormControl
            // 
            this.panelFormControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(65)))), ((int)(((byte)(98)))));
            this.panelFormControl.Controls.Add(this.label1);
            this.panelFormControl.Controls.Add(this.pcBoxClose);
            this.panelFormControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormControl.Location = new System.Drawing.Point(0, 0);
            this.panelFormControl.Margin = new System.Windows.Forms.Padding(0);
            this.panelFormControl.Name = "panelFormControl";
            this.panelFormControl.Size = new System.Drawing.Size(1095, 52);
            this.panelFormControl.TabIndex = 0;
            this.panelFormControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFormControl_MouseDown);
            this.panelFormControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelFormControl_MouseMove);
            this.panelFormControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelFormControl_MouseUp);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team Manager";
            // 
            // pcBoxClose
            // 
            this.pcBoxClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pcBoxClose.Image = global::TeamManager.Properties.Resources.close_window;
            this.pcBoxClose.Location = new System.Drawing.Point(1045, 4);
            this.pcBoxClose.Margin = new System.Windows.Forms.Padding(2);
            this.pcBoxClose.Name = "pcBoxClose";
            this.pcBoxClose.Size = new System.Drawing.Size(45, 42);
            this.pcBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxClose.TabIndex = 1;
            this.pcBoxClose.TabStop = false;
            this.pcBoxClose.Click += new System.EventHandler(this.pcBoxClose_Click);
            this.pcBoxClose.MouseEnter += new System.EventHandler(this.pcBoxClose_MouseEnter);
            this.pcBoxClose.MouseLeave += new System.EventHandler(this.pcBoxClose_MouseLeave);
            // 
            // cmBoxCountries
            // 
            this.cmBoxCountries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmBoxCountries.AutoRoundedCorners = true;
            this.cmBoxCountries.BackColor = System.Drawing.Color.Transparent;
            this.cmBoxCountries.BorderRadius = 17;
            this.cmBoxCountries.BorderThickness = 0;
            this.cmBoxCountries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmBoxCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxCountries.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmBoxCountries.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmBoxCountries.FocusedState.Parent = this.cmBoxCountries;
            this.cmBoxCountries.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmBoxCountries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmBoxCountries.HoverState.Parent = this.cmBoxCountries;
            this.cmBoxCountries.ItemHeight = 30;
            this.cmBoxCountries.ItemsAppearance.Parent = this.cmBoxCountries;
            this.cmBoxCountries.Location = new System.Drawing.Point(294, 67);
            this.cmBoxCountries.Name = "cmBoxCountries";
            this.cmBoxCountries.ShadowDecoration.Parent = this.cmBoxCountries;
            this.cmBoxCountries.Size = new System.Drawing.Size(354, 36);
            this.cmBoxCountries.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(207, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Country";
            // 
            // cmBoxTactics
            // 
            this.cmBoxTactics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmBoxTactics.AutoRoundedCorners = true;
            this.cmBoxTactics.BackColor = System.Drawing.Color.Transparent;
            this.cmBoxTactics.BorderRadius = 17;
            this.cmBoxTactics.BorderThickness = 0;
            this.cmBoxTactics.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmBoxTactics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxTactics.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmBoxTactics.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmBoxTactics.FocusedState.Parent = this.cmBoxTactics;
            this.cmBoxTactics.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmBoxTactics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmBoxTactics.HoverState.Parent = this.cmBoxTactics;
            this.cmBoxTactics.ItemHeight = 30;
            this.cmBoxTactics.ItemsAppearance.Parent = this.cmBoxTactics;
            this.cmBoxTactics.Location = new System.Drawing.Point(754, 66);
            this.cmBoxTactics.Name = "cmBoxTactics";
            this.cmBoxTactics.ShadowDecoration.Parent = this.cmBoxTactics;
            this.cmBoxTactics.Size = new System.Drawing.Size(135, 36);
            this.cmBoxTactics.TabIndex = 1;
            this.cmBoxTactics.SelectedIndexChanged += new System.EventHandler(this.cmBoxTactics_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(691, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tactic";
            // 
            // panelPlayers
            // 
            this.panelPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPlayers.AutoScroll = true;
            this.panelPlayers.Location = new System.Drawing.Point(0, 169);
            this.panelPlayers.Name = "panelPlayers";
            this.panelPlayers.Size = new System.Drawing.Size(1095, 424);
            this.panelPlayers.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(85, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Position";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(422, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Number";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(852, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Name";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(256, 131);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(19, 40);
            this.guna2VSeparator1.TabIndex = 7;
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.Location = new System.Drawing.Point(678, 131);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(19, 40);
            this.guna2VSeparator2.TabIndex = 7;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.CheckedState.Parent = this.buttonCreate;
            this.buttonCreate.CustomImages.Parent = this.buttonCreate;
            this.buttonCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(65)))), ((int)(((byte)(98)))));
            this.buttonCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCreate.ForeColor = System.Drawing.Color.White;
            this.buttonCreate.HoverState.Parent = this.buttonCreate;
            this.buttonCreate.Location = new System.Drawing.Point(850, 614);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.ShadowDecoration.Parent = this.buttonCreate;
            this.buttonCreate.Size = new System.Drawing.Size(197, 58);
            this.buttonCreate.TabIndex = 8;
            this.buttonCreate.Text = "Generate";
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoad.CheckedState.Parent = this.btnLoad;
            this.btnLoad.CustomImages.Parent = this.btnLoad;
            this.btnLoad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(65)))), ((int)(((byte)(98)))));
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.HoverState.Parent = this.btnLoad;
            this.btnLoad.Location = new System.Drawing.Point(27, 614);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.ShadowDecoration.Parent = this.btnLoad;
            this.btnLoad.Size = new System.Drawing.Size(197, 58);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.Enabled = false;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(238, 614);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(197, 58);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1095, 695);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.guna2VSeparator2);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelPlayers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmBoxTactics);
            this.Controls.Add(this.cmBoxCountries);
            this.Controls.Add(this.panelFormControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1095, 3000);
            this.MinimumSize = new System.Drawing.Size(1095, 626);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelFormControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFormControl;
        private System.Windows.Forms.PictureBox pcBoxClose;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmBoxCountries;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmBoxTactics;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelPlayers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2Button buttonCreate;
        private Guna.UI2.WinForms.Guna2Button btnLoad;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}

