using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dashboard.ChildForms;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0,0);


        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //    (
        //    int nLeftRect,
        //    int nTopRect,
        //    int nRightRect,
        //    int nBottomRect,
        //    int nWidthEllipse,
        //    int nHeightEllipse
        //    );

        public Form1()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;

            
            //btnDashboard.BackColor = Color.FromArgb(0, 64, 135);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(0, 64, 135);

            //Open window to childform "panel3"
            OpenChildForm(new ChildForm_Charts());

        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            pnlNav.Left = btnAnalytics.Left;
            btnAnalytics.BackColor = Color.FromArgb(0, 64, 135);

            //Open window to childform "panel3"
            OpenChildForm(new ChildForm_Analytics());
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalendar.Height;
            pnlNav.Top = btnCalendar.Top;
            pnlNav.Left = btnCalendar.Left;
            btnCalendar.BackColor = Color.FromArgb(0, 64, 135);

            //Open window to childform "panel3"
            OpenChildForm(new ChildForm_Calendar());
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAboutUs.Height;
            pnlNav.Top = btnAboutUs.Top;
            pnlNav.Left = btnAboutUs.Left;
            btnAboutUs.BackColor = Color.FromArgb(0, 64, 135);

            //Open window to childform "panel3"
            OpenChildForm(new ChildForm_AboutUs());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromArgb(0, 64, 135);

            //Open window to childform "panel3"
            OpenChildForm(new ChildForm_Settings());
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(9, 40, 82);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(9, 40, 82);
        }

        private void btnCalendar_Leave(object sender, EventArgs e)
        {
            btnCalendar.BackColor = Color.FromArgb(9, 40, 82);
        }

        private void btnAboutUs_Leave(object sender, EventArgs e)
        {
            btnAboutUs.BackColor = Color.FromArgb(9, 40, 82);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(9, 40, 82);
        }

        
        private Form ActiveChildForm = null;

        private void OpenChildForm(Form childForm)
        {
            if (ActiveChildForm != null)
            {
                ActiveChildForm.Close();
            }
            ActiveChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonEllipse1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging == true)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
    }
}
