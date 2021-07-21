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
    /// "0~9."的按鍵類別, 功能把按鍵值加到TempInputString最後
    /// </summary>
    public class NumPad : Btns
    {
        /// <summary>
        /// 按鍵本身的值
        /// </summary>
        private string btnnum;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="btnnum">按鍵本身的值</param>
        public NumPad(string btnnum)
        {
            this.btnnum = btnnum;
        }

        /// <summary>
        /// 把response 放到winformcaldata 作展示
        /// </summary>
        public override void BtnFunction()
        {
            WinformCaldata = AddNum();
        }

        /// <summary>
        /// 向Math controller 提出請求
        /// </summary>
        /// <returns>更新的caldata</returns>
        public CalData AddNum()
        {
            string url = "https://localhost:44375/api/Math/Numpad?btnnum=" + btnnum;
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
