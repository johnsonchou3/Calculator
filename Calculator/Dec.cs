using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// "."鍵的class, 繼承Btns
    /// </summary>
    public class Dec : Btns
    {
        /// <summary>
        /// 按鈕功能
        /// 會在Tempinputstring 加上.數, 不作decimal轉換
        /// </summary>
        public override void BtnFunction()
        {
            TempInputString += ".";
        }
    }
}
