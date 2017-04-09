using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace PoemGamesApp
{
    [Activity(Label = "猜唐诗", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //int count = 1;

        string[] Lines;
        List<Button> dicButton;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            TextView txtsuccess = FindViewById<TextView>(Resource.Id.txtSuccess);
            txtsuccess.Visibility = ViewStates.Invisible;

            Button button = FindViewById<Button>(Resource.Id.MyButton);

            Button bn1 = FindViewById<Button>(Resource.Id.bn1);
            Button bn2 = FindViewById<Button>(Resource.Id.bn2);
            Button bn3 = FindViewById<Button>(Resource.Id.bn3);
            Button bn4 = FindViewById<Button>(Resource.Id.bn4);
            Button bn5 = FindViewById<Button>(Resource.Id.bn5);
            Button bn6 = FindViewById<Button>(Resource.Id.bn6);
            Button bn7 = FindViewById<Button>(Resource.Id.bn7);
            Button bn8 = FindViewById<Button>(Resource.Id.bn8);
            Button bn9 = FindViewById<Button>(Resource.Id.bn9);

            dicButton = new List<Button>
            {
                bn1,
                bn2,
                bn3,
                bn4,
                bn5,
                bn6,
                bn7,
                bn8,
                bn9
            };
            Button btndelete = FindViewById<Button>(Resource.Id.btnDelete);
            btndelete.Click += delegate {
                TextView txtResult = FindViewById<TextView>(Resource.Id.txtRes);
                var res = txtResult.Text;
                if (!string.IsNullOrEmpty(res))
                {
                    if (res.Length == 1)
                    {
                        txtResult.Text = "";
                    }
                    else
                    {
                        txtResult.Text = res.Substring(0, res.Length - 1);
                    }
                    txtsuccess.Visibility = ViewStates.Invisible;
                }
            };

            Button btnShow = FindViewById<Button>(Resource.Id.btnShow);
            TextView txt = FindViewById<TextView>(Resource.Id.txtLine);

            button.Click += delegate {
                //TextView txtsuccess = FindViewById<TextView>(Resource.Id.txtSuccess);
                txtsuccess.Visibility = ViewStates.Invisible;
                Lines = Components.Utility.GetRandTowLines();

                txt.Text = Lines[0];
                txt.Visibility = ViewStates.Invisible;
                var buttontext = Components.Utility.GetButtonText(Lines[0], Lines[1]);

                bn1.Text = buttontext[0];
                bn2.Text = buttontext[1];
                bn3.Text = buttontext[2];
                bn4.Text = buttontext[3];
                bn5.Text = buttontext[4];
                bn6.Text = buttontext[5];
                bn7.Text = buttontext[6];
                bn8.Text = buttontext[7];
                bn9.Text = buttontext[8];

                TextView txtResult = FindViewById<TextView>(Resource.Id.txtRes);
                txtResult.Text = "";

            };

            bn1.Click += btClick;
            bn2.Click += btClick;
            bn3.Click += btClick;
            bn4.Click += btClick;
            bn5.Click += btClick;
            bn6.Click += btClick;
            bn7.Click += btClick;
            bn8.Click += btClick;
            bn9.Click += btClick;




            btnShow.Click += delegate {
                txt.Visibility = ViewStates.Visible;
            };


        }



        private void btClick(object sender, EventArgs e)
        {
            TextView txt = FindViewById<TextView>(Resource.Id.txtLine);
            TextView txtResult = FindViewById<TextView>(Resource.Id.txtRes);
            if (!string.IsNullOrEmpty(txtResult.Text) && txtResult.Text.Length == 5) return;
            TextView txtsuccess = FindViewById<TextView>(Resource.Id.txtSuccess);
            var c = ((Button)sender).Text.ToString();
            //if (!txtResult.Text.Contains(c))
            if (GetCharCount(txtResult.Text, c) < GetCharCount(c))
            { txtResult.Text += c; }

            if (txtResult.Text == txt.Text)
            {
                txtsuccess.Text = "完全正确！";
                txtsuccess.Visibility = ViewStates.Visible;
            }else if (txtResult.Text.Length == 5)
            {
                txtsuccess.Text = "猜错了...";
                txtsuccess.Visibility = ViewStates.Visible;
            }
            else
            {
                txtsuccess.Visibility = ViewStates.Invisible;
            }
        }


        private int GetCharCount(string c)
        {
            int count = 0;
            for (var i = 0; i < 9; i++)
            {
                if (dicButton[i].Text.ToString() == c)
                {
                    count++;
                }
            }
            return count;
        }

        private int GetCharCount(string s, string c)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s.Substring(i, 1) == c) count++;
            }
            return count;
        }


    }
}

