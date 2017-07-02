using System;
using System.Windows.Forms;

namespace library.Controls
{
    public class ScrollablePanel : Panel
    {
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            e.Control.MouseEnter += ControlOnMouseEnter;
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);
            e.Control.MouseEnter -= ControlOnMouseEnter;
        }

        private void ControlOnMouseEnter(object sender, EventArgs e)
        {
            this.Focus();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            this.Focus();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (IsMouseOnControl(e))
            {
                MouseEventArgs eventArgs = new MouseEventArgs(e.Button, e.Clicks, e.X, e.Y, e.Delta / 10);
                base.OnMouseWheel(eventArgs);
            }
        }

        private bool IsMouseOnControl(MouseEventArgs e)
        {
            if (e.X < 0) return false;
            if (e.Y < 0) return false;
            if (e.X >= this.Width) return false;
            if (e.Y >= this.Height) return false;
            return true;
        }
    }
}