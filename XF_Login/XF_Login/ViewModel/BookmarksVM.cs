using System;
using System.Collections.Generic;
using System.Text;
using XF_Login.View;
using System.Diagnostics;
using Xamarin.Forms;
using System.ComponentModel;

namespace XF_Login.ViewModel
{
   public class BookmarksVM 
    {
        public BookmarksVM(string url2)
        {
            URL = url2;
        }
        private string url;

        public string URL
        {
            get { return url; }
            set { url = value; }
        }
    }
}
