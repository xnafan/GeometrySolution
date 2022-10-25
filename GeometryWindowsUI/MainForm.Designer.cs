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
            this.gmtpnlLineVisualizer = new GeometryWindowsUI.CustomControls.GeometryPanel();
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstLines);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gmtpnlLineVisualizer);
            this.splitContainer1.Size = new System.Drawing.Size(832, 523);
            this.splitContainer1.SplitterDistance = 276;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // lstLines
            // 
            this.lstLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLines.FormattingEnabled = true;
            this.lstLines.ItemHeight = 20;
            this.lstLines.Location = new System.Drawing.Point(0, 0);
            this.lstLines.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstLines.Name = "lstLines";
            this.lstLines.Size = new System.Drawing.Size(276, 523);
            this.lstLines.TabIndex = 0;
            this.lstLines.SelectedIndexChanged += new System.EventHandler(this.lstLines_SelectedIndexChanged);
            // 
            // gmtpnlLineVisualizer
            // 
            this.gmtpnlLineVisualizer.CurrentLine = null;
            this.gmtpnlLineVisualizer.Dock = System.Windows.Forms.DockStyle.Top;
            this.gmtpnlLineVisualizer.Location = new System.Drawing.Point(0, 0);
            this.gmtpnlLineVisualizer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gmtpnlLineVisualizer.Name = "gmtpnlLineVisualizer";
            this.gmtpnlLineVisualizer.Size = new System.Drawing.Size(553, 523);
            this.gmtpnlLineVisualizer.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 523);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private GeometryPanel gmtpnlLineVisualizer;
        private ListBox lstLines;
    }
}