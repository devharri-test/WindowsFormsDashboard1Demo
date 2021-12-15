using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace Dashboard.UserControls
{
    class ButtonEllipse : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(1, 1, ClientSize.Width - 4, ClientSize.Width - 4);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(pevent);
            
        }
    }
}
