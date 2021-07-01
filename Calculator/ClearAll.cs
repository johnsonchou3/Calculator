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
        /// 需要form1 的txtbox 及label作存取
        /// </summary>
        private readonly Form1 form1;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="form1">需form1作txtbox label 存取</param>
        public ClearAll(Form1 form1) : base(form1)
        {
            this.form1 = form1;
        }

        /// <summary>
        /// 按鍵功能
        /// base: 繼承至CE的清空txtbox
        /// ClearDatas: 把label 清空
        /// </summary>
        public override void BtnFunction()
        {
            base.BtnFunction();
            ClearDatas();
        }

        /// <summary>
        /// 把label 清空
        /// </summary>
        private void ClearDatas()
        {
            form1.LabelStr = string.Empty;
        }
    }
}
