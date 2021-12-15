
namespace Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonEllipse1 = new Dashboard.UserControls.ButtonEllipse();
            this.buttonEllipse2 = new Dashboard.UserControls.ButtonEllipse();
            this.buttonEllipse3 = new Dashboard.UserControls.ButtonEllipse();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnAboutUs);
            this.panel1.Controls.Add(this.btnCalendar);
            this.panel1.Controls.Add(this.btnAnalytics);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 192);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 2;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            this.btnSettings.Location = new System.Drawing.Point(0, 535);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(186, 42);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.Leave += new System.EventHandler(this.btnSettings_Leave);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            this.btnAboutUs.Location = new System.Drawing.Point(0, 270);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(186, 42);
            this.btnAboutUs.TabIndex = 4;
            this.btnAboutUs.Text = "About us";
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            this.btnAboutUs.Leave += new System.EventHandler(this.btnAboutUs_Leave);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            this.btnCalendar.Location = new System.Drawing.Point(0, 228);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(186, 42);
            this.btnCalendar.TabIndex = 3;
            this.btnCalendar.Text = "Calendar";
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            this.btnCalendar.Leave += new System.EventHandler(this.btnCalendar_Leave);
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnalytics.FlatAppearance.BorderSize = 0;
            this.btnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalytics.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            this.btnAnalytics.Location = new System.Drawing.Point(0, 186);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(186, 42);
            this.btnAnalytics.TabIndex = 2;
            this.btnAnalytics.Text = "Analytics";
            this.btnAnalytics.UseVisualStyleBackColor = true;
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);
            this.btnAnalytics.Leave += new System.EventHandler(this.btnAnalytics_Leave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            this.btnDashboard.Location = new System.Drawing.Point(0, 144);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(186, 42);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonEllipse3);
            this.panel2.Controls.Add(this.buttonEllipse2);
            this.panel2.Controls.Add(this.buttonEllipse1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Some user text here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(56, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dashboard.Properties.Resources.Yksivärinen_neliö_Valkoinen;
            this.pictureBox1.Location = new System.Drawing.Point(59, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(186, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(765, 577);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // buttonEllipse1
            // 
            this.buttonEllipse1.BackColor = System.Drawing.Color.Red;
            this.buttonEllipse1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEllipse1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonEllipse1.FlatAppearance.BorderSize = 0;
            this.buttonEllipse1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonEllipse1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonEllipse1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEllipse1.ForeColor = System.Drawing.Color.Red;
            this.buttonEllipse1.Location = new System.Drawing.Point(6, 5);
            this.buttonEllipse1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEllipse1.Name = "buttonEllipse1";
            this.buttonEllipse1.Size = new System.Drawing.Size(20, 20);
            this.buttonEllipse1.TabIndex = 0;
            this.buttonEllipse1.UseVisualStyleBackColor = false;
            this.buttonEllipse1.Click += new System.EventHandler(this.buttonEllipse1_Click);
            // 
            // buttonEllipse2
            // 
            this.buttonEllipse2.BackColor = System.Drawing.Color.Yellow;
            this.buttonEllipse2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEllipse2.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonEllipse2.FlatAppearance.BorderSize = 0;
            this.buttonEllipse2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.buttonEllipse2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonEllipse2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEllipse2.ForeColor = System.Drawing.Color.Yellow;
            this.buttonEllipse2.Location = new System.Drawing.Point(27, 5);
            this.buttonEllipse2.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEllipse2.Name = "buttonEllipse2";
            this.buttonEllipse2.Size = new System.Drawing.Size(20, 20);
            this.buttonEllipse2.TabIndex = 2;
            this.buttonEllipse2.UseVisualStyleBackColor = false;
            // 
            // buttonEllipse3
            // 
            this.buttonEllipse3.BackColor = System.Drawing.Color.Lime;
            this.buttonEllipse3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEllipse3.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonEllipse3.FlatAppearance.BorderSize = 0;
            this.buttonEllipse3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonEllipse3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonEllipse3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEllipse3.ForeColor = System.Drawing.Color.Lime;
            this.buttonEllipse3.Location = new System.Drawing.Point(48, 5);
            this.buttonEllipse3.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEllipse3.Name = "buttonEllipse3";
            this.buttonEllipse3.Size = new System.Drawing.Size(20, 20);
            this.buttonEllipse3.TabIndex = 3;
            this.buttonEllipse3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enmac Vision System";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel panel3;
        private UserControls.ButtonEllipse buttonEllipse1;
        private UserControls.ButtonEllipse buttonEllipse2;
        private UserControls.ButtonEllipse buttonEllipse3;
    }
}

