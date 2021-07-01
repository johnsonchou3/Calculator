using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// 倒退鍵的Class, 功能為txtbox 最後char 刪除
    /// </summary>
    public class Backspace : Btns
    {
        /// <summary>
        /// 需要form1 的txtbox 及label作存取
        /// </summary>
        private readonly Form1 form1;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="form1">需form1作txtbox label 存取</param>
        public Backspace(Form1 form1)
        {
            this.form1 = form1;
        }

        /// <summary>
        /// 按鍵動作
        /// RemoveLastDigit: 移除txtbox最後的digit
        /// </summary>
        public override void BtnFunction()
        {
            RemoveLastDigit();
        }

        /// <summary>
        /// RemoveLastDigit: 移除txtbox最後的digit
        /// </summary>
        private void RemoveLastDigit()
        {
            string curtextbox = form1.TextBoxStr;
            form1.TextBoxStr = (curtextbox).Remove(curtextbox.Length - 1);
        }
    }
}
