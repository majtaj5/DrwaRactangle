
namespace DrwaRactangle
{
    partial class RactangleForm
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
            this.gbRactangleForm = new System.Windows.Forms.GroupBox();
            this.gdCoordinates = new System.Windows.Forms.GroupBox();
            this.txtYcoord = new System.Windows.Forms.TextBox();
            this.txtXCoord = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbPickOnScreen = new System.Windows.Forms.RadioButton();
            this.rbCooordinates = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.txtwidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRanctangle = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gbRactangleForm.SuspendLayout();
            this.gdCoordinates.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRactangleForm
            // 
            this.gbRactangleForm.Controls.Add(this.lblInfo);
            this.gbRactangleForm.Controls.Add(this.btnRanctangle);
            this.gbRactangleForm.Controls.Add(this.gdCoordinates);
            this.gbRactangleForm.Controls.Add(this.rbPickOnScreen);
            this.gbRactangleForm.Controls.Add(this.rbCooordinates);
            this.gbRactangleForm.Controls.Add(this.label3);
            this.gbRactangleForm.Controls.Add(this.txtheight);
            this.gbRactangleForm.Controls.Add(this.txtwidth);
            this.gbRactangleForm.Controls.Add(this.label2);
            this.gbRactangleForm.Controls.Add(this.label1);
            this.gbRactangleForm.Location = new System.Drawing.Point(12, 12);
            this.gbRactangleForm.Name = "gbRactangleForm";
            this.gbRactangleForm.Size = new System.Drawing.Size(302, 330);
            this.gbRactangleForm.TabIndex = 0;
            this.gbRactangleForm.TabStop = false;
            this.gbRactangleForm.Text = "Enter Ractangle Parameters";
            // 
            // gdCoordinates
            // 
            this.gdCoordinates.Controls.Add(this.txtYcoord);
            this.gdCoordinates.Controls.Add(this.txtXCoord);
            this.gdCoordinates.Controls.Add(this.label6);
            this.gdCoordinates.Controls.Add(this.label5);
            this.gdCoordinates.Controls.Add(this.label4);
            this.gdCoordinates.Location = new System.Drawing.Point(12, 177);
            this.gdCoordinates.Name = "gdCoordinates";
            this.gdCoordinates.Size = new System.Drawing.Size(284, 90);
            this.gdCoordinates.TabIndex = 7;
            this.gdCoordinates.TabStop = false;
            this.gdCoordinates.Text = "Enter Coordinates";
            // 
            // txtYcoord
            // 
            this.txtYcoord.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtYcoord.Location = new System.Drawing.Point(124, 53);
            this.txtYcoord.Name = "txtYcoord";
            this.txtYcoord.Size = new System.Drawing.Size(100, 20);
            this.txtYcoord.TabIndex = 4;
            // 
            // txtXCoord
            // 
            this.txtXCoord.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtXCoord.Location = new System.Drawing.Point(124, 19);
            this.txtXCoord.Name = "txtXCoord";
            this.txtXCoord.Size = new System.Drawing.Size(100, 20);
            this.txtXCoord.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Y coordinate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "X coordinate";
            // 
            // rbPickOnScreen
            // 
            this.rbPickOnScreen.AutoSize = true;
            this.rbPickOnScreen.Location = new System.Drawing.Point(150, 132);
            this.rbPickOnScreen.Name = "rbPickOnScreen";
            this.rbPickOnScreen.Size = new System.Drawing.Size(102, 17);
            this.rbPickOnScreen.TabIndex = 6;
            this.rbPickOnScreen.TabStop = true;
            this.rbPickOnScreen.Text = "Pick on screeen";
            this.rbPickOnScreen.UseVisualStyleBackColor = true;
            // 
            // rbCooordinates
            // 
            this.rbCooordinates.AutoSize = true;
            this.rbCooordinates.Location = new System.Drawing.Point(12, 132);
            this.rbCooordinates.Name = "rbCooordinates";
            this.rbCooordinates.Size = new System.Drawing.Size(108, 17);
            this.rbCooordinates.TabIndex = 5;
            this.rbCooordinates.TabStop = true;
            this.rbCooordinates.Text = "Enter coordinates";
            this.rbCooordinates.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose starting point ";
            // 
            // txtheight
            // 
            this.txtheight.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtheight.Location = new System.Drawing.Point(93, 63);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(100, 20);
            this.txtheight.TabIndex = 3;
            // 
            // txtwidth
            // 
            this.txtwidth.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtwidth.Location = new System.Drawing.Point(93, 33);
            this.txtwidth.Name = "txtwidth";
            this.txtwidth.Size = new System.Drawing.Size(100, 20);
            this.txtwidth.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter width";
            // 
            // btnRanctangle
            // 
            this.btnRanctangle.BackColor = System.Drawing.Color.PaleGreen;
            this.btnRanctangle.Location = new System.Drawing.Point(12, 292);
            this.btnRanctangle.Name = "btnRanctangle";
            this.btnRanctangle.Size = new System.Drawing.Size(284, 23);
            this.btnRanctangle.TabIndex = 8;
            this.btnRanctangle.Text = "Draw ractangle";
            this.btnRanctangle.UseVisualStyleBackColor = false;
            this.btnRanctangle.Click += new System.EventHandler(this.btnRanctangle_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 331);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(16, 13);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "...";
            // 
            // RactangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 354);
            this.Controls.Add(this.gbRactangleForm);
            this.MaximizeBox = false;
            this.Name = "RactangleForm";
            this.Text = "RactangleForm";
            this.gbRactangleForm.ResumeLayout(false);
            this.gbRactangleForm.PerformLayout();
            this.gdCoordinates.ResumeLayout(false);
            this.gdCoordinates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRactangleForm;
        private System.Windows.Forms.GroupBox gdCoordinates;
        private System.Windows.Forms.RadioButton rbPickOnScreen;
        private System.Windows.Forms.RadioButton rbCooordinates;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.TextBox txtwidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYcoord;
        private System.Windows.Forms.TextBox txtXCoord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnRanctangle;
    }
}