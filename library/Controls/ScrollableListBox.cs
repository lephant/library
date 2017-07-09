using System;
using System.Drawing;
using System.Windows.Forms;

namespace library.Controls
{
    public class ScrollableListBox : ListBox
    {
        private bool mouseOnControl;

        public int ContextMenuItemIndex { get; private set; }

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

        protected override void OnContextMenuChanged(EventArgs e)
        {
            base.OnContextMenuChanged(e);
            ContextMenu.Popup += ContextMenuOnPopup;
        }

        private void ContextMenuOnPopup(object sender, EventArgs e)
        {
            Point controlLocation = PointToScreen(new Point(0, 0));
            Point clickLocation = Point.Subtract(Cursor.Position, (Size) controlLocation);
            ContextMenuItemIndex = this.IndexFromPoint(clickLocation);
        }
    }
}
