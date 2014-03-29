using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using flash.tools.debugger;
using flash.tools.debugger.expression;

namespace FlashDebugger.Controls
{
    public partial class ImmediateUI : DockPanelControl
    {
        private List<string> history;
        private int historyPos;

        public ImmediateUI()
        {
            this.InitializeComponent();
            this.contextMenuStrip.Renderer = new DockPanelStripRenderer(false);
            this.history = new List<string>();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && this.textBox.GetFirstCharIndexOfCurrentLine() == this.textBox.SelectionStart) e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Up && this.historyPos > 0)
            {
                this.historyPos--;
                this.textBox.Select(this.textBox.Text.Length, 0);
                this.textBox.Text = this.textBox.Text.Substring(0, this.textBox.GetFirstCharIndexOfCurrentLine()) + this.history[this.historyPos];
                this.textBox.Select(this.textBox.Text.Length, 0);
                this.textBox.ScrollToCaret();
            }
            if (e.KeyCode == Keys.Down && this.historyPos + 1 < this.history.Count)
            {
                this.historyPos++;
                this.textBox.Select(this.textBox.Text.Length, 0);
                this.textBox.Text = this.textBox.Text.Substring(0, this.textBox.GetFirstCharIndexOfCurrentLine()) + this.history[this.historyPos];
                this.textBox.Select(this.textBox.Text.Length, 0);
                this.textBox.ScrollToCaret();
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                int curLine = this.textBox.GetLineFromCharIndex(this.textBox.SelectionStart);
                //int curLine = 0;
                //int tmp = 0;
                //while (true)
                //{
                //    tmp += this.textBox.Lines[curLine].Length + 2; // newline chars
                //    if (tmp >= this.textBox.SelectionStart) break;
                //    curLine++;
                //}
                string line = "";
                if (curLine<this.textBox.Lines.Length) line = this.textBox.Lines[curLine];
                if (this.textBox.Lines.Length > 0 && !this.textBox.Lines[this.textBox.Lines.Length - 1].Trim().Equals("")) this.textBox.Text += "\r\n";
                try
                {
                    this.history.Add(line);
                    this.historyPos = this.history.Count;
					this.textBox.Text += PluginMain.debugManager.DebuggerInterface.ImmediateProvider.ProcessLine(line);
                }
                catch (Exception ex)
                {
                    this.textBox.Text += ex.ToString();
                }
                if (this.textBox.Lines.Length > 0 && !this.textBox.Lines[this.textBox.Lines.Length - 1].Trim().Equals("")) this.textBox.Text += "\r\n";
                this.textBox.Select(this.textBox.Text.Length, 0);
                this.textBox.ScrollToCaret();
            }
        }
        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox.Clear();
            this.history.Clear();
            this.historyPos = 0;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox.Paste();
        }

    }
}
