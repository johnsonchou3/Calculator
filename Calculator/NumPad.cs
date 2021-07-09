using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// "0~9."的按鍵類別, 功能把按鍵值加到TempInputString最後
    /// </summary>
    public class NumPad : Btns
    {
        /// <summary>
        /// 按鍵本身的值
        /// </summary>
        private string btnnum;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="btnnum">按鍵本身的值</param>
        public NumPad(string btnnum)
        {
            this.btnnum = btnnum;
        }

        /// <summary>
        /// 按鍵動作
        /// AddNum: 把按鍵值加到TempInputString最後
        /// </summary>
        public override void BtnFunction()
        {
            IsOperating = false;
            this.AddNum();
            StoretoDisplay();
        }

        /// <summary>
        /// 把按鍵值加到TempInputString最後
        /// </summary>
        public void AddNum()
        {
            try
            {
                TempInputString += btnnum;
                TempInputString = double.Parse(TempInputString).ToString();
            }
            catch (FormatException)
            {
                TempInputString = btnnum;
            }
        }
    }
}
