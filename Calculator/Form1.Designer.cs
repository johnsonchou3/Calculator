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
            this.btnPN = new System.Windows.Forms.Button();
            this.btnexe = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btndec = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnce = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.CurOp = new System.Windows.Forms.Label();
            this.btnroot = new System.Windows.Forms.Button();
            this.btnbrack1 = new System.Windows.Forms.Button();
            this.btnbrack2 = new System.Windows.Forms.Button();
            this.PreOrd = new System.Windows.Forms.Label();
            this.InOrd = new System.Windows.Forms.Label();
            this.PostOrd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPN
            // 
            this.btnPN.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPN.Location = new System.Drawing.Point(52, 564);
            this.btnPN.Name = "btnPN";
            this.btnPN.Size = new System.Drawing.Size(107, 71);
            this.btnPN.TabIndex = 1;
            this.btnPN.Text = "+/-";
            this.btnPN.UseVisualStyleBackColor = true;
            this.btnPN.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnexe
            // 
            this.btnexe.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnexe.Location = new System.Drawing.Point(389, 564);
            this.btnexe.Name = "btnexe";
            this.btnexe.Size = new System.Drawing.Size(107, 71);
            this.btnexe.TabIndex = 2;
            this.btnexe.Text = "=";
            this.btnexe.UseVisualStyleBackColor = true;
            this.btnexe.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnadd.Location = new System.Drawing.Point(389, 487);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(107, 71);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnsub
            // 
            this.btnsub.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsub.Location = new System.Drawing.Point(389, 410);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(107, 71);
            this.btnsub.TabIndex = 4;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnmul
            // 
            this.btnmul.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnmul.Location = new System.Drawing.Point(389, 333);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(107, 71);
            this.btnmul.TabIndex = 5;
            this.btnmul.Text = "*";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.Button_Click);
            // 
            // btndiv
            // 
            this.btndiv.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndiv.Location = new System.Drawing.Point(389, 256);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(107, 71);
            this.btndiv.TabIndex = 6;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnback.Location = new System.Drawing.Point(389, 179);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(107, 71);
            this.btnback.TabIndex = 7;
            this.btnback.Text = "back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(165, 564);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(107, 71);
            this.btn0.TabIndex = 8;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Button_Click);
            // 
            // btndec
            // 
            this.btndec.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndec.Location = new System.Drawing.Point(276, 564);
            this.btndec.Name = "btndec";
            this.btndec.Size = new System.Drawing.Size(107, 71);
            this.btndec.TabIndex = 9;
            this.btndec.Text = ".";
            this.btndec.UseVisualStyleBackColor = true;
            this.btndec.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(165, 487);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(107, 71);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(276, 487);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(107, 71);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(52, 487);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(107, 71);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(165, 410);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(107, 71);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(52, 410);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(107, 71);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(276, 410);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(107, 71);
            this.btn6.TabIndex = 15;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(165, 333);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(107, 71);
            this.btn8.TabIndex = 16;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(52, 333);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(107, 71);
            this.btn7.TabIndex = 17;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(276, 333);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(107, 71);
            this.btn9.TabIndex = 18;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnc
            // 
            this.btnc.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnc.Location = new System.Drawing.Point(276, 256);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(107, 71);
            this.btnc.TabIndex = 19;
            this.btnc.Tag = "0";
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnce
            // 
            this.btnce.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnce.Location = new System.Drawing.Point(165, 256);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(107, 71);
            this.btnce.TabIndex = 20;
            this.btnce.Text = "CE";
            this.btnce.UseVisualStyleBackColor = true;
            this.btnce.Click += new System.EventHandler(this.Button_Click);
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
            this.CurOp.AutoSize = true;
            this.CurOp.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurOp.Location = new System.Drawing.Point(34, 27);
            this.CurOp.Name = "CurOp";
            this.CurOp.Size = new System.Drawing.Size(0, 41);
            this.CurOp.TabIndex = 22;
            // 
            // btnroot
            // 
            this.btnroot.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnroot.Location = new System.Drawing.Point(52, 256);
            this.btnroot.Name = "btnroot";
            this.btnroot.Size = new System.Drawing.Size(107, 71);
            this.btnroot.TabIndex = 24;
            this.btnroot.Text = "√";
            this.btnroot.UseVisualStyleBackColor = true;
            this.btnroot.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnbrack1
            // 
            this.btnbrack1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbrack1.Location = new System.Drawing.Point(52, 179);
            this.btnbrack1.Name = "btnbrack1";
            this.btnbrack1.Size = new System.Drawing.Size(107, 71);
            this.btnbrack1.TabIndex = 25;
            this.btnbrack1.Tag = "0";
            this.btnbrack1.Text = "(";
            this.btnbrack1.UseVisualStyleBackColor = true;
            this.btnbrack1.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnbrack2
            // 
            this.btnbrack2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbrack2.Location = new System.Drawing.Point(165, 179);
            this.btnbrack2.Name = "btnbrack2";
            this.btnbrack2.Size = new System.Drawing.Size(107, 71);
            this.btnbrack2.TabIndex = 26;
            this.btnbrack2.Tag = "0";
            this.btnbrack2.Text = ")";
            this.btnbrack2.UseVisualStyleBackColor = true;
            this.btnbrack2.Click += new System.EventHandler(this.Button_Click);
            // 
            // PreOrd
            // 
            this.PreOrd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PreOrd.Location = new System.Drawing.Point(517, 46);
            this.PreOrd.Name = "PreOrd";
            this.PreOrd.Size = new System.Drawing.Size(317, 167);
            this.PreOrd.TabIndex = 27;
            // 
            // InOrd
            // 
            this.InOrd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InOrd.Location = new System.Drawing.Point(517, 246);
            this.InOrd.Name = "InOrd";
            this.InOrd.Size = new System.Drawing.Size(317, 167);
            this.InOrd.TabIndex = 28;
            // 
            // PostOrd
            // 
            this.PostOrd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PostOrd.Location = new System.Drawing.Point(517, 468);
            this.PostOrd.Name = "PostOrd";
            this.PostOrd.Size = new System.Drawing.Size(317, 167);
            this.PostOrd.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 667);
            this.Controls.Add(this.PostOrd);
            this.Controls.Add(this.InOrd);
            this.Controls.Add(this.PreOrd);
            this.Controls.Add(this.btnbrack2);
            this.Controls.Add(this.btnbrack1);
            this.Controls.Add(this.btnroot);
            this.Controls.Add(this.CurOp);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.btnce);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btndec);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnexe);
            this.Controls.Add(this.btnPN);
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
        private System.Windows.Forms.Button btnPN;

        /// <summary>
        /// =鍵
        /// </summary>
        private System.Windows.Forms.Button btnexe;

        /// <summary>
        /// +鍵
        /// </summary>
        private System.Windows.Forms.Button btnadd;

        /// <summary>
        /// -鍵
        /// </summary>
        private System.Windows.Forms.Button btnsub;

        /// <summary>
        /// *鍵
        /// </summary>
        private System.Windows.Forms.Button btnmul;

        /// <summary>
        /// /鍵
        /// </summary>
        private System.Windows.Forms.Button btndiv;

        /// <summary>
        /// back鍵
        /// </summary>
        private System.Windows.Forms.Button btnback;

        /// <summary>
        /// 數字0鍵
        /// </summary>
        private System.Windows.Forms.Button btn0;

        /// <summary>
        /// 數字.鍵
        /// </summary>
        private System.Windows.Forms.Button btndec;

        /// <summary>
        /// 數字2鍵
        /// </summary>
        private System.Windows.Forms.Button btn2;

        /// <summary>
        /// 數字3鍵
        /// </summary>
        private System.Windows.Forms.Button btn3;

        /// <summary>
        /// 數字1鍵
        /// </summary>
        private System.Windows.Forms.Button btn1;

        /// <summary>
        /// 數字5鍵
        /// </summary>
        private System.Windows.Forms.Button btn5;

        /// <summary>
        /// 數字4鍵
        /// </summary>
        private System.Windows.Forms.Button btn4;

        /// <summary>
        /// 數字6鍵
        /// </summary>
        private System.Windows.Forms.Button btn6;

        /// <summary>
        /// 數字8鍵
        /// </summary>
        private System.Windows.Forms.Button btn8;

        /// <summary>
        /// 數字7鍵
        /// </summary>
        private System.Windows.Forms.Button btn7;

        /// <summary>
        /// 數字9鍵
        /// </summary>
        private System.Windows.Forms.Button btn9;

        /// <summary>
        /// Clear鍵
        /// </summary>
        private System.Windows.Forms.Button btnc;

        /// <summary>
        /// Clear Entry鍵
        /// </summary>
        private System.Windows.Forms.Button btnce;

        /// <summary>
        /// TextBox
        /// </summary>
        private System.Windows.Forms.TextBox ResultBox;

        /// <summary>
        /// Label
        /// </summary>
        private System.Windows.Forms.Label CurOp;

        /// <summary>
        /// 開根號鍵
        /// </summary>
        private System.Windows.Forms.Button btnroot;

        /// <summary>
        /// 開括號鍵
        /// </summary>
        private System.Windows.Forms.Button btnbrack1;

        /// <summary>
        /// 關括號鍵
        /// </summary>
        private System.Windows.Forms.Button btnbrack2;

        /// <summary>
        /// 前序顯示label
        /// </summary>
        private System.Windows.Forms.Label PreOrd;

        /// <summary>
        /// 中序顯示label
        /// </summary>
        private System.Windows.Forms.Label InOrd;

        /// <summary>
        /// 後序顯示label
        /// </summary>
        private System.Windows.Forms.Label PostOrd;
    }
}