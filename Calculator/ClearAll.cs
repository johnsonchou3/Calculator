using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// C按鍵的類別, 繼承CE的清空method, 並再把之前的所有輸入移除
    /// </summary>
    public class ClearAll : ClearEntry
    {
        /// <summary>
        /// 按鍵功能
        /// base: 繼承至CE的清空txtbox
        /// ClearDatas: 把stringofoperation 及label清空
        /// StoretoDisplay: 把新的stringofoperation 更新至畫面
        /// </summary>
        public override void BtnFunction()
        {
            base.BtnFunction();
            ClearDatas();
            StoretoDisplay();
        }

        /// <summary>
        /// 把stringofoperation 及label清空
        /// </summary>
        private void ClearDatas()
        {
            StringOfOperation = string.Empty;
            Expressionlist.Clear();
        }
    }
}
