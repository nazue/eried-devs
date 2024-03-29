using System;
using System.Windows.Forms;

namespace InterfazTerceraEdad
{

    public class BetterListBox : ListBox
    {
        // Event declaration
        public delegate void BetterListBoxScrollDelegate(object Sender, BetterListBoxScrollArgs e);
        public event BetterListBoxScrollDelegate Scroll;
        // WM_VSCROLL message constants
        private const int WM_VSCROLL = 0x0115;
        private const int SB_THUMBTRACK = 5;
        private const int SB_ENDSCROLL = 8;

        protected override void WndProc(ref Message m)
        {
            try
            {
                // Trap the WM_VSCROLL message to generate the Scroll event
                base.WndProc(ref m);
                if (m.Msg == WM_VSCROLL)
                {
                    int nfy = m.WParam.ToInt32() & 0xFFFF;
                    if (nfy == SB_THUMBTRACK || nfy == SB_ENDSCROLL)
                        Scroll.Invoke(this, new BetterListBoxScrollArgs(this.TopIndex, nfy == SB_THUMBTRACK));
                }
            }
            catch { }
        }
        public class BetterListBoxScrollArgs
        {
            // Scroll event argument
            private int mTop;
            private bool mTracking;
            public BetterListBoxScrollArgs(int top, bool tracking)
            {
                mTop = top;
                mTracking = tracking;
            }
            public int Top
            {
                get { return mTop; }
            }
            public bool Tracking
            {
                get { return mTracking; }
            }
        }
    }
}
