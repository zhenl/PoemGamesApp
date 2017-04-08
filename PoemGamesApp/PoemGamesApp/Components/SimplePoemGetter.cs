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
    public class SimplePoemGetter : IPoemGetter
    {
        private List<PocoLineInfo> lines=GetLines();

        public int GetCountOfPoemLines()
        {
            return lines.Count;
        }

        public string GetPoemLineByIndex(int idx)
        {
            return lines[idx].LineContent;
        }

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
    }
}