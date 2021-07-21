﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Net;
using System.IO;
using System.Web;
using Newtonsoft.Json;

namespace Calculator
{
    /// <summary>
    /// 所有Btns 的基底類別, 必須擁有BtnFunction - 按鍵的功能
    /// </summary>
    public abstract class Btns
    {
        /// <summary>
        /// 儲存winform 的CookieID以作辨識
        /// </summary>
        public static string CookieID { get; set; } = null;

        /// <summary>
        /// 整個winform 共用的caldata, 每次按按鍵都會給form1 作展示
        /// </summary>
        public static CalData WinformCaldata { get; set; }

        /// <summary>
        /// 判斷目前是否在AfterBracket, 以免operation或execute 出現格式錯誤
        /// </summary>
        public static bool IsAfterBracket { get; set; } = false;

        /// <summary>
        /// 判斷目前是否在operation, 在operation當中再按operation 會修改operator
        /// </summary>
        public static bool IsOperating { get; set; } = false;

        /// <summary>
        /// 目前的運算式, 每按operation/bracket/execute 都會使其更新, 在execute/ClearAll後會清空
        /// </summary>
        public static string StringOfOperation { get; set; }

        /// <summary>
        /// 讓form1 讀取顯示, 透過storedisplay存取stringofoperation, 唯execute後不清空以便用家看到式子
        /// </summary>
        public static string DisplayOperation { get; set; }

        /// <summary>
        /// 讓form1 讀取顯示, 在execute後會顯示expressiontree 的前序
        /// </summary>
        public static string Preordstring { get; set; }

        /// <summary>
        /// 讓form1 讀取顯示, 在execute後會顯示expressiontree 的中序
        /// </summary>
        public static string Inordstring { get; set; }

        /// <summary>
        /// 讓form1 讀取顯示, 在execute後會顯示expressiontree 的後序
        /// </summary>
        public static string Postordstring { get; set; }

        /// <summary>
        /// 目前輸入的String, 會顯示在form1textbox 讓用家知道目前輸入
        /// </summary>
        public static string TempInputString { get; set; } = "0";

        /// <summary>
        /// 存入每個operand 及operator 的List, 以便在execute 創建tree
        /// </summary>
        public static List<string> Expressionlist { get; set; } = new List<string>();

        /// <summary>
        /// 每個按鍵的各自功能
        /// </summary>
        public abstract void BtnFunction();

        /// <summary>
        /// 把Stringofoperation 存到DisplayOperation 的method
        /// </summary>
        public void StoretoDisplay()
        {
            DisplayOperation = StringOfOperation;
        }
    }
}
