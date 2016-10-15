using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge4
{
    public partial class ChallengeMain : Form
    {
        public ChallengeMain()
        {
            InitializeComponent();
            //テスト
           
        }


        /// <summary>
        /// 変換ボタンが押されたとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HenkanButton_Click(object sender, EventArgs e)
        {
            //エラーチェックを行う
            if (!ErrorCheck())
            {
                return;
            }     

            //変換
            outputValue.Text = HenkanJikkou(inputValue.Text.ToUpper());
        }


        /// <summary>
        /// 変換処理を行う
        /// </summary>
        /// <param name="moji"></param>
        /// <returns></returns>
        private String HenkanJikkou(String moji)
        {
            String outputText = "";

            //入力された文字が数字かどうかで処理を分ける
            int s = 0;
            if (int.TryParse(moji, out s))
            {
                //文字に変換
                outputText = Henkan.ToAlphabet(int.Parse(moji));
            }
            else
            {
                //数字に変換
                outputText = Henkan.ToInt(moji).ToString();
            }



            //変換がうまくいっているかを調べる
            if(outputText.Trim() == String.Empty || outputText.Trim() == "0")
            {
                //失敗した場合
                outputText = "";
            }
           
            return outputText;
        }

        /// <summary>
        /// 変換前のエラーチェックを行う
        /// </summary>
        /// <returns></returns>
        private Boolean ErrorCheck()
        {

            //文字が入力されていなかった場合
            if(inputValue.Text.Trim() == "")
            {
                return false;
            }

            return true;
        }
    }
}
