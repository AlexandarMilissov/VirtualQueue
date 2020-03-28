using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VirtualQueue.ViewPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
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
                FirstNameError.IsVisible = false;
            }
            else
            {
                FirstNameError.IsVisible = true;
                FirstNameError.Text = $"Name cannot be empty, should be at least {Validation.minStringSize} and max {Validation.maxStringSize}.";
            }
            //check if second name is valid
            if (Validation.IsNameValid(SecondNameField.Text))
            {
                SecondNameText.Text = "Second Name";
                secondNameAcceptable = true;
                SecondNameError.IsVisible = false;
            }
            else
            {
                SecondNameError.IsVisible = true;
                SecondNameError.Text = $"Name cannot be empty, should be at least {Validation.minStringSize} and max {Validation.maxStringSize}.";
            }
            //check if last name is valid
            if (Validation.IsNameValid(LastNameField.Text))
            {
                LastNameError.IsVisible = false;
                LastNameText.Text = "Last name";
                lastNameAcceptable = true;
            }
            else
            {
                LastNameError.IsVisible = true;
                LastNameError.Text = $"Name cannot be empty, should be at least {Validation.minStringSize} and max {Validation.maxStringSize}.";
            }

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

            //check if phone is valid
            if (Validation.IsPhoneValidMatch(PhoneField.Text))
            {
                PhoneError.IsVisible = false;
                PhoneText.Text = "Phone number is invalid";
                phoneAcceptable = true;
            }
            else
            {
                PhoneError.IsVisible = true;
                PhoneError.Text = "Phone number is invalid";
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