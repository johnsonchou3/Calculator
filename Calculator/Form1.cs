using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Web;
using Newtonsoft.Json;
using System.Threading;
using System.Configuration;

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
            this.btnexe.Tag = "?method=Execute";
            this.btnadd.Tag = "?method=Operation&btn=" + System.Web.HttpUtility.UrlEncode(this.btnadd.Text);
            this.btnsub.Tag = "?method=Operation&btn=" + System.Web.HttpUtility.UrlEncode(this.btnsub.Text);
            this.btnmul.Tag = "?method=Operation&btn=" + System.Web.HttpUtility.UrlEncode(this.btnmul.Text);
            this.btndiv.Tag = "?method=Operation?btn=" + System.Web.HttpUtility.UrlEncode(this.btndiv.Text);
            this.btn0.Tag = "?method=NumPad&btn=" + this.btn0.Text;
            this.btn2.Tag = "?method=NumPad&btn=" + this.btn2.Text;
            this.btn1.Tag = "?method=NumPad&btn=" + this.btn1.Text;
            this.btn3.Tag = "?method=NumPad&btn=" + this.btn3.Text;
            this.btn4.Tag = "?method=NumPad&btn=" + this.btn4.Text;
            this.btn5.Tag = "?method=NumPad&btn=" + this.btn5.Text;
            this.btn6.Tag = "?method=NumPad&btn=" + this.btn6.Text;
            this.btn7.Tag = "?method=NumPad&btn=" + this.btn7.Text;
            this.btn8.Tag = "?method=NumPad&btn=" + this.btn8.Text;
            this.btn9.Tag = "?method=NumPad&btn=" + this.btn9.Text;
            this.btndec.Tag = "?method=Dec";
            this.btnce.Tag = "?method=ClearEntry";
            this.btnc.Tag = "?method=ClearAll";
            this.btnback.Tag = "?method=Backspace";
            this.btnPN.Tag = "?method=PosNeg";
            this.btnroot.Tag = "?method=Root";
            this.btnbrack1.Tag = "?method=BracketOp&btn=" + HttpUtility.UrlEncode(this.btnbrack1.Text);
            this.btnbrack2.Tag = "?method=BracketClose&btn=" + HttpUtility.UrlEncode(this.btnbrack2.Text);
            this.btninv.Tag = "?method=Invert";
        }

        /// <summary>
        /// 從config 檔取得base url
        /// </summary>
        private readonly string url = ConfigurationManager.AppSettings["url"];

        /// <summary>
        /// 儲存winform 的CookieID以作辨識
        /// </summary>
        public string CookieID { get; set; }

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
            StatusLab.Text = "Processing...";
            if (btn.Name != "label1")
            {
                Thread thread = new Thread(SetValue);
                thread.Start();
                void SetValue()
                {
                    PostRequest((string)btn.Tag);
                }
            }
        }
    
        /// <summary>
        /// 送出post 請求的function
        /// </summary>
        /// <param name="btntag">需傳入btntag到url</param>
        private void PostRequest(string btntag)
        {
            string tempurl = url + btntag;
            var request = (HttpWebRequest)WebRequest.Create(tempurl);
            request.Method = "POST";
            request.Headers["Cookie"] = CookieID;

            try
            {
                //成功回傳200
                var response = (HttpWebResponse)request?.GetResponse();
                   CookieID = response.Headers["set-cookie"];
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                CalData caldata = JsonConvert.DeserializeObject<CalData>(responseString);
                WinformCaldata = caldata;
                this.Invoke((MethodInvoker)delegate
                {
                    StatusLab.Text = "Status Code: " + (int)response.StatusCode;
                    ResultBox.Text = WinformCaldata.TempInputString;
                    CurOp.Text = WinformCaldata.DisplayOperation;
                    PreOrd.Text = WinformCaldata.DisplayOperation;
                    PreOrd.Text = WinformCaldata.Preordstring;
                    InOrd.Text = WinformCaldata.Inordstring;
                    PostOrd.Text = WinformCaldata.Postordstring;
                });
            }
            catch (WebException ex)
            {
                try
                {
                    //有response 但非200
                    StreamReader streamreader = new StreamReader(ex.Response?.GetResponseStream());
                    this.Invoke((MethodInvoker)delegate
                    {
                        StatusLab.Text = "Status Code: " + (int)((HttpWebResponse)ex.Response).StatusCode + "-" + streamreader.ReadToEnd();
                    });
                }
                catch (ArgumentNullException)
                {
                    //沒有response
                    this.Invoke((MethodInvoker)delegate
                    {
                        StatusLab.Text = "WebAPI is not available currently.";
                    });
                }
            }
        }
    }
}
