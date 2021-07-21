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
    /// ")" 按鈕的類別, 繼承Bracket 
    /// </summary>
    public class BracketClose : Btns
    {
        /// <summary>
        /// 使用本身按鈕的字串
        /// </summary>
        private string bracket;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="bracket">使用本身按鈕的字串</param>
        public BracketClose(string bracket) 
        {
            this.bracket = bracket;
        }

        /// <summary>
        /// 把response 放到winformcaldata 作展示
        /// </summary>
        public override void BtnFunction()
        {
            WinformCaldata = AddBracket();
        }

        /// <summary>
        /// 向Math controller 提出請求
        /// </summary>
        /// <returns>更新的caldata</returns>
        private CalData AddBracket()
        {
            string url = "https://localhost:44375/api/Math/BracketClose?bracket=" + System.Web.HttpUtility.UrlEncode(bracket);
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
