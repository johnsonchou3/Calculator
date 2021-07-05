using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Calculator
{
    /// <summary>
    /// 等於鍵的類別, 功能為 把TempInputString打包, 並透過運算StringOfOperation, 結果存在TempInputString並顯示
    /// </summary>
    public class Execute : Btns
    {
        /// <summary>
        /// 需要form1 的TempInputString, StringOfOperation, txtbox 及label作存取
        /// </summary>
        private readonly Form1 form1;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="form1">需要form1 的TempInputString, StringOfOperation, txtbox 及label作存取</param>
        public Execute(Form1 form1)
        {
            this.form1 = form1;
        }

        /// <summary>
        /// 按鍵功能
        /// SaveValue: 把目前輸入值加進運算式中
        /// GetResult: 把運算式(string) 作運算並回傳結果(string)
        /// Label 顯示運算式, 並把結果存進tempinputstring再清空運算式, 最後把tempinputstring (結果) 顯示在textbox
        /// </summary>
        public override void BtnFunction()
        {
            SaveValue();
            form1.LabelStr = form1.StringOfOperation + "=";
            form1.TempInputString = GetResult();
            form1.StringOfOperation = string.Empty;
            form1.TextBoxStr = form1.TempInputString;
        }

        /// <summary>
        /// 把目前輸入值加進運算式中
        /// </summary>
        private void SaveValue()
        {
            form1.StringOfOperation += form1.TempInputString;
        }

        /// <summary>
        /// 把運算式(string) 作運算並回傳結果(string)
        /// </summary>
        /// <returns>回傳運算結果(string)</returns>
        private string GetResult()
        {
            DataTable dt = new DataTable();
            return dt.Compute(form1.StringOfOperation, "").ToString();
        }
    }
}
