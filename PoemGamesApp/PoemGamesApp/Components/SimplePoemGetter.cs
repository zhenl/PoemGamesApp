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
        /// ��ȡ��ʫ
        /// </summary>
        /// <returns></returns>
        private static List<PocoLineInfo> GetLines()
        {
            var lst = new List<PocoLineInfo>();

            lst.Add(new PocoLineInfo
            {
                LineContent = "��ǰ���¹�"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "���ǵ���˪"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "��ͷ������"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "��ͷ˼����"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "Σ¥�߰ٳ�"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "�ֿ�ժ�ǳ�"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "���Ҹ�����"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "�־�������"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "����߷ɾ�"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "���ƶ�ȥ��"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "�࿴������"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "ֻ�о�ͤɽ"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "Сʱ��ʶ��"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "����������"
            });


            lst.Add(new PocoLineInfo
            {
                LineContent = "������̨��"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "���ڰ��ƶ�"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "����һ����"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "����������"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "�ٱ�������"
            });

            lst.Add(new PocoLineInfo
            {
                LineContent = "��Ӱ������"
            });

            return lst;
        }
    }
}