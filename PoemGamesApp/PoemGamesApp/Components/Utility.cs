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

        /// <summary>
        /// �����ȡ������ʫ
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
        /// ����������ʫ��ƾŹ��������
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