﻿namespace ChessyForms
{
    partial class MainForm
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
            this.chessBoard1 = new ChessyForms.ChessBoard();
            this.SuspendLayout();
            // 
            // chessBoard1
            // 
            this.chessBoard1.Location = new System.Drawing.Point(197, 12);
            this.chessBoard1.Name = "chessBoard1";
            this.chessBoard1.Size = new System.Drawing.Size(405, 405);
            this.chessBoard1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chessBoard1);
            this.Name = "MainForm";
            this.Text = "Chessy";
            this.ResumeLayout(false);

        }

        #endregion

        private ChessBoard chessBoard1;
    }
}

