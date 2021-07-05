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
        /// 需要form1 的TempInputString, StringOfOperation, txtbox 及label作存取
        /// </summary>
        private readonly Form1 form1;

        /// <summary>
        /// 按鍵本身的值
        /// </summary>
        private string btnnum;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="form1">需要form1 的TempInputString, StringOfOperation, txtbox 及label作存取</param>
        /// <param name="btnnum">按鍵本身的值</param>
        public NumPad(Form1 form1, string btnnum)
        {
            this.form1 = form1;
            this.btnnum = btnnum;
        }

        /// <summary>
        /// 按鍵動作
        /// AddNum: 把按鍵值加到TempInputString最後
        /// 最後把TempInputString 顯示於textbox上
        /// </summary>
        public override void BtnFunction()
        {
            this.AddNum();
            form1.TextBoxStr = form1.TempInputString;
        }

        /// <summary>
        /// 把按鍵值加到TempInputString最後
        /// </summary>
        public void AddNum()
        {
            try
            {
                decimal txtboxdec = decimal.Parse(form1.TempInputString);
                decimal inputdec = decimal.Parse(btnnum);
                string newtxtboxstr = ((txtboxdec * 10) + inputdec).ToString();
                form1.TempInputString = newtxtboxstr;
            }
            catch (FormatException)
            {
                form1.TempInputString = btnnum;
            }
        }
    }
}
