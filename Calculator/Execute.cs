using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// 等於鍵的類別, 功能為 把val1 val2打包, 並透過operator 對應的actionmap作運算, 把結果顯於txtbox
    /// </summary>
    public class Execute : Btns
    {
        /// <summary>
        /// 需要form1 的txtbox 及label作存取
        /// </summary>
        private readonly Form1 form1;

        /// <summary>
        /// 從label 得到目前operator
        /// </summary>
        private string curop;

        /// <summary>
        /// 從label 得到val1
        /// </summary>
        private decimal val1;

        /// <summary>
        /// 從txtbox 得到val2
        /// </summary>
        private decimal val2;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="form1">需form1作txtbox label 存取</param>
        public Execute(Form1 form1)
        {
            this.form1 = form1;
        }

        /// <summary>
        /// 按鍵功能
        /// SplitLabel: 把label的val1及operator分開並存入attribute 
        /// AssignVal2: 把txtboxstr 的val2 存入attribute
        /// 把val2 放到label並把結果顯示在txtbox 
        /// </summary>
        public override void BtnFunction()
        {
            SplitLabel();
            AssignVal2();
            form1.TextBoxStr = GetStrNum();
            form1.LabelStr += val2;
        }

        /// <summary>
        /// 把label的val1及operator分開並存入attribute 
        /// </summary>
        private void SplitLabel()
        {
            string labelstr = this.form1.LabelStr;
            curop = labelstr.Substring(labelstr.Length - 1);
             val1 = decimal.Parse(labelstr.Remove(labelstr.Length - 1));
        }

        /// <summary>
        /// 把txtboxstr 的val2 存入attribute
        /// </summary>
        private void AssignVal2()
        {
            this.val2 = decimal.Parse(form1.TextBoxStr);
        }

        /// <summary>
        /// 透過label1 的operator 放入Actionmap 並找到相應的運算
        /// </summary>
        /// <returns>回傳運算結果val3的string</returns>
        public string GetStrNum()
        {
            string val3str = "";
            Dictionary<string, decimal> actionmap = new Dictionary<string, decimal>();
            actionmap["+"] = Addition();
            actionmap["-"] = Subtraction();
            actionmap["*"] = Multiplication();
            actionmap["/"] = Division();
            decimal val3 = actionmap[curop];
            val3str = val3.ToString();
            return val3str;
        }

        /// <summary>
        /// 加法的運算, 放入actionmap
        /// </summary>
        /// <returns>val1 val2的加法結果</returns>
        private decimal Addition()
        {
            return this.val1 + this.val2;
        }

        /// <summary>
        /// 減法的運算, 放入actionmap
        /// </summary>
        /// <returns>val1 val2的減法結果</returns>
        private decimal Subtraction()
        {
            return this.val1 - this.val2;
        }

        /// <summary>
        /// 乘法的運算, 放入actionmap
        /// </summary>
        /// <returns>val1 val2的乘法結果</returns>
        private decimal Multiplication()
        {
            return this.val1 * this.val2;
        }

        /// <summary>
        /// 乘法的運算, 放入actionmap
        /// </summary>
        /// <returns>val1 val2的乘法結果</returns>
        private decimal Division()
        {
            return this.val1 / this.val2;
        }
    }
}
