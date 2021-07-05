using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// CE 的按鍵類別, 會被C 繼承, 功能為清空TempInputString
    /// </summary>
    public class ClearEntry : Btns
    {
        /// <summary>
        /// 需要form1 的TempInputString, StringOfOperation, txtbox 及label作存取
        /// </summary>
        private readonly Form1 form1;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="form1">需要form1 的TempInputString, StringOfOperation, txtbox 及label作存取</param>
        public ClearEntry(Form1 form1)
        {
            this.form1 = form1;
        }

        /// <summary>
        /// 按鍵功能
        /// 把TenpInputString 歸零
        /// EmptyTxtBox:清空txtbox
        /// </summary>
        public override void BtnFunction()
        {
            form1.TempInputString = "0";
            EmptyTxtBox();
        }

        /// <summary>
        /// 清空txtbox
        /// </summary>
        private void EmptyTxtBox()
        {
            form1.TextBoxStr = "0";
        }
    }
}
