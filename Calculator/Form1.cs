using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    /// <summary>
    /// Winform 程式 Form1 Class 
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 程式初始化
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.btnexe.Tag = new Execute();
            this.btnadd.Tag = new Operation(this.btnadd.Text);
            this.btnsub.Tag = new Operation(this.btnsub.Text);
            this.btnmul.Tag = new Operation(this.btnmul.Text);
            this.btndiv.Tag = new Operation(this.btndiv.Text);
            this.btn0.Tag = new NumPad(this.btn0.Text);
            this.btn1.Tag = new NumPad(this.btn1.Text);
            this.btn2.Tag = new NumPad(this.btn2.Text);
            this.btn3.Tag = new NumPad(this.btn3.Text);
            this.btn4.Tag = new NumPad(this.btn4.Text);
            this.btn5.Tag = new NumPad(this.btn5.Text);
            this.btn6.Tag = new NumPad(this.btn6.Text);
            this.btn7.Tag = new NumPad(this.btn7.Text);
            this.btn8.Tag = new NumPad(this.btn8.Text);
            this.btn9.Tag = new NumPad(this.btn9.Text);
            this.btndec.Tag = new Dec();
            this.btnce.Tag = new ClearEntry();
            this.btnc.Tag = new ClearAll();
            this.btnback.Tag = new Backspace();
            this.btnPN.Tag = new PosNeg();
            this.btnroot.Tag = new Root();
            this.btnbrack1.Tag = new BracketOp(this.btnbrack1.Text);
            this.btnbrack2.Tag = new BracketClose(this.btnbrack2.Text);
        }

        /// <summary>
        /// 按鍵的event handler, 會呼叫tag並使用其btnfunction
        /// </summary>
        /// <param name="sender">觸發者</param>
        /// <param name="e">事件數據</param>
        private void Button_Click(object sender, EventArgs e)
        {                 
            Button b = (Button)sender;
            if (b.Name != "label1")
            {             
                Btns abc = (Btns)b.Tag;
                abc.BtnFunction();
                ResultBox.Text = Btns.WinformCaldata.TempInputString;
                CurOp.Text = Btns.WinformCaldata.DisplayOperation;
                PreOrd.Text = Btns.WinformCaldata.DisplayOperation;
                PreOrd.Text = Btns.WinformCaldata.Preordstring;
                InOrd.Text = Btns.WinformCaldata.Inordstring;
                PostOrd.Text = Btns.WinformCaldata.Postordstring;
            }
        }                                    
    }
}
