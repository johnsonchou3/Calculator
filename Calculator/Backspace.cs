using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// 倒退鍵的Class, 功能為將TempInputString 最後char 刪除
    /// </summary>
    public class Backspace : Btns
    {
        /// <summary>
        /// 需要form1 的TempInputString, StringOfOperation, txtbox 及label作存取
        /// </summary>
        private readonly Form1 form1;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="form1">需要form1 的TempInputString, StringOfOperation, txtbox 及label作存取</param>
        public Backspace(Form1 form1)
        {
            this.form1 = form1;
        }

        /// <summary>
        /// 按鍵動作
        /// RemoveLastDigit: 移除txtbox最後的digit
        /// ArgumentOutOfRangeException: 當tempinputstring 為null時, 把其設為0
        /// </summary>
        public override void BtnFunction()
        {
            try
            {
                RemoveLastDigit();
                form1.TextBoxStr = form1.TempInputString;
            }
            catch (ArgumentOutOfRangeException)
            {
                form1.TempInputString = "0";
                form1.TextBoxStr = form1.TempInputString;
            }
        }

        /// <summary>
        /// RemoveLastDigit: 移除tempinputstring最後的位數
        /// </summary>
        private void RemoveLastDigit()
        {
            string curtextbox = form1.TempInputString;
            form1.TempInputString = (curtextbox).Remove(curtextbox.Length - 1);
        }
    }
}
