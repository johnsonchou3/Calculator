using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// 開根號鍵的類別, 功能為把TempInputString作開根號
    /// </summary>
    public class Root : Btns
    {
        /// <summary>
        /// 需要form1 的TempInputString, StringOfOperation, txtbox 及label作存取
        /// </summary>
        private readonly Form1 form1;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="form1">需要form1 的TempInputString, StringOfOperation, txtbox 及label作存取</param>
        public Root(Form1 form1)
        {
            this.form1 = form1;
        }

        /// <summary>
        /// 按鍵動作
        /// OperateRoot: 把TempInputString 作開根號並取代原本值
        /// 顯示更新的TempInputString在textbox上
        /// </summary>
        public override void BtnFunction()
        {
            OperateRoot();
            form1.TextBoxStr = form1.TempInputString;
        }

        /// <summary>
        /// 把TempInputString 作開根號並取代原本值
        /// </summary>
        private void OperateRoot()
        {
            double tempnum = double.Parse(form1.TempInputString);
            form1.TempInputString = Math.Sqrt(tempnum).ToString();
        }
    }
}