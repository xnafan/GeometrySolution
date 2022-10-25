using GeometryWindowsUI.CustomControls;

namespace GeometryWindowsUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstLines = new System.Windows.Forms.ListBox();
            this.lineVisualizerPanel = new GeometryWindowsUI.CustomControls.GeometryPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fiuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedLine = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 33);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstLines);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lineVisualizerPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1040, 621);
            this.splitContainer1.SplitterDistance = 345;
            this.splitContainer1.TabIndex = 0;
            // 
            // lstLines
            // 
            this.lstLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLines.FormattingEnabled = true;
            this.lstLines.ItemHeight = 25;
            this.lstLines.Location = new System.Drawing.Point(0, 0);
            this.lstLines.Margin = new System.Windows.Forms.Padding(2);
            this.lstLines.Name = "lstLines";
            this.lstLines.Size = new System.Drawing.Size(345, 621);
            this.lstLines.TabIndex = 0;
            // 
            // lineVisualizerPanel
            // 
            this.lineVisualizerPanel.CurrentLine = null;
            this.lineVisualizerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineVisualizerPanel.Location = new System.Drawing.Point(0, 0);
            this.lineVisualizerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.lineVisualizerPanel.Name = "lineVisualizerPanel";
            this.lineVisualizerPanel.Size = new System.Drawing.Size(691, 621);
            this.lineVisualizerPanel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fiuleToolStripMenuItem,
            this.linesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1040, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fiuleToolStripMenuItem
            // 
            this.fiuleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fiuleToolStripMenuItem.Name = "fiuleToolStripMenuItem";
            this.fiuleToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fiuleToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.closeToolStripMenuItem.Text = "&Close";
            // 
            // linesToolStripMenuItem
            // 
            this.linesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedLine});
            this.linesToolStripMenuItem.Name = "linesToolStripMenuItem";
            this.linesToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.linesToolStripMenuItem.Text = "&Edit";
            // 
            // deleteSelectedLineToolStripMenuItem
            // 
            this.deleteSelectedLine.Name = "deleteSelectedLineToolStripMenuItem";
            this.deleteSelectedLine.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteSelectedLine.Size = new System.Drawing.Size(303, 34);
            this.deleteSelectedLine.Text = "&Delete selected line";
            this.deleteSelectedLine.Click += new System.EventHandler(this.deleteSelectedLineToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 654);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Geometry visualizer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SplitContainer splitContainer1;
        private GeometryPanel lineVisualizerPanel;
        private ListBox lstLines;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fiuleToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem linesToolStripMenuItem;
        private ToolStripMenuItem deleteSelectedLine;
    }
}