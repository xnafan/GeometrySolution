namespace GeometryWindowsUI
{
    partial class LineDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblPoint1X = new System.Windows.Forms.Label();
            this.numPoint1_X = new System.Windows.Forms.NumericUpDown();
            this.numPoint1_Y = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPoint1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numPoint2_X = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numPoint2_Y = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPoint1_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoint1_Y)).BeginInit();
            this.grpPoint1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPoint2_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoint2_Y)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(44, 299);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 44);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(296, 299);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(146, 44);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblPoint1X
            // 
            this.lblPoint1X.AutoSize = true;
            this.lblPoint1X.Location = new System.Drawing.Point(25, 52);
            this.lblPoint1X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoint1X.Name = "lblPoint1X";
            this.lblPoint1X.Size = new System.Drawing.Size(33, 32);
            this.lblPoint1X.TabIndex = 5;
            this.lblPoint1X.Text = "X:";
            // 
            // numPoint1_X
            // 
            this.numPoint1_X.Location = new System.Drawing.Point(66, 52);
            this.numPoint1_X.Margin = new System.Windows.Forms.Padding(5);
            this.numPoint1_X.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPoint1_X.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numPoint1_X.Name = "numPoint1_X";
            this.numPoint1_X.Size = new System.Drawing.Size(148, 39);
            this.numPoint1_X.TabIndex = 6;
            // 
            // numPoint1_Y
            // 
            this.numPoint1_Y.Location = new System.Drawing.Point(277, 54);
            this.numPoint1_Y.Margin = new System.Windows.Forms.Padding(6);
            this.numPoint1_Y.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPoint1_Y.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numPoint1_Y.Name = "numPoint1_Y";
            this.numPoint1_Y.Size = new System.Drawing.Size(148, 39);
            this.numPoint1_Y.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Y:";
            // 
            // grpPoint1
            // 
            this.grpPoint1.Controls.Add(this.numPoint1_X);
            this.grpPoint1.Controls.Add(this.lblPoint1X);
            this.grpPoint1.Controls.Add(this.numPoint1_Y);
            this.grpPoint1.Controls.Add(this.label1);
            this.grpPoint1.Location = new System.Drawing.Point(19, 12);
            this.grpPoint1.Name = "grpPoint1";
            this.grpPoint1.Size = new System.Drawing.Size(450, 126);
            this.grpPoint1.TabIndex = 7;
            this.grpPoint1.TabStop = false;
            this.grpPoint1.Text = "Point 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numPoint2_X);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numPoint2_Y);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(19, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 126);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Point 2";
            // 
            // numPoint2_X
            // 
            this.numPoint2_X.Location = new System.Drawing.Point(66, 52);
            this.numPoint2_X.Margin = new System.Windows.Forms.Padding(5);
            this.numPoint2_X.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPoint2_X.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numPoint2_X.Name = "numPoint2_X";
            this.numPoint2_X.Size = new System.Drawing.Size(148, 39);
            this.numPoint2_X.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "X:";
            // 
            // numPoint2_Y
            // 
            this.numPoint2_Y.Location = new System.Drawing.Point(277, 54);
            this.numPoint2_Y.Margin = new System.Windows.Forms.Padding(6);
            this.numPoint2_Y.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPoint2_Y.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numPoint2_Y.Name = "numPoint2_Y";
            this.numPoint2_Y.Size = new System.Drawing.Size(148, 39);
            this.numPoint2_Y.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y:";
            // 
            // LineDialog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(483, 364);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPoint1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LineDialog";
            this.Text = "Line editor (only values from -1000 to 1000)";
            ((System.ComponentModel.ISupportInitialize)(this.numPoint1_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoint1_Y)).EndInit();
            this.grpPoint1.ResumeLayout(false);
            this.grpPoint1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPoint2_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoint2_Y)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCancel;
        private Button btnOk;
        private Label lblPoint1X;
        private NumericUpDown numPoint1_X;
        private NumericUpDown numPoint1_Y;
        private Label label1;
        private GroupBox grpPoint1;
        private GroupBox groupBox1;
        private NumericUpDown numPoint2_X;
        private Label label2;
        private NumericUpDown numPoint2_Y;
        private Label label3;
    }
}