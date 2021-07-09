using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// ( ) 的類別, 由(及) 繼承
    /// </summary>
    public class Bracket : Btns
    {
        /// <summary>
        /// 使用本身按鈕的字串
        /// </summary>
        private string bracket;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="bracket">使用本身按鈕的字串"("或")"</param>
        public Bracket(string bracket)
        {
            this.bracket = bracket;
        }

        /// <summary>
        /// 按鈕功能
        /// 把括號加進Expressionlist StringOfOperation 以作最後execution判斷
        /// StoretoExe, 把算式傳到DisplayOperation供顯示
        /// </summary>
        public override void BtnFunction()
        {
            Expressionlist.Add(bracket);
            StringOfOperation += bracket;
            StoretoDisplay();
        }
    }
}
