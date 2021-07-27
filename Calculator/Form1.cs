using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Web;
using Newtonsoft.Json;

namespace Calculator
{
    /// <summary>
    /// Winform 程式 Form1 Class 
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 程式初始化
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.btnexe.Tag = "execute";
            this.btnadd.Tag = "Operation?btnop=" + System.Web.HttpUtility.UrlEncode(this.btnadd.Text);
            this.btnsub.Tag = "Operation?btnop=" + System.Web.HttpUtility.UrlEncode(this.btnsub.Text);
            this.btnmul.Tag = "Operation?btnop=" + System.Web.HttpUtility.UrlEncode(this.btnmul.Text);
            this.btndiv.Tag = "Operation?btnop=" + System.Web.HttpUtility.UrlEncode(this.btndiv.Text);
            this.btn0.Tag = "Numpad?btnnum=" + this.btn0.Text;
            this.btn1.Tag = "Numpad?btnnum=" + this.btn1.Text;
            this.btn2.Tag = "Numpad?btnnum=" + this.btn2.Text;
            this.btn3.Tag = "Numpad?btnnum=" + this.btn3.Text;
            this.btn4.Tag = "Numpad?btnnum=" + this.btn4.Text;
            this.btn5.Tag = "Numpad?btnnum=" + this.btn5.Text;
            this.btn6.Tag = "Numpad?btnnum=" + this.btn6.Text;
            this.btn7.Tag = "Numpad?btnnum=" + this.btn7.Text;
            this.btn8.Tag = "Numpad?btnnum=" + this.btn8.Text;
            this.btn9.Tag = "Numpad?btnnum=" + this.btn9.Text;
            this.btndec.Tag = "Dec";
            this.btnce.Tag = "ClearEntry";
            this.btnc.Tag = "ClearAll";
            this.btnback.Tag = "Backspace";
            this.btnPN.Tag = "PosNeg";
            this.btnroot.Tag = "Root";
            this.btnbrack1.Tag = "BracketOp?bracket=" + System.Web.HttpUtility.UrlEncode(this.btnbrack1.Text);
            this.btnbrack2.Tag = "BracketOp?bracket=" + System.Web.HttpUtility.UrlEncode(this.btnbrack2.Text);
        }
        /// <summary>
        /// 儲存winform 的CookieID以作辨識
        /// </summary>
        public static string CookieID { get; set; } = null;

        /// <summary>
        /// 整個winform 共用的caldata, 每次按按鍵都會給form1 作展示
        /// </summary>
        public static CalData WinformCaldata { get; set; }


        /// <summary>
        /// 按鍵的event handler, 會呼叫tag並使用其btnfunction
        /// </summary>
        /// <param name="sender">觸發者</param>
        /// <param name="e">事件數據</param>
        private void Button_Click(object sender, EventArgs e)
        {                 
            Button btn = (Button)sender;
            if (btn.Name != "label1")
            {
                WinformCaldata = PostRequest((string)btn.Tag);
                ResultBox.Text = WinformCaldata.TempInputString;
                CurOp.Text = WinformCaldata.DisplayOperation;
                PreOrd.Text = WinformCaldata.DisplayOperation;
                PreOrd.Text = WinformCaldata.Preordstring;
                InOrd.Text = WinformCaldata.Inordstring;
                PostOrd.Text = WinformCaldata.Postordstring;
            }
        }
        private CalData PostRequest(string btntag)
        {
            string url = "https://localhost:44375/api/Math/";
            url += btntag;
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
