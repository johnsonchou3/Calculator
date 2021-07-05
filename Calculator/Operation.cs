using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// 加減乘除的類別, 功能為 打包TempInputString並加上operator, 並清空
    /// </summary>
    public class Operation : Btns
    {
        /// <summary>
        /// 需要form1 的TempInputString, StringOfOperation, txtbox 及label作存取
        /// </summary>
        private readonly Form1 form1;

        /// <summary>
        /// 需按鍵本身的operator
        /// </summary>
        private string btnop;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="form1">需要form1 的TempInputString, StringOfOperation, txtbox 及label作存取</param>
        /// <param name="btnop">需按鍵本身的operator</param>
        public Operation(Form1 form1, string btnop)
        {
            this.form1 = form1;
            this.btnop = btnop;
        }

        /// <summary>
        /// 按鍵動作
        /// SaveValue: 把TempInputString及目前的operator寫入StringOfOperation中
        /// ClearTemp: 寫入後把TempInputString清空作下一次儲存
        /// </summary>
        public override void BtnFunction()
        {
            SaveValue();
            ClearTemp();
        }

        /// <summary>
        /// 把TempInputString及目前的operator寫入StringOfOperation中
        /// </summary>
        private void SaveValue()
        {
            form1.StringOfOperation += form1.TempInputString + btnop;
            form1.LabelStr = form1.StringOfOperation;
        }

        /// <summary>
        /// 寫入後把TempInputString清空作下一次儲存
        /// </summary>
        private void ClearTemp()
        {
            form1.TextBoxStr = "0";
            form1.TempInputString = "0";
        }
    }
}