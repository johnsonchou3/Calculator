using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// 加減乘除的類別, 功能為 打包TempInputString並加上operator, 並清空
    /// </summary>
    public class Operation : Btns
    {
        /// <summary>
        /// 需按鍵本身的operator
        /// </summary>
        private string btnop;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="btnop">需按鍵本身的operator</param>
        public Operation(string btnop)
        {
            this.btnop = btnop;
        }

        /// <summary>
        /// 按鍵動作
        /// if (IsOperating): 如果前一個按的也是operation(isoperating), 就只會替換上一個btnop; ELSE 存入Tempinputstring及btnop 
        /// if (!IsAfterBracket): 如果在")"後面, 只存入btnop, ELSE 存入tempinputstring + btnop
        /// SaveValue: 把TempInputString及目前的operator寫入StringOfOperation, ExpressionList中
        /// ClearTemp: 寫入後把TempInputString清空作下一次儲存
        /// StoretoDisplay: 把新的stringofoperation 更新至畫面
        /// </summary>
        public override void BtnFunction()
        {
            if (IsOperating)
            {
                StringOfOperation = StringOfOperation.Remove(StringOfOperation.Length - 1, 1) + btnop;
            }
            else
            {
                IsOperating = true;
                if (IsAfterBracket)
                {
                    Expressionlist.Add(btnop);
                    StringOfOperation += btnop;
                    IsAfterBracket = false;
                }
                else
                {
                    SaveValue();
                    ClearTemp();
                }
            }
            StoretoDisplay();
        }

        /// <summary>
        /// 把TempInputString及目前的operator寫入StringOfOperation中
        /// </summary>
        private void SaveValue()
        {
            StringOfOperation += double.Parse(TempInputString).ToString() + btnop;
            Expressionlist.Add(TempInputString);
            Expressionlist.Add(btnop);
        }

        /// <summary>
        /// 寫入後把TempInputString清空作下一次儲存
        /// </summary>
        private void ClearTemp()
        {
            TempInputString = "0";
        }
    }
}