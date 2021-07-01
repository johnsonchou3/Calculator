using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// +/- 鍵的類別, 功能為多加+/-在txtboxstr 前面
    /// </summary>
    public class PosNeg : Btns
    {
        /// <summary>
        /// 需要form1 的txtbox 及label作存取
        /// </summary>
        private readonly Form1 form1;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="form1">需form1作txtbox label 存取</param>
        public PosNeg(Form1 form1)
        {
            this.form1 = form1;
        }

        /// <summary>
        /// 按鍵動作
        /// SwitchPos: 多加+/-在txtboxstr 前面
        /// </summary>
        public override void BtnFunction()
        {
            SwitchPosNeg();
        }

        /// <summary>
        /// 多加+/-在txtboxstr 前面
        /// </summary>
        private void SwitchPosNeg()
        {
            string txtboxstr = form1.TextBoxStr;
            decimal reversed = decimal.Parse(txtboxstr) * (-1);
            form1.TextBoxStr = reversed.ToString();
        }
    }
}
