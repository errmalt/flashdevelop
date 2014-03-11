﻿using System;
using System.Windows.Forms;
using flash.tools.debugger;
using System.Collections.Generic;
using FlashDebugger.Debugger;

namespace FlashDebugger
{
    class ThreadsUI : DockPanelControl
    {
        private ListView lv;
        private ColumnHeader imageColumnHeader;
        private ColumnHeader frameColumnHeader;
        private PluginMain pluginMain;
		private int runningImageIndex;
		private int suspendedImageIndex;

        public ThreadsUI(PluginMain pluginMain, ImageList imageList)
        {
            this.pluginMain = pluginMain;

            lv = new ListView();
			lv.ShowItemToolTips = true;
            this.imageColumnHeader = new ColumnHeader();
            this.imageColumnHeader.Text = string.Empty;
            this.imageColumnHeader.Width = 20;

            this.frameColumnHeader = new ColumnHeader();
            this.frameColumnHeader.Text = string.Empty;

            lv.Columns.AddRange(new ColumnHeader[] {
            this.imageColumnHeader,
            this.frameColumnHeader});
            lv.FullRowSelect = true;
            lv.BorderStyle = BorderStyle.None;
            lv.Dock = System.Windows.Forms.DockStyle.Fill;

            lv.SmallImageList = imageList;
            runningImageIndex = imageList.Images.IndexOfKey("StartContinue");
			suspendedImageIndex = imageList.Images.IndexOfKey("Pause");

            lv.View = System.Windows.Forms.View.Details;
            lv.MouseDoubleClick += new MouseEventHandler(lv_MouseDoubleClick);
            lv.KeyDown += new KeyEventHandler(lv_KeyDown);
            lv.SizeChanged += new EventHandler(lv_SizeChanged);

            this.Controls.Add(lv);
        }

        void lv_SizeChanged(object sender, EventArgs e)
        {
            this.frameColumnHeader.Width = lv.Width - this.imageColumnHeader.Width;
        }

        public void ClearItem()
        {
            lv.Items.Clear();
        }

        public void ActiveItem()
        {
            foreach (ListViewItem item in lv.Items)
            {
				if ((int)item.Tag == PluginMain.debugManager.DebuggerInterface.ActiveThreadId)
				{
					item.Font = new System.Drawing.Font(item.Font, System.Drawing.FontStyle.Bold);
				}
				else
				{
					item.Font = new System.Drawing.Font(item.Font, System.Drawing.FontStyle.Regular);
				}
            }
		}

        public void SetThreads(DbgThread[] threads)
        {
            lv.Items.Clear();
			foreach (DbgThread thread in threads)
			{
				int image = thread.IsSuspended ? suspendedImageIndex : runningImageIndex;
				lv.Items.Add(new ListViewItem(new string[] { "", thread.Name }, image));
				lv.Items[lv.Items.Count - 1].Tag = thread.Id;
			}
			ActiveItem();
        }

        void lv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
				if (lv.SelectedIndices.Count > 0)
				{
					PluginMain.debugManager.DebuggerInterface.ActiveThreadId = (int)lv.SelectedItems[0].Tag;
					ActiveItem();
				}
			}
        }

        void lv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
			if (lv.SelectedIndices.Count > 0)
			{
				PluginMain.debugManager.DebuggerInterface.ActiveThreadId = (int)lv.SelectedItems[0].Tag;
				ActiveItem();
			}
        }

    }

}
