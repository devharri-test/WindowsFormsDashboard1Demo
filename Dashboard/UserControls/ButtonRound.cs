using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.UserControls
{
    class ButtonRound : Control
    {
        private readonly Label lbl;
        public ButtonRound() : base()
        {
            lbl = new Label
            {
                Text = Text,
                ForeColor = ForeColor,
                BackColor = BackColor,
                Font = Font
            };
            CenterInParent();
        }
        private void CenterInParent()
        {
            lbl.Left = (Width - lbl.Width) / 2;
            lbl.Top = (Height - lbl.Height) / 2;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, (ClientSize.Width-2), (ClientSize.Height-2));
            Region = new Region(grPath);
            base.OnPaint(e);
        }
        protected override void OnMove(EventArgs e)
        {
            CenterInParent();
            base.OnMove(e);
        }
        protected override void OnTextChanged(EventArgs e)
        {
            lbl.Text = Text;
            base.OnTextChanged(e);
        }
        protected override void OnForeColorChanged(EventArgs e)
        {
            lbl.ForeColor = ForeColor;
            base.OnForeColorChanged(e);
        }
        protected override void OnBackColorChanged(EventArgs e)
        {
            lbl.BackColor = BackColor;
            base.OnBackColorChanged(e);
        }
        protected override void OnFontChanged(EventArgs e)
        {
            lbl.Font = Font;
            base.OnFontChanged(e);
        }
    }
}
