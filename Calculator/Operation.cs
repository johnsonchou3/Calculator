using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// 加減乘除的類別, 功能為 打包txtbox並加上operator 供execute 辨別, 並把txtbox 清空
    /// </summary>
    public class Operation : Btns
    {
        /// <summary>
        /// 需要form1 的txtbox 及label作存取
        /// </summary>
        private readonly Form1 form1;

        /// <summary>
        /// 需按鍵本身的operator
        /// </summary>
        private string btnop;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="form1">需要form1 的txtbox 及label作存取</param>
        /// <param name="btnop">需按鍵本身的operator</param>
        public Operation(Form1 form1, string btnop)
        {
            this.form1 = form1;
            this.btnop = btnop;
        }

        /// <summary>
        /// 按鍵動作
        /// AssignVal1: 把txtbox及operator打包至label1
        /// ClearTxtBox: 清空txtbox
        /// </summary>
        public override void BtnFunction()
        {
            this.AssignVal1();
            this.ClearTxtBox();
        }

        /// <summary>
        /// 把txtbox及operator打包至label1
        /// </summary>
        private void AssignVal1()
        {
            try
            {
                decimal txtboxdec = decimal.Parse(form1.TextBoxStr);
                form1.LabelStr = txtboxdec.ToString() + this.btnop;
            }
            catch (FormatException)
            {
                CorrectOperator();
            }
        }

        /// <summary>
        /// 清空txtbox
        /// </summary>
        private void ClearTxtBox()
        {
            form1.TextBoxStr = "0";
        }

        private void CorrectOperator()
        {
            string labelstr = form1.LabelStr;
            form1.LabelStr = labelstr.Remove(labelstr.Length - 1) + btnop;
        }
    }
}