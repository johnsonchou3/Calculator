using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// 每次response的物件, 並把資料傳到winformcaldata 作展示
    /// </summary>
    public class CalData
    {
        /// <summary>
        /// 目前的運算式, 每按operation/bracket/execute 都會使其更新, 在execute/ClearAll後會清空
        /// </summary>
        public string StringOfOperation { get; set; }

        /// <summary>
        /// 讓form1 讀取顯示, 透過storedisplay存取stringofoperation, 唯execute後不清空以便用家看到式子
        /// </summary>
        public string DisplayOperation { get; set; }

        /// <summary>
        /// 讓form1 讀取顯示, 在execute後會顯示expressiontree 的前序
        /// </summary>
        public string Preordstring { get; set; }

        /// <summary>
        /// 讓form1 讀取顯示, 在execute後會顯示expressiontree 的中序
        /// </summary>
        public string Inordstring { get; set; }

        /// <summary>
        /// 讓form1 讀取顯示, 在execute後會顯示expressiontree 的後序
        /// </summary>
        public string Postordstring { get; set; }

        /// <summary>
        /// 目前輸入的String, 會顯示在form1textbox 讓用家知道目前輸入
        /// </summary>
        public string TempInputString { get; set; } = "0";

        /// <summary>
        /// 內建的儲存displayoperation method 方便使用
        /// </summary>
        public void StoretoDisplay()
        {
            DisplayOperation = StringOfOperation;
        }
    }
}
