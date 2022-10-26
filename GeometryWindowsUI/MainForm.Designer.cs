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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstLines = new System.Windows.Forms.ListBox();
            this.lineVisualizerPanel = new GeometryWindowsUI.CustomControls.GeometryPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstLines);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lineVisualizerPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1352, 837);
            this.splitContainer1.SplitterDistance = 448;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // lstLines
            // 
            this.lstLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLines.FormattingEnabled = true;
            this.lstLines.ItemHeight = 32;
            this.lstLines.Location = new System.Drawing.Point(0, 0);
            this.lstLines.Name = "lstLines";
            this.lstLines.Size = new System.Drawing.Size(448, 837);
            this.lstLines.TabIndex = 0;
            this.lstLines.DoubleClick += new System.EventHandler(this.lstLines_DoubleClick);
            // 
            // lineVisualizerPanel
            // 
            this.lineVisualizerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineVisualizerPanel.LineCollection = null;
            this.lineVisualizerPanel.LineCurrentlyBeingDrawnWithMouse = null;
            this.lineVisualizerPanel.Location = new System.Drawing.Point(0, 0);
            this.lineVisualizerPanel.Name = "lineVisualizerPanel";
            this.lineVisualizerPanel.SelectedLine = null;
            this.lineVisualizerPanel.Size = new System.Drawing.Size(899, 837);
            this.lineVisualizerPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 837);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Geometry visualizer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private GeometryPanel lineVisualizerPanel;
        private ListBox lstLines;
    }
}