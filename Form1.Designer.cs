namespace PathFindGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.LbFilter = new System.Windows.Forms.ListBox();
            this.TbFilter = new System.Windows.Forms.TextBox();
            this.RbTopDown = new System.Windows.Forms.RadioButton();
            this.RbFirstPersonView = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Location = new System.Drawing.Point(197, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 355);
            this.panel1.TabIndex = 0;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(606, 355);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // LbFilter
            // 
            this.LbFilter.FormattingEnabled = true;
            this.LbFilter.Location = new System.Drawing.Point(24, 96);
            this.LbFilter.Name = "LbFilter";
            this.LbFilter.Size = new System.Drawing.Size(167, 355);
            this.LbFilter.TabIndex = 1;
            this.LbFilter.Click += new System.EventHandler(this.LbFilter_Click);
            this.LbFilter.SelectedIndexChanged += new System.EventHandler(this.LbFilter_SelectedIndexChanged);
            // 
            // TbFilter
            // 
            this.TbFilter.Font = new System.Drawing.Font("Arial", 12F);
            this.TbFilter.Location = new System.Drawing.Point(23, 64);
            this.TbFilter.Name = "TbFilter";
            this.TbFilter.Size = new System.Drawing.Size(167, 26);
            this.TbFilter.TabIndex = 2;
            this.TbFilter.TextChanged += new System.EventHandler(this.TbFilter_TextChanged);
            this.TbFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbFilter_KeyUp);
            // 
            // RbTopDown
            // 
            this.RbTopDown.AutoSize = true;
            this.RbTopDown.Location = new System.Drawing.Point(210, 69);
            this.RbTopDown.Name = "RbTopDown";
            this.RbTopDown.Size = new System.Drawing.Size(72, 17);
            this.RbTopDown.TabIndex = 4;
            this.RbTopDown.Text = "TopDown";
            this.RbTopDown.UseVisualStyleBackColor = true;
            this.RbTopDown.CheckedChanged += new System.EventHandler(this.RbTopDown_CheckedChanged);
            // 
            // RbFirstPersonView
            // 
            this.RbFirstPersonView.AutoSize = true;
            this.RbFirstPersonView.Checked = true;
            this.RbFirstPersonView.Location = new System.Drawing.Point(288, 69);
            this.RbFirstPersonView.Name = "RbFirstPersonView";
            this.RbFirstPersonView.Size = new System.Drawing.Size(106, 17);
            this.RbFirstPersonView.TabIndex = 4;
            this.RbFirstPersonView.TabStop = true;
            this.RbFirstPersonView.Text = "First Person View";
            this.RbFirstPersonView.UseVisualStyleBackColor = true;
            this.RbFirstPersonView.CheckedChanged += new System.EventHandler(this.RbFirstPersonView_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 465);
            this.Controls.Add(this.RbFirstPersonView);
            this.Controls.Add(this.RbTopDown);
            this.Controls.Add(this.TbFilter);
            this.Controls.Add(this.LbFilter);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 465);
            this.MinimumSize = new System.Drawing.Size(818, 465);
            this.Name = "Form1";
            this.Text = "Campus Path Finder for IAU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox LbFilter;
        private System.Windows.Forms.TextBox TbFilter;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.RadioButton RbTopDown;
        private System.Windows.Forms.RadioButton RbFirstPersonView;
    }
}

