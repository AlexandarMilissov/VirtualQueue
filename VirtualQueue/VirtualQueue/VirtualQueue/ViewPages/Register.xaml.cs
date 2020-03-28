using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VirtualQueue.ViewPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        private static int minStringSize = 1;
        private static int maxStringSize = 10;
        public Register()
        {
            InitializeComponent();
        }
        private void Registered(object sender, EventArgs e)
        {
            bool firstNameAcceptable = false;
            bool secondNameAcceptable = false;
            bool lastNameAcceptable = false;
            bool emailAcceptable = false;
            bool phoneAcceptable = false;
            bool passwordAcceptable = false;

            //check if first name is valid
            if (Validation.IsNameValid(FirstNameField.Text))
            {
                FirstNameText.Text = "First Name";
                firstNameAcceptable = true;
            }
            else
            {
                FirstNameText.Text = $"Name cannot be empty, should be at least {minStringSize} and max {maxStringSize}.";
            }
            //check if second name is valid
            if (Validation.IsNameValid(SecondNameField.Text))
            {
                SecondNameText.Text = "Second Name";
                secondNameAcceptable = true;
            }
            else
            {
                SecondNameText.Text = $"Name cannot be empty, should be at least {minStringSize} and max {maxStringSize}.";
            }
            //check if last name is valid
            if (Validation.IsNameValid(LastNameField.Text))
            {
                LastNameText.Text = "Last name";
                lastNameAcceptable = true;
            }
            else
            {
                LastNameText.Text = $"Name cannot be empty, should be at least {minStringSize} and max {maxStringSize}.";
            }

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

            //check if phone is valid
            if (Validation.IsPhoneValidMatch(PhoneField.Text))
            {
                PhoneText.Text = "Phone number is invalid";
                phoneAcceptable = true;
            }
            else
            {
                PhoneText.Text = "Phone number is invalid";
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

            if (firstNameAcceptable &&
                secondNameAcceptable &&
                lastNameAcceptable &&
                emailAcceptable &&
                phoneAcceptable &&
                passwordAcceptable)
            {
                //todo: 
            }
        }
    }
}