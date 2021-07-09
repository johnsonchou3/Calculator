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
        /// 按鍵動作
        /// SwitchPos: 多加+/-在TempInputString前面
        /// 顯示更新的TempInputString在textbox上
        /// </summary>
        public override void BtnFunction()
        {
            SwitchPosNeg();
        }

        /// <summary>
        /// 多加+/-在TempInputString前面
        /// </summary>
        private void SwitchPosNeg()
        {
            string txtboxstr = TempInputString;
            decimal reversed = decimal.Parse(txtboxstr) * (-1);
            TempInputString = reversed.ToString();
        }
    }
}
