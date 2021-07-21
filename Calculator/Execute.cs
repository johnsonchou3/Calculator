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
    /// 等於鍵的類別, 功能為 把TempInputString打包, 並透過運算StringOfOperation, 結果存在TempInputString並顯示
    /// </summary>
    public class Execute : Btns
    {
        /// <summary>
        /// 把response 放到winformcaldata 作展示
        /// </summary>
        public override void BtnFunction()
        {
            WinformCaldata = GetResult();
        }

        /// <summary>
        /// 向Math controller 提出請求
        /// </summary>
        /// <returns>回傳運算結果(string)</returns>
        private CalData GetResult()
        {
            string url = "https://localhost:44375/api/Math/execute";
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
