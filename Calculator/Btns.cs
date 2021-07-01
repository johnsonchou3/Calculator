using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// 所有Btns 的基底類別, 必須擁有BtnFunction - 按鍵的功能
    /// </summary>
    public abstract class Btns
    {
        /// <summary>
        /// 每個按鍵的各自功能
        /// </summary>
        public abstract void BtnFunction();
    }
}
