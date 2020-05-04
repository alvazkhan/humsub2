using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Login.ViewModel;

namespace XF_Login.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {
        SettingsVM settingsVM;
        public Settings(string email)
        {
            InitializeComponent();
           
            //  Order = ToolbarItemOrder.Primary,
            // Priority = 0 
            //void OnItemClicked(object sender, EventArgs e)
            // {
            //} 
            //item.Clicked += OnItemClicked;
            // "this" refers to a Page object
            // this.ToolbarItems.Add(item);

           settingsVM = new SettingsVM(email);
           BindingContext = settingsVM;


        }
    }
}