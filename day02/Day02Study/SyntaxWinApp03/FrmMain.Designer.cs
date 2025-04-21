namespace SyntaxWinApp03
{
    partial class CboPainPoint
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
            LblPain = new Label();
            TxtPain = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            TxtResult = new TextBox();
            BtnDisplay = new Button();
            BtnWhile = new Button();
            SuspendLayout();
            // 
            // BtnMsg
            // 
            BtnMsg.Location = new Point(444, 249);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Size = new Size(100, 40);
            BtnMsg.TabIndex = 6;
            BtnMsg.Text = "메시지";
            BtnMsg.TextImageRelation = TextImageRelation.TextAboveImage;
            BtnMsg.UseVisualStyleBackColor = true;
            BtnMsg.Click += button1_Click;
            // 
            // LblPain
            // 
            LblPain.AutoSize = true;
            LblPain.Location = new Point(12, 9);
            LblPain.Name = "LblPain";
            LblPain.Size = new Size(64, 15);
            LblPain.TabIndex = 1;
            LblPain.Text = "통증여부 -";
            // 
            // TxtPain
            // 
            TxtPain.Location = new Point(73, 6);
            TxtPain.Name = "TxtPain";
            TxtPain.PlaceholderText = "네 또는 아니요";
            TxtPain.Size = new Size(100, 23);
            TxtPain.TabIndex = 1;
            TxtPain.KeyPress += TxtPain_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "통증부위 -";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "머리", "눈", "코", "목", "가슴", "배", "다리" });
            comboBox1.Location = new Point(73, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "부위선택";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(12, 74);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(547, 169);
            TxtResult.TabIndex = 3;
            // 
            // BtnDisplay
            // 
            BtnDisplay.Location = new Point(338, 249);
            BtnDisplay.Name = "BtnDisplay";
            BtnDisplay.Size = new Size(100, 40);
            BtnDisplay.TabIndex = 5;
            BtnDisplay.Text = "구구단";
            BtnDisplay.TextImageRelation = TextImageRelation.TextAboveImage;
            BtnDisplay.UseVisualStyleBackColor = true;
            BtnDisplay.Click += BtnDisplay_Click;
            // 
            // BtnWhile
            // 
            BtnWhile.Location = new Point(232, 249);
            BtnWhile.Name = "BtnWhile";
            BtnWhile.Size = new Size(100, 40);
            BtnWhile.TabIndex = 4;
            BtnWhile.Text = "반복";
            BtnWhile.TextImageRelation = TextImageRelation.TextAboveImage;
            BtnWhile.UseVisualStyleBackColor = true;
            BtnWhile.Click += BtnWhile_Click;
            // 
            // CboPainPoint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 320);
            Controls.Add(BtnWhile);
            Controls.Add(BtnDisplay);
            Controls.Add(TxtResult);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(TxtPain);
            Controls.Add(LblPain);
            Controls.Add(BtnMsg);
            Name = "CboPainPoint";
            Text = "문법학습 윈앱03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnMsg;
        private Label LblPain;
        private TextBox TxtPain;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox TxtResult;
        private Button BtnDisplay;
        private Button BtnWhile;
    }
}
