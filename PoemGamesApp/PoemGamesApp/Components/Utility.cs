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
        /// 获取唐诗
        /// </summary>
        /// <returns></returns>
        private static List<PocoLineInfo> GetLines()
        {
            var lst = new List<PocoLineInfo>();

            lst.Add(new PocoLineInfo
            {
                LineContent = "床前明月光"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "疑是地上霜"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "举头望明月"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "低头思故乡"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "危楼高百尺"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "手可摘星辰"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "不敢高声语"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "恐惊天上人"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "众鸟高飞尽"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "孤云独去闲"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "相看两不厌"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "只有敬亭山"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "小时不识月"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "呼作白玉盘"
            });


            lst.Add(new PocoLineInfo
            {
                LineContent = "又疑瑶台镜"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "飞在白云端"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "花间一壶酒"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "独酌无相亲"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "举杯邀明月"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "对影成三人"
            });

            return lst;
        }

        /// <summary>
        /// 随机获取两行唐诗
        /// </summary>
        /// <returns></returns>
        public static string[] GetRandTowLines()
        {
            var res = new string[2];

            var lst = GetLines();

            Random rd = new Random();

            int num = rd.Next(0, lst.Count);

            int num1 = rd.Next(0, lst.Count);

            res[0] = lst[num].LineContent;
            res[1] = lst[num1].LineContent;
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