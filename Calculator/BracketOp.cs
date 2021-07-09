using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// "(" 按鈕的類別, 繼承Bracket
    /// </summary>
    public class BracketOp : Bracket
    {
        /// <summary>
        /// 使用本身按鈕的字串
        /// </summary>
        private string bracket;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="bracket">使用本身按鈕的字串</param>
        public BracketOp (string bracket) : base(bracket)
        {
            this.bracket = bracket;
        }

        /// <summary>
        /// 按鈕功能
        /// 繼承Bracket的功能, 把"(" 存進Expressionlist 及Stringofoperation, 並更新exeoper
        /// </summary>
        public override void BtnFunction()
        {
            base.BtnFunction();
        }
    }
}
