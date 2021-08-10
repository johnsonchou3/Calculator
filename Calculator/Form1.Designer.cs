namespace Calculator
{
    /// <summary>
    /// Designer: Form的版面
    /// </summary>
    public partial class Form1
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
            this.buttonPositiveNegative = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.CurrentOperation = new System.Windows.Forms.Label();
            this.buttonRoot = new System.Windows.Forms.Button();
            this.buttonBracketOpen = new System.Windows.Forms.Button();
            this.buttonBracketClose = new System.Windows.Forms.Button();
            this.PreOrderLabel = new System.Windows.Forms.Label();
            this.InOrderLabel = new System.Windows.Forms.Label();
            this.PostOrderLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.buttonInvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPN
            // 
            this.buttonPositiveNegative.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPositiveNegative.Location = new System.Drawing.Point(52, 564);
            this.buttonPositiveNegative.Name = "btnPN";
            this.buttonPositiveNegative.Size = new System.Drawing.Size(107, 71);
            this.buttonPositiveNegative.TabIndex = 1;
            this.buttonPositiveNegative.Text = "+/-";
            this.buttonPositiveNegative.UseVisualStyleBackColor = true;
            this.buttonPositiveNegative.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnexe
            // 
            this.buttonExecute.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExecute.Location = new System.Drawing.Point(389, 564);
            this.buttonExecute.Name = "btnexe";
            this.buttonExecute.Size = new System.Drawing.Size(107, 71);
            this.buttonExecute.TabIndex = 2;
            this.buttonExecute.Text = "=";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnadd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(389, 487);
            this.buttonAdd.Name = "btnadd";
            this.buttonAdd.Size = new System.Drawing.Size(107, 71);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnsub
            // 
            this.buttonSubtract.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSubtract.Location = new System.Drawing.Point(389, 410);
            this.buttonSubtract.Name = "btnsub";
            this.buttonSubtract.Size = new System.Drawing.Size(107, 71);
            this.buttonSubtract.TabIndex = 4;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnmul
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMultiply.Location = new System.Drawing.Point(389, 333);
            this.buttonMultiply.Name = "btnmul";
            this.buttonMultiply.Size = new System.Drawing.Size(107, 71);
            this.buttonMultiply.TabIndex = 5;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.Button_Click);
            // 
            // btndiv
            // 
            this.buttonDivision.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDivision.Location = new System.Drawing.Point(389, 256);
            this.buttonDivision.Name = "btndiv";
            this.buttonDivision.Size = new System.Drawing.Size(107, 71);
            this.buttonDivision.TabIndex = 6;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnback
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.Location = new System.Drawing.Point(389, 179);
            this.buttonBack.Name = "btnback";
            this.buttonBack.Size = new System.Drawing.Size(107, 71);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button0.Location = new System.Drawing.Point(165, 564);
            this.button0.Name = "btn0";
            this.button0.Size = new System.Drawing.Size(107, 71);
            this.button0.TabIndex = 8;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.Button_Click);
            // 
            // btndec
            // 
            this.buttonDecimal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDecimal.Location = new System.Drawing.Point(276, 564);
            this.buttonDecimal.Name = "btndec";
            this.buttonDecimal.Size = new System.Drawing.Size(107, 71);
            this.buttonDecimal.TabIndex = 9;
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            this.buttonDecimal.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(165, 487);
            this.button2.Name = "btn2";
            this.button2.Size = new System.Drawing.Size(107, 71);
            this.button2.TabIndex = 10;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(276, 487);
            this.button3.Name = "btn3";
            this.button3.Size = new System.Drawing.Size(107, 71);
            this.button3.TabIndex = 11;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(52, 487);
            this.button1.Name = "btn1";
            this.button1.Size = new System.Drawing.Size(107, 71);
            this.button1.TabIndex = 12;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(165, 410);
            this.button5.Name = "btn5";
            this.button5.Size = new System.Drawing.Size(107, 71);
            this.button5.TabIndex = 13;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(52, 410);
            this.button4.Name = "btn4";
            this.button4.Size = new System.Drawing.Size(107, 71);
            this.button4.TabIndex = 14;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(276, 410);
            this.button6.Name = "btn6";
            this.button6.Size = new System.Drawing.Size(107, 71);
            this.button6.TabIndex = 15;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(165, 333);
            this.button8.Name = "btn8";
            this.button8.Size = new System.Drawing.Size(107, 71);
            this.button8.TabIndex = 16;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(52, 333);
            this.button7.Name = "btn7";
            this.button7.Size = new System.Drawing.Size(107, 71);
            this.button7.TabIndex = 17;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(276, 333);
            this.button9.Name = "btn9";
            this.button9.Size = new System.Drawing.Size(107, 71);
            this.button9.TabIndex = 18;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnc
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonC.Location = new System.Drawing.Point(276, 256);
            this.buttonC.Name = "btnc";
            this.buttonC.Size = new System.Drawing.Size(107, 71);
            this.buttonC.TabIndex = 19;
            this.buttonC.Tag = "0";
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnce
            // 
            this.buttonCE.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCE.Location = new System.Drawing.Point(165, 256);
            this.buttonCE.Name = "btnce";
            this.buttonCE.Size = new System.Drawing.Size(107, 71);
            this.buttonCE.TabIndex = 20;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.Button_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResultBox.Location = new System.Drawing.Point(36, 75);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResultBox.Size = new System.Drawing.Size(460, 48);
            this.ResultBox.TabIndex = 21;
            this.ResultBox.Text = "0";
            this.ResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CurOp
            // 
            this.CurrentOperation.AutoSize = true;
            this.CurrentOperation.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentOperation.Location = new System.Drawing.Point(34, 27);
            this.CurrentOperation.Name = "CurOp";
            this.CurrentOperation.Size = new System.Drawing.Size(0, 41);
            this.CurrentOperation.TabIndex = 22;
            // 
            // btnroot
            // 
            this.buttonRoot.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRoot.Location = new System.Drawing.Point(52, 256);
            this.buttonRoot.Name = "btnroot";
            this.buttonRoot.Size = new System.Drawing.Size(107, 71);
            this.buttonRoot.TabIndex = 24;
            this.buttonRoot.Text = "√";
            this.buttonRoot.UseVisualStyleBackColor = true;
            this.buttonRoot.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnbrack1
            // 
            this.buttonBracketOpen.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBracketOpen.Location = new System.Drawing.Point(52, 179);
            this.buttonBracketOpen.Name = "btnbrack1";
            this.buttonBracketOpen.Size = new System.Drawing.Size(107, 71);
            this.buttonBracketOpen.TabIndex = 25;
            this.buttonBracketOpen.Tag = "0";
            this.buttonBracketOpen.Text = "(";
            this.buttonBracketOpen.UseVisualStyleBackColor = true;
            this.buttonBracketOpen.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnbrack2
            // 
            this.buttonBracketClose.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBracketClose.Location = new System.Drawing.Point(165, 179);
            this.buttonBracketClose.Name = "btnbrack2";
            this.buttonBracketClose.Size = new System.Drawing.Size(107, 71);
            this.buttonBracketClose.TabIndex = 26;
            this.buttonBracketClose.Tag = "0";
            this.buttonBracketClose.Text = ")";
            this.buttonBracketClose.UseVisualStyleBackColor = true;
            this.buttonBracketClose.Click += new System.EventHandler(this.Button_Click);
            // 
            // PreOrd
            // 
            this.PreOrderLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PreOrderLabel.Location = new System.Drawing.Point(517, 46);
            this.PreOrderLabel.Name = "PreOrd";
            this.PreOrderLabel.Size = new System.Drawing.Size(317, 167);
            this.PreOrderLabel.TabIndex = 27;
            // 
            // InOrd
            // 
            this.InOrderLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InOrderLabel.Location = new System.Drawing.Point(517, 246);
            this.InOrderLabel.Name = "InOrd";
            this.InOrderLabel.Size = new System.Drawing.Size(317, 167);
            this.InOrderLabel.TabIndex = 28;
            // 
            // PostOrd
            // 
            this.PostOrderLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PostOrderLabel.Location = new System.Drawing.Point(517, 468);
            this.PostOrderLabel.Name = "PostOrd";
            this.PostOrderLabel.Size = new System.Drawing.Size(317, 167);
            this.PostOrderLabel.TabIndex = 29;
            // 
            // StatusLab
            // 
            this.StatusLabel.Location = new System.Drawing.Point(12, 635);
            this.StatusLabel.Name = "StatusLab";
            this.StatusLabel.Size = new System.Drawing.Size(509, 23);
            this.StatusLabel.TabIndex = 30;
            // 
            // btninv
            // 
            this.buttonInvert.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonInvert.Location = new System.Drawing.Point(278, 179);
            this.buttonInvert.Name = "btninv";
            this.buttonInvert.Size = new System.Drawing.Size(107, 71);
            this.buttonInvert.TabIndex = 31;
            this.buttonInvert.Text = "Inv";
            this.buttonInvert.UseVisualStyleBackColor = true;
            this.buttonInvert.Click += new System.EventHandler(this.Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 667);
            this.Controls.Add(this.buttonInvert);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.PostOrderLabel);
            this.Controls.Add(this.InOrderLabel);
            this.Controls.Add(this.PreOrderLabel);
            this.Controls.Add(this.buttonBracketClose);
            this.Controls.Add(this.buttonBracketOpen);
            this.Controls.Add(this.buttonRoot);
            this.Controls.Add(this.CurrentOperation);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.buttonPositiveNegative);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// +/-鍵
        /// </summary>
        private System.Windows.Forms.Button buttonPositiveNegative;

        /// <summary>
        /// =鍵
        /// </summary>
        private System.Windows.Forms.Button buttonExecute;

        /// <summary>
        /// +鍵
        /// </summary>
        private System.Windows.Forms.Button buttonAdd;

        /// <summary>
        /// -鍵
        /// </summary>
        private System.Windows.Forms.Button buttonSubtract;

        /// <summary>
        /// *鍵
        /// </summary>
        private System.Windows.Forms.Button buttonMultiply;

        /// <summary>
        /// /鍵
        /// </summary>
        private System.Windows.Forms.Button buttonDivision;

        /// <summary>
        /// back鍵
        /// </summary>
        private System.Windows.Forms.Button buttonBack;

        /// <summary>
        /// 數字0鍵
        /// </summary>
        private System.Windows.Forms.Button button0;

        /// <summary>
        /// 數字.鍵
        /// </summary>
        private System.Windows.Forms.Button buttonDecimal;

        /// <summary>
        /// 數字2鍵
        /// </summary>
        private System.Windows.Forms.Button button2;

        /// <summary>
        /// 數字3鍵
        /// </summary>
        private System.Windows.Forms.Button button3;

        /// <summary>
        /// 數字1鍵
        /// </summary>
        private System.Windows.Forms.Button button1;

        /// <summary>
        /// 數字5鍵
        /// </summary>
        private System.Windows.Forms.Button button5;

        /// <summary>
        /// 數字4鍵
        /// </summary>
        private System.Windows.Forms.Button button4;

        /// <summary>
        /// 數字6鍵
        /// </summary>
        private System.Windows.Forms.Button button6;

        /// <summary>
        /// 數字8鍵
        /// </summary>
        private System.Windows.Forms.Button button8;

        /// <summary>
        /// 數字7鍵
        /// </summary>
        private System.Windows.Forms.Button button7;

        /// <summary>
        /// 數字9鍵
        /// </summary>
        private System.Windows.Forms.Button button9;

        /// <summary>
        /// Clear鍵
        /// </summary>
        private System.Windows.Forms.Button buttonC;

        /// <summary>
        /// Clear Entry鍵
        /// </summary>
        private System.Windows.Forms.Button buttonCE;

        /// <summary>
        /// TextBox
        /// </summary>
        private System.Windows.Forms.TextBox ResultBox;

        /// <summary>
        /// Label
        /// </summary>
        private System.Windows.Forms.Label CurrentOperation;

        /// <summary>
        /// 開根號鍵
        /// </summary>
        private System.Windows.Forms.Button buttonRoot;

        /// <summary>
        /// 開括號鍵
        /// </summary>
        private System.Windows.Forms.Button buttonBracketOpen;

        /// <summary>
        /// 關括號鍵
        /// </summary>
        private System.Windows.Forms.Button buttonBracketClose;

        /// <summary>
        /// 前序顯示label
        /// </summary>
        private System.Windows.Forms.Label PreOrderLabel;

        /// <summary>
        /// 中序顯示label
        /// </summary>
        private System.Windows.Forms.Label InOrderLabel;

        /// <summary>
        /// 後序顯示label
        /// </summary>
        private System.Windows.Forms.Label PostOrderLabel;

        /// <summary>
        /// 顯示Status code 的label
        /// </summary>
        private System.Windows.Forms.Label StatusLabel;

        /// <summary>
        /// 倒數的按鈕
        /// </summary>
        private System.Windows.Forms.Button buttonInvert;
    }
}