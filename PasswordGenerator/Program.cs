using PasswordGenerator;
using System;


RandomPasswordGenerator randomPasswordGenerator = new RandomPasswordGenerator();


Console.WriteLine("\n ****************** PASSWORD GENERATOR ****************** \n");

Console.WriteLine("\nDoes your password contain special characters? (Y/N)");
string SPECIALCHARACTER = Console.ReadLine();

Console.WriteLine("\nDoes your password contain numbers? (Y/N)");
string NUMBERS = Console.ReadLine();

Console.WriteLine("\nDoes your password contain lower letters? (Y/N)");
string LOWERCASE = Console.ReadLine();


Console.WriteLine("\nDoes your password contain UPPER letter? (Y/N)");
string UPPERCASE = Console.ReadLine();


Console.WriteLine("\nHow many characters should your password consist of?");
int Lengthofpassword = Convert.ToInt32(Console.ReadLine());


string result;
result = randomPasswordGenerator.RandomPassword(SPECIALCHARACTER, NUMBERS, LOWERCASE, UPPERCASE, Lengthofpassword);

Console.WriteLine($"\nYour Random Password:\n{result}");
Console.ReadKey();
