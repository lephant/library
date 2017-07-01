using System;
using System.Windows.Forms;

namespace library.Controls
{
    public class ScrollableListBox : ListBox
    {
        private bool mouseOnControl;

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.Focus();
            mouseOnControl = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            mouseOnControl = false;
        }
        
        protected override void WndProc(ref Message m)
        {
            const int scrollWndMessage = 522;
            // 522 791 20 792 673
            if (m.Msg == scrollWndMessage && !mouseOnControl)
            {
                return;
            }
            base.WndProc(ref m);
        }
    }
}
