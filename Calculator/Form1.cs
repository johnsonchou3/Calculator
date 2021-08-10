using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Web;
using Newtonsoft.Json;
using System.Threading;
using System.Configuration;
using System.Threading.Tasks;

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
            this.buttonExecute.Tag = "?method=Execute";
            this.buttonAdd.Tag = "?method=AddSubtract&button=" + System.Web.HttpUtility.UrlEncode(this.buttonAdd.Text);
            this.buttonSubtract.Tag = "?method=AddSubtract&button=" + System.Web.HttpUtility.UrlEncode(this.buttonSubtract.Text);
            this.buttonMultiply.Tag = "?method=MultiplyDivision&button=" + System.Web.HttpUtility.UrlEncode(this.buttonMultiply.Text);
            this.buttonDivision.Tag = "?method=MultiplyDivision&button=" + System.Web.HttpUtility.UrlEncode(this.buttonDivision.Text);
            this.button0.Tag = "?method=NumPad&button=" + this.button0.Text;
            this.button2.Tag = "?method=NumPad&button=" + this.button2.Text;
            this.button1.Tag = "?method=NumPad&button=" + this.button1.Text;
            this.button3.Tag = "?method=NumPad&button=" + this.button3.Text;
            this.button4.Tag = "?method=NumPad&button=" + this.button4.Text;
            this.button5.Tag = "?method=NumPad&button=" + this.button5.Text;
            this.button6.Tag = "?method=NumPad&button=" + this.button6.Text;
            this.button7.Tag = "?method=NumPad&button=" + this.button7.Text;
            this.button8.Tag = "?method=NumPad&button=" + this.button8.Text;
            this.button9.Tag = "?method=NumPad&button=" + this.button9.Text;
            this.buttonDecimal.Tag = "?method=AddDecimal";
            this.buttonCE.Tag = "?method=ClearEntry";
            this.buttonC.Tag = "?method=ClearAll";
            this.buttonBack.Tag = "?method=Backspace";
            this.buttonPositiveNegative.Tag = "?method=PositiveNegative";
            this.buttonRoot.Tag = "?method=Root";
            this.buttonBracketOpen.Tag = "?method=BracketOpen&button=" + HttpUtility.UrlEncode(this.buttonBracketOpen.Text);
            this.buttonBracketClose.Tag = "?method=BracketClose&button=" + HttpUtility.UrlEncode(this.buttonBracketClose.Text);
            this.buttonInvert.Tag = "?method=Invert";
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
        private async void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            StatusLabel.Text = "Processing...";
            try
            {
                //成功回傳200
                WinformCaldata = await PostRequestAsync((string)btn.Tag);
                ResultBox.Text = WinformCaldata.TempInputString;
                CurrentOperation.Text = WinformCaldata.DisplayOperation;
                PreOrderLabel.Text = WinformCaldata.DisplayOperation;
                PreOrderLabel.Text = WinformCaldata.Preordstring;
                InOrderLabel.Text = WinformCaldata.Inordstring;
                PostOrderLabel.Text = WinformCaldata.Postordstring;
            }
            catch (WebException exception)
            {
                try
                {
                    //有response 但非200
                    StreamReader streamreader = new StreamReader(exception.Response?.GetResponseStream());

                    StatusLabel.Text = "Status Code: " + (int)((HttpWebResponse)exception.Response).StatusCode + "-" + streamreader.ReadToEnd();

                }
                catch (ArgumentNullException)
                {
                    //沒有response

                    StatusLabel.Text = "WebAPI is not available currently.";

                }
            }
        }

        /// <summary>
        /// 送出post 請求的function
        /// </summary>
        /// <param name="btntag">需傳入btntag到url</param>
        private async Task<CalData> PostRequestAsync(string btntag)
        {
            string tempurl = url + btntag;
            var request = (HttpWebRequest)WebRequest.Create(tempurl);
            request.Method = "POST";
            request.Headers["Cookie"] = CookieID;
            HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
            CookieID = response.Headers["set-cookie"];
            StatusLabel.Text = "Status Code: " + (int)response.StatusCode;
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            CalData caldata = JsonConvert.DeserializeObject<CalData>(responseString);
            return caldata;
        }
    }
}
