using System;
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
    /// 倒退鍵的Class, 功能為將TempInputString 最後char 刪除
    /// </summary>
    public class Backspace : Btns
    {
        /// <summary>
        /// 把response 放到winformcaldata 作展示
        /// </summary>
        public override void BtnFunction()
        {
            WinformCaldata = RemoveLastDigit();
        }

        /// <summary>
        /// 向Math controller 提出請求
        /// </summary>
        /// <returns>更新的caldata</returns>
        private CalData RemoveLastDigit()
        {
            string url = "https://localhost:44375/api/Math/Backspace";
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
