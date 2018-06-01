﻿namespace TreeViewCheckUnCheckHierarchyExample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    public class ExTreeView : TreeView
    {
        private const int WM_LBUTTONDBLCLK = 0x0203;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDBLCLK)
            {
                var info = this.HitTest(PointToClient(Cursor.Position));
                if (info.Location == TreeViewHitTestLocations.StateImage)
                {
                    m.Result = IntPtr.Zero;
                    return;
                }
            }
            base.WndProc(ref m);
        }
    }
}
