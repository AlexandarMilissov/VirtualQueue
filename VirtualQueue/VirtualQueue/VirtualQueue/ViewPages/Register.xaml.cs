using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VirtualQueue.ViewPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        const int minStringSize = 1;
        const int maxStringSize = 10;
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
            if( IsNameValid(FirstNameField.Text) )
            {
                FirstNameText.Text = "First Name";
                firstNameAcceptable = true;
            }
            else
            {
                FirstNameText.Text = $"Name cannot be null, should be at least {minStringSize} and max {maxStringSize}.";
            }
            //check if second name is valid
            if ( IsNameValid(SecondNameField.Text) )
            {
                SecondNameText.Text = "Second Name";
                secondNameAcceptable = true;
            }
            else
            {
                SecondNameText.Text = $"Name cannot be null, should be at least {minStringSize} and max {maxStringSize}.";
            }
            //check if last name is valid
            if ( IsNameValid(LastNameField.Text) )
            {
                LastNameText.Text = "Last name";
                lastNameAcceptable = true;
            }
            else
            {
                LastNameText.Text = $"Name cannot be null, should be at least {minStringSize} and max {maxStringSize}.";
            }

            //check if email is valid
            if ( IsValidEmail(EmailField.Text) )
            {
                EmailText.Text = "Email";
                emailAcceptable = true;
            }
            else
            {
                EmailText.Text = "Email seems to be invalid";
            }

            //check if phone is valid
            if ( IsPhoneValidMatch(PhoneField.Text) )
            {
                PhoneText.Text = "Phone number is invalid";
                phoneAcceptable = true;
            }
            else
            {
                PhoneText.Text = "Phone number is invalid";
            }

            //check if password is valid
            if ( IsPasswordValid(PhoneField.Text) )
            {
                PasswordText.Text = "Password is invalid";
                phoneAcceptable = true;
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

            }
        }

        bool IsPasswordValid(string password)
        {
            if(password == null)
            {
                return false;
            }
            return true;
        }
        bool IsPhoneValidMatch(string phone)
        {
            if(phone == null)
            {
                return false;
            }
            if(phone.Length != 10)
            {
                return false;
            }
            for(int i = 0; i < 10; i++)
            {
                if(phone[i] >= '0' && phone[i] <= '9')
                {

                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        bool IsNameValid(string name)
        {
            if (name != null &&
                name.Length > minStringSize &&
                name.Length < maxStringSize)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}