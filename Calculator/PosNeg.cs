using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// +/- 鍵的類別, 功能為多加+/-TempInputString 前面
    /// </summary>
    public class PosNeg : Btns
    {
        /// <summary>
        /// 需要form1 的TempInputString, StringOfOperation, txtbox 及label作存取
        /// </summary>
        private readonly Form1 form1;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="form1">需要form1 的TempInputString, StringOfOperation, txtbox 及label作存取</param>
        public PosNeg(Form1 form1)
        {
            this.form1 = form1;
        }

        /// <summary>
        /// 按鍵動作
        /// SwitchPos: 多加+/-在TempInputString前面
        /// 顯示更新的TempInputString在textbox上
        /// </summary>
        public override void BtnFunction()
        {
            SwitchPosNeg();
            form1.TextBoxStr = form1.TempInputString;
        }

        /// <summary>
        /// 多加+/-在TempInputString前面
        /// </summary>
        private void SwitchPosNeg()
        {
            string txtboxstr = form1.TempInputString;
            decimal reversed = decimal.Parse(txtboxstr) * (-1);
            form1.TempInputString = reversed.ToString();
        }
    }
}
