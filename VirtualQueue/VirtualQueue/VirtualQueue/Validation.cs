using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualQueue
{
    public static class Validation
    {
        private static int minStringSize = 1;
        private static int maxStringSize = 10;

        public static bool IsPasswordValid(string password)
        {
            if (password == null)
            {
                return false;
            }
            return true;
        }

        public static bool IsPhoneValidMatch(string phone)
        {
            if (phone == null)
            {
                return false;
            }
            if (phone.Length != 10)
            {
                return false;
            }
            for (int i = 0; i < 10; i++)
            {
                if (phone[i] >= '0' && phone[i] <= '9')
                {

                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsValidEmail(string email)
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

        public static bool IsNameValid(string name)
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
