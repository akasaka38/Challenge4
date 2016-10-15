using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
     public static class Henkan
    {

        /// <summary>
        /// 数字をアルファベットに変換する
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string ToAlphabet(this int number)
        {
            //入力値が０以下の場合は処理を行わない
            if (number <= 0)
            {
                return "";
            }
            
            int n = number % 26;
            n = (n == 0) ? 26 : n;

            String s = ((char)(n + 64)).ToString();

            if (number == n)
            {
                return s;
            }

            return ((number - n) / 26).ToAlphabet() + s;
        }


        /// <summary>
        /// アルファベットを数字に変換する
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static int ToInt(this string self)
        {
            int result = 0;
            if (string.IsNullOrEmpty(self)) return result;

            char[] chars = self.ToCharArray();
            int len = self.Length - 1;
            foreach (var c in chars)
            {
                int asc = (int)c - 64;
                if (asc < 1 || asc > 26) return 0;
                result += asc * (int)Math.Pow((double)26, (double)len--);
            }
            return result;
        }
    }
}
