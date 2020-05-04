using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;
using XF_Login.View;

namespace XF_Login.ViewModel
{
   public class WelcomePageVM: INotifyPropertyChanged
    {
        public WelcomePageVM(string email2, string url2)
        {
            Email = email2;
            URL = url2;
        }
        private string email;
        private string url;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string URL
        {
            get { return url; }
            set { url = value; }
        }

        private string password;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Password
        {
            get { return password; }
            set { password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public Command UpdateCommand
        {
            get { return new Command(Update); }
        }

        public Command DeleteCommand
        {
            get { return new Command(Delete); }
        }

        public Command BookMarking
        {
            get
            {
                return new Command(() =>
                {
                    App.Current.MainPage.Navigation.PushAsync(new Bookmarks(url));
                });
            }
        }
        public Command Starring
        {
                get { return new Command(Favorite); }
        }

        private  void Favorite()
        {
              App.Current.MainPage.DisplayAlert("Added Bookmark Article", "", "Ok");
        }

        //setings
        public Command OnItemClicked
        {
            get
            {
                return new Command(() =>
                {
                    App.Current.MainPage.Navigation.PushAsync(new Settings(email));
                });
            }

        }

        //For Logout
        public Command LogoutCommand
        {
            get
            {
                return new Command(() =>
                {
                     App.Current.MainPage.Navigation.PopAsync();
                });
            }
        }
        //Update user data
        private async void Update()
        {
            try
            {
                if (!string.IsNullOrEmpty(Password))
                {
                    var isupdate = await FirebaseHelper.UpdateUser(Email, Password);
                    if (isupdate)
                        await App.Current.MainPage.DisplayAlert("Update Success", "", "Ok");
                    else
                        await App.Current.MainPage.DisplayAlert("Error", "Record not update", "Ok");
                }
                else
                    await App.Current.MainPage.DisplayAlert("Password Require", "Please Enter your password", "Ok");
            }
            catch (Exception e)
            {

                Debug.WriteLine($"Error:{e}");
            }
        }
        //Delete user data
        private async void Delete()
        {
            try
            {
                var isdelete = await FirebaseHelper.DeleteUser(Email);
                if (isdelete)
                    await App.Current.MainPage.Navigation.PopAsync();
                else
                    await App.Current.MainPage.DisplayAlert("Error", "Record not delete", "Ok");
            }
            catch (Exception e)
            {

                Debug.WriteLine($"Error:{e}");
            }
        }
    }
}
