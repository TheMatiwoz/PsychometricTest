using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PsychometricTest
{
    public class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(4, 4, ClientSize.Width-10, ClientSize.Height-10);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
}
