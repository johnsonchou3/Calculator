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
            this.btnexe.Tag = new Execute(this);
            this.btnadd.Tag = new Operation(this, this.btnadd.Text);
            this.btnsub.Tag = new Operation(this, this.btnsub.Text);
            this.btnmul.Tag = new Operation(this, this.btnmul.Text);
            this.btndiv.Tag = new Operation(this, this.btndiv.Text);
            this.btn0.Tag = new NumPad(this, this.btn0.Text);
            this.btn1.Tag = new NumPad(this, this.btn1.Text);
            this.btn2.Tag = new NumPad(this, this.btn2.Text);
            this.btn3.Tag = new NumPad(this, this.btn3.Text);
            this.btn4.Tag = new NumPad(this, this.btn4.Text);
            this.btn5.Tag = new NumPad(this, this.btn5.Text);
            this.btn6.Tag = new NumPad(this, this.btn6.Text);
            this.btn7.Tag = new NumPad(this, this.btn7.Text);
            this.btn8.Tag = new NumPad(this, this.btn8.Text);
            this.btn9.Tag = new NumPad(this, this.btn9.Text);
            this.btndec.Tag = new NumPad(this, this.btndec.Text);
            this.btnce.Tag = new ClearEntry(this);
            this.btnc.Tag = new ClearAll(this);
            this.btnback.Tag = new Backspace(this);
            this.btnPN.Tag = new PosNeg(this);
            this.btnroot.Tag = new Root(this);
        }

        /// <summary>
        /// 全部運算式, 透過operation 及execute, C, CE 作存取
        /// </summary>
        public string StringOfOperation{ get; set; }

        /// <summary>
        /// 存進目前輸入的數值, 以numpad,execute 作寫入, 並會在operation 後清空
        /// </summary>
        public string TempInputString {get; set; } = "0";

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
            }             
        }                 
                        
        /// <summary>
        /// 回傳/修改txtbox 值, 供class 使用
        /// </summary>
        public string TextBoxStr
        {                 
            get { return ResultBox.Text; }
            set { ResultBox.Text = value; }
        }

        /// <summary>
        /// 回傳/label 值, 供class 使用
        /// </summary>
        public string LabelStr
        {
            get { return CurOp.Text; }
            set { CurOp.Text = value; }
        }
    }
}
