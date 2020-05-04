using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Login.ViewModel;
using Xamarin.Essentials;

namespace XF_Login.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bookmarks : ContentPage
    {
       BookmarksVM bookmarksVM;

       public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

        public Bookmarks(string url)
        { 
            
            InitializeComponent();

           bookmarksVM = new BookmarksVM(url);
            BindingContext = this;
        }
    }
}