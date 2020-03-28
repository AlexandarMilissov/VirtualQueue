using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VirtualQueue.ViewPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void LoggedIn(object sender, EventArgs e)
        {
            bool emailAcceptable = false;
            bool passwordAcceptable = false;

            //check if email is valid
            if (Validation.IsValidEmail(EmailField.Text))
            {
                EmailError.IsVisible = false;
                EmailText.Text = "Email";
                emailAcceptable = true;
            }
            else
            {
                EmailError.IsVisible = true;
                EmailError.Text = "Email seems to be invalid";
            }

            //check if password is valid
            if (Validation.IsPasswordValid(PasswordField.Text))
            {
                PasswordError.IsVisible = false;
                PasswordText.Text = "Password";
                passwordAcceptable = true;
            }
            else
            {
                PasswordError.IsVisible = true;
                PasswordError.Text = "Password is invalid";
            }


            if(passwordAcceptable && emailAcceptable)
            {
                //todo: seach if user exists
                //if (true)

                await Navigation.PushAsync(new ManagerView());
            }
        }
    }
}