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
        /// 按鍵動作
        /// RemoveLastDigit: 移除txtbox最後的digit
        /// ArgumentOutOfRangeException: 當tempinputstring 為null時, 把其設為0
        /// </summary>
        public override void BtnFunction()
        {
            try
            {
                RemoveLastDigit();
            }
            catch (ArgumentOutOfRangeException)
            {
                TempInputString = "0";
            }
        }

        /// <summary>
        /// RemoveLastDigit: 移除tempinputstring最後的位數
        /// </summary>
        private void RemoveLastDigit()
        {
            string curtextbox = TempInputString;
            TempInputString = (curtextbox).Remove(Math.Max(1, curtextbox.Length - 1));
        }
    }
}
