﻿using System;
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
        /// 按鍵功能
        /// 把TenpInputString 歸零
        /// </summary>
        public override void BtnFunction()
        {
            TempInputString = "0";
        }
    }
}
