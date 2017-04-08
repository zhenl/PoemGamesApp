using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace PoemGamesApp.Components
{
    public class Utility
    {
        

        /// <summary>
        /// 随机获取两行唐诗
        /// </summary>
        /// <returns></returns>
        public static string[] GetRandTowLines()
        {
            var getter = PoemGetterFactory.Create();

            var res = new string[2];
            
            var count = getter.GetCountOfPoemLines();

            Random rd = new Random();

            int num = rd.Next(0, count);

            int num1 = rd.Next(0, count);

            res[0] = getter.GetPoemLineByIndex(num);
            res[1] = getter.GetPoemLineByIndex(num1);
            return res;
        }

        /// <summary>
        /// 根据两行唐诗设计九宫格的排列
        /// </summary>
        /// <param name="line1"></param>
        /// <param name="line2"></param>
        /// <returns></returns>
        public static string[] GetButtonText(string line1,string line2)
        {
            var res = new string[9];
            var content = line1 + line2.Substring(0, 4);
            Random rd = new Random();
            for (var i = 8; i > 0; i--)
            {
                int n = rd.Next(0, i);
                res[i] = content.Substring(n, 1);
                content = content.Remove(n, 1);

            }
            res[0] = content;

            return res;
        }
    }
}