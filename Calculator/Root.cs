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
        /// 按鍵動作
        /// OperateRoot: 把TempInputString 作開根號並取代原本值
        /// 顯示更新的TempInputString在textbox上
        /// </summary>
        public override void BtnFunction()
        {
            OperateRoot();
        }

        /// <summary>
        /// 把TempInputString 作開根號並取代原本值
        /// </summary>
        private void OperateRoot()
        {
            double tempnum = double.Parse(TempInputString);
            TempInputString = Math.Sqrt(tempnum).ToString();
        }
    }
}