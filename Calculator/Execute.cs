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
        /// 按鍵功能
        /// if (!IsAfterBracket): 不在")"後的話則需把tempinputstring 存入
        /// CreateTree: 以expressionlist 創建Tree以作Traverse
        /// GetXxxOrder: 以Tree 作前、中、後序遍歷並把結果顯示
        /// SaveValue: 把目前輸入值加進stringofoperation 及expressionlist中
        /// GetResult: 把運算式(string) 作運算並回傳結果(string)
        /// Label 顯示運算式, 並把結果存進tempinputstring再清空運算式
        /// </summary>
        public override void BtnFunction()
        {
            if (!IsAfterBracket)
            {
                SaveValue();
                IsAfterBracket = false;
            }
            Node ExpTree = Node.CreateTree(Expressionlist);
            Preordstring = "Pre-Order: \n";
            Inordstring = "In-Order: \n";
            Postordstring = "Post-Order: \n";
            GetPreorder(ExpTree);
            GetInorder(ExpTree);
            GetPostorder(ExpTree);
            TempInputString = GetResult();
            DisplayOperation = StringOfOperation;
            StringOfOperation = string.Empty;
            Expressionlist.Clear();
        }

        /// <summary>
        /// 把目前輸入值加進運算式中
        /// </summary>
        private void SaveValue()
        {
            StringOfOperation += TempInputString;
            Expressionlist.Add(TempInputString);
        }

        /// <summary>
        /// 把運算式(string) 作運算並回傳結果(string)
        /// </summary>
        /// <returns>回傳運算結果(string)</returns>
        private string GetResult()
        {
            DataTable dt = new DataTable();
            return dt.Compute(StringOfOperation, "").ToString();
        }

        /// <summary>
        /// 以前序編歷Tree, 並把value 加到Preordstring 以顯示
        /// </summary>
        /// <param name="root">需要Tree的root</param>
        private static void GetPreorder(Node root)
        {
            if (root != null)
            {
                Preordstring += root.Value + " ";
                GetPreorder(root.Left);
                GetPreorder(root.Right);
            }
        }

        /// <summary>
        /// 以中序編歷Tree, 並把value 加到Preordstring 以顯示
        /// </summary>
        /// <param name="root">需要Tree的root</param>
        private static void GetInorder(Node root)
        {
            if (root != null)
            {
                GetInorder(root.Left);
                Inordstring += root.Value + " ";
                GetInorder(root.Right);
            }
        }

        /// <summary>
        /// 以後序編歷Tree, 並把value 加到Preordstring 以顯示
        /// </summary>
        /// <param name="root">需要Tree的root </param>
        private static void GetPostorder(Node root)
        {
            if (root != null)
            {
                GetPostorder(root.Left);
                GetPostorder(root.Right);
                Postordstring += root.Value + " ";
            }
        }
    }
}
