﻿namespace PlottterTester
{
    partial class PlotForm
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
            this.plotBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.plotBox)).BeginInit();
            this.SuspendLayout();
            // 
            // plotBox
            // 
            this.plotBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotBox.Location = new System.Drawing.Point(0, 0);
            this.plotBox.Name = "plotBox";
            this.plotBox.Size = new System.Drawing.Size(284, 261);
            this.plotBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plotBox.TabIndex = 0;
            this.plotBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.plotBox);
            this.Name = "Form1";
            this.Text = "Plot";
            ((System.ComponentModel.ISupportInitialize)(this.plotBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox plotBox;
    }
}

