﻿namespace SyntaxWinApp02
{
    partial class FrmMain
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
            BtnMsg = new Button();
            SuspendLayout();
            // 
            // BtnMsg
            // 
            BtnMsg.BackColor = SystemColors.GradientInactiveCaption;
            BtnMsg.ForeColor = Color.Red;
            BtnMsg.Location = new Point(410, 245);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Size = new Size(100, 40);
            BtnMsg.TabIndex = 0;
            BtnMsg.Text = "메시지";
            BtnMsg.UseVisualStyleBackColor = false;
            BtnMsg.Click += BtnMsg_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 297);
            Controls.Add(BtnMsg);
            Name = "FrmMain";
            Text = "문법학습 윈앱 02";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnMsg;
    }
}
