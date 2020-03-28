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

        private void LoggedIn(object sender, EventArgs e)
        {
            bool emailAcceptable = false;
            bool passwordAcceptable = false;

            //check if email is valid
            if (Validation.IsValidEmail(EmailField.Text))
            {
                EmailText.Text = "Email";
                emailAcceptable = true;
            }
            else
            {
                EmailText.Text = "Email seems to be invalid";
            }

            //check if password is valid
            if (Validation.IsPasswordValid(PasswordField.Text))
            {
                PasswordText.Text = "Password";
                passwordAcceptable = true;
            }
            else
            {
                PasswordText.Text = "Password is invalid";
            }


            if(passwordAcceptable && emailAcceptable)
            {
                //todo:
            }
        }
    }
}