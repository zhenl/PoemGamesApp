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
    public class RestPoemGetter : IPoemGetter
    {
        public int GetCountOfPoemLines()
        {
            return RestUtility.GetLineCount();
        }

        public string GetPoemLineByIndex(int idx)
        {
            return RestUtility.GetLineContentByIndxe(idx);
        }
    }
}