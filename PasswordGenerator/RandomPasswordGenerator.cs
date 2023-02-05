using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class RandomPasswordGenerator
    {

        const string SpecialCharacter = @"#()$%^-*=&!_+<>";
        const string Numbers = "0123456789";
        const string Lowercase = "abcdefghijklmnopqrstuvwxyz";
        const string Uppercase = "ABCDEFGHIJKLMOPQRSTUVWXYZ";
                 
        public string RandomPassword(string SPECIALCHARACTER, string NUMBERS, string LOWERCASE, string UPPERCASE, int Lengthofpassword)
        {
            char[] password = new char[Lengthofpassword];
            string RPassword = "";
            System.Random random = new Random();

            switch (SPECIALCHARACTER)
            {
                case "Y" or "y":
                    RPassword += SpecialCharacter;
                    break;
                case "N" or "n":
                    RPassword += RPassword;
                    break;
                    
            }


            switch (NUMBERS)
            {
                case "Y" or "y":
                    RPassword += Numbers;
                    break;
                case "N" or "n":
                    RPassword += RPassword;
                    break;
            }

            switch (LOWERCASE)
            {
                case "Y" or "y":
                    RPassword += Lowercase;
                    break;
                case "N" or "n":
                    RPassword += RPassword;
                    break;
            }

            switch (UPPERCASE)
            {
                case "Y" or "y":
                    RPassword += Uppercase;
                    break;
                case "N" or "n":
                    RPassword += RPassword;
                    break;
            }

            if (RPassword.Length == 0)
            {
                return "Password creation failed!";
            }


            for (int i = 0; i < Lengthofpassword; i++)
                {
                    password[i] = RPassword[random.Next(RPassword.Length - 1)];
                }
            
            return string.Join(null, password);

        }
    }
} 