using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// ")" 按鈕的類別, 繼承Bracket 
    /// </summary>
    public class BracketClose : Bracket
    {
        /// <summary>
        /// 使用本身按鈕的字串
        /// </summary>
        private string bracket;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="bracket">使用本身按鈕的字串</param>
        public BracketClose(string bracket) : base (bracket)
        {
            this.bracket = bracket;
        }

        /// <summary>
        /// 按鈕功能
        /// 除了繼承Bracket的功能之外, 還需要把目前的輸入字串存起來
        /// 並把IsAfterBracket 改為True 讓Operation 及 Execute 作判斷以免出錯
        /// </summary>
        public override void BtnFunction()
        {
            StringOfOperation += TempInputString;
            Expressionlist.Add(TempInputString);
            base.BtnFunction();
            TempInputString = "0";
            IsAfterBracket = true;
        }
    }
}
