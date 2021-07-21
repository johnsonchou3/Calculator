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
    /// 加減乘除的類別, 功能為 打包TempInputString並加上operator, 並清空
    /// </summary>
    public class Operation : Btns
    {
        /// <summary>
        /// 需按鍵本身的operator
        /// </summary>
        private string btnop;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="btnop">需按鍵本身的operator</param>
        public Operation(string btnop)
        {
            this.btnop = btnop;
        }

        /// <summary>
        /// 把response 放到winformcaldata 作展示
        /// </summary>
        public override void BtnFunction()
        {
            WinformCaldata = SaveValue();
        }

        /// <summary>
        /// 向Math controller 提出請求
        /// </summary>
        /// <returns>更新的caldata</returns>
        private CalData SaveValue()
        {
            string url = "https://localhost:44375/api/Math/Operation?btnop=" + System.Web.HttpUtility.UrlEncode(btnop);
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.Headers["Cookie"] = CookieID;
            var response = (HttpWebResponse)request.GetResponse();
            CookieID = response.Headers["set-cookie"];
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            CalData caldata = Newtonsoft.Json.JsonConvert.DeserializeObject<CalData>(responseString);
            return caldata;
        }
    }
}