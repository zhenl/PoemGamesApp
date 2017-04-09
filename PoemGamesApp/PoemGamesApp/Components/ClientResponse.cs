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
    class ClientResponse
    {
        public string LineContent { get; set; }
        public string PoemContent { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
    }
}
